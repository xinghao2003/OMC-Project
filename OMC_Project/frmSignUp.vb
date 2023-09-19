Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Public Class frmSignUp

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database_omcDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database_omcDataSet.users)
        UsersBindingSource.AddNew()
    End Sub

    Friend Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 2,
    Optional ByVal numLower As Integer = 2,
    Optional ByVal numNumbers As Integer = 2,
    Optional ByVal numSpecial As Integer = 2) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New Regex("[A-Z]")
        Dim lower As New Regex("[a-z]")
        Dim number As New Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Friend Function validateEmail(ByVal email As String) As Boolean
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(email.Trim)
        If Not isValid Then Return False
        Return True
    End Function

    Friend Function validateEmailWithDatabase(ByVal email As String) As Boolean
        Dim queryEmail = From users In Database_omcDataSet.users
                         Where users.EMAIL.ToLower = email.ToLower
                         Select users
        If queryEmail.Count > 0 Then Return False
        Return True
    End Function

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If ValidatePassword(txtPassword.Text) Then
            lblPasswordValidate.Text = "Requirements fulfilled"
            lblPasswordValidate.ForeColor = Color.Green
            txtPassword2.Enabled = True
        Else
            lblPasswordValidate.Text = "Does not fulfill requirements"
            lblPasswordValidate.ForeColor = Color.Red
            txtPassword2.Enabled = False
        End If
    End Sub

    Private Sub txtPassword2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword2.TextChanged
        If txtPassword2.Enabled = True Then
            If txtPassword2.Text <> txtPassword.Text Then
                lblAlertRePass.Text = "Not the same!"
                lblAlertRePass.ForeColor = Color.Red
            Else
                lblAlertRePass.Text = ""
                lblAlertRePass.ForeColor = Color.Green
            End If
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If txtFirstName.Text.Trim = "" Then
            MsgBox("Please enter your first name!", vbCritical + vbOKOnly, "Sign Up")
        ElseIf txtLastName.Text.Trim = "" Then
            MsgBox("Please enter your last name!", vbCritical + vbOKOnly, "Sign Up")
        ElseIf txtEmail.Text.Trim = "" Then
            MsgBox("Please enter your email!", vbCritical + vbOKOnly, "Sign Up")
        ElseIf validateEmail(txtEmail.Text.Trim) = False Then
            MsgBox("Incorrect email format!", vbCritical + vbOKOnly, "Sign Up")
        ElseIf validateEmailWithDatabase(txtEmail.Text.Trim) = False Then
            MsgBox("Email is already being used!", vbCritical + vbOKOnly, "Sign Up")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please enter your password!", vbCritical + vbOKOnly, "Sign Up")
        ElseIf validatePassword(txtPassword.Text) = False Then
            MsgBox("Password does not meet the requirements!", vbCritical + vbOKOnly, "Sign Up")
        ElseIf txtPassword2.Text = "" Then
            MsgBox("Please re-enter your password!", vbCritical + vbOKOnly, "Sign Up")
        ElseIf txtPassword2.Text <> txtPassword.Text Then
            MsgBox("Password entered is not the same!", vbCritical + vbOKOnly, "Sign Up")
        Else
            txtEmail.Text = txtEmail.Text.Trim.ToLower
            lblOTPStatus.Text = "OTP Verification is in process"
            lblOTPStatus.ForeColor = Color.Green
            Dim otpVerify As Boolean = frmMain.otpVerification(txtEmail.Text)
            If otpVerify Then
                txtType.Visible = True
                txtType.Text = "0"
                txtFirstName.Text = txtFirstName.Text.Trim.ToUpper
                txtLastName.Text = txtLastName.Text.Trim.ToUpper
                txtPassword.Text = encrypt(txtPassword.Text)
                txtPassword2.Text = encrypt(txtPassword2.Text)
                Validate()
                UsersBindingSource.EndEdit()
                UsersTableAdapter.Update(Database_omcDataSet.users.GetChanges)
                UsersTableAdapter.Fill(Database_omcDataSet.users)
                txtType.Visible = False
                lblOTPStatus.Text = "OTP Verification Successful"
                Me.Close()
                MsgBox("Sign Up Success", vbOKOnly, "Sign Up")
            Else
                lblOTPStatus.Text = "Failed, Please sign up again!"
                lblOTPStatus.ForeColor = Color.Red
                MsgBox("Sign Up Failed, Please sign up again!", vbCritical + vbOKOnly, "Sign Up")
            End If
        End If
    End Sub
    Private Function encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Private Sub lblTermsServices_Click(sender As Object, e As EventArgs) Handles lblTermsServices.Click
        Process.Start("https://www.xinghao2003.com/terms.html")
        chkTermsServices.Enabled = True
    End Sub

    Private Sub chkTermsServices_Click(sender As Object, e As EventArgs) Handles chkTermsServices.Click
        If chkTermsServices.Enabled = False Then
            MsgBox("Please read the terms and services!", vbCritical + vbOKOnly, "Terms and Services")
        End If
    End Sub

    Private Sub chkTermsServices_CheckedChanged(sender As Object, e As EventArgs) Handles chkTermsServices.CheckedChanged
        If chkTermsServices.Checked Then
            btnSignUp.Enabled = True
        Else
            btnSignUp.Enabled = False
        End If
    End Sub

    Private Sub frmSignUp_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLogin.Show()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If validateEmail(txtEmail.Text) Then
            If validateEmailWithDatabase(txtEmail.Text) Then
                lblEmailValidate.Text = "Valid"
                lblEmailValidate.ForeColor = Color.Green
            Else
                lblEmailValidate.Text = "This email is already being used"
                lblEmailValidate.ForeColor = Color.Red
            End If
        Else
            lblEmailValidate.Text = "Incorrect Format"
            lblEmailValidate.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        lblEmailValidate.Visible = True
        lblEmailValidate.Text = ""
    End Sub

    Private Sub txtPassword2_Enter(sender As Object, e As EventArgs) Handles txtPassword2.Enter
        lblAlertRePass.Visible = True
        lblAlertRePass.Text = ""
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        lblPasswordValidate.Visible = True
        lblPasswordValidate.Text = ""
    End Sub

End Class