Imports System.IO

Public Class frmSeller
    Friend userID As String = -1
    Friend userName As String = "SELLER"
    Friend invEditStatus As Integer = -1
    Private Sub frmSeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database_omcDataSet.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.Database_omcDataSet.sales)
        'TODO: This line of code loads data into the 'Database_omcDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database_omcDataSet.users)
        'TODO: This line of code loads data into the 'Database_omcDataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Database_omcDataSet.inventory)
        'TODO: This line of code loads data into the 'Database_omcDataSet.order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.Database_omcDataSet.order)
        'TODO: This line of code loads data into the 'Database_omcDataSet.issue' table. You can move, or remove it, as needed.
        Me.IssueTableAdapter.Fill(Me.Database_omcDataSet.issue)
        'TODO: This line of code loads data into the 'TestDataSet.test' table. You can move, or remove it, as needed.
        userID = frmMain.userID
        userName = frmMain.userName
        lblSellerName.Text = userName
        Dim queryOrder = From order In Database_omcDataSet.order
                         Where order.IsSTATUSNull
                         Select order
        OrderBindingSource.DataSource = queryOrder.AsDataView
        nameFind()
        txtStatus.Visible = False
    End Sub

    Private Sub frmSeller_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Show()
    End Sub

    Private Sub btnUploadPicture_Click(sender As Object, e As EventArgs) Handles btnUploadPicture.Click
        Dim openPhoto As New OpenFileDialog With {
            .Filter = ("Picture File |*.jpg;*.jpeg;*.gif;*.png")
        }
        openPhoto.ShowDialog()
        picUpload.ImageLocation = openPhoto.FileName
    End Sub

    Private Sub btnIssueSubmit_Click(sender As Object, e As EventArgs) Handles btnIssueSubmit.Click
        txtUserID.Visible = True
        txtUserID.Text = userID
        Validate()
        IssueBindingSource.EndEdit()
        IssueTableAdapter.Update(Database_omcDataSet.issue.GetChanges)
        IssueTableAdapter.Fill(Database_omcDataSet.issue)
        txtUserID.Visible = False
        MsgBox("Issue submitted!")
        IssueBindingSource.AddNew()
    End Sub

    Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        If tabControl.SelectedIndex = 3 Then
            IssueBindingSource.AddNew()
        End If
    End Sub

    Sub nameFind()
        'lblItemID.Visible = True
        'Dim queryItemName = From inventory In Database_omcDataSet.inventory
        'Where inventory.ID.ToString = lblItemID.Text
        'Select Case inventory.ITEM_NAME
        'If queryItemName.Count > 0 Then
        'lblItemName.Text = queryItemName.ToArray(0)
        'Else
        'lblItemName.Text = "Item not found!"
        'End If
        'lblItemID.Visible = False
        lblCustomerID.Visible = True
        Dim queryCustomerName = From users In Database_omcDataSet.users
                                Where users.ID.ToString = lblCustomerID.Text
                                Select users.FIRST_NAME
        If queryCustomerName.Count > 0 Then
            lblCustomerName.Text = queryCustomerName.ToArray(0)
        Else
            lblCustomerName.Text = "Name not found!"
        End If
        lblCustomerID.Visible = False
        lblWeightOrdered.Text = Val(lblWeightOrdered.Text.Trim) & " kg"
        lblFinalPrice.Text = "RM" & Val(lblFinalPrice.Text.Replace("RM", "").Trim)
    End Sub

    Private Sub btnPreviousOrder_Click(sender As Object, e As EventArgs) Handles btnPreviousOrder.Click
        OrderBindingSource.MovePrevious()
        nameFind()
    End Sub

    Private Sub btnNextOrder_Click(sender As Object, e As EventArgs) Handles btnNextOrder.Click
        OrderBindingSource.MoveNext()
        nameFind()
    End Sub

    Private Sub btnOrderAccept_Click(sender As Object, e As EventArgs) Handles btnOrderAccept.Click
        If lblCustomerID.Text <> "" Then
            If txtStatus.Text <> "Accepted" And txtStatus.Text <> "Rejected" Then
                stockUpdate()
                salesUpdate()
                lblWeightOrdered.Text = Val(lblWeightOrdered.Text.Trim)
                lblFinalPrice.Text = Val(lblFinalPrice.Text.Replace("RM", "").Trim)
                lblCustomerID.Visible = True
                txtStatus.Visible = True
                txtStatus.Text = "Accepted"
                Validate()
                OrderBindingSource.EndEdit()
                OrderTableAdapter.Update(Database_omcDataSet.order.GetChanges)
                OrderTableAdapter.Fill(Database_omcDataSet.order)
                lblCustomerID.Visible = False
                txtStatus.Visible = False
                lblWeightOrdered.Text = lblWeightOrdered.Text & " kg"
                lblFinalPrice.Text = "RM" & Val(lblFinalPrice.Text.Replace("RM", "").Trim)
                MsgBox("Order Accepted")
            Else
                MsgBox("Order status had been set!")
            End If
        Else
            MsgBox("There is not order to be accept!")
        End If
    End Sub

    Private Sub btnOrderReject_Click(sender As Object, e As EventArgs) Handles btnOrderReject.Click
        If lblCustomerID.Text <> "" Then
            If txtStatus.Text <> "Accepted" And txtStatus.Text <> "Rejected" Then
                lblCustomerID.Visible = True
                txtStatus.Visible = True
                txtStatus.Text = "Rejected"
                Validate()
                OrderBindingSource.EndEdit()
                OrderTableAdapter.Update(Database_omcDataSet.order.GetChanges)
                OrderTableAdapter.Fill(Database_omcDataSet.order)
                lblCustomerID.Visible = False
                txtStatus.Visible = False
                MsgBox("Order Rejected")
            Else
                MsgBox("Order status had been set!")
            End If
        Else
            MsgBox("There is not order to be reject!")
        End If
    End Sub

    Private Sub btnListOfOrder_Click(sender As Object, e As EventArgs) Handles btnListOfOrder.Click
        Dim queryOrder = From order In Database_omcDataSet.order
                         Select order
        OrderBindingSource.DataSource = queryOrder.AsDataView
        nameFind()
    End Sub

    Private Sub dgvInv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInv.CellContentDoubleClick

    End Sub

    Private Sub btnNewProduct_Click(sender As Object, e As EventArgs) Handles btnNewProduct.Click
        InventoryBindingSource.AddNew()
        invEditStatus = -2
        frmInventory.ShowDialog()
        If invEditStatus = -2 Then
            InventoryBindingSource.RemoveCurrent()
            invEditStatus = -1
        ElseIf invEditStatus = -1 Then
            txtInvUserID.Visible = True
            txtInvUserID.Text = userID
            InventoryBindingSource.EndEdit()
            InventoryTableAdapter.Update(Database_omcDataSet.inventory.GetChanges)
            InventoryTableAdapter.Fill(Database_omcDataSet.inventory)
            txtInvUserID.Visible = False
        End If
    End Sub

    Private Sub InventoryBindingSource_BindingComplete(sender As Object, e As BindingCompleteEventArgs) Handles InventoryBindingSource.BindingComplete
        If e.BindingCompleteContext = BindingCompleteContext.DataSourceUpdate AndAlso e.Exception Is Nothing Then
            e.Binding.BindingManagerBase.EndCurrentEdit()
        End If
    End Sub

    Private Sub btnEditStock_Click(sender As Object, e As EventArgs) Handles btnEditStock.Click
        frmInventory.ShowDialog()
        InventoryBindingSource.EndEdit()
        InventoryTableAdapter.Update(Database_omcDataSet.inventory.GetChanges)
        InventoryTableAdapter.Fill(Database_omcDataSet.inventory)
    End Sub

    Public Sub completeEditInventory()
        Select Case invEditStatus
            Case 1
                txtInvUserID.Visible = True
                txtInvUserID.Text = userID
                Validate()
                InventoryBindingSource.EndEdit()
                InventoryTableAdapter.Update(Database_omcDataSet.inventory.GetChanges)
                InventoryTableAdapter.Fill(Database_omcDataSet.inventory)
                txtInvUserID.Visible = False
                MsgBox("Inventory edited!")
                invEditStatus = -1
            Case 0
                InventoryBindingSource.RemoveCurrent()
                InventoryBindingSource.EndEdit()
                InventoryTableAdapter.Update(Database_omcDataSet.inventory.GetChanges)
                InventoryTableAdapter.Fill(Database_omcDataSet.inventory)
                invEditStatus = -1
        End Select
    End Sub

    Private Sub btnOrderRefresh_Click(sender As Object, e As EventArgs) Handles btnOrderRefresh.Click
        Me.OrderTableAdapter.Fill(Me.Database_omcDataSet.order)
        Dim queryOrder = From order In Database_omcDataSet.order
                         Where order.IsSTATUSNull
                         Select order
        OrderBindingSource.DataSource = queryOrder.AsDataView
        nameFind()
    End Sub

    Private Sub btnInvRefresh_Click(sender As Object, e As EventArgs) Handles btnInvRefresh.Click
        Dim query = From inventory In Database_omcDataSet.inventory
                    Select inventory
        Me.InventoryTableAdapter.Fill(Me.Database_omcDataSet.inventory)
    End Sub

    Private Sub lblSellerName_DoubleClick(sender As Object, e As EventArgs) Handles lblSellerName.DoubleClick
        frmAccDetail.userID = userID
        frmAccDetail.ShowDialog()
    End Sub

    Private Sub tabControl_Enter(sender As Object, e As EventArgs) Handles tabControl.Enter
        Me.InventoryTableAdapter.Fill(Me.Database_omcDataSet.inventory)
    End Sub

    Friend Sub stockUpdate()
        For index As Integer = 0 To rtxtOrderDetail.Lines.Length - 1
            If rtxtOrderDetail.Lines(index) <> "" Then
                Dim value() = rtxtOrderDetail.Lines(index).Split(" ")
                Dim queryInv = From inventory In Database_omcDataSet.inventory
                               Where inventory.ID.ToString = value(1).ToString.Trim
                               Select inventory
                If queryInv.Count > 0 Then
                    InventoryBindingSource.DataSource = queryInv.AsDataView
                    txtStock.Visible = True
                    Dim stock As Integer = Val(txtStock.Text) - Val(value(value.Length - 4).Trim)
                    txtStock.Text = stock
                    Validate()
                    Me.InventoryBindingSource.EndEdit()
                    Me.InventoryTableAdapter.Update(Me.Database_omcDataSet.inventory.GetChanges)
                    Me.InventoryTableAdapter.Fill(Me.Database_omcDataSet.inventory)
                    txtStock.Visible = False
                Else
                    MsgBox("Stock Update Failed, please report this issue!", vbCritical + vbOKOnly, "Order")
                End If
            End If
        Next
    End Sub

    Friend Sub salesUpdate()
        For index As Integer = 0 To rtxtOrderDetail.Lines.Length - 1
            If rtxtOrderDetail.Lines(index) <> "" Then
                Dim value() = rtxtOrderDetail.Lines(index).Split(" ")
                Dim queryProductNumber = From inventory In Database_omcDataSet.inventory
                                         Where inventory.ID.ToString = value(1).ToString.Trim
                                         Select inventory.PRODUCT_NUMBER
                Dim querySales = From sales In Database_omcDataSet.sales
                                 Where sales.ITEM_ID.ToString.ToUpper = queryProductNumber.ToArray(0).ToString.ToUpper
                                 Select sales
                If querySales.Count > 0 Then
                    SalesBindingSource.DataSource = querySales.AsDataView
                    txtSalesPrice.Visible = True
                    Dim finalPrice As Double = Val(txtSalesPrice.Text) + Val(value(value.Length - 1).Replace("RM", "").Trim)
                    txtSalesPrice.Text = Val(txtSalesPrice.Text) + Val(value(value.Length - 1).Replace("RM", "").Trim)
                    txtSalesQuantity.Visible = True
                    Dim finalQuantity As Integer = Val(txtSalesQuantity.Text) + Val(value(value.Length - 4).Trim)
                    txtSalesQuantity.Text = Val(txtSalesQuantity.Text) + Val(value(value.Length - 4).Trim)
                    Validate()
                    SalesBindingSource.EndEdit()
                    SalesTableAdapter.Update(Database_omcDataSet.sales.GetChanges)
                    SalesTableAdapter.Fill(Database_omcDataSet.sales)
                    txtSalesPrice.Visible = False
                    txtSalesQuantity.Visible = False
                Else
                    MsgBox("Sales Update Failed, please report this issue!", vbCritical + vbOKOnly, "Order")
                End If
            End If
        Next
    End Sub

    Private Sub btnIncomeRefresh_Click(sender As Object, e As EventArgs) Handles btnIncomeRefresh.Click
        chartIncome.DataBind()
    End Sub

    Private Sub btnTopSellingRefresh_Click(sender As Object, e As EventArgs) Handles btnTopSellingRefresh.Click
        chartTopSelling.DataBind()
    End Sub
End Class