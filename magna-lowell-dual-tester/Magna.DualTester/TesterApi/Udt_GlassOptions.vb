﻿Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)> Public Class Udt_GlassOptions
        Public Convex As New Udt_Opt_Item()
        Public Flat As New Udt_Opt_Item()
        Public Aspheric As New Udt_Opt_Item()
        Public BziSymbol As New Udt_Opt_Item()
        Public TurnSignal As New Udt_Opt_Item()
        Public DefogSymbol As New Udt_Opt_Item()
        Public JeepSymbol As New Udt_Opt_Item
        Public English As New Udt_Opt_Item()
        Public Arabic As New Udt_Opt_Item()
        Public Korean As New Udt_Opt_Item()
        Public PowerFoldSymbol As New Udt_Opt_Item()
        Public CoPlaner As New Udt_Opt_Item()
        Public WideView As New Udt_Opt_Item()
    End Class
End Namespace

