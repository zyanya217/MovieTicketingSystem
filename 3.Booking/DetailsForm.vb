Imports System.Runtime.Remoting

Public Class DetailsForm
    Public Property SourceForm As BookingForm
    Public MealsPrice As Int16
    Dim a As Double
    Dim phone_d As String
    Private bform As BookingForm
    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = SourceForm.TextBox1.Text
    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click

        bform.Close()
        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class