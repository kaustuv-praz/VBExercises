<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise6
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
        Me.PurchaseAmtLbl = New System.Windows.Forms.Label()
        Me.AnnualSalaryTB = New System.Windows.Forms.TextBox()
        Me.TaxableLbl = New System.Windows.Forms.Label()
        Me.TaxableLblVal = New System.Windows.Forms.Label()
        Me.TaxPerLbl = New System.Windows.Forms.Label()
        Me.TaxPerLblVal = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.TaxAmtLbl = New System.Windows.Forms.Label()
        Me.TaxAmtValLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NetSalaryLbl = New System.Windows.Forms.Label()
        Me.FinalAmtLblVal = New System.Windows.Forms.Label()
        Me.EligibilityCriteriaLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PurchaseAmtLbl
        '
        Me.PurchaseAmtLbl.AutoSize = True
        Me.PurchaseAmtLbl.Location = New System.Drawing.Point(187, 80)
        Me.PurchaseAmtLbl.Name = "PurchaseAmtLbl"
        Me.PurchaseAmtLbl.Size = New System.Drawing.Size(135, 20)
        Me.PurchaseAmtLbl.TabIndex = 0
        Me.PurchaseAmtLbl.Text = "Annual Salary (Rs) :"
        '
        'AnnualSalaryTB
        '
        Me.AnnualSalaryTB.Location = New System.Drawing.Point(353, 77)
        Me.AnnualSalaryTB.Name = "AnnualSalaryTB"
        Me.AnnualSalaryTB.Size = New System.Drawing.Size(136, 27)
        Me.AnnualSalaryTB.TabIndex = 1
        Me.AnnualSalaryTB.Text = "0.0"
        Me.AnnualSalaryTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaxableLbl
        '
        Me.TaxableLbl.AutoSize = True
        Me.TaxableLbl.Location = New System.Drawing.Point(252, 122)
        Me.TaxableLbl.Name = "TaxableLbl"
        Me.TaxableLbl.Size = New System.Drawing.Size(70, 20)
        Me.TaxableLbl.TabIndex = 2
        Me.TaxableLbl.Text = "Taxable  :"
        '
        'TaxableLblVal
        '
        Me.TaxableLblVal.AutoSize = True
        Me.TaxableLblVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TaxableLblVal.ForeColor = System.Drawing.Color.Red
        Me.TaxableLblVal.Location = New System.Drawing.Point(353, 122)
        Me.TaxableLblVal.Name = "TaxableLblVal"
        Me.TaxableLblVal.Size = New System.Drawing.Size(32, 20)
        Me.TaxableLblVal.TabIndex = 3
        Me.TaxableLblVal.Text = "NO"
        '
        'TaxPerLbl
        '
        Me.TaxPerLbl.AutoSize = True
        Me.TaxPerLbl.Location = New System.Drawing.Point(269, 164)
        Me.TaxPerLbl.Name = "TaxPerLbl"
        Me.TaxPerLbl.Size = New System.Drawing.Size(53, 20)
        Me.TaxPerLbl.TabIndex = 4
        Me.TaxPerLbl.Text = "Tax % :"
        '
        'TaxPerLblVal
        '
        Me.TaxPerLblVal.AutoSize = True
        Me.TaxPerLblVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TaxPerLblVal.Location = New System.Drawing.Point(353, 164)
        Me.TaxPerLblVal.Name = "TaxPerLblVal"
        Me.TaxPerLblVal.Size = New System.Drawing.Size(29, 20)
        Me.TaxPerLblVal.TabIndex = 5
        Me.TaxPerLblVal.Text = "Na"
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
        'TaxAmtLbl
        '
        Me.TaxAmtLbl.AutoSize = True
        Me.TaxAmtLbl.Location = New System.Drawing.Point(253, 252)
        Me.TaxAmtLbl.Name = "TaxAmtLbl"
        Me.TaxAmtLbl.Size = New System.Drawing.Size(69, 20)
        Me.TaxAmtLbl.TabIndex = 7
        Me.TaxAmtLbl.Text = "Tax Amt :"
        '
        'TaxAmtValLbl
        '
        Me.TaxAmtValLbl.AutoSize = True
        Me.TaxAmtValLbl.ForeColor = System.Drawing.Color.LimeGreen
        Me.TaxAmtValLbl.Location = New System.Drawing.Point(353, 252)
        Me.TaxAmtValLbl.Name = "TaxAmtValLbl"
        Me.TaxAmtValLbl.Size = New System.Drawing.Size(47, 20)
        Me.TaxAmtValLbl.TabIndex = 8
        Me.TaxAmtValLbl.Text = "0.0 Rs"
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
        Me.Label3.Text = "Exercise 6"
        '
        'NetSalaryLbl
        '
        Me.NetSalaryLbl.AutoSize = True
        Me.NetSalaryLbl.Location = New System.Drawing.Point(238, 292)
        Me.NetSalaryLbl.Name = "NetSalaryLbl"
        Me.NetSalaryLbl.Size = New System.Drawing.Size(84, 20)
        Me.NetSalaryLbl.TabIndex = 10
        Me.NetSalaryLbl.Text = "Net Salary :"
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
        'EligibilityCriteriaLbl
        '
        Me.EligibilityCriteriaLbl.AutoSize = True
        Me.EligibilityCriteriaLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EligibilityCriteriaLbl.ForeColor = System.Drawing.SystemColors.Highlight
        Me.EligibilityCriteriaLbl.Location = New System.Drawing.Point(446, 356)
        Me.EligibilityCriteriaLbl.Name = "EligibilityCriteriaLbl"
        Me.EligibilityCriteriaLbl.Size = New System.Drawing.Size(233, 20)
        Me.EligibilityCriteriaLbl.TabIndex = 18
        Me.EligibilityCriteriaLbl.Text = "View Taxation Criteria (Click Here)"
        '
        'Exercise6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.EligibilityCriteriaLbl)
        Me.Controls.Add(Me.FinalAmtLblVal)
        Me.Controls.Add(Me.NetSalaryLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TaxAmtValLbl)
        Me.Controls.Add(Me.TaxAmtLbl)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.TaxPerLblVal)
        Me.Controls.Add(Me.TaxPerLbl)
        Me.Controls.Add(Me.TaxableLblVal)
        Me.Controls.Add(Me.TaxableLbl)
        Me.Controls.Add(Me.AnnualSalaryTB)
        Me.Controls.Add(Me.PurchaseAmtLbl)
        Me.Name = "Exercise6"
        Me.Text = "Exercise6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PurchaseAmtLbl As Label
    Friend WithEvents AnnualSalaryTB As TextBox
    Friend WithEvents TaxableLbl As Label
    Friend WithEvents TaxableLblVal As Label
    Friend WithEvents TaxPerLbl As Label
    Friend WithEvents TaxPerLblVal As Label
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents TaxAmtLbl As Label
    Friend WithEvents TaxAmtValLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NetSalaryLbl As Label
    Friend WithEvents FinalAmtLblVal As Label
    Friend WithEvents EligibilityCriteriaLbl As Label
End Class
