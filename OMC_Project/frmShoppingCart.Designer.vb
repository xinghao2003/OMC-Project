<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoppingCart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShoppingCart))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPriceAfterDiscount = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_omcDataSet = New OMC_Project.database_omcDataSet()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNextItem = New System.Windows.Forms.Button()
        Me.btnPreviousItem = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InventoryTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.inventoryTableAdapter()
        Me.panelOrder = New System.Windows.Forms.Panel()
        Me.rtxtOrderDetail = New System.Windows.Forms.RichTextBox()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtOrderWeight = New System.Windows.Forms.TextBox()
        Me.txtOrderPrice = New System.Windows.Forms.TextBox()
        Me.txtOrderUserID = New System.Windows.Forms.TextBox()
        Me.OrderTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.orderTableAdapter()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrder.SuspendLayout()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblPriceAfterDiscount)
        Me.Panel1.Controls.Add(Me.lblDiscount)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.lblItemName)
        Me.Panel1.Controls.Add(Me.lblFinalPrice)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.nudQuantity)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(22, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 150)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(199, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 18)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Price after Discount:"
        '
        'lblPriceAfterDiscount
        '
        Me.lblPriceAfterDiscount.AutoSize = True
        Me.lblPriceAfterDiscount.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceAfterDiscount.Location = New System.Drawing.Point(381, 72)
        Me.lblPriceAfterDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceAfterDiscount.Name = "lblPriceAfterDiscount"
        Me.lblPriceAfterDiscount.Size = New System.Drawing.Size(174, 18)
        Me.lblPriceAfterDiscount.TabIndex = 61
        Me.lblPriceAfterDiscount.Text = "Item Price after Discount"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "DISCOUNT", True))
        Me.lblDiscount.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(321, 44)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(101, 18)
        Me.lblDiscount.TabIndex = 60
        Me.lblDiscount.Text = "Item Dicsount"
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "inventory"
        Me.InventoryBindingSource.DataSource = Me.Database_omcDataSet
        '
        'Database_omcDataSet
        '
        Me.Database_omcDataSet.DataSetName = "database_omcDataSet"
        Me.Database_omcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "PRICE", True))
        Me.lblPrice.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(199, 44)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(76, 18)
        Me.lblPrice.TabIndex = 59
        Me.lblPrice.Text = "Item Price"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.BackColor = System.Drawing.Color.LightGray
        Me.lblItemName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "ITEM NAME", True))
        Me.lblItemName.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(196, 11)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(149, 31)
        Me.lblItemName.TabIndex = 58
        Me.lblItemName.Text = "Item Name"
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalPrice.Location = New System.Drawing.Point(511, 119)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(75, 18)
        Me.lblFinalPrice.TabIndex = 56
        Me.lblFinalPrice.Text = "FinalPrice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Final Price: "
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(280, 116)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(68, 25)
        Me.nudQuantity.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Quantity: "
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.InventoryBindingSource, "MAIN PICTURE", True))
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnNextItem
        '
        Me.btnNextItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNextItem.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextItem.Location = New System.Drawing.Point(167, 216)
        Me.btnNextItem.Name = "btnNextItem"
        Me.btnNextItem.Size = New System.Drawing.Size(135, 25)
        Me.btnNextItem.TabIndex = 2
        Me.btnNextItem.Text = "&Next Item"
        Me.btnNextItem.UseVisualStyleBackColor = False
        '
        'btnPreviousItem
        '
        Me.btnPreviousItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPreviousItem.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousItem.Location = New System.Drawing.Point(25, 216)
        Me.btnPreviousItem.Name = "btnPreviousItem"
        Me.btnPreviousItem.Size = New System.Drawing.Size(135, 25)
        Me.btnPreviousItem.TabIndex = 1
        Me.btnPreviousItem.Text = "&Previous Item"
        Me.btnPreviousItem.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.GreenYellow
        Me.btnCheckout.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(472, 216)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(169, 25)
        Me.btnCheckout.TabIndex = 3
        Me.btnCheckout.Text = "Check &out"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPrice.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(528, 182)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(83, 18)
        Me.lblTotalPrice.TabIndex = 63
        Me.lblTotalPrice.Text = "Total Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(362, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Total Price of all item: "
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'panelOrder
        '
        Me.panelOrder.Controls.Add(Me.rtxtOrderDetail)
        Me.panelOrder.Controls.Add(Me.txtOrderWeight)
        Me.panelOrder.Controls.Add(Me.txtOrderPrice)
        Me.panelOrder.Controls.Add(Me.txtOrderUserID)
        Me.panelOrder.Location = New System.Drawing.Point(19, 276)
        Me.panelOrder.Name = "panelOrder"
        Me.panelOrder.Size = New System.Drawing.Size(619, 177)
        Me.panelOrder.TabIndex = 65
        Me.panelOrder.Visible = False
        '
        'rtxtOrderDetail
        '
        Me.rtxtOrderDetail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "ORDER DETAIL", True))
        Me.rtxtOrderDetail.Location = New System.Drawing.Point(26, 18)
        Me.rtxtOrderDetail.Name = "rtxtOrderDetail"
        Me.rtxtOrderDetail.Size = New System.Drawing.Size(203, 113)
        Me.rtxtOrderDetail.TabIndex = 5
        Me.rtxtOrderDetail.Text = ""
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "order"
        Me.OrderBindingSource.DataSource = Me.Database_omcDataSet
        '
        'txtOrderWeight
        '
        Me.txtOrderWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "WEIGHT", True))
        Me.txtOrderWeight.Location = New System.Drawing.Point(258, 106)
        Me.txtOrderWeight.Name = "txtOrderWeight"
        Me.txtOrderWeight.Size = New System.Drawing.Size(112, 25)
        Me.txtOrderWeight.TabIndex = 3
        '
        'txtOrderPrice
        '
        Me.txtOrderPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "PRICE", True))
        Me.txtOrderPrice.Location = New System.Drawing.Point(258, 59)
        Me.txtOrderPrice.Name = "txtOrderPrice"
        Me.txtOrderPrice.Size = New System.Drawing.Size(112, 25)
        Me.txtOrderPrice.TabIndex = 2
        '
        'txtOrderUserID
        '
        Me.txtOrderUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "USER ID", True))
        Me.txtOrderUserID.Location = New System.Drawing.Point(258, 18)
        Me.txtOrderUserID.Name = "txtOrderUserID"
        Me.txtOrderUserID.Size = New System.Drawing.Size(112, 25)
        Me.txtOrderUserID.TabIndex = 1
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(324, 130)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(8, 25)
        Me.NumericUpDown1.TabIndex = 63
        '
        'frmShoppingCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(662, 265)
        Me.Controls.Add(Me.panelOrder)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnNextItem)
        Me.Controls.Add(Me.btnPreviousItem)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmShoppingCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrder.ResumeLayout(False)
        Me.panelOrder.PerformLayout()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFinalPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPriceAfterDiscount As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents btnNextItem As Button
    Friend WithEvents btnPreviousItem As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Database_omcDataSet As database_omcDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As database_omcDataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents panelOrder As Panel
    Friend WithEvents txtOrderUserID As TextBox
    Friend WithEvents txtOrderPrice As TextBox
    Friend WithEvents txtOrderWeight As TextBox
    Friend WithEvents rtxtOrderDetail As RichTextBox
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As database_omcDataSetTableAdapters.orderTableAdapter
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
