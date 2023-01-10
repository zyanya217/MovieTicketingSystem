Imports System.ComponentModel

Public Class MovieForm
    Private Sub PbxMovie1_Click(sender As Object, e As EventArgs) Handles PbxMovie1.Click
        Dim mForm As New Movie1Form
        Me.Close()
        mForm.Show()
    End Sub

    Private Sub PbxMovie2_Click(sender As Object, e As EventArgs) Handles PbxMovie2.Click
        Dim mForm As New Movie2Form
        Me.Close()
        mForm.Show()
    End Sub

    Private Sub PbxMovie3_Click(sender As Object, e As EventArgs) Handles PbxMovie3.Click
        Dim mForm As New Movie3Form
        Me.Close()
        mForm.Show()
    End Sub

    Private Sub PbxMovie4_Click(sender As Object, e As EventArgs) Handles PbxMovie4.Click
        Dim mForm As New Movie4Form
        Me.Close()
        mForm.Show()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim mForm As New MenuForm
        Me.Close()
        mForm.Show()
    End Sub


End Class