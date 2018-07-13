Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Collections.ObjectModel
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data
Imports System.Collections.Specialized
Imports Magna.DualTester.JobSchedulerService
Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Magna.DualTester.SchedulerServiceReference

Namespace UI.Views.Settings.SubViews

    ''' <summary>
    ''' This is one of the views that edits the config file for this application.
    ''' </summary>
    Public Class ViewShiftSetup
        Implements IView(Of ViewShiftSetupViewModel)
        Implements ISaveView(Of NonDominoCfg)


        Private ReadOnly _lines As BindingList(Of LineModel) = New BindingList(Of LineModel)()

        Dim vm As ViewShiftSetupViewModel
        Private _scheduleServiceFactory As ScheduleServiceFactory
        Private ReadOnly _prnFileRepo As New PrnFileRepo
        ''' <summary>
        ''' holds a list of active com ports on this computer. Is bound to a list box for users to select.
        ''' </summary>
        Private ReadOnly _coms1 As New List(Of String)
        'Private ReadOnly _coms2 As New List(Of String)

        Private ReadOnly _printCfgs As New BindingList(Of PrintCfg)

        Public Sub New()
            'MyBase.New(AccessLevel.Engineer)
            InitializeComponent()
            AddHandler _lines.ListChanged, AddressOf OnLinesChanged
            LineModelBindingSource.DataSource = _lines
            PrintCfgBindingSource.DataSource = _printCfgs
            ComPort.DataSource = My.Computer.Ports.SerialPortNames.ToList()
            PrnFileDataGridViewTextBoxColumn.DataSource = _prnFileRepo.GetPrnFiles().ToList()
        End Sub

        Private Sub OnLinesChanged(sender As Object, e As ListChangedEventArgs)
            ComboLines.Enabled = _lines.Any()
            If Not _lines.Any Then
                ComboLines.SelectedIndex = -1
            End If
        End Sub

        Public Sub AddDependencies(scheduleServiceFactory As ScheduleServiceFactory)
            _scheduleServiceFactory = scheduleServiceFactory
        End Sub

        Private Sub ShiftSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load, ErrorProvider1.RightToLeftChanged
            _coms1.AddRange(My.Computer.Ports.SerialPortNames)
            '_coms2.AddRange(My.Computer.Ports.SerialPortNames)
            ComboBarCodeScannerCom.DataSource = _coms1
            'ComboPartLabelCom.DataSource = _coms2
        End Sub





        ''' <summary>
        ''' Used by the <c>SaveConfig</c> function to see if input strings are correct. And to highlight problem textboxes.
        ''' Incorrect strings are nulled out and returned thru their reference.
        ''' </summary>
        ''' <param name="txtbox">Handing this in allows the highlighting of incorrect inputs</param>
        ''' <param name="regex">This is the pattern the string will be checked against</param>
        ''' <param name="str">This is the string to be checked. This is a reference, the string can be modified so it should be used as the final output.</param>
        ''' <returns>-1 implies the string is blank. 0 implies the string is wrong. 1 implies the string is good.</returns>
        Private Function Check(txtbox As TextBox, regex As Regex, ByRef str As String) As Integer
            Dim match As Match = regex.Match(str)
            Dim val As Integer

            If txtbox.Enabled Then

                If IsNothing(str) OrElse str = String.Empty Then
                    txtbox.BackColor = Color.Yellow
                    val = -1
                ElseIf Not match.Success Then
                    txtbox.BackColor = Color.Red
                    val = 0
                Else
                    val = 1
                    txtbox.BackColor = SystemColors.Window
                End If
                str = match.Value
            Else
                val = 1
                txtbox.BackColor = SystemColors.Window
                str = String.Empty
            End If
            Return val
        End Function

        'Private Sub BtnFileDialog_Click(sender As Object, e As EventArgs)
        '    SaveFileDialog1.InitialDirectory = Application.StartupPath
        '    If SaveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
        '        vm.Cfg.AutoLabelRequestPath = SaveFileDialog1.FileName
        '        TxtLabelRequestPath.Text = SaveFileDialog1.FileName
        '    End If
        'End Sub

        ' <summary>
        ' This function checks to see if the text entered is a valid file directory every time focus is lost.
        ' If its not the textbox is turned yellow.
        ' </summary>
        'Private Sub TxtLabelRequestPath_TextChanged(sender As Object, e As EventArgs)
        '    If TxtLabelRequestPath.Text <> String.Empty Then
        '        Dim lblPath = Path.GetDirectoryName(TxtLabelRequestPath.Text)
        '        TxtLabelRequestPath.BackColor = If(Directory.Exists(lblPath), Color.LimeGreen, Color.Yellow)
        '    Else
        '        TxtLabelRequestPath.BackColor = Color.Salmon
        '    End If
        'End Sub


        Public Sub UpdateViewModel(data As ViewShiftSetupViewModel) Implements IView(Of ViewShiftSetupViewModel).UpdateViewModel
            If InvokeRequired Then
                Invoke(Sub() UpdateViewModel(data))
                Return
            End If
            vm = data
            If Not Me.DesignMode Then
                Dim cfg = data.Cfg
                If cfg IsNot Nothing Then
                    'TxtName.Text = cfg.IdName
                    'TxtAssetNumber.Text = cfg.IdAssetNumber



                    TrackShift1.Value = If(cfg.ShiftSetup1StStart > 1439, 1439, If(cfg.ShiftSetup1StStart < 0, 0, cfg.ShiftSetup1StStart))
                    TrackShift2.Value = If(cfg.ShiftSetup2NdStart > 1439, 1439, If(cfg.ShiftSetup2NdStart < 0, 0, cfg.ShiftSetup2NdStart))
                    TrackShift3.Value = If(cfg.ShiftSetup3RdStart > 1439, 1439, If(cfg.ShiftSetup3RdStart < 0, 0, cfg.ShiftSetup3RdStart))

                    TrackBar1_ValueChanged(Nothing, EventArgs.Empty)
                    ComboBarCodeScannerCom.Text = cfg.DeviceBarcodeScannerPort
                    'ComboPartLabelCom.Text = cfg.DevicePartLabelPort
                    TxtPlcIp.Text = cfg.DevicePlcIp
                    'TxtLabelRequestPath.Text = cfg.AutoLabelRequestPath
                    'TxtPrinterId.Text = cfg.ToteLabelPrinterId
                    'ChkAutoTote.Checked = cfg.AutoToteLabel
                    'TxtLabelRequestPath.Text = cfg.AutoLabelRequestPath
                    TxtServiceUrl.Text = cfg.JobSchedularServiceAddress
                    ComboLines.SelectedValue = cfg.LineId
                    _printCfgs.Clear()
                    cfg.Printers.ForEach(Sub(x) _printCfgs.Add(x))
                    CheckWcfService()
                Else
                    Throw New Exception("cfg error")
                End If
            End If
        End Sub

        Public Function Save() As NonDominoCfg Implements ISaveView(Of NonDominoCfg).Save
            Dim _cfg = vm.Cfg


            '*********************Id info***********************
            '_cfg.IdName = TxtName.Text
            '_cfg.IdAssetNumber = TxtAssetNumber.Text

            '*********************shift times***********************
            Dim regexTime As Regex = New Regex("(\d{1,2}):(\d{2})")
            Dim timeMatch1 As Integer = Check(Txt1stStart, regexTime, Txt1stStart.Text)
            Dim timeMatch2 As Integer = Check(Txt2ndStart, regexTime, Txt2ndStart.Text)
            Dim timeMatch3 As Integer = Check(Txt3rdStart, regexTime, Txt3rdStart.Text)
            If timeMatch1 = 0 OrElse timeMatch2 = 0 OrElse timeMatch3 = 0 Then
                MessageBox.Show("The shift times must be in the format of ##:## or #:##")
            End If
            _cfg.ShiftSetup1StStart = TrackShift1.Value
            _cfg.ShiftSetup2NdStart = TrackShift2.Value
            _cfg.ShiftSetup3RdStart = TrackShift3.Value

            'ComboPartLabelCom.BackColor = SystemColors.Control
            ComboBarCodeScannerCom.BackColor = SystemColors.Control
            '*********************ports***********************
            'If ComboBarCodeScannerCom.Text = ComboPartLabelCom.Text Then
            '    If MsgBox("The Selected COM ports have the same name. Do you want this? (This can cause strange errors)", MsgBoxStyle.YesNo, "Same Port") = MsgBoxResult.No Then
            '        ComboBarCodeScannerCom.Text = String.Empty
            '        ComboPartLabelCom.Text = String.Empty
            '    End If
            'End If
            If ComboBarCodeScannerCom.Text = String.Empty OrElse My.Computer.Ports.SerialPortNames.SingleOrDefault(Function(x) x = ComboBarCodeScannerCom.Text) Is Nothing Then
                If MsgBox(String.Format("The Selected port {0} does not seem to exist do you wish to use it? (Barcode Scanner may be unusable)", ComboBarCodeScannerCom.Text), MsgBoxStyle.YesNo, "Missing port") = MsgBoxResult.No Then
                    ComboBarCodeScannerCom.BackColor = Color.PaleVioletRed
                    ComboBarCodeScannerCom.Text = String.Empty
                End If
            End If
            'If ComboPartLabelCom.Text = String.Empty OrElse My.Computer.Ports.SerialPortNames.SingleOrDefault(Function(x) x = ComboPartLabelCom.Text) Is Nothing Then
            '    If MsgBox(String.Format("The Selected port {0} does not seem to exist do you wish to use it? (label printer my be unusable)", ComboPartLabelCom.Text), MsgBoxStyle.YesNo, "Missing port") = MsgBoxResult.No Then
            '        ComboPartLabelCom.BackColor = Color.PaleVioletRed
            '        ComboPartLabelCom.Text = String.Empty
            '    End If
            'End If

            _cfg.DeviceBarcodeScannerPort = ComboBarCodeScannerCom.Text
            '_cfg.DevicePartLabelPort = ComboPartLabelCom.Text

            '**********************ip addresses**********************
            Dim regexIp As Regex = New Regex("\b(?:\d{1,3}\.){3}\d{1,3}\b")
            Dim match1 As Integer = Check(TxtPlcIp, regexIp, TxtPlcIp.Text)

            If match1 = 0 Then
                MessageBox.Show("The IpAddresses must be in the format of ###.###.###.###")
            End If
            _cfg.DevicePlcIp = TxtPlcIp.Text

            '***********************auto label*********************
            'If Not IO.Directory.Exists(TxtLabelRequestPath.Text) Then
            '    If MsgBox("The entered file path does not exist do you wish to use it?", MsgBoxStyle.YesNo, "Missing path") = MsgBoxResult.No Then
            '        TxtLabelRequestPath.Text = String.Empty
            '    End If
            'End If
            '_cfg.AutoLabelRequestPath = TxtLabelRequestPath.Text
            '_cfg.ToteLabelPrinterId = TxtPrinterId.Text
            '_cfg.AutoToteLabel = ChkAutoTote.Checked
            '***********************job scheduler******************
            _cfg.LineId = CInt(ComboLines.SelectedValue)
            _cfg.JobSchedularServiceAddress = TxtServiceUrl.Text
            '***********************printer cfgs*******************

            _cfg.Printers.Clear()
            _cfg.Printers.AddRange(_printCfgs)

            '*******************Save*******************************
            Return _cfg
        End Function

        Private Sub BtnTestUrl_Click(sender As Object, e As EventArgs) Handles BtnTestUrl.Click
            CheckWcfService()
        End Sub
        Private Async Sub CheckWcfService()
            BtnTestUrl.Enabled = False
            TxtServiceUrl.Enabled = False

            Dim commException = False
            Dim tmplines As GetLinesResponse = Nothing
            Try
                Using srv = _scheduleServiceFactory.GetInstance(TxtServiceUrl.Text)
                    tmplines = Await srv.GetLinesAsync()
                End Using
                If tmplines.Result = 1 Then
                    _lines.Clear()
                    For Each line In tmplines.Lines.Select(Function(x) New LineModel(x))
                        _lines.Add(line)
                    Next
                End If
            Catch ex As Exception
                commException = True
            Finally
            End Try

            Dim updateui = Sub()
                               ComboLines.SelectedValue = vm.Cfg.LineId
                               LblServiceError.BackColor = If(tmplines Is Nothing OrElse tmplines.Result = -1, Color.PaleVioletRed, Color.Transparent)
                               LblServiceError.Text = If(commException, "Invalid wcf address. Acceptable format example -> http://localhost:8045", tmplines?.ResultString)
                               BtnTestUrl.BackColor = If(commException, Color.PaleVioletRed, Color.PaleGreen)
                               TxtServiceUrl.Enabled = True
                               BtnTestUrl.Enabled = True
                           End Sub
            If Me.InvokeRequired Then
                Invoke(updateui)
            Else
                updateui()
            End If
        End Sub



        Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackShift3.ValueChanged, TrackShift2.ValueChanged, TrackShift1.ValueChanged
            Dim shift1 = TrackShift1.Value
            Dim shift2 = TrackShift2.Value
            Dim shift3 = TrackShift3.Value

            TlpShiftSetup.BackColor = If(shift1 < shift2 AndAlso shift2 < shift3 OrElse shift3 < shift1 AndAlso shift1 < shift2, Color.PaleGreen, Color.PaleVioletRed)
            Txt1stStart.Text = TimeSpan.FromMinutes(TrackShift1.Value).ToString()
            Txt2ndStart.Text = TimeSpan.FromMinutes(TrackShift2.Value).ToString()
            Txt3rdStart.Text = TimeSpan.FromMinutes(TrackShift3.Value).ToString()
        End Sub
    End Class
End Namespace