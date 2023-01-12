Imports System.Data.SqlClient

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

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click



        '--註解：第一，連結SQL資料庫
        myConn = New SqlConnection("Initial Catalog=Northwind;" & _
                                   "Data Source=localhost;Integrated Security=SSPI;")


        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT 電話 FROM Order WHERE 電話 = '" + TextBox1.Text + "'"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet.Order' 資料表。您可以視需要進行移動或移除。
        Me.OrderTableAdapter.Fill(Me.BookingAndEventsDataSet.Order)
        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet.Table' 資料表。您可以視需要進行移動或移除。
        'Me.TableTableAdapter.Fill(Me.BookingAndEventsDataSet.Table)

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

    End Sub





End Class