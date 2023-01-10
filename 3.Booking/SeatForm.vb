Public Class SeatForm

    Public Totalseat As Int16
    Public Mealsprice As Int16

    Private Sub SeatForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Text = "可選擇座位數:" + Totalseat.ToString


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