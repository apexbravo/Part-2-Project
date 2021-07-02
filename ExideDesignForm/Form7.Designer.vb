<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.project1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._project__1_DataSet = New ExideDesignForm._project__1_DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.project1TableAdapter = New ExideDesignForm._project__1_DataSetTableAdapters.project1TableAdapter()
        CType(Me.project1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._project__1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'project1BindingSource
        '
        Me.project1BindingSource.DataMember = "project1"
        Me.project1BindingSource.DataSource = Me._project__1_DataSet
        '
        '_project__1_DataSet
        '
        Me._project__1_DataSet.DataSetName = "_project__1_DataSet"
        Me._project__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.project1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ExideDesignForm.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(988, 675)
        Me.ReportViewer1.TabIndex = 0
        '
        'project1TableAdapter
        '
        Me.project1TableAdapter.ClearBeforeFill = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 685)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form7"
        Me.Text = "Report Viewer"
        CType(Me.project1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._project__1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents project1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _project__1_DataSet As ExideDesignForm._project__1_DataSet
    Friend WithEvents project1TableAdapter As ExideDesignForm._project__1_DataSetTableAdapters.project1TableAdapter
End Class
