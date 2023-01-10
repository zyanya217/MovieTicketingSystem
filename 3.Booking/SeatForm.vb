Imports System.Windows

Public Class SeatForm

    Public Totalseat As Int16
    Public Mealsprice As Int16
    Public Seatprice As Int16
    Public discount_ticket As Double
    Public regular As Double
    Public group_ticket As Double
    Public Phone As String
    Public Theater As String
    Public Movie As String
    Public SelectDate As String
    Public SelectTime As String

    Private Sub SeatForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Text = "可選擇座位數:" + Totalseat.ToString


    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim dForm As New DetailsForm
        dForm.Phone = Phone
        dForm.Theater = Theater
        dForm.Phone = Phone
        dForm.SelectDate = SelectDate
        dForm.SelectTime = SelectTime
        dForm.discount_ticket = discount_ticket
        dForm.regular = regular
        dForm.group_ticket = group_ticket
        dForm.Seatprice = Seatprice
        dForm.Mealsprice = Mealsprice
        dForm.Show()
    End Sub



    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click

    End Sub


End Class