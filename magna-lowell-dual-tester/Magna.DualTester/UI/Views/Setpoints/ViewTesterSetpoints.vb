Imports Magna.DualTester.TesterApi
Imports System.Threading.Tasks
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums

Namespace UI.Views.Setpoints
    Public Class ViewTesterSetpoints
        Implements IViewTask



        Private _setpoints As Udt_Setpoints
        ReadOnly _minmaxCells As New Dictionary(Of String, MinMaxCells)()

        Private ReadOnly _msgsvc As IMessageAlertService
        Private ReadOnly _userWatch As IUserWatch
        Private ReadOnly _plc As IPlc
        Private ReadOnly _plcrepo As IPlcFullRepo

        Public Property RunningTask As Task Implements IViewTask.RunningTask

#Region "Constants"
        Private Const ActuatorAmps As String = "ActuatorAmps"
        Private Const ActuatorRate As String = "ActuatorRate"
        Private Const Defog_Inrush As String = "Defog_Inrush"
        Private Const defogAmps As String = "defogAmps"
        Private Const Gi_Amps As String = "Gi_Amps"
        Private Const LogoLamp_Amps As String = "LogoLamp_Amps"
        Private Const Ts_Amps As String = "Ts_Amps"
        Private Const Bzi_Amps As String = "Bzi_Amps"
        Private Const Pfold_Amps As String = "Pfold_Amps"
        Private Const Pfold_TravTime As String = "Pfold_TravTime"
        Private Const MemoryVoltsPerDeg As String = "MemoryVoltsPerDeg"
        Private Const EcAmps As String = "EcAmps"
        Private Const Cargo_Lamp_Amps As String = "Cargo_Lamp_Amps"
        Private Const Oats_Amps As String = "Oats_Amps"
        Private Const PowerExt_Amps As String = "PowerExt_Amps"
        Private Const PowerExt_TravTime As String = "PowerExt_TravTime"
        Private Const Camera_Amps As String = "Camera_Amps"
        Private Const Gps_Amps As String = "Gps_Amps"
        Private Const Ca_Amps As String = "Ca_Amps"

        Private Const UpAngle = "UpAngle"
        Private Const MemAtUp = "MemAtUp"
        Private Const DwnAngle = "DwnAngle"
        Private Const MemAtDwn = "MemAtDwn"
        Private Const InBoardAngle = "InBoardAngle"
        Private Const MemAtInBoard = "MemAtInBoard"
        Private Const OutBoardAngle = "OutBoardAngle"
        Private Const MemAtOutBoard = "MemAtOutBoard"
#End Region


        Public Sub New(userWatch As IUserWatch, plc As IPlc, plcrepo As IPlcFullRepo, msgsvc As IMessageAlertService)
            _plc = plc
            _plcrepo = plcrepo
            _userWatch = userWatch
            _msgsvc = msgsvc
            NewUser(_userWatch.CurrentValue)
            AddHandler _userWatch.ValueChanged, AddressOf NewUser
            InitializeComponent()
        End Sub

