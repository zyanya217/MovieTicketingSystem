Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Public Class TrackingForm

    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String



    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        Me.Close()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim mForm As New MenuForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub TrackingForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click


        Try
            Dim SQLString As String = "Select * from Order..電話 Where 1=1 and 電話=@電話 "
            Dim sqlcommand As SqlCommand = New SqlCommand(SQLString)
            Dim sqlconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookingAndEvents.mdf;Integrated Security=True;Connect Timeout=30")
            Dim dataset As DataSet = New DataSet
            sqlcommand.Connection = sqlconnection
            sqlcommand.Parameters.Clear()
            Dim TextBox1TextTrim As String = TextBox1.Text.Trim
            sqlcommand.Parameters.Add("@電話", SqlDbType.NChar).Value = TextBox1TextTrim
            sqlcommand.Connection.Open()
            Dim sqldataadapter As SqlDataAdapter = New SqlDataAdapter(sqlcommand)
            sqldataadapter.Fill(dataset)
            DataGridView1.DataSource = dataset.Tables(0)
            ' DataGridView1.DataBindings()
        Catch msg As Exception
            Console.WriteLine(msg)
        End Try


    End Sub


End Class