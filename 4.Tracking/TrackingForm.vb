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

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.OrderTableAdapter.FillBy(Me.BookingAndEventsDataSet1.Order)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.OrderTableAdapter.FillBy1(Me.BookingAndEventsDataSet1.Order, 電話ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub 電話ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles 電話ToolStripTextBox1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub OrderBindingSource2_CurrentChanged(sender As Object, e As EventArgs) Handles OrderBindingSource2.CurrentChanged

    End Sub

    Private Sub TrackingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet.Orders' 資料表。您可以視需要進行移動或移除。
        Me.OrdersTableAdapter.Fill(Me.BookingAndEventsDataSet.Orders)

    End Sub
End Class