Imports Magna.DualTester.Plc.Core.PlcStrings

Public Class Udt_Order
    Public SN As New PlcString_82
    Public ID As Integer
    Public TargetCount As Integer
    Public Built As New Integer
    Public FailCount As Integer
    Public Status As Integer
    Public TargetQrCode As New PlcString_82
    Public RanNumber As New PlcString_32
    Public PartNumber As New PlcString_32
    Public LineId As Integer
End Class
