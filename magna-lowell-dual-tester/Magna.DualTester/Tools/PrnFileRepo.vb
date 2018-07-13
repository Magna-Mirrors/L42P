Imports System.IO

Public Class PrnFileRepo
    Private Shared Property PrnFileDirectory As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "FeyenZylstra", "DualTesterNonDomino", "PrnFiles")

    Public Function GetPrnFiles() As IEnumerable(Of String)
        If Not Directory.Exists(PrnFileDirectory) Then
            Directory.CreateDirectory(PrnFileDirectory)
        End If
        Dim files = Directory.EnumerateFiles(PrnFileDirectory).Where(Function(x) Path.GetExtension(x) = ".prn").ToList()
        Return files.Select(Function(x) Path.GetFileName(x))
    End Function

    Public Function GetPrnFileStream(filename As String) As String
        Dim filepath = Path.Combine(PrnFileDirectory, filename)
        If Not File.Exists(filepath) Then
            Throw New FileNotFoundException("", filepath)
        End If
        Dim output As String

        Using sr As New StreamReader(filepath)
            output = sr.ReadToEnd()
        End Using



        Return output
    End Function
End Class
