Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_project__1_DataSet.project1' table. You can move, or remove it, as needed.
        Me.project1TableAdapter.Fill(Me._project__1_DataSet.project1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Form7_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form3.Show()

    End Sub

End Class