#Region "Set tables"
        Private Sub SetTableSizes()
            Dim rightGridWidth = RightGrid.Width - 2
            RightGrid.Column(0).AutoFit()
            RightGrid.Column(3).AutoFit()
            Dim finalRightWidth = rightGridWidth - RightGrid.Column(0).Width - RightGrid.Column(3).Width
            RightGrid.Column(1).Width = CShort(finalRightWidth * (1 / 3))
            RightGrid.Column(2).Width = CShort(finalRightWidth * (1 / 3))
            RightGrid.Column(3).Width = CShort(finalRightWidth * (1 / 3))
            'RightGrid.Column(4).Width = CShort(rightGridWidth * 0.25)

            Dim gridWidth = LeftGrid.Width - 2
            LeftGrid.Column(0).AutoFit() '.Width = 160 'CShort(gridWidth * (0.2))
            LeftGrid.Column(5).AutoFit()
            Dim finalLeftWidth = gridWidth - LeftGrid.Column(0).Width - LeftGrid.Column(5).Width
            LeftGrid.Column(1).Width = CShort(finalLeftWidth * (0.25))
            LeftGrid.Column(2).Width = CShort(finalLeftWidth * (0.25))
            LeftGrid.Column(3).Width = CShort(finalLeftWidth * (0.25))
            LeftGrid.Column(4).Width = CShort(finalLeftWidth * (0.25))
        End Sub
        Private Sub SetRightTable()
            Dim amp = "Amps"
            Dim degSec = "Deg/Sec"
            Dim sec = "Sec"
            'Dim propsMotion = GetType(Udt_Setpoints).GetFields().Where(Function(x) Not MemoryTargets.Union(MotionTargets).Contains(x.Name))
            Dim maxRow = 19
            RightGrid.Cols = 4
            RightGrid.Rows = maxRow + 1
            RightGrid.ExtendLastCol = True
            RightGrid.HorizontalScroll.Enabled = False
            RightGrid.Range(1, 3, maxRow, 3).Locked = True
            Dim twoCenterColumns = RightGrid.Range(1, 1, maxRow, 2)
            twoCenterColumns.Borders(FlexCell.EdgeEnum.Inside Or FlexCell.EdgeEnum.Outside) = FlexCell.LineStyleEnum.Thin
            twoCenterColumns.BackColor = Color.Black
            twoCenterColumns.ForeColor = Color.White
            twoCenterColumns.Mask = FlexCell.MaskEnum.Numeric
            RightGrid.Column(2).DecimalLength = 2
            RightGrid.Column(3).DecimalLength = 2
            RightGrid.Column(1).Alignment = FlexCell.AlignmentEnum.RightGeneral
            RightGrid.Cell(0, 1).Text = "Min"
            RightGrid.Cell(0, 2).Text = "Max"


            Dim setcells = Sub(row As Integer, col As Integer, measurementType As String, title As String)
                               RightGrid.Cell(row, col).Text = title
                               Dim mincell = RightGrid.Cell(row, col + 1)
                               Dim maxcell = RightGrid.Cell(row, col + 2)
                               mincell.Alignment = FlexCell.AlignmentEnum.RightCenter
                               maxcell.Alignment = FlexCell.AlignmentEnum.RightCenter
                               _minmaxCells.Add(title, New MinMaxCells(mincell, maxcell))
                               RightGrid.Cell(row, col + 3).Text = measurementType
                           End Sub

            setcells(1, 0, amp, ActuatorAmps)
            setcells(2, 0, amp, ActuatorRate)
            setcells(3, 0, amp, Defog_Inrush)
            setcells(4, 0, amp, defogAmps)
            setcells(5, 0, amp, Gi_Amps)
            setcells(6, 0, amp, LogoLamp_Amps)
            setcells(7, 0, amp, Ts_Amps)
            setcells(8, 0, amp, Bzi_Amps)
            setcells(9, 0, amp, Pfold_Amps)
            setcells(10, 0, amp, Pfold_TravTime)
            setcells(11, 0, amp, MemoryVoltsPerDeg)
            setcells(12, 0, amp, EcAmps)
            setcells(13, 0, amp, Cargo_Lamp_Amps)
            setcells(14, 0, amp, Oats_Amps)
            setcells(15, 0, amp, PowerExt_Amps)
            setcells(16, 0, amp, PowerExt_TravTime)
            setcells(17, 0, amp, Camera_Amps)
            setcells(18, 0, amp, Gps_Amps)
            setcells(19, 0, amp, Ca_Amps)

        End Sub

        Private Sub SetTargetsTable()

            LeftGrid.Cols = 6
            LeftGrid.Rows = 5
            LeftGrid.ExtendLastCol = True
            LeftGrid.Range(1, 5, 3, 5).Locked = True

            Dim numberFields = LeftGrid.Range(1, 1, 4, 4)
            numberFields.Borders(FlexCell.EdgeEnum.Inside Or FlexCell.EdgeEnum.Outside) = FlexCell.LineStyleEnum.Thin
            numberFields.BackColor = Color.Black
            numberFields.ForeColor = Color.White
            numberFields.Mask = FlexCell.MaskEnum.Numeric
            numberFields.Alignment = FlexCell.AlignmentEnum.CenterGeneral
            LeftGrid.Column(2).DecimalLength = 2
            LeftGrid.Column(3).DecimalLength = 2
            LeftGrid.Column(4).DecimalLength = 2
            LeftGrid.Column(5).DecimalLength = 2



            LeftGrid.Cell(1, 0).Text = "Motion Targets Min"
            LeftGrid.Cell(2, 0).Text = "Motion Targets Max"
            LeftGrid.Cell(3, 0).Text = "Memory Range Min"
            LeftGrid.Cell(4, 0).Text = "Memory Range Max"

            Dim setCells = Sub(header As String, angle As String, mem As String, col As Integer)
                               LeftGrid.Cell(0, col).Text = header
                               _minmaxCells.Add(angle, New MinMaxCells(LeftGrid.Cell(1, col), LeftGrid.Cell(2, col)))
                               _minmaxCells.Add(mem, New MinMaxCells(LeftGrid.Cell(3, col), LeftGrid.Cell(4, col)))
                           End Sub


            setCells("Up", UpAngle, MemAtUp, 1)
            setCells("Down", DwnAngle, MemAtDwn, 2)
            setCells("InBoard", InBoardAngle, MemAtInBoard, 3)
            setCells("OutBoard", OutBoardAngle, MemAtOutBoard, 4)
            LeftGrid.Cell(1, 5).Text = "Deg."
            LeftGrid.Cell(2, 5).Text = "Deg."
            LeftGrid.Cell(3, 5).Text = "Volts/Deg"
            LeftGrid.Cell(4, 5).Text = "Volts/Deg"
        End Sub
