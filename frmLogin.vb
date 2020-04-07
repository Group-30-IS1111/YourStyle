Public Class frmLogin
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LoginDataSet.Login)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
        txtUsername.Clear()
        txtPassword.Clear()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim queryUser = From Login In LoginDataSet.Login
                        Where Login.Username = txtUsername.Text
                        Select Login.Username

        Dim queryPass = From Login In LoginDataSet.Login
                        Where Login.Password = txtPassword.Text
                        Select Login.Password

        Dim FoDUsername = queryUser.FirstOrDefault()
        Dim FoDPassword = queryPass.FirstOrDefault()

        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter a username", "Error")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter a password", "Error")
            txtPassword.Focus()
        ElseIf FoDUsername.ToString() <> txtUsername.Text And
           FoDPassword.ToString() <> txtPassword.Text Then
            MessageBox.Show("Incorrect Username or Password", "Error")
        ElseIf FoDUsername.ToString() = txtUsername.Text And
           FoDPassword.ToString() = txtPassword.Text Then
            MessageBox.Show("Login Successful")
            Me.Hide()
            'Next form needs to be put in here
        End If

    End Sub
End Class
