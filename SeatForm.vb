Public Class SeatForm
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim mForm As New MealsForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim dForm As New DetailsForm
        Me.Hide()
        dForm.Show()
    End Sub
End Class