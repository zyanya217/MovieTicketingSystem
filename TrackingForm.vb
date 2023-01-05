Public Class TrackingForm
    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        Me.Close()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim mForm As New MenuForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    End Sub

    Private Sub TrackingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet.Table' 資料表。您可以視需要進行移動或移除。
        'Me.TableTableAdapter.Fill(Me.BookingAndEventsDataSet.Table)

    End Sub
End Class