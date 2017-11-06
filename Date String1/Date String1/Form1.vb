Public Class Form1

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblDateString.Text = txtDayofweek.Text & ", " & txtMonth.Text &
            " " & txtDayofmonth.Text & ", " &
            txtYear.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDayofmonth.Clear()
        txtDayofweek.Clear()
        txtMonth.Clear()
        txtYear.Clear()
        lblDateString.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
