Public Class Form5
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_project__1_DataSet.project' table. You can move, or remove it, as needed.
        Me.ProjectTableAdapter.Fill(Me._project__1_DataSet.project)

    End Sub
End Class