Public Class frmPayment
    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        Dim expiredDataCompare As String = txtExpiredDate.Text.Replace("/", "").Replace(" ", "")
        Dim cvvCompare As String = txtExpiredDate.Text.Replace(" ", "")
        If expiredDataCompare <> "" And cvvCompare <> "" Then
            'To-do linking to official bank API to validate card details and perform real transaction
            frmShoppingCart.orderDone()
            Me.Close()
        ElseIf rbtnPayPal.Checked Then
            'To-do linking to Paypal perform real transaction
            frmShoppingCart.orderDone()
            Me.Close()
        ElseIf rbtnBank.Checked And cboBank.SelectedIndex <> -1 Then
            'To-do linking with official bank API to perform online banking transfer
            frmShoppingCart.orderDone()
            Me.Close()
        Else
            MsgBox("Please completed all information required!", vbCritical + vbOKOnly, "Marvelous Masters")
        End If
    End Sub

    Private Sub btnCancelPayment_Click(sender As Object, e As EventArgs) Handles btnCancelPayment.Click
        MsgBox("Payment Cancel", vbOKOnly, "Marvelous Master")
        Me.Close()
    End Sub

    Private Sub rbtnCard_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCard.CheckedChanged
        checkPaymentType()
    End Sub

    Private Sub rbtnOnline_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOnline.CheckedChanged
        checkPaymentType()
    End Sub

    Private Sub rbtnBank_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBank.CheckedChanged
        checkPaymentMethod()
    End Sub

    Private Sub rbtnPayPal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPayPal.CheckedChanged
        checkPaymentMethod()
    End Sub

    Private Sub rbtnVisa_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnVisa.CheckedChanged
        checkPaymentMethod()
    End Sub

    Private Sub rbtnMaster_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMaster.CheckedChanged
        checkPaymentMethod()
    End Sub

    Sub checkPaymentMethod()
        cboBank.Enabled = False
        cboBank.SelectedIndex = -1
        txtCardHolderName.Enabled = False
        txtCardHolderName.Clear()
        txtCardBankNumber.Enabled = False
        txtCardBankNumber.Clear()
        If rbtnVisa.Checked Or rbtnMaster.Checked Then
            txtCardHolderName.Enabled = True
            txtCardBankNumber.Enabled = True
        ElseIf rbtnBank.Checked Then
            cboBank.Enabled = True
        End If
    End Sub

    Sub checkPaymentType()
        rbtnVisa.Enabled = False
        rbtnMaster.Enabled = False
        rbtnPayPal.Enabled = False
        rbtnBank.Enabled = False
        If rbtnCard.Checked Then
            rbtnVisa.Enabled = True
            rbtnMaster.Enabled = True
            rbtnVisa.Checked = True
        ElseIf rbtnOnline.Checked Then
            rbtnPayPal.Enabled = True
            rbtnBank.Enabled = True
            rbtnPayPal.Checked = True
        End If
    End Sub

    Private Function cardValidate(ByVal creditCardNumber As String) As String
        If creditCardNumber.Length < 16 Then
            cardValidate = "Too short required 16 numbers"
        Else
            Dim Int(15) As Integer
            Dim x, num, sun As Integer
            For x = 0 To 15
                num = creditCardNumber.Substring(x, 1)
                If (x + 1) Mod 2 <> 0 Then
                    Int(x) = num * 2
                Else
                    Int(x) = num
                End If
            Next
            For x = 0 To 15
                If (Int(x) > 9) Then
                    Int(x) = (Int(x) Mod 10) + 1
                End If
                sun += Int(x)
            Next
            If (sun Mod 10 = 0) Then
                cardValidate = "Valid"
            Else
                cardValidate = "Not valid"
            End If
        End If
    End Function

    Private Sub txtCardBankNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCardBankNumber.TextChanged
        lblNameResult.Text = ""
        lblValidateResult.Text = ""
        txtExpiredDate.Enabled = False
        txtExpiredDate.Clear()
        txtCVV.Enabled = False
        txtCVV.Clear()
        If txtCardBankNumber.Enabled = True Then
            If txtCardHolderName.Text.Trim = "" Then
                lblNameResult.Text = "Name are required"
            End If
            Dim result As String = cardValidate(txtCardBankNumber.Text.Replace("-", "").Replace(" ", ""))
            lblValidateResult.Text = result
            If result = "Valid" And txtCardHolderName.Text.Trim <> "" Then
                txtExpiredDate.Enabled = True
                txtCVV.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtExpiredDate_TextChanged(sender As Object, e As EventArgs) Handles txtExpiredDate.TextChanged
        'To-do expired data check
    End Sub

    Private Sub txtCVV_TextChanged(sender As Object, e As EventArgs) Handles txtCVV.TextChanged
        'To-do CVV check
    End Sub

    Private Sub txtCardHolderName_TextChanged(sender As Object, e As EventArgs) Handles txtCardHolderName.TextChanged
        lblNameResult.Text = ""
        If lblValidateResult.Text <> "" Then
            lblValidateResult.Text = lblValidateResult.Text
        Else
            lblValidateResult.Text = ""
        End If
        txtExpiredDate.Enabled = False
        txtExpiredDate.Clear()
        txtCVV.Enabled = False
        txtCVV.Clear()
        If txtCardBankNumber.Enabled = True Then
            If txtCardHolderName.Text.Trim <> "" Then
                lblNameResult.Text = ""
            ElseIf txtCardHolderName.Text.Trim = "" Then
                lblNameResult.Text = "Name are required"
            End If
            Dim result As String = cardValidate(txtCardBankNumber.Text.Replace("-", "").Replace(" ", ""))
            If result = "Valid" And txtCardHolderName.Text.Trim <> "" Then
                txtExpiredDate.Enabled = True
                txtCVV.Enabled = True
            End If
        End If
    End Sub
End Class
