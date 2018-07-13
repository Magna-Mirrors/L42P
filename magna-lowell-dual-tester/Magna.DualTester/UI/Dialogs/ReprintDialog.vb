Public Class ReprintDialog

    Public Property SelectedPrinter As PrintCfg

    Public Sub New(cfgtool As ICfgNonDomino)
        InitializeComponent()

        PrintCfgBindingSource.DataSource = cfgtool.ReadConfig().Printers.ToList()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If ComboBox1.SelectedItem Is Nothing Then
            Return
        End If
        SelectedPrinter = DirectCast(ComboBox1.SelectedItem, PrintCfg)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class