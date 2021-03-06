﻿Imports Magna.DualTester.UI.Views.MainView.SubViews
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.TesterApi
Imports Magna.DualTester.Core

Public Class TesterDevicesViewModel
    Public Sub New(nestid As Integer, nest As Udt_Nest, colors As ColorsModel)
        Me.NestId = nestid
        ManualOps = nest.ManualOps
        TargetColor = New ColorMap(nest.TargetColor, colors)
        Me.Colors = colors
    End Sub
    Public Property NestId As Integer
    Public Property ManualOps As Udt_Manual_Operators
    Public Property TargetColor As ColorMap
    Public Property Colors As ColorsModel
End Class