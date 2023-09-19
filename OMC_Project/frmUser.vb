Imports System.ComponentModel

Public Class frmUser
    Friend userID As String = -1
    Friend userName As String = "USER"
    Friend shoppingCart() = {}

    Private Sub doFormatting()
        lblPrice.Text = Format(Val(lblPrice.Text), "RM 0.00")
        lblDiscount.Text = Val(lblDiscount.Text) & "% Discount"
        lblPriceAfterDiscount.Text = "Price after discount: " & Format(Val(lblPrice.Text.Split(" ")(1)) * (100 - Val(lblDiscount.Text)) / 100, "RM 0.00")
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database_omcDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database_omcDataSet.users)
        'TODO: This line of code loads data into the 'Database_omcDataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Database_omcDataSet.inventory)
        userID = frmMain.userID
        userName = frmMain.userName
        btnUserDetail.Text = userName
        Dim query = From users In Database_omcDataSet.users
                    Where users.ID = userID
                    Select users
        UsersBindingSource.DataSource = query.AsDataView
        doFormatting()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strFind As String
        strFind = UCase(txtSearch.Text)
        Dim query = From inventory In Database_omcDataSet.inventory
                    Where inventory.ITEM_NAME.ToUpper Like "*" & strFind & "*"
                    Select inventory
        InventoryBindingSource.DataSource = query.AsDataView
        doFormatting()
    End Sub

    Private Sub btnUserDetail_Click(sender As Object, e As EventArgs) Handles btnUserDetail.Click
        frmAccDetail.userID = userID
        frmAccDetail.ShowDialog()
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim quantity As Integer = nudQuantity.Value
        If quantity <> 0 Then
            Dim queryID = From inventory In Database_omcDataSet.inventory
                          Where inventory.ITEM_NAME.ToUpper = lblItemName.Text.ToUpper
                          Select inventory.ID
            Dim itemID As Integer = Val(queryID.ToArray(0))
            Dim finalPrice As Double = Val(lblPrice.Text.Split(" ")(1)) * (100 - Val(lblDiscount.Text)) / 100 * quantity
            Dim queryWeight = From inventory In Database_omcDataSet.inventory
                              Where inventory.ITEM_NAME.ToUpper = lblItemName.Text.ToUpper
                              Select inventory.WEIGHT
            Dim finalWeight As Double = Val(queryWeight.ToArray(0)) * quantity
            Dim currentItemData() As String = {itemID, quantity, finalPrice, finalWeight, queryWeight.ToArray(0)}
            'MsgBox(shoppingCart.Length)
            If shoppingCart.Length <> 0 Then
                ReDim Preserve shoppingCart(shoppingCart.Length)
                shoppingCart(shoppingCart.Length - 1) = currentItemData
            Else
                ReDim Preserve shoppingCart(0)
                shoppingCart(0) = currentItemData
            End If
            'To-do : Make storing shopping cart data possible

            MsgBox("Added to Shopping Cart!", vbExclamation + vbOKOnly, "Marvelous Master")
        Else
            MsgBox("Please select atleast 1 quantity!", vbCritical + vbOKOnly, "Marvelous Master")
        End If
    End Sub

    Private Sub btnShoppingCart_Click(sender As Object, e As EventArgs) Handles btnShoppingCart.Click
        If shoppingCart.Length <> 0 Then
            frmShoppingCart.Show()
            Me.Hide()
        Else
            MsgBox("Nothing in your shopping cart!", vbCritical + vbOKOnly, "Marvelous Master")
        End If
    End Sub

    Private Sub btnPreviousItem_Click(sender As Object, e As EventArgs) Handles btnPreviousItem.Click
        InventoryBindingSource.MovePrevious()
        doFormatting()
    End Sub

    Private Sub btnNextItem_Click(sender As Object, e As EventArgs) Handles btnNextItem.Click
        InventoryBindingSource.MoveNext()
        doFormatting()
    End Sub

    Private Sub frmUser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        txtSearch.Text = ""
    End Sub
End Class