Public Class AppSettings


    Public Shared Function DebugModeActive() As Boolean

        Return My.Application.CommandLineArgs.Any(Function(x) x = "-debug")
    End Function

    Friend Shared Function FakeBarcodeScanner() As Boolean
        Return My.Application.CommandLineArgs.Any(Function(x) x = "-fakebarcode")
    End Function
End Class
