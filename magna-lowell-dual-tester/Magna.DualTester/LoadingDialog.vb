
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Tools
Imports Magna.DualTester.Plc.Core

Public Class LoadingDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        TryClose(True)
    End Sub

    Private _allServices As List(Of IStartupService) = New List(Of IStartupService)
    Dim _services As New Dictionary(Of String, LoadingStatus)
    Dim lock As New Object()
    Dim count As Integer = 0

    Public Sub New(services As IStartupService())
        InitializeComponent()
        _allServices.AddRange(services)
        For Each s In services
            Dim uc As New LoadingStatus(s.ServiceName)
            _services.Add(s.ServiceName, uc)
            uc.Anchor = AnchorStyles.Left Or AnchorStyles.Right
            uc.BorderStyle = BorderStyle.FixedSingle
            FlowLayoutPanel1.Controls.Add(uc)

            If s.Status Is Nothing Then
                AddHandler s.StartupResult, AddressOf OnStartupResult
            Else
                Debug.Print(s.ServiceName)
                OnStartupResult(s, s.Status)
            End If
        Next
    End Sub
    Private Sub OnStartupResult(sender As Object, e As StartupEventResult)
        SyncLock (lock)
            Dim service = DirectCast(sender, IStartupService)
            _allServices.Remove(service)
            _services(service.ServiceName).SetStatus(e)
            RemoveHandler service.StartupResult, AddressOf OnStartupResult
            count += 1
        End SyncLock
    End Sub

    Private Sub TryClose(Optional ignore As Boolean = False)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Dim start As DateTime

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Now - start) > New TimeSpan(0, 0, 10) Then
            Me.Close()
        End If
    End Sub

    Private Sub LoadingDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each item In _allServices
            RemoveHandler item.StartupResult, AddressOf OnStartupResult
        Next
    End Sub
End Class

