Imports Magna.DualTester.Core

Public Class LoadingStatus

    Public Sub New(servicename As String)
        InitializeComponent()
        LblServiceName.Text = servicename
    End Sub
    Public Sub SetStatus(stat As StartupEventResult)
        Dim run = Sub()
                      If stat Is Nothing Then
                          LblStatus.Text = "Error starting"
                          PicStatus.Image = ImageList1.Images(2)
                      Else
                          LblStatus.Text = stat.Message
                          PicStatus.Image = ImageList1.Images(If(stat.Ok, 1, 2))
                      End If
                  End Sub
        If Me.InvokeRequired Then
            Invoke(run)
        Else
            run()
        End If
    End Sub
End Class
