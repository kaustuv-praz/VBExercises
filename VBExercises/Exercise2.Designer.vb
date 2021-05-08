<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise2
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
        Me.PurchaseAmtTB = New System.Windows.Forms.TextBox()
        Me.DisStatLbl = New System.Windows.Forms.Label()
        Me.DisStatLvlVal = New System.Windows.Forms.Label()
        Me.DisPerLbl = New System.Windows.Forms.Label()
        Me.DisPerLblVal = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.DisAmtLbl = New System.Windows.Forms.Label()
        Me.DisAmtValLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FinalAmountLbl = New System.Windows.Forms.Label()
        Me.FinalAmtLblVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PurchaseAmtLbl
        '
        Me.PurchaseAmtLbl.AutoSize = True
        Me.PurchaseAmtLbl.Location = New System.Drawing.Point(187, 80)
        Me.PurchaseAmtLbl.Name = "PurchaseAmtLbl"
        Me.PurchaseAmtLbl.Size = New System.Drawing.Size(160, 20)
        Me.PurchaseAmtLbl.TabIndex = 0
        Me.PurchaseAmtLbl.Text = "Purchase Amount (Rs) :"
        '
        'PurchaseAmtTB
        '
        Me.PurchaseAmtTB.Location = New System.Drawing.Point(353, 77)
        Me.PurchaseAmtTB.Name = "PurchaseAmtTB"
        Me.PurchaseAmtTB.Size = New System.Drawing.Size(136, 27)
        Me.PurchaseAmtTB.TabIndex = 1
        Me.PurchaseAmtTB.Text = "0.0"
        Me.PurchaseAmtTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DisStatLbl
        '
        Me.DisStatLbl.AutoSize = True
        Me.DisStatLbl.Location = New System.Drawing.Point(229, 122)
        Me.DisStatLbl.Name = "DisStatLbl"
        Me.DisStatLbl.Size = New System.Drawing.Size(118, 20)
        Me.DisStatLbl.TabIndex = 2
        Me.DisStatLbl.Text = "Discount Status :"
        '
        'DisStatLvlVal
        '
        Me.DisStatLvlVal.AutoSize = True
        Me.DisStatLvlVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DisStatLvlVal.ForeColor = System.Drawing.Color.Red
        Me.DisStatLvlVal.Location = New System.Drawing.Point(353, 122)
        Me.DisStatLvlVal.Name = "DisStatLvlVal"
        Me.DisStatLvlVal.Size = New System.Drawing.Size(32, 20)
        Me.DisStatLvlVal.TabIndex = 3
        Me.DisStatLvlVal.Text = "NO"
        '
        'DisPerLbl
        '
        Me.DisPerLbl.AutoSize = True
        Me.DisPerLbl.Location = New System.Drawing.Point(257, 164)
        Me.DisPerLbl.Name = "DisPerLbl"
        Me.DisPerLbl.Size = New System.Drawing.Size(90, 20)
        Me.DisPerLbl.TabIndex = 4
        Me.DisPerLbl.Text = "Discount % :"
        '
        'DisPerLblVal
        '
        Me.DisPerLblVal.AutoSize = True
        Me.DisPerLblVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DisPerLblVal.Location = New System.Drawing.Point(353, 164)
        Me.DisPerLblVal.Name = "DisPerLblVal"
        Me.DisPerLblVal.Size = New System.Drawing.Size(29, 20)
        Me.DisPerLblVal.TabIndex = 5
        Me.DisPerLblVal.Text = "Na"
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
        'DisAmtLbl
        '
        Me.DisAmtLbl.AutoSize = True
        Me.DisAmtLbl.Location = New System.Drawing.Point(241, 252)
        Me.DisAmtLbl.Name = "DisAmtLbl"
        Me.DisAmtLbl.Size = New System.Drawing.Size(106, 20)
        Me.DisAmtLbl.TabIndex = 7
        Me.DisAmtLbl.Text = "Discount Amt :"
        '
        'DisAmtValLbl
        '
        Me.DisAmtValLbl.AutoSize = True
        Me.DisAmtValLbl.ForeColor = System.Drawing.Color.LimeGreen
        Me.DisAmtValLbl.Location = New System.Drawing.Point(353, 252)
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
        Me.Label3.Text = "Exercise 2"
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
        'Exercise2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.FinalAmtLblVal)
        Me.Controls.Add(Me.FinalAmountLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DisAmtValLbl)
        Me.Controls.Add(Me.DisAmtLbl)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.DisPerLblVal)
        Me.Controls.Add(Me.DisPerLbl)
        Me.Controls.Add(Me.DisStatLvlVal)
        Me.Controls.Add(Me.DisStatLbl)
        Me.Controls.Add(Me.PurchaseAmtTB)
        Me.Controls.Add(Me.PurchaseAmtLbl)
        Me.Name = "Exercise2"
        Me.Text = "Exercise2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PurchaseAmtLbl As Label
    Friend WithEvents PurchaseAmtTB As TextBox
    Friend WithEvents DisStatLbl As Label
    Friend WithEvents DisStatLvlVal As Label
    Friend WithEvents DisPerLbl As Label
    Friend WithEvents DisPerLblVal As Label
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents DisAmtLbl As Label
    Friend WithEvents DisAmtValLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FinalAmountLbl As Label
    Friend WithEvents FinalAmtLblVal As Label
End Class
