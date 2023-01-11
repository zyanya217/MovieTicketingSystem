Imports System.Windows

Public Class SeatForm

    Public Totalseat As Int16
    Public Mealsprice As Int16
    Public Seatprice As Int16
    Public discount_ticket As Double
    Public regular As Double
    Public group_ticket As Double
    Public Phone As String
    Public Theater As String
    Public Movie As String
    Public SelectDate As String
    Public SelectTime As String
    Public Mealslist As String
    Private Sub SeatForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Text = "可選擇座位數:" + Totalseat.ToString
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim dForm As New DetailsForm
        dForm.Phone = Phone
        dForm.Theater = Theater
        dForm.Phone = Phone
        dForm.SelectDate = SelectDate
        dForm.SelectTime = SelectTime
        dForm.discount_ticket = discount_ticket
        dForm.regular = regular
        dForm.group_ticket = group_ticket
        dForm.Seatprice = Seatprice
        dForm.Mealsprice = Mealsprice
        dForm.Mealslist = Mealslist
        dForm.Show()
    End Sub





    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Btn2.BackColor = Color.Lime Then
            Btn2.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn2.BackColor = Color.Lime
            End If
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If Btn3.BackColor = Color.Lime Then
            Btn3.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn3.BackColor = Color.Lime
            End If
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If Btn4.BackColor = Color.Lime Then
            Btn4.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn4.BackColor = Color.Lime
            End If
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If Btn5.BackColor = Color.Lime Then
            Btn5.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn5.BackColor = Color.Lime
            End If
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If Btn6.BackColor = Color.Lime Then
            Btn6.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn6.BackColor = Color.Lime
            End If
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If Btn7.BackColor = Color.Lime Then
            Btn7.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn7.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If Btn8.BackColor = Color.Lime Then
            Btn8.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn8.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If Btn9.BackColor = Color.Lime Then
            Btn9.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn9.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn10_Click(sender As Object, e As EventArgs) Handles Btn10.Click
        If Btn10.BackColor = Color.Lime Then
            Btn10.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn10.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn11_Click(sender As Object, e As EventArgs) Handles Btn11.Click
        If Btn11.BackColor = Color.Lime Then
            Btn11.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn11.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn12_Click(sender As Object, e As EventArgs) Handles Btn12.Click
        If Btn12.BackColor = Color.Lime Then
            Btn12.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn12.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn15_Click(sender As Object, e As EventArgs) Handles Btn15.Click
        If Btn15.BackColor = Color.Lime Then
            Btn15.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn15.BackColor = Color.Lime
            End If
        End If
    End Sub

    Private Sub Btn16_Click(sender As Object, e As EventArgs) Handles Btn16.Click
        If Btn16.BackColor = Color.Lime Then
            Btn16.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn16.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn17_Click(sender As Object, e As EventArgs) Handles Btn17.Click
        If Btn17.BackColor = Color.Lime Then
            Btn17.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn17.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn18_Click(sender As Object, e As EventArgs) Handles Btn18.Click
        If Btn18.BackColor = Color.Lime Then
            Btn18.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn18.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn19_Click(sender As Object, e As EventArgs) Handles Btn19.Click
        If Btn19.BackColor = Color.Lime Then
            Btn19.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn19.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn20_Click(sender As Object, e As EventArgs) Handles Btn20.Click
        If Btn20.BackColor = Color.Lime Then
            Btn20.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn20.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn23_Click(sender As Object, e As EventArgs) Handles Btn23.Click
        If Btn23.BackColor = Color.Lime Then
            Btn23.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn23.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn24_Click(sender As Object, e As EventArgs) Handles Btn24.Click
        If Btn24.BackColor = Color.Lime Then
            Btn24.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn24.BackColor = Color.Lime
            End If

        End If
    End Sub

    Private Sub Btn25_Click(sender As Object, e As EventArgs) Handles Btn25.Click
        If Btn25.BackColor = Color.Lime Then
            Btn25.BackColor = Color.Gainsboro
            Totalseat = Totalseat + 1
            Label3.Text = "可選擇座位數:" + Totalseat.ToString
        Else
            If Totalseat = 0 Then
                Dim Input As DialogResult
                Input = MessageBox.Show("已經不能再選擇座位了。" + vbCrLf + “Cannot choose seats.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Totalseat = Totalseat - 1
                Label3.Text = "可選擇座位數:" + Totalseat.ToString
                Btn25.BackColor = Color.Lime
            End If

        End If
    End Sub
End Class