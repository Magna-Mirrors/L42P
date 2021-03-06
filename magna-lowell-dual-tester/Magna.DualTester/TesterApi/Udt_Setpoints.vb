﻿Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_Setpoints
        Public ActuatorAmps As New Udt_MinMax
        Public ActuatorRate As New Udt_MinMax
        Public UpAngle As New Udt_MinMax
        Public DwnAngle As New Udt_MinMax
        Public InBoardAngle As New Udt_MinMax
        Public OutBoardAngle As New Udt_MinMax
        Public MemAtUp As New Udt_MinMax
        Public MemAtDwn As New Udt_MinMax
        Public MemAtInBoard As New Udt_MinMax
        Public MemAtOutBoard As New Udt_MinMax
        Public Defog_Inrush As New Udt_MinMax
        Public defogAmps As New Udt_MinMax
        Public Gi_Amps As New Udt_MinMax
        Public LogoLamp_Amps As New Udt_MinMax
        Public Ts_Amps As New Udt_MinMax
        Public Bzi_Amps As New Udt_MinMax
        Public Pfold_Amps As New Udt_MinMax
        Public Pfold_TravTime As New Udt_MinMax
        Public MemoryVoltsPerDeg As New Udt_MinMax
        Public EcAmps As New Udt_MinMax
        Public Cargo_Lamp_Amps As New Udt_MinMax
        Public Oats_Amps As New Udt_MinMax
        Public PowerExt_Amps As New Udt_MinMax
        Public PowerExt_TravTime As New Udt_MinMax
        Public Camera_Amps As New Udt_MinMax
        Public Gps_Amps As New Udt_MinMax
        Public Ca_Amps As New Udt_MinMax
    End Class
End Namespace