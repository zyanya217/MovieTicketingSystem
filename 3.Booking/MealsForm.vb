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
        If ComboBox1.SelectedIndex = -1 AndAlso ComboBox2.SelectedIndex = -1 AndAlso ComboBox3.SelectedIndex = -1 Then
            mealslist = ""
        Else
            mealslist = "爆米花:" + vbCrLf
            If ComboBox1.SelectedIndex <> -1 Then
                mealslist += "大x" + ComboBox1.SelectedIndex.ToString + vbCrLf
            End If
            If ComboBox2.SelectedIndex <> -1 Then
                mealslist += "中x" + ComboBox2.SelectedIndex.ToString + vbCrLf
            End If
            If ComboBox3.SelectedIndex <> -1 Then
                mealslist += "小x" + ComboBox3.SelectedIndex.ToString + vbCrLf
            End If
        End If
        If ComboBox4.SelectedIndex = -1 Then
            mealslist = ""
        Else
            mealslist += "大亨堡" + "x" + ComboBox4.SelectedIndex.ToString + vbCrLf
        End If
        If ComboBox5.SelectedIndex = -1 AndAlso ComboBox6.SelectedIndex = -1 AndAlso ComboBox7.SelectedIndex = -1 Then
            mealslist += ""
        Else
            mealslist += "可樂:" + vbCrLf
            If ComboBox5.SelectedIndex <> -1 Then
                mealslist += "大杯x" + ComboBox5.SelectedIndex.ToString + vbCrLf
            End If
            If ComboBox6.SelectedIndex <> -1 Then
                mealslist += "中杯x" + ComboBox6.SelectedIndex.ToString + vbCrLf
            End If
            If ComboBox7.SelectedIndex <> -1 Then
                mealslist += "小杯x" + ComboBox7.SelectedIndex.ToString + vbCrLf
            End If
        End If
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
        sForm.Mealslist = mealslist
        sForm.Show()

        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mealslist = ""
        If ComboBox1.SelectedIndex = -1 AndAlso ComboBox2.SelectedIndex = -1 AndAlso ComboBox3.SelectedIndex = -1 Then
            mealslist = ""
        Else
            mealslist = "爆米花:" + vbCrLf
            If ComboBox1.SelectedIndex <> -1 Then
                mealslist += "大x" + ComboBox1.SelectedIndex.ToString + vbCrLf
            End If
            If ComboBox2.SelectedIndex <> -1 Then
                mealslist += "中x" + ComboBox2.SelectedIndex.ToString + vbCrLf
            End If
            If ComboBox3.SelectedIndex <> -1 Then
                mealslist += "小x" + ComboBox3.SelectedIndex.ToString + vbCrLf
            End If
        End If
        If ComboBox4.SelectedIndex = -1 Then
            mealslist = ""
        Else
            mealslist += "大亨堡" + "x" + ComboBox4.SelectedIndex.ToString + vbCrLf
        End If
        If ComboBox5.SelectedIndex = -1 AndAlso ComboBox6.SelectedIndex = -1 AndAlso ComboBox7.SelectedIndex = -1 Then
            mealslist += ""
        Else
            mealslist += "可樂:" + vbCrLf
            If ComboBox5.SelectedIndex <> -1 Then
                mealslist += "大杯x" + ComboBox5.SelectedIndex.ToString + vbCrLf
            End If
            If ComboBox6.SelectedIndex <> -1 Then
                mealslist += "中杯x" + ComboBox6.SelectedIndex.ToString + vbCrLf
            End If
            If ComboBox7.SelectedIndex <> -1 Then
                mealslist += "小杯x" + ComboBox7.SelectedIndex.ToString + vbCrLf
            End If
        End If
        Button1.Text = mealslist.ToString + vbCrLf + "共:" + price.ToString

    End Sub
End Class