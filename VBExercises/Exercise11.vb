Public Class Exercise11
    ' combo box tut
    ' https://social.msdn.microsoft.com/Forums/vstudio/en-US/3197a91d-c762-40a4-966e-4f06edc80c13/add-items-with-value-and-display-into-comboboxes-in-vbnet-2005-windows-application?forum=vbgeneral
    Dim monthArray() As String = {
"January",
"February",
"March",
"April",
"May ",
"June ",
"July ",
"August ",
"September",
"October",
"November",
"December"
    }

    Dim noOfDaysArray() As Int64 = {
      31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
    }
    Private Sub Exercise11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthSelectorCb.DisplayMember = "Text"
        MonthSelectorCb.ValueMember = "Value"

        Dim tableData As New DataTable
        tableData.Columns.Add("Text", GetType(String))
        tableData.Columns.Add("Value", GetType(Int64))

        For i = 0 To 11
            tableData.Rows.Add(monthArray(i), noOfDaysArray(i))
        Next

        MonthSelectorCb.DataSource = tableData
    End Sub

    Private Sub MonthSelectorCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MonthSelectorCb.SelectedIndexChanged
        NoOfDaysLblVal.Text = MonthSelectorCb.SelectedValue
    End Sub
End Class