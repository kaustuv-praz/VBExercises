<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MonthSelectorCb = New System.Windows.Forms.ComboBox()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NoOfDaysLblVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthSelectorCb
        '
        Me.MonthSelectorCb.FormattingEnabled = True
        Me.MonthSelectorCb.Location = New System.Drawing.Point(264, 137)
        Me.MonthSelectorCb.Name = "MonthSelectorCb"
        Me.MonthSelectorCb.Size = New System.Drawing.Size(151, 28)
        Me.MonthSelectorCb.TabIndex = 0
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLbl.Location = New System.Drawing.Point(259, 34)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(161, 38)
        Me.TitleLbl.TabIndex = 17
        Me.TitleLbl.Text = "Exercise 11"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Select Month :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "No Of Day :"
        '
        'NoOfDaysLblVal
        '
        Me.NoOfDaysLblVal.AutoSize = True
        Me.NoOfDaysLblVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NoOfDaysLblVal.Location = New System.Drawing.Point(264, 193)
        Me.NoOfDaysLblVal.Name = "NoOfDaysLblVal"
        Me.NoOfDaysLblVal.Size = New System.Drawing.Size(32, 20)
        Me.NoOfDaysLblVal.TabIndex = 20
        Me.NoOfDaysLblVal.Text = "NA"
        '
        'Exercise11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.NoOfDaysLblVal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleLbl)
        Me.Controls.Add(Me.MonthSelectorCb)
        Me.Name = "Exercise11"
        Me.Text = "Exercise11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthSelectorCb As ComboBox
    Friend WithEvents TitleLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NoOfDaysLblVal As Label
End Class
