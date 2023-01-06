<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealsForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MealsForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(79, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(343, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(592, 123)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(142, 141)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnNext.Location = New System.Drawing.Point(737, 482)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(134, 46)
        Me.BtnNext.TabIndex = 23
        Me.BtnNext.Text = "下一頁"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnBack.Location = New System.Drawing.Point(41, 482)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(134, 46)
        Me.BtnBack.TabIndex = 24
        Me.BtnBack.Text = "上一頁"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 36)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "爆米花"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 36)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "大亨堡"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(635, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 36)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "可樂"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 30)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "大(60$)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 30)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "中(50$)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 30)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "小(40$)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 30)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "50$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(539, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 30)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "小(10$)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(539, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 30)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "中(20$)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(539, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 30)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "大(30$)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 55)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "選擇餐點"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox1.Location = New System.Drawing.Point(125, 326)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox1.TabIndex = 43
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox2.Location = New System.Drawing.Point(125, 371)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox2.TabIndex = 44
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox3.Location = New System.Drawing.Point(125, 421)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox3.TabIndex = 45
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox4.Location = New System.Drawing.Point(373, 326)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox4.TabIndex = 46
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox5.Location = New System.Drawing.Point(629, 326)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox5.TabIndex = 47
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox6.Location = New System.Drawing.Point(629, 375)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox6.TabIndex = 48
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox7.Location = New System.Drawing.Point(629, 421)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox7.TabIndex = 49
        '
        'MealsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(914, 540)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "MealsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MealsForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
End Class
