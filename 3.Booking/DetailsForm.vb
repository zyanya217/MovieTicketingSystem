﻿Imports System.Runtime.Remoting
Imports System.Data.SqlClient

Public Class DetailsForm
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Public Property SourceForm As BookingForm
    Public Property WebConfigurationManager As Object
    Public Totalseat As Int16
    Public Seatprice As Int16
    Public discount_ticket As Double
    Public regular As Double
    Public group_ticket As Double
    Public Phone As String
    Public Theater As String
    Public Movie As String
    Public SelectDate As Date
    Public SelectTime As String
    Public Mealsprice As Int16
    Public Mealslist As String

    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Text = Phone
        Label9.Text = Theater
        Label5.Text = Movie
        Label16.Text = SelectDate
        Label20.Text = Seatprice + Mealsprice
        Label14.Text = Mealslist.ToString

        '票種判斷
        Dim ticket As String
        Dim enMovie As String
        Dim enTime As String
        Dim enTheater As String

        enMovie = ""
        enTime = ""
        enTheater = ""

        If Movie = "阿凡達：水之道" Then
            enMovie = "Avatar: The Way of Water"
        ElseIf Movie = "黑豹2：瓦干達萬歲" Then
            enMovie = "Black Panther: Wakanda Forever"
        ElseIf Movie = "刀劍神域progressive 陰沉薄暮的詼諧曲" Then
            enMovie = "Sword Art Online Progressive: Scherzo of a Dark Dusk"
        ElseIf Movie = "天空之城" Then
            enMovie = "LAPUTA: Castle in the Sky"
        End If

        If SelectTime = "早上場 9:00" Then
            enTime = "AM 9:00"
        ElseIf SelectTime = "下午場 13:00" Then
            enTime = "PM 13:00"
        ElseIf SelectTime = "下午場 16:00" Then
            enTime = "PM 16:00"
        ElseIf SelectTime = "下午場 19:00" Then
            enTime = "PM 19:00"
        End If

        If Theater = "皇家廳" Then
            enTheater = "Royal hall"
        ElseIf Theater = "普通廳" Then
            enTheater = "Ordinary hall"
        End If

        Dim totalseat3 As Double
        totalseat3 = 1
        totalseat3 = discount_ticket + regular + group_ticket

        Dim cmd As New System.Data.SqlClient.SqlCommand
        myConn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Emily\Study-4-1\視窗程式設計\期末專題\MovieTicketingSystem\BookingAndEvents.mdf;Integrated Security=True;Replication=True;Connect Timeout=30")
        'Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Emily\Study-4-1\視窗程式設計\期末專題\MovieTicketingSystem\BookingAndEvents.mdf;Integrated Security=True;Replication=True;Connect Timeout=30
        'Create a Command object.
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "SELECT * FROM Orders;"
        cmd.CommandText = "INSERT INTO Orders (訂單編號, 日期, 電影名稱, 票數, 影廳, 場次, 電話) VALUES (10,'" & SelectDate & "','" & enMovie & "'," & totalseat3 & ",'" & enTheater & "','" & enTime & "','" & Phone & "');"
        'cmd.CommandText += "INSERT INTO Orders (訂單編號, 票數) VALUES (8, 12);"
        cmd.Connection = myConn

        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        ticket = ""
        If discount_ticket <> 0 Then
            ticket += "優惠票" + discount_ticket.ToString + "張" + vbCrLf
        End If
        If regular <> 0 Then
            ticket += "全票" + regular.ToString + "張" + vbCrLf
        End If
        If group_ticket <> 0 Then
            ticket += "團體票" + (group_ticket * 10).ToString + "張" + vbCrLf
        End If
        Label7.Text = ticket
        '活動顯示判斷
        If SelectDate.ToString = "2023/1/13 上午 12:00:00" Then
            Label18.Text = "Super Junier World Tour 巡迴演唱會!" + vbCrLf + "天團Super Junier來台開唱！" + vbCrLf + "下午4點到晚上8點，不見不散!"
        End If
        If SelectDate.ToString = "2023/1/15 上午 12:00:00" Then
            Label18.Text = "《SPV×FAMILY間諜加加酒》期間限定快閃店" + vbCrLf + "經典場景重現！不需門票，歡迎免費入場！" + vbCrLf + "上午11點到晚上6點，與你相見!"
        End If
        If SelectDate.ToString = "2023/1/17 上午 12:00:00" Then
            Label18.Text = "MEMEMOO World Tour 巡迴演唱會!" + vbCrLf + "美聲樂團MEMEMOO來台開唱！" + vbCrLf + "下午4點到晚上8點，不見不散!"
        End If
        If SelectDate.ToString = "2023/1/19 上午 12:00:00" Then
            Label18.Text = "Halolive Pesu 新春2023粉絲見面會! " + vbCrLf + "與Pesu 1對1的粉絲見面會" + vbCrLf + "上午11點到下午1點，兔粉還不趕快集合!"
        End If

        '活動顯示判斷
        'If SelectDate.ToString = "2023/1/13 上午 12:00:00" Then
        'Dim a As DialogResult
        'a = MessageBox.Show("當天大型活動" + vbCrLf + "Super Junier World Tour 巡迴演唱會!", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        'If SelectDate.ToString = "2023/1/15 上午 12:00:00" Then
        'Dim a As DialogResult
        'a = MessageBox.Show("當天大型活動" + vbCrLf + "《SPV×FAMILY間諜加加酒》期間限定快閃店", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        'If SelectDate.ToString = "2023/1/17 上午 12:00:00" Then
        'Dim a As DialogResult
        'a = MessageBox.Show("當天大型活動" + vbCrLf + "MEMEMOO World Tour 巡迴演唱會!", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        'If SelectDate.ToString = "2023/1/18 上午 12:00:00" Then
        'Dim a As DialogResult
        'a = MessageBox.Show("當天大型活動" + vbCrLf + "Halolive Pesu 新春2023粉絲見面會!", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        Me.Close()
    End Sub


End Class