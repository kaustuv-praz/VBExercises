'Write a program To calculate discount On the basis Of following assumption
'a) If purchased amount Is greater than Or equal to 5000, discount Is 10%
'b) If purchased amount Is greater than Or equal to 4000 And less than 5000, discount Is 
'7%
'c) If purchased amount Is greater than Or equal to 3000 And less than 4000, discount Is 
'5%
'd) If purchased amount Is greater than Or equal to 2000 And less than 3000, discount Is 
'3%
'e) If purchased amount Is less than 2000, discount Is 2%
'Write a program To calculate discount On the basis Of following assumption
'a) If purchased amount Is greater than Or equal to 1000, discount Is 5%
'b) If purchased amount Is less than 1000, discount Is 3%
Public Class Exercise3
    Dim newPurchaseAmt, disPercent As Double
    Dim discountable As Boolean

    Private Sub PurchaseAmtTB_TextChanged(sender As Object, e As EventArgs) Handles PurchaseAmtTB.TextChanged
        'MessageBox.Show(PurchaseAmtTB.Text)

        Double.TryParse(PurchaseAmtTB.Text, newPurchaseAmt)

        Update_Discount_Settings(newPurchaseAmt)
    End Sub


    Private Sub Update_Discount_Settings(newPurchaseAmt)
        If newPurchaseAmt >= 5000 Then
            Calculate_Discount(True, "YES", Color.Green, "10%", 0.1)
        ElseIf newPurchaseAmt >= 4000 And newPurchaseAmt < 5000 Then
            Calculate_Discount(True, "YES", Color.Green, "7%", 0.07)
            disPercent = 0.7 ' in percentage
        ElseIf newPurchaseAmt >= 3000 And newPurchaseAmt < 4000 Then
            Calculate_Discount(True, "YES", Color.Green, "5%", 0.05)
        ElseIf newPurchaseAmt >= 2000 And newPurchaseAmt < 3000 Then
            Calculate_Discount(True, "YES", Color.Green, "3%", 0.03)
        ElseIf newPurchaseAmt < 2000 Then
            Calculate_Discount(True, "YES", Color.Green, "2%", 0.02)
        End If
    End Sub

    Private Sub Calculate_Discount(discountableBool, disStatLblVal, disStatLblColor, disPerLblValNew, disPercentVal)
        discountable = discountableBool

        Me.DisStatLblVal.Text = disStatLblVal
        Me.DisStatLblVal.ForeColor = disStatLblColor

        DisPerLblVal.Text = disPerLblValNew

        disPercent = disPercentVal ' in percentage
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
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