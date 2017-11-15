Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Average As Double
        Average = CDbl(txtTestScore1.Text) + CDbl(txtTestScore2.Text) +
            CDbl(txtTestScore3.Text) + CDbl(txtTestScore4.Text) + CDbl(txtTestScore5.Text)
        lblAverage.Text = Average / "5"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScore1.Text = ""
        txtTestScore2.Text = ""
        txtTestScore3.Text = ""
        txtTestScore4.Text = ""
        txtTestScore5.Text = ""
        lblAverage.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
