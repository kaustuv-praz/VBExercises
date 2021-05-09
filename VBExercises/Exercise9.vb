Public Class Exercise9
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Subject4Tb.TextChanged

    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim sub1, sub2, sub3, sub4, sub5 As Double
        Dim resultStatus As Boolean

        Double.TryParse(Subject1Tb.Text, sub1)
        Double.TryParse(Subject2Tb.Text, sub2)
        Double.TryParse(Subject3Tb.Text, sub3)
        Double.TryParse(Subject4Tb.Text, sub4)
        Double.TryParse(Subject5Tb.Text, sub5)

        If sub1 < 45 Or sub2 < 45 Or sub3 < 45 Or sub4 < 45 Or sub5 < 45 Then
            ResultStatusLbl.Text = "FAIL"
            ResultStatusLbl.ForeColor = Color.Red
            resultStatus = False
        Else
            ResultStatusLbl.Text = "PASS"
            ResultStatusLbl.ForeColor = Color.Green
            resultStatus = True
        End If

        If resultStatus Then

            Dim totalMarks, percentage As Double
            Dim division As String

            totalMarks = sub1 + sub2 + sub3 + sub4 + sub5
            percentage = totalMarks / 5

            PercentageLblVal.Text = percentage

            If percentage > 80 Then
                division = "DISTINCTION"
            ElseIf percentage > 60 Then
                division = "FIRST DIVISION"
            Else
                division = "SECOND DIVISION"
            End If

            DivisionLblVal.Text = division
        Else
            PercentageLblVal.Text = "Na"
            DivisionLblVal.Text = "Na"
        End If

    End Sub
End Class