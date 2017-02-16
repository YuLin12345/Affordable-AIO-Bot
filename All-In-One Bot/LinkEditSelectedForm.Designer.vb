<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkEditSelectedForm
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
        Me.LinkEditSelectedGroup = New System.Windows.Forms.GroupBox()
        Me.LinkEditSelectedFormCancelButton = New System.Windows.Forms.Button()
        Me.LinkEditSelectedFormOkayButton = New System.Windows.Forms.Button()
        Me.LinkEditSelectedBox = New System.Windows.Forms.TextBox()
        Me.LinkEditSelectedLabel = New System.Windows.Forms.Label()
        Me.LinkEditSelectedGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkEditSelectedGroup
        '
        Me.LinkEditSelectedGroup.Controls.Add(Me.LinkEditSelectedFormCancelButton)
        Me.LinkEditSelectedGroup.Controls.Add(Me.LinkEditSelectedFormOkayButton)
        Me.LinkEditSelectedGroup.Controls.Add(Me.LinkEditSelectedBox)
        Me.LinkEditSelectedGroup.Controls.Add(Me.LinkEditSelectedLabel)
        Me.LinkEditSelectedGroup.Location = New System.Drawing.Point(12, 12)
        Me.LinkEditSelectedGroup.Name = "LinkEditSelectedGroup"
        Me.LinkEditSelectedGroup.Size = New System.Drawing.Size(410, 87)
        Me.LinkEditSelectedGroup.TabIndex = 0
        Me.LinkEditSelectedGroup.TabStop = False
        Me.LinkEditSelectedGroup.Text = "Link Edit"
        '
        'LinkEditSelectedFormCancelButton
        '
        Me.LinkEditSelectedFormCancelButton.Location = New System.Drawing.Point(230, 58)
        Me.LinkEditSelectedFormCancelButton.Name = "LinkEditSelectedFormCancelButton"
        Me.LinkEditSelectedFormCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.LinkEditSelectedFormCancelButton.TabIndex = 3
        Me.LinkEditSelectedFormCancelButton.Text = "Cancel"
        Me.LinkEditSelectedFormCancelButton.UseVisualStyleBackColor = True
        '
        'LinkEditSelectedFormOkayButton
        '
        Me.LinkEditSelectedFormOkayButton.Location = New System.Drawing.Point(129, 58)
        Me.LinkEditSelectedFormOkayButton.Name = "LinkEditSelectedFormOkayButton"
        Me.LinkEditSelectedFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.LinkEditSelectedFormOkayButton.TabIndex = 2
        Me.LinkEditSelectedFormOkayButton.Text = "Okay"
        Me.LinkEditSelectedFormOkayButton.UseVisualStyleBackColor = True
        '
        'LinkEditSelectedBox
        '
        Me.LinkEditSelectedBox.Location = New System.Drawing.Point(70, 22)
        Me.LinkEditSelectedBox.Name = "LinkEditSelectedBox"
        Me.LinkEditSelectedBox.Size = New System.Drawing.Size(334, 20)
        Me.LinkEditSelectedBox.TabIndex = 1
        '
        'LinkEditSelectedLabel
        '
        Me.LinkEditSelectedLabel.AutoSize = True
        Me.LinkEditSelectedLabel.Location = New System.Drawing.Point(6, 25)
        Me.LinkEditSelectedLabel.Name = "LinkEditSelectedLabel"
        Me.LinkEditSelectedLabel.Size = New System.Drawing.Size(58, 13)
        Me.LinkEditSelectedLabel.TabIndex = 0
        Me.LinkEditSelectedLabel.Text = "Enter Link:"
        '
        'LinkEditSelectedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 111)
        Me.Controls.Add(Me.LinkEditSelectedGroup)
        Me.MaximumSize = New System.Drawing.Size(450, 150)
        Me.MinimumSize = New System.Drawing.Size(450, 150)
        Me.Name = "LinkEditSelectedForm"
        Me.Text = "Link Edit Selected"
        Me.LinkEditSelectedGroup.ResumeLayout(False)
        Me.LinkEditSelectedGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LinkEditSelectedGroup As GroupBox
    Friend WithEvents LinkEditSelectedFormCancelButton As Button
    Friend WithEvents LinkEditSelectedFormOkayButton As Button
    Friend WithEvents LinkEditSelectedBox As TextBox
    Friend WithEvents LinkEditSelectedLabel As Label
End Class
