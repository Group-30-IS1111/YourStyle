<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.cboQuantity = New System.Windows.Forms.ComboBox()
        Me.txtModel2 = New System.Windows.Forms.TextBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPerShoe = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblHeelTab2 = New System.Windows.Forms.Label()
        Me.lblBackCounter2 = New System.Windows.Forms.Label()
        Me.lblLogo3 = New System.Windows.Forms.Label()
        Me.lblQuarter2 = New System.Windows.Forms.Label()
        Me.lvlVamp2 = New System.Windows.Forms.Label()
        Me.lblEyestay2 = New System.Windows.Forms.Label()
        Me.lblLaces2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblHeelTab = New System.Windows.Forms.Label()
        Me.lblBackCounter = New System.Windows.Forms.Label()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.lvlVamp = New System.Windows.Forms.Label()
        Me.lblEyestay = New System.Windows.Forms.Label()
        Me.lblLaces = New System.Windows.Forms.Label()
        Me.txtServedBy = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtTotalDue = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtHeelTab2 = New System.Windows.Forms.TextBox()
        Me.txtBackCounter2 = New System.Windows.Forms.TextBox()
        Me.txtLogo3 = New System.Windows.Forms.TextBox()
        Me.txtQuarter2 = New System.Windows.Forms.TextBox()
        Me.txtVamp2 = New System.Windows.Forms.TextBox()
        Me.txtEyestay2 = New System.Windows.Forms.TextBox()
        Me.txtLaces2 = New System.Windows.Forms.TextBox()
        Me.txtHeelTab = New System.Windows.Forms.TextBox()
        Me.txtBackCounter = New System.Windows.Forms.TextBox()
        Me.txtQuarter = New System.Windows.Forms.TextBox()
        Me.txtVamp = New System.Windows.Forms.TextBox()
        Me.txtEyestay = New System.Windows.Forms.TextBox()
        Me.txtLaces = New System.Windows.Forms.TextBox()
        Me.txtProvided = New System.Windows.Forms.TextBox()
        Me.txtLogo = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.lblServed = New System.Windows.Forms.Label()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblProvided = New System.Windows.Forms.Label()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblCustomized = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnCustomize = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Your_StyleDataSet = New YourStyle.Your_StyleDataSet()
        Me.Customers_OrdersTableAdapter = New YourStyle.Your_StyleDataSetTableAdapters.Customers_OrdersTableAdapter()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.grpOrder.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Your_StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOrder
        '
        Me.grpOrder.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.grpOrder.Controls.Add(Me.grpTotal)
        Me.grpOrder.Controls.Add(Me.txtModel2)
        Me.grpOrder.Controls.Add(Me.lblModel)
        Me.grpOrder.Controls.Add(Me.btnPrevious)
        Me.grpOrder.Controls.Add(Me.btnTotal)
        Me.grpOrder.Controls.Add(Me.lblHeelTab2)
        Me.grpOrder.Controls.Add(Me.lblBackCounter2)
        Me.grpOrder.Controls.Add(Me.lblLogo3)
        Me.grpOrder.Controls.Add(Me.lblQuarter2)
        Me.grpOrder.Controls.Add(Me.lvlVamp2)
        Me.grpOrder.Controls.Add(Me.lblEyestay2)
        Me.grpOrder.Controls.Add(Me.lblLaces2)
        Me.grpOrder.Controls.Add(Me.DateTimePicker1)
        Me.grpOrder.Controls.Add(Me.lblHeelTab)
        Me.grpOrder.Controls.Add(Me.lblBackCounter)
        Me.grpOrder.Controls.Add(Me.lblQuarter)
        Me.grpOrder.Controls.Add(Me.lvlVamp)
        Me.grpOrder.Controls.Add(Me.lblEyestay)
        Me.grpOrder.Controls.Add(Me.lblLaces)
        Me.grpOrder.Controls.Add(Me.txtServedBy)
        Me.grpOrder.Controls.Add(Me.txtSize)
        Me.grpOrder.Controls.Add(Me.txtHeelTab2)
        Me.grpOrder.Controls.Add(Me.txtBackCounter2)
        Me.grpOrder.Controls.Add(Me.txtLogo3)
        Me.grpOrder.Controls.Add(Me.txtQuarter2)
        Me.grpOrder.Controls.Add(Me.txtVamp2)
        Me.grpOrder.Controls.Add(Me.txtEyestay2)
        Me.grpOrder.Controls.Add(Me.txtLaces2)
        Me.grpOrder.Controls.Add(Me.txtHeelTab)
        Me.grpOrder.Controls.Add(Me.txtBackCounter)
        Me.grpOrder.Controls.Add(Me.txtQuarter)
        Me.grpOrder.Controls.Add(Me.txtVamp)
        Me.grpOrder.Controls.Add(Me.txtEyestay)
        Me.grpOrder.Controls.Add(Me.txtLaces)
        Me.grpOrder.Controls.Add(Me.txtProvided)
        Me.grpOrder.Controls.Add(Me.txtLogo)
        Me.grpOrder.Controls.Add(Me.txtModel)
        Me.grpOrder.Controls.Add(Me.txtNumber)
        Me.grpOrder.Controls.Add(Me.txtAddress)
        Me.grpOrder.Controls.Add(Me.txtName)
        Me.grpOrder.Controls.Add(Me.txtOrder)
        Me.grpOrder.Controls.Add(Me.lblServed)
        Me.grpOrder.Controls.Add(Me.lblCharge)
        Me.grpOrder.Controls.Add(Me.lblSize)
        Me.grpOrder.Controls.Add(Me.lblDescription)
        Me.grpOrder.Controls.Add(Me.lblProvided)
        Me.grpOrder.Controls.Add(Me.lblLogo)
        Me.grpOrder.Controls.Add(Me.lblCustomized)
        Me.grpOrder.Controls.Add(Me.lblNumber)
        Me.grpOrder.Controls.Add(Me.lblAddress)
        Me.grpOrder.Controls.Add(Me.lblName)
        Me.grpOrder.Controls.Add(Me.lblDate)
        Me.grpOrder.Controls.Add(Me.lblOrder)
        Me.grpOrder.Location = New System.Drawing.Point(72, 62)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(1068, 657)
        Me.grpOrder.TabIndex = 8
        Me.grpOrder.TabStop = False
        Me.grpOrder.Text = "Order Form"
        '
        'cboQuantity
        '
        Me.cboQuantity.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.BindingSource1, "Quantity", True))
        Me.cboQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuantity.FormattingEnabled = True
        Me.cboQuantity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboQuantity.Location = New System.Drawing.Point(183, 137)
        Me.cboQuantity.Name = "cboQuantity"
        Me.cboQuantity.Size = New System.Drawing.Size(100, 24)
        Me.cboQuantity.TabIndex = 3
        '
        'txtModel2
        '
        Me.txtModel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Model Price", True))
        Me.txtModel2.Location = New System.Drawing.Point(493, 189)
        Me.txtModel2.Name = "txtModel2"
        Me.txtModel2.ReadOnly = True
        Me.txtModel2.Size = New System.Drawing.Size(100, 22)
        Me.txtModel2.TabIndex = 14
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(395, 189)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(50, 17)
        Me.lblModel.TabIndex = 62
        Me.lblModel.Text = "Model:"
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(438, 418)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(110, 32)
        Me.btnTotal.TabIndex = 22
        Me.btnTotal.Text = "Calculate"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(17, 181)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(143, 17)
        Me.lblTotal.TabIndex = 60
        Me.lblTotal.Text = "Total Amount Due:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(17, 140)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(139, 17)
        Me.lblQuantity.TabIndex = 59
        Me.lblQuantity.Text = "Quantity Ordered:"
        '
        'lblPerShoe
        '
        Me.lblPerShoe.AutoSize = True
        Me.lblPerShoe.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerShoe.Location = New System.Drawing.Point(18, 104)
        Me.lblPerShoe.Name = "lblPerShoe"
        Me.lblPerShoe.Size = New System.Drawing.Size(122, 17)
        Me.lblPerShoe.TabIndex = 58
        Me.lblPerShoe.Text = "Total Per Shoe:"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(18, 68)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(93, 17)
        Me.lblVat.TabIndex = 57
        Me.lblVat.Text = "Vat @ 23%:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(18, 35)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(122, 17)
        Me.lblPrice.TabIndex = 56
        Me.lblPrice.Text = "Price Per Shoe:"
        '
        'lblHeelTab2
        '
        Me.lblHeelTab2.AutoSize = True
        Me.lblHeelTab2.Location = New System.Drawing.Point(396, 355)
        Me.lblHeelTab2.Name = "lblHeelTab2"
        Me.lblHeelTab2.Size = New System.Drawing.Size(70, 17)
        Me.lblHeelTab2.TabIndex = 55
        Me.lblHeelTab2.Text = "Heel Tab:"
        '
        'lblBackCounter2
        '
        Me.lblBackCounter2.AutoSize = True
        Me.lblBackCounter2.Location = New System.Drawing.Point(396, 327)
        Me.lblBackCounter2.Name = "lblBackCounter2"
        Me.lblBackCounter2.Size = New System.Drawing.Size(97, 17)
        Me.lblBackCounter2.TabIndex = 54
        Me.lblBackCounter2.Text = "Back Counter:"
        '
        'lblLogo3
        '
        Me.lblLogo3.AutoSize = True
        Me.lblLogo3.Location = New System.Drawing.Point(399, 383)
        Me.lblLogo3.Name = "lblLogo3"
        Me.lblLogo3.Size = New System.Drawing.Size(44, 17)
        Me.lblLogo3.TabIndex = 53
        Me.lblLogo3.Text = "Logo:"
        '
        'lblQuarter2
        '
        Me.lblQuarter2.AutoSize = True
        Me.lblQuarter2.Location = New System.Drawing.Point(396, 299)
        Me.lblQuarter2.Name = "lblQuarter2"
        Me.lblQuarter2.Size = New System.Drawing.Size(61, 17)
        Me.lblQuarter2.TabIndex = 52
        Me.lblQuarter2.Text = "Quarter:"
        '
        'lvlVamp2
        '
        Me.lvlVamp2.AutoSize = True
        Me.lvlVamp2.Location = New System.Drawing.Point(395, 271)
        Me.lvlVamp2.Name = "lvlVamp2"
        Me.lvlVamp2.Size = New System.Drawing.Size(48, 17)
        Me.lvlVamp2.TabIndex = 51
        Me.lvlVamp2.Text = "Vamp:"
        '
        'lblEyestay2
        '
        Me.lblEyestay2.AutoSize = True
        Me.lblEyestay2.Location = New System.Drawing.Point(395, 243)
        Me.lblEyestay2.Name = "lblEyestay2"
        Me.lblEyestay2.Size = New System.Drawing.Size(62, 17)
        Me.lblEyestay2.TabIndex = 50
        Me.lblEyestay2.Text = "Eyestay:"
        '
        'lblLaces2
        '
        Me.lblLaces2.AutoSize = True
        Me.lblLaces2.Location = New System.Drawing.Point(395, 215)
        Me.lblLaces2.Name = "lblLaces2"
        Me.lblLaces2.Size = New System.Drawing.Size(50, 17)
        Me.lblLaces2.TabIndex = 49
        Me.lblLaces2.Text = "Laces:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(683, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lblHeelTab
        '
        Me.lblHeelTab.AutoSize = True
        Me.lblHeelTab.Location = New System.Drawing.Point(32, 331)
        Me.lblHeelTab.Name = "lblHeelTab"
        Me.lblHeelTab.Size = New System.Drawing.Size(70, 17)
        Me.lblHeelTab.TabIndex = 47
        Me.lblHeelTab.Text = "Heel Tab:"
        '
        'lblBackCounter
        '
        Me.lblBackCounter.AutoSize = True
        Me.lblBackCounter.Location = New System.Drawing.Point(33, 303)
        Me.lblBackCounter.Name = "lblBackCounter"
        Me.lblBackCounter.Size = New System.Drawing.Size(97, 17)
        Me.lblBackCounter.TabIndex = 46
        Me.lblBackCounter.Text = "Back Counter:"
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Location = New System.Drawing.Point(33, 275)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(61, 17)
        Me.lblQuarter.TabIndex = 44
        Me.lblQuarter.Text = "Quarter:"
        '
        'lvlVamp
        '
        Me.lvlVamp.AutoSize = True
        Me.lvlVamp.Location = New System.Drawing.Point(33, 247)
        Me.lvlVamp.Name = "lvlVamp"
        Me.lvlVamp.Size = New System.Drawing.Size(48, 17)
        Me.lvlVamp.TabIndex = 43
        Me.lvlVamp.Text = "Vamp:"
        '
        'lblEyestay
        '
        Me.lblEyestay.AutoSize = True
        Me.lblEyestay.Location = New System.Drawing.Point(32, 220)
        Me.lblEyestay.Name = "lblEyestay"
        Me.lblEyestay.Size = New System.Drawing.Size(62, 17)
        Me.lblEyestay.TabIndex = 42
        Me.lblEyestay.Text = "Eyestay:"
        '
        'lblLaces
        '
        Me.lblLaces.AutoSize = True
        Me.lblLaces.Location = New System.Drawing.Point(33, 192)
        Me.lblLaces.Name = "lblLaces"
        Me.lblLaces.Size = New System.Drawing.Size(50, 17)
        Me.lblLaces.TabIndex = 41
        Me.lblLaces.Text = "Laces:"
        '
        'txtServedBy
        '
        Me.txtServedBy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Served By", True))
        Me.txtServedBy.Location = New System.Drawing.Point(136, 428)
        Me.txtServedBy.Name = "txtServedBy"
        Me.txtServedBy.Size = New System.Drawing.Size(100, 22)
        Me.txtServedBy.TabIndex = 24
        '
        'txtSize
        '
        Me.txtSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Size", True))
        Me.txtSize.Location = New System.Drawing.Point(136, 378)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 22)
        Me.txtSize.TabIndex = 23
        '
        'txtTotalDue
        '
        Me.txtTotalDue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Total Due", True))
        Me.txtTotalDue.Location = New System.Drawing.Point(183, 181)
        Me.txtTotalDue.Name = "txtTotalDue"
        Me.txtTotalDue.ReadOnly = True
        Me.txtTotalDue.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalDue.TabIndex = 4
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Total", True))
        Me.txtTotal.Location = New System.Drawing.Point(183, 102)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTotal.TabIndex = 2
        '
        'txtVat
        '
        Me.txtVat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Vat 23%", True))
        Me.txtVat.Location = New System.Drawing.Point(183, 65)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(100, 22)
        Me.txtVat.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Price Per Shoe", True))
        Me.txtPrice.Location = New System.Drawing.Point(183, 30)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 0
        '
        'txtHeelTab2
        '
        Me.txtHeelTab2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Heel Tab Price", True))
        Me.txtHeelTab2.Location = New System.Drawing.Point(493, 357)
        Me.txtHeelTab2.Name = "txtHeelTab2"
        Me.txtHeelTab2.ReadOnly = True
        Me.txtHeelTab2.Size = New System.Drawing.Size(100, 22)
        Me.txtHeelTab2.TabIndex = 20
        '
        'txtBackCounter2
        '
        Me.txtBackCounter2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Back Counter Price", True))
        Me.txtBackCounter2.Location = New System.Drawing.Point(493, 329)
        Me.txtBackCounter2.Name = "txtBackCounter2"
        Me.txtBackCounter2.ReadOnly = True
        Me.txtBackCounter2.Size = New System.Drawing.Size(100, 22)
        Me.txtBackCounter2.TabIndex = 19
        '
        'txtLogo3
        '
        Me.txtLogo3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Logo Price", True))
        Me.txtLogo3.Location = New System.Drawing.Point(493, 385)
        Me.txtLogo3.Name = "txtLogo3"
        Me.txtLogo3.ReadOnly = True
        Me.txtLogo3.Size = New System.Drawing.Size(100, 22)
        Me.txtLogo3.TabIndex = 21
        '
        'txtQuarter2
        '
        Me.txtQuarter2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Quarter Price", True))
        Me.txtQuarter2.Location = New System.Drawing.Point(493, 301)
        Me.txtQuarter2.Name = "txtQuarter2"
        Me.txtQuarter2.ReadOnly = True
        Me.txtQuarter2.Size = New System.Drawing.Size(100, 22)
        Me.txtQuarter2.TabIndex = 18
        '
        'txtVamp2
        '
        Me.txtVamp2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Vamp Price", True))
        Me.txtVamp2.Location = New System.Drawing.Point(493, 273)
        Me.txtVamp2.Name = "txtVamp2"
        Me.txtVamp2.ReadOnly = True
        Me.txtVamp2.Size = New System.Drawing.Size(100, 22)
        Me.txtVamp2.TabIndex = 17
        '
        'txtEyestay2
        '
        Me.txtEyestay2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Eyestay Price", True))
        Me.txtEyestay2.Location = New System.Drawing.Point(493, 245)
        Me.txtEyestay2.Name = "txtEyestay2"
        Me.txtEyestay2.ReadOnly = True
        Me.txtEyestay2.Size = New System.Drawing.Size(100, 22)
        Me.txtEyestay2.TabIndex = 16
        '
        'txtLaces2
        '
        Me.txtLaces2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Laces Price", True))
        Me.txtLaces2.Location = New System.Drawing.Point(493, 217)
        Me.txtLaces2.Name = "txtLaces2"
        Me.txtLaces2.ReadOnly = True
        Me.txtLaces2.Size = New System.Drawing.Size(100, 22)
        Me.txtLaces2.TabIndex = 15
        '
        'txtHeelTab
        '
        Me.txtHeelTab.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Heel Tab Colour", True))
        Me.txtHeelTab.Location = New System.Drawing.Point(136, 328)
        Me.txtHeelTab.Name = "txtHeelTab"
        Me.txtHeelTab.ReadOnly = True
        Me.txtHeelTab.Size = New System.Drawing.Size(100, 22)
        Me.txtHeelTab.TabIndex = 13
        '
        'txtBackCounter
        '
        Me.txtBackCounter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Back Counter Colour", True))
        Me.txtBackCounter.Location = New System.Drawing.Point(136, 300)
        Me.txtBackCounter.Name = "txtBackCounter"
        Me.txtBackCounter.ReadOnly = True
        Me.txtBackCounter.Size = New System.Drawing.Size(100, 22)
        Me.txtBackCounter.TabIndex = 12
        '
        'txtQuarter
        '
        Me.txtQuarter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Quarter Colour", True))
        Me.txtQuarter.Location = New System.Drawing.Point(136, 272)
        Me.txtQuarter.Name = "txtQuarter"
        Me.txtQuarter.ReadOnly = True
        Me.txtQuarter.Size = New System.Drawing.Size(100, 22)
        Me.txtQuarter.TabIndex = 11
        '
        'txtVamp
        '
        Me.txtVamp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Vamp Colour", True))
        Me.txtVamp.Location = New System.Drawing.Point(136, 244)
        Me.txtVamp.Name = "txtVamp"
        Me.txtVamp.ReadOnly = True
        Me.txtVamp.Size = New System.Drawing.Size(100, 22)
        Me.txtVamp.TabIndex = 10
        '
        'txtEyestay
        '
        Me.txtEyestay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Eyestay Colour", True))
        Me.txtEyestay.Location = New System.Drawing.Point(136, 217)
        Me.txtEyestay.Name = "txtEyestay"
        Me.txtEyestay.ReadOnly = True
        Me.txtEyestay.Size = New System.Drawing.Size(100, 22)
        Me.txtEyestay.TabIndex = 9
        '
        'txtLaces
        '
        Me.txtLaces.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Laces Colour", True))
        Me.txtLaces.Location = New System.Drawing.Point(136, 189)
        Me.txtLaces.Name = "txtLaces"
        Me.txtLaces.ReadOnly = True
        Me.txtLaces.Size = New System.Drawing.Size(100, 22)
        Me.txtLaces.TabIndex = 8
        '
        'txtProvided
        '
        Me.txtProvided.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Logo Provided", True))
        Me.txtProvided.Location = New System.Drawing.Point(838, 123)
        Me.txtProvided.Name = "txtProvided"
        Me.txtProvided.ReadOnly = True
        Me.txtProvided.Size = New System.Drawing.Size(100, 22)
        Me.txtProvided.TabIndex = 7
        '
        'txtLogo
        '
        Me.txtLogo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Logo", True))
        Me.txtLogo.Location = New System.Drawing.Point(184, 128)
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.ReadOnly = True
        Me.txtLogo.Size = New System.Drawing.Size(154, 22)
        Me.txtLogo.TabIndex = 6
        '
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Shoe Model", True))
        Me.txtModel.Location = New System.Drawing.Point(838, 91)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(100, 22)
        Me.txtModel.TabIndex = 5
        '
        'txtNumber
        '
        Me.txtNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Phone Number", True))
        Me.txtNumber.Location = New System.Drawing.Point(184, 95)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(154, 22)
        Me.txtNumber.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(683, 63)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(255, 22)
        Me.txtAddress.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Name(s)", True))
        Me.txtName.Location = New System.Drawing.Point(184, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 22)
        Me.txtName.TabIndex = 2
        '
        'txtOrder
        '
        Me.txtOrder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Order ID", True))
        Me.txtOrder.Location = New System.Drawing.Point(184, 30)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.ReadOnly = True
        Me.txtOrder.Size = New System.Drawing.Size(154, 22)
        Me.txtOrder.TabIndex = 0
        '
        'lblServed
        '
        Me.lblServed.AutoSize = True
        Me.lblServed.Location = New System.Drawing.Point(33, 428)
        Me.lblServed.Name = "lblServed"
        Me.lblServed.Size = New System.Drawing.Size(77, 17)
        Me.lblServed.TabIndex = 11
        Me.lblServed.Text = "Served By:"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Location = New System.Drawing.Point(370, 163)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(150, 17)
        Me.lblCharge.TabIndex = 10
        Me.lblCharge.Text = "Customization Charge:"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(32, 388)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(39, 17)
        Me.lblSize.TabIndex = 9
        Me.lblSize.Text = "Size:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(6, 163)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(175, 17)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Customization Description:"
        '
        'lblProvided
        '
        Me.lblProvided.AutoSize = True
        Me.lblProvided.Location = New System.Drawing.Point(551, 128)
        Me.lblProvided.Name = "lblProvided"
        Me.lblProvided.Size = New System.Drawing.Size(248, 17)
        Me.lblProvided.TabIndex = 7
        Me.lblProvided.Text = "Provided by customer when ordering*:"
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(6, 131)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(44, 17)
        Me.lblLogo.TabIndex = 6
        Me.lblLogo.Text = "Logo:"
        '
        'lblCustomized
        '
        Me.lblCustomized.AutoSize = True
        Me.lblCustomized.Location = New System.Drawing.Point(551, 98)
        Me.lblCustomized.Name = "lblCustomized"
        Me.lblCustomized.Size = New System.Drawing.Size(198, 17)
        Me.lblCustomized.TabIndex = 5
        Me.lblCustomized.Text = "Shoe Model to be customized:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(6, 98)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(171, 17)
        Me.lblNumber.TabIndex = 4
        Me.lblNumber.Text = "Customer Phone Number:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(551, 63)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(128, 17)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Customer Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 63)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(113, 17)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Customer Name:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(551, 30)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 17)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(6, 33)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(66, 17)
        Me.lblOrder.TabIndex = 0
        Me.lblOrder.Text = "Order ID:"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(904, 581)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(158, 48)
        Me.btnPrevious.TabIndex = 65
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(1, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(389, 53)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnCustomize
        '
        Me.btnCustomize.Location = New System.Drawing.Point(387, 3)
        Me.btnCustomize.Name = "btnCustomize"
        Me.btnCustomize.Size = New System.Drawing.Size(417, 53)
        Me.btnCustomize.TabIndex = 1
        Me.btnCustomize.Text = "Customize Your Shoe"
        Me.btnCustomize.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Location = New System.Drawing.Point(796, 3)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(383, 53)
        Me.btnAccount.TabIndex = 2
        Me.btnAccount.Text = "Your Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Customers Orders"
        Me.BindingSource1.DataSource = Me.Your_StyleDataSet
        '
        'Your_StyleDataSet
        '
        Me.Your_StyleDataSet.DataSetName = "Your_StyleDataSet"
        Me.Your_StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customers_OrdersTableAdapter
        '
        Me.Customers_OrdersTableAdapter.ClearBeforeFill = True
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.btnBuy)
        Me.grpTotal.Controls.Add(Me.lblPrice)
        Me.grpTotal.Controls.Add(Me.cboQuantity)
        Me.grpTotal.Controls.Add(Me.lblVat)
        Me.grpTotal.Controls.Add(Me.lblPerShoe)
        Me.grpTotal.Controls.Add(Me.lblQuantity)
        Me.grpTotal.Controls.Add(Me.lblTotal)
        Me.grpTotal.Controls.Add(Me.txtPrice)
        Me.grpTotal.Controls.Add(Me.txtVat)
        Me.grpTotal.Controls.Add(Me.txtTotal)
        Me.grpTotal.Controls.Add(Me.txtTotalDue)
        Me.grpTotal.Location = New System.Drawing.Point(704, 178)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(306, 309)
        Me.grpTotal.TabIndex = 65
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Totals"
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(92, 236)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(110, 31)
        Me.btnBuy.TabIndex = 66
        Me.btnBuy.Text = "Add"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1217, 715)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.btnCustomize)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.grpOrder)
        Me.Name = "frmPayment"
        Me.Text = "Payment"
        Me.grpOrder.ResumeLayout(False)
        Me.grpOrder.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Your_StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTotal.ResumeLayout(False)
        Me.grpTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents cboQuantity As ComboBox
    Friend WithEvents txtModel2 As TextBox
    Friend WithEvents lblModel As Label
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPerShoe As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblHeelTab2 As Label
    Friend WithEvents lblBackCounter2 As Label
    Friend WithEvents lblLogo3 As Label
    Friend WithEvents lblQuarter2 As Label
    Friend WithEvents lvlVamp2 As Label
    Friend WithEvents lblEyestay2 As Label
    Friend WithEvents lblLaces2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblHeelTab As Label
    Friend WithEvents lblBackCounter As Label
    Friend WithEvents lblQuarter As Label
    Friend WithEvents lvlVamp As Label
    Friend WithEvents lblEyestay As Label
    Friend WithEvents lblLaces As Label
    Friend WithEvents txtServedBy As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtTotalDue As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtHeelTab2 As TextBox
    Friend WithEvents txtBackCounter2 As TextBox
    Friend WithEvents txtLogo3 As TextBox
    Friend WithEvents txtQuarter2 As TextBox
    Friend WithEvents txtVamp2 As TextBox
    Friend WithEvents txtEyestay2 As TextBox
    Friend WithEvents txtLaces2 As TextBox
    Friend WithEvents txtHeelTab As TextBox
    Friend WithEvents txtBackCounter As TextBox
    Friend WithEvents txtQuarter As TextBox
    Friend WithEvents txtVamp As TextBox
    Friend WithEvents txtEyestay As TextBox
    Friend WithEvents txtLaces As TextBox
    Friend WithEvents txtProvided As TextBox
    Friend WithEvents txtLogo As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents lblServed As Label
    Friend WithEvents lblCharge As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblProvided As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblCustomized As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnCustomize As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Your_StyleDataSet As Your_StyleDataSet
    Friend WithEvents Customers_OrdersTableAdapter As Your_StyleDataSetTableAdapters.Customers_OrdersTableAdapter
    Friend WithEvents grpTotal As GroupBox
    Friend WithEvents btnBuy As Button
End Class
