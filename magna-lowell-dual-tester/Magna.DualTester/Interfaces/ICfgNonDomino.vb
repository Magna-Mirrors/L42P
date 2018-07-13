Imports Magna.DualTester.Core

Public Interface ICfgNonDomino
    Inherits ICfg
    Overloads Function ReadConfig() As NonDominoCfg
    Function WriteConfig(cfg As NonDominoCfg) As Boolean
End Interface