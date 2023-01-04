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

        '用於傳值給webform 
        Dim frm As New DetailsForm
        frm.SourceForm = Me
        ' frm.ShowDialog()




    End Sub
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim mForm As New MenuForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click


        Dim phone As String

        '判斷欄位是否有空值，若無空值，則帶入值
        If TextBox1.Text IsNot Nothing And (Len(TextBox1.Text) = 10) Then
            Double.TryParse(TextBox1.Text, phone)
        Else
            '判斷電話輸入是否合理
            Dim PhoneInput As DialogResult
            PhoneInput = MessageBox.Show("Please enter the correct phone number format.")
        End If


        Dim nForm As New MealsForm
        'Me.Hide()
        'nForm.Show()
        Me.Visible = False
        nForm.Visible = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class