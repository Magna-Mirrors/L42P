Imports Magna.DualTester.TesterApi
Imports Magna.DualTester.Core

Public Class CalibrationSubViewModel

    Public Sub New(nestid As Integer, nest As Udt_Nest)
        Me.NestId = nestid
        Me.Nest = nest
    End Sub

    Public Property NestId As Integer
    Public Property Nest As Udt_Nest
    Public ReadOnly Property AlgFeatures As Udt_AnalogItems
        Get
            Return Nest.AlgFeatures
        End Get
    End Property
    Public ReadOnly Property CurrentGlassType As GlassTypeEnum
        Get
            Return CType(Nest.CurrentGlassType, GlassTypeEnum)
        End Get
    End Property
    Public ReadOnly Property ManualOps As Udt_Manual_Operators
        Get
            Return Nest.ManualOps
        End Get
    End Property
    Public ReadOnly Property CurrentMirrorCal As Udt_Mcal
        Get
            Return Nest.CurrentMirrorCal
        End Get
    End Property

End Class
