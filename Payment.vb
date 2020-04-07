Public Class frmPayment
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Hide()
        frmDesign.Show()
    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmHome.Show()
        Me.Hide()
        frmAccount.Hide()
    End Sub

    Private Sub btnCustomize_Click(sender As Object, e As EventArgs) Handles btnCustomize.Click
        frmHome.Hide()
        Me.Show()
        frmAccount.Hide()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        frmHome.Hide()
        Me.Hide()
        frmAccount.Show()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        'When user clicks total, the figures will add together
        Dim dblModel As Double = CDbl(txtModel2.Text)
        Dim dblLaces As Double = CDbl(txtLaces2.Text)
        Dim dblEyestay As Double = CDbl(txtEyestay2.Text)
        Dim dblVamp As Double = CDbl(txtVamp2.Text)
        Dim dblQuarter As Double = CDbl(txtQuarter2.Text)
        Dim dblBackCounter As Double = CDbl(txtBackCounter2.Text)
        Dim dblHeelTab As Double = CDbl(txtHeelTab2.Text)
        Dim dblPrice = FormatCurrency(dblModel + dblLaces + dblEyestay + dblVamp + dblQuarter + dblBackCounter + dblHeelTab)
        txtPrice.Text = CStr(dblPrice)

        'Getting the price for VAT
        Dim strVat As String = (txtPrice.Text * 0.23)
        txtVat.Text = FormatCurrency(strVat)
        Dim dblVat As Double = CDbl(txtVat.Text)

        'Adding VAT and price of shoe together for total price
        Dim dblTotal = FormatCurrency(dblPrice + dblVat)
        txtTotal.Text = CStr(dblTotal)
    End Sub

    Private Sub cboQuantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboQuantity.SelectedIndexChanged
        If cboQuantity.SelectedItem = "1" Then
            txtTotalDue.Text = FormatCurrency(txtTotal.Text)

        ElseIf cboQuantity.SelectedItem = "2" Then
            txtTotalDue.Text = FormatCurrency(txtTotal.Text * 2)

        ElseIf cboQuantity.SelectedItem = "3" Then
            txtTotalDue.Text = FormatCurrency(txtTotal.Text * 3)

        ElseIf cboQuantity.SelectedItem = "4" Then
            txtTotalDue.Text = FormatCurrency(txtTotal.Text * 4)

        ElseIf cboQuantity.SelectedItem = "5" Then
            txtTotalDue.Text = FormatCurrency(txtTotal.Text * 5)

        ElseIf cboQuantity.SelectedItem = "6" Then
            txtTotalDue.Text = FormatCurrency(txtTotal.Text * 6)

        ElseIf cboQuantity.SelectedItem = "7" Then
            txtTotalDue.Text = FormatCurrency(txtTotal.Text * 7)

        ElseIf cboQuantity.SelectedItem = "8" Then
            txtTotalDue.Text = FormatCurrency(txtTotal.Text * 8)

        End If
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Your_StyleDataSet.Customers_Orders' table. You can move, or remove it, as needed.
        Me.Customers_OrdersTableAdapter.Fill(Me.Your_StyleDataSet.Customers_Orders)

    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        BindingSource1.AddNew()
    End Sub
End Class