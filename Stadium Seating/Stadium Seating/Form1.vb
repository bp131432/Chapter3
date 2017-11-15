﻿Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblClassA As Double
        Dim dblClassB As Double
        Dim dblClassC As Double
        Dim TotalCharges As Double
        dblClassA = CDbl(txtClassA.Text) * 15
        lblClassA.Text = dblClassA.ToString("c")

        dblClassB = CDbl(txtClassB.Text) * 12
        lblClassB.Text = dblClassB.ToString("c")

        dblClassC = CDbl(txtClassC.Text) * 9
        lblClassC.Text = dblClassC.ToString("c")

        TotalCharges = CDec(lblClassA.Text) + CDec(lblClassB.Text) + CDec(lblClassC.Text)

        lblTotal.Text = TotalCharges.ToString("c")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblClassA.Text = ""
        lblClassB.Text = ""
        lblClassC.Text = ""
        lblTotal.Text = ""

        txtClassA.Text = ""
        txtClassB.Text = ""
        txtClassC.Text = ""
    End Sub
End Class
