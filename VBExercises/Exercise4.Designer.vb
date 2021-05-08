<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BalanceAmtLbl = New System.Windows.Forms.Label()
        Me.BalanceAmtTB = New System.Windows.Forms.TextBox()
        Me.interestStatLbl = New System.Windows.Forms.Label()
        Me.InterestStatLblVal = New System.Windows.Forms.Label()
        Me.InterestPerLbl = New System.Windows.Forms.Label()
        Me.InterestPerLblVal = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.InterestAmtLbl = New System.Windows.Forms.Label()
        Me.InterestAmtValLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FinalAmountLbl = New System.Windows.Forms.Label()
        Me.FinalAmtLblVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BalanceAmtLbl
        '
        Me.BalanceAmtLbl.AutoSize = True
        Me.BalanceAmtLbl.Location = New System.Drawing.Point(187, 80)
        Me.BalanceAmtLbl.Name = "BalanceAmtLbl"
        Me.BalanceAmtLbl.Size = New System.Drawing.Size(154, 20)
        Me.BalanceAmtLbl.TabIndex = 0
        Me.BalanceAmtLbl.Text = "Balance Amount (Rs) :"
        '
        'BalanceAmtTB
        '
        Me.BalanceAmtTB.Location = New System.Drawing.Point(353, 77)
        Me.BalanceAmtTB.Name = "BalanceAmtTB"
        Me.BalanceAmtTB.Size = New System.Drawing.Size(136, 27)
        Me.BalanceAmtTB.TabIndex = 1
        Me.BalanceAmtTB.Text = "0.0"
        Me.BalanceAmtTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'interestStatLbl
        '
        Me.interestStatLbl.AutoSize = True
        Me.interestStatLbl.Location = New System.Drawing.Point(229, 122)
        Me.interestStatLbl.Name = "interestStatLbl"
        Me.interestStatLbl.Size = New System.Drawing.Size(109, 20)
        Me.interestStatLbl.TabIndex = 2
        Me.interestStatLbl.Text = "Interest Status :"
        '
        'InterestStatLblVal
        '
        Me.InterestStatLblVal.AutoSize = True
        Me.InterestStatLblVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InterestStatLblVal.ForeColor = System.Drawing.Color.Red
        Me.InterestStatLblVal.Location = New System.Drawing.Point(353, 122)
        Me.InterestStatLblVal.Name = "InterestStatLblVal"
        Me.InterestStatLblVal.Size = New System.Drawing.Size(32, 20)
        Me.InterestStatLblVal.TabIndex = 3
        Me.InterestStatLblVal.Text = "NO"
        '
        'InterestPerLbl
        '
        Me.InterestPerLbl.AutoSize = True
        Me.InterestPerLbl.Location = New System.Drawing.Point(257, 164)
        Me.InterestPerLbl.Name = "InterestPerLbl"
        Me.InterestPerLbl.Size = New System.Drawing.Size(81, 20)
        Me.InterestPerLbl.TabIndex = 4
        Me.InterestPerLbl.Text = "Interest % :"
        '
        'InterestPerLblVal
        '
        Me.InterestPerLblVal.AutoSize = True
        Me.InterestPerLblVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InterestPerLblVal.Location = New System.Drawing.Point(353, 164)
        Me.InterestPerLblVal.Name = "InterestPerLblVal"
        Me.InterestPerLblVal.Size = New System.Drawing.Size(29, 20)
        Me.InterestPerLblVal.TabIndex = 5
        Me.InterestPerLblVal.Text = "Na"
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(353, 208)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(94, 29)
        Me.CalculateBtn.TabIndex = 6
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'InterestAmtLbl
        '
        Me.InterestAmtLbl.AutoSize = True
        Me.InterestAmtLbl.Location = New System.Drawing.Point(241, 252)
        Me.InterestAmtLbl.Name = "InterestAmtLbl"
        Me.InterestAmtLbl.Size = New System.Drawing.Size(97, 20)
        Me.InterestAmtLbl.TabIndex = 7
        Me.InterestAmtLbl.Text = "Interest Amt :"
        '
        'InterestAmtValLbl
        '
        Me.InterestAmtValLbl.AutoSize = True
        Me.InterestAmtValLbl.ForeColor = System.Drawing.Color.LimeGreen
        Me.InterestAmtValLbl.Location = New System.Drawing.Point(353, 252)
        Me.InterestAmtValLbl.Name = "InterestAmtValLbl"
        Me.InterestAmtValLbl.Size = New System.Drawing.Size(47, 20)
        Me.InterestAmtValLbl.TabIndex = 8
        Me.InterestAmtValLbl.Text = "0.0 Rs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(281, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Exercise 4"
        '
        'FinalAmountLbl
        '
        Me.FinalAmountLbl.AutoSize = True
        Me.FinalAmountLbl.Location = New System.Drawing.Point(243, 292)
        Me.FinalAmountLbl.Name = "FinalAmountLbl"
        Me.FinalAmountLbl.Size = New System.Drawing.Size(104, 20)
        Me.FinalAmountLbl.TabIndex = 10
        Me.FinalAmountLbl.Text = "Final Amount :"
        '
        'FinalAmtLblVal
        '
        Me.FinalAmtLblVal.AutoSize = True
        Me.FinalAmtLblVal.Location = New System.Drawing.Point(353, 292)
        Me.FinalAmtLblVal.Name = "FinalAmtLblVal"
        Me.FinalAmtLblVal.Size = New System.Drawing.Size(47, 20)
        Me.FinalAmtLblVal.TabIndex = 11
        Me.FinalAmtLblVal.Text = "0.0 Rs"
        '
        'Exercise4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.FinalAmtLblVal)
        Me.Controls.Add(Me.FinalAmountLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InterestAmtValLbl)
        Me.Controls.Add(Me.InterestAmtLbl)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.InterestPerLblVal)
        Me.Controls.Add(Me.InterestPerLbl)
        Me.Controls.Add(Me.InterestStatLblVal)
        Me.Controls.Add(Me.interestStatLbl)
        Me.Controls.Add(Me.BalanceAmtTB)
        Me.Controls.Add(Me.BalanceAmtLbl)
        Me.Name = "Exercise4"
        Me.Text = "Exercise4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BalanceAmtLbl As Label
    Friend WithEvents BalanceAmtTB As TextBox
    Friend WithEvents interestStatLbl As Label
    Friend WithEvents InterestStatLblVal As Label
    Friend WithEvents InterestPerLbl As Label
    Friend WithEvents InterestPerLblVal As Label
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents InterestAmtLbl As Label
    Friend WithEvents InterestAmtValLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FinalAmountLbl As Label
    Friend WithEvents FinalAmtLblVal As Label
End Class
