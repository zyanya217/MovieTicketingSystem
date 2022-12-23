Imports System.Windows

Public Class MainForm
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim mForm As New MenuForm
        Me.Hide()
        mForm.Show()
        ''
    End Sub
End Class
