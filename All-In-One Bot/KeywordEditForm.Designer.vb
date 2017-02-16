<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeywordEditForm
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
        Me.KeywordEditGroup = New System.Windows.Forms.GroupBox()
        Me.KeywordEditFormCancelButton = New System.Windows.Forms.Button()
        Me.KeywordEditFormOkayButton = New System.Windows.Forms.Button()
        Me.KeywordEditBox = New System.Windows.Forms.TextBox()
        Me.KeywordEditLabel = New System.Windows.Forms.Label()
        Me.KeywordEditGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'KeywordEditGroup
        '
        Me.KeywordEditGroup.Controls.Add(Me.KeywordEditFormCancelButton)
        Me.KeywordEditGroup.Controls.Add(Me.KeywordEditFormOkayButton)
        Me.KeywordEditGroup.Controls.Add(Me.KeywordEditBox)
        Me.KeywordEditGroup.Controls.Add(Me.KeywordEditLabel)
        Me.KeywordEditGroup.Location = New System.Drawing.Point(12, 12)
        Me.KeywordEditGroup.Name = "KeywordEditGroup"
        Me.KeywordEditGroup.Size = New System.Drawing.Size(410, 87)
        Me.KeywordEditGroup.TabIndex = 0
        Me.KeywordEditGroup.TabStop = False
        Me.KeywordEditGroup.Text = "Keyword Edit"
        '
        'KeywordEditFormCancelButton
        '
        Me.KeywordEditFormCancelButton.Location = New System.Drawing.Point(230, 58)
        Me.KeywordEditFormCancelButton.Name = "KeywordEditFormCancelButton"
        Me.KeywordEditFormCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.KeywordEditFormCancelButton.TabIndex = 3
        Me.KeywordEditFormCancelButton.Text = "Cancel"
        Me.KeywordEditFormCancelButton.UseVisualStyleBackColor = True
        '
        'KeywordEditFormOkayButton
        '
        Me.KeywordEditFormOkayButton.Location = New System.Drawing.Point(129, 58)
        Me.KeywordEditFormOkayButton.Name = "KeywordEditFormOkayButton"
        Me.KeywordEditFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.KeywordEditFormOkayButton.TabIndex = 2
        Me.KeywordEditFormOkayButton.Text = "Okay"
        Me.KeywordEditFormOkayButton.UseVisualStyleBackColor = True
        '
        'KeywordEditBox
        '
        Me.KeywordEditBox.Location = New System.Drawing.Point(91, 22)
        Me.KeywordEditBox.Name = "KeywordEditBox"
        Me.KeywordEditBox.Size = New System.Drawing.Size(313, 20)
        Me.KeywordEditBox.TabIndex = 1
        '
        'KeywordEditLabel
        '
        Me.KeywordEditLabel.AutoSize = True
        Me.KeywordEditLabel.Location = New System.Drawing.Point(6, 25)
        Me.KeywordEditLabel.Name = "KeywordEditLabel"
        Me.KeywordEditLabel.Size = New System.Drawing.Size(79, 13)
        Me.KeywordEditLabel.TabIndex = 0
        Me.KeywordEditLabel.Text = "Enter Keyword:"
        '
        'KeywordEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 111)
        Me.Controls.Add(Me.KeywordEditGroup)
        Me.MaximumSize = New System.Drawing.Size(450, 150)
        Me.MinimumSize = New System.Drawing.Size(450, 150)
        Me.Name = "KeywordEditForm"
        Me.Text = "Keyword Edit All"
        Me.KeywordEditGroup.ResumeLayout(False)
        Me.KeywordEditGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KeywordEditGroup As GroupBox
    Friend WithEvents KeywordEditFormCancelButton As Button
    Friend WithEvents KeywordEditFormOkayButton As Button
    Friend WithEvents KeywordEditBox As TextBox
    Friend WithEvents KeywordEditLabel As Label
End Class
