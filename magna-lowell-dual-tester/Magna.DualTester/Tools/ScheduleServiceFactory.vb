Imports System.ServiceModel
Imports Magna.DualTester.SchedulerServiceReference

Public Class ScheduleServiceFactory


    Private ReadOnly _cfg As ICfgNonDomino
    Public Sub New(cfg As ICfgNonDomino)
        _cfg = cfg
    End Sub



    Public Function GetInstance() As iSchedulerServiceClient
        Dim x = New iSchedulerServiceClient()
        x.Endpoint.Address = New EndpointAddress(_cfg.ReadConfig().JobSchedularServiceAddress + "/SchedulerService")
        x.Open()
        Return x
    End Function
    Public Function GetInstance(baseAddress As String) As iSchedulerServiceClient
        'Dim binding As New BasicHttpBinding(BasicHttpSecurityMode.None)
        'Dim host As New ServiceHost(GetType(iSchedulerServiceClient), New Uri(baseAddress + "/SchedulerService"))
        ''host.AddServiceEndpoint(GetType(iSchedulerService), binding, baseAddress)
        'host.Open()

        Dim x = New iSchedulerServiceClient()
        x.Endpoint.Address = New EndpointAddress(baseAddress + "/SchedulerService")
        x.Open()
        Return x
    End Function

End Class
