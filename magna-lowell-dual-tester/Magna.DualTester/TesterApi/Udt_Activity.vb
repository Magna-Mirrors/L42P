Imports Magna.DualTester.Plc.Core.PlcStrings
Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_Activity
        Public EventDateTime As New PlcString_82
        Public ClockNumber As New PlcString_82
        Public EventMessage As New PlcString_82
        Public StationId As Integer
    End Class
End Namespace