<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuatity = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtProduct_ID = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Receipt = New System.Windows.Forms.TabControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNumberOfItems = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatterIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatteryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatteryTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBoughtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSoldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Project1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._project__1_DataSet = New ExideDesignForm._project__1_DataSet()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtTotal_Amount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtProduct_cost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Project1TableAdapter = New ExideDesignForm._project__1_DataSetTableAdapters.project1TableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Receipt.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._project__1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SALES_FORM"
        '
        'txtQuatity
        '
        Me.txtQuatity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuatity.Location = New System.Drawing.Point(99, 66)
        Me.txtQuatity.Multiline = True
        Me.txtQuatity.Name = "txtQuatity"
        Me.txtQuatity.Size = New System.Drawing.Size(177, 22)
        Me.txtQuatity.TabIndex = 7
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(99, 100)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(177, 22)
        Me.txtAmount.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Amount Paid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product_ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.txtQuatity)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtProduct_ID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 144)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Items"
        '
        'txtProduct_ID
        '
        Me.txtProduct_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct_ID.Location = New System.Drawing.Point(99, 30)
        Me.txtProduct_ID.Multiline = True
        Me.txtProduct_ID.Name = "txtProduct_ID"
        Me.txtProduct_ID.Size = New System.Drawing.Size(177, 22)
        Me.txtProduct_ID.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(266, 337)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Receipt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 284)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(244, 37)
        Me.btnEnter.TabIndex = 17
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage1.Controls.Add(Me.btnEnter)
        Me.TabPage1.Controls.Add(Me.btnMult)
        Me.TabPage1.Controls.Add(Me.btncancel)
        Me.TabPage1.Controls.Add(Me.btnDec)
        Me.TabPage1.Controls.Add(Me.btn0)
        Me.TabPage1.Controls.Add(Me.btnDiv)
        Me.TabPage1.Controls.Add(Me.btnSub)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.btn9)
        Me.TabPage1.Controls.Add(Me.btn8)
        Me.TabPage1.Controls.Add(Me.btn7)
        Me.TabPage1.Controls.Add(Me.btn6)
        Me.TabPage1.Controls.Add(Me.btn5)
        Me.TabPage1.Controls.Add(Me.bt2)
        Me.TabPage1.Controls.Add(Me.btn3)
        Me.TabPage1.Controls.Add(Me.btn4)
        Me.TabPage1.Controls.Add(Me.btn1)
        Me.TabPage1.Controls.Add(Me.txtInput)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(266, 337)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calculator"
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(206, 223)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(50, 37)
        Me.btnMult.TabIndex = 16
        Me.btnMult.Text = "x"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(124, 225)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(50, 37)
        Me.btncancel.TabIndex = 15
        Me.btncancel.Text = "CE"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnDec
        '
        Me.btnDec.Location = New System.Drawing.Point(68, 226)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(50, 37)
        Me.btnDec.TabIndex = 14
        Me.btnDec.Text = "."
        Me.btnDec.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(12, 226)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(50, 37)
        Me.btn0.TabIndex = 13
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(206, 182)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(50, 37)
        Me.btnDiv.TabIndex = 12
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(206, 138)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(50, 37)
        Me.btnSub.TabIndex = 11
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(206, 96)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 37)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(124, 182)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(50, 37)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(68, 183)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(50, 37)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(12, 183)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(50, 37)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(124, 139)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(50, 37)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(68, 140)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(50, 37)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'bt2
        '
        Me.bt2.Location = New System.Drawing.Point(68, 96)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(50, 37)
        Me.bt2.TabIndex = 4
        Me.bt2.Text = "2"
        Me.bt2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(124, 96)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(50, 37)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(12, 140)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(50, 37)
        Me.btn4.TabIndex = 2
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 96)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(50, 37)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Quartz", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(12, 27)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(244, 53)
        Me.txtInput.TabIndex = 0
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Receipt
        '
        Me.Receipt.Controls.Add(Me.TabPage1)
        Me.Receipt.Controls.Add(Me.TabPage2)
        Me.Receipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receipt.Location = New System.Drawing.Point(6, 9)
        Me.Receipt.Name = "Receipt"
        Me.Receipt.SelectedIndex = 0
        Me.Receipt.Size = New System.Drawing.Size(274, 366)
        Me.Receipt.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Receipt)
        Me.GroupBox3.Location = New System.Drawing.Point(584, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(282, 391)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtNumberOfItems
        '
        Me.txtNumberOfItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfItems.Location = New System.Drawing.Point(110, 25)
        Me.txtNumberOfItems.Multiline = True
        Me.txtNumberOfItems.Name = "txtNumberOfItems"
        Me.txtNumberOfItems.Size = New System.Drawing.Size(137, 22)
        Me.txtNumberOfItems.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Discount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Number of  items"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.btnMain)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(-6, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 459)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(681, 406)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(93, 48)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.Location = New System.Drawing.Point(584, 405)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(91, 48)
        Me.btnMain.TabIndex = 9
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BatterIdDataGridViewTextBoxColumn, Me.BatteryNameDataGridViewTextBoxColumn, Me.BatteryTypeDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.DateBoughtDataGridViewTextBoxColumn, Me.DateSoldDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PackageNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Project1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 309)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(563, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'BatterIdDataGridViewTextBoxColumn
        '
        Me.BatterIdDataGridViewTextBoxColumn.DataPropertyName = "BatterId"
        Me.BatterIdDataGridViewTextBoxColumn.HeaderText = "BatterId"
        Me.BatterIdDataGridViewTextBoxColumn.Name = "BatterIdDataGridViewTextBoxColumn"
        '
        'BatteryNameDataGridViewTextBoxColumn
        '
        Me.BatteryNameDataGridViewTextBoxColumn.DataPropertyName = "BatteryName"
        Me.BatteryNameDataGridViewTextBoxColumn.HeaderText = "BatteryName"
        Me.BatteryNameDataGridViewTextBoxColumn.Name = "BatteryNameDataGridViewTextBoxColumn"
        '
        'BatteryTypeDataGridViewTextBoxColumn
        '
        Me.BatteryTypeDataGridViewTextBoxColumn.DataPropertyName = "BatteryType"
        Me.BatteryTypeDataGridViewTextBoxColumn.HeaderText = "BatteryType"
        Me.BatteryTypeDataGridViewTextBoxColumn.Name = "BatteryTypeDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'DateBoughtDataGridViewTextBoxColumn
        '
        Me.DateBoughtDataGridViewTextBoxColumn.DataPropertyName = "DateBought"
        Me.DateBoughtDataGridViewTextBoxColumn.HeaderText = "DateBought"
        Me.DateBoughtDataGridViewTextBoxColumn.Name = "DateBoughtDataGridViewTextBoxColumn"
        '
        'DateSoldDataGridViewTextBoxColumn
        '
        Me.DateSoldDataGridViewTextBoxColumn.DataPropertyName = "DateSold"
        Me.DateSoldDataGridViewTextBoxColumn.HeaderText = "DateSold"
        Me.DateSoldDataGridViewTextBoxColumn.Name = "DateSoldDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'PackageNumberDataGridViewTextBoxColumn
        '
        Me.PackageNumberDataGridViewTextBoxColumn.DataPropertyName = "PackageNumber"
        Me.PackageNumberDataGridViewTextBoxColumn.HeaderText = "PackageNumber"
        Me.PackageNumberDataGridViewTextBoxColumn.Name = "PackageNumberDataGridViewTextBoxColumn"
        '
        'Project1BindingSource
        '
        Me.Project1BindingSource.DataMember = "project1"
        Me.Project1BindingSource.DataSource = Me.Project1DataSetBindingSource
        '
        'Project1DataSetBindingSource
        '
        Me.Project1DataSetBindingSource.DataSource = Me._project__1_DataSet
        Me.Project1DataSetBindingSource.Position = 0
        '
        '_project__1_DataSet
        '
        Me._project__1_DataSet.DataSetName = "_project__1_DataSet"
        Me._project__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(317, 178)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(243, 43)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(317, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(243, 43)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = CType(resources.GetObject("GroupBox5.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtChange)
        Me.GroupBox5.Controls.Add(Me.txtTotal_Amount)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtTax)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 174)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(281, 125)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total Cost"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Change"
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(94, 90)
        Me.txtChange.Multiline = True
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(177, 22)
        Me.txtChange.TabIndex = 16
        '
        'txtTotal_Amount
        '
        Me.txtTotal_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal_Amount.Location = New System.Drawing.Point(94, 59)
        Me.txtTotal_Amount.Multiline = True
        Me.txtTotal_Amount.Name = "txtTotal_Amount"
        Me.txtTotal_Amount.Size = New System.Drawing.Size(177, 22)
        Me.txtTotal_Amount.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Total Amount"
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(94, 25)
        Me.txtTax.Multiline = True
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(177, 22)
        Me.txtTax.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tax"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.txtProduct_cost)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtDiscount)
        Me.GroupBox4.Controls.Add(Me.txtNumberOfItems)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(308, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(270, 139)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pricing"
        '
        'txtProduct_cost
        '
        Me.txtProduct_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct_cost.Location = New System.Drawing.Point(110, 95)
        Me.txtProduct_cost.Multiline = True
        Me.txtProduct_cost.Name = "txtProduct_cost"
        Me.txtProduct_cost.Size = New System.Drawing.Size(137, 22)
        Me.txtProduct_cost.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Product cost"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(110, 61)
        Me.txtDiscount.Multiline = True
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(137, 22)
        Me.txtDiscount.TabIndex = 11
        '
        'Project1TableAdapter
        '
        Me.Project1TableAdapter.ClearBeforeFill = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(867, 522)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form6"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Receipt.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._project__1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuatity As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProduct_ID As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnMult As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnDec As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents bt2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Receipt As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumberOfItems As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProduct_cost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Project1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _project__1_DataSet As ExideDesignForm._project__1_DataSet
    Friend WithEvents Project1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Project1TableAdapter As ExideDesignForm._project__1_DataSetTableAdapters.project1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatterIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatteryNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatteryTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateBoughtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSoldDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackageNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
