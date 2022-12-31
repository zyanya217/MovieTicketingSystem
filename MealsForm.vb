Public Class MealsForm
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim bForm As New BookingForm
        Me.Hide()
        bForm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim sForm As New SeatForm
        Me.Hide()
        sForm.Show()
    End Sub
End Class