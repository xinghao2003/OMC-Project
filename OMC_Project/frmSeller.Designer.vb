<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeller))
        Me.lblSellerName = New System.Windows.Forms.Label()
        Me.tabIssueReport = New System.Windows.Forms.TabPage()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.IssueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_omcDataSet = New OMC_Project.database_omcDataSet()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.btnIssueSubmit = New System.Windows.Forms.Button()
        Me.btnUploadPicture = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picUpload = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTypeIssue = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabFinance = New System.Windows.Forms.TabPage()
        Me.btnIncomeRefresh = New System.Windows.Forms.Button()
        Me.btnTopSellingRefresh = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chartTopSelling = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chartIncome = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabInventory = New System.Windows.Forms.TabPage()
        Me.txtInvUserID = New System.Windows.Forms.TextBox()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEditStock = New System.Windows.Forms.Button()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.btnInvRefresh = New System.Windows.Forms.Button()
        Me.dgvInv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabOrders = New System.Windows.Forms.TabPage()
        Me.sc1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtSalesPrice = New System.Windows.Forms.TextBox()
        Me.txtSalesQuantity = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.rtxtOrderDetail = New System.Windows.Forms.RichTextBox()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.lblWeightOrdered = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnOrderRefresh = New System.Windows.Forms.Button()
        Me.btnNextOrder = New System.Windows.Forms.Button()
        Me.btnPreviousOrder = New System.Windows.Forms.Button()
        Me.btnOrderReject = New System.Windows.Forms.Button()
        Me.btnListOfOrder = New System.Windows.Forms.Button()
        Me.btnOrderAccept = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.IssueTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.issueTableAdapter()
        Me.OrderTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.orderTableAdapter()
        Me.InventoryTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.inventoryTableAdapter()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.usersTableAdapter()
        Me.SalesTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.salesTableAdapter()
        Me.tabIssueReport.SuspendLayout()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFinance.SuspendLayout()
        CType(Me.chartTopSelling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInventory.SuspendLayout()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrders.SuspendLayout()
        CType(Me.sc1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sc1.Panel1.SuspendLayout()
        Me.sc1.Panel2.SuspendLayout()
        Me.sc1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSellerName
        '
        Me.lblSellerName.BackColor = System.Drawing.Color.Transparent
        Me.lblSellerName.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellerName.Location = New System.Drawing.Point(432, 30)
        Me.lblSellerName.Name = "lblSellerName"
        Me.lblSellerName.Size = New System.Drawing.Size(299, 17)
        Me.lblSellerName.TabIndex = 1
        Me.lblSellerName.Text = "SELLER NAME"
        Me.lblSellerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabIssueReport
        '
        Me.tabIssueReport.Controls.Add(Me.txtUserID)
        Me.tabIssueReport.Controls.Add(Me.txtDesc)
        Me.tabIssueReport.Controls.Add(Me.btnIssueSubmit)
        Me.tabIssueReport.Controls.Add(Me.btnUploadPicture)
        Me.tabIssueReport.Controls.Add(Me.Label5)
        Me.tabIssueReport.Controls.Add(Me.picUpload)
        Me.tabIssueReport.Controls.Add(Me.Label4)
        Me.tabIssueReport.Controls.Add(Me.cboTypeIssue)
        Me.tabIssueReport.Controls.Add(Me.Label1)
        Me.tabIssueReport.Location = New System.Drawing.Point(4, 26)
        Me.tabIssueReport.Name = "tabIssueReport"
        Me.tabIssueReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIssueReport.Size = New System.Drawing.Size(713, 371)
        Me.tabIssueReport.TabIndex = 3
        Me.tabIssueReport.Text = "System Issue Report"
        Me.tabIssueReport.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "USER ID", True))
        Me.txtUserID.Location = New System.Drawing.Point(255, 29)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(123, 25)
        Me.txtUserID.TabIndex = 9
        Me.txtUserID.Text = "-1"
        Me.txtUserID.Visible = False
        '
        'IssueBindingSource
        '
        Me.IssueBindingSource.DataMember = "issue"
        Me.IssueBindingSource.DataSource = Me.Database_omcDataSet
        '
        'Database_omcDataSet
        '
        Me.Database_omcDataSet.DataSetName = "database_omcDataSet"
        Me.Database_omcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDesc
        '
        Me.txtDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "DESCRIPTION", True))
        Me.txtDesc.Location = New System.Drawing.Point(11, 97)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(367, 169)
        Me.txtDesc.TabIndex = 1
        '
        'btnIssueSubmit
        '
        Me.btnIssueSubmit.BackColor = System.Drawing.Color.GreenYellow
        Me.btnIssueSubmit.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueSubmit.Location = New System.Drawing.Point(316, 302)
        Me.btnIssueSubmit.Name = "btnIssueSubmit"
        Me.btnIssueSubmit.Size = New System.Drawing.Size(94, 36)
        Me.btnIssueSubmit.TabIndex = 3
        Me.btnIssueSubmit.Text = "&Submit"
        Me.btnIssueSubmit.UseVisualStyleBackColor = False
        '
        'btnUploadPicture
        '
        Me.btnUploadPicture.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnUploadPicture.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPicture.Location = New System.Drawing.Point(412, 241)
        Me.btnUploadPicture.Name = "btnUploadPicture"
        Me.btnUploadPicture.Size = New System.Drawing.Size(161, 25)
        Me.btnUploadPicture.TabIndex = 2
        Me.btnUploadPicture.Text = "&Upload Picture"
        Me.btnUploadPicture.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Screenshot"
        '
        'picUpload
        '
        Me.picUpload.BackColor = System.Drawing.Color.White
        Me.picUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUpload.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.IssueBindingSource, "PICTURE", True))
        Me.picUpload.Location = New System.Drawing.Point(412, 29)
        Me.picUpload.Name = "picUpload"
        Me.picUpload.Size = New System.Drawing.Size(292, 206)
        Me.picUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUpload.TabIndex = 5
        Me.picUpload.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Description"
        '
        'cboTypeIssue
        '
        Me.cboTypeIssue.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssueBindingSource, "TYPE", True))
        Me.cboTypeIssue.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.IssueBindingSource, "TYPE", True))
        Me.cboTypeIssue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "TYPE", True))
        Me.cboTypeIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeIssue.FormattingEnabled = True
        Me.cboTypeIssue.Items.AddRange(New Object() {"General", "Login", "Sign Up", "Orders", "Inventory", "Finance", "Database"})
        Me.cboTypeIssue.Location = New System.Drawing.Point(11, 29)
        Me.cboTypeIssue.Name = "cboTypeIssue"
        Me.cboTypeIssue.Size = New System.Drawing.Size(217, 25)
        Me.cboTypeIssue.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type of Issue"
        '
        'tabFinance
        '
        Me.tabFinance.Controls.Add(Me.btnIncomeRefresh)
        Me.tabFinance.Controls.Add(Me.btnTopSellingRefresh)
        Me.tabFinance.Controls.Add(Me.Label3)
        Me.tabFinance.Controls.Add(Me.Label2)
        Me.tabFinance.Controls.Add(Me.chartTopSelling)
        Me.tabFinance.Controls.Add(Me.chartIncome)
        Me.tabFinance.Location = New System.Drawing.Point(4, 26)
        Me.tabFinance.Name = "tabFinance"
        Me.tabFinance.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFinance.Size = New System.Drawing.Size(713, 371)
        Me.tabFinance.TabIndex = 2
        Me.tabFinance.Text = "Finance"
        Me.tabFinance.UseVisualStyleBackColor = True
        '
        'btnIncomeRefresh
        '
        Me.btnIncomeRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnIncomeRefresh.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncomeRefresh.Location = New System.Drawing.Point(260, 324)
        Me.btnIncomeRefresh.Name = "btnIncomeRefresh"
        Me.btnIncomeRefresh.Size = New System.Drawing.Size(84, 25)
        Me.btnIncomeRefresh.TabIndex = 0
        Me.btnIncomeRefresh.Text = "Re&fresh"
        Me.btnIncomeRefresh.UseVisualStyleBackColor = False
        '
        'btnTopSellingRefresh
        '
        Me.btnTopSellingRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnTopSellingRefresh.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopSellingRefresh.Location = New System.Drawing.Point(620, 324)
        Me.btnTopSellingRefresh.Name = "btnTopSellingRefresh"
        Me.btnTopSellingRefresh.Size = New System.Drawing.Size(84, 25)
        Me.btnTopSellingRefresh.TabIndex = 1
        Me.btnTopSellingRefresh.Text = "Re&fresh"
        Me.btnTopSellingRefresh.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(368, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Top Selling Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Income"
        '
        'chartTopSelling
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartTopSelling.ChartAreas.Add(ChartArea1)
        Me.chartTopSelling.DataSource = Me.SalesBindingSource
        Legend1.Name = "Legend1"
        Me.chartTopSelling.Legends.Add(Legend1)
        Me.chartTopSelling.Location = New System.Drawing.Point(371, 45)
        Me.chartTopSelling.Name = "chartTopSelling"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.XValueMember = "ITEM ID"
        Series1.YValueMembers = "QUANTITY"
        Me.chartTopSelling.Series.Add(Series1)
        Me.chartTopSelling.Size = New System.Drawing.Size(338, 319)
        Me.chartTopSelling.TabIndex = 1
        Me.chartTopSelling.Text = "Chart2"
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "sales"
        Me.SalesBindingSource.DataSource = Me.Database_omcDataSet
        '
        'chartIncome
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartIncome.ChartAreas.Add(ChartArea2)
        Me.chartIncome.DataSource = Me.SalesBindingSource
        Legend2.Name = "Legend1"
        Me.chartIncome.Legends.Add(Legend2)
        Me.chartIncome.Location = New System.Drawing.Point(7, 45)
        Me.chartIncome.Name = "chartIncome"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.XValueMember = "ITEM ID"
        Series2.YValueMembers = "PRICE"
        Me.chartIncome.Series.Add(Series2)
        Me.chartIncome.Size = New System.Drawing.Size(338, 319)
        Me.chartIncome.TabIndex = 0
        Me.chartIncome.Text = "Chart1"
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.txtInvUserID)
        Me.tabInventory.Controls.Add(Me.btnEditStock)
        Me.tabInventory.Controls.Add(Me.btnNewProduct)
        Me.tabInventory.Controls.Add(Me.btnInvRefresh)
        Me.tabInventory.Controls.Add(Me.dgvInv)
        Me.tabInventory.Location = New System.Drawing.Point(4, 26)
        Me.tabInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.Padding = New System.Windows.Forms.Padding(4)
        Me.tabInventory.Size = New System.Drawing.Size(713, 371)
        Me.tabInventory.TabIndex = 1
        Me.tabInventory.Text = "Inventory"
        Me.tabInventory.UseVisualStyleBackColor = True
        '
        'txtInvUserID
        '
        Me.txtInvUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "USER ID", True))
        Me.txtInvUserID.Location = New System.Drawing.Point(99, 4)
        Me.txtInvUserID.Name = "txtInvUserID"
        Me.txtInvUserID.Size = New System.Drawing.Size(46, 25)
        Me.txtInvUserID.TabIndex = 27
        Me.txtInvUserID.Text = "-1"
        Me.txtInvUserID.Visible = False
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "inventory"
        Me.InventoryBindingSource.DataSource = Me.Database_omcDataSet
        '
        'btnEditStock
        '
        Me.btnEditStock.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditStock.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStock.Location = New System.Drawing.Point(592, 4)
        Me.btnEditStock.Name = "btnEditStock"
        Me.btnEditStock.Size = New System.Drawing.Size(112, 25)
        Me.btnEditStock.TabIndex = 3
        Me.btnEditStock.Text = "&Edit Stock"
        Me.btnEditStock.UseVisualStyleBackColor = False
        '
        'btnNewProduct
        '
        Me.btnNewProduct.BackColor = System.Drawing.Color.GreenYellow
        Me.btnNewProduct.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewProduct.Location = New System.Drawing.Point(472, 4)
        Me.btnNewProduct.Name = "btnNewProduct"
        Me.btnNewProduct.Size = New System.Drawing.Size(112, 25)
        Me.btnNewProduct.TabIndex = 2
        Me.btnNewProduct.Text = "&New Product"
        Me.btnNewProduct.UseVisualStyleBackColor = False
        '
        'btnInvRefresh
        '
        Me.btnInvRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnInvRefresh.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvRefresh.Location = New System.Drawing.Point(8, 4)
        Me.btnInvRefresh.Name = "btnInvRefresh"
        Me.btnInvRefresh.Size = New System.Drawing.Size(84, 25)
        Me.btnInvRefresh.TabIndex = 1
        Me.btnInvRefresh.Text = "Re&fresh"
        Me.btnInvRefresh.UseVisualStyleBackColor = False
        '
        'dgvInv
        '
        Me.dgvInv.AllowUserToAddRows = False
        Me.dgvInv.AllowUserToDeleteRows = False
        Me.dgvInv.AutoGenerateColumns = False
        Me.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvInv.DataSource = Me.InventoryBindingSource
        Me.dgvInv.Location = New System.Drawing.Point(8, 35)
        Me.dgvInv.Name = "dgvInv"
        Me.dgvInv.ReadOnly = True
        Me.dgvInv.RowHeadersWidth = 51
        Me.dgvInv.RowTemplate.Height = 23
        Me.dgvInv.Size = New System.Drawing.Size(696, 327)
        Me.dgvInv.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PRODUCT NUMBER"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PRODUCT NUMBER"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ITEM NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ITEM NAME"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DISCOUNT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DISCOUNT"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "STOCK"
        Me.DataGridViewTextBoxColumn5.HeaderText = "STOCK"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'tabOrders
        '
        Me.tabOrders.Controls.Add(Me.sc1)
        Me.tabOrders.Location = New System.Drawing.Point(4, 26)
        Me.tabOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.tabOrders.Name = "tabOrders"
        Me.tabOrders.Padding = New System.Windows.Forms.Padding(4)
        Me.tabOrders.Size = New System.Drawing.Size(713, 371)
        Me.tabOrders.TabIndex = 0
        Me.tabOrders.Text = "Orders"
        Me.tabOrders.UseVisualStyleBackColor = True
        '
        'sc1
        '
        Me.sc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sc1.Location = New System.Drawing.Point(4, 4)
        Me.sc1.Name = "sc1"
        '
        'sc1.Panel1
        '
        Me.sc1.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'sc1.Panel2
        '
        Me.sc1.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.sc1.Panel2.Controls.Add(Me.btnOrderReject)
        Me.sc1.Panel2.Controls.Add(Me.btnListOfOrder)
        Me.sc1.Panel2.Controls.Add(Me.btnOrderAccept)
        Me.sc1.Size = New System.Drawing.Size(705, 363)
        Me.sc1.SplitterDistance = 557
        Me.sc1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSalesPrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSalesQuantity)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtStock)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rtxtOrderDetail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCustomerID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtStatus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFinalPrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblWeightOrdered)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCustomerName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblOrderID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnOrderRefresh)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnNextOrder)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnPreviousOrder)
        Me.SplitContainer1.Size = New System.Drawing.Size(557, 363)
        Me.SplitContainer1.SplitterDistance = 317
        Me.SplitContainer1.TabIndex = 0
        '
        'txtSalesPrice
        '
        Me.txtSalesPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "PRICE", True))
        Me.txtSalesPrice.Location = New System.Drawing.Point(451, 226)
        Me.txtSalesPrice.Name = "txtSalesPrice"
        Me.txtSalesPrice.Size = New System.Drawing.Size(100, 25)
        Me.txtSalesPrice.TabIndex = 18
        Me.txtSalesPrice.Visible = False
        '
        'txtSalesQuantity
        '
        Me.txtSalesQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "QUANTITY", True))
        Me.txtSalesQuantity.Location = New System.Drawing.Point(451, 270)
        Me.txtSalesQuantity.Name = "txtSalesQuantity"
        Me.txtSalesQuantity.Size = New System.Drawing.Size(100, 25)
        Me.txtSalesQuantity.TabIndex = 17
        Me.txtSalesQuantity.Visible = False
        '
        'txtStock
        '
        Me.txtStock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "STOCK", True))
        Me.txtStock.Location = New System.Drawing.Point(263, 275)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 25)
        Me.txtStock.TabIndex = 15
        Me.txtStock.Visible = False
        '
        'rtxtOrderDetail
        '
        Me.rtxtOrderDetail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "ORDER DETAIL", True))
        Me.rtxtOrderDetail.Enabled = False
        Me.rtxtOrderDetail.Location = New System.Drawing.Point(135, 51)
        Me.rtxtOrderDetail.Name = "rtxtOrderDetail"
        Me.rtxtOrderDetail.Size = New System.Drawing.Size(417, 114)
        Me.rtxtOrderDetail.TabIndex = 14
        Me.rtxtOrderDetail.Text = ""
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "order"
        Me.OrderBindingSource.DataSource = Me.Database_omcDataSet
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "USER ID", True))
        Me.lblCustomerID.Location = New System.Drawing.Point(146, 278)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(92, 17)
        Me.lblCustomerID.TabIndex = 13
        Me.lblCustomerID.Text = "Customer ID"
        '
        'txtStatus
        '
        Me.txtStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "STATUS", True))
        Me.txtStatus.Location = New System.Drawing.Point(27, 275)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(112, 25)
        Me.txtStatus.TabIndex = 11
        Me.txtStatus.Text = "-1"
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "PRICE", True))
        Me.lblFinalPrice.Location = New System.Drawing.Point(133, 248)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(60, 17)
        Me.lblFinalPrice.TabIndex = 9
        Me.lblFinalPrice.Text = "Label15"
        '
        'lblWeightOrdered
        '
        Me.lblWeightOrdered.AutoSize = True
        Me.lblWeightOrdered.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "WEIGHT", True))
        Me.lblWeightOrdered.Location = New System.Drawing.Point(132, 214)
        Me.lblWeightOrdered.Name = "lblWeightOrdered"
        Me.lblWeightOrdered.Size = New System.Drawing.Size(60, 17)
        Me.lblWeightOrdered.TabIndex = 8
        Me.lblWeightOrdered.Text = "Label14"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(133, 180)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(60, 17)
        Me.lblCustomerName.TabIndex = 7
        Me.lblCustomerName.Text = "Label13"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "ID", True))
        Me.lblOrderID.Location = New System.Drawing.Point(133, 17)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(60, 17)
        Me.lblOrderID.TabIndex = 5
        Me.lblOrderID.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 18)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total Price: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Weight Ordered: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Customer Name: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Order Detail: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Order ID: "
        '
        'btnOrderRefresh
        '
        Me.btnOrderRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnOrderRefresh.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderRefresh.Location = New System.Drawing.Point(210, 4)
        Me.btnOrderRefresh.Name = "btnOrderRefresh"
        Me.btnOrderRefresh.Size = New System.Drawing.Size(135, 32)
        Me.btnOrderRefresh.TabIndex = 1
        Me.btnOrderRefresh.Text = "Re&fresh"
        Me.btnOrderRefresh.UseVisualStyleBackColor = False
        '
        'btnNextOrder
        '
        Me.btnNextOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNextOrder.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextOrder.Location = New System.Drawing.Point(417, 3)
        Me.btnNextOrder.Name = "btnNextOrder"
        Me.btnNextOrder.Size = New System.Drawing.Size(135, 32)
        Me.btnNextOrder.TabIndex = 2
        Me.btnNextOrder.Text = "&Next"
        Me.btnNextOrder.UseVisualStyleBackColor = False
        '
        'btnPreviousOrder
        '
        Me.btnPreviousOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPreviousOrder.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousOrder.Location = New System.Drawing.Point(3, 4)
        Me.btnPreviousOrder.Name = "btnPreviousOrder"
        Me.btnPreviousOrder.Size = New System.Drawing.Size(135, 32)
        Me.btnPreviousOrder.TabIndex = 0
        Me.btnPreviousOrder.Text = "&Previous"
        Me.btnPreviousOrder.UseVisualStyleBackColor = False
        '
        'btnOrderReject
        '
        Me.btnOrderReject.BackColor = System.Drawing.Color.OrangeRed
        Me.btnOrderReject.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderReject.Location = New System.Drawing.Point(4, 172)
        Me.btnOrderReject.Name = "btnOrderReject"
        Me.btnOrderReject.Size = New System.Drawing.Size(135, 32)
        Me.btnOrderReject.TabIndex = 5
        Me.btnOrderReject.Text = "&Reject"
        Me.btnOrderReject.UseVisualStyleBackColor = False
        '
        'btnListOfOrder
        '
        Me.btnListOfOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnListOfOrder.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListOfOrder.Location = New System.Drawing.Point(4, 3)
        Me.btnListOfOrder.Name = "btnListOfOrder"
        Me.btnListOfOrder.Size = New System.Drawing.Size(135, 32)
        Me.btnListOfOrder.TabIndex = 3
        Me.btnListOfOrder.Text = "Show All &Order"
        Me.btnListOfOrder.UseVisualStyleBackColor = False
        '
        'btnOrderAccept
        '
        Me.btnOrderAccept.BackColor = System.Drawing.Color.GreenYellow
        Me.btnOrderAccept.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderAccept.Location = New System.Drawing.Point(4, 134)
        Me.btnOrderAccept.Name = "btnOrderAccept"
        Me.btnOrderAccept.Size = New System.Drawing.Size(135, 32)
        Me.btnOrderAccept.TabIndex = 4
        Me.btnOrderAccept.Text = "&Accept"
        Me.btnOrderAccept.UseVisualStyleBackColor = False
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabOrders)
        Me.tabControl.Controls.Add(Me.tabInventory)
        Me.tabControl.Controls.Add(Me.tabFinance)
        Me.tabControl.Controls.Add(Me.tabIssueReport)
        Me.tabControl.Location = New System.Drawing.Point(24, 27)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(721, 401)
        Me.tabControl.TabIndex = 0
        '
        'IssueTableAdapter
        '
        Me.IssueTableAdapter.ClearBeforeFill = True
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.Database_omcDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'frmSeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(769, 455)
        Me.Controls.Add(Me.lblSellerName)
        Me.Controls.Add(Me.tabControl)
        Me.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmSeller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marvelous Masters"
        Me.tabIssueReport.ResumeLayout(False)
        Me.tabIssueReport.PerformLayout()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFinance.ResumeLayout(False)
        Me.tabFinance.PerformLayout()
        CType(Me.chartTopSelling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInventory.ResumeLayout(False)
        Me.tabInventory.PerformLayout()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrders.ResumeLayout(False)
        Me.sc1.Panel1.ResumeLayout(False)
        Me.sc1.Panel2.ResumeLayout(False)
        CType(Me.sc1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSellerName As Label
    Friend WithEvents Database_omcDataSet As database_omcDataSet
    Friend WithEvents IssueBindingSource As BindingSource
    Friend WithEvents IssueTableAdapter As database_omcDataSetTableAdapters.issueTableAdapter
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As database_omcDataSetTableAdapters.orderTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As database_omcDataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents tabIssueReport As TabPage
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents btnIssueSubmit As Button
    Friend WithEvents btnUploadPicture As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents picUpload As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboTypeIssue As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabFinance As TabPage
    Friend WithEvents btnTopSellingRefresh As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chartTopSelling As DataVisualization.Charting.Chart
    Friend WithEvents chartIncome As DataVisualization.Charting.Chart
    Friend WithEvents tabInventory As TabPage
    Friend WithEvents btnEditStock As Button
    Friend WithEvents btnNewProduct As Button
    Friend WithEvents btnInvRefresh As Button
    Friend WithEvents tabOrders As TabPage
    Friend WithEvents sc1 As SplitContainer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblFinalPrice As Label
    Friend WithEvents lblWeightOrdered As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnOrderRefresh As Button
    Friend WithEvents btnNextOrder As Button
    Friend WithEvents btnPreviousOrder As Button
    Friend WithEvents btnOrderReject As Button
    Friend WithEvents btnListOfOrder As Button
    Friend WithEvents btnOrderAccept As Button
    Friend WithEvents tabControl As TabControl
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As database_omcDataSetTableAdapters.usersTableAdapter
    Friend WithEvents dgvInv As DataGridView
    Friend WithEvents btnIncomeRefresh As Button
    Friend WithEvents txtInvUserID As TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents rtxtOrderDetail As RichTextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtSalesPrice As TextBox
    Friend WithEvents txtSalesQuantity As TextBox
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As database_omcDataSetTableAdapters.salesTableAdapter
End Class
