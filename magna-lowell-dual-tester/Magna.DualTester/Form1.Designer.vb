﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.BtnAppSettings = New System.Windows.Forms.Button()
        Me.BtnCalibrate = New System.Windows.Forms.Button()
        Me.BtnSetPoints = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutUser = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAccessLvl = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadEnglish = New System.Windows.Forms.RadioButton()
        Me.RadSpanish = New System.Windows.Forms.RadioButton()
        Me.BtnMain = New System.Windows.Forms.Button()
        Me.BtnService = New System.Windows.Forms.Button()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.BtnDbgLogin = New System.Windows.Forms.Button()
        Me.BtnScheduleView = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblError = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RePrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestPrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerDisplayShift = New System.Windows.Forms.Timer(Me.components)
        Me.LabelDim = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutUser.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.AutoSize = True
        Me.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(1, 43)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1262, 759)
        Me.MainPanel.TabIndex = 0
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLogOut.Location = New System.Drawing.Point(3, 3)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 46)
        Me.BtnLogOut.TabIndex = 1
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = True
        '
        'BtnAppSettings
        '
        Me.BtnAppSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAppSettings.Location = New System.Drawing.Point(327, 3)
        Me.BtnAppSettings.Name = "BtnAppSettings"
        Me.BtnAppSettings.Size = New System.Drawing.Size(75, 46)
        Me.BtnAppSettings.TabIndex = 3
        Me.BtnAppSettings.Text = "Application Settings"
        Me.BtnAppSettings.UseVisualStyleBackColor = True
        '
        'BtnCalibrate
        '
        Me.BtnCalibrate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCalibrate.Location = New System.Drawing.Point(165, 3)
        Me.BtnCalibrate.Name = "BtnCalibrate"
        Me.BtnCalibrate.Size = New System.Drawing.Size(75, 46)
        Me.BtnCalibrate.TabIndex = 2
        Me.BtnCalibrate.Text = "Calibrate"
        Me.BtnCalibrate.UseVisualStyleBackColor = True
        '
        'BtnSetPoints
        '
        Me.BtnSetPoints.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSetPoints.Location = New System.Drawing.Point(408, 3)
        Me.BtnSetPoints.Name = "BtnSetPoints"
        Me.BtnSetPoints.Size = New System.Drawing.Size(75, 46)
        Me.BtnSetPoints.TabIndex = 4
        Me.BtnSetPoints.Text = "Setpoints"
        Me.BtnSetPoints.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.46836!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.53164!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutUser, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnLogOut, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnMain, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCalibrate, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAppSettings, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSetPoints, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnService, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTime, 11, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDbgLogin, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnScheduleView, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 806)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1256, 52)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutUser
        '
        Me.TableLayoutUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutUser.AutoSize = True
        Me.TableLayoutUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutUser.ColumnCount = 3
        Me.TableLayoutUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutUser.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutUser.Controls.Add(Me.TxtUser, 1, 0)
        Me.TableLayoutUser.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutUser.Controls.Add(Me.TxtAccessLvl, 1, 1)
        Me.TableLayoutUser.Location = New System.Drawing.Point(807, 0)
        Me.TableLayoutUser.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.TableLayoutUser.Name = "TableLayoutUser"
        Me.TableLayoutUser.RowCount = 2
        Me.TableLayoutUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutUser.Size = New System.Drawing.Size(253, 52)
        Me.TableLayoutUser.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtUser
        '
        Me.TxtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUser.Location = New System.Drawing.Point(79, 3)
        Me.TxtUser.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.ReadOnly = True
        Me.TxtUser.Size = New System.Drawing.Size(152, 20)
        Me.TxtUser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Access Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAccessLvl
        '
        Me.TxtAccessLvl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAccessLvl.Location = New System.Drawing.Point(79, 28)
        Me.TxtAccessLvl.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAccessLvl.Name = "TxtAccessLvl"
        Me.TxtAccessLvl.ReadOnly = True
        Me.TxtAccessLvl.Size = New System.Drawing.Size(152, 20)
        Me.TxtAccessLvl.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.RadEnglish, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.RadSpanish, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(732, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(69, 52)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'RadEnglish
        '
        Me.RadEnglish.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadEnglish.AutoSize = True
        Me.RadEnglish.Checked = True
        Me.RadEnglish.Location = New System.Drawing.Point(3, 4)
        Me.RadEnglish.Name = "RadEnglish"
        Me.RadEnglish.Size = New System.Drawing.Size(63, 17)
        Me.RadEnglish.TabIndex = 0
        Me.RadEnglish.TabStop = True
        Me.RadEnglish.Text = "English"
        Me.RadEnglish.UseVisualStyleBackColor = True
        '
        'RadSpanish
        '
        Me.RadSpanish.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadSpanish.AutoSize = True
        Me.RadSpanish.Location = New System.Drawing.Point(3, 30)
        Me.RadSpanish.Name = "RadSpanish"
        Me.RadSpanish.Size = New System.Drawing.Size(63, 17)
        Me.RadSpanish.TabIndex = 1
        Me.RadSpanish.Text = "Spanish"
        Me.RadSpanish.UseVisualStyleBackColor = True
        '
        'BtnMain
        '
        Me.BtnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMain.Location = New System.Drawing.Point(84, 3)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(75, 46)
        Me.BtnMain.TabIndex = 6
        Me.BtnMain.Text = "Main"
        Me.BtnMain.UseVisualStyleBackColor = True
        '
        'BtnService
        '
        Me.BtnService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnService.Location = New System.Drawing.Point(570, 3)
        Me.BtnService.Name = "BtnService"
        Me.BtnService.Size = New System.Drawing.Size(75, 46)
        Me.BtnService.TabIndex = 10
        Me.BtnService.Text = "Returnable"
        Me.BtnService.UseVisualStyleBackColor = True
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTime.Location = New System.Drawing.Point(1066, 0)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(187, 52)
        Me.LblTime.TabIndex = 11
        '
        'BtnDbgLogin
        '
        Me.BtnDbgLogin.Location = New System.Drawing.Point(651, 3)
        Me.BtnDbgLogin.Name = "BtnDbgLogin"
        Me.BtnDbgLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnDbgLogin.TabIndex = 12
        Me.BtnDbgLogin.Text = "Button1"
        Me.BtnDbgLogin.UseVisualStyleBackColor = True
        Me.BtnDbgLogin.Visible = False
        '
        'BtnScheduleView
        '
        Me.BtnScheduleView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnScheduleView.Location = New System.Drawing.Point(246, 3)
        Me.BtnScheduleView.Name = "BtnScheduleView"
        Me.BtnScheduleView.Size = New System.Drawing.Size(75, 46)
        Me.BtnScheduleView.TabIndex = 13
        Me.BtnScheduleView.Text = "Schedule"
        Me.BtnScheduleView.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.MainPanel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LblError, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1264, 862)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'LblError
        '
        Me.LblError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.Location = New System.Drawing.Point(4, 24)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(1256, 16)
        Me.LblError.TabIndex = 7
        Me.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1262, 20)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RePrintToolStripMenuItem, Me.TestPrintToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 16)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'RePrintToolStripMenuItem
        '
        Me.RePrintToolStripMenuItem.Name = "RePrintToolStripMenuItem"
        Me.RePrintToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.RePrintToolStripMenuItem.Text = "Re-Print"
        '
        'TestPrintToolStripMenuItem
        '
        Me.TestPrintToolStripMenuItem.Name = "TestPrintToolStripMenuItem"
        Me.TestPrintToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TestPrintToolStripMenuItem.Text = "Test Print"
        '
        'TimerDisplayShift
        '
        Me.TimerDisplayShift.Enabled = True
        Me.TimerDisplayShift.Interval = 1000
        '
        'LabelDim
        '
        Me.LabelDim.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 862)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dual Tester Application"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout
        Me.TableLayoutUser.ResumeLayout(false)
        Me.TableLayoutUser.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents BtnAppSettings As System.Windows.Forms.Button
    Friend WithEvents BtnCalibrate As System.Windows.Forms.Button
    Friend WithEvents BtnSetPoints As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnMain As System.Windows.Forms.Button
    Friend WithEvents TimerDisplayShift As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutUser As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtAccessLvl As System.Windows.Forms.TextBox
    Friend WithEvents LblError As System.Windows.Forms.Label
    Friend WithEvents LabelDim As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RadEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents RadSpanish As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnService As System.Windows.Forms.Button
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents BtnDbgLogin As Button
    Friend WithEvents BtnScheduleView As Button
    Friend WithEvents RePrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestPrintToolStripMenuItem As ToolStripMenuItem
End Class
