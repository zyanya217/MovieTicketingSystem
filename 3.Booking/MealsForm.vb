Imports System.Windows

Public Class MealsForm
    Public Totalseat As Int16
    Public Seatprice As Int16
    Public discount_ticket As Double
    Public regular As Double
    Public group_ticket As Double
    Public Phone As String
    Public Theater As String
    Public Movie As String
    Public SelectDate As String
    Public SelectTime As String

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim price As Int16
        price = ComboBox1.SelectedIndex.ToString * 60 + ComboBox2.SelectedIndex.ToString * 50 + ComboBox3.SelectedIndex.ToString * 40 +
            ComboBox4.SelectedIndex.ToString * 50 + ComboBox5.SelectedIndex.ToString * 30 + ComboBox6.SelectedIndex.ToString * 20 + ComboBox7.SelectedIndex.ToString * 10

        Dim sForm As New SeatForm
        sForm.Phone = Phone
        sForm.Theater = Theater
        sForm.Phone = Phone
        sForm.SelectDate = SelectDate
        sForm.SelectTime = SelectTime
        sForm.discount_ticket = discount_ticket
        sForm.regular = regular
        sForm.group_ticket = group_ticket
        sForm.Seatprice = Seatprice
        sForm.Seatprice = Seatprice
        sForm.Mealsprice = price
        sForm.Totalseat = Totalseat
        sForm.Show()

        Me.Hide()
    End Sub


End Class