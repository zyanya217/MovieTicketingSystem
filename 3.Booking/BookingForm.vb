Public Class BookingForm

    '設票券變數
    Private discount_ticket As Double
    Private regular As Double
    Private group_ticket As Double
    Public SeaatPrice As Double
    Public Totalseat As Int16

    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet.Movie' 資料表。您可以視需要進行移動或移除。
        Me.MovieTableAdapter.Fill(Me.BookingAndEventsDataSet.Movie)
        'TODO: 這行程式碼會將資料載入 'BookingAndEventsDataSet.Movie' 資料表。您可以視需要進行移動或移除。
        Me.MovieTableAdapter.Fill(Me.BookingAndEventsDataSet.Movie)
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
        Label12.BackColor = Color.Transparent
        LblTotal.BackColor = Color.Transparent
        DateTimePicker1.MaxDate = DateTimePicker1.Value.AddDays(7).Date.ToString("MM/dd/yyyy")
        DateTimePicker1.MinDate = Today
        '用於傳值給webform 
        Dim frm As New DetailsForm
        frm.SourceForm = Me
        'frm.ShowDialog() '未測試該功能

    End Sub
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim mForm As New MenuForm
        Me.Close()
        mForm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        '判斷欄位是否有空值，若無空值，則帶入值
        If (TextBox1.Text IsNot Nothing) And (Len(TextBox1.Text) = 10) Then

            If RadioNormal.Checked = True Or RadioRoyal.Checked = True Then
                Dim Input As DialogResult
                Input = MessageBox.Show("請確認的資訊是否正確" + vbCrLf + “Please confirm if the information is correct.", "前往下一頁!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If Input = 6 Then
                    Dim sForm As New SeatForm
                    sForm.Show()
                    sForm.Visible = False
                    sForm.Totalseat = Totalseat.ToString

                    '跳轉畫面至下一頁
                    Dim mForm As New MealsForm
                    mForm.Show()
                    Me.Hide()
                End If

            Else
                    Dim Input As DialogResult
                Input = MessageBox.Show("請選擇影廳。" + vbCrLf + “Please select a movie theater.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            '判斷是否有輸入是否合理
            Dim Input As DialogResult
            Input = MessageBox.Show("有欄位還沒被填寫或電話輸入不合理。" + vbCrLf + “A field has not been filled or the phone input is invalid.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeaatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket
        If RadioRoyal.Checked = True Then
            SeaatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeaatPrice.ToString
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeaatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket
        If RadioRoyal.Checked = True Then
            SeaatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeaatPrice.ToString
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeaatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket
        If RadioRoyal.Checked = True Then
            SeaatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeaatPrice.ToString
    End Sub

    Private Sub RadioRoyal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRoyal.CheckedChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeaatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket
        If RadioRoyal.Checked = True Then
            SeaatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeaatPrice.ToString
    End Sub

    Private Sub RadioNormal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNormal.CheckedChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeaatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket
        If RadioRoyal.Checked = True Then
            SeaatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeaatPrice.ToString
    End Sub
End Class