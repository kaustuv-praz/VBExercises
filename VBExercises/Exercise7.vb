'Jet Company gives 5% commission To its salesman If their monthly sales are less than Rs. 
'10,000 And a 10% commission if it Is equal to Or greater than Rs. 10,000. Write a program 
'to calculate commission at the end of the month.
Public Class Exercise7
    Dim newMonthlySalesAmt, commissionPercent As Double
    Dim discountable As Boolean

    Private Sub PurchaseAmtTB_TextChanged(sender As Object, e As EventArgs) Handles MonthlySalesTB.TextChanged
        Double.TryParse(MonthlySalesTB.Text, newMonthlySalesAmt)

        Update_Commission_Settings(newMonthlySalesAmt)
    End Sub


    Private Sub Update_Commission_Settings(newMSalesAmt)
        If newMSalesAmt < 10000 Then
            Calculate_Commission("5%", 0.05)
        Else
            Calculate_Commission("10%", 0.1)
        End If
    End Sub

    Private Sub Calculate_Commission(commissionPerLblValNew, commissionPercentVal)

        CommissionPerLblVal.Text = commissionPerLblValNew
        commissionPercent = commissionPercentVal ' in percentage
    End Sub

    Private Sub EligibilityCriteriaLbl_Click(sender As Object, e As EventArgs) Handles EligibilityCriteriaLbl.Click
        MessageBox.Show("'Jet Company gives 5% commission To its salesman If their monthly sales are less than Rs. 
'10,000 And a 10% commission if it Is equal to Or greater than Rs. 10,000. Write a program 
'to calculate commission at the end of the month.")
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim comissionAmt, finalPaycheckAmt As Double

        comissionAmt = Math.Round(newMonthlySalesAmt * commissionPercent, 2)
        finalPaycheckAmt = Math.Round(newMonthlySalesAmt + comissionAmt, 2)

        DisAmtValLbl.Text = comissionAmt & " Rs /-"
        FinalAmtLblVal.Text = finalPaycheckAmt & " Rs /-"
    End Sub

End Class