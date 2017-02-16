<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkEditForm
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
        Me.LinkEditGroup = New System.Windows.Forms.GroupBox()
        Me.LinkEditFormCancelButton = New System.Windows.Forms.Button()
        Me.LinkEditFormOkayButton = New System.Windows.Forms.Button()
        Me.LinkEditBox = New System.Windows.Forms.TextBox()
        Me.LinkEditLabel = New System.Windows.Forms.Label()
        Me.LinkEditGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkEditGroup
        '
        Me.LinkEditGroup.Controls.Add(Me.LinkEditFormCancelButton)
        Me.LinkEditGroup.Controls.Add(Me.LinkEditFormOkayButton)
        Me.LinkEditGroup.Controls.Add(Me.LinkEditBox)
        Me.LinkEditGroup.Controls.Add(Me.LinkEditLabel)
        Me.LinkEditGroup.Location = New System.Drawing.Point(12, 12)
        Me.LinkEditGroup.Name = "LinkEditGroup"
        Me.LinkEditGroup.Size = New System.Drawing.Size(410, 87)
        Me.LinkEditGroup.TabIndex = 0
        Me.LinkEditGroup.TabStop = False
        Me.LinkEditGroup.Text = "Link Edit"
        '
        'LinkEditFormCancelButton
        '
        Me.LinkEditFormCancelButton.Location = New System.Drawing.Point(230, 58)
        Me.LinkEditFormCancelButton.Name = "LinkEditFormCancelButton"
        Me.LinkEditFormCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.LinkEditFormCancelButton.TabIndex = 3
        Me.LinkEditFormCancelButton.Text = "Cancel"
        Me.LinkEditFormCancelButton.UseVisualStyleBackColor = True
        '
        'LinkEditFormOkayButton
        '
        Me.LinkEditFormOkayButton.Location = New System.Drawing.Point(129, 58)
        Me.LinkEditFormOkayButton.Name = "LinkEditFormOkayButton"
        Me.LinkEditFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.LinkEditFormOkayButton.TabIndex = 2
        Me.LinkEditFormOkayButton.Text = "Okay"
        Me.LinkEditFormOkayButton.UseVisualStyleBackColor = True
        '
        'LinkEditBox
        '
        Me.LinkEditBox.Location = New System.Drawing.Point(70, 22)
        Me.LinkEditBox.Name = "LinkEditBox"
        Me.LinkEditBox.Size = New System.Drawing.Size(334, 20)
        Me.LinkEditBox.TabIndex = 1
        '
        'LinkEditLabel
        '
        Me.LinkEditLabel.AutoSize = True
        Me.LinkEditLabel.Location = New System.Drawing.Point(6, 25)
        Me.LinkEditLabel.Name = "LinkEditLabel"
        Me.LinkEditLabel.Size = New System.Drawing.Size(58, 13)
        Me.LinkEditLabel.TabIndex = 0
        Me.LinkEditLabel.Text = "Enter Link:"
        '
        'LinkEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 111)
        Me.Controls.Add(Me.LinkEditGroup)
        Me.MaximumSize = New System.Drawing.Size(450, 150)
        Me.MinimumSize = New System.Drawing.Size(450, 150)
        Me.Name = "LinkEditForm"
        Me.Text = "Link Edit All"
        Me.LinkEditGroup.ResumeLayout(False)
        Me.LinkEditGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LinkEditGroup As GroupBox
    Friend WithEvents LinkEditFormCancelButton As Button
    Friend WithEvents LinkEditFormOkayButton As Button
    Friend WithEvents LinkEditBox As TextBox
    Friend WithEvents LinkEditLabel As Label
End Class
