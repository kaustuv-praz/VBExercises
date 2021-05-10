<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise12
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
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.FirstNumberTb = New System.Windows.Forms.TextBox()
        Me.secondNumberTb = New System.Windows.Forms.TextBox()
        Me.OperatorCb = New System.Windows.Forms.ComboBox()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResultLblVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLbl.Location = New System.Drawing.Point(249, 34)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(161, 38)
        Me.TitleLbl.TabIndex = 18
        Me.TitleLbl.Text = "Exercise 12"
        '
        'FirstNumberTb
        '
        Me.FirstNumberTb.Location = New System.Drawing.Point(201, 153)
        Me.FirstNumberTb.Name = "FirstNumberTb"
        Me.FirstNumberTb.Size = New System.Drawing.Size(79, 27)
        Me.FirstNumberTb.TabIndex = 1
        Me.FirstNumberTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'secondNumberTb
        '
        Me.secondNumberTb.Location = New System.Drawing.Point(386, 153)
        Me.secondNumberTb.Name = "secondNumberTb"
        Me.secondNumberTb.Size = New System.Drawing.Size(79, 27)
        Me.secondNumberTb.TabIndex = 3
        Me.secondNumberTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OperatorCb
        '
        Me.OperatorCb.FormattingEnabled = True
        Me.OperatorCb.Items.AddRange(New Object() {"+", "-", "*", "/", "%"})
        Me.OperatorCb.Location = New System.Drawing.Point(307, 153)
        Me.OperatorCb.Name = "OperatorCb"
        Me.OperatorCb.Size = New System.Drawing.Size(53, 28)
        Me.OperatorCb.TabIndex = 2
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(498, 154)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(94, 29)
        Me.CalculateBtn.TabIndex = 4
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(498, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Result :"
        '
        'ResultLblVal
        '
        Me.ResultLblVal.AutoSize = True
        Me.ResultLblVal.Location = New System.Drawing.Point(560, 204)
        Me.ResultLblVal.Name = "ResultLblVal"
        Me.ResultLblVal.Size = New System.Drawing.Size(17, 20)
        Me.ResultLblVal.TabIndex = 24
        Me.ResultLblVal.Text = "0"
        '
        'Exercise12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.ResultLblVal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.OperatorCb)
        Me.Controls.Add(Me.secondNumberTb)
        Me.Controls.Add(Me.FirstNumberTb)
        Me.Controls.Add(Me.TitleLbl)
        Me.Name = "Exercise12"
        Me.Text = "Exercise12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLbl As Label
    Friend WithEvents FirstNumberTb As TextBox
    Friend WithEvents secondNumberTb As TextBox
    Friend WithEvents OperatorCb As ComboBox
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ResultLblVal As Label
End Class
