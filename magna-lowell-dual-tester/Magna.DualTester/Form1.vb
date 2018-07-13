Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Threading.Tasks
Imports Magna.DualTester.Plc.Core

Imports Magna.DualTester.Core
Imports Ninject
Imports NLog
Imports Magna.DualTester.My.Resources
Imports Magna.DualTester.UI.Views.Calibration
Imports Magna.DualTester.UI.Views.MainView
Imports Magna.DualTester.UI.Views.Setpoints
Imports Magna.DualTester.UI.Views.Settings
Imports Magna.DualTester.TesterApi
Imports Magna.DualTester.Core.Data.Enums

Public Class Form1
    Implements IShell

    Const PrnFile = "PartLabel.prn"
    Private Property _errorDisplayTime As Integer = 1000
    Private Property _errorTimeCount As Integer = 0
    Private Property _currentAlarmColor As Color
    Private Property _currentmessage As EventErrorArgs
    Private ReadOnly _logger As NLog.Logger = LogManager.GetCurrentClassLogger()

    Private _kernel As IKernel
    Private _cfg As ICfgNonDomino
    Private _plc As IPlc
    Private _plcrepo As IPlcFullRepo
    Private _uWatch As IUserWatch
    Private _lWatch As ILanguageWatch
    Private _printServ As IPrint
    Private _messageAlert As IMessageAlertService
    Private _barcodeService As BarcodeService


    'expendable - yellow
    'returnable - green 
    'service 

    Private ReadOnly _cheatlogin() As Keys = {Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.ControlKey, Keys.Enter}
    Private ReadOnly _cheatlogin1() As Keys = {Keys.Shift, Keys.C}

    Private _cheatIndex As Integer = 0
    Private _cheatIndex1 As Integer = 0
    Private Property CurrentView As UserControl
    Private ReadOnly Property CurrentViewTask As IViewTask
        Get
            Return TryCast(CurrentView, IViewTask)
        End Get
    End Property

    Public Sub New()
        _kernel = New Ninject.StandardKernel(New Bindings())
        _kernel.Bind(Of IShell).ToConstant(Me)
        _lWatch = _kernel.Get(Of ILanguageWatch)
        Task.Run(Sub()
                     _cfg = _kernel.Get(Of ICfgNonDomino)
                     _plc = _kernel.Get(Of IPlc)
                     _plcrepo = _kernel.Get(Of IPlcFullRepo)
                     _uWatch = _kernel.Get(Of IUserWatch)
                     _printServ = _kernel.Get(Of IPrint)
                     _messageAlert = _kernel.Get(Of IMessageAlertService)
                 End Sub)
        InitializeComponent()
        Dim _dig = _kernel.Get(Of LoadingDialog)
        _dig.Show(Me)
    End Sub

    Private Async Sub ChangeViews(Of T As {UserControl, IViewTask})(Optional forceuser As Boolean = False)
        TableLayoutPanel1.Enabled = False
        If CurrentView?.GetType() = GetType(ViewCalibration) Then
            _plc.ManualWrite(New SaveEventArgs(Tag_TesterAddress + ".Nest1.ModeRequest", NestModeStatus.Auto))
            _plc.ManualWrite(New SaveEventArgs(Tag_TesterAddress + ".Nest2.ModeRequest", NestModeStatus.Auto))
        End If

        If CurrentViewTask IsNot Nothing Then
            Await CurrentViewTask?.BeginClose()
            If CurrentViewTask?.RunningTask IsNot Nothing Then
                Await CurrentViewTask.RunningTask
            End If
        End If


        If CurrentView?.GetType() IsNot GetType(T) Then
            MainPanel.SuspendLayout()
            MainPanel.Controls.Clear()

            If CurrentView IsNot Nothing Then
                Me.CurrentView.Dispose()
                Me.CurrentView = Nothing
            End If
            Dim newview = _kernel.Get(Of T)
            CurrentView = newview
            CurrentViewTask.Load()
            newview.Dock = DockStyle.Fill
            MainPanel.Controls.Add(CType(CurrentView, Control))
            MainPanel.ResumeLayout()
            If CurrentViewTask?.RunningTask IsNot Nothing Then
                Await CurrentViewTask.RunningTask
            End If
        End If
        TableLayoutPanel1.Enabled = True
    End Sub
    Private Sub UserChanged(user As User)
        Dim run = Sub(usr As User)
                      Dim usrNothing = user Is Nothing
                      TxtUser.Text = If(usrNothing, String.Empty, usr.Username)
                      TxtAccessLvl.Text = If(usrNothing, String.Empty, user.AccessLevel.ToString())
                  End Sub
        If Me.InvokeRequired Then Me.BeginInvoke(run, {user}) Else run(user)
    End Sub

    Private Sub OnPlcChange(tester As Udt_tester)
        Dim run = Sub()
                      Dim service As Boolean = tester.PartInfo.Service
                      BtnService.BackColor = If(Not service, Color.LimeGreen, Color.Yellow)
                      BtnService.Text = If(Not service, "Returnable", "Expendable")
                  End Sub
        If Me.InvokeRequired Then Me.BeginInvoke(run) Else run()

    End Sub

