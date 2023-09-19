Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class frmAccDetail

    Friend userID As String = -1
    Friend forgotPass As Boolean = False

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

    Private Function decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Private Sub frmAccDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database_omcDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database_omcDataSet.users)
        Dim query = From users In Database_omcDataSet.users
                    Where users.ID = userID
                    Select users
        UsersBindingSource.DataSource = query.AsDataView
        txtPassword.Text = decrypt(txtPassword.Text)
        txtPassword2.Clear()
        lblPasswordValidate.Text = ""
        lblAlertRePass.Text = ""
        txtPassword2.Enabled = False
        If forgotPass Then
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            txtEmail.Enabled = False
            dtpBirthday.Enabled = False
            rtxtAddress.Enabled = False
            picProfile.Enabled = False
        End If
    End Sub

    Private Sub picProfile_DoubleClick(sender As Object, e As EventArgs) Handles picProfile.DoubleClick
        Dim openPhoto As New OpenFileDialog With {
            .Filter = ("Picture File |*.jpg;*.jpeg;*.gif;*.png")
        }
        openPhoto.ShowDialog()
        picProfile.ImageLocation = openPhoto.FileName
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lblFirstName.Visible Or lblLastName.Visible Or lblEmailValidate.Visible Or lblPasswordValidate.Visible Or lblAlertRePass.Visible Then
            If txtFirstName.Text.Trim = "" Then
                MsgBox("Please fillup your first name!", vbCritical + vbOKOnly, "Account Detail")
            ElseIf txtLastName.Text.Trim = "" Then
                MsgBox("Please fillup your last name!", vbCritical + vbOKOnly, "Account Detail")
            ElseIf lblEmailValidate.Text = "Email required" Then
                MsgBox("Please fillup your email address!", vbCritical + vbOKOnly, "Account Detail")
            ElseIf lblEmailValidate.Text = "Incorrect Format" Then
                MsgBox("Please use correct email address!", vbCritical + vbOKOnly, "Account Detail")
            ElseIf lblEmailValidate.Text = "This email is already being used" Then
                MsgBox("Please use another email address!", vbCritical + vbOKOnly, "Account Detail")
            ElseIf lblPasswordValidate.Text = "Password required" Then
                MsgBox("Please fillup your password!", vbCritical + vbOKOnly, "Account Detail")
            ElseIf lblPasswordValidate.Text = "Does not fulfill requirements" Then
                MsgBox("Please enter valid password!", vbCritical + vbOKOnly, "Account Detail")
            ElseIf lblAlertRePass.Text = "Please re-enter your password" Then
                MsgBox("Please re-enter the password!", vbCritical + vbOKOnly, "Account Detail")
            ElseIf lblAlertRePass.Text = "Not the same!" Then
                MsgBox("Please re-enter the password correctly!", vbCritical + vbOKOnly, "Account Detail")
            Else
                txtPassword.Text = encrypt(txtPassword.Text)
                txtPassword2.Text = encrypt(txtPassword2.Text)
                Validate()
                UsersBindingSource.EndEdit()
                UsersTableAdapter.Update(Database_omcDataSet.users.GetChanges)
                UsersTableAdapter.Fill(Database_omcDataSet.users)
                MsgBox("Account detail saved!", vbOKOnly, "Account Detail")
                Me.Close()
            End If
        Else
            txtPassword.Text = encrypt(txtPassword.Text)
            txtPassword2.Text = txtPassword.Text
            Validate()
            UsersBindingSource.EndEdit()
            UsersTableAdapter.Update(Database_omcDataSet.users.GetChanges)
            UsersTableAdapter.Fill(Database_omcDataSet.users)
            MsgBox("Account detail saved!", vbOKOnly, "Account Detail")
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As MsgBoxResult = MsgBox("Closing without edit?", vbYesNo, "Account Detail")
        If result = MsgBoxResult.Yes Then
            Me.Close()
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

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If txtEmail.Text.Trim <> "" Then
            If validateEmail(txtEmail.Text) Then
                Dim queryEmail = From users In Database_omcDataSet.users
                                 Where users.ID = userID
                                 Select users.EMAIL
                If queryEmail.ToArray(0).ToLower <> txtEmail.Text.ToLower Then
                    If validateEmailWithDatabase(txtEmail.Text) Then
                        lblEmailValidate.Text = "Valid"
                        lblEmailValidate.ForeColor = Color.Green
                    Else
                        lblEmailValidate.Text = "This email is already being used"
                        lblEmailValidate.ForeColor = Color.Red
                    End If
                Else
                    lblEmailValidate.Text = ""
                End If
            Else
                lblEmailValidate.Text = "Incorrect Format"
                lblEmailValidate.ForeColor = Color.Red
            End If
        Else
            lblEmailValidate.Text = "Email required"
            lblEmailValidate.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If ValidatePassword(txtPassword.Text) Then
            lblPasswordValidate.Text = "Requirements fulfilled"
            lblPasswordValidate.ForeColor = Color.Green
            txtPassword2.Enabled = True
            lblAlertRePass.Visible = True
            lblAlertRePass.Text = "Please re-enter your password"
            lblAlertRePass.ForeColor = Color.Red
            txtPassword2.Clear()
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

    Friend Function saveCheck() As Boolean
        Return True
    End Function

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If txtFirstName.Text.Trim = "" Then
            lblFirstName.Text = "First Name should not be empty"
            lblFirstName.ForeColor = Color.Red
        Else
            If lblFirstName.Text <> "" Then
                lblFirstName.Text = ""
            End If
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If txtLastName.Text.Trim = "" Then
            lblLastName.Text = "Last Name should not be empty"
            lblLastName.ForeColor = Color.Red
        Else
            If lblLastName.Text <> "" Then
                lblLastName.Text = ""
            End If
        End If
    End Sub

    Private Sub txtFirstName_Enter(sender As Object, e As EventArgs) Handles txtFirstName.Enter
        lblFirstName.Visible = True
        lblFirstName.Text = ""
    End Sub

    Private Sub txtLastName_Enter(sender As Object, e As EventArgs) Handles txtLastName.Enter
        lblLastName.Visible = True
        lblLastName.Text = ""
    End Sub

    Private Sub txtFirstName_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave
        If txtFirstName.Text.Trim = "" Then
            lblFirstName.Text = "First Name should not be empty"
            lblFirstName.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave
        If txtLastName.Text.Trim = "" Then
            lblLastName.Text = "Last Name should not be empty"
            lblLastName.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text = "" Then
            lblEmailValidate.Text = "Email required"
            lblEmailValidate.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            lblPasswordValidate.Text = "Password required"
            lblPasswordValidate.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtPassword2_Leave(sender As Object, e As EventArgs) Handles txtPassword2.Leave
        If txtPassword2.Text = "" Then
            lblAlertRePass.Text = "Please re-enter your password"
            lblAlertRePass.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub txtPassword2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword2.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
                e.SuppressKeyPress = True
        End Select
    End Sub
End Class