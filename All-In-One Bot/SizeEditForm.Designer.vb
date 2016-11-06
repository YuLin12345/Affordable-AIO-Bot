<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SizeEditForm
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
        Me.SizeEditGroup = New System.Windows.Forms.GroupBox()
        Me.SizeEditBox = New System.Windows.Forms.TextBox()
        Me.SizeEditFormCancelButton = New System.Windows.Forms.Button()
        Me.SizeEditFormOkayButton = New System.Windows.Forms.Button()
        Me.SizeEditLabel = New System.Windows.Forms.Label()
        Me.SizeEditGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'SizeEditGroup
        '
        Me.SizeEditGroup.Controls.Add(Me.SizeEditBox)
        Me.SizeEditGroup.Controls.Add(Me.SizeEditFormCancelButton)
        Me.SizeEditGroup.Controls.Add(Me.SizeEditFormOkayButton)
        Me.SizeEditGroup.Controls.Add(Me.SizeEditLabel)
        Me.SizeEditGroup.Location = New System.Drawing.Point(12, 12)
        Me.SizeEditGroup.Name = "SizeEditGroup"
        Me.SizeEditGroup.Size = New System.Drawing.Size(410, 87)
        Me.SizeEditGroup.TabIndex = 0
        Me.SizeEditGroup.TabStop = False
        Me.SizeEditGroup.Text = "Size Edit"
        '
        'SizeEditBox
        '
        Me.SizeEditBox.Location = New System.Drawing.Point(68, 22)
        Me.SizeEditBox.Name = "SizeEditBox"
        Me.SizeEditBox.Size = New System.Drawing.Size(336, 20)
        Me.SizeEditBox.TabIndex = 1
        '
        'SizeEditFormCancelButton
        '
        Me.SizeEditFormCancelButton.Location = New System.Drawing.Point(230, 58)
        Me.SizeEditFormCancelButton.Name = "SizeEditFormCancelButton"
        Me.SizeEditFormCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.SizeEditFormCancelButton.TabIndex = 3
        Me.SizeEditFormCancelButton.Text = "Cancel"
        Me.SizeEditFormCancelButton.UseVisualStyleBackColor = True
        '
        'SizeEditFormOkayButton
        '
        Me.SizeEditFormOkayButton.Location = New System.Drawing.Point(129, 58)
        Me.SizeEditFormOkayButton.Name = "SizeEditFormOkayButton"
        Me.SizeEditFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.SizeEditFormOkayButton.TabIndex = 2
        Me.SizeEditFormOkayButton.Text = "Okay"
        Me.SizeEditFormOkayButton.UseVisualStyleBackColor = True
        '
        'SizeEditLabel
        '
        Me.SizeEditLabel.AutoSize = True
        Me.SizeEditLabel.Location = New System.Drawing.Point(6, 25)
        Me.SizeEditLabel.Name = "SizeEditLabel"
        Me.SizeEditLabel.Size = New System.Drawing.Size(58, 13)
        Me.SizeEditLabel.TabIndex = 0
        Me.SizeEditLabel.Text = "Enter Size:"
        '
        'SizeEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 111)
        Me.Controls.Add(Me.SizeEditGroup)
        Me.MaximumSize = New System.Drawing.Size(450, 150)
        Me.MinimumSize = New System.Drawing.Size(450, 150)
        Me.Name = "SizeEditForm"
        Me.Text = "Size Edit"
        Me.SizeEditGroup.ResumeLayout(False)
        Me.SizeEditGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SizeEditGroup As GroupBox
    Friend WithEvents SizeEditLabel As Label
    Friend WithEvents SizeEditFormCancelButton As Button
    Friend WithEvents SizeEditFormOkayButton As Button
    Friend WithEvents SizeEditBox As TextBox
End Class
