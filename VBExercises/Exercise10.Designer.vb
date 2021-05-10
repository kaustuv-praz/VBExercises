<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise10
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
        Me.UserInputTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResultLbl = New System.Windows.Forms.Label()
        Me.ResultLblVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLbl.Location = New System.Drawing.Point(242, 21)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(161, 38)
        Me.TitleLbl.TabIndex = 16
        Me.TitleLbl.Text = "Exercise 10"
        '
        'UserInputTb
        '
        Me.UserInputTb.Location = New System.Drawing.Point(269, 115)
        Me.UserInputTb.Name = "UserInputTb"
        Me.UserInputTb.Size = New System.Drawing.Size(125, 27)
        Me.UserInputTb.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Type a, b, c, d, e  to see magic"
        '
        'ResultLbl
        '
        Me.ResultLbl.AutoSize = True
        Me.ResultLbl.Location = New System.Drawing.Point(182, 214)
        Me.ResultLbl.Name = "ResultLbl"
        Me.ResultLbl.Size = New System.Drawing.Size(58, 20)
        Me.ResultLbl.TabIndex = 19
        Me.ResultLbl.Text = "RESULT"
        '
        'ResultLblVal
        '
        Me.ResultLblVal.AutoSize = True
        Me.ResultLblVal.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultLblVal.Location = New System.Drawing.Point(269, 205)
        Me.ResultLblVal.Name = "ResultLblVal"
        Me.ResultLblVal.Size = New System.Drawing.Size(51, 33)
        Me.ResultLblVal.TabIndex = 20
        Me.ResultLblVal.Text = "Na"
        '
        'Exercise10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.ResultLblVal)
        Me.Controls.Add(Me.ResultLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserInputTb)
        Me.Controls.Add(Me.TitleLbl)
        Me.Name = "Exercise10"
        Me.Text = "Exercise10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLbl As Label
    Friend WithEvents UserInputTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ResultLbl As Label
    Friend WithEvents ResultLblVal As Label
End Class
