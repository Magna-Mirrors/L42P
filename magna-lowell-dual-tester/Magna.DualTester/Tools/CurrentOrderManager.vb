Imports System.Threading.Tasks
Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.SchedulerServiceReference
Imports Magna.DualTester.TesterApi

Public Class CurrentOrderManager
    Implements IStartupService

    Private Const OrderPlcAddress = "AutoReplenish.OrderData"
    Private Const CommError = "Job Scheduler Communication Error Check URL in Configuration. "

    Private ReadOnly _scheduleservicefactory As ScheduleServiceFactory
    Private ReadOnly _plc As IPlc(Of Udt_tester)
    Private ReadOnly _cfg As ICfgNonDomino
    Private ReadOnly _msgService As IMessageAlertService
    Public Event StartupResult As EventHandler(Of StartupEventResult) Implements IStartupService.StartupResult

    Public Sub New(scheduleservicefactory As ScheduleServiceFactory,
                   plc As IPlc(Of Udt_tester),
                   cfg As ICfgNonDomino,
                   msgService As IMessageAlertService)
        _scheduleservicefactory = scheduleservicefactory
        _plc = plc
        _cfg = cfg
        _msgService = msgService
        Task.Run(Async Function()
                     Try
                         Dim res = Await GetPlansAsync()
                         If res IsNot Nothing Then
                             Status = New StartupEventResult(True)
                         End If
                     Catch ex As Exception
                         Status = New StartupEventResult(False, "Communication error with service, check cfg")
                     End Try
                     RaiseEvent StartupResult(Me, Status)
                 End Function)
    End Sub

    Private ReadOnly Property LineId As Integer
        Get
            Return _cfg.ReadConfig().LineId
        End Get
    End Property

    Public ReadOnly Property ServiceName As String Implements IStartupService.ServiceName
        Get
            Return "Scheduler service"
        End Get
    End Property

    Public Property Status As StartupEventResult Implements IStartupService.Status

    Private Function HasLineIdCheck() As Boolean
        If (LineId <= 0) Then
            _msgService.PublishNewAlarm("Please set line id in cfg menu", ErrorLevel.Error)
            Return False
        End If
        Return True
    End Function

    Public Async Function GetPlansAsync() As Task(Of IEnumerable(Of Plan))
        'Return New List(Of Plan) From {New Plan() With {.BuildID = "bid1", .Built = 3, .Chk = "chk1",
        '                                                .CreationDate = Date.Now, .Desc = "desc1", .DueDate = Date.Now.AddHours(2),
        '                                                .Flags = OrderFlags.Truck, .HHMM = "HHMM1", .LastLoadTime = Date.Now.AddHours(1),
        '                                                .MMDDYY = "MMDDYY1", .Ordered = 4, .OrderId = 113, .PartId = 10, .PartNumber = "pn1",
        '                                                .Position = 11111, .PPHPP = 0.5, .QTY = 20, .ScheduleDate = Date.Now.AddDays(1)}}
        Dim result As GetScheduleResult = Nothing
        Try
            Using svc = _scheduleservicefactory.GetInstance()
                result = Await svc.GetLineScheduleAsync(New GetScheduleRequest() With {.LineId = LineId})
            End Using
            If result.Result = 1 Then
                Return result.Items.Select(Function(x) New Plan(x)).ToList()
            Else
                _msgService.PublishNewAlarm($"Service returned error {result.Result} while getting schedule -> " + result.ResultString, ErrorLevel.Error)
            End If
        Catch ex As Exception
            _msgService.PublishNewAlarm(CommError + "{GetLineSchedule}", ErrorLevel.Error)
        End Try
        Return Nothing
    End Function



    Public Async Function SkipCurrentOrder() As Task
        If (HasLineIdCheck()) Then
            Dim result As SkipOrderResult = Nothing
            Try
                Using svc = _scheduleservicefactory.GetInstance()
                    result = Await svc.SkipThisorderAsync(New SkipOrderRequest() With {.Lineid = LineId})
                End Using
            Catch ex As Exception
                _msgService.PublishNewAlarm(CommError + "{skipthisorder}", ErrorLevel.Error)
            End Try
            'Await SetOrder(If(result Is Nothing, Nothing, New OrderResult(result)))
        End If
    End Function

    Friend Async Function RemoveOrderAsync(orderid As Integer) As Task(Of RemoveOrderResult)
        Try
            Using svc = _scheduleservicefactory.GetInstance()
                Return Await svc.RemoveThisorderAsync(New RemoveOrderRequest() With {.OrderId = orderid})
            End Using
        Catch ex As Exception
            _msgService.PublishNewAlarm(CommError + "{skipthisorder}", ErrorLevel.Error)
        End Try
        Return Nothing
    End Function

    Public Async Function SetSchedulerButtons(val As SchedulerButtons) As Task
        Dim result = Await _plc.ManualWriteAsync(New SaveEventArgs("SchedulerButtons", CInt(val)))
        Await Task.Delay(2000)
    End Function
    Public Enum SchedulerButtons
        GetNextOrder = 1
        SkipOrder = 2
        RemoveOrder = 4
        ClearBuild = 8
    End Enum


    Private Class OrderResult
        Public Sub New(res As SkipOrderResult)
            Item = res.Item
            Result = res.Result
            ResultMessage = res?.ResultString
        End Sub
        Public Sub New(res As GetNextOrderResult)
            Item = res.Item
            Result = res.Result
            ResultMessage = res.ResultString
        End Sub

        Public Property Item As PlanItem
        Public Property Result As Integer
        Public Property ResultMessage As String
    End Class
End Class
