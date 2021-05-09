Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i As ListViewItem In ExerciseLV.Items
            'MessageBox.Show(i.SubItems(0).Text)
            If i.SubItems(0).Text = Exercise1.Text Then
                switchPanel(Exercise1)
                i.Selected = True   ' not working
                i.Focused = True    ' not working
                i.EnsureVisible()   ' not working
                ExerciseLV.FocusedItem.Selected = True  ' not working
            End If
        Next
    End Sub

    Sub switchPanel(panelForm As Form)
        'MessageBox.Show(panelForm.Text)
        ExercisePanel.Controls.Clear()
        panelForm.TopLevel = False
        ExercisePanel.Controls.Add(panelForm)
        panelForm.FormBorderStyle = FormBorderStyle.None
        panelForm.Show()
    End Sub

    Private Sub ExerciesLV_MouseClick(sender As Object, e As MouseEventArgs) Handles ExerciseLV.MouseClick
        'MessageBox.Show(ExerciseLV.SelectedItems(0).SubItems(0).Text)
        Dim selectedListViewItem As String
        selectedListViewItem = ExerciseLV.SelectedItems(0).SubItems(0).Text

        Select Case selectedListViewItem
            Case "Exercise1"
                switchPanel(Exercise1)
            Case "Exercise2"
                switchPanel(Exercise2)
            Case "Exercise3"
                switchPanel(Exercise3)
            Case "Exercise4"
                switchPanel(Exercise4)
            Case "Exercise5"
                switchPanel(Exercise5)
            Case "Exercise6"
                switchPanel(Exercise6)
        End Select
    End Sub

End Class
