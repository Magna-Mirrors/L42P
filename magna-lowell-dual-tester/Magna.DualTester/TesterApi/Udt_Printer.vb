Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_Printer
        Public Request As Integer
        Public Pass As Integer
        Public Fail As Integer
        Public Nest As Integer 
    End Class
End Namespace