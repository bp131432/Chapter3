Public Class Form1

 
 
    Private Sub lblTodayDate_Click(sender As Object, e As EventArgs) Handles lblTodayDate.Click
        lblTodayDate.Text = Now.ToString("D")
    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click
        'Declare variable for the calculations.
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        'Calculate and display the room charges 
        decRoomCharges = CDec(txtNights.Text) *
            CDec(txtNightlyCharge.Text)
        lblRoomCharges.Text = decRoomCharges.ToString("c")

        'Calculate and display the additional charges
        decAddCharges = CDec(txtRoomService.Text) +
            CDec(txtTelephone.Text) +
            CDec(txtMisc.Text)
        lblA()
    End Sub
End Class
