<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.btnInquire = New System.Windows.Forms.Button()
        Me.btnIntroduction = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInquire
        '
        Me.btnInquire.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnInquire.FlatAppearance.BorderSize = 0
        Me.btnInquire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInquire.Font = New System.Drawing.Font("Microsoft JhengHei", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnInquire.ForeColor = System.Drawing.Color.White
        Me.btnInquire.Image = CType(resources.GetObject("btnInquire.Image"), System.Drawing.Image)
        Me.btnInquire.Location = New System.Drawing.Point(25, 359)
        Me.btnInquire.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInquire.Name = "btnInquire"
        Me.btnInquire.Size = New System.Drawing.Size(794, 142)
        Me.btnInquire.TabIndex = 2
        Me.btnInquire.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnInquire.UseVisualStyleBackColor = False
        '
        'btnIntroduction
        '
        Me.btnIntroduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnIntroduction.FlatAppearance.BorderSize = 0
        Me.btnIntroduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIntroduction.Font = New System.Drawing.Font("Microsoft JhengHei", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btnIntroduction.ForeColor = System.Drawing.Color.White
        Me.btnIntroduction.Image = CType(resources.GetObject("btnIntroduction.Image"), System.Drawing.Image)
        Me.btnIntroduction.Location = New System.Drawing.Point(25, 10)
        Me.btnIntroduction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIntroduction.Name = "btnIntroduction"
        Me.btnIntroduction.Size = New System.Drawing.Size(794, 189)
        Me.btnIntroduction.TabIndex = 3
        Me.btnIntroduction.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnIntroduction.UseVisualStyleBackColor = False
        '
        'btnBooking
        '
        Me.btnBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBooking.FlatAppearance.BorderSize = 0
        Me.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooking.Font = New System.Drawing.Font("Microsoft JhengHei", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btnBooking.ForeColor = System.Drawing.Color.White
        Me.btnBooking.Image = CType(resources.GetObject("btnBooking.Image"), System.Drawing.Image)
        Me.btnBooking.Location = New System.Drawing.Point(25, 191)
        Me.btnBooking.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(794, 164)
        Me.btnBooking.TabIndex = 1
        Me.btnBooking.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBooking.UseVisualStyleBackColor = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 561)
        Me.Controls.Add(Me.btnIntroduction)
        Me.Controls.Add(Me.btnInquire)
        Me.Controls.Add(Me.btnBooking)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnInquire As Button
    Friend WithEvents btnIntroduction As Button
End Class
