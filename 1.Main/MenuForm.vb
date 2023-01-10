Public Class MenuForm
    Private Sub btnIntroduction_Click(sender As Object, e As EventArgs) Handles btnIntroduction.Click
        Dim mForm As New MovieForm
        Me.Close()
        mForm.Show()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Dim bForm As New BookingForm
        Me.Close()
        bForm.Show()
    End Sub

    Private Sub btnInquire_Click(sender As Object, e As EventArgs) Handles btnInquire.Click
        Dim tForm As New TrackingForm
        Me.Close()
        tForm.Show()
    End Sub
End Class
