
Namespace UI.Views.Calibration.SubViews

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CalibrationSubUserControl
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
            Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.CalItemVerticalAngle = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemHorizontalMem = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemVerticalMemory = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemHorzAmp = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemVertAmp = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemHorizontalAngle = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemSpare = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemOats = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemCargoLamp = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemGi = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemEc = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemPfold = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemBzi = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemTurnSig = New Magna.DualTester.CalibrationItemDisplay()
            Me.CalItemHeater = New Magna.DualTester.CalibrationItemDisplay()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.MirrorTraining = New Magna.DualTester.Uc_Coordinate()
            Me.TableLayoutPanel5.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel5
            '
            Me.TableLayoutPanel5.ColumnCount = 1
            Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel5.Controls.Add(Me.Label22, 0, 0)
            Me.TableLayoutPanel5.Controls.Add(Me.Panel1, 0, 1)
            Me.TableLayoutPanel5.Controls.Add(Me.Panel2, 0, 2)
            Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
            Me.TableLayoutPanel5.RowCount = 4
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel5.Size = New System.Drawing.Size(607, 712)
            Me.TableLayoutPanel5.TabIndex = 1
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.Blue
            Me.Label22.Location = New System.Drawing.Point(3, 0)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(601, 30)
            Me.Label22.TabIndex = 0
            Me.Label22.Text = "Calibration"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel1
            '
            Me.Panel1.AutoScroll = True
            Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(3, 33)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(601, 325)
            Me.Panel1.TabIndex = 2
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.AutoScroll = True
            Me.TableLayoutPanel1.AutoSize = True
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22221!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223!))
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemHorizontalAngle, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemVerticalAngle, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemHorizontalMem, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemVerticalMemory, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemHorzAmp, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemVertAmp, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemHeater, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemTurnSig, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemBzi, 0, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemPfold, 0, 10)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemEc, 0, 11)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemGi, 0, 12)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemCargoLamp, 0, 13)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemOats, 0, 14)
            Me.TableLayoutPanel1.Controls.Add(Me.CalItemSpare, 0, 15)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 17
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(584, 448)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(188, 28)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Value"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(197, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(188, 28)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Raw Analog"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(391, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(190, 28)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Cal Item"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'CalItemVerticalAngle
            '
            Me.CalItemVerticalAngle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemVerticalAngle.CalibrationButtonText = "Vertical Data"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemVerticalAngle, 3)
            Me.CalItemVerticalAngle.LabelOnly = True
            Me.CalItemVerticalAngle.Location = New System.Drawing.Point(0, 56)
            Me.CalItemVerticalAngle.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemVerticalAngle.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemVerticalAngle.Name = "CalItemVerticalAngle"
            Me.CalItemVerticalAngle.PowerButtonText = "Power"
            Me.CalItemVerticalAngle.PowerButtonVisible = True
            Me.CalItemVerticalAngle.RawBackColor = System.Drawing.Color.Black
            Me.CalItemVerticalAngle.RawForeColor = System.Drawing.Color.Yellow
            Me.CalItemVerticalAngle.Size = New System.Drawing.Size(584, 28)
            Me.CalItemVerticalAngle.TabIndex = 61
            Me.CalItemVerticalAngle.ValueSuffix = "°"
            '
            'CalItemHorizontalMem
            '
            Me.CalItemHorizontalMem.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemHorizontalMem.CalibrationButtonText = "Horiz Memory"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemHorizontalMem, 3)
            Me.CalItemHorizontalMem.LabelOnly = False
            Me.CalItemHorizontalMem.Location = New System.Drawing.Point(0, 84)
            Me.CalItemHorizontalMem.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemHorizontalMem.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemHorizontalMem.Name = "CalItemHorizontalMem"
            Me.CalItemHorizontalMem.PowerButtonText = "Power"
            Me.CalItemHorizontalMem.PowerButtonVisible = False
            Me.CalItemHorizontalMem.RawBackColor = System.Drawing.Color.Black
            Me.CalItemHorizontalMem.RawForeColor = System.Drawing.Color.White
            Me.CalItemHorizontalMem.Size = New System.Drawing.Size(584, 28)
            Me.CalItemHorizontalMem.TabIndex = 62
            Me.CalItemHorizontalMem.ValueSuffix = "V"
            '
            'CalItemVerticalMemory
            '
            Me.CalItemVerticalMemory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemVerticalMemory.CalibrationButtonText = "Vert Memory"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemVerticalMemory, 3)
            Me.CalItemVerticalMemory.LabelOnly = False
            Me.CalItemVerticalMemory.Location = New System.Drawing.Point(0, 112)
            Me.CalItemVerticalMemory.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemVerticalMemory.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemVerticalMemory.Name = "CalItemVerticalMemory"
            Me.CalItemVerticalMemory.PowerButtonText = "Power"
            Me.CalItemVerticalMemory.PowerButtonVisible = False
            Me.CalItemVerticalMemory.RawBackColor = System.Drawing.Color.Black
            Me.CalItemVerticalMemory.RawForeColor = System.Drawing.Color.White
            Me.CalItemVerticalMemory.Size = New System.Drawing.Size(584, 28)
            Me.CalItemVerticalMemory.TabIndex = 63
            Me.CalItemVerticalMemory.ValueSuffix = "V"
            '
            'CalItemHorzAmp
            '
            Me.CalItemHorzAmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemHorzAmp.CalibrationButtonText = "HorzAmp"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemHorzAmp, 3)
            Me.CalItemHorzAmp.LabelOnly = False
            Me.CalItemHorzAmp.Location = New System.Drawing.Point(0, 140)
            Me.CalItemHorzAmp.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemHorzAmp.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemHorzAmp.Name = "CalItemHorzAmp"
            Me.CalItemHorzAmp.PowerButtonText = "Power"
            Me.CalItemHorzAmp.PowerButtonVisible = True
            Me.CalItemHorzAmp.RawBackColor = System.Drawing.Color.Black
            Me.CalItemHorzAmp.RawForeColor = System.Drawing.Color.White
            Me.CalItemHorzAmp.Size = New System.Drawing.Size(584, 28)
            Me.CalItemHorzAmp.TabIndex = 64
            Me.CalItemHorzAmp.ValueSuffix = "A"
            '
            'CalItemVertAmp
            '
            Me.CalItemVertAmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemVertAmp.CalibrationButtonText = "VertAmp"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemVertAmp, 3)
            Me.CalItemVertAmp.LabelOnly = False
            Me.CalItemVertAmp.Location = New System.Drawing.Point(0, 168)
            Me.CalItemVertAmp.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemVertAmp.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemVertAmp.Name = "CalItemVertAmp"
            Me.CalItemVertAmp.PowerButtonText = "Power"
            Me.CalItemVertAmp.PowerButtonVisible = True
            Me.CalItemVertAmp.RawBackColor = System.Drawing.Color.Black
            Me.CalItemVertAmp.RawForeColor = System.Drawing.Color.White
            Me.CalItemVertAmp.Size = New System.Drawing.Size(584, 28)
            Me.CalItemVertAmp.TabIndex = 65
            Me.CalItemVertAmp.ValueSuffix = "A"
            '
            'CalItemHorizontalAngle
            '
            Me.CalItemHorizontalAngle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemHorizontalAngle.CalibrationButtonText = "Horizontal Data"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemHorizontalAngle, 3)
            Me.CalItemHorizontalAngle.LabelOnly = True
            Me.CalItemHorizontalAngle.Location = New System.Drawing.Point(0, 28)
            Me.CalItemHorizontalAngle.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemHorizontalAngle.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemHorizontalAngle.Name = "CalItemHorizontalAngle"
            Me.CalItemHorizontalAngle.PowerButtonText = "Power"
            Me.CalItemHorizontalAngle.PowerButtonVisible = True
            Me.CalItemHorizontalAngle.RawBackColor = System.Drawing.Color.Black
            Me.CalItemHorizontalAngle.RawForeColor = System.Drawing.Color.Yellow
            Me.CalItemHorizontalAngle.Size = New System.Drawing.Size(584, 28)
            Me.CalItemHorizontalAngle.TabIndex = 71
            Me.CalItemHorizontalAngle.ValueSuffix = "°"
            '
            'CalItemSpare
            '
            Me.CalItemSpare.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemSpare.CalibrationButtonText = "Spare"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemSpare, 3)
            Me.CalItemSpare.LabelOnly = False
            Me.CalItemSpare.Location = New System.Drawing.Point(0, 420)
            Me.CalItemSpare.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemSpare.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemSpare.Name = "CalItemSpare"
            Me.CalItemSpare.PowerButtonText = "Power"
            Me.CalItemSpare.PowerButtonVisible = False
            Me.CalItemSpare.RawBackColor = System.Drawing.Color.Black
            Me.CalItemSpare.RawForeColor = System.Drawing.Color.White
            Me.CalItemSpare.Size = New System.Drawing.Size(584, 28)
            Me.CalItemSpare.TabIndex = 70
            Me.CalItemSpare.ValueSuffix = "A"
            '
            'CalItemOats
            '
            Me.CalItemOats.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemOats.CalibrationButtonText = "OATS"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemOats, 3)
            Me.CalItemOats.LabelOnly = False
            Me.CalItemOats.Location = New System.Drawing.Point(0, 392)
            Me.CalItemOats.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemOats.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemOats.Name = "CalItemOats"
            Me.CalItemOats.PowerButtonText = "Power"
            Me.CalItemOats.PowerButtonVisible = False
            Me.CalItemOats.RawBackColor = System.Drawing.Color.Black
            Me.CalItemOats.RawForeColor = System.Drawing.Color.White
            Me.CalItemOats.Size = New System.Drawing.Size(584, 28)
            Me.CalItemOats.TabIndex = 69
            Me.CalItemOats.ValueSuffix = "A"
            '
            'CalItemCargoLamp
            '
            Me.CalItemCargoLamp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemCargoLamp.CalibrationButtonText = "Cargo Lamp"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemCargoLamp, 3)
            Me.CalItemCargoLamp.LabelOnly = False
            Me.CalItemCargoLamp.Location = New System.Drawing.Point(0, 364)
            Me.CalItemCargoLamp.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemCargoLamp.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemCargoLamp.Name = "CalItemCargoLamp"
            Me.CalItemCargoLamp.PowerButtonText = "Power"
            Me.CalItemCargoLamp.PowerButtonVisible = False
            Me.CalItemCargoLamp.RawBackColor = System.Drawing.Color.Black
            Me.CalItemCargoLamp.RawForeColor = System.Drawing.Color.White
            Me.CalItemCargoLamp.Size = New System.Drawing.Size(584, 28)
            Me.CalItemCargoLamp.TabIndex = 68
            Me.CalItemCargoLamp.ValueSuffix = "A"
            '
            'CalItemGi
            '
            Me.CalItemGi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemGi.CalibrationButtonText = "GI"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemGi, 3)
            Me.CalItemGi.LabelOnly = False
            Me.CalItemGi.Location = New System.Drawing.Point(0, 336)
            Me.CalItemGi.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemGi.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemGi.Name = "CalItemGi"
            Me.CalItemGi.PowerButtonText = "Power"
            Me.CalItemGi.PowerButtonVisible = False
            Me.CalItemGi.RawBackColor = System.Drawing.Color.Black
            Me.CalItemGi.RawForeColor = System.Drawing.Color.White
            Me.CalItemGi.Size = New System.Drawing.Size(584, 28)
            Me.CalItemGi.TabIndex = 67
            Me.CalItemGi.ValueSuffix = "A"
            '
            'CalItemEc
            '
            Me.CalItemEc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemEc.CalibrationButtonText = "EC"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemEc, 3)
            Me.CalItemEc.LabelOnly = False
            Me.CalItemEc.Location = New System.Drawing.Point(0, 308)
            Me.CalItemEc.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemEc.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemEc.Name = "CalItemEc"
            Me.CalItemEc.PowerButtonText = "Power"
            Me.CalItemEc.PowerButtonVisible = False
            Me.CalItemEc.RawBackColor = System.Drawing.Color.Black
            Me.CalItemEc.RawForeColor = System.Drawing.Color.White
            Me.CalItemEc.Size = New System.Drawing.Size(584, 28)
            Me.CalItemEc.TabIndex = 66
            Me.CalItemEc.ValueSuffix = "A"
            '
            'CalItemPfold
            '
            Me.CalItemPfold.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemPfold.CalibrationButtonText = "P Fold"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemPfold, 3)
            Me.CalItemPfold.LabelOnly = False
            Me.CalItemPfold.Location = New System.Drawing.Point(0, 280)
            Me.CalItemPfold.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemPfold.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemPfold.Name = "CalItemPfold"
            Me.CalItemPfold.PowerButtonText = "Power"
            Me.CalItemPfold.PowerButtonVisible = True
            Me.CalItemPfold.RawBackColor = System.Drawing.Color.Black
            Me.CalItemPfold.RawForeColor = System.Drawing.Color.White
            Me.CalItemPfold.Size = New System.Drawing.Size(584, 28)
            Me.CalItemPfold.TabIndex = 60
            Me.CalItemPfold.ValueSuffix = "A"
            '
            'CalItemBzi
            '
            Me.CalItemBzi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemBzi.CalibrationButtonText = "BZI"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemBzi, 3)
            Me.CalItemBzi.LabelOnly = False
            Me.CalItemBzi.Location = New System.Drawing.Point(0, 252)
            Me.CalItemBzi.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemBzi.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemBzi.Name = "CalItemBzi"
            Me.CalItemBzi.PowerButtonText = "Power"
            Me.CalItemBzi.PowerButtonVisible = False
            Me.CalItemBzi.RawBackColor = System.Drawing.Color.Black
            Me.CalItemBzi.RawForeColor = System.Drawing.Color.White
            Me.CalItemBzi.Size = New System.Drawing.Size(584, 28)
            Me.CalItemBzi.TabIndex = 72
            Me.CalItemBzi.ValueSuffix = "A"
            '
            'CalItemTurnSig
            '
            Me.CalItemTurnSig.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemTurnSig.CalibrationButtonText = "Turn Sig"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemTurnSig, 3)
            Me.CalItemTurnSig.LabelOnly = False
            Me.CalItemTurnSig.Location = New System.Drawing.Point(0, 224)
            Me.CalItemTurnSig.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemTurnSig.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemTurnSig.Name = "CalItemTurnSig"
            Me.CalItemTurnSig.PowerButtonText = "Power"
            Me.CalItemTurnSig.PowerButtonVisible = False
            Me.CalItemTurnSig.RawBackColor = System.Drawing.Color.Black
            Me.CalItemTurnSig.RawForeColor = System.Drawing.Color.White
            Me.CalItemTurnSig.Size = New System.Drawing.Size(584, 28)
            Me.CalItemTurnSig.TabIndex = 73
            Me.CalItemTurnSig.ValueSuffix = "A"
            '
            'CalItemHeater
            '
            Me.CalItemHeater.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CalItemHeater.CalibrationButtonText = "Heater"
            Me.TableLayoutPanel1.SetColumnSpan(Me.CalItemHeater, 3)
            Me.CalItemHeater.LabelOnly = False
            Me.CalItemHeater.Location = New System.Drawing.Point(0, 196)
            Me.CalItemHeater.Margin = New System.Windows.Forms.Padding(0)
            Me.CalItemHeater.MinUserLevel = Magna.DualTester.Core.Data.Enums.AccessLevel.None
            Me.CalItemHeater.Name = "CalItemHeater"
            Me.CalItemHeater.PowerButtonText = "Power"
            Me.CalItemHeater.PowerButtonVisible = False
            Me.CalItemHeater.RawBackColor = System.Drawing.Color.Black
            Me.CalItemHeater.RawForeColor = System.Drawing.Color.White
            Me.CalItemHeater.Size = New System.Drawing.Size(584, 28)
            Me.CalItemHeater.TabIndex = 74
            Me.CalItemHeater.ValueSuffix = "A"
            '
            'Panel2
            '
            Me.Panel2.AutoScroll = True
            Me.Panel2.AutoSize = True
            Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Panel2.Controls.Add(Me.MirrorTraining)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(3, 364)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(601, 325)
            Me.Panel2.TabIndex = 3
            '
            'MirrorTraining
            '
            Me.MirrorTraining.AutoScroll = True
            Me.MirrorTraining.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.MirrorTraining.Location = New System.Drawing.Point(4, 3)
            Me.MirrorTraining.MaxVal = 12.0!
            Me.MirrorTraining.MinVal = 0!
            Me.MirrorTraining.Name = "MirrorTraining"
            Me.MirrorTraining.Size = New System.Drawing.Size(572, 434)
            Me.MirrorTraining.TabIndex = 1
            '
            'CalibrationSubUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel5)
            Me.Name = "CalibrationSubUserControl"
            Me.Size = New System.Drawing.Size(607, 712)
            Me.TableLayoutPanel5.ResumeLayout(False)
            Me.TableLayoutPanel5.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label22 As Label
        Friend WithEvents MirrorTraining As Uc_Coordinate
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents CalItemVerticalAngle As CalibrationItemDisplay
        Friend WithEvents CalItemHorizontalMem As CalibrationItemDisplay
        Friend WithEvents CalItemVerticalMemory As CalibrationItemDisplay
        Friend WithEvents CalItemHorzAmp As CalibrationItemDisplay
        Friend WithEvents CalItemVertAmp As CalibrationItemDisplay
        Friend WithEvents CalItemHorizontalAngle As CalibrationItemDisplay
        Friend WithEvents CalItemSpare As CalibrationItemDisplay
        Friend WithEvents CalItemOats As CalibrationItemDisplay
        Friend WithEvents CalItemCargoLamp As CalibrationItemDisplay
        Friend WithEvents CalItemGi As CalibrationItemDisplay
        Friend WithEvents CalItemEc As CalibrationItemDisplay
        Friend WithEvents CalItemPfold As CalibrationItemDisplay
        Friend WithEvents CalItemBzi As CalibrationItemDisplay
        Friend WithEvents CalItemTurnSig As CalibrationItemDisplay
        Friend WithEvents CalItemHeater As CalibrationItemDisplay
    End Class
End Namespace