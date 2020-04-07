<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.NamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShoeModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LogoProvidedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LacesColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EyestayColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VampColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuarterColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackCounterColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeelTabColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LacesPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EyestayPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VampPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuarterPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackCounterPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeelTabPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PricePerShoeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vat23DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Your_StyleDataSet2 = New YourStyle.Your_StyleDataSet2()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Customers_OrdersTableAdapter = New YourStyle.Your_StyleDataSet2TableAdapters.Customers_OrdersTableAdapter()
        Me.grpOrder.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Your_StyleDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 27)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(250, 39)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(254, 27)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(250, 39)
        Me.btnReports.TabIndex = 3
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(501, 27)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(250, 39)
        Me.btnQuery.TabIndex = 4
        Me.btnQuery.Text = "Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Location = New System.Drawing.Point(748, 27)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(250, 39)
        Me.btnStaff.TabIndex = 5
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Location = New System.Drawing.Point(993, 27)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(250, 39)
        Me.btnOrders.TabIndex = 6
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.btnSearch)
        Me.grpOrder.Controls.Add(Me.dgvOrders)
        Me.grpOrder.Controls.Add(Me.lblDetails)
        Me.grpOrder.Controls.Add(Me.txtNumber)
        Me.grpOrder.Controls.Add(Me.txtCustomer)
        Me.grpOrder.Controls.Add(Me.txtOrder)
        Me.grpOrder.Controls.Add(Me.lblOrder)
        Me.grpOrder.Controls.Add(Me.lblNumber)
        Me.grpOrder.Controls.Add(Me.lblName)
        Me.grpOrder.Location = New System.Drawing.Point(68, 72)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(1128, 468)
        Me.grpOrder.TabIndex = 11
        Me.grpOrder.TabStop = False
        Me.grpOrder.Text = "Orders"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(400, 107)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(269, 35)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvOrders
        '
        Me.dgvOrders.AutoGenerateColumns = False
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamesDataGridViewTextBoxColumn, Me.OrderIDDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.ShoeModelDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.LogoDataGridViewCheckBoxColumn, Me.LogoProvidedDataGridViewCheckBoxColumn, Me.LacesColourDataGridViewTextBoxColumn, Me.EyestayColourDataGridViewTextBoxColumn, Me.VampColourDataGridViewTextBoxColumn, Me.QuarterColourDataGridViewTextBoxColumn, Me.BackCounterColourDataGridViewTextBoxColumn, Me.HeelTabColourDataGridViewTextBoxColumn, Me.ModelPriceDataGridViewTextBoxColumn, Me.LacesPriceDataGridViewTextBoxColumn, Me.EyestayPriceDataGridViewTextBoxColumn, Me.VampPriceDataGridViewTextBoxColumn, Me.QuarterPriceDataGridViewTextBoxColumn, Me.BackCounterPriceDataGridViewTextBoxColumn, Me.HeelTabPriceDataGridViewTextBoxColumn, Me.LogoPriceDataGridViewTextBoxColumn, Me.PricePerShoeDataGridViewTextBoxColumn, Me.Vat23DataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.TotalDueDataGridViewTextBoxColumn, Me.ServedByDataGridViewTextBoxColumn})
        Me.dgvOrders.DataSource = Me.CustomersOrdersBindingSource
        Me.dgvOrders.Location = New System.Drawing.Point(39, 240)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.RowTemplate.Height = 24
        Me.dgvOrders.Size = New System.Drawing.Size(1017, 212)
        Me.dgvOrders.TabIndex = 14
        '
        'NamesDataGridViewTextBoxColumn
        '
        Me.NamesDataGridViewTextBoxColumn.DataPropertyName = "Name(s)"
        Me.NamesDataGridViewTextBoxColumn.HeaderText = "Name(s)"
        Me.NamesDataGridViewTextBoxColumn.Name = "NamesDataGridViewTextBoxColumn"
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
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
        'ShoeModelDataGridViewTextBoxColumn
        '
        Me.ShoeModelDataGridViewTextBoxColumn.DataPropertyName = "Shoe Model"
        Me.ShoeModelDataGridViewTextBoxColumn.HeaderText = "Shoe Model"
        Me.ShoeModelDataGridViewTextBoxColumn.Name = "ShoeModelDataGridViewTextBoxColumn"
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        '
        'LogoDataGridViewCheckBoxColumn
        '
        Me.LogoDataGridViewCheckBoxColumn.DataPropertyName = "Logo"
        Me.LogoDataGridViewCheckBoxColumn.HeaderText = "Logo"
        Me.LogoDataGridViewCheckBoxColumn.Name = "LogoDataGridViewCheckBoxColumn"
        '
        'LogoProvidedDataGridViewCheckBoxColumn
        '
        Me.LogoProvidedDataGridViewCheckBoxColumn.DataPropertyName = "Logo Provided"
        Me.LogoProvidedDataGridViewCheckBoxColumn.HeaderText = "Logo Provided"
        Me.LogoProvidedDataGridViewCheckBoxColumn.Name = "LogoProvidedDataGridViewCheckBoxColumn"
        '
        'LacesColourDataGridViewTextBoxColumn
        '
        Me.LacesColourDataGridViewTextBoxColumn.DataPropertyName = "Laces Colour"
        Me.LacesColourDataGridViewTextBoxColumn.HeaderText = "Laces Colour"
        Me.LacesColourDataGridViewTextBoxColumn.Name = "LacesColourDataGridViewTextBoxColumn"
        '
        'EyestayColourDataGridViewTextBoxColumn
        '
        Me.EyestayColourDataGridViewTextBoxColumn.DataPropertyName = "Eyestay Colour"
        Me.EyestayColourDataGridViewTextBoxColumn.HeaderText = "Eyestay Colour"
        Me.EyestayColourDataGridViewTextBoxColumn.Name = "EyestayColourDataGridViewTextBoxColumn"
        '
        'VampColourDataGridViewTextBoxColumn
        '
        Me.VampColourDataGridViewTextBoxColumn.DataPropertyName = "Vamp Colour"
        Me.VampColourDataGridViewTextBoxColumn.HeaderText = "Vamp Colour"
        Me.VampColourDataGridViewTextBoxColumn.Name = "VampColourDataGridViewTextBoxColumn"
        '
        'QuarterColourDataGridViewTextBoxColumn
        '
        Me.QuarterColourDataGridViewTextBoxColumn.DataPropertyName = "Quarter Colour"
        Me.QuarterColourDataGridViewTextBoxColumn.HeaderText = "Quarter Colour"
        Me.QuarterColourDataGridViewTextBoxColumn.Name = "QuarterColourDataGridViewTextBoxColumn"
        '
        'BackCounterColourDataGridViewTextBoxColumn
        '
        Me.BackCounterColourDataGridViewTextBoxColumn.DataPropertyName = "Back Counter Colour"
        Me.BackCounterColourDataGridViewTextBoxColumn.HeaderText = "Back Counter Colour"
        Me.BackCounterColourDataGridViewTextBoxColumn.Name = "BackCounterColourDataGridViewTextBoxColumn"
        '
        'HeelTabColourDataGridViewTextBoxColumn
        '
        Me.HeelTabColourDataGridViewTextBoxColumn.DataPropertyName = "Heel Tab Colour"
        Me.HeelTabColourDataGridViewTextBoxColumn.HeaderText = "Heel Tab Colour"
        Me.HeelTabColourDataGridViewTextBoxColumn.Name = "HeelTabColourDataGridViewTextBoxColumn"
        '
        'ModelPriceDataGridViewTextBoxColumn
        '
        Me.ModelPriceDataGridViewTextBoxColumn.DataPropertyName = "Model Price"
        Me.ModelPriceDataGridViewTextBoxColumn.HeaderText = "Model Price"
        Me.ModelPriceDataGridViewTextBoxColumn.Name = "ModelPriceDataGridViewTextBoxColumn"
        '
        'LacesPriceDataGridViewTextBoxColumn
        '
        Me.LacesPriceDataGridViewTextBoxColumn.DataPropertyName = "Laces Price"
        Me.LacesPriceDataGridViewTextBoxColumn.HeaderText = "Laces Price"
        Me.LacesPriceDataGridViewTextBoxColumn.Name = "LacesPriceDataGridViewTextBoxColumn"
        '
        'EyestayPriceDataGridViewTextBoxColumn
        '
        Me.EyestayPriceDataGridViewTextBoxColumn.DataPropertyName = "Eyestay Price"
        Me.EyestayPriceDataGridViewTextBoxColumn.HeaderText = "Eyestay Price"
        Me.EyestayPriceDataGridViewTextBoxColumn.Name = "EyestayPriceDataGridViewTextBoxColumn"
        '
        'VampPriceDataGridViewTextBoxColumn
        '
        Me.VampPriceDataGridViewTextBoxColumn.DataPropertyName = "Vamp Price"
        Me.VampPriceDataGridViewTextBoxColumn.HeaderText = "Vamp Price"
        Me.VampPriceDataGridViewTextBoxColumn.Name = "VampPriceDataGridViewTextBoxColumn"
        '
        'QuarterPriceDataGridViewTextBoxColumn
        '
        Me.QuarterPriceDataGridViewTextBoxColumn.DataPropertyName = "Quarter Price"
        Me.QuarterPriceDataGridViewTextBoxColumn.HeaderText = "Quarter Price"
        Me.QuarterPriceDataGridViewTextBoxColumn.Name = "QuarterPriceDataGridViewTextBoxColumn"
        '
        'BackCounterPriceDataGridViewTextBoxColumn
        '
        Me.BackCounterPriceDataGridViewTextBoxColumn.DataPropertyName = "Back Counter Price"
        Me.BackCounterPriceDataGridViewTextBoxColumn.HeaderText = "Back Counter Price"
        Me.BackCounterPriceDataGridViewTextBoxColumn.Name = "BackCounterPriceDataGridViewTextBoxColumn"
        '
        'HeelTabPriceDataGridViewTextBoxColumn
        '
        Me.HeelTabPriceDataGridViewTextBoxColumn.DataPropertyName = "Heel Tab Price"
        Me.HeelTabPriceDataGridViewTextBoxColumn.HeaderText = "Heel Tab Price"
        Me.HeelTabPriceDataGridViewTextBoxColumn.Name = "HeelTabPriceDataGridViewTextBoxColumn"
        '
        'LogoPriceDataGridViewTextBoxColumn
        '
        Me.LogoPriceDataGridViewTextBoxColumn.DataPropertyName = "Logo Price"
        Me.LogoPriceDataGridViewTextBoxColumn.HeaderText = "Logo Price"
        Me.LogoPriceDataGridViewTextBoxColumn.Name = "LogoPriceDataGridViewTextBoxColumn"
        '
        'PricePerShoeDataGridViewTextBoxColumn
        '
        Me.PricePerShoeDataGridViewTextBoxColumn.DataPropertyName = "Price Per Shoe"
        Me.PricePerShoeDataGridViewTextBoxColumn.HeaderText = "Price Per Shoe"
        Me.PricePerShoeDataGridViewTextBoxColumn.Name = "PricePerShoeDataGridViewTextBoxColumn"
        '
        'Vat23DataGridViewTextBoxColumn
        '
        Me.Vat23DataGridViewTextBoxColumn.DataPropertyName = "Vat 23%"
        Me.Vat23DataGridViewTextBoxColumn.HeaderText = "Vat 23%"
        Me.Vat23DataGridViewTextBoxColumn.Name = "Vat23DataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'TotalDueDataGridViewTextBoxColumn
        '
        Me.TotalDueDataGridViewTextBoxColumn.DataPropertyName = "Total Due"
        Me.TotalDueDataGridViewTextBoxColumn.HeaderText = "Total Due"
        Me.TotalDueDataGridViewTextBoxColumn.Name = "TotalDueDataGridViewTextBoxColumn"
        '
        'ServedByDataGridViewTextBoxColumn
        '
        Me.ServedByDataGridViewTextBoxColumn.DataPropertyName = "Served By"
        Me.ServedByDataGridViewTextBoxColumn.HeaderText = "Served By"
        Me.ServedByDataGridViewTextBoxColumn.Name = "ServedByDataGridViewTextBoxColumn"
        '
        'CustomersOrdersBindingSource
        '
        Me.CustomersOrdersBindingSource.DataMember = "Customers Orders"
        Me.CustomersOrdersBindingSource.DataSource = Me.BindingSource1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.Your_StyleDataSet2
        Me.BindingSource1.Position = 0
        '
        'Your_StyleDataSet2
        '
        Me.Your_StyleDataSet2.DataSetName = "Your_StyleDataSet2"
        Me.Your_StyleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(35, 208)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(115, 20)
        Me.lblDetails.TabIndex = 13
        Me.lblDetails.Text = "Order Details:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(900, 49)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(209, 22)
        Me.txtNumber.TabIndex = 12
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(520, 52)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(209, 22)
        Me.txtCustomer.TabIndex = 11
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(134, 48)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(209, 22)
        Me.txtOrder.TabIndex = 10
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(17, 45)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(92, 25)
        Me.lblOrder.TabIndex = 7
        Me.lblOrder.Text = "Order ID:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(745, 52)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(149, 25)
        Me.lblNumber.TabIndex = 9
        Me.lblNumber.Text = "Phone Number:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(364, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(150, 25)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Cutomer Name:"
        '
        'Customers_OrdersTableAdapter
        '
        Me.Customers_OrdersTableAdapter.ClearBeforeFill = True
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1244, 655)
        Me.Controls.Add(Me.grpOrder)
        Me.Controls.Add(Me.btnOrders)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "Orders"
        Me.Text = "Orders"
        Me.grpOrder.ResumeLayout(False)
        Me.grpOrder.PerformLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Your_StyleDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnQuery As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents lblDetails As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblName As Label
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Your_StyleDataSet2 As Your_StyleDataSet2
    Friend WithEvents CustomersOrdersBindingSource As BindingSource
    Friend WithEvents Customers_OrdersTableAdapter As Your_StyleDataSet2TableAdapters.Customers_OrdersTableAdapter
    Friend WithEvents NamesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShoeModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LogoProvidedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LacesColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EyestayColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VampColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuarterColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackCounterColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeelTabColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LacesPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EyestayPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VampPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuarterPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackCounterPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeelTabPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogoPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PricePerShoeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Vat23DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
End Class
