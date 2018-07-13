

Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Core.Tools

Public Class BarcodeService

    Private ReadOnly _scanner As IBarcodeScanner
    Private ReadOnly _uwatch As IUserWatch
    Private ReadOnly _plc As IPlc
    Private ReadOnly _msgsvc As IMessageAlertService
    Private ReadOnly _plcrepo As IPlcDataRepo
    Private ReadOnly _currentorderManager As CurrentOrderManager
    Public Sub New(scanner As IBarcodeScanner,
                   uwatch As IUserWatch,
                   plc As IPlc,
                   msgsvc As IMessageAlertService,
                   plcrepo As IPlcDataRepo,
                   currentorderManager As CurrentOrderManager)
        _scanner = scanner
        _uwatch = uwatch
        _plc = plc
        _plcrepo = plcrepo
        _msgsvc = msgsvc
        _currentorderManager = currentorderManager
        AddHandler _scanner.NewScan, AddressOf NewScan

    End Sub

    Private Async Sub NewScan(sender As Object, scan As BarCodeScanResults)
        Const minValForPartScan = 20
        If scan.LowerScanValue = "next" Then
            Await _currentorderManager.SetSchedulerButtons(CurrentOrderManager.SchedulerButtons.GetNextOrder)
        ElseIf scan.LowerScanValue.StartsWith("sldta-") Then
            _plc.ManualWriteString82(My.Resources.Tag_DownTimeInput, scan.ScanValue)
        ElseIf scan.ScanValue.StartsWith("OP") Then
            _uwatch.LogIn(scan.ScanValue.Substring(2))
        Else
            If _uwatch.CheckCurrentUserPermission(AccessLevel.Operator) Then
                If _plcrepo.Nest1SequenceStep <= minValForPartScan AndAlso _plcrepo.Nest2SequenceStep <= minValForPartScan Then
                    _plc.ManualWriteString82(My.Resources.Tag_PnToFind, scan.ScanValue)
                Else
                    Dim str As String = If(_plcrepo.Nest1SequenceStep > minValForPartScan, "Nest1", String.Empty)
                    str += If(_plcrepo.Nest2SequenceStep > minValForPartScan, "Nest2", String.Empty)
                    _msgsvc.PublishNewAlarm(str + " SeqVal Is above " + minValForPartScan.ToString(), ErrorLevel.Alert)
                End If
            Else
                _msgsvc.PublishNewAlarm("User Access Level Is To low", ErrorLevel.Alert)
            End If
        End If
    End Sub
End Class
