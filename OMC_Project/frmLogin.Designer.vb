<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chkRemember = New System.Windows.Forms.CheckBox()
        Me.lblForgotPass = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblMsgAccount = New System.Windows.Forms.Label()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.Database_omcDataSet = New OMC_Project.database_omcDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New OMC_Project.database_omcDataSetTableAdapters.usersTableAdapter()
        Me.lblOTPStatus = New System.Windows.Forms.Label()
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Calisto MT", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTitle.Location = New System.Drawing.Point(78, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(286, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "LOGIN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(34, 139)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(375, 25)
        Me.txtEmail.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email Address*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password*"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(34, 217)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(375, 25)
        Me.txtPassword.TabIndex = 1
        '
        'chkRemember
        '
        Me.chkRemember.AutoSize = True
        Me.chkRemember.BackColor = System.Drawing.Color.Transparent
        Me.chkRemember.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRemember.Location = New System.Drawing.Point(34, 271)
        Me.chkRemember.Name = "chkRemember"
        Me.chkRemember.Size = New System.Drawing.Size(123, 22)
        Me.chkRemember.TabIndex = 2
        Me.chkRemember.Text = "Remember &Me"
        Me.chkRemember.UseVisualStyleBackColor = False
        '
        'lblForgotPass
        '
        Me.lblForgotPass.AutoSize = True
        Me.lblForgotPass.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotPass.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPass.Location = New System.Drawing.Point(281, 272)
        Me.lblForgotPass.Name = "lblForgotPass"
        Me.lblForgotPass.Size = New System.Drawing.Size(123, 18)
        Me.lblForgotPass.TabIndex = 7
        Me.lblForgotPass.Text = "Forgot Password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.GreenYellow
        Me.btnLogin.Location = New System.Drawing.Point(169, 325)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(112, 42)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "&LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblMsgAccount
        '
        Me.lblMsgAccount.AutoSize = True
        Me.lblMsgAccount.BackColor = System.Drawing.Color.Transparent
        Me.lblMsgAccount.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgAccount.Location = New System.Drawing.Point(101, 444)
        Me.lblMsgAccount.Name = "lblMsgAccount"
        Me.lblMsgAccount.Size = New System.Drawing.Size(164, 18)
        Me.lblMsgAccount.TabIndex = 9
        Me.lblMsgAccount.Text = "Don’t have an account?"
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lblSignUp.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.Location = New System.Drawing.Point(288, 444)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(60, 18)
        Me.lblSignUp.TabIndex = 10
        Me.lblSignUp.Text = "Sign Up"
        '
        'Database_omcDataSet
        '
        Me.Database_omcDataSet.DataSetName = "database_omcDataSet"
        Me.Database_omcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'lblOTPStatus
        '
        Me.lblOTPStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblOTPStatus.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTPStatus.Location = New System.Drawing.Point(37, 381)
        Me.lblOTPStatus.Name = "lblOTPStatus"
        Me.lblOTPStatus.Size = New System.Drawing.Size(372, 25)
        Me.lblOTPStatus.TabIndex = 11
        Me.lblOTPStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOTPStatus.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(442, 490)
        Me.Controls.Add(Me.lblOTPStatus)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.lblMsgAccount)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblForgotPass)
        Me.Controls.Add(Me.chkRemember)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marvelous Masters"
        CType(Me.Database_omcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkRemember As CheckBox
    Friend WithEvents lblForgotPass As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblMsgAccount As Label
    Friend WithEvents lblSignUp As Label
    Friend WithEvents Database_omcDataSet As database_omcDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As database_omcDataSetTableAdapters.usersTableAdapter
    Friend WithEvents lblOTPStatus As Label
End Class
