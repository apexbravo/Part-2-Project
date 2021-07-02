Imports System.Data.DataTable
Imports System.Data.OleDb
Imports System.IO
Imports System.Data


Public Class Form5
    Dim conaccess As New OleDbConnection
    Dim conreader As OleDbDataReader
    Dim concmd As New OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim myDA As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Private Access As New DBControl
    Dim prev, maxRows, nexty As Integer
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_project__1_DataSet.project1' table. You can move, or remove it, as needed.
        Me.Project1TableAdapter.Fill(Me._project__1_DataSet.project1)
        dt = New DataTable


        conaccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Apxb\Desktop\ExideDesignForm\ExideDesignForm\project (1).mdb"
        conaccess.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM project", conaccess)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)
        Button5.Enabled = False
        refresher()
        maxRows = ds.Tables("project").Rows.Count



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If prev <> 0 Then
            prev = Me.DataGridView1.CurrentRow.Index - 1
            Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(prev).Cells(Me.DataGridView1.CurrentCell.ColumnIndex)

        Else
            MsgBox("First Record", vbInformation)

        End If
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If prev < maxRows Then
            prev = Me.DataGridView1.CurrentRow.Index + 1
            Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(prev).Cells(Me.DataGridView1.CurrentCell.ColumnIndex)

        Else
            MsgBox("No More Rows", vbInformation, "Error")

        End If
       
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.ReadOnly = False
        Button5.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        '  For Each newdata As DataGridViewRow In DataGridView1.Rows
        'Dim access As String = String.Format("INSERT INTO project (ID,BatterId,BatteryName,BatteryType,UnitPrice,DateBought,DateSold,Quantity,PackageNumber) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", newdata.Cells(0).Value.ToString(), newdata.Cells(1).Value.ToString(), newdata.Cells(2).Value.ToString(), newdata.Cells(3).Value.ToString(), newdata.Cells(4).Value.ToString(), newdata.Cells(5).Value.ToString(), newdata.Cells(6).Value.ToString(), newdata.Cells(7).Value.ToString(), newdata.Cells(8).Value.ToString())
        'concmd.Connection = conaccess
        'concmd.CommandText = access
        'concmd.ExecuteNonQuery()
        'Next

        Me.Validate()
        Me.myDA.Update(Me.ds.Tables("project"))
        Me.ds.AcceptChanges()



        'maxRows = ds.Tables("project").Rows.Count
        MessageBox.Show("The information has been saved successfully")


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        


        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
            Dim index As Integer
            index = DataGridView1.CurrentCell.RowIndex
            Dim delcmd As New OleDbCommand("delete from project where ID=" & index & "  ", conaccess)
            delcmd.ExecuteNonQuery()
            MsgBox("Record is deleted")
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub refresher()
        Dim access As String

        access = "select * from project"
        Dim DataTab As New DataTable
        Dim DataAdap As New OleDbDataAdapter(access, conaccess)
        DataAdap.Fill(ds, "project")
        DataGridView1.Refresh()


        DataGridView1.DataSource = ds.Tables("project")






    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim str As String = TextBox1.Text

        Try
            If Me.TextBox1.Text.Trim(" ") = " " Then
            Else
                For i As Integer = 0 To DataGridView1.Rows.Count - 1

                    If DataGridView1.Rows(i).Cells(1).Value.ToString = str Then


                        DataGridView1.Rows(i).Selected = True
                        DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(1)



                    End If
                Next


            End If
        Catch ex As Exception

        End Try


    End Sub
End Class