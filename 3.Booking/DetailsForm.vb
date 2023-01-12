Imports System.Runtime.Remoting
Imports System.Data.SqlClient

Public Class DetailsForm
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
    Public SelectDate As String
    Public SelectTime As String
    Public Mealsprice As Int16
    Public Mealslist As String

    Dim SelectCmd As String = "select * from 學生資料表"


    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Phone
        Label9.Text = Theater
        Label5.Text = Movie
        Label16.Text = SelectDate
        Label20.Text = Seatprice + Mealsprice
        Label14.Text = Mealslist.ToString
        '票種判斷
        Dim ticket As String
        ticket = ""
        If discount_ticket <> 0 Then
            ticket += "優惠票" + discount_ticket.ToString + "張" + vbCrLf
        End If
        If regular <> 0 Then
            ticket += "全票" + regular.ToString + "張" + vbCrLf
        End If
        If group_ticket <> 0 Then
            ticket += "團體票" + (group_ticket * 10).ToString + "張"
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
        If SelectDate.ToString = "2023/1/18 上午 12:00:00" Then
            Label18.Text = "Halolive Pesu 新春2023粉絲見面會! " + vbCrLf + "與Pesu 1對1的粉絲見面會" + vbCrLf + "上午11點到下午1點，兔粉還不趕快集合!"
        End If

        ' 建立資料庫連結物件 
        Using connection As New SqlConnection(My.Settings.connString)
            ' 資料庫指令作為物件  
            Using sqlCommand As New SqlCommand("NEW.Booking", connection)
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add(New SqlParameter("@電影名稱", SqlDbType.NVarChar, 50))
                sqlCommand.Parameters("@電影名稱").Value = Movie
            End Using

        End Using

    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        Me.Close()
    End Sub
End Class