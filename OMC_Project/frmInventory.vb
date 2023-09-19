Imports System.ComponentModel

Public Class frmInventory

    Private Sub frmNewProduct_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Database_omcDataSet.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.Database_omcDataSet.sales)
        txtProductName.DataBindings.Clear()
        rtxtDescription.DataBindings.Clear()
        txtPrice.DataBindings.Clear()
        txtDiscount.DataBindings.Clear()
        txtWeight.DataBindings.Clear()
        nudQuantity.DataBindings.Clear()
        txtProductID.DataBindings.Clear()
        txtSupplier.DataBindings.Clear()
        picMain.DataBindings.Clear()
        txtProductName.DataBindings.Add("Text", frmSeller.InventoryBindingSource, "ITEM NAME", True)
        rtxtDescription.DataBindings.Add("Text", frmSeller.InventoryBindingSource, "DESCRIPTION", True)
        txtPrice.DataBindings.Add("Text", frmSeller.InventoryBindingSource, "PRICE", True)
        txtDiscount.DataBindings.Add("Text", frmSeller.InventoryBindingSource, "DISCOUNT", True)
        txtWeight.DataBindings.Add("Text", frmSeller.InventoryBindingSource, "WEIGHT", True)
        nudQuantity.DataBindings.Add("Value", frmSeller.InventoryBindingSource, "STOCK", True)
        txtProductID.DataBindings.Add("Text", frmSeller.InventoryBindingSource, "PRODUCT NUMBER", True)
        txtSupplier.DataBindings.Add("Text", frmSeller.InventoryBindingSource, "SUPPLIER", True)
        picMain.DataBindings.Add("Image", frmSeller.InventoryBindingSource, "MAIN PICTURE", True)
    End Sub

    Private Sub frmNewProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub

    Private Sub btnUploadPic_Click(sender As Object, e As EventArgs) Handles btnUploadPic.Click
        Dim openPhoto As New OpenFileDialog With {
            .Filter = ("Picture File |*.jpg;*.jpeg;*.gif;*.png")
        }
        openPhoto.ShowDialog()
        picMain.ImageLocation = openPhoto.FileName
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtProductName.Clear()
        rtxtDescription.Clear()
        txtPrice.Clear()
        txtDiscount.Clear()
        txtWeight.Clear()
        nudQuantity.Value = 0
        txtProductID.Clear()
        txtSupplier.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtInvUserID.Visible = True
        txtSalesItemID.Visible = True
        txtInvUserID.Text = frmSeller.userID
        Validate()
        'frmSeller.InventoryBindingSource.EndEdit()
        'frmSeller.InventoryTableAdapter.Update(frmSeller.Database_omcDataSet.inventory.GetChanges)
        SalesBindingSource.AddNew()
        txtSalesItemID.Text = txtProductID.Text
        SalesBindingSource.EndEdit()
        SalesTableAdapter.Update(Database_omcDataSet.sales.GetChanges)
        SalesTableAdapter.Fill(Database_omcDataSet.sales)
        txtInvUserID.Visible = False
        txtSalesItemID.Visible = False
        MsgBox("Inventory edited!")
        'frmSeller.InventoryTableAdapter.Fill(frmSeller.Database_omcDataSet.inventory)
        frmSeller.invEditStatus = -1
        Me.Close()
    End Sub

    Private Sub frmInventory_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub
End Class