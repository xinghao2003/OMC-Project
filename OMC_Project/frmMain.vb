Imports System.ComponentModel
Imports System.Net.Mail

Public Class frmMain

    Friend rememberMe As Boolean = False
    Friend userID As Integer = -1
    Friend userName As String = "DEFAULT"

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        If rememberMe = True Then
            frmUser.Show()
            Me.Hide()
        Else
            'Type 0 : User
            frmLogin.Close()
            frmLogin.loginType = 0
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        'Type 1 : Seller / Admin
        frmLogin.Close()
        frmLogin.loginType = 1
        frmLogin.Show()
        Me.Hide()
    End Sub
    Private Sub lblCopyright_DoubleClick(sender As Object, e As EventArgs) Handles lblCopyright.DoubleClick
        frmAbout.ShowDialog()
    End Sub

    Private Sub picLogo_DoubleClick(sender As Object, e As EventArgs) Handles picLogo.DoubleClick
        frmAbout.ShowDialog()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim result As MsgBoxResult = MsgBox("Do you want to exit?", vbYesNo, "Marvelous Master")
        If result = MsgBoxResult.Yes Then
            MsgBox("Thank you for using!", vbOKOnly, "Marvelous Master")
        Else
            e.Cancel = True
        End If
    End Sub

    Friend Function emailProtocol(ByVal receiver As String, ByVal message As String,
                                  Optional ByVal subject As String = "Marvelous Masters",
                                  Optional ByVal succesfulMsg As String = "Mail Sent",
                                  Optional ByVal sender As String = "email@marvelous.com") As Boolean
        Try
            Dim smtpServer As New SmtpClient
            Dim eMail As New MailMessage()
            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New Net.NetworkCredential("marvelousmastersenterprise@gmail.com", "LQ.Lg`hassj2Vx%6")
            'smtpServer.Credentials = New Net.NetworkCredential("89c5fbda31d9d7", "3c6db3733b3698")
            smtpServer.Port = 587
            smtpServer.EnableSsl = True
            smtpServer.Host = "smtp.gmail.com"
            'smtpServer.Host = "smtp.mailtrap.io"

            eMail = New MailMessage()
            eMail.From = New MailAddress(sender)
            eMail.To.Add(receiver)
            eMail.Subject = subject
            eMail.IsBodyHtml = False
            eMail.Body = message
            smtpServer.Send(eMail)
            MsgBox(succesfulMsg, vbOKOnly, "Email Service")
            Return True
        Catch error_t As Exception
            MsgBox(error_t.ToString)
            Return False
        End Try
    End Function

    Friend Function otpVerification(ByVal receiver As String) As Boolean
        Dim randomGenerator As New Random
        Dim otp As String = randomGenerator.Next(1000, 10000).ToString
        Dim message As String = "Your otp is " & otp
        emailProtocol(receiver, message, , "OTP sent. Please check your email!")
        Dim result As String = InputBox("Please input your otp here: ", "OTP Verification")
        If result.Trim = otp Then
            MsgBox("OTP verified", vbOKOnly, "OTP Verification")
            Return True
        Else
            MsgBox("Incorrect OTP!", vbCritical + vbOKOnly, "OTP Verification")
            Return False
        End If
    End Function
End Class
