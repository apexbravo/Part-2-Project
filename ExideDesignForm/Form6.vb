Option Explicit On

Public Class Form6


    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim [Operator] As String

    Dim hasDecimal As Boolean
    Dim tmpValue As Double
    Dim batter_name As String
    Dim DueBalance, Amount_Paid, New_DueBalance As Double
    Dim amount As Double


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_project__1_DataSet.project1' table. You can move, or remove it, as needed.
        Me.Project1TableAdapter.Fill(Me._project__1_DataSet.project1)
        txtTax.Text = "3%"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Text = ""
        txtInput.Text = 0
        txtChange.Text = ""
        txtTotal_Amount.Text = ""
        ListBox1.Items.Clear()
        amount = 0
    End Sub


    Public Sub Button21_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim Result As Double
        Operand2 = Val(txtInput.Text)

        Select Case [Operator]
            Case "+"
                Result = Operand1 + Operand2
                txtInput.Text = Result.ToString()
            Case "-"
                Result = Operand1 - Operand2
                txtInput.Text = Result.ToString()
            Case "/"
                Try
                    Result = Operand1 / Operand2

                Catch ex As DivideByZeroException
                    MessageBox.Show("Cannot divide by zero")
                Finally
                    txtInput.Text = Result.ToString()

                End Try

            Case "x"
                Result = Operand1 * Operand2
                txtInput.Text = Result.ToString()

        End Select
    End Sub

    'for the Decimal
    Private Sub btnDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDec.Click
        If InStr(txtInput.Text, ".") > 0 Then
            Exit Sub
        Else
            txtInput.Text = txtInput.Text & "."
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "+"
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "-"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "/"
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "x"
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtInput.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout", "closing exams", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = (DialogResult.Yes) Then
            Me.Close()
            Form3.Show()


        End If
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAddItem.Click

        batter_name = ComboBox1.Text
        ListBox1.Items.Add(batter_name)

        If (ListBox1.Items.Contains("SLI Gel cel")) Then
            amount = amount + 180.0
        ElseIf (ListBox1.Items.Contains("Li-ion Cobalt oxide")) Then
            amount = amount + 360.0
        ElseIf (ListBox1.Items.Contains("SLI AGM")) Then
            amount = amount + 180.0
        ElseIf (ListBox1.Items.Contains("Lead-Acid Flooded")) Then
            amount = amount + 120.0
        Else
            amount = amount + 360.0
        End If

        txtDueBalanceWithoutTax.Text = amount
        DueBalance = amount + (0.03 * amount)
        txtTotal_Amount.Text = DueBalance
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncalculate.Click


        If txtAmount.Text = "" Then
            MessageBox.Show("Please enter the amount of money paid by the customer", "closing exams", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Amount_Paid = txtAmount.Text
        If Amount_Paid < DueBalance Then
            MessageBox.Show("The amount paid by the customer is less than the total purchasing price", "closing exams", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtChange.Text = ""
        Else

            txtChange.Text = Amount_Paid - DueBalance
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ListBox1.Items.Remove(batter_name)
    End Sub

    Private Sub Form6_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form3.Show()

    End Sub

End Class