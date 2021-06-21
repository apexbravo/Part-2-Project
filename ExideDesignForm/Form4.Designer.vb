<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radfemale = New System.Windows.Forms.RadioButton()
        Me.Radmale = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesDataSet = New ExideDesignForm.EmployeesDataSet()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeTableTableAdapter = New ExideDesignForm.EmployeesDataSetTableAdapters.EmployeeTableTableAdapter()
        Me.TableAdapterManager = New ExideDesignForm.EmployeesDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmployeeTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Btnprevious = New System.Windows.Forms.Button()
        Me.Btnnext = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Btnmainmenu = New System.Windows.Forms.Button()
        Me.Btnlogout = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeTableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(165, 19)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(20, 14)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(165, 57)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(67, 14)
        First_NameLabel.TabIndex = 2
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(423, 51)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(165, 95)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(53, 14)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_BirthLabel.Location = New System.Drawing.Point(165, 134)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(77, 14)
        Date_Of_BirthLabel.TabIndex = 8
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(487, 134)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 14)
        AgeLabel.TabIndex = 10
        AgeLabel.Text = "Age:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexLabel.Location = New System.Drawing.Point(165, 178)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(27, 14)
        SexLabel.TabIndex = 12
        SexLabel.Text = "Sex:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(165, 221)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(72, 14)
        DepartmentLabel.TabIndex = 14
        DepartmentLabel.Text = "Department:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(437, 218)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(47, 13)
        ContactLabel.TabIndex = 16
        ContactLabel.Text = "Contact:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalaryLabel.Location = New System.Drawing.Point(443, 260)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(41, 14)
        SalaryLabel.TabIndex = 18
        SalaryLabel.Text = "Salary:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Radfemale)
        Me.GroupBox1.Controls.Add(Me.Radmale)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Date_Of_BirthLabel)
        Me.GroupBox1.Controls.Add(Me.Date_Of_BirthDateTimePicker)
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(SexLabel)
        Me.GroupBox1.Controls.Add(Me.SexTextBox)
        Me.GroupBox1.Controls.Add(DepartmentLabel)
        Me.GroupBox1.Controls.Add(Me.DepartmentTextBox)
        Me.GroupBox1.Controls.Add(ContactLabel)
        Me.GroupBox1.Controls.Add(Me.ContactTextBox)
        Me.GroupBox1.Controls.Add(SalaryLabel)
        Me.GroupBox1.Controls.Add(Me.SalaryTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 306)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Radfemale
        '
        Me.Radfemale.AutoSize = True
        Me.Radfemale.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radfemale.Location = New System.Drawing.Point(520, 179)
        Me.Radfemale.Name = "Radfemale"
        Me.Radfemale.Size = New System.Drawing.Size(63, 18)
        Me.Radfemale.TabIndex = 24
        Me.Radfemale.TabStop = True
        Me.Radfemale.Text = "Female"
        Me.Radfemale.UseVisualStyleBackColor = True
        '
        'Radmale
        '
        Me.Radmale.AutoSize = True
        Me.Radmale.Font = New System.Drawing.Font("Bariol Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radmale.Location = New System.Drawing.Point(398, 181)
        Me.Radmale.Name = "Radmale"
        Me.Radmale.Size = New System.Drawing.Size(50, 18)
        Me.Radmale.TabIndex = 23
        Me.Radmale.TabStop = True
        Me.Radmale.Text = "Male"
        Me.Radmale.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(257, 12)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(146, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'EmployeeTableBindingSource
        '
        Me.EmployeeTableBindingSource.DataMember = "EmployeeTable"
        Me.EmployeeTableBindingSource.DataSource = Me.EmployeesDataSet
        '
        'EmployeesDataSet
        '
        Me.EmployeesDataSet.DataSetName = "EmployeesDataSet"
        Me.EmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(257, 51)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(160, 20)
        Me.First_NameTextBox.TabIndex = 3
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(490, 51)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(257, 95)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(374, 20)
        Me.AddressTextBox.TabIndex = 7
        '
        'Date_Of_BirthDateTimePicker
        '
        Me.Date_Of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeTableBindingSource, "Date Of Birth", True))
        Me.Date_Of_BirthDateTimePicker.Location = New System.Drawing.Point(257, 134)
        Me.Date_Of_BirthDateTimePicker.Name = "Date_Of_BirthDateTimePicker"
        Me.Date_Of_BirthDateTimePicker.Size = New System.Drawing.Size(189, 20)
        Me.Date_Of_BirthDateTimePicker.TabIndex = 9
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(541, 134)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(38, 20)
        Me.AgeTextBox.TabIndex = 11
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(257, 178)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(83, 20)
        Me.SexTextBox.TabIndex = 13
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(257, 218)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(160, 20)
        Me.DepartmentTextBox.TabIndex = 15
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(490, 218)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(161, 20)
        Me.ContactTextBox.TabIndex = 17
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(490, 260)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(88, 20)
        Me.SalaryTextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bariol Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EMPLOYEE DETAILS"
        '
        'EmployeeTableTableAdapter
        '
        Me.EmployeeTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableTableAdapter = Me.EmployeeTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = ExideDesignForm.EmployeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeTableBindingNavigator
        '
        Me.EmployeeTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeTableBindingNavigator.BindingSource = Me.EmployeeTableBindingSource
        Me.EmployeeTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeeTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeTableBindingNavigatorSaveItem})
        Me.EmployeeTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeeTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeeTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeeTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeeTableBindingNavigator.Name = "EmployeeTableBindingNavigator"
        Me.EmployeeTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeeTableBindingNavigator.Size = New System.Drawing.Size(723, 25)
        Me.EmployeeTableBindingNavigator.TabIndex = 2
        Me.EmployeeTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmployeeTableBindingNavigatorSaveItem
        '
        Me.EmployeeTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeTableBindingNavigatorSaveItem.Name = "EmployeeTableBindingNavigatorSaveItem"
        Me.EmployeeTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeeTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Btnprevious
        '
        Me.Btnprevious.Location = New System.Drawing.Point(26, 403)
        Me.Btnprevious.Name = "Btnprevious"
        Me.Btnprevious.Size = New System.Drawing.Size(75, 38)
        Me.Btnprevious.TabIndex = 3
        Me.Btnprevious.Text = "<<<"
        Me.Btnprevious.UseVisualStyleBackColor = True
        '
        'Btnnext
        '
        Me.Btnnext.Location = New System.Drawing.Point(136, 403)
        Me.Btnnext.Name = "Btnnext"
        Me.Btnnext.Size = New System.Drawing.Size(75, 38)
        Me.Btnnext.TabIndex = 4
        Me.Btnnext.Text = ">>>"
        Me.Btnnext.UseVisualStyleBackColor = True
        '
        'Btnadd
        '
        Me.Btnadd.Font = New System.Drawing.Font("Bariol Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.Location = New System.Drawing.Point(234, 403)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(75, 38)
        Me.Btnadd.TabIndex = 5
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Font = New System.Drawing.Font("Bariol Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(334, 403)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(75, 38)
        Me.Btndelete.TabIndex = 6
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.Font = New System.Drawing.Font("Bariol Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.Location = New System.Drawing.Point(424, 403)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 38)
        Me.Btnsave.TabIndex = 7
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Btnmainmenu
        '
        Me.Btnmainmenu.Font = New System.Drawing.Font("Bariol Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmainmenu.Location = New System.Drawing.Point(516, 403)
        Me.Btnmainmenu.Name = "Btnmainmenu"
        Me.Btnmainmenu.Size = New System.Drawing.Size(90, 38)
        Me.Btnmainmenu.TabIndex = 9
        Me.Btnmainmenu.Text = "Main Menu"
        Me.Btnmainmenu.UseVisualStyleBackColor = True
        '
        'Btnlogout
        '
        Me.Btnlogout.Font = New System.Drawing.Font("Bariol Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogout.Location = New System.Drawing.Point(623, 403)
        Me.Btnlogout.Name = "Btnlogout"
        Me.Btnlogout.Size = New System.Drawing.Size(75, 38)
        Me.Btnlogout.TabIndex = 10
        Me.Btnlogout.Text = "Logout"
        Me.Btnlogout.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(723, 466)
        Me.Controls.Add(Me.Btnlogout)
        Me.Controls.Add(Me.Btnmainmenu)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Btnnext)
        Me.Controls.Add(Me.Btnprevious)
        Me.Controls.Add(Me.EmployeeTableBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeTableBindingNavigator.ResumeLayout(False)
        Me.EmployeeTableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmployeesDataSet As ExideDesignForm.EmployeesDataSet
    Friend WithEvents EmployeeTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableTableAdapter As ExideDesignForm.EmployeesDataSetTableAdapters.EmployeeTableTableAdapter
    Friend WithEvents TableAdapterManager As ExideDesignForm.EmployeesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeTableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmployeeTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Radfemale As System.Windows.Forms.RadioButton
    Friend WithEvents Radmale As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Of_BirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btnprevious As System.Windows.Forms.Button
    Friend WithEvents Btnnext As System.Windows.Forms.Button
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btnmainmenu As System.Windows.Forms.Button
    Friend WithEvents Btnlogout As System.Windows.Forms.Button
End Class
