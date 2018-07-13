Imports Magna.DualTester.Plc.Core.PlcStrings
Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_tester
        Public StationId As New Integer
        Public Counts As New Udt_Tester_Counts
        Public PartInfo As New Udt_PartInformation
        Public SetPoints As New Udt_Setpoints
        Public Nest1 As New Udt_Nest
        Public Nest2 As New Udt_Nest
        Public User As New Udt_User
        Public Daq_Hb As New Udt_HeartBeat
        Public LogBuffer As New Udt_LgBuffCntrl
        Public LogCalibrationEvent As New Udt_LogReq
        Public LogSetpointChange As New Udt_LogReq
        Public ShiftValue As Integer
        Public LastShift As Integer
        Public RequestLogOut As Integer
        Public CalibrationChange As New Udt_AnalogItems
        Public FindPartReq As New Udt_LogReq
        Public ActivityToBuffer As New Udt_Activity
        Public LogActivityRequest As New Udt_LogReq
        Public ActivityLogQueItem As New Udt_Activity
        Public PnToFind As New PlcString_82
        Public Printer As New Udt_Printer
        Public DownTimeInput As New PlcString_82
    End Class
End Namespace