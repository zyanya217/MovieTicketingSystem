Public Class MealsForm
    Public Totalseat As Double



    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim price As Int16
        price = ComboBox1.SelectedIndex.ToString * 60 + ComboBox2.SelectedIndex.ToString * 50 + ComboBox3.SelectedIndex.ToString * 40 +
            ComboBox4.SelectedIndex.ToString * 50 + ComboBox5.SelectedIndex.ToString * 30 + ComboBox6.SelectedIndex.ToString * 20 + ComboBox7.SelectedIndex.ToString * 10
        Dim sForm As New SeatForm
        sForm.Totalseat = Totalseat
        sForm.Mealsprice = price
        sForm.Visible = True
    End Sub


End Class