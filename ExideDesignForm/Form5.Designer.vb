<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me._project__1_DataSet = New ExideDesignForm._project__1_DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Project1TableAdapter = New ExideDesignForm._project__1_DataSetTableAdapters.project1TableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._project__1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(953, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BatterIdDataGridViewTextBoxColumn, Me.BatteryNameDataGridViewTextBoxColumn, Me.BatteryTypeDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.DateBoughtDataGridViewTextBoxColumn, Me.DateSoldDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PackageNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Project1BindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(5, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(942, 262)
        Me.DataGridView1.TabIndex = 0
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
        Me.Project1BindingSource.DataSource = Me._project__1_DataSet
        '
        '_project__1_DataSet
        '
        Me._project__1_DataSet.DataSetName = "_project__1_DataSet"
        Me._project__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product File"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "<<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 46)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = ">>>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 440)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 46)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(105, 440)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 46)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(196, 389)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 46)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(196, 441)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 46)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Main Menu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(466, 388)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(500, 389)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 28)
        Me.TextBox1.TabIndex = 10
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(500, 440)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(126, 46)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Search"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(130, 66)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 26)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Order"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(217, 66)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(70, 26)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "Invoice"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(131, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(217, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Project1TableAdapter
        '
        Me.Project1TableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(966, 494)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(982, 533)
        Me.Name = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._project__1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _project__1_DataSet As _project__1_DataSet
    Friend WithEvents Project1BindingSource As BindingSource
    Friend WithEvents Project1TableAdapter As _project__1_DataSetTableAdapters.project1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BatterIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BatteryNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BatteryTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateBoughtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateSoldDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackageNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
