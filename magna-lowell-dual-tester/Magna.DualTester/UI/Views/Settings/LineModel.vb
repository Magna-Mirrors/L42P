Imports Magna.DualTester.SchedulerServiceReference

Public Class LineModel
    Public Sub New()

    End Sub
    Public Sub New(line As Line)
        CustomerId = line.CustomerId
        CustomerName = line.CustomerName
        Description = line.Description
        Id = line.Id
        Name = line.Name
        ProgramId = line.ProgramId
        QueuedMinutes = line.QueuedMinutes
        ReOrderPercentThreshold = line.ReOrderPercentThreshold
        ScheduleFolder = line.ScheduleFolder
        SchedulerMethod = line.SchedulerMethod
        SelectCmd = line.SelectCmd
        UserCount = line.UserCount
        WC = line.WC
        WcfFileName = line.WcfFileName
        WorkBufferMinutes = line.WorkBufferMinutes
    End Sub

    Public Property CustomerId() As Integer
    Public Property CustomerName() As String
    Public Property Description() As String
    Public Property Id() As Integer
    Public Property Name() As String
    Public Property ProgramId() As Integer
    Public Property QueuedMinutes() As Single
    Public Property ReOrderPercentThreshold() As Single
    Public Property ScheduleFolder() As String
    Public Property SchedulerMethod() As SchedulerMethods
    Public Property SelectCmd() As String
    Public Property UserCount() As Single
    Public Property WC() As String
    Public Property WcfFileName() As String
    Public Property WorkBufferMinutes() As Integer

End Class
