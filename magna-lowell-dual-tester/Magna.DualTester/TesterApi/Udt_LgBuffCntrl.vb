﻿Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)> Public Class Udt_LgBuffCntrl
        Public Log As New Udt_LogReq
        Public Queue As New Udt_Logvalues
        Public State As Integer
    End Class
End NameSpace