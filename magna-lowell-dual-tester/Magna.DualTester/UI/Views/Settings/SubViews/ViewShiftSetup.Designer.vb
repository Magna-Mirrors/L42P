Namespace UI.Views.Settings.SubViews
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ViewShiftSetup
        Inherits UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.ComboBarCodeScannerCom = New System.Windows.Forms.ComboBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.TxtPlcIp = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.IndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PrinterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ComPort = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.PrnFileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.PrintCfgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.TxtServiceUrl = New System.Windows.Forms.TextBox()
            Me.BtnTestUrl = New System.Windows.Forms.Button()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.ComboLines = New System.Windows.Forms.ComboBox()
            Me.LineModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.LblServiceError = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
            Me.TxtAssetNumber = New System.Windows.Forms.TextBox()
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GrpShift = New System.Windows.Forms.GroupBox()
            Me.TlpShiftSetup = New System.Windows.Forms.TableLayoutPanel()
            Me.TrackShift3 = New System.Windows.Forms.TrackBar()
            Me.Txt3rdStart = New System.Windows.Forms.TextBox()
            Me.Txt2ndStart = New System.Windows.Forms.TextBox()
            Me.Txt1stStart = New System.Windows.Forms.TextBox()
            Me.TrackShift1 = New System.Windows.Forms.TrackBar()
            Me.TrackShift2 = New System.Windows.Forms.TrackBar()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.TableLayoutPanel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.TableLayoutPanel10.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PrintCfgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            CType(Me.LineModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.TableLayoutPanel7.SuspendLayout()
            Me.GrpShift.SuspendLayout()
            Me.TlpShiftSetup.SuspendLayout()
            CType(Me.TrackShift3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TrackShift1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TrackShift2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel1.ColumnCount = 4
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001379!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.80234!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.1949!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001379!))
            Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 2, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.GrpShift, 1, 2)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 4
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1087, 588)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'GroupBox3
            '
            Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox3.AutoSize = True
            Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GroupBox3.Controls.Add(Me.TableLayoutPanel10)
            Me.GroupBox3.Location = New System.Drawing.Point(57, 112)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(470, 87)
            Me.GroupBox3.TabIndex = 1
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Device Connections"
            '
            'TableLayoutPanel10
            '
            Me.TableLayoutPanel10.AutoSize = True
            Me.TableLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel10.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TableLayoutPanel10.ColumnCount = 3
            Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.8317!))
            Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26367!))
            Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.90463!))
            Me.TableLayoutPanel10.Controls.Add(Me.Label6, 0, 0)
            Me.TableLayoutPanel10.Controls.Add(Me.ComboBarCodeScannerCom, 1, 0)
            Me.TableLayoutPanel10.Controls.Add(Me.Label8, 0, 1)
            Me.TableLayoutPanel10.Controls.Add(Me.TxtPlcIp, 1, 1)
            Me.TableLayoutPanel10.Controls.Add(Me.Label11, 2, 0)
            Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 18)
            Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
            Me.TableLayoutPanel10.RowCount = 2
            Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel10.Size = New System.Drawing.Size(464, 66)
            Me.TableLayoutPanel10.TabIndex = 1
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(3, 7)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(178, 16)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Bar Code Scanner"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'ComboBarCodeScannerCom
            '
            Me.ComboBarCodeScannerCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ComboBarCodeScannerCom.FormattingEnabled = True
            Me.ComboBarCodeScannerCom.Location = New System.Drawing.Point(187, 3)
            Me.ComboBarCodeScannerCom.Name = "ComboBarCodeScannerCom"
            Me.ComboBarCodeScannerCom.Size = New System.Drawing.Size(106, 24)
            Me.ComboBarCodeScannerCom.TabIndex = 5
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(3, 40)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(178, 16)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Plc Ip Address"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtPlcIp
            '
            Me.TxtPlcIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtPlcIp.Location = New System.Drawing.Point(187, 37)
            Me.TxtPlcIp.Name = "TxtPlcIp"
            Me.TxtPlcIp.Size = New System.Drawing.Size(106, 22)
            Me.TxtPlcIp.TabIndex = 7
            '
            'Label11
            '
            Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(299, 8)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(162, 13)
            Me.Label11.TabIndex = 10
            Me.Label11.Text = "RS232 Comm Port"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'GroupBox4
            '
            Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox4.Controls.Add(Me.DataGridView1)
            Me.GroupBox4.Location = New System.Drawing.Point(533, 3)
            Me.GroupBox4.Name = "GroupBox4"
            Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox4, 2)
            Me.GroupBox4.Size = New System.Drawing.Size(496, 196)
            Me.GroupBox4.TabIndex = 5
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Printer Setup"
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexDataGridViewTextBoxColumn, Me.PrinterName, Me.ComPort, Me.PrnFileDataGridViewTextBoxColumn})
            Me.DataGridView1.DataSource = Me.PrintCfgBindingSource
            Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.Size = New System.Drawing.Size(490, 175)
            Me.DataGridView1.TabIndex = 0
            '
            'IndexDataGridViewTextBoxColumn
            '
            Me.IndexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.IndexDataGridViewTextBoxColumn.DataPropertyName = "Index"
            Me.IndexDataGridViewTextBoxColumn.HeaderText = "Index"
            Me.IndexDataGridViewTextBoxColumn.Name = "IndexDataGridViewTextBoxColumn"
            Me.IndexDataGridViewTextBoxColumn.Width = 65
            '
            'PrinterName
            '
            Me.PrinterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.PrinterName.DataPropertyName = "PrinterName"
            Me.PrinterName.FillWeight = 50.0!
            Me.PrinterName.HeaderText = "PrinterName"
            Me.PrinterName.Name = "PrinterName"
            '
            'ComPort
            '
            Me.ComPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.ComPort.DataPropertyName = "ComPort"
            Me.ComPort.HeaderText = "ComPort"
            Me.ComPort.Name = "ComPort"
            Me.ComPort.Width = 66
            '
            'PrnFileDataGridViewTextBoxColumn
            '
            Me.PrnFileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.PrnFileDataGridViewTextBoxColumn.DataPropertyName = "PrnFile"
            Me.PrnFileDataGridViewTextBoxColumn.FillWeight = 50.0!
            Me.PrnFileDataGridViewTextBoxColumn.HeaderText = "PrnFile"
            Me.PrnFileDataGridViewTextBoxColumn.Name = "PrnFileDataGridViewTextBoxColumn"
            Me.PrnFileDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.PrnFileDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            '
            'PrintCfgBindingSource
            '
            Me.PrintCfgBindingSource.DataSource = GetType(Magna.DualTester.PrintCfg)
            '
            'GroupBox2
            '
            Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox2.AutoSize = True
            Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
            Me.GroupBox2.Location = New System.Drawing.Point(57, 3)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(470, 103)
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Scheduler"
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.AutoSize = True
            Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TableLayoutPanel3.ColumnCount = 3
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
            Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.TxtServiceUrl, 1, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.BtnTestUrl, 2, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 2)
            Me.TableLayoutPanel3.Controls.Add(Me.ComboLines, 1, 2)
            Me.TableLayoutPanel3.Controls.Add(Me.LblServiceError, 0, 1)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 18)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 3
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(464, 82)
            Me.TableLayoutPanel3.TabIndex = 3
            '
            'Label9
            '
            Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(3, 6)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(111, 16)
            Me.Label9.TabIndex = 0
            Me.Label9.Text = "Service Address:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtServiceUrl
            '
            Me.TxtServiceUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtServiceUrl.Location = New System.Drawing.Point(120, 3)
            Me.TxtServiceUrl.Name = "TxtServiceUrl"
            Me.TxtServiceUrl.Size = New System.Drawing.Size(144, 22)
            Me.TxtServiceUrl.TabIndex = 2
            '
            'BtnTestUrl
            '
            Me.BtnTestUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnTestUrl.Location = New System.Drawing.Point(270, 3)
            Me.BtnTestUrl.Name = "BtnTestUrl"
            Me.BtnTestUrl.Size = New System.Drawing.Size(191, 22)
            Me.BtnTestUrl.TabIndex = 4
            Me.BtnTestUrl.Text = "Test Url"
            Me.BtnTestUrl.UseVisualStyleBackColor = True
            '
            'Label10
            '
            Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(3, 60)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(111, 16)
            Me.Label10.TabIndex = 1
            Me.Label10.Text = "Line Id:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'ComboLines
            '
            Me.ComboLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ComboLines.DataSource = Me.LineModelBindingSource
            Me.ComboLines.DisplayMember = "Description"
            Me.ComboLines.Enabled = False
            Me.ComboLines.FormattingEnabled = True
            Me.ComboLines.Location = New System.Drawing.Point(120, 58)
            Me.ComboLines.Name = "ComboLines"
            Me.ComboLines.Size = New System.Drawing.Size(144, 24)
            Me.ComboLines.TabIndex = 3
            Me.ComboLines.ValueMember = "Id"
            '
            'LineModelBindingSource
            '
            Me.LineModelBindingSource.DataSource = GetType(Magna.DualTester.LineModel)
            '
            'LblServiceError
            '
            Me.LblServiceError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblServiceError.AutoSize = True
            Me.TableLayoutPanel3.SetColumnSpan(Me.LblServiceError, 3)
            Me.LblServiceError.Location = New System.Drawing.Point(3, 33)
            Me.LblServiceError.Name = "LblServiceError"
            Me.LblServiceError.Size = New System.Drawing.Size(458, 16)
            Me.LblServiceError.TabIndex = 5
            Me.LblServiceError.Text = "..."
            Me.LblServiceError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.AutoSize = True
            Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GroupBox1.Controls.Add(Me.TableLayoutPanel7)
            Me.GroupBox1.Location = New System.Drawing.Point(533, 205)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(496, 174)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Identification"
            Me.GroupBox1.Visible = False
            '
            'TableLayoutPanel7
            '
            Me.TableLayoutPanel7.AutoSize = True
            Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel7.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TableLayoutPanel7.ColumnCount = 2
            Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel7.Controls.Add(Me.TxtAssetNumber, 1, 1)
            Me.TableLayoutPanel7.Controls.Add(Me.TxtName, 1, 0)
            Me.TableLayoutPanel7.Controls.Add(Me.Label1, 0, 1)
            Me.TableLayoutPanel7.Controls.Add(Me.Label2, 0, 0)
            Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 18)
            Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
            Me.TableLayoutPanel7.RowCount = 2
            Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel7.Size = New System.Drawing.Size(490, 153)
            Me.TableLayoutPanel7.TabIndex = 5
            '
            'TxtAssetNumber
            '
            Me.TxtAssetNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtAssetNumber.Location = New System.Drawing.Point(248, 128)
            Me.TxtAssetNumber.Name = "TxtAssetNumber"
            Me.TxtAssetNumber.Size = New System.Drawing.Size(239, 22)
            Me.TxtAssetNumber.TabIndex = 2
            '
            'TxtName
            '
            Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtName.Location = New System.Drawing.Point(248, 51)
            Me.TxtName.Name = "TxtName"
            Me.TxtName.Size = New System.Drawing.Size(239, 22)
            Me.TxtName.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(149, 131)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(93, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Asset Number"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(197, 54)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(45, 16)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Name"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GrpShift
            '
            Me.GrpShift.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GrpShift.AutoSize = True
            Me.GrpShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GrpShift.Controls.Add(Me.TlpShiftSetup)
            Me.GrpShift.Location = New System.Drawing.Point(57, 205)
            Me.GrpShift.Name = "GrpShift"
            Me.GrpShift.Size = New System.Drawing.Size(470, 174)
            Me.GrpShift.TabIndex = 1
            Me.GrpShift.TabStop = False
            Me.GrpShift.Text = "Shift Setup"
            '
            'TlpShiftSetup
            '
            Me.TlpShiftSetup.AutoSize = True
            Me.TlpShiftSetup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TlpShiftSetup.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TlpShiftSetup.ColumnCount = 3
            Me.TlpShiftSetup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TlpShiftSetup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TlpShiftSetup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TlpShiftSetup.Controls.Add(Me.TrackShift3, 1, 2)
            Me.TlpShiftSetup.Controls.Add(Me.Txt3rdStart, 2, 2)
            Me.TlpShiftSetup.Controls.Add(Me.Txt2ndStart, 2, 1)
            Me.TlpShiftSetup.Controls.Add(Me.Txt1stStart, 2, 0)
            Me.TlpShiftSetup.Controls.Add(Me.TrackShift1, 1, 0)
            Me.TlpShiftSetup.Controls.Add(Me.TrackShift2, 1, 1)
            Me.TlpShiftSetup.Controls.Add(Me.Label4, 0, 1)
            Me.TlpShiftSetup.Controls.Add(Me.Label5, 0, 2)
            Me.TlpShiftSetup.Controls.Add(Me.Label3, 0, 0)
            Me.TlpShiftSetup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TlpShiftSetup.Location = New System.Drawing.Point(3, 18)
            Me.TlpShiftSetup.Margin = New System.Windows.Forms.Padding(0)
            Me.TlpShiftSetup.Name = "TlpShiftSetup"
            Me.TlpShiftSetup.RowCount = 3
            Me.TlpShiftSetup.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TlpShiftSetup.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TlpShiftSetup.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TlpShiftSetup.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TlpShiftSetup.Size = New System.Drawing.Size(464, 153)
            Me.TlpShiftSetup.TabIndex = 0
            '
            'TrackShift3
            '
            Me.TrackShift3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TrackShift3.Location = New System.Drawing.Point(69, 105)
            Me.TrackShift3.Maximum = 1439
            Me.TrackShift3.Name = "TrackShift3"
            Me.TrackShift3.Size = New System.Drawing.Size(236, 45)
            Me.TrackShift3.TabIndex = 8
            Me.TrackShift3.TickFrequency = 10
            Me.TrackShift3.Value = 1
            '
            'Txt3rdStart
            '
            Me.Txt3rdStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Txt3rdStart.Location = New System.Drawing.Point(311, 116)
            Me.Txt3rdStart.Name = "Txt3rdStart"
            Me.Txt3rdStart.ReadOnly = True
            Me.Txt3rdStart.Size = New System.Drawing.Size(150, 22)
            Me.Txt3rdStart.TabIndex = 5
            '
            'Txt2ndStart
            '
            Me.Txt2ndStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Txt2ndStart.Location = New System.Drawing.Point(311, 65)
            Me.Txt2ndStart.Name = "Txt2ndStart"
            Me.Txt2ndStart.ReadOnly = True
            Me.Txt2ndStart.Size = New System.Drawing.Size(150, 22)
            Me.Txt2ndStart.TabIndex = 4
            '
            'Txt1stStart
            '
            Me.Txt1stStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Txt1stStart.Location = New System.Drawing.Point(311, 14)
            Me.Txt1stStart.Name = "Txt1stStart"
            Me.Txt1stStart.ReadOnly = True
            Me.Txt1stStart.Size = New System.Drawing.Size(150, 22)
            Me.Txt1stStart.TabIndex = 3
            '
            'TrackShift1
            '
            Me.TrackShift1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TrackShift1.Location = New System.Drawing.Point(69, 3)
            Me.TrackShift1.Maximum = 1439
            Me.TrackShift1.Name = "TrackShift1"
            Me.TrackShift1.Size = New System.Drawing.Size(236, 45)
            Me.TrackShift1.TabIndex = 6
            Me.TrackShift1.TickFrequency = 10
            Me.TrackShift1.Value = 1
            '
            'TrackShift2
            '
            Me.TrackShift2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TrackShift2.Location = New System.Drawing.Point(69, 54)
            Me.TrackShift2.Maximum = 1439
            Me.TrackShift2.Name = "TrackShift2"
            Me.TrackShift2.Size = New System.Drawing.Size(236, 45)
            Me.TrackShift2.TabIndex = 7
            Me.TrackShift2.TickFrequency = 10
            Me.TrackShift2.Value = 1
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(3, 68)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(60, 16)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "2nd Start"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(3, 119)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(60, 16)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "3rd Start"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(3, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 16)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "1st Start"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.ContainerControl = Me
            '
            'SaveFileDialog1
            '
            Me.SaveFileDialog1.FileName = "requestfile"
            Me.SaveFileDialog1.Filter = "REQ File|*.req"
            '
            'ViewShiftSetup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "ViewShiftSetup"
            Me.Size = New System.Drawing.Size(1087, 588)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.TableLayoutPanel10.ResumeLayout(False)
            Me.TableLayoutPanel10.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PrintCfgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            CType(Me.LineModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TableLayoutPanel7.ResumeLayout(False)
            Me.TableLayoutPanel7.PerformLayout()
            Me.GrpShift.ResumeLayout(False)
            Me.GrpShift.PerformLayout()
            Me.TlpShiftSetup.ResumeLayout(False)
            Me.TlpShiftSetup.PerformLayout()
            CType(Me.TrackShift3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TrackShift1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TrackShift2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents GrpShift As System.Windows.Forms.GroupBox
        Friend WithEvents TlpShiftSetup As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Txt1stStart As System.Windows.Forms.TextBox
        Friend WithEvents Txt2ndStart As System.Windows.Forms.TextBox
        Friend WithEvents Txt3rdStart As System.Windows.Forms.TextBox
        Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents ComboBarCodeScannerCom As System.Windows.Forms.ComboBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TxtAssetNumber As System.Windows.Forms.TextBox
        Friend WithEvents TxtName As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
        Friend WithEvents TxtPlcIp As System.Windows.Forms.TextBox
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
        Friend WithEvents Label9 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents TxtServiceUrl As TextBox
        Friend WithEvents ComboLines As ComboBox
        Friend WithEvents LineModelBindingSource As BindingSource
        Friend WithEvents BtnTestUrl As Button
        Friend WithEvents LblServiceError As Label
        Friend WithEvents GroupBox4 As GroupBox
        Friend WithEvents DataGridView1 As DataGridView
        Friend WithEvents PrintCfgBindingSource As BindingSource
        Friend WithEvents IndexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents PrinterName As DataGridViewTextBoxColumn
        Friend WithEvents ComPort As DataGridViewComboBoxColumn
        Friend WithEvents PrnFileDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
        Friend WithEvents TrackShift3 As TrackBar
        Friend WithEvents TrackShift1 As TrackBar
        Friend WithEvents TrackShift2 As TrackBar
    End Class
End Namespace