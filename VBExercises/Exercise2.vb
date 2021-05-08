'Write a program To calculate discount On the basis Of following assumption
'a) If purchased amount Is greater than Or equal to 1000, discount Is 5%
'b) If purchased amount Is less than 1000, discount Is 3%
Public Class Exercise2
    Dim newPurchaseAmt, disPercent As Double
    Dim discountable As Boolean

    Private Sub PurchaseAmtTB_TextChanged(sender As Object, e As EventArgs) Handles PurchaseAmtTB.TextChanged
        'MessageBox.Show(PurchaseAmtTB.Text)

        Double.TryParse(PurchaseAmtTB.Text, newPurchaseAmt)

        Update_Discount_Settings(newPurchaseAmt)
    End Sub


    Private Sub Update_Discount_Settings(newPurchaseAmt)
        If newPurchaseAmt >= 1000 Then
            discountable = True

            DisStatLvlVal.Text = "YES"
            DisStatLvlVal.ForeColor = Color.Green

            DisPerLblVal.Text = "5%"

            disPercent = 0.05 ' in percentage
        ElseIf newPurchaseAmt < 1000 Then
            discountable = True

            DisStatLvlVal.Text = "YES"
            DisStatLvlVal.ForeColor = Color.Green

            DisPerLblVal.Text = "3%"

            disPercent = 0.03 ' in percentage
        End If
    End Sub


    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        ' CALCULATING 5% DISCOUNT ON Purchase Amt
        Dim discountAmt As Double

        If discountable Then
            discountAmt = Math.Round(newPurchaseAmt * disPercent, 2)
            newPurchaseAmt = Math.Round(newPurchaseAmt - discountAmt, 2)
        Else
            discountAmt = 0
        End If

        DisAmtValLbl.Text = discountAmt & " Rs /-"
        FinalAmtLblVal.Text = newPurchaseAmt & " Rs /-"
    End Sub

End Class