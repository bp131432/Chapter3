Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim assessment As Double
        Dim propTax As Double

        assessment = (CDbl(txtActualPropertyValue.Text) * 0.6)
        lblAssessmentValue.Text = assessment
        propTax = assessment * 0.0064
        lblPropertyTax.Text = propTax.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAssessmentValue.Text = ""
        lblPropertyTax.Text = ""
        txtActualPropertyValue.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
