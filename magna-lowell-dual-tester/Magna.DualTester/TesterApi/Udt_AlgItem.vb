Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_AlgItem
        Public AnalogInDint As Integer
        Public CalValue As Single
        Public Value As Single
        Public Offset As Single
        Public MinRawCalDeflect As Integer
    End Class
End Namespace