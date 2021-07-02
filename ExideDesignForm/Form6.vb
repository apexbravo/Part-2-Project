Option Explicit On

Public Class Form6


    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim [Operator] As String

    Dim hasDecimal As Boolean
    Dim tmpValue As Double

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_project__1_DataSet.project1' table. You can move, or remove it, as needed.
        Me.Project1TableAdapter.Fill(Me._project__1_DataSet.project1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Text = ""
        txtInput.Text = 0
        txtChange.Text = ""
        txtDiscount.Text = ""
        txtNumberOfItems.Text = ""
        txtProduct_cost.Text = ""
        txtProduct_ID.Text = ""
        txtQuatity.Text = ""
        txtTax.Text = "3%"
        txtTotal_Amount.Text = ""


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
            Application.Exit()
        End If
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub
End Class