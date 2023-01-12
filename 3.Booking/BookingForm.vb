Imports System.Reflection.Emit
Imports System.Windows

Public Class BookingForm

    '設票券變數
    Private discount_ticket As Double
    Private regular As Double
    Private group_ticket As Double
    Public SeatPrice As Double
    Public Totalseat As Int16
    Public Phone As String
    Public Theater As String
    Public Movie As String
    Public SelectDate As String
    Public SelectTime As String

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
                If ComboBox4.SelectedIndex = -1 AndAlso ComboBox2.SelectedIndex = -1 AndAlso ComboBox3.SelectedIndex = -1 Then
                    Dim a As DialogResult
                    a = MessageBox.Show("請選擇票種及數量。" + vbCrLf + “Please select tickets.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Totalseat > 20 Then
                        Dim a As DialogResult
                        a = MessageBox.Show("總票數不可超過20張。" + vbCrLf + “Total number of tickets cannot exceed 20.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        SelectDate = DateTimePicker1.Value.ToString
                        SelectTime = ComboBox5.Text.ToString
                        '活動顯示判斷
                        If SelectDate.ToString = "2023/1/13 上午 12:00:00" Then
                            Dim a As DialogResult
                            a = MessageBox.Show("當天大型活動" + vbCrLf + "Super Junier World Tour 巡迴演唱會!", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        If SelectDate.ToString = "2023/1/15 上午 12:00:00" Then
                            Dim a As DialogResult
                            a = MessageBox.Show("當天大型活動" + vbCrLf + "《SPV×FAMILY間諜加加酒》期間限定快閃店", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        If SelectDate.ToString = "2023/1/17 上午 12:00:00" Then
                            Dim a As DialogResult
                            a = MessageBox.Show("當天大型活動" + vbCrLf + "MEMEMOO World Tour 巡迴演唱會!", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        If SelectDate.ToString = "2023/1/18 上午 12:00:00" Then
                            Dim a As DialogResult
                            a = MessageBox.Show("當天大型活動" + vbCrLf + "Halolive Pesu 新春2023粉絲見面會!", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        Dim Input As DialogResult
                        Input = MessageBox.Show("請確認您輸入的資訊是否正確，進入下一頁就無法再度更改" + vbCrLf + “Please confirm if the information is correct." + vbCrLf + "Proceeding to the next page will prevent further changes.", "前往下一頁!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                        If Input = 6 Then
                            Dim Array(0, 8) As String
                            Phone = TextBox1.Text
                            If RadioNormal.Checked = True Then
                                Theater = "普通廳"
                            Else
                                Theater = "皇家廳"
                            End If
                            Movie = ComboBox1.Text


                            '跳轉畫面至下一頁
                            Dim mform As New MealsForm
                            mform.Show()
                            mform.Movie = Movie
                            mform.Phone = Phone
                            mform.Theater = Theater
                            mform.Phone = Phone
                            mform.SelectDate = SelectDate
                            mform.SelectTime = SelectTime
                            mform.discount_ticket = discount_ticket
                            mform.regular = regular
                            mform.group_ticket = group_ticket
                            mform.Totalseat = Totalseat
                            mform.Seatprice = SeatPrice
                            Me.Hide()
                        End If
                    End If
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
        SeatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket * 10
        If RadioRoyal.Checked = True Then
            SeatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeatPrice.ToString
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket * 10
        If RadioRoyal.Checked = True Then
            SeatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeatPrice.ToString
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket * 10
        If RadioRoyal.Checked = True Then
            SeatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeatPrice.ToString
    End Sub

    Private Sub RadioRoyal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRoyal.CheckedChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket * 10
        If RadioRoyal.Checked = True Then
            SeatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeatPrice.ToString
    End Sub

    Private Sub RadioNormal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNormal.CheckedChanged
        Double.TryParse(ComboBox2.Text, discount_ticket)
        Double.TryParse(ComboBox3.Text, regular)
        Double.TryParse(ComboBox4.Text, group_ticket)
        SeatPrice = discount_ticket * 100 + regular * 200 + group_ticket * 150
        Totalseat = discount_ticket + regular + group_ticket * 10
        If RadioRoyal.Checked = True Then
            SeatPrice += 25 * Totalseat
        End If
        LblTotal.Text = SeatPrice.ToString
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class