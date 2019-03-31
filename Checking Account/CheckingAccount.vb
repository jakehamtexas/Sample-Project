Public Class CheckingAccount
    Private accountBalance As Double = 0
    Private Const checkCharge As Double = 10

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim value As Double
        Dim inputPrerequisitesMet As Boolean = AnyRadioButtonsChecked() AndAlso Double.TryParse(txtInputAmount.Text, value)

        If inputPrerequisitesMet Then
            ModifyAccountBalance(value)
            lblAccountBallance.Text = accountBalance.ToString("c")
        Else
            MessageBox.Show("Please select deposit, check or service charge ")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInputAmount.Text = ""
        ClearRadioButtons()
    End Sub

    Private Sub ClearRadioButtons()
        rdbDeposit.Checked = False
        rdbCheck.Checked = False
        rdbServiceCharge.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function AnyRadioButtonsChecked() As Boolean
        Dim DepositNotchecked As Boolean = rdbDeposit.Checked = True
        Dim CheckNotChecked As Boolean = rdbCheck.Checked = True
        Dim ServiceNotChecked As Boolean = rdbServiceCharge.Checked = True

        Return DepositNotchecked OrElse CheckNotChecked OrElse ServiceNotChecked
    End Function

    Private Sub ModifyAccountBalance(value As Double)
        If rdbDeposit.Checked = True Then
            accountBalance += value
        End If
        If rdbCheck.Checked = True Then
            HandleCheck(value)
        End If
        If rdbServiceCharge.Checked = True Then
            accountBalance -= value
        End If
    End Sub

    Private Sub HandleCheck(value As Double)
        If value <= accountBalance Then
            accountBalance -= value
        Else
            ApplyServiceChargeAndDisplayWarning()
        End If
    End Sub

    Private Sub ApplyServiceChargeAndDisplayWarning()
        MessageBox.Show("Insufficient funds: $10 Service Charge")
        accountBalance -= checkCharge
    End Sub
End Class

