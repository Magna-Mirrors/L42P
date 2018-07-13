Imports Magna.DualTester.Plc.Core.PlcStrings
Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)> Public Class Udt_OrderInfo
        Public OrderId As Integer
        Public QTY As Integer
        Public Accum As Integer
        Public PartNumber As New PlcString_32
    End Class
End Namespace
