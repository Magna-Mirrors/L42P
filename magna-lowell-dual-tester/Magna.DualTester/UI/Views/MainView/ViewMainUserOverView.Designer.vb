
Imports Magna.DualTester.UI.Views.MainView.SubViews

Namespace UI.Views.MainView

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ViewMainUserOverView
        Inherits UserControl

        'UserControl overrides dispose to clean up the component list.
        '<System.Diagnostics.DebuggerNonUserCode()> _
        'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        '    Try
        '        If disposing AndAlso components IsNot Nothing Then
        '            components.Dispose()
        '        End If
        '    Finally
        '        MyBase.Dispose(disposing)
        '    End Try
        'End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.TableLayoutTopCenter = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
            Me.LblToteQtyReqHeader = New System.Windows.Forms.Label()
            Me.LblToteDoneHeader = New System.Windows.Forms.Label()
            Me.LblToteTargetValue = New System.Windows.Forms.Label()
            Me.LblToteDownValue = New System.Windows.Forms.Label()
            Me.LblToteHeader = New System.Windows.Forms.Label()
            Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
            Me.LblPassHeader = New System.Windows.Forms.Label()
            Me.LblFailHeader = New System.Windows.Forms.Label()
            Me.LblFailValue = New System.Windows.Forms.Label()
            Me.LblPassValue = New System.Windows.Forms.Label()
            Me.LblTotalTitle = New System.Windows.Forms.Label()
            Me.LblBatchCount = New System.Windows.Forms.Label()
            Me.GridPartData = New FlexCell.Grid()
            Me.GridPartOptions = New FlexCell.Grid()
            Me.GridGlassOptions = New FlexCell.Grid()
            Me.LblPartInfoTitle = New System.Windows.Forms.Label()
            Me.LblDaq = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Nest1DataControl = New Magna.DualTester.UI.Views.MainView.SubViews.NestDataControl()
            Me.Nest2DataControl = New Magna.DualTester.UI.Views.MainView.SubViews.NestDataControl()
            Me.TableLayoutBase = New System.Windows.Forms.TableLayoutPanel()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.TableLayoutTopCenter.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.TableLayoutPanel6.SuspendLayout()
            Me.TableLayoutPanel7.SuspendLayout()
            Me.TableLayoutPanel4.SuspendLayout()
            Me.TableLayoutPanel5.SuspendLayout()
            Me.TableLayoutBase.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutTopCenter
            '
            Me.TableLayoutTopCenter.AutoSize = True
            Me.TableLayoutTopCenter.ColumnCount = 1
            Me.TableLayoutTopCenter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutTopCenter.Controls.Add(Me.TableLayoutPanel3, 0, 0)
            Me.TableLayoutTopCenter.Controls.Add(Me.LblBatchCount, 0, 2)
            Me.TableLayoutTopCenter.Controls.Add(Me.GridPartData, 0, 5)
            Me.TableLayoutTopCenter.Controls.Add(Me.GridPartOptions, 0, 7)
            Me.TableLayoutTopCenter.Controls.Add(Me.GridGlassOptions, 0, 9)
            Me.TableLayoutTopCenter.Controls.Add(Me.LblPartInfoTitle, 0, 4)
            Me.TableLayoutTopCenter.Controls.Add(Me.LblDaq, 0, 3)
            Me.TableLayoutTopCenter.Controls.Add(Me.Label8, 0, 1)
            Me.TableLayoutTopCenter.Controls.Add(Me.Label1, 0, 6)
            Me.TableLayoutTopCenter.Controls.Add(Me.Label2, 0, 8)
            Me.TableLayoutTopCenter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutTopCenter.Location = New System.Drawing.Point(509, 3)
            Me.TableLayoutTopCenter.Name = "TableLayoutTopCenter"
            Me.TableLayoutTopCenter.RowCount = 10
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutTopCenter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutTopCenter.Size = New System.Drawing.Size(244, 857)
            Me.TableLayoutTopCenter.TabIndex = 19
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.AutoSize = True
            Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel3.ColumnCount = 1
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel6, 0, 1)
            Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 2
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(244, 140)
            Me.TableLayoutPanel3.TabIndex = 21
            '
            'TableLayoutPanel6
            '
            Me.TableLayoutPanel6.AutoSize = True
            Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
            Me.TableLayoutPanel6.ColumnCount = 1
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 1)
            Me.TableLayoutPanel6.Controls.Add(Me.LblToteHeader, 0, 0)
            Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 71)
            Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
            Me.TableLayoutPanel6.RowCount = 2
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel6.Size = New System.Drawing.Size(244, 69)
            Me.TableLayoutPanel6.TabIndex = 23
            '
            'TableLayoutPanel7
            '
            Me.TableLayoutPanel7.AutoSize = True
            Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel7.ColumnCount = 2
            Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel7.Controls.Add(Me.LblToteQtyReqHeader, 0, 0)
            Me.TableLayoutPanel7.Controls.Add(Me.LblToteDoneHeader, 1, 0)
            Me.TableLayoutPanel7.Controls.Add(Me.LblToteTargetValue, 0, 1)
            Me.TableLayoutPanel7.Controls.Add(Me.LblToteDownValue, 1, 1)
            Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel7.Location = New System.Drawing.Point(2, 17)
            Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
            Me.TableLayoutPanel7.RowCount = 2
            Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel7.Size = New System.Drawing.Size(240, 50)
            Me.TableLayoutPanel7.TabIndex = 23
            '
            'LblToteQtyReqHeader
            '
            Me.LblToteQtyReqHeader.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.LblToteQtyReqHeader.AutoSize = True
            Me.LblToteQtyReqHeader.Location = New System.Drawing.Point(32, 0)
            Me.LblToteQtyReqHeader.Name = "LblToteQtyReqHeader"
            Me.LblToteQtyReqHeader.Size = New System.Drawing.Size(55, 13)
            Me.LblToteQtyReqHeader.TabIndex = 0
            Me.LblToteQtyReqHeader.Text = "QTY REQ"
            Me.LblToteQtyReqHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblToteDoneHeader
            '
            Me.LblToteDoneHeader.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.LblToteDoneHeader.AutoSize = True
            Me.LblToteDoneHeader.Location = New System.Drawing.Point(161, 0)
            Me.LblToteDoneHeader.Name = "LblToteDoneHeader"
            Me.LblToteDoneHeader.Size = New System.Drawing.Size(38, 13)
            Me.LblToteDoneHeader.TabIndex = 1
            Me.LblToteDoneHeader.Text = "DONE"
            Me.LblToteDoneHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblToteTargetValue
            '
            Me.LblToteTargetValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblToteTargetValue.AutoSize = True
            Me.LblToteTargetValue.BackColor = System.Drawing.Color.Black
            Me.LblToteTargetValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblToteTargetValue.ForeColor = System.Drawing.Color.Lime
            Me.LblToteTargetValue.Location = New System.Drawing.Point(3, 13)
            Me.LblToteTargetValue.Name = "LblToteTargetValue"
            Me.LblToteTargetValue.Size = New System.Drawing.Size(114, 37)
            Me.LblToteTargetValue.TabIndex = 4
            Me.LblToteTargetValue.Text = "0"
            Me.LblToteTargetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ToolTip1.SetToolTip(Me.LblToteTargetValue, "Double click to edit")
            '
            'LblToteDownValue
            '
            Me.LblToteDownValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblToteDownValue.AutoSize = True
            Me.LblToteDownValue.BackColor = System.Drawing.Color.Black
            Me.LblToteDownValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblToteDownValue.ForeColor = System.Drawing.Color.Lime
            Me.LblToteDownValue.Location = New System.Drawing.Point(123, 13)
            Me.LblToteDownValue.Name = "LblToteDownValue"
            Me.LblToteDownValue.Size = New System.Drawing.Size(114, 37)
            Me.LblToteDownValue.TabIndex = 5
            Me.LblToteDownValue.Text = "0"
            Me.LblToteDownValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ToolTip1.SetToolTip(Me.LblToteDownValue, "Double click to edit")
            '
            'LblToteHeader
            '
            Me.LblToteHeader.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.LblToteHeader.AutoSize = True
            Me.LblToteHeader.Location = New System.Drawing.Point(76, 2)
            Me.LblToteHeader.Name = "LblToteHeader"
            Me.LblToteHeader.Size = New System.Drawing.Size(92, 13)
            Me.LblToteHeader.TabIndex = 24
            Me.LblToteHeader.Text = "CURRENT TOTE"
            Me.LblToteHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TableLayoutPanel4
            '
            Me.TableLayoutPanel4.AutoSize = True
            Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
            Me.TableLayoutPanel4.ColumnCount = 1
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
            Me.TableLayoutPanel4.Controls.Add(Me.LblTotalTitle, 0, 0)
            Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
            Me.TableLayoutPanel4.RowCount = 2
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel4.Size = New System.Drawing.Size(244, 71)
            Me.TableLayoutPanel4.TabIndex = 22
            '
            'TableLayoutPanel5
            '
            Me.TableLayoutPanel5.AutoSize = True
            Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel5.ColumnCount = 2
            Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel5.Controls.Add(Me.LblPassHeader, 0, 0)
            Me.TableLayoutPanel5.Controls.Add(Me.LblFailHeader, 1, 0)
            Me.TableLayoutPanel5.Controls.Add(Me.LblFailValue, 1, 1)
            Me.TableLayoutPanel5.Controls.Add(Me.LblPassValue, 0, 1)
            Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel5.Location = New System.Drawing.Point(2, 17)
            Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
            Me.TableLayoutPanel5.RowCount = 2
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel5.Size = New System.Drawing.Size(240, 52)
            Me.TableLayoutPanel5.TabIndex = 23
            '
            'LblPassHeader
            '
            Me.LblPassHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblPassHeader.AutoSize = True
            Me.LblPassHeader.BackColor = System.Drawing.Color.Lime
            Me.LblPassHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPassHeader.Location = New System.Drawing.Point(3, 0)
            Me.LblPassHeader.Name = "LblPassHeader"
            Me.LblPassHeader.Size = New System.Drawing.Size(114, 15)
            Me.LblPassHeader.TabIndex = 0
            Me.LblPassHeader.Text = "Passing"
            Me.LblPassHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblFailHeader
            '
            Me.LblFailHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblFailHeader.AutoSize = True
            Me.LblFailHeader.BackColor = System.Drawing.Color.Red
            Me.LblFailHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblFailHeader.Location = New System.Drawing.Point(123, 0)
            Me.LblFailHeader.Name = "LblFailHeader"
            Me.LblFailHeader.Size = New System.Drawing.Size(114, 15)
            Me.LblFailHeader.TabIndex = 1
            Me.LblFailHeader.Text = "Failing"
            Me.LblFailHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblFailValue
            '
            Me.LblFailValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblFailValue.AutoSize = True
            Me.LblFailValue.BackColor = System.Drawing.Color.Black
            Me.LblFailValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblFailValue.ForeColor = System.Drawing.Color.Red
            Me.LblFailValue.Location = New System.Drawing.Point(123, 15)
            Me.LblFailValue.Name = "LblFailValue"
            Me.LblFailValue.Size = New System.Drawing.Size(114, 37)
            Me.LblFailValue.TabIndex = 3
            Me.LblFailValue.Text = "0"
            Me.LblFailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ToolTip1.SetToolTip(Me.LblFailValue, "Double click to edit")
            '
            'LblPassValue
            '
            Me.LblPassValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblPassValue.AutoSize = True
            Me.LblPassValue.BackColor = System.Drawing.Color.Black
            Me.LblPassValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPassValue.ForeColor = System.Drawing.Color.Lime
            Me.LblPassValue.Location = New System.Drawing.Point(3, 15)
            Me.LblPassValue.Name = "LblPassValue"
            Me.LblPassValue.Size = New System.Drawing.Size(114, 37)
            Me.LblPassValue.TabIndex = 4
            Me.LblPassValue.Text = "0"
            Me.LblPassValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ToolTip1.SetToolTip(Me.LblPassValue, "Double click to edit")
            '
            'LblTotalTitle
            '
            Me.LblTotalTitle.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.LblTotalTitle.AutoSize = True
            Me.LblTotalTitle.Location = New System.Drawing.Point(92, 2)
            Me.LblTotalTitle.Name = "LblTotalTitle"
            Me.LblTotalTitle.Size = New System.Drawing.Size(60, 13)
            Me.LblTotalTitle.TabIndex = 24
            Me.LblTotalTitle.Text = "Shift Totals"
            Me.LblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblBatchCount
            '
            Me.LblBatchCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblBatchCount.AutoSize = True
            Me.LblBatchCount.BackColor = System.Drawing.Color.Black
            Me.LblBatchCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblBatchCount.ForeColor = System.Drawing.Color.White
            Me.LblBatchCount.Location = New System.Drawing.Point(3, 160)
            Me.LblBatchCount.Name = "LblBatchCount"
            Me.LblBatchCount.Size = New System.Drawing.Size(238, 37)
            Me.LblBatchCount.TabIndex = 4
            Me.LblBatchCount.Text = "0"
            Me.LblBatchCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ToolTip1.SetToolTip(Me.LblBatchCount, "Double click to edit")
            '
            'GridPartData
            '
            Me.GridPartData.AllowUserResizing = FlexCell.ResizeEnum.None
            Me.GridPartData.AutoSize = True
            Me.GridPartData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GridPartData.CheckedImage = Nothing
            Me.GridPartData.Cols = 2
            Me.GridPartData.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridPartData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridPartData.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.GridPartData.Location = New System.Drawing.Point(3, 235)
            Me.GridPartData.Name = "GridPartData"
            Me.GridPartData.Rows = 12
            Me.GridPartData.Size = New System.Drawing.Size(238, 233)
            Me.GridPartData.TabIndex = 22
            Me.ToolTip1.SetToolTip(Me.GridPartData, "Double click to edit part number")
            Me.GridPartData.UncheckedImage = Nothing
            '
            'GridPartOptions
            '
            Me.GridPartOptions.AllowUserResizing = FlexCell.ResizeEnum.None
            Me.GridPartOptions.CheckedImage = Nothing
            Me.GridPartOptions.Cols = 2
            Me.GridPartOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridPartOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridPartOptions.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.GridPartOptions.Location = New System.Drawing.Point(3, 487)
            Me.GridPartOptions.Name = "GridPartOptions"
            Me.GridPartOptions.Rows = 24
            Me.GridPartOptions.Size = New System.Drawing.Size(238, 233)
            Me.GridPartOptions.TabIndex = 23
            Me.GridPartOptions.UncheckedImage = Nothing
            '
            'GridGlassOptions
            '
            Me.GridGlassOptions.AllowUserResizing = FlexCell.ResizeEnum.None
            Me.GridGlassOptions.CheckedImage = Nothing
            Me.GridGlassOptions.Cols = 2
            Me.GridGlassOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridGlassOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridGlassOptions.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.GridGlassOptions.Location = New System.Drawing.Point(3, 739)
            Me.GridGlassOptions.Name = "GridGlassOptions"
            Me.GridGlassOptions.Rows = 24
            Me.GridGlassOptions.Size = New System.Drawing.Size(238, 115)
            Me.GridGlassOptions.TabIndex = 23
            Me.GridGlassOptions.UncheckedImage = Nothing
            '
            'LblPartInfoTitle
            '
            Me.LblPartInfoTitle.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.LblPartInfoTitle.AutoSize = True
            Me.LblPartInfoTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPartInfoTitle.Location = New System.Drawing.Point(79, 219)
            Me.LblPartInfoTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
            Me.LblPartInfoTitle.Name = "LblPartInfoTitle"
            Me.LblPartInfoTitle.Size = New System.Drawing.Size(86, 13)
            Me.LblPartInfoTitle.TabIndex = 24
            Me.LblPartInfoTitle.Text = "Loaded Part Info"
            '
            'LblDaq
            '
            Me.LblDaq.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.LblDaq.AutoSize = True
            Me.LblDaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblDaq.Location = New System.Drawing.Point(69, 197)
            Me.LblDaq.Name = "LblDaq"
            Me.LblDaq.Size = New System.Drawing.Size(105, 20)
            Me.LblDaq.TabIndex = 25
            Me.LblDaq.Text = "Remote DAQ"
            '
            'Label8
            '
            Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(74, 140)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(96, 20)
            Me.Label8.TabIndex = 26
            Me.Label8.Text = "Order Count"
            '
            'Label1
            '
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(70, 471)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(104, 13)
            Me.Label1.TabIndex = 27
            Me.Label1.Text = "Loaded Part Options"
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(3, 723)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(238, 13)
            Me.Label2.TabIndex = 28
            Me.Label2.Text = "Glass Options"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Nest1DataControl
            '
            Me.Nest1DataControl.AutoSize = True
            Me.Nest1DataControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Nest1DataControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Nest1DataControl.Location = New System.Drawing.Point(3, 3)
            Me.Nest1DataControl.Name = "Nest1DataControl"
            Me.Nest1DataControl.Size = New System.Drawing.Size(500, 857)
            Me.Nest1DataControl.TabIndex = 26
            '
            'Nest2DataControl
            '
            Me.Nest2DataControl.AutoSize = True
            Me.Nest2DataControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Nest2DataControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Nest2DataControl.Location = New System.Drawing.Point(759, 3)
            Me.Nest2DataControl.Name = "Nest2DataControl"
            Me.Nest2DataControl.Size = New System.Drawing.Size(500, 857)
            Me.Nest2DataControl.TabIndex = 27
            '
            'TableLayoutBase
            '
            Me.TableLayoutBase.ColumnCount = 3
            Me.TableLayoutBase.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutBase.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
            Me.TableLayoutBase.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutBase.Controls.Add(Me.TableLayoutTopCenter, 1, 0)
            Me.TableLayoutBase.Controls.Add(Me.Nest2DataControl, 2, 0)
            Me.TableLayoutBase.Controls.Add(Me.Nest1DataControl, 0, 0)
            Me.TableLayoutBase.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutBase.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutBase.Name = "TableLayoutBase"
            Me.TableLayoutBase.RowCount = 1
            Me.TableLayoutBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutBase.Size = New System.Drawing.Size(1262, 863)
            Me.TableLayoutBase.TabIndex = 29
            '
            'ViewMainUserOverView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutBase)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "ViewMainUserOverView"
            Me.Size = New System.Drawing.Size(1262, 863)
            Me.TableLayoutTopCenter.ResumeLayout(False)
            Me.TableLayoutTopCenter.PerformLayout()
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            Me.TableLayoutPanel6.ResumeLayout(False)
            Me.TableLayoutPanel6.PerformLayout()
            Me.TableLayoutPanel7.ResumeLayout(False)
            Me.TableLayoutPanel7.PerformLayout()
            Me.TableLayoutPanel4.ResumeLayout(False)
            Me.TableLayoutPanel4.PerformLayout()
            Me.TableLayoutPanel5.ResumeLayout(False)
            Me.TableLayoutPanel5.PerformLayout()
            Me.TableLayoutBase.ResumeLayout(False)
            Me.TableLayoutBase.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Private Sub TableLayoutBase_DoubleClick(sender As Object, e As EventArgs) Handles TableLayoutBase.DoubleClick

        End Sub

        Friend WithEvents TableLayoutTopCenter As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblToteQtyReqHeader As System.Windows.Forms.Label
        Friend WithEvents LblToteDoneHeader As System.Windows.Forms.Label
        Friend WithEvents LblToteHeader As System.Windows.Forms.Label
        Friend WithEvents LblPassHeader As System.Windows.Forms.Label
        Friend WithEvents LblFailHeader As System.Windows.Forms.Label
        Friend WithEvents LblTotalTitle As System.Windows.Forms.Label
        Friend WithEvents Nest1DataControl As NestDataControl
        Friend WithEvents Nest2DataControl As NestDataControl
        Friend WithEvents TableLayoutBase As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblBatchCount As System.Windows.Forms.Label
        Friend WithEvents LblToteTargetValue As System.Windows.Forms.Label
        Friend WithEvents LblToteDownValue As System.Windows.Forms.Label
        Friend WithEvents LblFailValue As System.Windows.Forms.Label
        Friend WithEvents LblPassValue As System.Windows.Forms.Label
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents GridPartData As FlexCell.Grid
        Friend WithEvents GridPartOptions As FlexCell.Grid
        Friend WithEvents GridGlassOptions As FlexCell.Grid
        Friend WithEvents LblPartInfoTitle As System.Windows.Forms.Label
        Friend WithEvents LblDaq As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As Label
    End Class
End Namespace