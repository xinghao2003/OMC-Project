Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.ComponentModel

Public Class frmLogin
    Friend loginType As Integer = -1
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database_omcDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database_omcDataSet.users)
        Dim strName As String
        If loginType = 0 Then
            strName = "USER LOGIN"
        ElseIf loginType = 1 Then
            lblMsgAccount.Visible = False
            lblSignUp.Visible = False
            lblForgotPass.Visible = False
            chkRemember.Visible = False
            strName = "SELLER LOGIN"
        Else
            strName = "LOGIN"
        End If
        lblTitle.Text = strName
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userEmail As String = txtEmail.Text.Trim.ToLower
        Dim password As String = txtPassword.Text.Trim
        Dim queryAccountType = From users In Database_omcDataSet.users
                               Where users.EMAIL.ToLower = userEmail
                               Select users.ACCOUNT_TYPE
        Dim queryPassword = From users In Database_omcDataSet.users
                            Where users.EMAIL.ToLower = userEmail
                            Select users.ENCRYPTED_PASSWORD
        Dim queryID = From users In Database_omcDataSet.users
                      Where users.EMAIL.ToLower = userEmail
                      Select users.ID
        Dim queryFirstName = From users In Database_omcDataSet.users
                             Where users.EMAIL.ToLower = userEmail
                             Select users.FIRST_NAME
        If queryPassword.Count > 0 Or queryAccountType.Count > 0 Then
            If queryAccountType.ToArray(0) = loginType Or queryAccountType.ToArray(0) = 888 Then
                If encrypt(password) = queryPassword.ToArray(0) Then
                    lblOTPStatus.Text = "OTP Verification is in process"
                    lblOTPStatus.ForeColor = Color.Green
                    Dim otpVerify As Boolean = False
                    If queryAccountType.ToArray(0) = 888 Then
                        otpVerify = True
                    Else
                        otpVerify = frmMain.otpVerification(userEmail)
                    End If
                    If otpVerify Then
                        lblOTPStatus.Text = "OTP Verification Successful"
                        MsgBox("Login Successful", vbOKOnly, "Login")
                        frmMain.userID = queryID.ToArray(0)
                        frmMain.userName = queryFirstName.ToArray(0)
                        Select Case loginType
                            Case 0
                                If chkRemember.Checked Then
                                    frmMain.rememberMe = True
                                End If
                                frmUser.Show()
                                Me.Hide()
                            'frmUser.userID = queryID.ToArray(0)
                            'frmUser.userName = userEmail
                            Case 1
                                frmMain.rememberMe = False
                                'frmSeller.userID = queryID.ToArray(0)
                                'frmSeller.userName = userEmail
                                frmSeller.Show()
                                Me.Hide()
                        End Select
                    Else
                        lblOTPStatus.Text = "Failed, Please login again!"
                        lblOTPStatus.ForeColor = Color.Red
                        MsgBox("Login failed, Please log in again!", vbCritical + vbOKOnly, "Login")
                    End If
                Else
                    MsgBox("Incorrect Password", vbOKOnly, "Login")
                End If
            Else
                Select Case loginType
                    Case 0
                        MsgBox("Please login using seller page!", vbOKOnly, "Login")
                    Case 1
                        MsgBox("Please login using user page!", vbOKOnly, "Login")
                End Select
            End If
        Else
            MsgBox("Email not found!", vbOKOnly, "Login")
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

    Friend Function createRandomPassword(ByVal PasswordLength As Integer) As String
        Dim _allowedChars As String = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789*$-+?_&=!%{}/"
        Dim randomNumber As New Random()
        Dim chars(PasswordLength - 1) As Char
        Dim allowedCharCount As Integer = _allowedChars.Length
        For i As Integer = 0 To PasswordLength - 1
            chars(i) = _allowedChars.Chars(CInt(Fix((_allowedChars.Length) * randomNumber.NextDouble())))
        Next i
        Return New String(chars)
    End Function

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        Dim userEmail As String = txtEmail.Text.Trim.ToLower
        Dim password As String = txtPassword.Text.Trim
        Dim queryPassword = From users In Database_omcDataSet.users
                            Where users.EMAIL.ToLower = userEmail
                            Select users.ENCRYPTED_PASSWORD
        Dim queryID = From users In Database_omcDataSet.users
                      Where users.EMAIL.ToLower = userEmail
                      Select users.ID
        If queryPassword.Count > 0 Then
            Dim tempPass As String = createRandomPassword(8)
            frmMain.emailProtocol(userEmail, "Your temporary password is " & tempPass, , "An email contain one-time password was sent! Please check your mailbox!")
            Dim result As String = InputBox("Please input your temporary password here: ", "Forgot Password")
            If result.Trim = tempPass Then
                MsgBox("Login successful, Please change your password!", vbOKOnly, "Forgot Password")
                frmAccDetail.userID = queryID.ToArray(0)
                frmAccDetail.forgotPass = True
                frmAccDetail.ShowDialog()
                MsgBox("Please login using your new password!", vbOKOnly, "Forgot Password")
            Else
                MsgBox("Incorrect temporary password!", vbCritical + vbOKOnly, "Forgot Password")
            End If
        Else
            MsgBox("Email not found!", vbOKOnly, "Forgot Password")
        End If
    End Sub

    Private Sub frmLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Show()
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        frmSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.UsersTableAdapter.Fill(Me.Database_omcDataSet.users)
    End Sub
End Class