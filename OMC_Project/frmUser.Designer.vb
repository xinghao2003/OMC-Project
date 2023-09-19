<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_omcDataSet = New OMC_Project.database_omcDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPriceAfterDiscount = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.rtxtDescription = New System.Windows.Forms.RichTextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnPreviousItem = New System.Windows.Forms.Button()
        Me.btnNextItem = New System.Windows.Forms.Button()
        Me.btnUserDetail = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnShoppingCart = New System.Windows.Forms.Button()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.inventoryTableAdapter()
        Me.UsersTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.usersTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(698, 125)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "WELCOME TO MASTER ENTREPRISE ONLINE SHOPPING PAGE !!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ENJOY YOURSELVES IN THIS" &
    " CORN'S WORLD "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.InventoryBindingSource, "MAIN PICTURE", True))
        Me.PictureBox2.Location = New System.Drawing.Point(20, 71)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 261)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblPriceAfterDiscount)
        Me.Panel1.Controls.Add(Me.lblDiscount)
        Me.Panel1.Controls.Add(Me.rtxtDescription)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.lblItemName)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(41, 200)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 402)
        Me.Panel1.TabIndex = 50
        '
        'lblPriceAfterDiscount
        '
        Me.lblPriceAfterDiscount.AutoSize = True
        Me.lblPriceAfterDiscount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "DISCOUNT", True))
        Me.lblPriceAfterDiscount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceAfterDiscount.Location = New System.Drawing.Point(356, 99)
        Me.lblPriceAfterDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceAfterDiscount.Name = "lblPriceAfterDiscount"
        Me.lblPriceAfterDiscount.Size = New System.Drawing.Size(159, 19)
        Me.lblPriceAfterDiscount.TabIndex = 54
        Me.lblPriceAfterDiscount.Text = "Price after Discount"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "DISCOUNT", True))
        Me.lblDiscount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(507, 71)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(114, 19)
        Me.lblDiscount.TabIndex = 53
        Me.lblDiscount.Text = "Item Discount"
        '
        'rtxtDescription
        '
        Me.rtxtDescription.BackColor = System.Drawing.Color.White
        Me.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "DESCRIPTION", True))
        Me.rtxtDescription.Enabled = False
        Me.rtxtDescription.Location = New System.Drawing.Point(358, 130)
        Me.rtxtDescription.Name = "rtxtDescription"
        Me.rtxtDescription.Size = New System.Drawing.Size(452, 202)
        Me.rtxtDescription.TabIndex = 52
        Me.rtxtDescription.Text = "Item description"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "PRICE", True))
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(356, 71)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(84, 19)
        Me.lblPrice.TabIndex = 51
        Me.lblPrice.Text = "Item Price"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "ITEM NAME", True))
        Me.lblItemName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(352, 26)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(157, 32)
        Me.lblItemName.TabIndex = 50
        Me.lblItemName.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 617)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Quantity: "
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(123, 613)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(68, 25)
        Me.nudQuantity.TabIndex = 0
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.GreenYellow
        Me.btnAddToCart.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.Location = New System.Drawing.Point(205, 613)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(135, 25)
        Me.btnAddToCart.TabIndex = 1
        Me.btnAddToCart.Text = "&Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'btnPreviousItem
        '
        Me.btnPreviousItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPreviousItem.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousItem.Location = New System.Drawing.Point(554, 613)
        Me.btnPreviousItem.Name = "btnPreviousItem"
        Me.btnPreviousItem.Size = New System.Drawing.Size(169, 25)
        Me.btnPreviousItem.TabIndex = 3
        Me.btnPreviousItem.Text = "&Previous Product"
        Me.btnPreviousItem.UseVisualStyleBackColor = False
        '
        'btnNextItem
        '
        Me.btnNextItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNextItem.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextItem.Location = New System.Drawing.Point(729, 613)
        Me.btnNextItem.Name = "btnNextItem"
        Me.btnNextItem.Size = New System.Drawing.Size(169, 25)
        Me.btnNextItem.TabIndex = 4
        Me.btnNextItem.Text = "&Next Product"
        Me.btnNextItem.UseVisualStyleBackColor = False
        '
        'btnUserDetail
        '
        Me.btnUserDetail.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnUserDetail.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserDetail.Location = New System.Drawing.Point(768, 168)
        Me.btnUserDetail.Name = "btnUserDetail"
        Me.btnUserDetail.Size = New System.Drawing.Size(129, 25)
        Me.btnUserDetail.TabIndex = 7
        Me.btnUserDetail.Text = "User &Detail"
        Me.btnUserDetail.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(444, 168)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(224, 25)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.Text = "Search any product"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.GreenYellow
        Me.btnFind.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(676, 168)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(56, 25)
        Me.btnFind.TabIndex = 6
        Me.btnFind.Text = "&Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(768, 72)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 56)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 73
        Me.PictureBox3.TabStop = False
        '
        'btnShoppingCart
        '
        Me.btnShoppingCart.BackColor = System.Drawing.Color.GreenYellow
        Me.btnShoppingCart.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShoppingCart.Location = New System.Drawing.Point(347, 613)
        Me.btnShoppingCart.Name = "btnShoppingCart"
        Me.btnShoppingCart.Size = New System.Drawing.Size(135, 25)
        Me.btnShoppingCart.TabIndex = 2
        Me.btnShoppingCart.Text = "Shopping &Cart"
        Me.btnShoppingCart.UseVisualStyleBackColor = False
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.Database_omcDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(938, 667)
        Me.Controls.Add(Me.btnShoppingCart)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnUserDetail)
        Me.Controls.Add(Me.btnNextItem)
        Me.Controls.Add(Me.btnPreviousItem)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User | Shop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rtxtDescription As RichTextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents Database_omcDataSet As database_omcDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As database_omcDataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnPreviousItem As Button
    Friend WithEvents btnNextItem As Button
    Friend WithEvents btnUserDetail As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnShoppingCart As Button
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblPriceAfterDiscount As Label
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As database_omcDataSetTableAdapters.usersTableAdapter
End Class
