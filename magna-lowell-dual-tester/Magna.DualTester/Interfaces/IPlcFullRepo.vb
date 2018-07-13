Imports Magna.DualTester.Core
Imports Magna.DualTester.TesterApi

Public Interface IPlcFullRepo
    Inherits IPlcDataRepo

    Event TesterContextChanged As Action(Of Udt_tester)
    ReadOnly Property TesterData As Udt_tester

End Interface