﻿Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_AnalogItems
        Public VertAmp As New Udt_AlgItem
        Public HorzAmp As New Udt_AlgItem

        Public VertAngle As New Udt_AlgItem
        Public HorzAngle As New Udt_AlgItem

        Public Vert_Mem As New Udt_AlgItem
        Public Horz_Mem As New Udt_AlgItem

        Public DefogAmp As New Udt_AlgItem
        Public Gi_Amp As New Udt_AlgItem
        Public Bzi_Amp As New Udt_AlgItem
        Public Ts_Amp As New Udt_AlgItem
        Public Pf_Amp As New Udt_AlgItem
        Public GlassPull As New Udt_AlgItem
        Public Ec_Amp As New Udt_AlgItem
        Public CargoLamp_Amp As New Udt_AlgItem
        Public Oats_Amp As New Udt_AlgItem
        Public Camera_Amp As New Udt_AlgItem
        Public Gps_Amp As New Udt_AlgItem
        Public Ca_Amp As New Udt_AlgItem
        Public Spare As New Udt_AlgItem
        Public Nest As Integer
    End Class
End Namespace