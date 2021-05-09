<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise8
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
        Me.FirstNumberTB = New System.Windows.Forms.TextBox()
        Me.SecondNumberTB = New System.Windows.Forms.TextBox()
        Me.ThirdNumberTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstIndicatorLbl = New System.Windows.Forms.Label()
        Me.SecondIndicatorLbl = New System.Windows.Forms.Label()
        Me.LargetNumberLblVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FirstNumberTB
        '
        Me.FirstNumberTB.Location = New System.Drawing.Point(89, 159)
        Me.FirstNumberTB.Name = "FirstNumberTB"
        Me.FirstNumberTB.Size = New System.Drawing.Size(120, 27)
        Me.FirstNumberTB.TabIndex = 0
        Me.FirstNumberTB.Text = "0"
        Me.FirstNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecondNumberTB
        '
        Me.SecondNumberTB.Location = New System.Drawing.Point(287, 159)
        Me.SecondNumberTB.Name = "SecondNumberTB"
        Me.SecondNumberTB.Size = New System.Drawing.Size(120, 27)
        Me.SecondNumberTB.TabIndex = 1
        Me.SecondNumberTB.Text = "0"
        Me.SecondNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ThirdNumberTB
        '
        Me.ThirdNumberTB.Location = New System.Drawing.Point(485, 159)
        Me.ThirdNumberTB.Name = "ThirdNumberTB"
        Me.ThirdNumberTB.Size = New System.Drawing.Size(120, 27)
        Me.ThirdNumberTB.TabIndex = 2
        Me.ThirdNumberTB.Text = "0"
        Me.ThirdNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(279, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Exercise 8"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(245, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calculate The Largest"
        '
        'FirstIndicatorLbl
        '
        Me.FirstIndicatorLbl.AutoSize = True
        Me.FirstIndicatorLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FirstIndicatorLbl.Location = New System.Drawing.Point(230, 150)
        Me.FirstIndicatorLbl.Name = "FirstIndicatorLbl"
        Me.FirstIndicatorLbl.Size = New System.Drawing.Size(36, 37)
        Me.FirstIndicatorLbl.TabIndex = 5
        Me.FirstIndicatorLbl.Text = "="
        '
        'SecondIndicatorLbl
        '
        Me.SecondIndicatorLbl.AutoSize = True
        Me.SecondIndicatorLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SecondIndicatorLbl.Location = New System.Drawing.Point(428, 150)
        Me.SecondIndicatorLbl.Name = "SecondIndicatorLbl"
        Me.SecondIndicatorLbl.Size = New System.Drawing.Size(36, 37)
        Me.SecondIndicatorLbl.TabIndex = 6
        Me.SecondIndicatorLbl.Text = "="
        '
        'LargetNumberLblVal
        '
        Me.LargetNumberLblVal.AutoSize = True
        Me.LargetNumberLblVal.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LargetNumberLblVal.Location = New System.Drawing.Point(306, 260)
        Me.LargetNumberLblVal.Name = "LargetNumberLblVal"
        Me.LargetNumberLblVal.Size = New System.Drawing.Size(83, 37)
        Me.LargetNumberLblVal.TabIndex = 7
        Me.LargetNumberLblVal.Text = "______"
        '
        'Exercise8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.LargetNumberLblVal)
        Me.Controls.Add(Me.SecondIndicatorLbl)
        Me.Controls.Add(Me.FirstIndicatorLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ThirdNumberTB)
        Me.Controls.Add(Me.SecondNumberTB)
        Me.Controls.Add(Me.FirstNumberTB)
        Me.Name = "Exercise8"
        Me.Text = "Exercise8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNumberTB As TextBox
    Friend WithEvents SecondNumberTB As TextBox
    Friend WithEvents ThirdNumberTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstIndicatorLbl As Label
    Friend WithEvents SecondIndicatorLbl As Label
    Friend WithEvents LargetNumberLblVal As Label
End Class
