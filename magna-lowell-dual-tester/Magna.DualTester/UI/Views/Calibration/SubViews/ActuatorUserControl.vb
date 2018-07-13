Imports Magna.DualTester.My.Resources
Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core

Namespace UI.Views.Calibration.SubViews

    Public Class ActuatorUserControl
        Implements IView(Of ActuatorViewModel)

        Const CargoLamp = "CargoLamp"
        Const CameraItems = "CameraItems"
        Const MirrrorActuator = "MirrrorActuator"
        Const Pfold = "Pfold"

        Const Ec = "EC"
        Const Gi = "Gi"
        Const Oats = "OATS"
        Private vm As ActuatorViewModel
        Private _plc As IPlc
        Public WriteOnly Property SetPlc As IPlc
            Set(value As IPlc)
                _plc = value
            End Set
        End Property

        Private ReadOnly _actuatorButtons As New List(Of Button)

        'Public Sub New()
        '    'MyBase.New(AccessLevel.Operator)
        '    InitializeComponent()
        'End Sub

#Region "Actuator Control"
        Private Sub BtnUp_MouseDown(sender As Object, e As EventArgs) Handles BtnUp.MouseDown, BtnIB.MouseDown, BtnOB.MouseDown, BtnCenter.MouseDown, BtnDown.MouseDown
            Dim val = CInt(DirectCast(sender, Button).Tag)
            WriteData(MirrrorActuator, val) 'up  = 1 'dwn = 2 'ib  = 4 'ob  = 8 'center = 16
        End Sub

        Private Sub BtnUp_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnUp.MouseUp, BtnIB.MouseUp, BtnOB.MouseUp, BtnCenter.MouseUp, BtnDown.MouseUp
            WriteData(MirrrorActuator, 0)
        End Sub

#End Region

#Region "Manual Toggle Options"
        Private Sub BtnDefog_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDefog.MouseClick
            Dim val = If(ChkDefog.Checked, 1, 0)
            If val <> vm.Nest.ManualOps.Defog Then
                WriteData("Defog", If(ChkDefog.Checked, 1, 0))
            End If
        End Sub

        Private Sub BtnTs_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTs.MouseClick
            Dim val = If(ChkTs.Checked, 1, 0)
            If val <> vm.Nest.ManualOps.TurnSignal Then
                WriteData("TurnSignal", val)
            End If
        End Sub

#Region "Pfold"
        Private Sub BtnPFIn_CheckedChanged(sender As Object, e As EventArgs) Handles BtnPfOut.MouseDown, BtnPfIn.MouseDown
            If sender Is BtnPfOut Then
                WriteData(Pfold, 2)
            ElseIf sender Is BtnPfIn Then
                WriteData(Pfold, 1)
            End If
        End Sub

        Private Sub BtnPf_MouseUp(sender As Object, e As EventArgs) Handles BtnPfOut.MouseUp, BtnPfIn.MouseUp
            WriteData(Pfold, 0)
        End Sub
#End Region


        Private Sub BtnBzi_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBzi.MouseClick
            Dim val = Math.Abs(CInt(ChkBzi.Checked))
            WriteData("BZI", val)
        End Sub
        Private Sub BtnCameraLed_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGreenLed.MouseClick
            WriteData(CameraItems, BitTools.FlipBit(vm.Nest.ManualOps.CameraItems, 1))
        End Sub

        Private Sub BtnFlatLight_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFlatLight.MouseClick
            WriteData(CameraItems, BitTools.FlipBit(vm.Nest.ManualOps.CameraItems, 0))
        End Sub




        Private Sub WriteData(itemName As String, data As Object)
            Debug.Print(itemName + " " + data.ToString)
            _plc.ManualWrite(New SaveEventArgs(Tag_TesterAddress + $".Nest{vm.NestId}.ManualOps.{itemName}", data))
        End Sub


#End Region
        Private Sub OnChkClick(sender As Object, e As EventArgs) Handles ChkCargoLamp.MouseClick,
                                                                                ChkEc.MouseClick,
                                                                                ChkGi.MouseClick,
                                                                                ChkOats.MouseClick,
                                                                                ChkMemory.MouseClick
            If sender Is ChkCargoLamp Then
                WriteData(CargoLamp, BitTools.FlipBit(vm.Nest.ManualOps.CargoLamp, 0))
            ElseIf sender Is ChkEc Then
                WriteData(Ec, BitTools.FlipBit(vm.Nest.ManualOps.Ec, 0))
            ElseIf sender Is ChkGi Then
                WriteData(Gi, BitTools.FlipBit(vm.Nest.ManualOps.Gi, 0))
            ElseIf sender Is ChkOats Then
                WriteData(Oats, BitTools.FlipBit(vm.Nest.ManualOps.Oats, 0))
            ElseIf sender Is ChkMemory Then
                WriteData("MemoryCr", BitTools.FlipBit(vm.Nest.ManualOps.MemoryCr, 0))
            Else
                Throw New NotImplementedException("This button is not being handled")
            End If

        End Sub



        Private Sub ActuatorUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _actuatorButtons.Add(BtnUp)          '0
            _actuatorButtons.Add(BtnDown)        '1
            _actuatorButtons.Add(BtnIB)          '2
            _actuatorButtons.Add(BtnOB)          '3
            _actuatorButtons.Add(BtnCenter)      '4
        End Sub
        Public Sub UpdateViewModel(data As ActuatorViewModel) Implements IView(Of ActuatorViewModel).UpdateViewModel
            vm = data

            With vm.Nest.ManualOps
                ChkDefog.Checked = BitTools.CheckBitValue(.Defog, 0)
                ChkTs.Checked = BitTools.CheckBitValue(.TurnSignal, 0)
                ChkBzi.Checked = BitTools.CheckBitValue(.BZI, 0)
                ChkGreenLed.Checked = BitTools.CheckBitValue(.CameraItems, 1)
                ChkFlatLight.Checked = BitTools.CheckBitValue(.CameraItems, 0)

                ChkCargoLamp.Checked = BitTools.CheckBitValue(.CargoLamp, 0)
                ChkEc.Checked = BitTools.CheckBitValue(.Ec, 0)
                ChkGi.Checked = BitTools.CheckBitValue(.Gi, 0)
                ChkOats.Checked = BitTools.CheckBitValue(.Oats, 0)
                ChkMemory.Checked = BitTools.CheckBitValue(.MemoryCr, 0)
            End With
        End Sub




    End Class
End Namespace