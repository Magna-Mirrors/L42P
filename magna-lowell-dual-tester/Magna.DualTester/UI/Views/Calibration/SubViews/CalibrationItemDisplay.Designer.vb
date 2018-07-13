<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalibrationItemDisplay
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.LblTaskLightVal = New System.Windows.Forms.Label()
        Me.BtnCalibrate = New System.Windows.Forms.Button()
        Me.BtnPower = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblRaw, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTaskLightVal, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCalibrate, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPower, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(603, 127)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblRaw
        '
        Me.lblRaw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRaw.BackColor = System.Drawing.Color.Black
        Me.lblRaw.ForeColor = System.Drawing.Color.White
        Me.lblRaw.Location = New System.Drawing.Point(202, 1)
        Me.lblRaw.Margin = New System.Windows.Forms.Padding(1)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Padding = New System.Windows.Forms.Padding(3)
        Me.lblRaw.Size = New System.Drawing.Size(199, 125)
        Me.lblRaw.TabIndex = 40
        Me.lblRaw.Text = "0"
        Me.lblRaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTaskLightVal
        '
        Me.LblTaskLightVal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTaskLightVal.BackColor = System.Drawing.Color.Black
        Me.LblTaskLightVal.ForeColor = System.Drawing.Color.White
        Me.LblTaskLightVal.Location = New System.Drawing.Point(1, 1)
        Me.LblTaskLightVal.Margin = New System.Windows.Forms.Padding(1)
        Me.LblTaskLightVal.Name = "LblTaskLightVal"
        Me.LblTaskLightVal.Padding = New System.Windows.Forms.Padding(3)
        Me.LblTaskLightVal.Size = New System.Drawing.Size(199, 125)
        Me.LblTaskLightVal.TabIndex = 39
        Me.LblTaskLightVal.Text = "0.000 A"
        Me.LblTaskLightVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCalibrate
        '
        Me.BtnCalibrate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCalibrate.Location = New System.Drawing.Point(403, 1)
        Me.BtnCalibrate.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnCalibrate.Name = "BtnCalibrate"
        Me.BtnCalibrate.Size = New System.Drawing.Size(98, 125)
        Me.BtnCalibrate.TabIndex = 41
        Me.BtnCalibrate.Text = "Calibrate"
        Me.BtnCalibrate.UseVisualStyleBackColor = True
        '
        'BtnPower
        '
        Me.BtnPower.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPower.Location = New System.Drawing.Point(503, 1)
        Me.BtnPower.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnPower.Name = "BtnPower"
        Me.BtnPower.Size = New System.Drawing.Size(99, 125)
        Me.BtnPower.TabIndex = 42
        Me.BtnPower.Text = "Power"
        Me.BtnPower.UseVisualStyleBackColor = True
        '
        'CalibrationItemDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "CalibrationItemDisplay"
        Me.Size = New System.Drawing.Size(603, 127)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblTaskLightVal As Label
    Friend WithEvents lblRaw As Label
    Friend WithEvents BtnCalibrate As Button
    Friend WithEvents BtnPower As Button
End Class
