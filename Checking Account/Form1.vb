Public Class Form1
    Dim output As Double
    Dim Deposit_Action As Double
    Sub Deposit()
        If rdbDeposit.Checked = True Then
            txtInputAmount
            output = Deposit_Action
            lblAccountBallance.Text = Deposit_Action.ToString()
        End If

    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim Value As Double


        If (Double.TryParse(txtInputAmount.Text, value)) Then









        Else

            MessageBox.Show("Please select deposit, check or service Charge ")
        End If



    End Sub
End Class