#Region "Events"
#Region "Btn Click events"
    Private Sub TestPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestPrintToolStripMenuItem.Click, RePrintToolStripMenuItem.Click
        If Not _uWatch.CheckCurrentUserPermission(AccessLevel.Supervisor) Then
            _messageAlert.PublishNewAlarm("Must be a supervisor to re-print or test print", ErrorLevel.Alert)
            Return
        End If

        Dim dilg = New ReprintDialog(_cfg)
        dilg.StartPosition = FormStartPosition.CenterParent
        dilg.ShowDialog(Me)
        If dilg.DialogResult <> DialogResult.OK Then
            _messageAlert.PublishNewAlarm("Print canceled", ErrorLevel.Alert)
            Return
        End If
        Dim printer = dilg.SelectedPrinter

        If TestPrintToolStripMenuItem Is sender Then
            _printServ.TestPrint(printer)
        ElseIf RePrintToolStripMenuItem Is sender Then
            _printServ.ReprintPrevious(printer)
        End If
    End Sub


    Private Sub Btn_click(sender As Object, e As EventArgs) Handles BtnSetPoints.Click, BtnAppSettings.Click,
                                                                BtnCalibrate.Click, BtnLogOut.Click, BtnService.Click,
                                                                BtnMain.Click, PrintToolStripMenuItem.Click, BtnDbgLogin.Click,
                                                                BtnScheduleView.Click
        Dim btn As Button = TryCast(sender, Button)
        If btn Is Nothing OrElse Not btn.Visible Then
            Exit Sub
        End If
        If btn Is BtnSetPoints Then
            ChangeViews(Of ViewTesterSetpoints)()
        ElseIf btn Is BtnAppSettings Then
            ChangeViews(Of ApplicationSettingsView)()
        ElseIf btn Is BtnCalibrate Then
            ChangeViews(Of ViewCalibration)()
        ElseIf btn Is BtnLogOut Then
            _uWatch.LogOut()
        ElseIf btn Is BtnMain Then
            ChangeViews(Of ViewMainUserOverView)()
        ElseIf btn Is BtnService Then
            BtnService.Enabled = False
            _plc.ManualWrite(Tag_PartInfo_Servce, CObj(Not _plcrepo.TesterData.PartInfo.Service))
            BtnService.Enabled = True
        ElseIf btn Is BtnDbgLogin Then
            '_formData.loginUser("002489A") ' op
            '_formData.loginUser("102626A") ' sup
            '_formData.loginUser("104002A") ' tech
            _uWatch.DebugLogin(New User() With {.AccessLevel = AccessLevel.Admin, .BadgeNumber = 654321, .ClockNumber = 123456, .Username = "fakename"})
            '_formData.LoginUser("7162") ' eng
            '_formData.loginUser("176823") ' admin
        ElseIf btn Is BtnScheduleView Then
            ChangeViews(Of ViewOrders)()
        End If

    End Sub
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _barcodeService = _kernel.Get(Of BarcodeService)
        _logger.Debug("Application Start")
        Me.Text += Application.ProductVersion
        AddHandler _messageAlert.NewAlert, AddressOf TryDisplayMessage
        If _cfg.ReadConfig() Is Nothing Then
            MessageBox.Show("The configuration file is missing or empty.")
        End If
        AddHandler _uWatch.ValueChanged, AddressOf UserChanged
        AddHandler _plcrepo.TesterContextChanged, AddressOf OnPlcChange



        DisplayTimer(Nothing, EventArgs.Empty)

        If Environment.GetCommandLineArgs.Contains("-setcfg") Then
            ChangeViews(Of ApplicationSettingsView)(True)
        Else
            ChangeViews(Of ViewMainUserOverView)()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '_closeWindowIsUp = True
        Dim result As DialogResult = MessageBox.Show("Do you wish to close?", "Closing", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            _uWatch.LogOut()
            _plc.Dispose()
        Else
            e.Cancel = True
            '_closeWindowIsUp = False
        End If
    End Sub

    Private Sub DisplayTimer(sender As Object, e As EventArgs) Handles TimerDisplayShift.Tick
        Const secondsADay = 86400 - 1

        Dim now = DateTime.Now()
        Dim currentShift As String = "Invalid shift cfg"
        Dim currentShiftInt As Integer = -1
        Dim c = _cfg.ReadConfig()
        Dim shift1 = c.ShiftSetup1StStart
        Dim shift2 = c.ShiftSetup2NdStart
        Dim shift3 = c.ShiftSetup3RdStart

        Dim Between = Function(val As Integer, low As Integer, high As Integer)
                          Return (val >= low AndAlso val < high)
                      End Function

        Dim time = CInt(New TimeSpan(0, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, 0).TotalMinutes)

        Dim shiftOffset = If(shift3 < shift1, secondsADay, 0)

        If Between(time, shift2, shift3 + shiftOffset) OrElse Between(time, 0, shift3) Then
            currentShiftInt = 2
            currentShift = "2nd"
        ElseIf Between(time, shift1, shift2) Then
            currentShiftInt = 1
            currentShift = "1st"
        ElseIf Between(time, shift3, shift1) Then
            currentShiftInt = 3
            currentShift = "3rd"
        End If
        If _plcrepo.TesterData IsNot Nothing AndAlso _plcrepo.TesterData.ShiftValue <> currentShiftInt Then
            _plc.ManualWrite(Tag_Shift_Value, currentShiftInt)
        End If
        'End If
        LblTime.Text = String.Format("{0}{3}{1}{2}{3}", currentShift, vbNewLine, now.ToString("HH:mm"), vbTab)
    End Sub
    Private Sub Language_CheckedChanged(sender As Object, e As EventArgs) Handles RadEnglish.CheckedChanged, RadSpanish.CheckedChanged
        _lWatch.SetValue = If(RadEnglish.Checked, LanguageEnum.English, LanguageEnum.Spanish)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.Alt AndAlso e.KeyCode = _cheatlogin(_cheatIndex) Then
            _cheatIndex += 1
            If _cheatIndex = _cheatlogin.Length() Then
                Dim dilg = New DialogGetStr()
                If dilg.ShowDialog(Me) = DialogResult.OK Then
                    _uWatch.LogIn(dilg.Value.ToString())
                End If
                _cheatIndex = 0
            End If
        Else
            _cheatIndex = 0
        End If
        If e.Control And e.Shift AndAlso CBool(Keys.C) Then
            _uWatch.LogIn("123456") ' admin quick cheat for tester repair
        End If

    End Sub
#End Region

#Region "Error Display"
    Private Sub TryDisplayMessage()

        If _currentmessage Is Nothing AndAlso Not LabelDim.Enabled AndAlso _messageAlert.Errors.Any() Then
            _currentmessage = _messageAlert.Errors.Dequeue()
            Dim run = Sub()
                          _errorDisplayTime = If(_currentmessage.Seconds >= 1, _currentmessage.Seconds * 1000, 1000)
                          LblError.Text = _currentmessage.Message
                          Dim setColor As Color
                          Select Case _currentmessage.AlertLevel
                              Case ErrorLevel.Alert
                                  setColor = Color.Yellow
                              Case ErrorLevel.Error
                                  setColor = Color.Red
                              Case ErrorLevel.Message
                                  setColor = Color.Green
                          End Select
                          LblError.BackColor = setColor
                          _currentAlarmColor = setColor
                          LabelDim.Start()
                      End Sub
            If Me.InvokeRequired Then Me.BeginInvoke(run) Else run()
        End If
    End Sub

    Private Sub LabelDim_Tick(sender As Object, e As EventArgs) Handles LabelDim.Tick
        _errorTimeCount += LabelDim.Interval

        Dim red = SetColor(SystemColors.Control.R, _currentAlarmColor.R, _errorDisplayTime, _errorTimeCount)
        Dim green = SetColor(SystemColors.Control.G, _currentAlarmColor.G, _errorDisplayTime, _errorTimeCount)
        Dim blue = SetColor(SystemColors.Control.B, _currentAlarmColor.B, _errorDisplayTime, _errorTimeCount)

        LblError.BackColor = Color.FromArgb(255, red, green, blue)
        If _errorTimeCount >= _errorDisplayTime Then
            LblError.BackColor = SystemColors.Control
            LblError.Text = String.Empty
            LabelDim.Stop()
            _errorTimeCount = 0
            _currentmessage = Nothing
            TryDisplayMessage()
        End If
    End Sub
    Private Shared Function SetColor(ToColorChannel As Byte, fromColorChannel As Byte, displayTime As Integer, timeDisplayed As Integer) As Integer
        Dim diff = (CInt(ToColorChannel) - CInt(fromColorChannel))
        Dim diffPerTimeIncrement = (diff / displayTime)
        Dim final As Integer = CInt((diffPerTimeIncrement * timeDisplayed) + fromColorChannel)
        If final > 255 Then
            Debug.Print($"Diff:{diff} , DiffPerTime:{diffPerTimeIncrement}, Final:{final}")
        End If
        Return If(final > 255, 255, final)
    End Function

    Public Function LaunchDialog(Of T As Form)() As T Implements IShell.LaunchDialog
        If Me.InvokeRequired Then
            Dim d = DirectCast(Me.Invoke(Function() LaunchDialog(Of T)()), T)
            Return d
        End If

        Dim dilg = _kernel.Get(Of T)
        dilg.Show()
        Return dilg
    End Function


#End Region
End Class

