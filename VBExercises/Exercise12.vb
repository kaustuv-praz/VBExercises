Public Class Exercise12
    Dim operatorSign As String
    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim firstNum, secondNum As Double
        Dim resultData As Double

        Double.TryParse(FirstNumberTb.Text, firstNum)
        Double.TryParse(secondNumberTb.Text, secondNum)

        Select Case operatorSign
            Case "+"
                resultData = firstNum + secondNum
            Case "-"
                resultData = firstNum - secondNum
            Case "*"
                resultData = firstNum * secondNum
            Case "/"
                resultData = firstNum / secondNum
            Case "%"
                resultData = firstNum Mod secondNum
        End Select

        ResultLblVal.Text = resultData
    End Sub

    Private Sub OperatorCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OperatorCb.SelectedIndexChanged
        operatorSign = OperatorCb.SelectedItem.ToString
    End Sub

    Private Sub Exercise12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OperatorCb.SelectedIndex = OperatorCb.FindString("+").ToString
    End Sub
End Class