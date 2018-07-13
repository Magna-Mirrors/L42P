Imports NLog
Imports Magna.DualTester.UI.Dialogs
Imports Magna.DualTester.TesterApi
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums

Namespace UI.Views.Calibration.SubViews

    Public Class CalibrationSubUserControl
        Implements IView(Of CalibrationSubViewModel)

        Private Const MirrrorActuator = "MirrrorActuator"
        Private Const Pfold = "Pfold"
        Private Const HorzAngle = "HorzAngle"
        Private Const VertAngle = "VertAngle"

        Private Property _vm As CalibrationSubViewModel
        Private Property _tmpuser As User
        Private ReadOnly _logger As Logger = LogManager.GetCurrentClassLogger()
        Private _plc As IPlc
        Private _msgsvc As IMessageAlertService

        Public WriteOnly Property SetPlc As IPlc
            Set(value As IPlc)
                _plc = value
            End Set
        End Property

        Private ReadOnly Property _isAdminOrBetter As Boolean
            Get
                Return _tmpuser.UserIs(AccessLevel.Admin)
            End Get
        End Property

        Public WriteOnly Property SetMessageService As IMessageAlertService
            Set(value As IMessageAlertService)
                _msgsvc = value
            End Set
        End Property

        Private Sub LaunchDialog(val As Udt_AlgItem, baseunit As ValueDialog.Units, label As String)

            If val Is Nothing Then
                _msgsvc.PublishNewAlarm("Could not open dialog udt_algItem is null", ErrorLevel.Error, 2)
                _logger.Error("Val is null LaunchDialog() @CalibrationSubUserControl")
                Return
            End If

            If val.AnalogInDint >= val.MinRawCalDeflect Then
                Dim dilg As New ValueDialog(label, baseunit, val.Value, _tmpuser, _msgsvc)
                If dilg.ShowDialog(Me) = DialogResult.OK AndAlso Not dilg.Value.Equals(val.Value) Then
                    val.CalValue = Math.Abs(dilg.Value) 'val.Value '/ val.AnalogInDint
                    Me.RaiseSaved($"{GetNestAddress(_vm.NestId)}.AlgFeatures.{label}", val)


                    Me.RaiseSaved($"{My.Resources.Tag_TesterAddress}.Nest{_vm.NestId}.CalibrationChangeId", CObj(1))
                    'after changing eng val add testapi.nest#.calibrationchangeId = 1
                End If
            End If
        End Sub

        Sub RaiseSaved(address As String, obj As Object, Optional msg As String = "")
            _plc.ManualWrite(New SaveEventArgs(address, obj, message:=msg))
        End Sub

        Private Sub WriteManualOps(itemName As String, data As Object)
            Me.RaiseSaved($"{GetNestAddress(_vm.NestId)}.ManualOps.{itemName}", data, Nothing)
        End Sub

#Region "CalItem Events"
        Private Sub OnCalibrateClick(sender As Object, e As EventArgs) Handles CalItemHorizontalMem.BtnCalibrateClicked,
                                                                                        CalItemVerticalMemory.BtnCalibrateClicked,
                                                                                        CalItemHorzAmp.BtnCalibrateClicked,
                                                                                        CalItemVertAmp.BtnCalibrateClicked,
                                                                                        CalItemSpare.BtnCalibrateClicked,
                                                                                        CalItemOats.BtnCalibrateClicked,
                                                                                        CalItemCargoLamp.BtnCalibrateClicked,
                                                                                        CalItemGi.BtnCalibrateClicked,
                                                                                        CalItemEc.BtnCalibrateClicked,
                                                                                        CalItemPfold.BtnCalibrateClicked,
                                                                                        CalItemBzi.BtnCalibrateClicked,
                                                                                        CalItemTurnSig.BtnCalibrateClicked,
                                                                                        CalItemHeater.BtnCalibrateClicked

            If sender Is CalItemPfold Then
                LaunchDialog(_vm.AlgFeatures.Pf_Amp, ValueDialog.Units.A, "Pf_Amp")
            ElseIf sender Is CalItemTurnSig Then
                LaunchDialog(_vm.AlgFeatures.Ts_Amp, ValueDialog.Units.A, "Ts_Amp")
            ElseIf sender Is CalItemHeater Then
                LaunchDialog(_vm.AlgFeatures.DefogAmp, ValueDialog.Units.A, "DefogAmp")
            ElseIf sender Is CalItemHorzAmp Then
                LaunchDialog(_vm.AlgFeatures.HorzAmp, ValueDialog.Units.A, "HorzAmp")
            ElseIf sender Is CalItemVertAmp Then
                LaunchDialog(_vm.AlgFeatures.VertAmp, ValueDialog.Units.A, "VertAmp")
            ElseIf sender Is CalItemBzi Then
                LaunchDialog(_vm.AlgFeatures.Bzi_Amp, ValueDialog.Units.A, "Bzi_Amp")
            ElseIf sender Is CalItemEc Then
                LaunchDialog(_vm.AlgFeatures.Ec_Amp, ValueDialog.Units.A, "EC_Amp")
            ElseIf sender Is CalItemGi Then
                LaunchDialog(_vm.AlgFeatures.Gi_Amp, ValueDialog.Units.A, "Gi_Amp")
            ElseIf sender Is CalItemCargoLamp Then
                LaunchDialog(_vm.AlgFeatures.CargoLamp_Amp, ValueDialog.Units.A, "CargoLamp_Amp")
            ElseIf sender Is CalItemOats Then
                LaunchDialog(_vm.AlgFeatures.Oats_Amp, ValueDialog.Units.A, "OATS_Amp")
            ElseIf sender Is CalItemSpare Then
                LaunchDialog(_vm.AlgFeatures.Spare, ValueDialog.Units.A, "Spare")
            ElseIf sender Is CalItemHorizontalMem Then
                LaunchDialog(_vm.AlgFeatures.Horz_Mem, ValueDialog.Units.V, "Horz_Mem")
            ElseIf sender Is CalItemVerticalMemory Then
                LaunchDialog(_vm.AlgFeatures.Vert_Mem, ValueDialog.Units.V, "Vert_Mem")
            End If
        End Sub

        Private Sub PowerToggle_CheckedChanged(sender As Object, e As Boolean) Handles CalItemVertAmp.BtnPowerClicked,
                                                                                        CalItemHorzAmp.BtnPowerClicked,
                                                                                        CalItemPfold.BtnPowerClicked
            If sender Is CalItemVertAmp Then
                WriteManualOps(MirrrorActuator, If(e, 1, 0))
            ElseIf sender Is CalItemHorzAmp Then
                WriteManualOps(MirrrorActuator, If(e, 4, 0))
            ElseIf sender Is CalItemPfold Then
                WriteManualOps(Pfold, If(e, 1, 0))
            End If
        End Sub