#End Region



        Private Sub RaiseSaved(address As String, obj As Object, Optional msg As String = "")
            _plc.ManualWrite(address, obj, message:=msg)
        End Sub
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            _setpoints.UpAngle = _minmaxCells(UpAngle).ToUdtMinMax()
            _setpoints.DwnAngle = _minmaxCells(DwnAngle).ToUdtMinMax()
            _setpoints.InBoardAngle = _minmaxCells(InBoardAngle).ToUdtMinMax()
            _setpoints.OutBoardAngle = _minmaxCells(OutBoardAngle).ToUdtMinMax()
            _setpoints.MemAtUp = _minmaxCells(MemAtUp).ToUdtMinMax()
            _setpoints.MemAtDwn = _minmaxCells(MemAtDwn).ToUdtMinMax()
            _setpoints.MemAtInBoard = _minmaxCells(MemAtInBoard).ToUdtMinMax()
            _setpoints.MemAtOutBoard = _minmaxCells(MemAtOutBoard).ToUdtMinMax()

            _setpoints.ActuatorAmps = _minmaxCells(ActuatorAmps).ToUdtMinMax()
            _setpoints.ActuatorRate = _minmaxCells(ActuatorRate).ToUdtMinMax()
            _setpoints.Defog_Inrush = _minmaxCells(Defog_Inrush).ToUdtMinMax()
            _setpoints.defogAmps = _minmaxCells(defogAmps).ToUdtMinMax()
            _setpoints.Gi_Amps = _minmaxCells(Gi_Amps).ToUdtMinMax()
            _setpoints.LogoLamp_Amps = _minmaxCells(LogoLamp_Amps).ToUdtMinMax()
            _setpoints.Ts_Amps = _minmaxCells(Ts_Amps).ToUdtMinMax()
            _setpoints.Bzi_Amps = _minmaxCells(Bzi_Amps).ToUdtMinMax()
            _setpoints.Pfold_Amps = _minmaxCells(Pfold_Amps).ToUdtMinMax()
            _setpoints.Pfold_TravTime = _minmaxCells(Pfold_TravTime).ToUdtMinMax()
            _setpoints.MemoryVoltsPerDeg = _minmaxCells(MemoryVoltsPerDeg).ToUdtMinMax()
            _setpoints.EcAmps = _minmaxCells(EcAmps).ToUdtMinMax()
            _setpoints.Cargo_Lamp_Amps = _minmaxCells(Cargo_Lamp_Amps).ToUdtMinMax()
            _setpoints.Oats_Amps = _minmaxCells(Oats_Amps).ToUdtMinMax()
            _setpoints.PowerExt_Amps = _minmaxCells(PowerExt_Amps).ToUdtMinMax()
            _setpoints.PowerExt_TravTime = _minmaxCells(PowerExt_TravTime).ToUdtMinMax()
            _setpoints.Camera_Amps = _minmaxCells(Camera_Amps).ToUdtMinMax()
            _setpoints.Gps_Amps = _minmaxCells(Gps_Amps).ToUdtMinMax()
            _setpoints.Ca_Amps = _minmaxCells(Ca_Amps).ToUdtMinMax()

            Me.RaiseSaved(My.Resources.Tag_SetPoints, _setpoints)
            Me.RaiseSaved(My.Resources.Tag_Log_Setpoint_Change_Trigger, 1)
            _msgsvc.PublishNewAlarm("Setpoints Saved", ErrorLevel.Message)
        End Sub
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
            RemoveHandler _userWatch.ValueChanged, AddressOf NewUser
        End Sub

        Private Sub NewUser(user As User)
            Me.Enabled = _userWatch.CheckCurrentUserPermission(AccessLevel.Engineer)
        End Sub

        Public Function BeginClose() As Task Implements IViewTask.BeginClose
            RemoveHandler _userWatch.ValueChanged, AddressOf NewUser
            Return Task.CompletedTask
        End Function

