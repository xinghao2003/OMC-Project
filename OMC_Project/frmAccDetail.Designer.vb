<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccDetail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_omcDataSet = New OMC_Project.database_omcDataSet()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.rtxtAddress = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ttEdit = New System.Windows.Forms.ToolTip(Me.components)
        Me.UsersTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.usersTableAdapter()
        Me.lblPasswordValidate = New System.Windows.Forms.Label()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmailValidate = New System.Windows.Forms.Label()
        Me.lblAlertRePass = New System.Windows.Forms.Label()
        Me.ttPasswordRequirements = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(485, 56)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Profile Picture:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 276)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Birthday Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 361)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Address:"
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "FIRST NAME", True))
        Me.txtFirstName.Location = New System.Drawing.Point(171, 28)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(281, 25)
        Me.txtFirstName.TabIndex = 0
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
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "LAST NAME", True))
        Me.txtLastName.Location = New System.Drawing.Point(171, 77)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(281, 25)
        Me.txtLastName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "EMAIL", True))
        Me.txtEmail.Location = New System.Drawing.Point(171, 126)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(281, 25)
        Me.txtEmail.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "ENCRYPTED PASSWORD", True))
        Me.txtPassword.Location = New System.Drawing.Point(171, 175)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(281, 25)
        Me.txtPassword.TabIndex = 3
        Me.ttPasswordRequirements.SetToolTip(Me.txtPassword, "* Minimum 8 characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Contain atleast :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 small letter, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 capital le" &
        "tter, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 numbers, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 special symbols." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Space are not allowed")
        '
        'dtpBirthday
        '
        Me.dtpBirthday.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "BIRTHDAY DATE", True))
        Me.dtpBirthday.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsersBindingSource, "BIRTHDAY DATE", True))
        Me.dtpBirthday.Location = New System.Drawing.Point(171, 273)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(281, 25)
        Me.dtpBirthday.TabIndex = 5
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.Snow
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.UsersBindingSource, "PROFILE PICTURE", True))
        Me.picProfile.Location = New System.Drawing.Point(483, 79)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(168, 170)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 14
        Me.picProfile.TabStop = False
        Me.ttEdit.SetToolTip(Me.picProfile, "Double Click to Upload Photo")
        '
        'rtxtAddress
        '
        Me.rtxtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "ADDRESS", True))
        Me.rtxtAddress.Location = New System.Drawing.Point(171, 322)
        Me.rtxtAddress.Name = "rtxtAddress"
        Me.rtxtAddress.Size = New System.Drawing.Size(481, 96)
        Me.rtxtAddress.TabIndex = 6
        Me.rtxtAddress.Text = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.GreenYellow
        Me.btnSave.Location = New System.Drawing.Point(252, 435)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 25)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClose.Location = New System.Drawing.Point(363, 435)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 25)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ttEdit
        '
        Me.ttEdit.ToolTipTitle = "Edit"
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'lblPasswordValidate
        '
        Me.lblPasswordValidate.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordValidate.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordValidate.Location = New System.Drawing.Point(171, 156)
        Me.lblPasswordValidate.Name = "lblPasswordValidate"
        Me.lblPasswordValidate.Size = New System.Drawing.Size(277, 18)
        Me.lblPasswordValidate.TabIndex = 32
        Me.lblPasswordValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPasswordValidate.Visible = False
        '
        'txtPassword2
        '
        Me.txtPassword2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "ENCRYPTED PASSWORD", True))
        Me.txtPassword2.Enabled = False
        Me.txtPassword2.Location = New System.Drawing.Point(171, 224)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(281, 25)
        Me.txtPassword2.TabIndex = 4
        Me.ttPasswordRequirements.SetToolTip(Me.txtPassword2, "* Minimum 8 characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Contain atleast :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 small letter, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 capital le" &
        "tter, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 numbers, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2 special symbols." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Space are not allowed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Re-enter Password: "
        '
        'lblEmailValidate
        '
        Me.lblEmailValidate.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailValidate.ForeColor = System.Drawing.Color.Black
        Me.lblEmailValidate.Location = New System.Drawing.Point(174, 107)
        Me.lblEmailValidate.Name = "lblEmailValidate"
        Me.lblEmailValidate.Size = New System.Drawing.Size(274, 18)
        Me.lblEmailValidate.TabIndex = 36
        Me.lblEmailValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEmailValidate.Visible = False
        '
        'lblAlertRePass
        '
        Me.lblAlertRePass.BackColor = System.Drawing.Color.Transparent
        Me.lblAlertRePass.ForeColor = System.Drawing.Color.Black
        Me.lblAlertRePass.Location = New System.Drawing.Point(171, 205)
        Me.lblAlertRePass.Name = "lblAlertRePass"
        Me.lblAlertRePass.Size = New System.Drawing.Size(277, 18)
        Me.lblAlertRePass.TabIndex = 35
        Me.lblAlertRePass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAlertRePass.Visible = False
        '
        'ttPasswordRequirements
        '
        Me.ttPasswordRequirements.AutoPopDelay = 5000
        Me.ttPasswordRequirements.InitialDelay = 100
        Me.ttPasswordRequirements.ReshowDelay = 100
        Me.ttPasswordRequirements.ToolTipTitle = "Password Requirements"
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(171, 58)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(279, 18)
        Me.lblLastName.TabIndex = 37
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLastName.Visible = False
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(171, 9)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(278, 18)
        Me.lblFirstName.TabIndex = 38
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirstName.Visible = False
        '
        'frmAccDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(676, 488)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblEmailValidate)
        Me.Controls.Add(Me.lblAlertRePass)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPasswordValidate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rtxtAddress)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAccDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Detail"
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents rtxtAddress As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ttEdit As ToolTip
    Friend WithEvents Database_omcDataSet As database_omcDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As database_omcDataSetTableAdapters.usersTableAdapter
    Friend WithEvents lblPasswordValidate As Label
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEmailValidate As Label
    Friend WithEvents lblAlertRePass As Label
    Friend WithEvents ttPasswordRequirements As ToolTip
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
End Class
