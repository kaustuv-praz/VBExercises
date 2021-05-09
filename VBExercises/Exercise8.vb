Public Class Exercise8
    Private Sub FirstNumberTB_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTB.TextChanged
        Calculate_Largest()
    End Sub

    Private Sub SecondNumberTB_TextChanged(sender As Object, e As EventArgs) Handles SecondNumberTB.TextChanged
        Calculate_Largest()
    End Sub

    Private Sub ThirdNumberTB_TextChanged(sender As Object, e As EventArgs) Handles ThirdNumberTB.TextChanged
        Calculate_Largest()
    End Sub
    Private Sub Calculate_Largest()
        Dim firstNum, secondNum, thirdNum As Double

        Double.TryParse(FirstNumberTB.Text, firstNum)
        Double.TryParse(SecondNumberTB.Text, secondNum)
        Double.TryParse(ThirdNumberTB.Text, thirdNum)

        If firstNum > secondNum And firstNum > thirdNum Then
            ' First number is grater
            FirstIndicatorLbl.Text = ">"
            If secondNum > thirdNum Then
                SecondIndicatorLbl.Text = ">"
            Else
                SecondIndicatorLbl.Text = "<"
            End If
            LargetNumberLblVal.Text = firstNum
        ElseIf secondNum > firstNum And secondNum > thirdNum Then
            ' Second number is greater
            FirstIndicatorLbl.Text = "<"
            SecondIndicatorLbl.Text = ">"

            LargetNumberLblVal.Text = secondNum
        Else
            ' Third Number is greater
            SecondIndicatorLbl.Text = "<"
            If firstNum > secondNum Then
                FirstIndicatorLbl.Text = ">"
            Else
                FirstIndicatorLbl.Text = "<"
            End If

            LargetNumberLblVal.Text = "    " & thirdNum
        End If
    End Sub

    Private Sub Exercise8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class