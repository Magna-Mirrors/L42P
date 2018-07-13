Imports System.Runtime.CompilerServices
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.TesterApi

Public Module Extensions
    <Extension()>
    Public Function UserIs(user As Udt_User, level As AccessLevel) As Boolean
        If user IsNot Nothing AndAlso user.AccessLevel >= level Then
            Return True
        End If
        Return False
    End Function
    <Extension()>
    Public Function UserIs(user As User, level As AccessLevel) As Boolean
        If user IsNot Nothing AndAlso user.AccessLevel >= level Then
            Return True
        End If
        Return False
    End Function
    <Extension()>
    Public Function UserEqual(olduser As Udt_User, newuser As Udt_User) As Boolean
        If olduser Is Nothing And newuser Is Nothing Then
            Return True
        ElseIf (olduser Is Nothing And newuser IsNot Nothing) OrElse (olduser IsNot Nothing And newuser Is Nothing) Then
            Return False
        End If
        Return olduser.ClockNumber.ToString() = newuser.ClockNumber.ToString()
    End Function

    <Extension()>
    Public Function UserIsTechOrBetter(user As Udt_User) As Boolean
        Return user.UserIs(AccessLevel.Tech)
    End Function

    <Extension()>
    Public Function UserIsEngieOrBetter(user As Udt_User) As Boolean
        Return user.UserIs(AccessLevel.Engineer)
    End Function

    <Extension()>
    Public Function UserIsAdminOrBetter(user As Udt_User) As Boolean
        Return user.UserIs(AccessLevel.Engineer)
    End Function

    <Extension()>
    Public Function GetAccessLevel(user As Udt_User) As AccessLevel
        If user IsNot Nothing Then
            If user.UserIs(AccessLevel.Admin) Then
                Return AccessLevel.Admin
            ElseIf user.UserIs(AccessLevel.Engineer) Then
                Return AccessLevel.Engineer
            ElseIf user.UserIs(AccessLevel.Tech) Then
                Return AccessLevel.Tech
            ElseIf user.UserIs(AccessLevel.Supervisor) Then
                Return AccessLevel.Supervisor
            ElseIf user.UserIs(AccessLevel.Operator) Then
                Return AccessLevel.Operator
            End If
        End If
        Return AccessLevel.None
    End Function
End Module
