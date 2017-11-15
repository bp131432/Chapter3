Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblFahrenheit As Double
        Dim dblCelsius As Double

        dblCelsius = CDbl(txtCelsius.Text)
        dblFahrenheit = CDbl(1.8 * dblCelsius + 32)
        lblFahrenheit.Text = dblFahrenheit.ToString("n")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFahrenheit.Text = ""
        txtCelsius.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
