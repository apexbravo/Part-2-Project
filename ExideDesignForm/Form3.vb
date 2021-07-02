Public Class Form3
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout", "closing exams", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = (DialogResult.Yes) Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Hide()

    End Sub
End Class