#Region "Loading"

        Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
            BtnLoad.Enabled = False
            LoadData(_plcrepo.TesterData)

            _msgsvc.PublishNewAlarm("Setpoints Loaded From PLC", ErrorLevel.Message)
            BtnLoad.Enabled = True
        End Sub


        Private Sub LoadData(data As Udt_tester)
            If InvokeRequired Then
                Invoke(Sub() LoadData(data))
                Return
            End If
            If _minmaxCells.Count > 8 Then
                _setpoints = data.SetPoints
                If _setpoints IsNot Nothing Then
                    _minmaxCells(ActuatorAmps).SetValues(_setpoints.ActuatorAmps)
                    _minmaxCells(ActuatorRate).SetValues(_setpoints.ActuatorRate)
                    _minmaxCells(UpAngle).SetValues(_setpoints.UpAngle)
                    _minmaxCells(DwnAngle).SetValues(_setpoints.DwnAngle)
                    _minmaxCells(InBoardAngle).SetValues(_setpoints.InBoardAngle)
                    _minmaxCells(OutBoardAngle).SetValues(_setpoints.OutBoardAngle)
                    _minmaxCells(MemAtUp).SetValues(_setpoints.MemAtUp)
                    _minmaxCells(MemAtDwn).SetValues(_setpoints.MemAtDwn)
                    _minmaxCells(MemAtInBoard).SetValues(_setpoints.MemAtInBoard)
                    _minmaxCells(MemAtOutBoard).SetValues(_setpoints.MemAtOutBoard)
                    _minmaxCells(Defog_Inrush).SetValues(_setpoints.Defog_Inrush)
                    _minmaxCells(defogAmps).SetValues(_setpoints.defogAmps)
                    _minmaxCells(Gi_Amps).SetValues(_setpoints.Gi_Amps)
                    _minmaxCells(LogoLamp_Amps).SetValues(_setpoints.LogoLamp_Amps)
                    _minmaxCells(Ts_Amps).SetValues(_setpoints.Ts_Amps)
                    _minmaxCells(Bzi_Amps).SetValues(_setpoints.Bzi_Amps)
                    _minmaxCells(Pfold_Amps).SetValues(_setpoints.Pfold_Amps)
                    _minmaxCells(Pfold_TravTime).SetValues(_setpoints.Pfold_TravTime)
                    _minmaxCells(MemoryVoltsPerDeg).SetValues(_setpoints.MemoryVoltsPerDeg)
                    _minmaxCells(EcAmps).SetValues(_setpoints.EcAmps)
                    _minmaxCells(Cargo_Lamp_Amps).SetValues(_setpoints.Cargo_Lamp_Amps)
                    _minmaxCells(Oats_Amps).SetValues(_setpoints.Oats_Amps)
                    _minmaxCells(PowerExt_Amps).SetValues(_setpoints.PowerExt_Amps)
                    _minmaxCells(PowerExt_TravTime).SetValues(_setpoints.PowerExt_TravTime)
                    _minmaxCells(Camera_Amps).SetValues(_setpoints.Camera_Amps)
                    _minmaxCells(Gps_Amps).SetValues(_setpoints.Gps_Amps)
                    _minmaxCells(Ca_Amps).SetValues(_setpoints.Ca_Amps)
                End If
            End If
            _msgsvc.PublishNewAlarm("Setpoints Loaded From PLC", ErrorLevel.Message)
        End Sub

        Private Sub IViewTask_Load() Implements IViewTask.Load
            SetRightTable()
            SetTargetsTable()
            LoadData(_plcrepo.TesterData)
        End Sub

        Private Sub TableLayoutPanel1_Resize(sender As Object, e As EventArgs) Handles TableLayoutPanel1.Resize
            SetTableSizes()
        End Sub
#End Region
    End Class

    Friend Class MinMaxCells
        Public Sub New(min As FlexCell.Cell)
            If min Is Nothing Then
                Throw New ArgumentNullException()
            End If
            _minCell = min
            _maxCell = Nothing
        End Sub
        Public Sub New(min As FlexCell.Cell, max As FlexCell.Cell)
            If min Is Nothing Or max Is Nothing Then
                Throw New ArgumentNullException()
            End If
            _minCell = min
            _maxCell = max
        End Sub
        Public Sub SetValues(udtmm As Udt_MinMax)
            If _maxCell IsNot Nothing Then
                Me._maxCell.Text = udtmm.Max.ToString()
            End If
            Me._minCell.Text = udtmm.Min.ToString()
        End Sub

        Public ReadOnly Property ToUdtMinMax As Udt_MinMax
            Get
                Return New Udt_MinMax() With {.Max = If(IsNothing(_maxCell), 0, _maxCell.SingleValue), .Min = _minCell.SingleValue}
            End Get
        End Property

        Private ReadOnly _maxCell As FlexCell.Cell
        Private ReadOnly _minCell As FlexCell.Cell
    End Class
End Namespace