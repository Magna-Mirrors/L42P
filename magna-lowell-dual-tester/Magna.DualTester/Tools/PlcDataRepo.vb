Imports Magna.DualTester.TesterApi
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester

Public Class PlcDataRepo
    Implements IPlcFullRepo


    Private ReadOnly _plc As IPlc(Of Udt_tester)
    'Private ReadOnly _testerTranslate As ITranslate(Of Udt_tester, Model_tester)
    Public Event TesterChanged As Action Implements IPlcDataRepo.TesterChanged
    Public Event TesterContextChanged As Action(Of Udt_tester) Implements IPlcFullRepo.TesterContextChanged


    Private Property _cachedTester As Udt_tester

    Public Sub New(plc As IPlc(Of Udt_tester))
        _plc = plc
        '_testerTranslate = testerTranslate
        AddHandler _plc.TesterChanged, AddressOf OnTesterChanged

    End Sub

    Private Sub OnTesterChanged(obj As Udt_tester)
        _cachedTester = obj '_testerTranslate.Translate(_plc.TesterData)
        RaiseEvent TesterContextChanged(_cachedTester)
        RaiseEvent TesterChanged()
    End Sub

    Public ReadOnly Property TesterData As Udt_tester Implements IPlcFullRepo.TesterData
        Get
            Return _cachedTester
        End Get
    End Property

    Public ReadOnly Property GetPartNumber As String Implements IPlcDataRepo.GetPartNumber
        Get
            Return _plc.TesterData.PartInfo.Pn.ToString()
        End Get
    End Property

    Public ReadOnly Property GetToteTarget As Integer Implements IPlcDataRepo.GetToteTarget
        Get
            Return _plc.TesterData.Counts.ToteTarget
        End Get
    End Property

    Public ReadOnly Property GetIsServicePart As Boolean Implements IPlcDataRepo.GetIsServicePart
        Get
            Return _plc.TesterData.PartInfo.Service
        End Get
    End Property

    Public ReadOnly Property PrnStringReplacements As IDictionary(Of String, String) Implements IPlcDataRepo.PrnStringReplacements
        Get
            Return New Dictionary(Of String, String) From {{"$PN$", _plc.TesterData.PartInfo.Pn.ToString()},
                                                                     {"$CPN$", _plc.TesterData.PartInfo.Cpn.ToString()},
                                                                     {"$SPN$", _plc.TesterData.PartInfo.SvcPn.ToString()},
                                                                     {"$DESC1$", _plc.TesterData.PartInfo.Desc1.ToString()},
                                                                     {"$DESC2$", _plc.TesterData.PartInfo.Desc2.ToString()},
                                                                      {"MM-DD-YY", DateTime.Now.ToString("MM-dd-yy")},
                                                                      {"HH:MM:SS", DateTime.Now.ToString("HH:mm:ss")},
                                                                      {"YYMMDD", DateTime.Now.ToString("yyMMdd")},
                                                                      {"$SHIFT$", _plc.TesterData.ShiftValue.ToString()},
                                                                      {"$SHIFTCOUNT$", _plc.TesterData.Counts.ShiftPassCount.ToString()},
                                                                      {"$PACKER$", _plc.TesterData.User.ClockNumber.ToString()},
                                                                       {"$TXT$", _plc.TesterData.PartInfo.Static_Label.ToString()},
                                                                       {"$QTY$", _plc.TesterData.PartInfo.PartsPerTote.ToString()}}
        End Get
    End Property

    Public ReadOnly Property Nest1SequenceStep As Integer Implements IPlcDataRepo.Nest1SequenceStep
        Get
            Return _plc.TesterData.Nest1.SeqVal
        End Get
    End Property

    Public ReadOnly Property Nest2SequenceStep As Integer Implements IPlcDataRepo.Nest2SequenceStep
        Get
            Return _plc.TesterData.Nest2.SeqVal
        End Get
    End Property

    Public ReadOnly Property User As User Implements IPlcDataRepo.User
        Get
            '_plc.TesterData.User
            Dim usr = _plc.TesterData.User
            Dim u = New User() With {.BadgeNumber = usr.BadgeNumber,
                                    .ClockNumber = usr.ClockNumber,
                                    .Username = usr.Username.ToString(),
                                    .LogOutRequest = usr.LogOutRequest,
                                    .State = usr.State,
                                    .StationNumber = usr.StationNumber,
                                    .RemainingQualityAlerts = usr.RemainingQualityAlerts,
                                    .reamaingTrainingItems = usr.ReamaingTrainingItems,
                                    .reamaingTrainingHours = usr.ReamaingTrainingHours,
                                    .RemainingErgoHours = usr.RemainingErgoHours,
                                    .AccessLevel = IntToAccessLevel(usr.AccessLevel)}
            Return u
        End Get
    End Property

    Public ReadOnly Property ToteCount As Integer Implements IPlcDataRepo.ToteCount
        Get
            Return _plc.TesterData.Counts.ToteCount
        End Get
    End Property

    Public ReadOnly Property ToteTarget As Integer Implements IPlcDataRepo.ToteTarget
        Get
            Return _plc.TesterData.Counts.ToteTarget
        End Get
    End Property

    Public ReadOnly Property Nest1ResultCode As Integer Implements IPlcDataRepo.Nest1ResultCode
        Get
            Return _plc.TesterData.Nest1.Logitems.ResultCode
        End Get
    End Property

    Public ReadOnly Property Nest2ResultCode As Integer Implements IPlcDataRepo.Nest2ResultCode
        Get
            Return _plc.TesterData.Nest2.Logitems.ResultCode
        End Get
    End Property

    Public ReadOnly Property Nest1ModeStatus As NestModeStatus Implements IPlcDataRepo.Nest1ModeStatus
        Get
            Return DirectCast(_plc.TesterData.Nest1.ModeStatus, NestModeStatus)
        End Get
    End Property

    Public ReadOnly Property Nest2ModeStatus As NestModeStatus Implements IPlcDataRepo.Nest2ModeStatus
        Get
            Return DirectCast(_plc.TesterData.Nest2.ModeStatus, NestModeStatus)
        End Get
    End Property
    Private Shared Function IntToAccessLevel(usr As Integer) As AccessLevel
        If usr < AccessLevel.[Operator] Then
            Return AccessLevel.None
        ElseIf usr < AccessLevel.Supervisor Then
            Return AccessLevel.[Operator]
        ElseIf usr < AccessLevel.Tech Then
            Return AccessLevel.Supervisor
        ElseIf usr < AccessLevel.Engineer Then
            Return AccessLevel.Tech
        ElseIf usr < AccessLevel.Admin Then
            Return AccessLevel.Engineer
        End If
        Return AccessLevel.Admin
    End Function
End Class