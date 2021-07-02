Public Class Form2

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtpassword.Text = ""
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit", "closing exams", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = (DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If txtName.Text = "Adder" And txtpassword.Text = "hul" Then
            Dim result = MessageBox.Show("Username and Password Correct", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = (DialogResult.Cancel) Then
               
                Me.Hide()

            End If
            Form3.Show()
            txtName.Text = ""
            txtpassword.Text = ""
            Me.Hide()

        Else
            Dim result2 = MessageBox.Show(" Wrong Username and Password", "Re-enter your credentials", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If result2 = (DialogResult.Cancel) Then
                Me.Close()



            End If



        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Hello.Click

    End Sub
End Class