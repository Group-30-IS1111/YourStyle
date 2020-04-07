<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.components = New System.ComponentModel.Container()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.grpStaff = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Manager_DatabaseDataSet = New YourStyle.Manager_DatabaseDataSet()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtStaff = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.StaffTableAdapter = New YourStyle.Manager_DatabaseDataSetTableAdapters.StaffTableAdapter()
        Me.grpStaff.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Manager_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 26)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(250, 39)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(257, 26)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(250, 39)
        Me.btnReports.TabIndex = 1
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(500, 26)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(250, 39)
        Me.btnQuery.TabIndex = 2
        Me.btnQuery.Text = "Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Location = New System.Drawing.Point(744, 26)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(250, 39)
        Me.btnStaff.TabIndex = 3
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Location = New System.Drawing.Point(987, 26)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(250, 39)
        Me.btnOrders.TabIndex = 4
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(49, 50)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(82, 25)
        Me.lblStaffID.TabIndex = 7
        Me.lblStaffID.Text = "Staff ID:"
        '
        'grpStaff
        '
        Me.grpStaff.Controls.Add(Me.txtDate)
        Me.grpStaff.Controls.Add(Me.btnCancel)
        Me.grpStaff.Controls.Add(Me.btnUpdate)
        Me.grpStaff.Controls.Add(Me.btnDelete)
        Me.grpStaff.Controls.Add(Me.btnAdd)
        Me.grpStaff.Controls.Add(Me.dgvStaff)
        Me.grpStaff.Controls.Add(Me.txtAddress)
        Me.grpStaff.Controls.Add(Me.lblAddress)
        Me.grpStaff.Controls.Add(Me.txtNumber)
        Me.grpStaff.Controls.Add(Me.txtSurname)
        Me.grpStaff.Controls.Add(Me.txtFirst)
        Me.grpStaff.Controls.Add(Me.txtStaff)
        Me.grpStaff.Controls.Add(Me.lblDate)
        Me.grpStaff.Controls.Add(Me.lblNumber)
        Me.grpStaff.Controls.Add(Me.lblSurname)
        Me.grpStaff.Controls.Add(Me.lblFirst)
        Me.grpStaff.Controls.Add(Me.lblStaffID)
        Me.grpStaff.Location = New System.Drawing.Point(22, 90)
        Me.grpStaff.Name = "grpStaff"
        Me.grpStaff.Size = New System.Drawing.Size(1200, 476)
        Me.grpStaff.TabIndex = 5
        Me.grpStaff.TabStop = False
        Me.grpStaff.Text = "Staff"
        '
        'txtDate
        '
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Date Joined", True))
        Me.txtDate.Location = New System.Drawing.Point(237, 365)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(238, 22)
        Me.txtDate.TabIndex = 19
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Staff"
        Me.BindingSource1.DataSource = Me.Manager_DatabaseDataSet
        '
        'Manager_DatabaseDataSet
        '
        Me.Manager_DatabaseDataSet.DataSetName = "Manager_DatabaseDataSet"
        Me.Manager_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(409, 423)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 28)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(276, 423)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(107, 28)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(149, 423)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 28)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 423)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 28)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvStaff
        '
        Me.dgvStaff.AutoGenerateColumns = False
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn})
        Me.dgvStaff.DataSource = Me.BindingSource1
        Me.dgvStaff.Location = New System.Drawing.Point(534, 50)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.RowTemplate.Height = 24
        Me.dgvStaff.Size = New System.Drawing.Size(644, 369)
        Me.dgvStaff.TabIndex = 10
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(237, 228)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(238, 22)
        Me.txtAddress.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(49, 225)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(91, 25)
        Me.lblAddress.TabIndex = 18
        Me.lblAddress.Text = "Address:"
        '
        'txtNumber
        '
        Me.txtNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Phone Number", True))
        Me.txtNumber.Location = New System.Drawing.Point(237, 297)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(238, 22)
        Me.txtNumber.TabIndex = 4
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Surname", True))
        Me.txtSurname.Location = New System.Drawing.Point(237, 170)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(238, 22)
        Me.txtSurname.TabIndex = 3
        '
        'txtFirst
        '
        Me.txtFirst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "First Name", True))
        Me.txtFirst.Location = New System.Drawing.Point(237, 111)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(238, 22)
        Me.txtFirst.TabIndex = 1
        '
        'txtStaff
        '
        Me.txtStaff.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ID", True))
        Me.txtStaff.Location = New System.Drawing.Point(237, 54)
        Me.txtStaff.Name = "txtStaff"
        Me.txtStaff.Size = New System.Drawing.Size(238, 22)
        Me.txtStaff.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(49, 363)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(123, 25)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "Date Joined:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(49, 293)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(149, 25)
        Me.lblNumber.TabIndex = 10
        Me.lblNumber.Text = "Phone Number:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(49, 170)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(98, 25)
        Me.lblSurname.TabIndex = 9
        Me.lblSurname.Text = "Surname:"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(49, 107)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(112, 25)
        Me.lblFirst.TabIndex = 8
        Me.lblFirst.Text = "First Name:"
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1286, 637)
        Me.Controls.Add(Me.grpStaff)
        Me.Controls.Add(Me.btnOrders)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        Me.grpStaff.ResumeLayout(False)
        Me.grpStaff.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Manager_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnQuery As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents lblStaffID As Label
    Friend WithEvents grpStaff As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtStaff As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Manager_DatabaseDataSet As Manager_DatabaseDataSet
    Friend WithEvents StaffTableAdapter As Manager_DatabaseDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtDate As TextBox
End Class
