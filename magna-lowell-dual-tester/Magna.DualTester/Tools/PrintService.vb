Imports System.IO
Imports System.IO.Ports
Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core
Imports System.Text.RegularExpressions

Public Class PrintService
    Implements IPrint

    Const PrnFile = "PartLabel.prn"
    Private ReadOnly _plc As IPlc
    Private ReadOnly _cfg As ICfgNonDomino
    Private ReadOnly _messageAlert As IMessageAlertService
    Private ReadOnly _plcDataRepo As IPlcFullRepo
    Private ReadOnly _prnFileRepo As PrnFileRepo

    Private _prevNest1PartPrint As String
    Private Property _prevNest1ResCode As Integer
    Private Property _prevNest2ResCode As Integer

    Private previousprints(31) As String
    Private previousPrintRequests As Integer


    Public Sub New(cfg As ICfgNonDomino, prnFileRepo As PrnFileRepo, msgserv As IMessageAlertService, plc As IPlc, printDataRepo As IPlcFullRepo)
        _plc = plc
        _cfg = cfg
        _messageAlert = msgserv
        _plcDataRepo = printDataRepo
        _prnFileRepo = prnFileRepo
        AddHandler _plcDataRepo.TesterContextChanged, AddressOf OnTesterChange
    End Sub

    Private Sub OnTesterChange(tester As TesterApi.Udt_tester)
        Dim cfg = _cfg.ReadConfig()

        Dim printdint As Integer = tester.Printer.Request

        For i As Byte = 0 To 31
            Dim index = i
            Dim printer = cfg.Printers.SingleOrDefault(Function(x) x.Index = index)
            If BitTools.CheckBitValue(previousPrintRequests, index) Then
                If Not BitTools.CheckBitValue(printdint, index) Then
                    previousPrintRequests = BitTools.SetBitTo(previousPrintRequests, index, False)
                End If
            ElseIf printer IsNot Nothing AndAlso BitTools.CheckBitValue(printdint, index) And Not BitTools.CheckBitValue(previousPrintRequests, index) Then
                previousPrintRequests = BitTools.SetBit(previousPrintRequests, index)
                If AutoPrint(printer) Then
                    _plc.ManualWrite($"{My.Resources.Tag_TesterAddress}.Printer.ResultPass", BitTools.SetBit(tester.Printer.Pass, index))
                Else
                    _plc.ManualWrite($"{My.Resources.Tag_TesterAddress}.Printer.ResultFail", BitTools.SetBit(tester.Printer.Fail, index))
                End If
            End If
        Next
    End Sub

    Private Function AutoPrint(cfg As PrintCfg) As Boolean
        Dim file As String
        Try
            file = _prnFileRepo.GetPrnFileStream(cfg.PrnFile)
        Catch ex As FileNotFoundException
            _messageAlert.PublishNewAlarm($"PrintFile Not Found ""{cfg.PrnFile}""", ErrorLevel.Error)
            Return False
        End Try
        For Each match In _plcDataRepo.PrnStringReplacements
            Dim key = match.Key
            file = file.Replace(key, match.Value)
        Next

        If Not My.Computer.Ports.SerialPortNames.Contains(cfg.ComPort) Then
            _messageAlert.PublishNewAlarm($"Printer port not found ""{cfg.ComPort}""", ErrorLevel.Error)
            Return False
        End If
        Try
            Using com1 As SerialPort = My.Computer.Ports.OpenSerialPort(cfg.ComPort)
                com1.Write(file)
            End Using
        Catch ex As Exception
            _messageAlert.PublishNewAlarm($"Comm error on printer {cfg.Index},{cfg.PrinterName},{cfg.ComPort}", ErrorLevel.Error)
            Return False
        End Try
        previousprints(cfg.Index) = file
        Return True
    End Function

    Public Sub ReprintPrevious(printer As PrintCfg) Implements IPrint.ReprintPrevious
        Dim finalfile = previousprints(printer.Index)
        If finalfile Is Nothing Then
            _messageAlert.PublishNewAlarm("There is no previous print stored", ErrorLevel.Alert)
            Return
        End If

        Try
            Using com1 As SerialPort = My.Computer.Ports.OpenSerialPort(printer.ComPort)
                com1.Write(finalfile)
            End Using
        Catch ex As Exception
            _messageAlert.PublishNewAlarm($"Comm error on printer {printer.Index},{printer.PrinterName},{printer.ComPort}", ErrorLevel.Error)
        End Try
    End Sub

    Public Sub TestPrint(printer As PrintCfg) Implements IPrint.TestPrint
        Dim file = _prnFileRepo.GetPrnFileStream(printer.PrnFile)
        Try
            Using com1 As SerialPort = My.Computer.Ports.OpenSerialPort(printer.ComPort)
                com1.Write(file)
            End Using
            _messageAlert.PublishNewAlarm($"Test print success {printer.Index},{printer.PrinterName},{printer.ComPort},""{printer.PrnFile}""", ErrorLevel.Error)
        Catch ex As Exception
            _messageAlert.PublishNewAlarm($"Comm error on printer {printer.Index},{printer.PrinterName},{printer.ComPort}", ErrorLevel.Error)
        End Try
    End Sub


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
            End If
        End If
        disposedValue = True
    End Sub


    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub
#End Region


End Class



