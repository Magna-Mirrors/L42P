Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)> Public Class Udt_LogReq
        Public trigger As Integer
        Public RepeatTmr As Integer
        Public Result As Integer
    End Class
End NameSpace