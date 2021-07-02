Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization

Public Class Form4
    Dim conaccess As New OleDbConnection
    Dim conreader As OleDbDataReader
    Dim concmd As New OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Private Access As New DBControl
    Dim inc, maxRows As Integer

    Private Sub EmployeeTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable

        conaccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Apxb\Desktop\ExideDesignForm\ExideDesignForm\Employees.mdb"
        conaccess.Open()
        loadGrid()
        maxRows = ds.Tables("EmployeeTable").Rows.Count
        inc = 0
    End Sub



    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        Dim no As String
        no = "select Max(ID) from EmployeeTable"
        Dim concmd As New OleDbCommand(no, conaccess)
        conreader = concmd.ExecuteReader
        If (conreader.Read) Then
            If (IsDBNull(conreader(0))) Then
                IDTextBox.Text = "1234"
            Else
                IDTextBox.Text = conreader(0) + 1

            End If
            IDTextBox.Text = ""
            First_NameTextBox.Text = ""
            Last_NameTextBox.Text = ""
            AddressTextBox.Text = ""
            txtdateTime.Text = ""
            AgeTextBox.Text = ""
            DepartmentTextBox.Text = ""
            ContactTextBox.Text = ""
            SalaryTextBox.Text = ""
        End If

    End Sub

    Private Sub NavigateRecords()
        IDTextBox.Text = ds.Tables("EmployeeTable").Rows(inc).Item(0).ToString()
        First_NameTextBox.Text = ds.Tables("EmployeeTable").Rows(inc).Item(1).ToString()
        Last_NameTextBox.Text = ds.Tables("EmployeeTable").Rows(inc).Item(2).ToString()
        AddressTextBox.Text = ds.Tables("EmployeeTable").Rows(inc).Item(3).ToString()
        txtdateTime.Text = ds.Tables("EmployeeTable").Rows(inc).Item(4).ToString()
        AgeTextBox.Text = ds.Tables("EmployeeTable").Rows(inc).Item(5).ToString()
        DepartmentTextBox.Text = ds.Tables("EmployeeTable").Rows(inc).Item(6).ToString()
        ContactTextBox.Text = ds.Tables("EmployeeTable").Rows(inc).Item(7).ToString()
        SalaryTextBox.Text = ds.Tables("EmployeeTable").Rows(inc).Item(8).ToString()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        Dim dast As DateTime = DateTime.Parse(txtdateTime.Text)
        Dim access As String = String.Format("INSERT INTO EmployeeTable (ID,FirstName,LastName,Address,DateOfBirth,Age,Department,Contact,Salary) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", IDTextBox.Text, First_NameTextBox.Text, Last_NameTextBox.Text, AddressTextBox.Text, dast, AgeTextBox.Text, DepartmentTextBox.Text, ContactTextBox.Text, SalaryTextBox.Text)
        concmd.Connection = conaccess
        concmd.CommandText = access
        concmd.ExecuteNonQuery()
        MsgBox("Record Successfully Saved")
        loadGrid()
        IDTextBox.Text = ""
        First_NameTextBox.Text = ""
        Last_NameTextBox.Text = ""
        AddressTextBox.Text = ""
        txtdateTime.Text = ""
        AgeTextBox.Text = ""
        DepartmentTextBox.Text = ""
        ContactTextBox.Text = ""
        SalaryTextBox.Text = ""
    End Sub
    Private Sub loadGrid()
        Dim access As String

        access = "select * from EmployeeTable"
        Dim DataTab As New DataTable
        Dim DataAdap As New OleDbDataAdapter(access, conaccess)
        DataAdap.Fill(ds, "EmployeeTable")
        IDTextBox.Text = ds.Tables("EmployeeTable").Rows(0).Item(0).ToString()
        First_NameTextBox.Text = ds.Tables("EmployeeTable").Rows(0).Item(1).ToString()
        Last_NameTextBox.Text = ds.Tables("EmployeeTable").Rows(0).Item(2).ToString()
        AddressTextBox.Text = ds.Tables("EmployeeTable").Rows(0).Item(3).ToString()
        txtdateTime.Text = ds.Tables("EmployeeTable").Rows(0).Item(4).ToString()
        AgeTextBox.Text = ds.Tables("EmployeeTable").Rows(0).Item(5).ToString()
        DepartmentTextBox.Text = ds.Tables("EmployeeTable").Rows(0).Item(6).ToString()
        ContactTextBox.Text = ds.Tables("EmployeeTable").Rows(0).Item(7).ToString()
        SalaryTextBox.Text = ds.Tables("EmployeeTable").Rows(0).Item(8).ToString()


    End Sub


    Private Sub Btnprevious_Click(sender As Object, e As EventArgs) Handles Btnprevious.Click
        If inc > 0 Then
            inc = inc - 1
            NavigateRecords()
        Else
            MsgBox("First Record", vbInformation)
        End If
    End Sub

    Private Sub Btnnext_Click(sender As Object, e As EventArgs) Handles Btnnext.Click
        If inc <> maxRows - 1 Then
            inc = inc + 1
            NavigateRecords()
        Else
            MsgBox("No More Rows", vbInformation, "Error")
        End If
    End Sub

    Private Sub EmployeeTableBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles EmployeeTableBindingSource.CurrentChanged

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)
        EmployeeTableBindingSource.MoveNext()
    End Sub

    Private Sub Date_Of_BirthLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btnmainmenu_Click(sender As Object, e As EventArgs) Handles Btnmainmenu.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click

        IDTextBox.Text = ""
        First_NameTextBox.Text = ""
        Last_NameTextBox.Text = ""
        AddressTextBox.Text = ""
        txtdateTime.Text = ""
        AgeTextBox.Text = ""
        DepartmentTextBox.Text = ""
        ContactTextBox.Text = ""
        SalaryTextBox.Text = ""
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim delcmd As New OleDbCommand("delete from EmployeeTable where ID=" & IDTextBox.Text & " ", conaccess)
        delcmd.ExecuteNonQuery()
        MsgBox("Record is deleted")
        IDTextBox.Text = ""
        First_NameTextBox.Text = ""
        Last_NameTextBox.Text = ""
        AddressTextBox.Text = ""
        txtdateTime.Text = ""
        AgeTextBox.Text = ""
        DepartmentTextBox.Text = ""
        ContactTextBox.Text = ""
        SalaryTextBox.Text = ""
        loadGrid()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IDTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IDTextBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            First_NameTextBox.Focus()
        End If
    End Sub

    Private Sub First_NameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles First_NameTextBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            Last_NameTextBox.Focus()
        End If
    End Sub
 
    Private Sub Last_NameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Last_NameTextBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            AddressTextBox.Focus()
        End If
    End Sub
    
    Private Sub AddressTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AddressTextBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            txtdateTime.Focus()
        End If
    End Sub

    Private Sub txtdateTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdateTime.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            AgeTextBox.Focus()
        End If
    End Sub
    
    Private Sub AgeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AgeTextBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            DepartmentTextBox.Focus()
        End If
    End Sub


    Private Sub DepartmentTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DepartmentTextBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            ContactTextBox.Focus()
        End If
    End Sub



    Private Sub ContactTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactTextBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            SalaryTextBox.Focus()
        End If
    End Sub

    Private Sub Form4_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form3.Show()

    End Sub


End Class