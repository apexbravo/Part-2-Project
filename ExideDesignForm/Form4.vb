Public Class Form4

    Private Sub EmployeeTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.EmployeeTable' table. You can move, or remove it, as needed.
        Me.EmployeeTableTableAdapter.Fill(Me.EmployeesDataSet.EmployeeTable)
        If SexTextBox.Text = Radmale.Text Then
            Radmale.Checked = True
            Radfemale.Checked = False
        ElseIf SexTextBox.Text = Radfemale.Text Then
            Radfemale.Checked = True
            Radmale.Checked = False
        End If

    End Sub

    Private Sub Radmale_CheckedChanged(sender As Object, e As EventArgs) Handles Radmale.CheckedChanged
        EmployeeTableBindingSource.AddNew()
        Radmale.Checked = True
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click

    End Sub

    Private Sub Radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles Radfemale.CheckedChanged
        EmployeeTableBindingSource.AddNew()
        Radfemale.Checked = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Try
            EmployeeTableBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.EmployeesDataSet)
            MessageBox.Show("Saving successfull" & MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error occurred, Please recheck the fields and try again" & MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Btnprevious_Click(sender As Object, e As EventArgs) Handles Btnprevious.Click
        EmployeeTableBindingSource.MovePrevious()
    End Sub

    Private Sub Btnnext_Click(sender As Object, e As EventArgs) Handles Btnnext.Click
        EmployeeTableBindingSource.MoveNext()
    End Sub

End Class