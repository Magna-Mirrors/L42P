Imports Magna.DualTester.Plc.Core.PlcStrings
Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)> Public Class Udt_PartInformation
        Public Pn As New PlcString_82
        Public SvcPn As New PlcString_82
        Public Cpn As New PlcString_82
        Public Desc1 As New PlcString_82
        Public Desc2 As New PlcString_82
        Public PartsPerTote As Integer
        Public Static_Label As New PlcString_82
        Public partColor As New PlcString_82
        Public Pcode As New PlcString_82
        Public ColorId As Integer
        Public SpecialCode As New PlcString_8
        Public Suffix As New PlcString_8
        Public BodyStyleName As New PlcString_82
        Public BodyStyleId As Integer
        Public ContainerType As Integer
        Public LH As Boolean
        Public RH As Boolean
        Public Service As Boolean
        Public RHD As Boolean
        Public ShipWithPFIn As Boolean
        Public PartsPerHourPerPerson As Single
        Public PartOptions As New Udt_PartOptions
        Public GlassOptions As New Udt_GlassOptions
    End Class
End Namespace