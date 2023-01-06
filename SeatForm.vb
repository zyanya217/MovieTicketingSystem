Public Class SeatForm

    Public Totalseat As Double
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim mForm As New MealsForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim dForm As New DetailsForm

        dForm.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SeatForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Text = "可選擇座位數:" + Totalseat.ToString

    End Sub
End Class