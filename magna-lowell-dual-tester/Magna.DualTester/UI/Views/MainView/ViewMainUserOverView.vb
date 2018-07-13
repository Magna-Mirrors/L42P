Imports System.Reflection
Imports System.Threading.Tasks
Imports Magna.DualTester.My.Resources
Imports Magna.DualTester.UI.Dialogs
Imports Magna.DualTester.TesterApi
Imports NLog
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core.PlcStrings
Imports Magna.DualTester.Core.Tools

Namespace UI.Views.MainView



    Public Class ViewMainUserOverView
        Implements IViewTask

        ReadOnly Property _isUserEnieOrBetter As Boolean
            Get
                Return _userWatch.CheckCurrentUserPermission(AccessLevel.Engineer)
            End Get
        End Property
        ReadOnly Property _isUserSupervisorOrBetter As Boolean
            Get
                Return _userWatch.CheckCurrentUserPermission(AccessLevel.Supervisor)
            End Get
        End Property
        ReadOnly Property _isUserOperator As Boolean
            Get
                Return _userWatch.CheckCurrentUserPermission(AccessLevel.Operator)
            End Get
        End Property

        ''' <summary>
        ''' the key will be a field name in a class and the value will be its corresponding cell
        ''' </summary>
        Private ReadOnly Property _cellDictPartData As New Dictionary(Of String, FlexCell.Cell)()
        ''' <summary>
        ''' the key will be a field name in a class and the value will be its corresponding cell
        ''' </summary>
        Private ReadOnly Property _cellDictPartOptions As New Dictionary(Of String, FlexCell.Cell)()
        Private ReadOnly Property _cellDictGlassOptions As New Dictionary(Of String, FlexCell.Cell)()

        ''' <summary>
        ''' This will hold the data every time the udt data structure is reloaded.
        ''' </summary>
        ''' <remarks></remarks>
        Private Property _tester As Udt_tester
        Dim logger As Logger = LogManager.GetCurrentClassLogger()
        Private Property PendingToteCountAtZero As Boolean

        Public Property RunningTask As Task Implements IViewTask.RunningTask


        Private ReadOnly _langWatch As ILanguageWatch
        Private ReadOnly _userWatch As IUserWatch
        Private ReadOnly _plc As IPlc
        Private ReadOnly _plcrepo As IPlcFullRepo
        Private ReadOnly _cfg As ICfgNonDomino
        Private ReadOnly _msgsvc As IMessageAlertService
        Private loading As Boolean = False

        Public Sub New(cfg As ICfgNonDomino, langWatch As ILanguageWatch, userWatch As IUserWatch, plc As IPlc, plcrepo As IPlcFullRepo, msgsvc As IMessageAlertService)
            'MyBase.New(AccessLevel.Engineer)
            'MyBase.New(AccessLevel.None)
            _langWatch = langWatch
            _userWatch = userWatch
            _plcrepo = plcrepo
            _msgsvc = msgsvc
            _cfg = cfg
            _plc = plc
            InitializeComponent()
            'SetupMidTopGrid()
            'SetupMidBottomGrid()

            SetupGrid(Of Udt_PartInformation)(GridPartData, _cellDictPartData, {"Options"})
            SetupGrid(Of Udt_PartOptions)(GridPartOptions, _cellDictPartOptions, {})
            SetupGrid(Of Udt_GlassOptions)(GridGlassOptions, _cellDictGlassOptions, {})

            PendingToteCountAtZero = False
            Me.Nest1DataControl.SetPlc = _plc
            Me.Nest2DataControl.SetPlc = _plc
            Nest1DataControl.SetMessageService = msgsvc
            Nest2DataControl.SetMessageService = msgsvc
        End Sub

        Private Sub IViewTask_Load() Implements IViewTask.Load
            LoadData(_plcrepo.TesterData)
            AddHandler _plcrepo.TesterContextChanged, AddressOf LoadData
        End Sub

        Private Shared Sub SetUpGridCommon(grid As FlexCell.Grid)
            With grid
                .Cols = 4
                .Range(0, 0, .Rows - 1, 1).Locked = True
                .Row(0).Height = 0
                .Column(0).Visible = False
                .Column(0).Width = 0
                .Column(1).Width = CShort((.Width - 2) * 0.33)
                .Column(2).Width = CShort((.Width - 2) * 0.33)
                .Column(3).Width = CShort((.Width - 2) * 0.33)
                Dim center = .Range(1, 2, .Rows - 1, 2)
                center.Alignment = FlexCell.AlignmentEnum.CenterCenter
                center.BackColor = Color.LightGray
                center.Locked = True
            End With
        End Sub
        Public Shared Sub SetupGrid(Of T)(grid As FlexCell.Grid, celldict As Dictionary(Of String, FlexCell.Cell), ignores As IEnumerable(Of String))
            With grid
                Dim properties() As FieldInfo = GetType(T).GetFields() 'this contains a list of fields inside the model_partTestOptions
                .Rows = properties.Count + 1
                .Cols = 4
                Dim count = 0
                For Each item As FieldInfo In properties
                    If Not ignores.Any() OrElse ignores.All(Function(x) Not item.Name.Contains(x)) Then
                        .Cell(count + 1, 1).Text = item.Name
                        celldict.Add(item.Name, .Cell(count + 1, 2))
                        count += 1
                    End If
                Next
            End With
            SetUpGridCommon(grid)
        End Sub

        Private Sub UpdateSubViews(data As Udt_tester)
            Dim c = _cfg.ReadConfig()
            Dim colors = _plc.Colors
            Dim n1Vm = New NestDataControlViewModel(1, data.Nest1, _langWatch.CurrentValue, c, colors)
            Dim n2Vm = New NestDataControlViewModel(2, data.Nest2, _langWatch.CurrentValue, c, colors)
            Nest1DataControl.UpdateViewModel(n1Vm)
            Nest2DataControl.UpdateViewModel(n2Vm)
        End Sub

        ''' <summary>
        ''' If any values under tester count are less than zero then the value will be set to zero.
        ''' </summary>
        Private Async Function FixCounts() As Task
            Dim cnts = _tester.Counts
            Dim failed = New List(Of String)
            Dim props = GetType(Udt_Tester_Counts).GetFields()
            For Each p In props
                If p.Name <> "BatchCountDown" Then
                    Dim i As Integer = CInt(p.GetValue(cnts))
                    If i < 0 Then
                        p.SetValue(cnts, 0)
                        failed.Add(p.Name)
                    End If
                End If
            Next
            If failed.Count > 0 Then
                Await WriteToPlcAsync(My.Resources.Tag_Counts, cnts, $"Value/s < 0 in counts {String.Join(",", failed)} set to 0")
            End If
        End Function

        Private Sub LoadData(data As Udt_tester)
            If data Is Nothing Then
                _msgsvc.PublishNewAlarm("_tester is null", ErrorLevel.Alert)
                'Throw New ArgumentNullException("The tester udt is null in the LoadData method")
            Else
                _tester = data
                If RunningTask Is Nothing OrElse RunningTask.IsCompleted Then
                    RunningTask = LoadView()
                End If
            End If
        End Sub

        Private Async Function LoadView() As Task
            UpdateSubViews(_tester)
            If loading Then
                Return
            End If
            loading = True

            '-----------------------------------------Set the counts to zero if they are less than zero----------------------
            Await FixCounts()

            '-----------------------------------------------adjust batchCount if 0------------------------------------------
            'If _tester.Counts.BatchCountDown <= 0 Then
            '    If _isUserSupervisorOrBetter Then
            '        PendingToteCountAtZero = Not (PendingToteCountAtZero AndAlso _tester.Counts.ToteCount = 0)

            '        If Not PendingToteCountAtZero Then
            '            Dim t1 = Task.Factory.StartNew(Sub()
            '                                               Dim runIt = Async Sub()
            '                                                               Dim NewPnQty = New PnAndQtyEdit("Part Number and Batch Qty", _tester.Counts.BatchCountDown, _userWatch.CurrentValue, _tester.PartInfo.Pn.ToString(), _msgsvc)
            '                                                               If _tester.Counts.ToteCount > 0 AndAlso _tester.PartInfo.Pn.ToString().Count() < 2 Then
            '                                                                   Await WriteToPlcAsync(My.Resources.Tag_Counts_ToteCount, 0)
            '                                                                   NewPnQty.ToteAccum = 0
            '                                                               Else
            '                                                                   NewPnQty.ToteAccum = _tester.Counts.ToteCount
            '                                                               End If
            '                                                               Dim Dr = NewPnQty.ShowDialog(Me)
            '                                                               If Dr = DialogResult.OK Then
            '                                                                   _plc.ManualWriteString82(My.Resources.Tag_PnToFind, NewPnQty.Pn.ToUpperInvariant().TrimStart(CChar("Z")))
            '                                                                   _plc.ManualWrite(My.Resources.Tag_Counts_Batch_CountDown, NewPnQty.Value)
            '                                                               ElseIf Dr = DialogResult.Abort Then
            '                                                                   PendingToteCountAtZero = NewPnQty.PrintToteLabel Or NewPnQty.EndTote
            '                                                                   If NewPnQty.EndTote Then
            '                                                                       _plc.ManualWrite(My.Resources.Tag_Counts_ToteCount, 0)
            '                                                                   End If
            '                                                               End If

            '                                                               NewPnQty = Nothing
            '                                                           End Sub
            '                                               Me.Invoke(runIt)
            '                                           End Sub)

            '            Await t1
            '            Debug.Print("Done running update view")
            '        End If
            '    Else
            '        _msgsvc.PublishNewAlarm("Login as Supervisor or better to adjust counts", ErrorLevel.Alert)
            '    End If
            'End If

            '-----------------------------------------------update ui-------------------------------------------------------
            Dim run = Sub()
                          Try
                              Select Case (_tester.Daq_Hb.Status)
                                  Case 1
                                      LblDaq.BackColor = Color.LimeGreen
                                  Case 2
                                      LblDaq.BackColor = Color.Yellow
                                  Case > 2
                                      LblDaq.BackColor = Color.Red
                              End Select


                              LblFailValue.Text = _tester.Counts.ShiftFailCount.ToString()
                              LblPassValue.Text = _tester.Counts.ShiftPassCount.ToString()
                              LblToteDownValue.Text = _tester.Counts.ToteCount.ToString()
                              LblToteTargetValue.Text = _tester.Counts.ToteTarget.ToString()
                              '----------------------------------------------Sets the Batch count label color-------------------------------------------------

                              Dim needsData = _tester.Counts.BatchCountDown <= 0 AndAlso _tester.PartInfo.Pn.ToString() <> String.Empty
                              LblBatchCount.BackColor = If(needsData, Color.Salmon, Color.Black)
                              LblBatchCount.ForeColor = If(needsData, Color.Black, Color.White)
                              LblBatchCount.Text = _tester.Counts.BatchCountDown.ToString()

                              '\/ top grid write -------------------------------------------------------------------
                              Dim objN1 As Udt_PartInformation = _tester.PartInfo '.Nest1.PartInfo         
                              For Each item As FieldInfo In GetType(Udt_PartInformation).GetFields()
                                  If item.FieldType Is GetType(PlcString_82) Then
                                      _cellDictPartData(item.Name).Text = DirectCast(item.GetValue(objN1), PlcString_82).ToString()
                                  ElseIf item.FieldType Is GetType(PlcString_8) Then
                                      _cellDictPartData(item.Name).Text = DirectCast(item.GetValue(objN1), PlcString_8).ToString()
                                  ElseIf item.FieldType.IsPrimitive Then
                                      _cellDictPartData(item.Name).Text = item.GetValue(objN1).ToString()
                                  End If
                              Next

                              '\/------------------------------bottom grid write -----------------------------------
                              Dim tmpN1 As Udt_PartOptions = objN1.PartOptions
                              For Each item As FieldInfo In GetType(Udt_PartOptions).GetFields()
                                  _cellDictPartOptions(item.Name).Text = DirectCast(item.GetValue(tmpN1), Udt_Opt_Item).Config.ToString()
                              Next

                              Dim tmpG1 As Udt_GlassOptions = objN1.GlassOptions
                              For Each item As FieldInfo In GetType(Udt_GlassOptions).GetFields()
                                  _cellDictGlassOptions(item.Name).Text = DirectCast(item.GetValue(tmpG1), Udt_Opt_Item).Config.ToString()
                              Next


                          Catch ex As Exception
                              logger.Error(ex.Message)
                              _msgsvc.PublishNewAlarm(ex.Message, ErrorLevel.Error)
                          End Try
                      End Sub
            If Me.InvokeRequired Then Me.BeginInvoke(run) Else run()
            loading = False
        End Function

        Private Async Function WriteToPlcAsync(address As String, obj As Object, Optional message As String = Nothing) As Task
            Await _plc.ManualWriteAsync(New SaveEventArgs(address, obj, message:=message))
        End Function

        Public Async Function BeginClose() As Task Implements IViewTask.BeginClose
            RemoveHandler _plcrepo.TesterContextChanged, AddressOf LoadData
            If RunningTask IsNot Nothing Then
                Await RunningTask
            End If
        End Function

#Region "Label event handlers"
        Private Sub Lbl_dblClickAsync(sender As Object, e As EventArgs) Handles LblFailValue.DoubleClick, LblToteTargetValue.DoubleClick,
                                                                             LblToteDownValue.DoubleClick, LblBatchCount.DoubleClick,
                                                                             LblPassValue.DoubleClick, GridPartData.DoubleClick


            Dim showEdit = Sub(title As String, val As Integer, address As String)
                               Dim d As New DialogCountEdit(title, val)
                               d.ShowDialog(Me)
                               If d.DialogResult = DialogResult.OK Then
                                   Dim incdec As String = If(val > d.Value, "Decremented", "Incremented")
                                   If d.Value >= 0 Then
                                       _plc.ManualWrite(address, d.Value, message:=String.Format("{0} was {1} to {2}", title, incdec, d.Value))
                                   Else
                                       _msgsvc.PublishNewAlarm("Count cannot be below 0", ErrorLevel.Alert)
                                   End If
                               End If
                           End Sub
            If _isUserOperator Then
                If sender Is GridPartData Then
                    Const InSeqVal As Integer = 20

                    Dim inSeqLeft = _tester.Nest1.SeqVal > InSeqVal
                    Dim inSeqRight = _tester.Nest2.SeqVal > InSeqVal
                    Dim both = inSeqRight AndAlso inSeqLeft

                    If inSeqLeft OrElse inSeqRight Then
                        Dim prefix = If(both, "Left & Right", If(inSeqLeft, "Left", "Right"))
                        _msgsvc.PublishNewAlarm($"{prefix} side Tester in Sequence (>={InSeqVal}), Pn Change Not available", ErrorLevel.Alert)
                        Exit Sub
                    End If


                    If _tester.Counts.ToteCount > 0 Then
                        _msgsvc.PublishNewAlarm("Tote Accum must be 0 to Change part Number", ErrorLevel.Alert)
                        Exit Sub
                    End If

                    Dim dilg As New DialogStringEdit("Edit Part Number", _tester.PartInfo.Pn.ToString())
                    dilg.ShowDialog(Me)
                    If dilg.DialogResult = DialogResult.OK Then
                        _plc.ManualWriteString82(Tag_PnToFind, dilg.Value.ToUpperInvariant().TrimStart(CChar("Z")))
                        If _isUserSupervisorOrBetter Then
                            Dim batchDialog As New ValueDialog("Batch Count", "Count", _tester.Counts.BatchCountDown, _userWatch.CurrentValue, _msgsvc) 'These Lines were commented out
                            batchDialog.ShowDialog(Me)
                            _tester.Counts.BatchCountDown = CInt(batchDialog.Value)
                            _plc.ManualWrite(My.Resources.Tag_Counts, CObj(_tester.Counts))
                        End If
                    End If
                    Exit Sub
                End If
                If _isUserSupervisorOrBetter Then
                    If sender Is LblFailValue Then
                        showEdit("Shift Fail Count", _tester.Counts.ShiftFailCount, Tag_TesterAddress + ".Counts.ShiftFailCount")
                    ElseIf sender Is LblToteTargetValue Then
                        showEdit("Tote Target Count", _tester.Counts.ToteTarget, My.Resources.Tag_Counts_ToteTarget)
                    ElseIf sender Is LblToteDownValue Then
                        showEdit("Tote Part Count", _tester.Counts.ToteCount, My.Resources.Tag_Counts_ToteCount)
                    ElseIf sender Is LblPassValue Then
                        showEdit("Shift Pass Count", _tester.Counts.ShiftPassCount, My.Resources.Tag_Counts_Shift_Pass_Count)
                    ElseIf sender Is LblBatchCount Then
                        Dim NewPnQty = New PnAndQtyEdit("Part Number and Batch Qty", _tester.Counts.BatchCountDown, _userWatch.CurrentValue, _tester.PartInfo.Pn.ToString(), _msgsvc)
                        Dim Dr = NewPnQty.ShowDialog(Me)
                        If Dr = DialogResult.OK Then
                            _plc.ManualWriteString82(My.Resources.Tag_PnToFind, NewPnQty.Pn.ToUpperInvariant().TrimStart(CChar("Z")))
                            _plc.ManualWrite(My.Resources.Tag_Counts_Batch_CountDown, NewPnQty.Value)
                        ElseIf Dr = DialogResult.Abort Then
                            PendingToteCountAtZero = NewPnQty.PrintToteLabel Or NewPnQty.EndTote
                            If NewPnQty.EndTote Then
                                _plc.ManualWrite(My.Resources.Tag_Counts_ToteCount, 0)
                            End If
                        End If
                        Exit Sub
                    Else
                        _msgsvc.PublishNewAlarm(MessageAlertService.PermissionAlert, ErrorLevel.Alert)
                    End If
                End If
            End If
        End Sub


#End Region

    End Class
    Public Class NestPair(Of T)
        Public Sub New(nest1 As T, nest2 As T)
            Me.Nest1 = nest1
            Me.Nest2 = nest2
        End Sub
        Public Property Nest1 As T
        Public Property Nest2 As T

    End Class
End Namespace