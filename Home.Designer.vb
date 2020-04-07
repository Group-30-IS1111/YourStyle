<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnCustomize = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(24, 43)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(386, 53)
        Me.btnHome.TabIndex = 18
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnCustomize
        '
        Me.btnCustomize.Location = New System.Drawing.Point(400, 43)
        Me.btnCustomize.Name = "btnCustomize"
        Me.btnCustomize.Size = New System.Drawing.Size(431, 53)
        Me.btnCustomize.TabIndex = 19
        Me.btnCustomize.Text = "Customize Your Shoe"
        Me.btnCustomize.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Location = New System.Drawing.Point(827, 43)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(390, 53)
        Me.btnAccount.TabIndex = 20
        Me.btnAccount.Text = "Your Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1239, 694)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.btnCustomize)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnCustomize As Button
    Friend WithEvents btnAccount As Button
End Class
