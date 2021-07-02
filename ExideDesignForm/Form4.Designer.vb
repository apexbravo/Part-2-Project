<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdateTime = New System.Windows.Forms.TextBox()
        Me.EmployeeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesDataSet = New ExideDesignForm.EmployeesDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeTableTableAdapter = New ExideDesignForm.EmployeesDataSetTableAdapters.EmployeeTableTableAdapter()
        Me.TableAdapterManager = New ExideDesignForm.EmployeesDataSetTableAdapters.TableAdapterManager()
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
        DepartmentLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(212, 19)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(31, 19)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(146, 52)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(97, 19)
        First_NameLabel.TabIndex = 2
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(423, 49)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(86, 18)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(164, 96)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(79, 19)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_BirthLabel.Location = New System.Drawing.Point(190, 134)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(53, 19)
        Date_Of_BirthLabel.TabIndex = 8
        Date_Of_BirthLabel.Text = "D.O.B"
        AddHandler Date_Of_BirthLabel.Click, AddressOf Me.Date_Of_BirthLabel_Click
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(487, 134)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(39, 18)
        AgeLabel.TabIndex = 10
        AgeLabel.Text = "Age:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(139, 177)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(104, 19)
        DepartmentLabel.TabIndex = 14
        DepartmentLabel.Text = "Department:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.Location = New System.Drawing.Point(423, 179)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(67, 18)
        ContactLabel.TabIndex = 16
        ContactLabel.Text = "Contact:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalaryLabel.Location = New System.Drawing.Point(434, 220)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(55, 18)
        SalaryLabel.TabIndex = 18
        SalaryLabel.Text = "Salary:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdateTime)
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
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(DepartmentLabel)
        Me.GroupBox1.Controls.Add(Me.DepartmentTextBox)
        Me.GroupBox1.Controls.Add(ContactLabel)
        Me.GroupBox1.Controls.Add(Me.ContactTextBox)
        Me.GroupBox1.Controls.Add(SalaryLabel)
        Me.GroupBox1.Controls.Add(Me.SalaryTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(699, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 306)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtdateTime
        '
        Me.txtdateTime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Last Name", True))
        Me.txtdateTime.Location = New System.Drawing.Point(256, 132)
        Me.txtdateTime.Name = "txtdateTime"
        Me.txtdateTime.Size = New System.Drawing.Size(141, 20)
        Me.txtdateTime.TabIndex = 23
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 19)
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
        Me.Last_NameTextBox.Location = New System.Drawing.Point(510, 49)
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
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(541, 134)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(38, 20)
        Me.AgeTextBox.TabIndex = 11
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(257, 177)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(160, 20)
        Me.DepartmentTextBox.TabIndex = 15
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(490, 177)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(161, 20)
        Me.ContactTextBox.TabIndex = 17
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTableBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(490, 219)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(88, 20)
        Me.SalaryTextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(269, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 22)
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
        Me.Btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.Location = New System.Drawing.Point(234, 403)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(75, 38)
        Me.Btnadd.TabIndex = 5
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(334, 403)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(75, 38)
        Me.Btndelete.TabIndex = 6
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.Location = New System.Drawing.Point(424, 403)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 38)
        Me.Btnsave.TabIndex = 7
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Btnmainmenu
        '
        Me.Btnmainmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmainmenu.Location = New System.Drawing.Point(516, 403)
        Me.Btnmainmenu.Name = "Btnmainmenu"
        Me.Btnmainmenu.Size = New System.Drawing.Size(90, 38)
        Me.Btnmainmenu.TabIndex = 9
        Me.Btnmainmenu.Text = "Main Menu"
        Me.Btnmainmenu.UseVisualStyleBackColor = True
        '
        'Btnlogout
        '
        Me.Btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogout.Location = New System.Drawing.Point(623, 403)
        Me.Btnlogout.Name = "Btnlogout"
        Me.Btnlogout.Size = New System.Drawing.Size(75, 38)
        Me.Btnlogout.TabIndex = 10
        Me.Btnlogout.Text = "Clear"
        Me.Btnlogout.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(723, 466)
        Me.Controls.Add(Me.Btnlogout)
        Me.Controls.Add(Me.Btnmainmenu)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Btnnext)
        Me.Controls.Add(Me.Btnprevious)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmployeesDataSet As ExideDesignForm.EmployeesDataSet
    Friend WithEvents EmployeeTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableTableAdapter As ExideDesignForm.EmployeesDataSetTableAdapters.EmployeeTableTableAdapter
    Friend WithEvents TableAdapterManager As ExideDesignForm.EmployeesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents txtdateTime As System.Windows.Forms.TextBox
End Class
