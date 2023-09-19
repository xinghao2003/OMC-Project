<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUp))
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_omcDataSet = New OMC_Project.database_omcDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTermsServices = New System.Windows.Forms.Label()
        Me.chkTermsServices = New System.Windows.Forms.CheckBox()
        Me.lblAlertRePass = New System.Windows.Forms.Label()
        Me.UsersTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.usersTableAdapter()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.lblPasswordValidate = New System.Windows.Forms.Label()
        Me.lblEmailValidate = New System.Windows.Forms.Label()
        Me.ttPasswordRequirements = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblOTPStatus = New System.Windows.Forms.Label()
        Me.ttTandS = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.GreenYellow
        Me.btnSignUp.Enabled = False
        Me.btnSignUp.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(176, 497)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(112, 42)
        Me.btnSignUp.TabIndex = 7
        Me.btnSignUp.Text = "&SIGN UP"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "ENCRYPTED PASSWORD", True))
        Me.txtPassword.Location = New System.Drawing.Point(39, 323)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(375, 25)
        Me.txtPassword.TabIndex = 4
        Me.ttPasswordRequirements.SetToolTip(Me.txtPassword, "* Minimum 8 characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Contain atleast :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 small letter, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 capital le" &
        "tter, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 numbers, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 special symbols.")
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.Database_omcDataSet
        '
        'Database_omcDataSet
        '
        Me.Database_omcDataSet.DataSetName = "database_omcDataSet"
        Me.Database_omcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Password*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Email Address*"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "EMAIL", True))
        Me.txtEmail.Location = New System.Drawing.Point(39, 187)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(375, 25)
        Me.txtEmail.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 24.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(91, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 34)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "SIGN UP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "First Name*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Last Name*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Re-enter Password*"
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "FIRST NAME", True))
        Me.txtFirstName.Location = New System.Drawing.Point(39, 119)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(168, 25)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "LAST NAME", True))
        Me.txtLastName.Location = New System.Drawing.Point(252, 119)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(162, 25)
        Me.txtLastName.TabIndex = 1
        '
        'dtpBirthday
        '
        Me.dtpBirthday.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "BIRTHDAY", True))
        Me.dtpBirthday.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsersBindingSource, "BIRTHDAY DATE", True))
        Me.dtpBirthday.Location = New System.Drawing.Point(39, 255)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(375, 25)
        Me.dtpBirthday.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Birthday*"
        '
        'lblTermsServices
        '
        Me.lblTermsServices.AutoSize = True
        Me.lblTermsServices.BackColor = System.Drawing.Color.Transparent
        Me.lblTermsServices.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTermsServices.Location = New System.Drawing.Point(99, 440)
        Me.lblTermsServices.Name = "lblTermsServices"
        Me.lblTermsServices.Size = New System.Drawing.Size(135, 18)
        Me.lblTermsServices.TabIndex = 7
        Me.lblTermsServices.Text = "Terms and Services"
        '
        'chkTermsServices
        '
        Me.chkTermsServices.AutoSize = True
        Me.chkTermsServices.BackColor = System.Drawing.Color.Transparent
        Me.chkTermsServices.Enabled = False
        Me.chkTermsServices.Location = New System.Drawing.Point(39, 441)
        Me.chkTermsServices.Name = "chkTermsServices"
        Me.chkTermsServices.Size = New System.Drawing.Size(60, 21)
        Me.chkTermsServices.TabIndex = 6
        Me.chkTermsServices.Text = "&Read"
        Me.chkTermsServices.UseVisualStyleBackColor = False
        '
        'lblAlertRePass
        '
        Me.lblAlertRePass.BackColor = System.Drawing.Color.Transparent
        Me.lblAlertRePass.ForeColor = System.Drawing.Color.Black
        Me.lblAlertRePass.Location = New System.Drawing.Point(233, 370)
        Me.lblAlertRePass.Name = "lblAlertRePass"
        Me.lblAlertRePass.Size = New System.Drawing.Size(182, 18)
        Me.lblAlertRePass.TabIndex = 29
        Me.lblAlertRePass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAlertRePass.Visible = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'txtType
        '
        Me.txtType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "ACCOUNT TYPE", True))
        Me.txtType.Location = New System.Drawing.Point(15, 10)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(28, 25)
        Me.txtType.TabIndex = 30
        Me.txtType.TabStop = False
        Me.txtType.Text = "-1"
        Me.txtType.Visible = False
        '
        'txtPassword2
        '
        Me.txtPassword2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "ENCRYPTED PASSWORD", True))
        Me.txtPassword2.Enabled = False
        Me.txtPassword2.Location = New System.Drawing.Point(39, 391)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(375, 25)
        Me.txtPassword2.TabIndex = 5
        '
        'lblPasswordValidate
        '
        Me.lblPasswordValidate.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordValidate.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordValidate.Location = New System.Drawing.Point(173, 302)
        Me.lblPasswordValidate.Name = "lblPasswordValidate"
        Me.lblPasswordValidate.Size = New System.Drawing.Size(242, 18)
        Me.lblPasswordValidate.TabIndex = 31
        Me.lblPasswordValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPasswordValidate.Visible = False
        '
        'lblEmailValidate
        '
        Me.lblEmailValidate.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailValidate.ForeColor = System.Drawing.Color.Black
        Me.lblEmailValidate.Location = New System.Drawing.Point(176, 166)
        Me.lblEmailValidate.Name = "lblEmailValidate"
        Me.lblEmailValidate.Size = New System.Drawing.Size(238, 18)
        Me.lblEmailValidate.TabIndex = 32
        Me.lblEmailValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEmailValidate.Visible = False
        '
        'ttPasswordRequirements
        '
        Me.ttPasswordRequirements.AutoPopDelay = 5000
        Me.ttPasswordRequirements.InitialDelay = 100
        Me.ttPasswordRequirements.ReshowDelay = 100
        Me.ttPasswordRequirements.ToolTipTitle = "Password Requirements"
        '
        'lblOTPStatus
        '
        Me.lblOTPStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblOTPStatus.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTPStatus.Location = New System.Drawing.Point(38, 555)
        Me.lblOTPStatus.Name = "lblOTPStatus"
        Me.lblOTPStatus.Size = New System.Drawing.Size(372, 25)
        Me.lblOTPStatus.TabIndex = 33
        Me.lblOTPStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(452, 604)
        Me.Controls.Add(Me.lblOTPStatus)
        Me.Controls.Add(Me.lblEmailValidate)
        Me.Controls.Add(Me.lblPasswordValidate)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.lblAlertRePass)
        Me.Controls.Add(Me.lblTermsServices)
        Me.Controls.Add(Me.chkTermsServices)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marvelous Masters"
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSignUp As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTermsServices As Label
    Friend WithEvents chkTermsServices As CheckBox
    Friend WithEvents Database_omcDataSet As database_omcDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As database_omcDataSetTableAdapters.usersTableAdapter
    Friend WithEvents lblAlertRePass As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents lblPasswordValidate As Label
    Friend WithEvents lblEmailValidate As Label
    Friend WithEvents lblOTPStatus As Label
    Friend WithEvents ttTandS As ToolTip
    Friend WithEvents ttPasswordRequirements As ToolTip
End Class
