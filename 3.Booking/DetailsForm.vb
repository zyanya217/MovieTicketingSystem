Imports System.Data.SqlClient
Imports System.Runtime.Remoting

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
    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Phone = Label3.Text
        Theater = Label9.Text
        Movie = Label5.Text

        '在顯示頁面時將資料回傳資料庫
        ' 1. 產生DataSet
        Dim Conn As New SqlConnection(WebConfigurationManager.ConnectionStrings("testConnectionString").ConnectionString.ToString)
        Dim ds As New DataSet

        Dim u_Adapter As New SqlDataAdapter
        u_Adapter.SelectCommand = New SqlCommand("Select * from Order", Conn)
        u_Adapter.Fill(ds, "Order")  '---- 這時候執行SQL指令。取出資料，放進 DataSet。

        ' 2.在Order資料表 手動新增一行 DataRow
        Dim new_row As DataRow = ds.Tables("Order").NewRow()
        new_row("訂單編號") = ""
        new_row("日期") = ""
        new_row("電影名稱") = Movie
        new_row("票種") = ""
        new_row("座位") = ""
        new_row("影廳") = Theater
        new_row("場次") = ""
        new_row("距離觀影日還有幾天") = ""

        ds.Tables("Order").Rows.Add(new_row)  '--將新增的一行 DataRow加入 DataSet裡面

    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub


End Class