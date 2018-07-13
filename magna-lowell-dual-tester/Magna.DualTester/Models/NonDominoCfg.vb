Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data

<Serializable>
Public Class NonDominoCfg
    Inherits CfgSettings

    Public Sub New()
        MyBase.New()
        JobSchedularServiceAddress = "http://localhost:8045"
    End Sub

    Public Sub New(stringDefaults As IStringDefaults)
        MyBase.New(stringDefaults)
        For i = 0 To 3
            Printers.Add(New PrintCfg() With {.ComPort = "", .PrnFile = "", .Index = i, .PrinterName = $"Printer {i}"})
        Next
    End Sub

    Public Property JobSchedularServiceAddress As String
    Public Property LineId As Integer

    Public Property Printers As New List(Of PrintCfg)

    Public Property ShiftSetup1StStart As Integer = 0
    Public Property ShiftSetup2NdStart As Integer = 0
    Public Property ShiftSetup3RdStart As Integer = 0

End Class

Public Class PrintCfg
    Public Property PrinterName As String
    Public Property ComPort As String
    Public Property PrnFile As String
    Public Property Index As Integer
End Class
