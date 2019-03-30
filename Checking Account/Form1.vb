Public Class Form1
    Private Account_Ballance As Double = 0
    Private Check_Charge As Double = 10


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim Value As Double


        If (AnyRadioButtonsChecked() AndAlso Double.TryParse(txtInputAmount.Text, Value)) Then
            If rdbDeposit.Checked = True Then
                Account_Ballance += Value
            End If
            If rdbCheck.Checked = True Then
                If Value <= Account_Ballance Then
                    Account_Ballance -= Value
                Else
                    MessageBox.Show("Insufficient funs: $10 Service Charge")
                    Account_Ballance -= Check_Charge
                End If
            End If

            If rdbServiceCharge.Checked = True Then
                Account_Ballance -= Value

            End If

            lblAccountBallance.Text = Account_Ballance.ToString("c")
        Else

            MessageBox.Show("Please select deposit, check or service Charge ")
        End If



    End Sub

    Private Function AnyRadioButtonsChecked() As Boolean
        Dim DepositNotchecked As Boolean = rdbDeposit.Checked = True
        Dim CheckNotChecked As Boolean = rdbCheck.Checked = True
        Dim ServiceNotChecked As Boolean = rdbServiceCharge.Checked = True
        Return DepositNotchecked OrElse CheckNotChecked OrElse ServiceNotChecked
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInputAmount.Text = ""
        rdbDeposit.Checked = False
        rdbCheck.Checked = False
        rdbServiceCharge.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

