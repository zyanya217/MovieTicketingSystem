Partial Class BookingAndEventsDataSet
    Partial Public Class OrderDataTable
        Private Sub OrderDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.距離觀影日還有幾天Column.ColumnName) Then

            End If

        End Sub



    End Class
End Class
