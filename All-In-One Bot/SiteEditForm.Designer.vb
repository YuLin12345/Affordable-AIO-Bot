<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiteEditForm
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
        Me.SiteEditGroup = New System.Windows.Forms.GroupBox()
        Me.SiteEditComboBox = New System.Windows.Forms.ComboBox()
        Me.SiteEditFormCancelButton = New System.Windows.Forms.Button()
        Me.SiteEditFormOkayButton = New System.Windows.Forms.Button()
        Me.SiteEditLabel = New System.Windows.Forms.Label()
        Me.SiteEditGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'SiteEditGroup
        '
        Me.SiteEditGroup.Controls.Add(Me.SiteEditComboBox)
        Me.SiteEditGroup.Controls.Add(Me.SiteEditFormCancelButton)
        Me.SiteEditGroup.Controls.Add(Me.SiteEditFormOkayButton)
        Me.SiteEditGroup.Controls.Add(Me.SiteEditLabel)
        Me.SiteEditGroup.Location = New System.Drawing.Point(12, 12)
        Me.SiteEditGroup.Name = "SiteEditGroup"
        Me.SiteEditGroup.Size = New System.Drawing.Size(410, 87)
        Me.SiteEditGroup.TabIndex = 0
        Me.SiteEditGroup.TabStop = False
        Me.SiteEditGroup.Text = "Site Edit"
        '
        'SiteEditComboBox
        '
        Me.SiteEditComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SiteEditComboBox.FormattingEnabled = True
        Me.SiteEditComboBox.Location = New System.Drawing.Point(68, 22)
        Me.SiteEditComboBox.Name = "SiteEditComboBox"
        Me.SiteEditComboBox.Size = New System.Drawing.Size(334, 21)
        Me.SiteEditComboBox.TabIndex = 1
        '
        'SiteEditFormCancelButton
        '
        Me.SiteEditFormCancelButton.Location = New System.Drawing.Point(230, 58)
        Me.SiteEditFormCancelButton.Name = "SiteEditFormCancelButton"
        Me.SiteEditFormCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.SiteEditFormCancelButton.TabIndex = 3
        Me.SiteEditFormCancelButton.Text = "Cancel"
        Me.SiteEditFormCancelButton.UseVisualStyleBackColor = True
        '
        'SiteEditFormOkayButton
        '
        Me.SiteEditFormOkayButton.Location = New System.Drawing.Point(129, 58)
        Me.SiteEditFormOkayButton.Name = "SiteEditFormOkayButton"
        Me.SiteEditFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.SiteEditFormOkayButton.TabIndex = 2
        Me.SiteEditFormOkayButton.Text = "Okay"
        Me.SiteEditFormOkayButton.UseVisualStyleBackColor = True
        '
        'SiteEditLabel
        '
        Me.SiteEditLabel.AutoSize = True
        Me.SiteEditLabel.Location = New System.Drawing.Point(6, 25)
        Me.SiteEditLabel.Name = "SiteEditLabel"
        Me.SiteEditLabel.Size = New System.Drawing.Size(56, 13)
        Me.SiteEditLabel.TabIndex = 0
        Me.SiteEditLabel.Text = "Enter Site:"
        '
        'SiteEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 111)
        Me.Controls.Add(Me.SiteEditGroup)
        Me.MaximumSize = New System.Drawing.Size(450, 150)
        Me.MinimumSize = New System.Drawing.Size(450, 150)
        Me.Name = "SiteEditForm"
        Me.Text = "Site Edit All"
        Me.SiteEditGroup.ResumeLayout(False)
        Me.SiteEditGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiteEditGroup As GroupBox
    Friend WithEvents SiteEditLabel As Label
    Friend WithEvents SiteEditFormCancelButton As Button
    Friend WithEvents SiteEditFormOkayButton As Button
    Friend WithEvents SiteEditComboBox As ComboBox
End Class
