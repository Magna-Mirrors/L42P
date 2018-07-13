Imports System.IO
Imports System.Xml.Serialization
Imports Magna.DualTester
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data



Public Class CfgTool
    Implements ICfgNonDomino, ICfg


    ''' <summary>
    ''' This is the name of the file the settings will be saved to.
    ''' </summary>
    ''' <remarks>Might be a better idea to store and load this string in the app.config</remarks>
    Private Shared ReadOnly Property FileName As String = "TesterSettings.cfg"
    Private Shared Property SettingsPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "FeyenZylstra", "DualTesterNonDomino")
    Private Shared Property FilePath As String = Path.Combine(SettingsPath, FileName)
    Private Shared _cfg As NonDominoCfg


    Private ReadOnly _stringdefaults As IStringDefaults
    Public Sub New(stringdefaults As IStringDefaults)
        _stringdefaults = stringdefaults

    End Sub

    Private Function CreateNewCfg() As NonDominoCfg
        CheckDir()
        Dim c = New NonDominoCfg(_stringdefaults)
        WriteConfig(c)
        _cfg = c
        Return _cfg
    End Function

    Private Shared Sub CheckDir()
        If Not Directory.Exists(SettingsPath) Then
            Directory.CreateDirectory(SettingsPath)
        End If
    End Sub

    Public Function ReadConfig() As NonDominoCfg Implements ICfgNonDomino.ReadConfig
        If File.Exists(FilePath) Then
            Using sr As New StreamReader(FilePath)
                Dim s As New XmlSerializer(GetType(NonDominoCfg))
                _cfg = CType(s.Deserialize(sr), NonDominoCfg)
                If (_cfg.JobSchedularServiceAddress Is Nothing) Then
                    _cfg.JobSchedularServiceAddress = "http://localhost:8045"
                End If
            End Using
            Return _cfg
        Else
            Return CreateNewCfg()
        End If
    End Function

    Public Function WriteConfig(cfg As NonDominoCfg) As Boolean Implements ICfgNonDomino.WriteConfig
        Try
            Using sw As New StreamWriter(FilePath, False)
                Dim s As New XmlSerializer(cfg.GetType)
                s.Serialize(sw, cfg)
            End Using
        Catch ex As Exception
            Return False
        End Try
        _cfg = cfg
        Return True
    End Function

    Private Function ICfg_ReadConfig() As CfgSettings Implements ICfg.ReadConfig
        Return ReadConfig()
    End Function
End Class
