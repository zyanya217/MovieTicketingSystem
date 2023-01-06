Public Class SeatForm
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim mForm As New MealsForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim dForm As New DetailsForm

        dForm.Show()
    End Sub



    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click

    End Sub
End Class