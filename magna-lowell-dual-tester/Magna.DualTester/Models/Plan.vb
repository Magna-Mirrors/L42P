Imports Magna.DualTester.SchedulerServiceReference

Public Class Plan
    Public Sub New()

    End Sub
    Public Sub New(planItem As PlanItem)
        BuildID = planItem.BuildID
        Built = planItem.Built
        Chk = planItem.Chk
        CreationDate = planItem.CreationDate
        Desc = planItem.Desc
        DueDate = planItem.DueDate
        Flags = planItem.Flags
        HHMM = planItem.HHMM
        LastLoadTime = planItem.LastLoadTime
        MMDDYY = planItem.MMDDYY
        OrderId = planItem.OrderId
        Ordered = planItem.Ordered
        PPHPP = planItem.PPHPP
        PartId = planItem.PartId
        PartNumber = planItem.PartNumber
        Position = planItem.Position
        QTY = planItem.QTY
        ScheduleDate = planItem.ScheduleDate
        Shipdate = planItem.Shipdate
        Status = planItem.Status
        TargetLineId = planItem.TargetLineId
        Truck = planItem.Truck
    End Sub
    Public Property BuildID As String
    Public Property Built As Integer
    Public Property Chk As String
    Public Property CreationDate As Date
    Public Property Desc As String
    Public Property DueDate As Date
    Public Property Flags As OrderFlags
    Public Property HHMM As String
    Public Property LastLoadTime As Date
    Public Property MMDDYY As String
    Public Property OrderId As Integer
    Public Property Ordered As Integer
    Public Property PPHPP As Single
    Public Property PartId As Integer
    Public Property PartNumber As String
    Public Property Position As Long
    Public Property QTY As Integer
    Public Property ScheduleDate As Date
    Public Property Shipdate As Date
    Public Property Status As PlanStatus
    Public Property TargetLineId As Integer
    Public Property Truck As Boolean

End Class
