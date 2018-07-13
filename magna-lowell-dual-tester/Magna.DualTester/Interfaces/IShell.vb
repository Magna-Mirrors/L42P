Imports System.Threading.Tasks

Public Interface IShell

    Function LaunchDialog(Of T As Form)() As T

End Interface
