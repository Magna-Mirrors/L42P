﻿Imports Magna.DualTester.Plc.Core.PlcStrings
Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)>
    Public Class Udt_User
        Public BadgeNumber As Integer
        Public ClockNumber As Integer
        Public Username As New PlcString_82
        Public AccessLevel As Short
        Public LogOutRequest As Short
        Public State As Integer
        Public StationNumber As Short
        Public Status As New Udt_UserStatus
        Public RemainingQualityAlerts As Short
        Public ReamaingTrainingItems As Short
        Public ReamaingTrainingHours As Single
        Public RemainingErgoHours As Single
    End Class
End Namespace