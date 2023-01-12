Imports System.Runtime.Remoting
Imports System.Data.SqlClient

Public Class DetailsForm
    Public Property SourceForm As BookingForm
    Public Property WebConfigurationManager As Object
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
    Public Mealslist As String

    Dim SelectCmd As String = "select * from 學生資料表"


    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Text = Phone
        Label9.Text = Theater
        Label5.Text = Movie
        Label16.Text = SelectDate
        Label20.Text = Seatprice + Mealsprice
        Label14.Text = Mealslist.ToString

        '票種判斷
        Dim ticket As String




        ' 建立資料庫連結物件 
        Using connection As New SqlConnection(My.Settings.connString)
            ' 資料庫指令作為物件  
            Using sqlCommand As New SqlCommand("NEW.Booking", connection)
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add(New SqlParameter("@電影名稱", SqlDbType.NVarChar, 50))
                sqlCommand.Parameters("@電影名稱").Value = Movie
            End Using

        End Using

    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class