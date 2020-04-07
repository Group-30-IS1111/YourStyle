Public Class frmAccount
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmHome.Show()
        Me.Hide()
        frmDesign.Hide()
    End Sub

    Private Sub btnCustomize_Click(sender As Object, e As EventArgs) Handles btnCustomize.Click
        frmHome.Hide()
        Me.Hide()
        frmDesign.Show()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        frmHome.Hide()
        Me.Show()
        frmDesign.Hide()
    End Sub
End Class