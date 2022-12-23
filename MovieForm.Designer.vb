<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovieForm))
        Me.PbxMovie1 = New System.Windows.Forms.PictureBox()
        Me.PbxMovie2 = New System.Windows.Forms.PictureBox()
        Me.PbxMovie3 = New System.Windows.Forms.PictureBox()
        Me.PbxMovie4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnMenu = New System.Windows.Forms.Button()
        CType(Me.PbxMovie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxMovie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxMovie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxMovie4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbxMovie1
        '
        Me.PbxMovie1.Image = CType(resources.GetObject("PbxMovie1.Image"), System.Drawing.Image)
        Me.PbxMovie1.Location = New System.Drawing.Point(8, 161)
        Me.PbxMovie1.Name = "PbxMovie1"
        Me.PbxMovie1.Size = New System.Drawing.Size(208, 316)
        Me.PbxMovie1.TabIndex = 0
        Me.PbxMovie1.TabStop = False
        '
        'PbxMovie2
        '
        Me.PbxMovie2.Image = CType(resources.GetObject("PbxMovie2.Image"), System.Drawing.Image)
        Me.PbxMovie2.Location = New System.Drawing.Point(218, 161)
        Me.PbxMovie2.Name = "PbxMovie2"
        Me.PbxMovie2.Size = New System.Drawing.Size(207, 316)
        Me.PbxMovie2.TabIndex = 1
        Me.PbxMovie2.TabStop = False
        '
        'PbxMovie3
        '
        Me.PbxMovie3.Image = CType(resources.GetObject("PbxMovie3.Image"), System.Drawing.Image)
        Me.PbxMovie3.Location = New System.Drawing.Point(428, 161)
        Me.PbxMovie3.Name = "PbxMovie3"
        Me.PbxMovie3.Size = New System.Drawing.Size(213, 316)
        Me.PbxMovie3.TabIndex = 2
        Me.PbxMovie3.TabStop = False
        '
        'PbxMovie4
        '
        Me.PbxMovie4.Image = CType(resources.GetObject("PbxMovie4.Image"), System.Drawing.Image)
        Me.PbxMovie4.Location = New System.Drawing.Point(637, 161)
        Me.PbxMovie4.Name = "PbxMovie4"
        Me.PbxMovie4.Size = New System.Drawing.Size(211, 316)
        Me.PbxMovie4.TabIndex = 3
        Me.PbxMovie4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 55)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "所有電影"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(204, 14)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(224, 141)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 477)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "阿凡達：水之道"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(221, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "黑豹 2：瓦干達萬歲"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(431, 477)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 48)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "刀劍神域Progressive" & Global.Microsoft.VisualBasic.ChrW(10) & "陰沉薄暮的詼諧曲"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(641, 477)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "天空之城"
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnMenu.FlatAppearance.BorderSize = 0
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Font = New System.Drawing.Font("Microsoft JhengHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnMenu.ForeColor = System.Drawing.Color.White
        Me.BtnMenu.Location = New System.Drawing.Point(668, 49)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(145, 42)
        Me.BtnMenu.TabIndex = 10
        Me.BtnMenu.Text = "回主選單"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'MovieForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 561)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PbxMovie4)
        Me.Controls.Add(Me.PbxMovie3)
        Me.Controls.Add(Me.PbxMovie2)
        Me.Controls.Add(Me.PbxMovie1)
        Me.Name = "MovieForm"
        Me.Text = "MovieForm"
        CType(Me.PbxMovie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxMovie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxMovie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxMovie4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbxMovie1 As PictureBox
    Friend WithEvents PbxMovie2 As PictureBox
    Friend WithEvents PbxMovie3 As PictureBox
    Friend WithEvents PbxMovie4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnMenu As Button
End Class
