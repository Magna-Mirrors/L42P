Imports Magna.DualTester.Plc.Core.PlcStrings
Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_Logvalues
        Public partNumber As New PlcString_82
        Public StationId As Integer
        Public Nest As Integer
        Public ClockNumber As New PlcString_82
        Public MirrorUpTravel As New Udt_LogItem
        Public MirrorUpRate As New Udt_LogItem
        Public MirrorUpAmp As New Udt_LogItem
        Public MirrorMemAtUp As New Udt_LogItem
        Public MirrorDwnTravel As New Udt_LogItem
        Public MirrorDwnRate As New Udt_LogItem
        Public MirrorDwnAmp As New Udt_LogItem
        Public MirrorMemAtDwn As New Udt_LogItem
        Public MirrorInBoardTravel As New Udt_LogItem
        Public MirrorInBoardRate As New Udt_LogItem
        Public MirrorInBoardAmp As New Udt_LogItem
        Public MirrorMemAtInBoard As New Udt_LogItem
        Public MirrorOutBoardTravel As New Udt_LogItem
        Public MirrorOutBoardRate As New Udt_LogItem
        Public MirrorOutBoardAmp As New Udt_LogItem
        Public MirrorMemAtOutBoard As New Udt_LogItem
        Public Defog As New Udt_LogItem
        Public Defog_InRush As New Udt_LogItem
        Public GlassPull As New Udt_LogItem
        Public Ec_Amp As New Udt_LogItem
        Public Ts_Amp As New Udt_LogItem
        Public Gi_Amp As New Udt_LogItem
        Public LogoLamp_Amp As New Udt_LogItem
        Public Bzi_Amp As New Udt_LogItem
        Public Pf_Amp As New Udt_LogItem
        Public Pf_Trav_Time As New Udt_LogItem
        Public PowerExt_Amp As New Udt_LogItem
        Public PowerExt_Trav_Time As New Udt_LogItem
        Public Oats_Amp As New Udt_LogItem
        Public CargoLamp_Amp As New Udt_LogItem
        Public Camera_Amp As New Udt_LogItem
        Public Gps_Amp As New Udt_LogItem
        Public Ca_Amp As New Udt_LogItem

        ''' <summary>
        '''  3 = part errors /
        '''  2 = part passed /
        '''  anything else is not defined
        ''' </summary>
        Public ResultCode As New Integer
        Public FltBits() As Boolean = New Boolean(127) {}
    End Class
End Namespace