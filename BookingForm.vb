Public Class BookingForm
    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
        Label12.BackColor = Color.Transparent
        LblTotal.BackColor = Color.Transparent


        Dim phone As String


    End Sub
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim mForm As New MenuForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim nForm As New MealsForm
        Me.Hide()
        nForm.Show()

        '判斷欄位是否有空值，若無空值，則帶入值
        If TextBox1.Text IsNot Nothing And (Len(TextBox1.Text) = 10) Then
            Double.TryParse(TextBox1.Text, phone)
        Else
            '判斷電話輸入是否合理
            Dim PhoneInput As DialogResult
            PhoneInput = MessageBox.Show("Please enter the correct phone number format.")
        End If





    End Sub

    Private Function phone() As Double
        Throw New NotImplementedException()
    End Function


End Class