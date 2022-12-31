Public Class Movie4Form
    Private Sub Movie4Form_Load(ByVal sender As System.Object, ByVal e _
As System.EventArgs) Handles MyBase.Load
        Label2.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        linklblTrailer.Text = "點我前往"
        linklblTrailer.Links.Add(0, 4, "https://www.youtube.com/watch?v=5LvSAK_LLcM")
    End Sub

    Private Sub linklblTrailer_LinkClicked(ByVal sender As System.Object, ByVal _
e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _
 linklblTrailer.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim mForm As New MenuForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim mForm As New MovieForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnBooking_Click(sender As Object, e As EventArgs) Handles BtnBooking.Click
        Dim bForm As New BookingForm
        Me.Hide()
        bForm.Show()
    End Sub
End Class