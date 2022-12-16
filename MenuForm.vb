Public Class MenuForm
    Private Sub btnIntroduction_Click(sender As Object, e As EventArgs) Handles btnIntroduction.Click
        Dim mForm As New MovieForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

    End Sub

    Private Sub btnInquire_Click(sender As Object, e As EventArgs) Handles btnInquire.Click

    End Sub
End Class
