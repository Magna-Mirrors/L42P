<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uc_Coordinate
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.V_Sample_RawMax = New System.Windows.Forms.Button()
        Me.V_EuMax = New System.Windows.Forms.NumericUpDown()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.V_RawMax = New System.Windows.Forms.Label()
        Me.V_Sample_RawMin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.V_RawMin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.V_EuMin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.H_Sample_RawMin = New System.Windows.Forms.Button()
        Me.H_Sample_RawMax = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.H_RawMin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.H_EuMin = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.H_RawMax = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.H_EuMax = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PartTypeName = New System.Windows.Forms.Label()
        Me.btnSaveAngleCal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        CType(Me.V_EuMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.V_EuMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.H_EuMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.H_EuMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'V_Sample_RawMax
        '
        Me.V_Sample_RawMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.V_Sample_RawMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.V_Sample_RawMax.Enabled = False
        Me.V_Sample_RawMax.Location = New System.Drawing.Point(195, 39)
        Me.V_Sample_RawMax.Name = "V_Sample_RawMax"
        Me.V_Sample_RawMax.Size = New System.Drawing.Size(118, 32)
        Me.V_Sample_RawMax.TabIndex = 0
        Me.V_Sample_RawMax.Text = "Sample Raw UP"
        Me.V_Sample_RawMax.UseVisualStyleBackColor = False
        '
        'V_EuMax
        '
        Me.V_EuMax.DecimalPlaces = 1
        Me.V_EuMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_EuMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.V_EuMax.Location = New System.Drawing.Point(40, 42)
        Me.V_EuMax.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.V_EuMax.Name = "V_EuMax"
        Me.V_EuMax.Size = New System.Drawing.Size(69, 26)
        Me.V_EuMax.TabIndex = 2
        Me.V_EuMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRaw
        '
        Me.lblRaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(1, 12)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(53, 18)
        Me.lblRaw.TabIndex = 3
        Me.lblRaw.Text = "Raw"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pos. °"
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox.Controls.Add(Me.V_RawMax)
        Me.GroupBox.Controls.Add(Me.lblRaw)
        Me.GroupBox.Controls.Add(Me.V_EuMax)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Location = New System.Drawing.Point(195, 68)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(118, 76)
        Me.GroupBox.TabIndex = 5
        Me.GroupBox.TabStop = False
        '
        'V_RawMax
        '
        Me.V_RawMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.V_RawMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.V_RawMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_RawMax.Location = New System.Drawing.Point(40, 12)
        Me.V_RawMax.Name = "V_RawMax"
        Me.V_RawMax.Size = New System.Drawing.Size(69, 23)
        Me.V_RawMax.TabIndex = 7
        Me.V_RawMax.Text = "0"
        Me.V_RawMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'V_Sample_RawMin
        '
        Me.V_Sample_RawMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.V_Sample_RawMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.V_Sample_RawMin.Enabled = False
        Me.V_Sample_RawMin.Location = New System.Drawing.Point(195, 253)
        Me.V_Sample_RawMin.Name = "V_Sample_RawMin"
        Me.V_Sample_RawMin.Size = New System.Drawing.Size(118, 38)
        Me.V_Sample_RawMin.TabIndex = 6
        Me.V_Sample_RawMin.Text = "Sample Raw Down"
        Me.V_Sample_RawMin.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.Controls.Add(Me.V_RawMin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.V_EuMin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(195, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 76)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'V_RawMin
        '
        Me.V_RawMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.V_RawMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.V_RawMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_RawMin.Location = New System.Drawing.Point(40, 12)
        Me.V_RawMin.Name = "V_RawMin"
        Me.V_RawMin.Size = New System.Drawing.Size(69, 23)
        Me.V_RawMin.TabIndex = 8
        Me.V_RawMin.Text = "0"
        Me.V_RawMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Raw"
        '
        'V_EuMin
        '
        Me.V_EuMin.DecimalPlaces = 1
        Me.V_EuMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_EuMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.V_EuMin.Location = New System.Drawing.Point(40, 42)
        Me.V_EuMin.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.V_EuMin.Minimum = New Decimal(New Integer() {12, 0, 0, -2147483648})
        Me.V_EuMin.Name = "V_EuMin"
        Me.V_EuMin.Size = New System.Drawing.Size(69, 26)
        Me.V_EuMin.TabIndex = 2
        Me.V_EuMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.V_EuMin.Value = New Decimal(New Integer() {100, 0, 0, -2147418112})
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pos. °"
        '
        'H_Sample_RawMin
        '
        Me.H_Sample_RawMin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.H_Sample_RawMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.H_Sample_RawMin.Enabled = False
        Me.H_Sample_RawMin.Location = New System.Drawing.Point(12, 127)
        Me.H_Sample_RawMin.Name = "H_Sample_RawMin"
        Me.H_Sample_RawMin.Size = New System.Drawing.Size(60, 72)
        Me.H_Sample_RawMin.TabIndex = 8
        Me.H_Sample_RawMin.Text = "Sample Raw IB"
        Me.H_Sample_RawMin.UseVisualStyleBackColor = False
        '
        'H_Sample_RawMax
        '
        Me.H_Sample_RawMax.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.H_Sample_RawMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.H_Sample_RawMax.Enabled = False
        Me.H_Sample_RawMax.Location = New System.Drawing.Point(435, 129)
        Me.H_Sample_RawMax.Name = "H_Sample_RawMax"
        Me.H_Sample_RawMax.Size = New System.Drawing.Size(60, 72)
        Me.H_Sample_RawMax.TabIndex = 9
        Me.H_Sample_RawMax.Text = "Sample Raw OB"
        Me.H_Sample_RawMax.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox2.Controls.Add(Me.H_RawMin)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.H_EuMin)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 76)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'H_RawMin
        '
        Me.H_RawMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.H_RawMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.H_RawMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_RawMin.Location = New System.Drawing.Point(40, 16)
        Me.H_RawMin.Name = "H_RawMin"
        Me.H_RawMin.Size = New System.Drawing.Size(69, 23)
        Me.H_RawMin.TabIndex = 6
        Me.H_RawMin.Text = "0"
        Me.H_RawMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Raw"
        '
        'H_EuMin
        '
        Me.H_EuMin.DecimalPlaces = 1
        Me.H_EuMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_EuMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.H_EuMin.Location = New System.Drawing.Point(40, 42)
        Me.H_EuMin.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.H_EuMin.Minimum = New Decimal(New Integer() {12, 0, 0, -2147483648})
        Me.H_EuMin.Name = "H_EuMin"
        Me.H_EuMin.Size = New System.Drawing.Size(69, 26)
        Me.H_EuMin.TabIndex = 2
        Me.H_EuMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pos. °"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox3.Controls.Add(Me.H_RawMax)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.H_EuMax)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(314, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(118, 76)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'H_RawMax
        '
        Me.H_RawMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.H_RawMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.H_RawMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_RawMax.Location = New System.Drawing.Point(40, 10)
        Me.H_RawMax.Name = "H_RawMax"
        Me.H_RawMax.Size = New System.Drawing.Size(69, 23)
        Me.H_RawMax.TabIndex = 5
        Me.H_RawMax.Text = "0"
        Me.H_RawMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Raw"
        '
        'H_EuMax
        '
        Me.H_EuMax.DecimalPlaces = 1
        Me.H_EuMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_EuMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.H_EuMax.Location = New System.Drawing.Point(40, 42)
        Me.H_EuMax.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.H_EuMax.Name = "H_EuMax"
        Me.H_EuMax.Size = New System.Drawing.Size(69, 26)
        Me.H_EuMax.TabIndex = 2
        Me.H_EuMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Pos. °"
        '
        'PartTypeName
        '
        Me.PartTypeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartTypeName.BackColor = System.Drawing.Color.White
        Me.PartTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PartTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartTypeName.Location = New System.Drawing.Point(3, 7)
        Me.PartTypeName.Name = "PartTypeName"
        Me.PartTypeName.Size = New System.Drawing.Size(495, 23)
        Me.PartTypeName.TabIndex = 12
        Me.PartTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveAngleCal
        '
        Me.btnSaveAngleCal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveAngleCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSaveAngleCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAngleCal.Location = New System.Drawing.Point(382, 243)
        Me.btnSaveAngleCal.Name = "btnSaveAngleCal"
        Me.btnSaveAngleCal.Size = New System.Drawing.Size(113, 48)
        Me.btnSaveAngleCal.TabIndex = 13
        Me.btnSaveAngleCal.Text = "Save Angle Cal Values"
        Me.btnSaveAngleCal.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 48)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Get Current Calibration"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblInstruction
        '
        Me.lblInstruction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstruction.Location = New System.Drawing.Point(195, 147)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(114, 38)
        Me.lblInstruction.TabIndex = 15
        Me.lblInstruction.Text = "You will need to supply the achived angles for each quadrant"
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Uc_Coordinate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSaveAngleCal)
        Me.Controls.Add(Me.PartTypeName)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.H_Sample_RawMax)
        Me.Controls.Add(Me.H_Sample_RawMin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.V_Sample_RawMin)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.V_Sample_RawMax)
        Me.Name = "Uc_Coordinate"
        Me.Size = New System.Drawing.Size(498, 296)
        CType(Me.V_EuMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.V_EuMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.H_EuMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.H_EuMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents V_Sample_RawMax As Button
    Private WithEvents V_EuMax As NumericUpDown
    Private WithEvents lblRaw As Label
    Private WithEvents Label1 As Label
    Private WithEvents GroupBox As GroupBox
    Private WithEvents V_Sample_RawMin As Button
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents Label2 As Label
    Private WithEvents V_EuMin As NumericUpDown
    Private WithEvents Label3 As Label
    Private WithEvents H_Sample_RawMin As Button
    Private WithEvents H_Sample_RawMax As Button
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents Label4 As Label
    Private WithEvents H_EuMin As NumericUpDown
    Private WithEvents Label5 As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents Label6 As Label
    Private WithEvents H_EuMax As NumericUpDown
    Private WithEvents Label7 As Label
    Private WithEvents PartTypeName As Label
    Private WithEvents btnSaveAngleCal As Button
    Private WithEvents V_RawMax As Label
    Private WithEvents V_RawMin As Label
    Private WithEvents H_RawMin As Label
    Private WithEvents H_RawMax As Label
    Private WithEvents Button1 As Button
    Private WithEvents lblInstruction As Label
End Class
