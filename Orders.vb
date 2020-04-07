Public Class Orders
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Your_StyleDataSet2.Customers_Orders' table. You can move, or remove it, as needed.
        Me.Customers_OrdersTableAdapter.Fill(Me.Your_StyleDataSet2.Customers_Orders)

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtCustomer.Text = "" Then

        End If
    End Sub

    Private Sub txtCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtCustomer.TextChanged

    End Sub
End Class