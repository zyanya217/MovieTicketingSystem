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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrackingForm))
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.電影名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.票數DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.影廳DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.場次DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingAndEventsDataSet = New Main.BookingAndEventsDataSet()
        Me.OrderBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New Main.BookingAndEventsDataSetTableAdapters.OrderTableAdapter()
        Me.BookingAndEventsDataSet1 = New Main.BookingAndEventsDataSet()
        Me.OrderBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New Main.BookingAndEventsDataSetTableAdapters.OrdersTableAdapter()
        Me.FillBy4ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.電話ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.電話ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy4ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingAndEventsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingAndEventsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy4ToolStrip.SuspendLayout()
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.電影名稱DataGridViewTextBoxColumn, Me.日期DataGridViewTextBoxColumn, Me.票數DataGridViewTextBoxColumn, Me.影廳DataGridViewTextBoxColumn, Me.場次DataGridViewTextBoxColumn, Me.距離觀影日還有幾天DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrdersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(54, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 20
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(778, 382)
        Me.DataGridView1.TabIndex = 30
        '
        '電影名稱DataGridViewTextBoxColumn
        '
        Me.電影名稱DataGridViewTextBoxColumn.DataPropertyName = "電影名稱"
        Me.電影名稱DataGridViewTextBoxColumn.HeaderText = "電影名稱"
        Me.電影名稱DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.電影名稱DataGridViewTextBoxColumn.Name = "電影名稱DataGridViewTextBoxColumn"
        Me.電影名稱DataGridViewTextBoxColumn.ReadOnly = True
        Me.電影名稱DataGridViewTextBoxColumn.Width = 125
        '
        '日期DataGridViewTextBoxColumn
        '
        Me.日期DataGridViewTextBoxColumn.DataPropertyName = "日期"
        Me.日期DataGridViewTextBoxColumn.HeaderText = "日期"
        Me.日期DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn"
        Me.日期DataGridViewTextBoxColumn.ReadOnly = True
        Me.日期DataGridViewTextBoxColumn.Width = 125
        '
        '票數DataGridViewTextBoxColumn
        '
        Me.票數DataGridViewTextBoxColumn.DataPropertyName = "票數"
        Me.票數DataGridViewTextBoxColumn.HeaderText = "票數"
        Me.票數DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.票數DataGridViewTextBoxColumn.Name = "票數DataGridViewTextBoxColumn"
        Me.票數DataGridViewTextBoxColumn.ReadOnly = True
        Me.票數DataGridViewTextBoxColumn.Width = 125
        '
        '影廳DataGridViewTextBoxColumn
        '
        Me.影廳DataGridViewTextBoxColumn.DataPropertyName = "影廳"
        Me.影廳DataGridViewTextBoxColumn.HeaderText = "影廳"
        Me.影廳DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.影廳DataGridViewTextBoxColumn.Name = "影廳DataGridViewTextBoxColumn"
        Me.影廳DataGridViewTextBoxColumn.ReadOnly = True
        Me.影廳DataGridViewTextBoxColumn.Width = 125
        '
        '場次DataGridViewTextBoxColumn
        '
        Me.場次DataGridViewTextBoxColumn.DataPropertyName = "場次"
        Me.場次DataGridViewTextBoxColumn.HeaderText = "場次"
        Me.場次DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.場次DataGridViewTextBoxColumn.Name = "場次DataGridViewTextBoxColumn"
        Me.場次DataGridViewTextBoxColumn.ReadOnly = True
        Me.場次DataGridViewTextBoxColumn.Width = 125
        '
        '距離觀影日還有幾天DataGridViewTextBoxColumn
        '
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.DataPropertyName = "距離觀影日還有幾天"
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.HeaderText = "距離觀影日還有幾天"
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.Name = "距離觀影日還有幾天DataGridViewTextBoxColumn"
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.ReadOnly = True
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.Width = 125
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.BookingAndEventsDataSet
        '
        'BookingAndEventsDataSet
        '
        Me.BookingAndEventsDataSet.DataSetName = "BookingAndEventsDataSet"
        Me.BookingAndEventsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderBindingSource6
        '
        Me.OrderBindingSource6.DataMember = "Order"
        Me.OrderBindingSource6.DataSource = Me.BookingAndEventsDataSet
        '
        'OrderBindingSource1
        '
        Me.OrderBindingSource1.DataMember = "Order"
        Me.OrderBindingSource1.DataSource = Me.BookingAndEventsDataSet
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
        'OrderBindingSource2
        '
        Me.OrderBindingSource2.DataMember = "Order"
        Me.OrderBindingSource2.DataSource = Me.BookingAndEventsDataSet1
        '
        'OrderBindingSource5
        '
        Me.OrderBindingSource5.DataMember = "Order"
        Me.OrderBindingSource5.DataSource = Me.BookingAndEventsDataSet
        '
        'OrderBindingSource3
        '
        Me.OrderBindingSource3.DataMember = "Order"
        Me.OrderBindingSource3.DataSource = Me.BookingAndEventsDataSet
        '
        'OrderBindingSource4
        '
        Me.OrderBindingSource4.DataMember = "Order"
        Me.OrderBindingSource4.DataSource = Me.BookingAndEventsDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'FillBy4ToolStrip
        '
        Me.FillBy4ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy4ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillBy4ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.電話ToolStripLabel, Me.電話ToolStripTextBox, Me.FillBy4ToolStripButton})
        Me.FillBy4ToolStrip.Location = New System.Drawing.Point(291, 62)
        Me.FillBy4ToolStrip.Name = "FillBy4ToolStrip"
        Me.FillBy4ToolStrip.Size = New System.Drawing.Size(314, 30)
        Me.FillBy4ToolStrip.TabIndex = 31
        Me.FillBy4ToolStrip.Text = "FillBy4ToolStrip"
        '
        '電話ToolStripLabel
        '
        Me.電話ToolStripLabel.Name = "電話ToolStripLabel"
        Me.電話ToolStripLabel.Size = New System.Drawing.Size(50, 27)
        Me.電話ToolStripLabel.Text = "電話:"
        '
        '電話ToolStripTextBox
        '
        Me.電話ToolStripTextBox.Name = "電話ToolStripTextBox"
        Me.電話ToolStripTextBox.Size = New System.Drawing.Size(200, 30)
        '
        'FillBy4ToolStripButton
        '
        Me.FillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy4ToolStripButton.Name = "FillBy4ToolStripButton"
        Me.FillBy4ToolStripButton.Size = New System.Drawing.Size(50, 27)
        Me.FillBy4ToolStripButton.Text = "查詢"
        '
        'TrackingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 591)
        Me.Controls.Add(Me.FillBy4ToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.BtnMenu)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "TrackingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrackingForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingAndEventsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingAndEventsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy4ToolStrip.ResumeLayout(False)
        Me.FillBy4ToolStrip.PerformLayout()
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
    Friend WithEvents OrderBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents 電影名稱DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 票數DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 影廳DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 場次DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 距離觀影日還有幾天DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderBindingSource3 As BindingSource
    Friend WithEvents OrderBindingSource5 As BindingSource
    Friend WithEvents OrderBindingSource4 As BindingSource
    Friend WithEvents OrderBindingSource6 As BindingSource
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As BookingAndEventsDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents FillBy4ToolStrip As ToolStrip
    Friend WithEvents 電話ToolStripLabel As ToolStripLabel
    Friend WithEvents 電話ToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBy4ToolStripButton As ToolStripButton
End Class