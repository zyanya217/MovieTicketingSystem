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


    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.OrderTableAdapter.FillBy(Me.BookingAndEventsDataSet.Order)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub OrderBindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles OrderBindingSource1.CurrentChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.OrderTableAdapter.FillBy(Me.BookingAndEventsDataSet1.Order, 電話ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub 電話ToolStripTextBox_Click(sender As Object, e As EventArgs) Handles 電話ToolStripTextBox.Click

    End Sub
End Class