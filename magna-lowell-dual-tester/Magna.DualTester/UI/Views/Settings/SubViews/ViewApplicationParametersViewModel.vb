Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.TesterApi
Imports Magna.DualTester.Core.Data
Imports Magna.DualTester.Core

Public Class ViewApplicationParametersViewModel
    Public Sub New(colors As ColorsModel, cfg As NonDominoCfg)
        Me.Colors = colors
        Me.Cfg = cfg
    End Sub
    Public Property Colors As ColorsModel
    Public Property Cfg As NonDominoCfg
End Class