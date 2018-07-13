Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.Plc.Core.Tools
Imports Magna.DualTester.TesterApi
Imports Magna.DualTester.Core.Tools

Public Class Bindings
    Inherits Ninject.Modules.NinjectModule

    Public Overrides Sub Load()
        If AppSettings.DebugModeActive() Then
            Bind(Of ICfgNonDomino, ICfg).To(Of DebugCfgTool)()
            Bind(Of IUserWatch).To(Of DebugUserWatch).InSingletonScope()
        Else
            Bind(Of ICfgNonDomino, ICfg).To(Of CfgTool)()
            Bind(Of IUserWatch).To(Of UserWatch).InSingletonScope()
        End If

        If AppSettings.FakeBarcodeScanner() Then
            Bind(Of IBarcodeScanner).To(Of FakeBarcodeScanner).InSingletonScope()
        Else
            Bind(Of IBarcodeScanner, IStartupService).To(Of BarCodeScanner).InSingletonScope()
        End If

        Bind(Of IStringDefaults).To(Of StringDefaults).InSingletonScope()
        Bind(Of IAsTest).To(Of AsTest).InSingletonScope()
        Bind(Of IMessageAlertService, IPlcAlertService).To(Of MessageAlertService).InSingletonScope()
        Bind(Of IPlcCfgFactory).To(Of PlcCfgFactory).InSingletonScope()

        'Bind(Of IPlc, IPlc(Of Udt_tester)).To(Of DebugAsConnection).InSingletonScope()

        Bind(Of IPlc, IPlc(Of Udt_tester), IStartupService).To(Of AsConnection(Of Udt_tester)).InSingletonScope()
        Bind(Of CurrentOrderManager, IStartupService).To(Of CurrentOrderManager).InSingletonScope()

        Bind(Of ILanguageWatch).To(Of LanguageWatch).InSingletonScope()
        Bind(Of IPrint).To(Of PrintService).InSingletonScope()
        Bind(Of IPlcFullRepo, IPlcDataRepo).To(Of PlcDataRepo).InSingletonScope()
        'Bind(Of IShell).To(Of Form1).InSingletonScope()
        Bind(Of ReprintDialog).ToSelf().InTransientScope()
        Bind(Of PrnFileRepo).ToSelf().InSingletonScope()
        Bind(Of BarcodeService).ToSelf().InSingletonScope()
    End Sub
End Class
