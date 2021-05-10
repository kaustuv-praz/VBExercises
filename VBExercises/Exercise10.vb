Public Class Exercise10
    Private Sub UserInputTb_TextChanged(sender As Object, e As EventArgs) Handles UserInputTb.TextChanged
        Dim newChar As Char
        Dim userInput As String
        userInput = UserInputTb.Text

        If userInput.Length > 0 Then
            'MessageBox.Show(newChar)

            newChar = userInput(userInput.Length - 1)

            Dim newCharString As String
            newCharString = newChar.ToString

            UserInputTb.Text = newCharString

            UserInputTb.SelectionStart = UserInputTb.Text.Length
            UserInputTb.SelectionLength = 0

            If newCharString = "a" Or newCharString = "A" Then
                ResultLblVal.Text = "EXCELLENT"
            ElseIf newCharString = "b" Or newCharString = "B" Then
                ResultLblVal.Text = "VERY GOOD"

            ElseIf newCharString = "c" Or newCharString = "C" Then
                ResultLblVal.Text = "GOOD"

            ElseIf newCharString = "d" Or newCharString = "D" Then
                ResultLblVal.Text = "SATISFACTORY"

            ElseIf newCharString = "e" Or newCharString = "E" Then
                ResultLblVal.Text = "FAIL"
            Else
                ResultLblVal.Text = "Na"
            End If
        Else
            ResultLblVal.Text = "Na"
        End If




    End Sub

End Class