Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Magna.DualTester.Core
Imports Magna.DualTester.CurrentOrderManager

Public Class ViewOrders
    Implements IViewTask

    Private Property task As Task Implements IViewTask.RunningTask

    Private ReadOnly _ordermanager As CurrentOrderManager
    Private ReadOnly _userWatch As IUserWatch
    Private ReadOnly _plans As New BindingList(Of Plan)
    Private ReadOnly _plc As IPlc
    Private ReadOnly _msgsvc As IMessageAlertService
    Private _currentorder As Udt_Order

    Public Sub New(ordermanager As CurrentOrderManager, userWatch As IUserWatch, plc As IPlc, msgsvc As IMessageAlertService)
        InitializeComponent()
        _plc = plc
        _msgsvc = msgsvc
        _userWatch = userWatch
        _ordermanager = ordermanager
        PlanBindingSource.DataSource = _plans
        AddHandler _userWatch.ValueChanged, AddressOf NewUser
        NewUser(_userWatch.CurrentValue)
    End Sub

    Private Sub NewUser(obj As User)
        BtnSkipOrder.Enabled = obj.UserIs(Data.Enums.AccessLevel.Supervisor)
    End Sub
    Private Async Function RefreshData() As Task
        Dim plans As IEnumerable(Of Plan) = Nothing
        Try
            Dim plansT = _ordermanager.GetPlansAsync()
            task = plansT
            Dim currentOrder = Await _plc.ReadAsync(Of Udt_Order)("CurrentOrder")
            If currentOrder.Success Then
                _currentorder = currentOrder.Value
            End If
            plans = Await plansT

            LblOrderId.Text = _currentorder.ID.ToString()
            LblPn.Text = _currentorder.PartNumber.ToString()
            LblTargetCount.Text = _currentorder.TargetCount.ToString()
            LblBuilt.Text = _currentorder.Built.ToString()

        Catch ex As Exception
            MessageBox.Show(Me, $"There was a problem connecting to the scheduler service. {ex.Message}", "Service Connection Error")
            Me.Enabled = False
        End Try

        If plans IsNot Nothing Then
            _plans.Clear()
            For Each item In plans
                _plans.Add(item)
            Next
        End If
    End Function

#Region "IViewTask"
    Private Async Sub IViewTask_Load() Implements IViewTask.Load
        SetButtons(False)
        Await RefreshData()
        SetButtons(True)
    End Sub

    Public Function BeginClose() As Task Implements IViewTask.BeginClose
        RemoveHandler _userWatch.ValueChanged, AddressOf NewUser

        Return Task.CompletedTask
    End Function
#End Region
    ReadOnly Property _isUserSupervisorOrBetter As Boolean
        Get
            Return _userWatch.CheckCurrentUserPermission(Data.Enums.AccessLevel.Supervisor)
        End Get
    End Property

#Region "Form Events"
    Private Async Sub Btn_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click,
                                                                            BtnGetNextOrder.Click,
                                                                            BtnSkipOrder.Click,
                                                                            BtnClear.Click,
                                                                            BtnRemoveOrder.Click
        SetButtons(False)
        If sender Is BtnRefresh Then
            Await RefreshData()
        ElseIf sender Is BtnGetNextOrder Then
            Await _ordermanager.SetSchedulerButtons(SchedulerButtons.GetNextOrder)
            Await RefreshData()
        ElseIf sender Is BtnSkipOrder Then
            If _isUserSupervisorOrBetter Then
                Await _ordermanager.SkipCurrentOrder()
                Await _ordermanager.SetSchedulerButtons(SchedulerButtons.SkipOrder)
                Await RefreshData()
            End If
        ElseIf sender Is BtnClear Then
                Await _ordermanager.SetSchedulerButtons(SchedulerButtons.ClearBuild)
                Await RefreshData()
            ElseIf sender Is BtnRemoveOrder Then

            If (_currentorder Is Nothing) Then
                _msgsvc.PublishNewAlarm("Current order is not set. Click Refresh.", ErrorLevel.Alert)
            Else
                If _isUserSupervisorOrBetter Then
                    Dim result = Await _ordermanager.RemoveOrderAsync(_currentorder.ID)
                    If result IsNot Nothing Then
                        Await _ordermanager.SetSchedulerButtons(SchedulerButtons.RemoveOrder)
                        Await RefreshData()
                    End If
                End If
            End If
        End If
        SetButtons(True)

    End Sub
#End Region

    Private Sub SetButtons(val As Boolean)
        BtnRefresh.Enabled = val
        BtnGetNextOrder.Enabled = val
        BtnSkipOrder.Enabled = val
        BtnClear.Enabled = val
        BtnRemoveOrder.Enabled = val
    End Sub
End Class
