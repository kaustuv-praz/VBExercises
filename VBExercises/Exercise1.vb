Public Class Exercise1
    Dim newPurchaseAmt As Double
    Dim discountable As Boolean
    Private Sub PurchaseAmtTB_TextChanged(sender As Object, e As EventArgs) Handles PurchaseAmtTB.TextChanged
        'MessageBox.Show(PurchaseAmtTB.Text)

        Double.TryParse(PurchaseAmtTB.Text, newPurchaseAmt)

        Update_Discount_Settings(newPurchaseAmt)
    End Sub


    Private Sub Update_Discount_Settings(newPurchaseAmt)
        If newPurchaseAmt > 1000 Then
            discountable = True

            DisStatLvlVal.Text = "YES"
            DisStatLvlVal.ForeColor = Color.Green

            DisPerLblVal.Text = "5%"
        Else
            discountable = False

            DisStatLvlVal.Text = "NO"
            DisStatLvlVal.ForeColor = Color.Red

            DisPerLblVal.Text = "Na"
        End If
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        ' CALCULATING 5% DISCOUNT ON Purchase Amt
        Dim discountAmt, disPercent As Double

        If discountable Then
            disPercent = 0.05 ' in percentage

            discountAmt = Math.Round(newPurchaseAmt * disPercent, 2)
            newPurchaseAmt = Math.Round(newPurchaseAmt - discountAmt, 2)
        Else
            discountAmt = 0
        End If

        DisAmtValLbl.Text = discountAmt & " Rs /-"
        FinalAmtLblVal.Text = newPurchaseAmt & " Rs /-"
    End Sub
End Class