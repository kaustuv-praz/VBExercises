'The rates Of tax On gross salary are As shown below:
'Income Tax
'Less than 10,000 Nill
'Rs. 10,000 to 19,999 10%
'Rs. 20,000 to 39,999 15%
'Rs. 40,000 to above 20%
'Write a program To compute the net salary after deducting the tax For the given 
'information And print the same
Public Class Exercise6
    Dim newAnnualSalaryAmt, taxPercent As Double
    Dim taxable As Boolean

    Private Sub PurchaseAmtTB_TextChanged(sender As Object, e As EventArgs) Handles AnnualSalaryTB.TextChanged
        'MessageBox.Show(PurchaseAmtTB.Text)

        Double.TryParse(AnnualSalaryTB.Text, newAnnualSalaryAmt)

        Update_Tax_Settings(newAnnualSalaryAmt)
    End Sub


    Private Sub Update_Tax_Settings(newAnnSalaryAmt)
        If newAnnSalaryAmt >= 40000 Then
            Calculate_Tax(True, "YES", Color.Green, "20%", 0.2)
        ElseIf newAnnSalaryAmt >= 20000 And newAnnSalaryAmt < 40000 Then
            Calculate_Tax(True, "YES", Color.Green, "15%", 0.15)
        ElseIf newAnnSalaryAmt >= 10000 And newAnnSalaryAmt < 20000 Then
            Calculate_Tax(True, "YES", Color.Green, "10%", 0.1)
        ElseIf newAnnSalaryAmt < 10000 Then
            Calculate_Tax(False, "NO", Color.Red, "Na", 0)
        End If
    End Sub

    Private Sub Calculate_Tax(taxableBool, taxStatLblVal, taxStatLblColor, taxPerLblValNew, taxPercentVal)
        taxable = taxableBool

        Me.TaxableLblVal.Text = taxStatLblVal
        Me.TaxableLblVal.ForeColor = taxStatLblColor

        TaxPerLblVal.Text = taxPerLblValNew

        taxPercent = taxPercentVal ' in percentage
    End Sub

    Private Sub EligibilityCriteriaLbl_Click(sender As Object, e As EventArgs) Handles EligibilityCriteriaLbl.Click
        MessageBox.Show("'Less than 10,000 Nill
'Rs. 10,000 to 19,999 10%
'Rs. 20,000 to 39,999 15%
'Rs. 40,000 to above 20%
")
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim taxAmt As Double

        If taxable Then
            taxAmt = Math.Round(newAnnualSalaryAmt * taxPercent, 2)
            newAnnualSalaryAmt = Math.Round(newAnnualSalaryAmt - taxAmt, 2)
        Else
            taxAmt = 0
            TaxPerLblVal.ForeColor = Color.Red
        End If

        TaxAmtValLbl.Text = taxAmt & " Rs /-"
        FinalAmtLblVal.Text = newAnnualSalaryAmt & " Rs /-"
    End Sub

End Class