<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Query
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
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.grpQuery = New System.Windows.Forms.GroupBox()
        Me.grpCustomization = New System.Windows.Forms.GroupBox()
        Me.chkLaces = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkEyestay = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.chkVamp = New System.Windows.Forms.CheckBox()
        Me.chkLogo = New System.Windows.Forms.CheckBox()
        Me.chkBackCounter = New System.Windows.Forms.CheckBox()
        Me.chkHeelTab = New System.Windows.Forms.CheckBox()
        Me.chkQuarter = New System.Windows.Forms.CheckBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.grpQuery.SuspendLayout()
        Me.grpCustomization.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(22, 32)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(250, 39)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(264, 32)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(250, 39)
        Me.btnReports.TabIndex = 3
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(510, 32)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(250, 39)
        Me.btnQuery.TabIndex = 4
        Me.btnQuery.Text = "Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Location = New System.Drawing.Point(751, 32)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(250, 39)
        Me.btnStaff.TabIndex = 5
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Location = New System.Drawing.Point(994, 32)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(250, 39)
        Me.btnOrders.TabIndex = 6
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'grpQuery
        '
        Me.grpQuery.Controls.Add(Me.grpCustomization)
        Me.grpQuery.Controls.Add(Me.btnClear)
        Me.grpQuery.Controls.Add(Me.txtTotal)
        Me.grpQuery.Controls.Add(Me.txtVat)
        Me.grpQuery.Controls.Add(Me.txtSub)
        Me.grpQuery.Controls.Add(Me.cboType)
        Me.grpQuery.Controls.Add(Me.lblTotal)
        Me.grpQuery.Controls.Add(Me.lblVAT)
        Me.grpQuery.Controls.Add(Me.lblSub)
        Me.grpQuery.Controls.Add(Me.lblType)
        Me.grpQuery.Location = New System.Drawing.Point(180, 103)
        Me.grpQuery.Name = "grpQuery"
        Me.grpQuery.Size = New System.Drawing.Size(884, 531)
        Me.grpQuery.TabIndex = 7
        Me.grpQuery.TabStop = False
        Me.grpQuery.Text = "Query"
        '
        'grpCustomization
        '
        Me.grpCustomization.Controls.Add(Me.chkLaces)
        Me.grpCustomization.Controls.Add(Me.chkEyestay)
        Me.grpCustomization.Controls.Add(Me.btnCalculate)
        Me.grpCustomization.Controls.Add(Me.chkVamp)
        Me.grpCustomization.Controls.Add(Me.chkLogo)
        Me.grpCustomization.Controls.Add(Me.chkBackCounter)
        Me.grpCustomization.Controls.Add(Me.chkHeelTab)
        Me.grpCustomization.Controls.Add(Me.chkQuarter)
        Me.grpCustomization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomization.Location = New System.Drawing.Point(69, 180)
        Me.grpCustomization.Name = "grpCustomization"
        Me.grpCustomization.Size = New System.Drawing.Size(404, 320)
        Me.grpCustomization.TabIndex = 18
        Me.grpCustomization.TabStop = False
        Me.grpCustomization.Text = "Customization Components:"
        '
        'chkLaces
        '
        Me.chkLaces.AutoSize = True
        Me.chkLaces.Location = New System.Drawing.Point(25, 40)
        Me.chkLaces.Name = "chkLaces"
        Me.chkLaces.Size = New System.Drawing.Size(77, 24)
        Me.chkLaces.TabIndex = 9
        Me.chkLaces.Text = "Laces"
        Me.chkLaces.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(752, 444)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 32)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkEyestay
        '
        Me.chkEyestay.AutoSize = True
        Me.chkEyestay.Location = New System.Drawing.Point(25, 89)
        Me.chkEyestay.Name = "chkEyestay"
        Me.chkEyestay.Size = New System.Drawing.Size(90, 24)
        Me.chkEyestay.TabIndex = 10
        Me.chkEyestay.Text = "Eyestay"
        Me.chkEyestay.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(246, 263)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(103, 32)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'chkVamp
        '
        Me.chkVamp.AutoSize = True
        Me.chkVamp.Location = New System.Drawing.Point(25, 138)
        Me.chkVamp.Name = "chkVamp"
        Me.chkVamp.Size = New System.Drawing.Size(74, 24)
        Me.chkVamp.TabIndex = 11
        Me.chkVamp.Text = "Vamp"
        Me.chkVamp.UseVisualStyleBackColor = True
        '
        'chkLogo
        '
        Me.chkLogo.AutoSize = True
        Me.chkLogo.Location = New System.Drawing.Point(160, 138)
        Me.chkLogo.Name = "chkLogo"
        Me.chkLogo.Size = New System.Drawing.Size(68, 24)
        Me.chkLogo.TabIndex = 14
        Me.chkLogo.Text = "Logo"
        Me.chkLogo.UseVisualStyleBackColor = True
        '
        'chkBackCounter
        '
        Me.chkBackCounter.AutoSize = True
        Me.chkBackCounter.Location = New System.Drawing.Point(160, 40)
        Me.chkBackCounter.Name = "chkBackCounter"
        Me.chkBackCounter.Size = New System.Drawing.Size(133, 24)
        Me.chkBackCounter.TabIndex = 15
        Me.chkBackCounter.Text = "Back Counter"
        Me.chkBackCounter.UseVisualStyleBackColor = True
        '
        'chkHeelTab
        '
        Me.chkHeelTab.AutoSize = True
        Me.chkHeelTab.Location = New System.Drawing.Point(160, 89)
        Me.chkHeelTab.Name = "chkHeelTab"
        Me.chkHeelTab.Size = New System.Drawing.Size(99, 24)
        Me.chkHeelTab.TabIndex = 13
        Me.chkHeelTab.Text = "Heel Tab"
        Me.chkHeelTab.UseVisualStyleBackColor = True
        '
        'chkQuarter
        '
        Me.chkQuarter.AutoSize = True
        Me.chkQuarter.Location = New System.Drawing.Point(25, 188)
        Me.chkQuarter.Name = "chkQuarter"
        Me.chkQuarter.Size = New System.Drawing.Size(88, 24)
        Me.chkQuarter.TabIndex = 12
        Me.chkQuarter.Text = "Quarter"
        Me.chkQuarter.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(591, 266)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(152, 22)
        Me.txtTotal.TabIndex = 8
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(591, 180)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(152, 22)
        Me.txtVat.TabIndex = 7
        '
        'txtSub
        '
        Me.txtSub.Location = New System.Drawing.Point(591, 96)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(152, 22)
        Me.txtSub.TabIndex = 6
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Classic", "Retro", "Vintage"})
        Me.cboType.Location = New System.Drawing.Point(69, 94)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(185, 24)
        Me.cboType.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(587, 243)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 20)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Location = New System.Drawing.Point(587, 157)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(46, 20)
        Me.lblVAT.TabIndex = 3
        Me.lblVAT.Text = "VAT:"
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.Location = New System.Drawing.Point(587, 73)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(85, 20)
        Me.lblSub.TabIndex = 2
        Me.lblSub.Text = "Sub Total:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(65, 51)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(93, 20)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Shoe Type:"
        '
        'Query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1244, 665)
        Me.Controls.Add(Me.grpQuery)
        Me.Controls.Add(Me.btnOrders)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "Query"
        Me.Text = "Query"
        Me.grpQuery.ResumeLayout(False)
        Me.grpQuery.PerformLayout()
        Me.grpCustomization.ResumeLayout(False)
        Me.grpCustomization.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnQuery As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents grpQuery As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtSub As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents lblType As Label
    Friend WithEvents chkLogo As CheckBox
    Friend WithEvents chkHeelTab As CheckBox
    Friend WithEvents chkQuarter As CheckBox
    Friend WithEvents chkVamp As CheckBox
    Friend WithEvents chkEyestay As CheckBox
    Friend WithEvents chkLaces As CheckBox
    Friend WithEvents chkBackCounter As CheckBox
    Friend WithEvents grpCustomization As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
End Class
