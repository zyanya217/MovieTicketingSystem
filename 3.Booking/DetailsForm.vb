Imports System.Runtime.Remoting

Public Class DetailsForm
    Public Property SourceForm As BookingForm
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
    Public Mealsprice As Int16
    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Phone
        Label9.Text = Theater
        Label5.Text = Movie

    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click


        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class