<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise7
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
        Me.MonthlySalesLbl = New System.Windows.Forms.Label()
        Me.MonthlySalesTB = New System.Windows.Forms.TextBox()
        Me.CommisionPerLbl = New System.Windows.Forms.Label()
        Me.CommissionPerLblVal = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.DisAmtLbl = New System.Windows.Forms.Label()
        Me.DisAmtValLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FinalAmountLbl = New System.Windows.Forms.Label()
        Me.FinalAmtLblVal = New System.Windows.Forms.Label()
        Me.EligibilityCriteriaLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthlySalesLbl
        '
        Me.MonthlySalesLbl.AutoSize = True
        Me.MonthlySalesLbl.Location = New System.Drawing.Point(187, 80)
        Me.MonthlySalesLbl.Name = "MonthlySalesLbl"
        Me.MonthlySalesLbl.Size = New System.Drawing.Size(137, 20)
        Me.MonthlySalesLbl.TabIndex = 0
        Me.MonthlySalesLbl.Text = "Monthly Sales (Rs) :"
        '
        'MonthlySalesTB
        '
        Me.MonthlySalesTB.Location = New System.Drawing.Point(353, 77)
        Me.MonthlySalesTB.Name = "MonthlySalesTB"
        Me.MonthlySalesTB.Size = New System.Drawing.Size(136, 27)
        Me.MonthlySalesTB.TabIndex = 1
        Me.MonthlySalesTB.Text = "0.0"
        Me.MonthlySalesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CommisionPerLbl
        '
        Me.CommisionPerLbl.AutoSize = True
        Me.CommisionPerLbl.Location = New System.Drawing.Point(211, 124)
        Me.CommisionPerLbl.Name = "CommisionPerLbl"
        Me.CommisionPerLbl.Size = New System.Drawing.Size(113, 20)
        Me.CommisionPerLbl.TabIndex = 4
        Me.CommisionPerLbl.Text = "Commission % :"
        '
        'CommissionPerLblVal
        '
        Me.CommissionPerLblVal.AutoSize = True
        Me.CommissionPerLblVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CommissionPerLblVal.Location = New System.Drawing.Point(353, 124)
        Me.CommissionPerLblVal.Name = "CommissionPerLblVal"
        Me.CommissionPerLblVal.Size = New System.Drawing.Size(29, 20)
        Me.CommissionPerLblVal.TabIndex = 5
        Me.CommissionPerLblVal.Text = "Na"
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(353, 168)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(94, 29)
        Me.CalculateBtn.TabIndex = 6
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'DisAmtLbl
        '
        Me.DisAmtLbl.AutoSize = True
        Me.DisAmtLbl.Location = New System.Drawing.Point(195, 212)
        Me.DisAmtLbl.Name = "DisAmtLbl"
        Me.DisAmtLbl.Size = New System.Drawing.Size(129, 20)
        Me.DisAmtLbl.TabIndex = 7
        Me.DisAmtLbl.Text = "Commission Amt :"
        '
        'DisAmtValLbl
        '
        Me.DisAmtValLbl.AutoSize = True
        Me.DisAmtValLbl.ForeColor = System.Drawing.Color.LimeGreen
        Me.DisAmtValLbl.Location = New System.Drawing.Point(353, 212)
        Me.DisAmtValLbl.Name = "DisAmtValLbl"
        Me.DisAmtValLbl.Size = New System.Drawing.Size(47, 20)
        Me.DisAmtValLbl.TabIndex = 8
        Me.DisAmtValLbl.Text = "0.0 Rs"
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
        Me.Label3.Text = "Exercise 7"
        '
        'FinalAmountLbl
        '
        Me.FinalAmountLbl.AutoSize = True
        Me.FinalAmountLbl.Location = New System.Drawing.Point(212, 252)
        Me.FinalAmountLbl.Name = "FinalAmountLbl"
        Me.FinalAmountLbl.Size = New System.Drawing.Size(112, 20)
        Me.FinalAmountLbl.TabIndex = 10
        Me.FinalAmountLbl.Text = "Total Paycheck :"
        '
        'FinalAmtLblVal
        '
        Me.FinalAmtLblVal.AutoSize = True
        Me.FinalAmtLblVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FinalAmtLblVal.Location = New System.Drawing.Point(353, 252)
        Me.FinalAmtLblVal.Name = "FinalAmtLblVal"
        Me.FinalAmtLblVal.Size = New System.Drawing.Size(48, 20)
        Me.FinalAmtLblVal.TabIndex = 11
        Me.FinalAmtLblVal.Text = "0.0 Rs"
        '
        'EligibilityCriteriaLbl
        '
        Me.EligibilityCriteriaLbl.AutoSize = True
        Me.EligibilityCriteriaLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EligibilityCriteriaLbl.ForeColor = System.Drawing.SystemColors.Highlight
        Me.EligibilityCriteriaLbl.Location = New System.Drawing.Point(419, 354)
        Me.EligibilityCriteriaLbl.Name = "EligibilityCriteriaLbl"
        Me.EligibilityCriteriaLbl.Size = New System.Drawing.Size(259, 20)
        Me.EligibilityCriteriaLbl.TabIndex = 19
        Me.EligibilityCriteriaLbl.Text = "View Commission Criteria (Click Here)"
        '
        'Exercise7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.EligibilityCriteriaLbl)
        Me.Controls.Add(Me.FinalAmtLblVal)
        Me.Controls.Add(Me.FinalAmountLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DisAmtValLbl)
        Me.Controls.Add(Me.DisAmtLbl)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.CommissionPerLblVal)
        Me.Controls.Add(Me.CommisionPerLbl)
        Me.Controls.Add(Me.MonthlySalesTB)
        Me.Controls.Add(Me.MonthlySalesLbl)
        Me.Name = "Exercise7"
        Me.Text = "Exercise7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthlySalesLbl As Label
    Friend WithEvents MonthlySalesTB As TextBox
    Friend WithEvents CommisionPerLbl As Label
    Friend WithEvents CommissionPerLblVal As Label
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents DisAmtLbl As Label
    Friend WithEvents DisAmtValLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FinalAmountLbl As Label
    Friend WithEvents FinalAmtLblVal As Label
    Friend WithEvents EligibilityCriteriaLbl As Label
End Class
