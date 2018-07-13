Public Interface IPrint
    Inherits IDisposable

    Sub ReprintPrevious(printer As PrintCfg)
    Sub TestPrint(printer As PrintCfg)

End Interface
