﻿Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_Tester_Counts
        Public ShiftPassCount As Integer
        Public ShiftFailCount As Integer
        Public BatchCountDown As Integer
        Public ToteTarget As Integer
        Public ToteCount As Integer
    End Class
End NameSpace