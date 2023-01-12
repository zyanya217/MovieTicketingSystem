<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrackingForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrackingForm))
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.OrderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingAndEventsDataSet = New Main.BookingAndEventsDataSet()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New Main.BookingAndEventsDataSetTableAdapters.OrderTableAdapter()
        Me.BookingAndEventsDataSet1 = New Main.BookingAndEventsDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.電影名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.票數 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.影廳DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.場次DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.電話 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillBy1ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.電話ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.電話ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.OrderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingAndEventsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingAndEventsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnMenu.Location = New System.Drawing.Point(21, 518)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(124, 48)
        Me.BtnMenu.TabIndex = 22
        Me.BtnMenu.Text = "回主選單"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'BtnEnd
        '
        Me.BtnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnEnd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnd.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnEnd.ForeColor = System.Drawing.Color.Black
        Me.BtnEnd.Location = New System.Drawing.Point(719, 518)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(113, 48)
        Me.BtnEnd.TabIndex = 27
        Me.BtnEnd.Text = "結束"
        Me.BtnEnd.UseVisualStyleBackColor = False
        '
        'OrderBindingSource1
        '
        Me.OrderBindingSource1.DataMember = "Order"
        Me.OrderBindingSource1.DataSource = Me.BookingAndEventsDataSet
        '
        'BookingAndEventsDataSet
        '
        Me.BookingAndEventsDataSet.DataSetName = "BookingAndEventsDataSet"
        Me.BookingAndEventsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.BookingAndEventsDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'BookingAndEventsDataSet1
        '
        Me.BookingAndEventsDataSet1.DataSetName = "BookingAndEventsDataSet"
        Me.BookingAndEventsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.電影名稱DataGridViewTextBoxColumn, Me.日期DataGridViewTextBoxColumn, Me.票數, Me.影廳DataGridViewTextBoxColumn, Me.場次DataGridViewTextBoxColumn, Me.距離觀影日還有幾天DataGridViewTextBoxColumn, Me.電話})
        Me.DataGridView1.DataSource = Me.OrderBindingSource3
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle7.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(122, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle8.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Goldenrod
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(619, 255)
        Me.DataGridView1.TabIndex = 28
        '
        '電影名稱DataGridViewTextBoxColumn
        '
        Me.電影名稱DataGridViewTextBoxColumn.DataPropertyName = "電影名稱"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.電影名稱DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.電影名稱DataGridViewTextBoxColumn.HeaderText = "電影名稱"
        Me.電影名稱DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.電影名稱DataGridViewTextBoxColumn.Name = "電影名稱DataGridViewTextBoxColumn"
        Me.電影名稱DataGridViewTextBoxColumn.ReadOnly = True
        Me.電影名稱DataGridViewTextBoxColumn.Width = 99
        '
        '日期DataGridViewTextBoxColumn
        '
        Me.日期DataGridViewTextBoxColumn.DataPropertyName = "日期"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.日期DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.日期DataGridViewTextBoxColumn.HeaderText = "日期"
        Me.日期DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn"
        Me.日期DataGridViewTextBoxColumn.ReadOnly = True
        Me.日期DataGridViewTextBoxColumn.Width = 99
        '
        '票數
        '
        Me.票數.DataPropertyName = "票數"
        Me.票數.HeaderText = "票數"
        Me.票數.Name = "票數"
        Me.票數.ReadOnly = True
        '
        '影廳DataGridViewTextBoxColumn
        '
        Me.影廳DataGridViewTextBoxColumn.DataPropertyName = "影廳"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.影廳DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.影廳DataGridViewTextBoxColumn.HeaderText = "影廳"
        Me.影廳DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.影廳DataGridViewTextBoxColumn.Name = "影廳DataGridViewTextBoxColumn"
        Me.影廳DataGridViewTextBoxColumn.ReadOnly = True
        Me.影廳DataGridViewTextBoxColumn.Width = 99
        '
        '場次DataGridViewTextBoxColumn
        '
        Me.場次DataGridViewTextBoxColumn.DataPropertyName = "場次"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.場次DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.場次DataGridViewTextBoxColumn.HeaderText = "場次"
        Me.場次DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.場次DataGridViewTextBoxColumn.Name = "場次DataGridViewTextBoxColumn"
        Me.場次DataGridViewTextBoxColumn.ReadOnly = True
        Me.場次DataGridViewTextBoxColumn.Width = 99
        '
        '距離觀影日還有幾天DataGridViewTextBoxColumn
        '
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.DataPropertyName = "距離觀影日還有幾天"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle6.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.HeaderText = "距離觀影日還有幾天"
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.Name = "距離觀影日還有幾天DataGridViewTextBoxColumn"
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.ReadOnly = True
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.Width = 125
        '
        '電話
        '
        Me.電話.DataPropertyName = "電話"
        Me.電話.HeaderText = "電話"
        Me.電話.Name = "電話"
        Me.電話.ReadOnly = True
        Me.電話.Visible = False
        '
        'OrderBindingSource3
        '
        Me.OrderBindingSource3.DataMember = "Order"
        Me.OrderBindingSource3.DataSource = Me.BookingAndEventsDataSet1
        '
        'OrderBindingSource2
        '
        Me.OrderBindingSource2.DataMember = "Order"
        Me.OrderBindingSource2.DataSource = Me.BookingAndEventsDataSet1
        '
        'FillBy1ToolStrip1
        '
        Me.FillBy1ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillBy1ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.電話ToolStripLabel1, Me.電話ToolStripTextBox1, Me.FillBy1ToolStripButton1})
        Me.FillBy1ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip1.Name = "FillBy1ToolStrip1"
        Me.FillBy1ToolStrip1.Size = New System.Drawing.Size(854, 30)
        Me.FillBy1ToolStrip1.TabIndex = 31
        Me.FillBy1ToolStrip1.Text = "FillBy1ToolStrip1"
        '
        '電話ToolStripLabel1
        '
        Me.電話ToolStripLabel1.Name = "電話ToolStripLabel1"
        Me.電話ToolStripLabel1.Size = New System.Drawing.Size(50, 27)
        Me.電話ToolStripLabel1.Text = "電話:"
        '
        '電話ToolStripTextBox1
        '
        Me.電話ToolStripTextBox1.Name = "電話ToolStripTextBox1"
        Me.電話ToolStripTextBox1.Size = New System.Drawing.Size(200, 30)
        '
        'FillBy1ToolStripButton1
        '
        Me.FillBy1ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton1.Name = "FillBy1ToolStripButton1"
        Me.FillBy1ToolStripButton1.Size = New System.Drawing.Size(50, 27)
        Me.FillBy1ToolStripButton1.Text = "查詢"
        '
        'TrackingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 591)
        Me.Controls.Add(Me.FillBy1ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.BtnMenu)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "TrackingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrackingForm"
        CType(Me.OrderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingAndEventsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingAndEventsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip1.ResumeLayout(False)
        Me.FillBy1ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnEnd As Button
    Friend WithEvents BookingAndEventsDataSet As BookingAndEventsDataSet
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As BookingAndEventsDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents 票種DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 座位DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderBindingSource1 As BindingSource
    Friend WithEvents BookingAndEventsDataSet1 As BookingAndEventsDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OrderBindingSource2 As BindingSource
    Friend WithEvents OrderBindingSource3 As BindingSource
    Friend WithEvents 電影名稱DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 票數 As DataGridViewTextBoxColumn
    Friend WithEvents 影廳DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 場次DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 距離觀影日還有幾天DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 電話 As DataGridViewTextBoxColumn
    Friend WithEvents FillBy1ToolStrip1 As ToolStrip
    Friend WithEvents 電話ToolStripLabel1 As ToolStripLabel
    Friend WithEvents 電話ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton1 As ToolStripButton
End Class