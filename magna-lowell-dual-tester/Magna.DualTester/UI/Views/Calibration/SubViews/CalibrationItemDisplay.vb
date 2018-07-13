Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.TesterApi

Public Class CalibrationItemDisplay

    Public Event BtnPowerClicked As EventHandler(Of Boolean)
    Public Event BtnCalibrateClicked As EventHandler

    Private Property TitleLabel As Label = New Label() With {.TextAlign = ContentAlignment.MiddleCenter,
                                                                .Anchor = CType((1 Or 2 Or 4 Or 8), AnchorStyles)}

    Public Property MinUserLevel As AccessLevel
    Private Property _valueSuffix As String = "A"
    Public Property ValueSuffix As String
        Get
            Return _valueSuffix
        End Get
        Set(value As String)
            LblTaskLightVal.Text = "0.000 " + value
            _valueSuffix = value
        End Set
    End Property

    Public Property RawForeColor As Color
        Get
            Return lblRaw.ForeColor
        End Get
        Set(value As Color)
            lblRaw.ForeColor = value
        End Set
    End Property
    Public Property RawBackColor As Color
        Get
            Return lblRaw.BackColor
        End Get
        Set(value As Color)
            lblRaw.BackColor = value
        End Set
    End Property

    Dim _labelOnly As Boolean = False
    Dim _powerButtonVisible As Boolean = True
    Public Property PowerButtonVisible As Boolean
        Get
            Return _powerButtonVisible
        End Get
        Set(value As Boolean)
            BtnPower.Visible = value
            If value Then
                TableLayoutPanel1.SetColumnSpan(BtnCalibrate, 1)
            Else
                TableLayoutPanel1.SetColumnSpan(BtnCalibrate, 2)
            End If
            _powerButtonVisible = value
        End Set
    End Property

    Public Property CalibrationButtonText As String
        Get
            Return BtnCalibrate.Text
        End Get
        Set(value As String)
            TitleLabel.Text = value
            BtnCalibrate.Text = value
        End Set
    End Property

    Public Property PowerButtonText As String
        Get
            Return BtnPower.Text
        End Get
        Set(value As String)
            BtnPower.Text = value
        End Set
    End Property

    Public Property LabelOnly As Boolean
        Get
            Return _labelOnly
        End Get
        Set(value As Boolean)
            If _labelOnly <> value Then
                _labelOnly = value
                BtnCalibrate.Visible = Not _labelOnly
                BtnPower.Visible = Not _labelOnly AndAlso PowerButtonVisible
                If _labelOnly Then
                    TableLayoutPanel1.Controls.Remove(BtnCalibrate)
                    TableLayoutPanel1.Controls.Remove(BtnPower)
                    TableLayoutPanel1.Controls.Add(TitleLabel, 2, 0)
                    TableLayoutPanel1.SetColumnSpan(TitleLabel, 2)
                Else
                    TableLayoutPanel1.Controls.Remove(TitleLabel)
                    TableLayoutPanel1.Controls.Add(BtnCalibrate, 2, 0)
                    TableLayoutPanel1.SetColumnSpan(BtnCalibrate, If(PowerButtonVisible, 1, 2))
                    TableLayoutPanel1.Controls.Add(BtnPower, 3, 0)
                    TableLayoutPanel1.SetColumnSpan(BtnPower, 1)
                End If
            End If
        End Set
    End Property

    Private powerBtnState As Boolean = False

    Public Sub UpdateData(algitem As Udt_AlgItem, user As AccessLevel, Optional pwrBtnEnabled As Boolean = False, Optional powerbtnStat As Boolean = False)

        LblTaskLightVal.Text = algitem.Value.ToString("F3") + " " + ValueSuffix
        lblRaw.Text = algitem.AnalogInDint.ToString()
        BtnCalibrate.Enabled = Compair(algitem.AnalogInDint, algitem.MinRawCalDeflect) AndAlso user >= MinUserLevel
        BtnPower.Enabled = pwrBtnEnabled
        BtnPower.BackColor = If(powerbtnStat, Color.PaleGreen, SystemColors.Control)
        powerBtnState = powerbtnStat
    End Sub
    Private Function Compair(analogVal As Integer, mincal As Integer) As Boolean
        Dim minrawcal = Math.Abs(mincal)
        Return Math.Abs(analogVal) >= minrawcal AndAlso minrawcal > 0 'so both are above zero and analog is greater than or equal to minrawcal
    End Function

    Private Sub BtnCalibrate_Click(sender As Object, e As EventArgs) Handles BtnCalibrate.Click
        RaiseEvent BtnCalibrateClicked(Me, e)
    End Sub

    Private Sub BtnPower_Click(sender As Object, e As EventArgs) Handles BtnPower.Click
        RaiseEvent BtnPowerClicked(Me, powerBtnState)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub CalibrationItemDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
        TableLayoutPanel1.ColumnStyles(0).Width = 1 / 3
        TableLayoutPanel1.ColumnStyles(1).SizeType = SizeType.Percent
        TableLayoutPanel1.ColumnStyles(1).Width = 1 / 3
        TableLayoutPanel1.ColumnStyles(2).SizeType = SizeType.Percent
        TableLayoutPanel1.ColumnStyles(2).Width = (1 / 3) / 2
        TableLayoutPanel1.ColumnStyles(3).SizeType = SizeType.Percent
        TableLayoutPanel1.ColumnStyles(3).Width = (1 / 3) / 2
    End Sub

End Class
