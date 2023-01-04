Public Class MealsForm
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim bForm As New BookingForm
        bForm.Visible = True
        Me.Visible = False

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim sForm As New SeatForm

        sForm.Visible = True
    End Sub


End Class