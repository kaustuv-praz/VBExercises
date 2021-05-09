'Admission to a professional course Is subject to the following conditions
'a) Marks in mathematics >=60
'b) Marks in physics >=50
'c) Marks in chemistry >=40
'd) Total in all three subjects >=200
'Or
'Total in mathematics And physics>=150
'Given the marks In three subjects, write a program To process the applications To list 
'eligible candidates.
Public Class Exercise5
    Dim newBalanceAmt, interestPercent As Double
    Dim interestable As Boolean


    Private Sub Update_Discount_Settings(newBalanceAmt)
        If newBalanceAmt > 99999 Then
            Calculate_Discount(True, "YES", Color.Green, "7%", 0.07)
        ElseIf newBalanceAmt >= 50000 And newBalanceAmt < 100000 Then
            Calculate_Discount(True, "YES", Color.Green, "5%", 0.05)
            interestPercent = 0.7 ' in percentage
        ElseIf newBalanceAmt < 50000 Then
            Calculate_Discount(True, "YES", Color.Green, "3%", 0.03)
        End If
    End Sub

    Private Sub Calculate_Discount(discountableBool, disStatLblVal, disStatLblColor, disPerLblValNew, disPercentVal)
        interestable = discountableBool

        Me.TotalMarkLblVal.Text = disStatLblVal
        Me.TotalMarkLblVal.ForeColor = disStatLblColor

        TotalMPMarkLblVal.Text = disPerLblValNew

        interestPercent = disPercentVal ' in percentage
    End Sub

    Private Sub EligibilityCriteriaLbl_Click(sender As Object, e As EventArgs) Handles EligibilityCriteriaLbl.Click
        MessageBox.Show("
a) Marks in mathematics >=60
b) Marks in physics >=50
c) Marks in chemistry >=40
d) Total in all three subjects >=200
Or
Total in mathematics And physics>=150
")
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        ' EVALUATE ELIGIBILITY
        Dim mMark, pMark, cMark, totalMark, totalMPMark As Double
        mMark = MathsMarkTB.Text
        pMark = PhysicsMarkTB.Text
        cMark = ChemistryMarkTB.Text
        totalMark = mMark + pMark + cMark
        totalMPMark = mMark + pMark

        TotalMarkLblVal.Text = totalMark
        TotalMPMarkLblVal.Text = totalMPMark

        If (mMark >= 60 And pMark >= 50 And cMark >= 40 And totalMark >= 200) Or (totalMPMark >= 150) Then
            If mMark >= 60 And pMark >= 50 And cMark >= 40 And totalMark >= 200 Then
                TotalMarkLblVal.ForeColor = Color.Green
            Else
                TotalMarkLblVal.ForeColor = Color.Red
            End If

            If totalMPMark >= 150 Then
                TotalMPMarkLblVal.ForeColor = Color.Green
            Else
                TotalMPMarkLblVal.ForeColor = Color.Red
            End If

            EligibiltyLblVal.Text = "ELIGIBLE"
            EligibiltyLblVal.ForeColor = Color.Green
        Else
            TotalMarkLblVal.ForeColor = Color.Red
            TotalMPMarkLblVal.ForeColor = Color.Red

            EligibiltyLblVal.Text = "NOT ELIGIBLE"
            EligibiltyLblVal.ForeColor = Color.Red
        End If

    End Sub

End Class