<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise5
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
        Me.MathMarksLbl = New System.Windows.Forms.Label()
        Me.MathsMarkTB = New System.Windows.Forms.TextBox()
        Me.totalMarkLbl = New System.Windows.Forms.Label()
        Me.TotalMarkLblVal = New System.Windows.Forms.Label()
        Me.TotalMathPhysicsMarkLbl = New System.Windows.Forms.Label()
        Me.TotalMPMarkLblVal = New System.Windows.Forms.Label()
        Me.CheckBtn = New System.Windows.Forms.Button()
        Me.EligibilityLbl = New System.Windows.Forms.Label()
        Me.EligibiltyLblVal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PhysicMarkLbl = New System.Windows.Forms.Label()
        Me.ChemistryMarkLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PhysicsMarkTB = New System.Windows.Forms.TextBox()
        Me.ChemistryMarkTB = New System.Windows.Forms.TextBox()
        Me.EligibilityCriteriaLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MathMarksLbl
        '
        Me.MathMarksLbl.AutoSize = True
        Me.MathMarksLbl.Location = New System.Drawing.Point(44, 103)
        Me.MathMarksLbl.Name = "MathMarksLbl"
        Me.MathMarksLbl.Size = New System.Drawing.Size(93, 20)
        Me.MathMarksLbl.TabIndex = 0
        Me.MathMarksLbl.Text = "Maths Mark :"
        '
        'MathsMarkTB
        '
        Me.MathsMarkTB.Location = New System.Drawing.Point(157, 100)
        Me.MathsMarkTB.Name = "MathsMarkTB"
        Me.MathsMarkTB.Size = New System.Drawing.Size(136, 27)
        Me.MathsMarkTB.TabIndex = 1
        Me.MathsMarkTB.Text = "0.0"
        Me.MathsMarkTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'totalMarkLbl
        '
        Me.totalMarkLbl.AutoSize = True
        Me.totalMarkLbl.Location = New System.Drawing.Point(381, 103)
        Me.totalMarkLbl.Name = "totalMarkLbl"
        Me.totalMarkLbl.Size = New System.Drawing.Size(92, 20)
        Me.totalMarkLbl.TabIndex = 2
        Me.totalMarkLbl.Text = "Total Marks :"
        '
        'TotalMarkLblVal
        '
        Me.TotalMarkLblVal.AutoSize = True
        Me.TotalMarkLblVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.TotalMarkLblVal.ForeColor = System.Drawing.Color.Red
        Me.TotalMarkLblVal.Location = New System.Drawing.Point(482, 103)
        Me.TotalMarkLblVal.Name = "TotalMarkLblVal"
        Me.TotalMarkLblVal.Size = New System.Drawing.Size(31, 20)
        Me.TotalMarkLblVal.TabIndex = 3
        Me.TotalMarkLblVal.Text = "0.0"
        '
        'TotalMathPhysicsMarkLbl
        '
        Me.TotalMathPhysicsMarkLbl.AutoSize = True
        Me.TotalMathPhysicsMarkLbl.Location = New System.Drawing.Point(359, 143)
        Me.TotalMathPhysicsMarkLbl.Name = "TotalMathPhysicsMarkLbl"
        Me.TotalMathPhysicsMarkLbl.Size = New System.Drawing.Size(114, 20)
        Me.TotalMathPhysicsMarkLbl.TabIndex = 4
        Me.TotalMathPhysicsMarkLbl.Text = "Math + Physics :"
        '
        'TotalMPMarkLblVal
        '
        Me.TotalMPMarkLblVal.AutoSize = True
        Me.TotalMPMarkLblVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.TotalMPMarkLblVal.ForeColor = System.Drawing.Color.Red
        Me.TotalMPMarkLblVal.Location = New System.Drawing.Point(482, 143)
        Me.TotalMPMarkLblVal.Name = "TotalMPMarkLblVal"
        Me.TotalMPMarkLblVal.Size = New System.Drawing.Size(31, 20)
        Me.TotalMPMarkLblVal.TabIndex = 5
        Me.TotalMPMarkLblVal.Text = "0.0"
        '
        'CheckBtn
        '
        Me.CheckBtn.Location = New System.Drawing.Point(157, 233)
        Me.CheckBtn.Name = "CheckBtn"
        Me.CheckBtn.Size = New System.Drawing.Size(136, 29)
        Me.CheckBtn.TabIndex = 6
        Me.CheckBtn.Text = "Check"
        Me.CheckBtn.UseVisualStyleBackColor = True
        '
        'EligibilityLbl
        '
        Me.EligibilityLbl.AutoSize = True
        Me.EligibilityLbl.Location = New System.Drawing.Point(395, 183)
        Me.EligibilityLbl.Name = "EligibilityLbl"
        Me.EligibilityLbl.Size = New System.Drawing.Size(78, 20)
        Me.EligibilityLbl.TabIndex = 7
        Me.EligibilityLbl.Text = "Eligibility :"
        '
        'EligibiltyLblVal
        '
        Me.EligibiltyLblVal.AutoSize = True
        Me.EligibiltyLblVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EligibiltyLblVal.ForeColor = System.Drawing.Color.Red
        Me.EligibiltyLblVal.Location = New System.Drawing.Point(482, 183)
        Me.EligibiltyLblVal.Name = "EligibiltyLblVal"
        Me.EligibiltyLblVal.Size = New System.Drawing.Size(100, 20)
        Me.EligibiltyLblVal.TabIndex = 8
        Me.EligibiltyLblVal.Text = "NOT ELIGIBLE"
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
        Me.Label3.Text = "Exercise 5"
        '
        'PhysicMarkLbl
        '
        Me.PhysicMarkLbl.AutoSize = True
        Me.PhysicMarkLbl.Location = New System.Drawing.Point(38, 143)
        Me.PhysicMarkLbl.Name = "PhysicMarkLbl"
        Me.PhysicMarkLbl.Size = New System.Drawing.Size(99, 20)
        Me.PhysicMarkLbl.TabIndex = 12
        Me.PhysicMarkLbl.Text = "Physics Mark :"
        '
        'ChemistryMarkLbl
        '
        Me.ChemistryMarkLbl.AutoSize = True
        Me.ChemistryMarkLbl.Location = New System.Drawing.Point(19, 183)
        Me.ChemistryMarkLbl.Name = "ChemistryMarkLbl"
        Me.ChemistryMarkLbl.Size = New System.Drawing.Size(118, 20)
        Me.ChemistryMarkLbl.TabIndex = 13
        Me.ChemistryMarkLbl.Text = "Chemistry Mark :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(22, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Marks Entry"
        '
        'PhysicsMarkTB
        '
        Me.PhysicsMarkTB.Location = New System.Drawing.Point(157, 140)
        Me.PhysicsMarkTB.Name = "PhysicsMarkTB"
        Me.PhysicsMarkTB.Size = New System.Drawing.Size(136, 27)
        Me.PhysicsMarkTB.TabIndex = 15
        Me.PhysicsMarkTB.Text = "0.0"
        Me.PhysicsMarkTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChemistryMarkTB
        '
        Me.ChemistryMarkTB.Location = New System.Drawing.Point(157, 180)
        Me.ChemistryMarkTB.Name = "ChemistryMarkTB"
        Me.ChemistryMarkTB.Size = New System.Drawing.Size(136, 27)
        Me.ChemistryMarkTB.TabIndex = 16
        Me.ChemistryMarkTB.Text = "0.0"
        Me.ChemistryMarkTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EligibilityCriteriaLbl
        '
        Me.EligibilityCriteriaLbl.AutoSize = True
        Me.EligibilityCriteriaLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EligibilityCriteriaLbl.ForeColor = System.Drawing.SystemColors.Highlight
        Me.EligibilityCriteriaLbl.Location = New System.Drawing.Point(463, 365)
        Me.EligibilityCriteriaLbl.Name = "EligibilityCriteriaLbl"
        Me.EligibilityCriteriaLbl.Size = New System.Drawing.Size(235, 20)
        Me.EligibilityCriteriaLbl.TabIndex = 17
        Me.EligibilityCriteriaLbl.Text = "View Eligibiliy Criteria (Click Here)"
        '
        'Exercise5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(710, 394)
        Me.Controls.Add(Me.EligibilityCriteriaLbl)
        Me.Controls.Add(Me.ChemistryMarkTB)
        Me.Controls.Add(Me.PhysicsMarkTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChemistryMarkLbl)
        Me.Controls.Add(Me.PhysicMarkLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EligibiltyLblVal)
        Me.Controls.Add(Me.EligibilityLbl)
        Me.Controls.Add(Me.CheckBtn)
        Me.Controls.Add(Me.TotalMPMarkLblVal)
        Me.Controls.Add(Me.TotalMathPhysicsMarkLbl)
        Me.Controls.Add(Me.TotalMarkLblVal)
        Me.Controls.Add(Me.totalMarkLbl)
        Me.Controls.Add(Me.MathsMarkTB)
        Me.Controls.Add(Me.MathMarksLbl)
        Me.Name = "Exercise5"
        Me.Text = "Exercise5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MathMarksLbl As Label
    Friend WithEvents MathsMarkTB As TextBox
    Friend WithEvents totalMarkLbl As Label
    Friend WithEvents TotalMarkLblVal As Label
    Friend WithEvents TotalMathPhysicsMarkLbl As Label
    Friend WithEvents TotalMPMarkLblVal As Label
    Friend WithEvents CheckBtn As Button
    Friend WithEvents EligibilityLbl As Label
    Friend WithEvents EligibiltyLblVal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PhysicMarkLbl As Label
    Friend WithEvents ChemistryMarkLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PhysicsMarkTB As TextBox
    Friend WithEvents ChemistryMarkTB As TextBox
    Friend WithEvents EligibilityCriteriaLbl As Label
End Class
