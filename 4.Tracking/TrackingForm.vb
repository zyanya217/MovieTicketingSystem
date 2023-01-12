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
        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet1.Order' 資料表。您可以視需要進行移動或移除。
        Me.OrderTableAdapter.Fill(Me.BookingAndEventsDataSet1.Order)
        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet1.Order' 資料表。您可以視需要進行移動或移除。
        Me.OrderTableAdapter.Fill(Me.BookingAndEventsDataSet1.Order)
        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet1.Order' 資料表。您可以視需要進行移動或移除。
        Me.OrderTableAdapter.Fill(Me.BookingAndEventsDataSet1.Order)

    End Sub


    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.OrderTableAdapter.FillBy(Me.BookingAndEventsDataSet.Order)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class