#End Region

        Public Sub NewUser(user As User)
            _tmpuser = user
        End Sub

        Private Sub MirrorTraining_SendAngleCalDataRequest(CalData As Udt_Mcal) Handles MirrorTraining.SendAngleCalDataRequest
            Dim nestAddress = GetNestAddress(_vm.NestId)
            Me.RaiseSaved($"{nestAddress}.CalEdit", CalData, "Angle calibration sent to PLC")
            Me.RaiseSaved($"{nestAddress}.SetAngleCal", 1, "Angle calibration sent to PLC")
            MirrorTraining.CalEventComplete()
        End Sub



        Private Shared Function GetNestAddress(nid As Integer) As String
            Return $"{My.Resources.Tag_TesterAddress}.Nest{nid}"
        End Function

        Public Sub UpdateViewModel(data As CalibrationSubViewModel) Implements IView(Of CalibrationSubViewModel).UpdateViewModel
            If InvokeRequired Then
                Invoke(Sub() UpdateViewModel(data))
                Return
            End If

            _vm = data

            If data.NestId < 1 Then
                Throw New Exception("nest id not set")
            End If
            Try
                'Nest = obj 'If(NestId = 1, obj.Nest1, obj.Nest2)
                If _vm IsNot Nothing Then
                    With _vm.AlgFeatures
                        CalItemHorizontalAngle.UpdateData(.HorzAngle, AccessLevel.None)
                        CalItemVerticalAngle.UpdateData(.VertAngle, AccessLevel.None)
                        CalItemHorizontalMem.UpdateData(.Horz_Mem, AccessLevel.None)
                        CalItemVerticalAngle.UpdateData(.Vert_Mem, AccessLevel.None)
                        CalItemHorzAmp.UpdateData(.HorzAmp, AccessLevel.None, _isAdminOrBetter, CBool(_vm.ManualOps.MirrrorActuator And 4))
                        CalItemVertAmp.UpdateData(.VertAmp, AccessLevel.None, _isAdminOrBetter, CBool(_vm.ManualOps.MirrrorActuator And 1))
                        CalItemHeater.UpdateData(.DefogAmp, AccessLevel.None)
                        CalItemTurnSig.UpdateData(.Ts_Amp, AccessLevel.None)
                        CalItemBzi.UpdateData(.Bzi_Amp, AccessLevel.None)
                        CalItemPfold.UpdateData(.Pf_Amp, AccessLevel.None, _isAdminOrBetter, CBool(_vm.ManualOps.Pfold And 1))
                        CalItemEc.UpdateData(.Ec_Amp, AccessLevel.None)
                        CalItemGi.UpdateData(.Gi_Amp, AccessLevel.None)
                        CalItemCargoLamp.UpdateData(.CargoLamp_Amp, AccessLevel.None)
                        CalItemOats.UpdateData(.Oats_Amp, AccessLevel.None)
                        CalItemSpare.UpdateData(.Spare, AccessLevel.None)
                        MirrorTraining.UpdateViewModel(New UcCoordinateViewModel(_vm))
                    End With
                Else
                    _msgsvc.PublishNewAlarm("Nest data is null at LoadData @CalibrationSubUserControl", ErrorLevel.Error, 2)
                End If
            Catch ex As NullReferenceException
                _logger.Error("Null ref LoadData() @CalibrationSubUserControl:: " + ex.ToString())
            End Try
        End Sub
    End Class
End Namespace


'do we want to shut off buttons after editing engval from screen

'can only enter engineering values if testerapi.nest#.algfeatures.horzmap.minrawcalDefect < rawValue
'both values have to be above zero
'and if user is engineer or higher
'

'scalefactor = eng val/rawinput
'get raw from plc
'get engval from screen
'push scale factor to plc


'after changing eng val add testapi.nest#.calibrationchangeId = 1