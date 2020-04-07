Public Class frmHome
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Show()
        frmAccount.Hide()
        frmDesign.Hide()
    End Sub

    Private Sub btnCustomize_Click(sender As Object, e As EventArgs) Handles btnCustomize.Click
        Me.Hide()
        frmAccount.Hide()
        frmDesign.Show()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Me.Hide()
        frmAccount.Show()
        frmDesign.Hide()
    End Sub
End Class