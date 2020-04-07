<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Me.lblHello = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnOrderHistory = New System.Windows.Forms.Button()
        Me.btnTrack = New System.Windows.Forms.Button()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnCustomize = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(129, 139)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(139, 51)
        Me.lblHello.TabIndex = 11
        Me.lblHello.Text = "Hello!"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(133, 210)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(978, 50)
        Me.lblWelcome.TabIndex = 12
        Me.lblWelcome.Text = "Welcome to your own space at Your Style! Here you can check past orders, manage a" &
    "ccount settings and keep " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "up to date with the latest trends."
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(218, 305)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(272, 117)
        Me.btnInfo.TabIndex = 13
        Me.btnInfo.Text = "My Info"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnOrderHistory
        '
        Me.btnOrderHistory.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOrderHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderHistory.Location = New System.Drawing.Point(738, 305)
        Me.btnOrderHistory.Name = "btnOrderHistory"
        Me.btnOrderHistory.Size = New System.Drawing.Size(272, 117)
        Me.btnOrderHistory.TabIndex = 14
        Me.btnOrderHistory.Text = "Order History"
        Me.btnOrderHistory.UseVisualStyleBackColor = False
        '
        'btnTrack
        '
        Me.btnTrack.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrack.Location = New System.Drawing.Point(218, 486)
        Me.btnTrack.Name = "btnTrack"
        Me.btnTrack.Size = New System.Drawing.Size(272, 117)
        Me.btnTrack.TabIndex = 15
        Me.btnTrack.Text = "Track My Order"
        Me.btnTrack.UseVisualStyleBackColor = False
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(738, 486)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(272, 117)
        Me.btnSignOut.TabIndex = 16
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(12, 48)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(386, 53)
        Me.btnHome.TabIndex = 17
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnCustomize
        '
        Me.btnCustomize.Location = New System.Drawing.Point(394, 48)
        Me.btnCustomize.Name = "btnCustomize"
        Me.btnCustomize.Size = New System.Drawing.Size(431, 53)
        Me.btnCustomize.TabIndex = 18
        Me.btnCustomize.Text = "Customize Your Shoe"
        Me.btnCustomize.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Location = New System.Drawing.Point(819, 48)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(390, 53)
        Me.btnAccount.TabIndex = 19
        Me.btnAccount.Text = "Your Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1238, 678)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.btnCustomize)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.btnTrack)
        Me.Controls.Add(Me.btnOrderHistory)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblHello)
        Me.Name = "frmAccount"
        Me.Text = "Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHello As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnOrderHistory As Button
    Friend WithEvents btnTrack As Button
    Friend WithEvents btnSignOut As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnCustomize As Button
    Friend WithEvents btnAccount As Button
End Class
