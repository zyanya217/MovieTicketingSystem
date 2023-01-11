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
    Public mealslist As String
    Public price As Int16

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        mealslist = ""
        price = 0
        If ComboBox1.SelectedIndex = -1 AndAlso ComboBox2.SelectedIndex = -1 AndAlso ComboBox3.SelectedIndex = -1 Then
            mealslist = ""
        Else
            mealslist += "爆米花"
            If ComboBox1.SelectedIndex <> -1 Then
                mealslist += " (大)x" + ComboBox1.SelectedIndex.ToString
                price += ComboBox1.SelectedIndex * 60
            End If
            If ComboBox2.SelectedIndex <> -1 Then
                mealslist += " (中)x" + ComboBox2.SelectedIndex.ToString
                price += ComboBox2.SelectedIndex * 50
            End If
            If ComboBox3.SelectedIndex <> -1 Then
                mealslist += " (小)x" + ComboBox3.SelectedIndex.ToString
                price += ComboBox3.SelectedIndex * 30
            End If
        End If
        If ComboBox4.SelectedIndex = -1 Then
            mealslist += ""
        Else
            mealslist += vbCrLf + "大亨堡" + "x" + ComboBox4.SelectedIndex.ToString
            price += ComboBox4.SelectedIndex * 50
        End If
        If ComboBox5.SelectedIndex = -1 AndAlso ComboBox6.SelectedIndex = -1 AndAlso ComboBox7.SelectedIndex = -1 Then
            mealslist += ""
        Else
            mealslist += vbCrLf + "可樂"
            If ComboBox5.SelectedIndex <> -1 Then
                mealslist += "(大)x" + ComboBox5.SelectedIndex.ToString
                price += ComboBox5.SelectedIndex * 30
            End If
            If ComboBox6.SelectedIndex <> -1 Then
                mealslist += "(中)x" + ComboBox6.SelectedIndex.ToString
                price += ComboBox6.SelectedIndex * 20
            End If
            If ComboBox7.SelectedIndex <> -1 Then
                mealslist += "(小)x" + ComboBox7.SelectedIndex.ToString
                price += ComboBox7.SelectedIndex * 10
            End If
        End If
        Dim sForm As New SeatForm
        sForm.Phone = Phone
        sForm.Movie = Movie
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
        sForm.Mealslist = mealslist
        sForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mealslist = ""
        price = 0
        If ComboBox1.SelectedIndex = -1 AndAlso ComboBox2.SelectedIndex = -1 AndAlso ComboBox3.SelectedIndex = -1 Then
            mealslist = ""
        Else
            mealslist += "爆米花"
            If ComboBox1.SelectedIndex <> -1 Then
                mealslist += " (大)x" + ComboBox1.SelectedIndex.ToString
                price += ComboBox1.SelectedIndex * 60
            End If
            If ComboBox2.SelectedIndex <> -1 Then
                mealslist += " (中)x" + ComboBox2.SelectedIndex.ToString
                price += ComboBox2.SelectedIndex * 50
            End If
            If ComboBox3.SelectedIndex <> -1 Then
                mealslist += " (小)x" + ComboBox3.SelectedIndex.ToString
                price += ComboBox3.SelectedIndex * 30
            End If
        End If
        If ComboBox4.SelectedIndex = -1 Then
            mealslist += ""
        Else
            mealslist += vbCrLf + "大亨堡" + "x" + ComboBox4.SelectedIndex.ToString
            price += ComboBox4.SelectedIndex * 50
        End If
        If ComboBox5.SelectedIndex = -1 AndAlso ComboBox6.SelectedIndex = -1 AndAlso ComboBox7.SelectedIndex = -1 Then
            mealslist += ""
        Else
            mealslist += vbCrLf + "可樂"
            If ComboBox5.SelectedIndex <> -1 Then
                mealslist += "(大)x" + ComboBox5.SelectedIndex.ToString
                price += ComboBox5.SelectedIndex * 30
            End If
            If ComboBox6.SelectedIndex <> -1 Then
                mealslist += "(中)x" + ComboBox6.SelectedIndex.ToString
                price += ComboBox6.SelectedIndex * 20
            End If
            If ComboBox7.SelectedIndex <> -1 Then
                mealslist += "(小)x" + ComboBox7.SelectedIndex.ToString
                price += ComboBox7.SelectedIndex * 10
            End If
        End If
        Button1.Text = mealslist.ToString + vbCrLf + "共:" + price.ToString

    End Sub
End Class