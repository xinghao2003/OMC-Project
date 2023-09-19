<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.rbtnVisa = New System.Windows.Forms.RadioButton()
        Me.rbtnMaster = New System.Windows.Forms.RadioButton()
        Me.rbtnPayPal = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnBank = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtnOnline = New System.Windows.Forms.RadioButton()
        Me.rbtnCard = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCardHolderName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.MaskedTextBox()
        Me.txtExpiredDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPayNow = New System.Windows.Forms.Button()
        Me.btnCancelPayment = New System.Windows.Forms.Button()
        Me.lblValidateResult = New System.Windows.Forms.Label()
        Me.txtCardBankNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblNameResult = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtnVisa
        '
        Me.rbtnVisa.AutoSize = True
        Me.rbtnVisa.Enabled = False
        Me.rbtnVisa.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnVisa.Location = New System.Drawing.Point(20, 38)
        Me.rbtnVisa.Name = "rbtnVisa"
        Me.rbtnVisa.Size = New System.Drawing.Size(61, 21)
        Me.rbtnVisa.TabIndex = 2
        Me.rbtnVisa.TabStop = True
        Me.rbtnVisa.Text = "&VISA"
        Me.rbtnVisa.UseVisualStyleBackColor = True
        '
        'rbtnMaster
        '
        Me.rbtnMaster.AutoSize = True
        Me.rbtnMaster.Enabled = False
        Me.rbtnMaster.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMaster.Location = New System.Drawing.Point(121, 38)
        Me.rbtnMaster.Name = "rbtnMaster"
        Me.rbtnMaster.Size = New System.Drawing.Size(106, 21)
        Me.rbtnMaster.TabIndex = 3
        Me.rbtnMaster.TabStop = True
        Me.rbtnMaster.Text = "&Master Card"
        Me.rbtnMaster.UseVisualStyleBackColor = True
        '
        'rbtnPayPal
        '
        Me.rbtnPayPal.AutoSize = True
        Me.rbtnPayPal.Enabled = False
        Me.rbtnPayPal.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPayPal.Location = New System.Drawing.Point(267, 38)
        Me.rbtnPayPal.Name = "rbtnPayPal"
        Me.rbtnPayPal.Size = New System.Drawing.Size(70, 21)
        Me.rbtnPayPal.TabIndex = 4
        Me.rbtnPayPal.TabStop = True
        Me.rbtnPayPal.Text = "Pa&yPal"
        Me.rbtnPayPal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Snow
        Me.GroupBox1.Controls.Add(Me.rbtnBank)
        Me.GroupBox1.Controls.Add(Me.rbtnVisa)
        Me.GroupBox1.Controls.Add(Me.rbtnMaster)
        Me.GroupBox1.Controls.Add(Me.rbtnPayPal)
        Me.GroupBox1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 96)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Method"
        '
        'rbtnBank
        '
        Me.rbtnBank.AutoSize = True
        Me.rbtnBank.Enabled = False
        Me.rbtnBank.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnBank.Location = New System.Drawing.Point(377, 38)
        Me.rbtnBank.Name = "rbtnBank"
        Me.rbtnBank.Size = New System.Drawing.Size(59, 21)
        Me.rbtnBank.TabIndex = 5
        Me.rbtnBank.TabStop = True
        Me.rbtnBank.Text = "&Bank"
        Me.rbtnBank.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.rbtnOnline)
        Me.Panel1.Controls.Add(Me.rbtnCard)
        Me.Panel1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(31, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 54)
        Me.Panel1.TabIndex = 5
        '
        'rbtnOnline
        '
        Me.rbtnOnline.AutoSize = True
        Me.rbtnOnline.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOnline.Location = New System.Drawing.Point(286, 17)
        Me.rbtnOnline.Name = "rbtnOnline"
        Me.rbtnOnline.Size = New System.Drawing.Size(125, 21)
        Me.rbtnOnline.TabIndex = 1
        Me.rbtnOnline.TabStop = True
        Me.rbtnOnline.Text = "&Online Banking"
        Me.rbtnOnline.UseVisualStyleBackColor = True
        '
        'rbtnCard
        '
        Me.rbtnCard.AutoSize = True
        Me.rbtnCard.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCard.Location = New System.Drawing.Point(42, 17)
        Me.rbtnCard.Name = "rbtnCard"
        Me.rbtnCard.Size = New System.Drawing.Size(145, 21)
        Me.rbtnCard.TabIndex = 0
        Me.rbtnCard.TabStop = True
        Me.rbtnCard.Text = "Credit/&Debit Card"
        Me.rbtnCard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bank "
        '
        'cboBank
        '
        Me.cboBank.Enabled = False
        Me.cboBank.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBank.FormattingEnabled = True
        Me.cboBank.Items.AddRange(New Object() {"Maybank", "Public Bank", "CIMB Bank", "Bank Islam"})
        Me.cboBank.Location = New System.Drawing.Point(229, 201)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(252, 25)
        Me.cboBank.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cardholder Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Card / Bank Number"
        '
        'txtCardHolderName
        '
        Me.txtCardHolderName.Enabled = False
        Me.txtCardHolderName.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardHolderName.Location = New System.Drawing.Point(229, 252)
        Me.txtCardHolderName.Name = "txtCardHolderName"
        Me.txtCardHolderName.Size = New System.Drawing.Size(252, 25)
        Me.txtCardHolderName.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtCVV)
        Me.Panel2.Controls.Add(Me.txtExpiredDate)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(31, 354)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 88)
        Me.Panel2.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(267, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 25)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Upload"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Proof of Payment"
        '
        'txtCVV
        '
        Me.txtCVV.Enabled = False
        Me.txtCVV.Location = New System.Drawing.Point(177, 47)
        Me.txtCVV.Mask = "000"
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(35, 25)
        Me.txtCVV.TabIndex = 10
        '
        'txtExpiredDate
        '
        Me.txtExpiredDate.Enabled = False
        Me.txtExpiredDate.Location = New System.Drawing.Point(37, 47)
        Me.txtExpiredDate.Mask = "00/00"
        Me.txtExpiredDate.Name = "txtExpiredDate"
        Me.txtExpiredDate.Size = New System.Drawing.Size(50, 25)
        Me.txtExpiredDate.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(174, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "CVV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Expired Date"
        '
        'btnPayNow
        '
        Me.btnPayNow.BackColor = System.Drawing.Color.GreenYellow
        Me.btnPayNow.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayNow.ForeColor = System.Drawing.Color.Black
        Me.btnPayNow.Location = New System.Drawing.Point(53, 470)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(154, 54)
        Me.btnPayNow.TabIndex = 12
        Me.btnPayNow.Text = "&Pay Now"
        Me.btnPayNow.UseVisualStyleBackColor = False
        '
        'btnCancelPayment
        '
        Me.btnCancelPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancelPayment.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPayment.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPayment.Location = New System.Drawing.Point(241, 470)
        Me.btnCancelPayment.Name = "btnCancelPayment"
        Me.btnCancelPayment.Size = New System.Drawing.Size(222, 54)
        Me.btnCancelPayment.TabIndex = 13
        Me.btnCancelPayment.Text = "&Cancel Payment"
        Me.btnCancelPayment.UseVisualStyleBackColor = False
        '
        'lblValidateResult
        '
        Me.lblValidateResult.BackColor = System.Drawing.Color.Transparent
        Me.lblValidateResult.Location = New System.Drawing.Point(229, 278)
        Me.lblValidateResult.Name = "lblValidateResult"
        Me.lblValidateResult.Size = New System.Drawing.Size(250, 25)
        Me.lblValidateResult.TabIndex = 15
        Me.lblValidateResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCardBankNumber
        '
        Me.txtCardBankNumber.Enabled = False
        Me.txtCardBankNumber.Location = New System.Drawing.Point(229, 301)
        Me.txtCardBankNumber.Mask = "0000-0000-0000-0000"
        Me.txtCardBankNumber.Name = "txtCardBankNumber"
        Me.txtCardBankNumber.Size = New System.Drawing.Size(250, 25)
        Me.txtCardBankNumber.TabIndex = 8
        '
        'lblNameResult
        '
        Me.lblNameResult.BackColor = System.Drawing.Color.Transparent
        Me.lblNameResult.Location = New System.Drawing.Point(229, 229)
        Me.lblNameResult.Name = "lblNameResult"
        Me.lblNameResult.Size = New System.Drawing.Size(250, 25)
        Me.lblNameResult.TabIndex = 19
        Me.lblNameResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(515, 560)
        Me.Controls.Add(Me.lblNameResult)
        Me.Controls.Add(Me.txtCardBankNumber)
        Me.Controls.Add(Me.lblValidateResult)
        Me.Controls.Add(Me.btnCancelPayment)
        Me.Controls.Add(Me.btnPayNow)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtCardHolderName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboBank)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbtnVisa As RadioButton
    Friend WithEvents rbtnMaster As RadioButton
    Friend WithEvents rbtnPayPal As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbtnOnline As RadioButton
    Friend WithEvents rbtnCard As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboBank As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCardHolderName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPayNow As Button
    Friend WithEvents btnCancelPayment As Button
    Friend WithEvents rbtnBank As RadioButton
    Friend WithEvents lblValidateResult As Label
    Friend WithEvents txtExpiredDate As MaskedTextBox
    Friend WithEvents txtCVV As MaskedTextBox
    Friend WithEvents txtCardBankNumber As MaskedTextBox
    Friend WithEvents lblNameResult As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
End Class
