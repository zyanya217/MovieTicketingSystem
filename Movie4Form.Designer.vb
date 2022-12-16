<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Movie4Form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movie4Form))
        Me.BtnBooking = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.linklblTrailer = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBooking
        '
        Me.BtnBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BtnBooking.FlatAppearance.BorderSize = 0
        Me.BtnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBooking.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnBooking.ForeColor = System.Drawing.Color.White
        Me.BtnBooking.Location = New System.Drawing.Point(662, 466)
        Me.BtnBooking.Name = "BtnBooking"
        Me.BtnBooking.Size = New System.Drawing.Size(141, 46)
        Me.BtnBooking.TabIndex = 55
        Me.BtnBooking.Text = "快速購票"
        Me.BtnBooking.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(495, 466)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(141, 46)
        Me.BtnBack.TabIndex = 54
        Me.BtnBack.Text = "上一頁"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BtnMenu.FlatAppearance.BorderSize = 0
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnMenu.ForeColor = System.Drawing.Color.White
        Me.BtnMenu.Location = New System.Drawing.Point(319, 466)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(141, 46)
        Me.BtnMenu.TabIndex = 53
        Me.BtnMenu.Text = "回主選單"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(314, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 30)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "預告片(連結) :"
        '
        'linklblTrailer
        '
        Me.linklblTrailer.AutoSize = True
        Me.linklblTrailer.LinkColor = System.Drawing.Color.Cyan
        Me.linklblTrailer.Location = New System.Drawing.Point(491, 393)
        Me.linklblTrailer.Name = "linklblTrailer"
        Me.linklblTrailer.Size = New System.Drawing.Size(106, 24)
        Me.linklblTrailer.TabIndex = 51
        Me.linklblTrailer.TabStop = True
        Me.linklblTrailer.Text = "LinkLabel1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(376, 258)
        Me.Label7.MaximumSize = New System.Drawing.Size(450, 24)
        Me.Label7.MinimumSize = New System.Drawing.Size(450, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(450, 130)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "取材自世界名著《格列佛遊記》中的空島「拉普達」。拉普達一族對於風相當了解，他們善用風來發展工業，後來他們更成功地讓許多城市飛到了天空之中，成為了一個偉大的文明帝國" &
    "，然而，卻因為人性的貪婪引發戰爭....。"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(314, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 30)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "影評:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(435, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 30)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "8.0/10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(314, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 30)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "綜合評分:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(314, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 30)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "簡介:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(376, 77)
        Me.Label2.MaximumSize = New System.Drawing.Size(450, 24)
        Me.Label2.MinimumSize = New System.Drawing.Size(450, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(450, 120)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "這世界上總有一個人，讓你勇敢與世界為敵。" & Global.Microsoft.VisualBasic.ChrW(10) & "古老帝國拉普達是一座漂浮在空中的機器島，傳說中那裡已無人居住，但蘊藏巨大的財富，各方勢力都在尋找這座傳說中的飛行島。某日" &
    "在礦場工作的少年巴魯，偶然遇見一位神秘的女孩希達…"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 466)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 34)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "天空之城"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(526, 200)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 436)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Movie4Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(844, 561)
        Me.Controls.Add(Me.BtnBooking)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.linklblTrailer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Movie4Form"
        Me.Text = "Movie4Form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBooking As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents linklblTrailer As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
