Imports System.Runtime.Remoting
Imports System.Data.SqlClient

Public Class DetailsForm
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

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
    Public SelectDate As Date
    Public SelectTime As String
    Public Mealsprice As Int16
    Public Mealslist As String

    'Dim SelectCmd As String = "select * from 學生資料表"


    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Text = Phone
        Label9.Text = Theater
        Label5.Text = Movie
        Label16.Text = SelectDate
        Label20.Text = Seatprice + Mealsprice
        Label14.Text = Mealslist.ToString

        '票種判斷
        Dim ticket As String
        Dim enMovie As String
        Dim enTime As String
        Dim enTheater As String

        enMovie = ""
        enTime = ""
        enTheater = ""

        If Movie = "阿凡達，水之道" Then
            enMovie = "Avatar: The Way of Water"
        ElseIf Movie = "黑豹2：瓦干達萬歲" Then
            enMovie = "Black Panther: Wakanda Forever"
        ElseIf Movie = "刀劍神域progressive 陰沉薄暮的詼諧曲" Then
            enMovie = "Sword Art Online Progressive: Scherzo of a Dark Dusk"
        ElseIf Movie = "天空之城" Then
            enMovie = "LAPUTA: Castle in the Sky"
        End If

        If SelectTime = "早上場 9:00" Then
            enTime = "AM 9:00"
        ElseIf SelectTime = "下午場 13:00" Then
            enTime = "PM 13:00"
        ElseIf SelectTime = "下午場 16:00" Then
            enTime = "PM 16:00"
        ElseIf SelectTime = "下午場 19:00" Then
            enTime = "PM 19:00"
        End If

        If Theater = "皇家廳" Then
            enTheater = "Royal hall"
        ElseIf Theater = "普通廳" Then
            enTheater = "Ordinary hall"
        End If

        Dim cmd As New System.Data.SqlClient.SqlCommand
        myConn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Emily\Study-4-1\視窗程式設計\期末專題\MovieTicketingSystem\BookingAndEvents.mdf;Integrated Security=True;Replication=True;Connect Timeout=30")
        'Create a Command object.
        'cmd = myConn.CreateCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "SELECT * FROM Orders;"
        cmd.CommandText = "INSERT INTO Orders (訂單編號, 日期, 電影名稱, 票數, 影廳, 場次, 電話) VALUES (11,'" & SelectDate & "','" & enMovie & "'," & Totalseat & ",'" & enTheater & "','" & enTime & "','" & Phone & "');"
        'cmd.CommandText += "INSERT INTO Orders (訂單編號, 票數) VALUES (8, 12);"
        cmd.Connection = myConn

        'Dim SQLString As String = "Select * from Orders;"
        'Dim sqlcommand As SqlCommand = New SqlCommand(SQLString)
        'Dim sqlconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookingAndEvents.mdf;Integrated Security=True;Connect Timeout=30")
        'Dim dataset As DataSet = New DataSet
        'sqlcommand.Connection = sqlconnection
        'sqlcommand.Parameters.Clear()

        'SqlCommand.Connection.Open()
        'SqlCommand.ExecuteNonQuery()
        'SqlCommand.Connection.Close()

        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        ' 建立資料庫連結物件 
        'Using connection As New SqlConnection(My.Settings.connString)
        ' 資料庫指令作為物件  
        '    Using sqlCommand As New SqlCommand("NEW.Booking", connection)
        '        sqlCommand.CommandType = CommandType.StoredProcedure

        '        sqlCommand.Parameters.Add(New SqlParameter("@電影名稱", SqlDbType.NVarChar, 50))
        '        sqlCommand.Parameters("@電影名稱").Value = Movie
        '    End Using
        'End Using

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