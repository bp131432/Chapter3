Public Class Form1

    Private Sub btnPLus_Click(sender As Object, e As EventArgs) Handles btnPLus.Click
        'This event handler performs addition
        'Declare a variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " + "

        dblResult = CDbl(txtOne.Text) + CDbl(txtTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        'This event handler performs subtraction
        Dim dblResult As Double

        lblOperation.Text = " - "

        dblResult = CDbl(txtOne.Text) - CDbl(txtTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'This event handler performs multiplication
        Dim dblResult As Double

        lblOperation.Text = " * "

        dblResult = CDbl(txtOne.Text) * CDbl(txtTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'This event handler performs division
        Dim dblResult As Double

        lblOperation.Text = " / "

        dblResult = CDbl(txtOne.Text) / CDbl(txtTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExponant_Click(sender As Object, e As EventArgs) Handles btnExponant.Click
        'this event handler performs an exponant
        Dim dblResult As Double

        lblOperation.Text = " ^ "

        dblResult = CDbl(txtOne.Text) ^ CDbl(txtTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        'This event handler performs a modulus
        Dim dblResult As Double

        lblOperation.Text = " MOD "

        dblResult = CDbl(txtOne.Text) Mod CDbl(txtTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOne.Clear()
        txtTwo.Clear()
        lblResult.Text = String.Empty
        lblOperation.Text = String.Empty

    End Sub
End Class
