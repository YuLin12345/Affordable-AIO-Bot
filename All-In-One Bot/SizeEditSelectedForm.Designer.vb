<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SizeEditSelectedForm
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
        Me.SizeEditSelectedGroup = New System.Windows.Forms.GroupBox()
        Me.SizeEditSelectedBox = New System.Windows.Forms.TextBox()
        Me.SizeEditSelectedFormCancelButton = New System.Windows.Forms.Button()
        Me.SizeEditSelectedFormOkayButton = New System.Windows.Forms.Button()
        Me.SizeEditSelectedLabel = New System.Windows.Forms.Label()
        Me.SizeEditSelectedGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'SizeEditSelectedGroup
        '
        Me.SizeEditSelectedGroup.Controls.Add(Me.SizeEditSelectedBox)
        Me.SizeEditSelectedGroup.Controls.Add(Me.SizeEditSelectedFormCancelButton)
        Me.SizeEditSelectedGroup.Controls.Add(Me.SizeEditSelectedFormOkayButton)
        Me.SizeEditSelectedGroup.Controls.Add(Me.SizeEditSelectedLabel)
        Me.SizeEditSelectedGroup.Location = New System.Drawing.Point(12, 12)
        Me.SizeEditSelectedGroup.Name = "SizeEditSelectedGroup"
        Me.SizeEditSelectedGroup.Size = New System.Drawing.Size(410, 87)
        Me.SizeEditSelectedGroup.TabIndex = 0
        Me.SizeEditSelectedGroup.TabStop = False
        Me.SizeEditSelectedGroup.Text = "Size Edit"
        '
        'SizeEditSelectedBox
        '
        Me.SizeEditSelectedBox.Location = New System.Drawing.Point(68, 22)
        Me.SizeEditSelectedBox.Name = "SizeEditSelectedBox"
        Me.SizeEditSelectedBox.Size = New System.Drawing.Size(336, 20)
        Me.SizeEditSelectedBox.TabIndex = 1
        '
        'SizeEditSelectedFormCancelButton
        '
        Me.SizeEditSelectedFormCancelButton.Location = New System.Drawing.Point(230, 58)
        Me.SizeEditSelectedFormCancelButton.Name = "SizeEditSelectedFormCancelButton"
        Me.SizeEditSelectedFormCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.SizeEditSelectedFormCancelButton.TabIndex = 3
        Me.SizeEditSelectedFormCancelButton.Text = "Cancel"
        Me.SizeEditSelectedFormCancelButton.UseVisualStyleBackColor = True
        '
        'SizeEditSelectedFormOkayButton
        '
        Me.SizeEditSelectedFormOkayButton.Location = New System.Drawing.Point(129, 58)
        Me.SizeEditSelectedFormOkayButton.Name = "SizeEditSelectedFormOkayButton"
        Me.SizeEditSelectedFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.SizeEditSelectedFormOkayButton.TabIndex = 2
        Me.SizeEditSelectedFormOkayButton.Text = "Okay"
        Me.SizeEditSelectedFormOkayButton.UseVisualStyleBackColor = True
        '
        'SizeEditSelectedLabel
        '
        Me.SizeEditSelectedLabel.AutoSize = True
        Me.SizeEditSelectedLabel.Location = New System.Drawing.Point(6, 25)
        Me.SizeEditSelectedLabel.Name = "SizeEditSelectedLabel"
        Me.SizeEditSelectedLabel.Size = New System.Drawing.Size(58, 13)
        Me.SizeEditSelectedLabel.TabIndex = 0
        Me.SizeEditSelectedLabel.Text = "Enter Size:"
        '
        'SizeEditSelectedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 111)
        Me.Controls.Add(Me.SizeEditSelectedGroup)
        Me.MaximumSize = New System.Drawing.Size(450, 150)
        Me.MinimumSize = New System.Drawing.Size(450, 150)
        Me.Name = "SizeEditSelectedForm"
        Me.Text = "Size Edit Selected"
        Me.SizeEditSelectedGroup.ResumeLayout(False)
        Me.SizeEditSelectedGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SizeEditSelectedGroup As GroupBox
    Friend WithEvents SizeEditSelectedLabel As Label
    Friend WithEvents SizeEditSelectedFormCancelButton As Button
    Friend WithEvents SizeEditSelectedFormOkayButton As Button
    Friend WithEvents SizeEditSelectedBox As TextBox
End Class
