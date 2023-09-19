Imports System.ComponentModel

Public Class frmShoppingCart
    Friend localShoppingCart()
    Friend currentItemIndex As Integer = -1
    Friend totalPrice As Double
    Friend totalWeight As Double
    Private Sub frmShoppingCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database_omcDataSet.order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.Database_omcDataSet.order)
        'TODO: This line of code loads data into the 'Database_omcDataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Database_omcDataSet.inventory)
        localShoppingCart = frmUser.shoppingCart
        currentItemIndex = 0
        Dim firstItem() As String = localShoppingCart(currentItemIndex)
        Dim queryInventory = From inventory In Database_omcDataSet.inventory
                             Where inventory.ID = Val(firstItem(0))
                             Select inventory
        InventoryBindingSource.DataSource = queryInventory.AsDataView
        Dim tempStore As String = lblPrice.Text
        lblPrice.Text = Format(Val(lblPrice.Text), "RM 0.00")
        lblDiscount.Text = lblDiscount.Text & "%"
        lblPriceAfterDiscount.Text = Format(Val(lblPrice.Text.Split(" ")(1)) * (100 - Val(lblDiscount.Text)) / 100, "RM 0.00")
        nudQuantity.Value = firstItem(1)
        lblFinalPrice.Text = Format(Val(firstItem(2)), "RM 0.00")
        totalPrice = 0
        totalWeight = 0
        For Each item In localShoppingCart
            totalWeight += item(3)
            totalPrice += item(2)
        Next
        lblTotalPrice.Text = Format(totalPrice, "RM 0.00")
    End Sub

    Private Sub frmShoppingCart_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    End Sub

    Private Sub frmShoppingCart_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmUser.shoppingCart = localShoppingCart
        frmUser.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        frmPayment.ShowDialog()
    End Sub

    Private Sub btnPreviousItem_Click(sender As Object, e As EventArgs) Handles btnPreviousItem.Click
        If currentItemIndex <> 0 Then
            itemChange(-1)
        End If
    End Sub

    Private Sub btnNextItem_Click(sender As Object, e As EventArgs) Handles btnNextItem.Click
        If currentItemIndex < (localShoppingCart.Length - 1) Then
            itemChange(+1)
        End If
    End Sub

    Sub itemChange(ByVal indexStepping As Integer)
        currentItemIndex += indexStepping
        Dim item() As String = localShoppingCart(currentItemIndex)
        Dim queryInventory = From inventory In Database_omcDataSet.inventory
                             Where inventory.ID = Val(item(0))
                             Select inventory
        InventoryBindingSource.DataSource = queryInventory.AsDataView
        Dim tempStore As String = lblPrice.Text
        lblPrice.Text = Format(Val(lblPrice.Text), "RM 0.00")
        lblDiscount.Text = lblDiscount.Text & "%"
        lblPriceAfterDiscount.Text = Format(Val(lblPrice.Text.Split(" ")(1)) * (100 - Val(lblDiscount.Text)) / 100, "RM 0.00")
        nudQuantity.Value = item(1)
        lblFinalPrice.Text = Format(Val(item(2)), "RM 0.00")
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged
        Dim finalPrice As Double = Val(lblPriceAfterDiscount.Text.Split(" ")(1)) * Val(nudQuantity.Value)
        Dim finalWeight As Double = Val(localShoppingCart(currentItemIndex)(4)) * Val(nudQuantity.Value)
        lblFinalPrice.Text = Format(finalPrice, "RM 0.00")
        localShoppingCart(currentItemIndex)(1) = nudQuantity.Value
        localShoppingCart(currentItemIndex)(2) = finalPrice
        localShoppingCart(currentItemIndex)(3) = finalWeight
        totalPrice = 0
        totalWeight = 0
        For Each item In localShoppingCart
            totalWeight += item(3)
            totalPrice += item(2)
        Next
        lblTotalPrice.Text = Format(totalPrice, "RM 0.00")
    End Sub

    Sub orderDone()
        panelOrder.Visible = True
        OrderBindingSource.AddNew()
        txtOrderUserID.Text = frmUser.userID
        txtOrderPrice.Text = totalPrice
        txtOrderWeight.Text = totalWeight
        For Each item In localShoppingCart
            Dim queryName = From inventory In Database_omcDataSet.inventory
                            Where inventory.ID = Val(item(0))
                            Select inventory.ITEM_NAME
            Dim orderDetail As String = "ID: " & Val(item(0)) & " Item Name: " & queryName.ToArray(0) & " Quantity: " & item(1) & " Price: RM " & item(2) & vbCrLf
            rtxtOrderDetail.Text = rtxtOrderDetail.Text & orderDetail
        Next
        Validate()
        OrderBindingSource.EndEdit()
        OrderTableAdapter.Update(Database_omcDataSet.order.GetChanges)
        OrderTableAdapter.Fill(Database_omcDataSet.order)
        panelOrder.Visible = False
        MsgBox("Order submitted!")
        Me.Close()
    End Sub
End Class