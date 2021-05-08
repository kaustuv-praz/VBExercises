'Write a program To calculate the simple interest On the basis Of following assumption
'a) If balance Is greater than 99999, interest Is 7 %
'b) If balance Is greater than Or equal to 50000 And less than 100000 interest Is 5 %
'c) If balance Is less than 50000, interest Is 3%
Public Class Exercise4
    Dim newBalanceAmt, interestPercent As Double
    Dim interestable As Boolean

    Private Sub PurchaseAmtTB_TextChanged(sender As Object, e As EventArgs) Handles BalanceAmtTB.TextChanged
        'MessageBox.Show(PurchaseAmtTB.Text)

        Double.TryParse(BalanceAmtTB.Text, newBalanceAmt)

        Update_Discount_Settings(newBalanceAmt)
    End Sub


    Private Sub Update_Discount_Settings(newPurchaseAmt)
        If newPurchaseAmt >= 5000 Then
            Calculate_Discount(True, "YES", Color.Green, "10%", 0.1)
        ElseIf newPurchaseAmt >= 4000 And newPurchaseAmt < 5000 Then
            Calculate_Discount(True, "YES", Color.Green, "7%", 0.07)
            interestPercent = 0.7 ' in percentage
        ElseIf newPurchaseAmt >= 3000 And newPurchaseAmt < 4000 Then
            Calculate_Discount(True, "YES", Color.Green, "5%", 0.05)
        ElseIf newPurchaseAmt >= 2000 And newPurchaseAmt < 3000 Then
            Calculate_Discount(True, "YES", Color.Green, "3%", 0.03)
        ElseIf newPurchaseAmt < 2000 Then
            Calculate_Discount(True, "YES", Color.Green, "2%", 0.02)
        End If
    End Sub

    Private Sub Calculate_Discount(discountableBool, disStatLblVal, disStatLblColor, disPerLblValNew, disPercentVal)
        interestable = discountableBool

        Me.InterestStatLblVal.Text = disStatLblVal
        Me.InterestStatLblVal.ForeColor = disStatLblColor

        InterestPerLblVal.Text = disPerLblValNew

        interestPercent = disPercentVal ' in percentage
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        ' CALCULATING 5% DISCOUNT ON Purchase Amt
        Dim interestAmt As Double

        If interestable Then
            interestAmt = Math.Round(newBalanceAmt * interestPercent, 2)
            newBalanceAmt = Math.Round(newBalanceAmt + interestAmt, 2)
        Else
            interestAmt = 0
        End If

        InterestAmtValLbl.Text = interestAmt & " Rs /-"
        FinalAmtLblVal.Text = newBalanceAmt & " Rs /-"
    End Sub

End Class