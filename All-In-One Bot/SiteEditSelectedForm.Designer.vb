<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiteEditSelectedForm
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
        Me.SiteEditSelectedGroup = New System.Windows.Forms.GroupBox()
        Me.SiteEditSelectedComboBox = New System.Windows.Forms.ComboBox()
        Me.SiteEditSelectedFormCancelButton = New System.Windows.Forms.Button()
        Me.SiteEditSelectedFormOkayButton = New System.Windows.Forms.Button()
        Me.SiteEditSelectedLabel = New System.Windows.Forms.Label()
        Me.SiteEditSelectedGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'SiteEditSelectedGroup
        '
        Me.SiteEditSelectedGroup.Controls.Add(Me.SiteEditSelectedComboBox)
        Me.SiteEditSelectedGroup.Controls.Add(Me.SiteEditSelectedFormCancelButton)
        Me.SiteEditSelectedGroup.Controls.Add(Me.SiteEditSelectedFormOkayButton)
        Me.SiteEditSelectedGroup.Controls.Add(Me.SiteEditSelectedLabel)
        Me.SiteEditSelectedGroup.Location = New System.Drawing.Point(12, 12)
        Me.SiteEditSelectedGroup.Name = "SiteEditSelectedGroup"
        Me.SiteEditSelectedGroup.Size = New System.Drawing.Size(410, 87)
        Me.SiteEditSelectedGroup.TabIndex = 0
        Me.SiteEditSelectedGroup.TabStop = False
        Me.SiteEditSelectedGroup.Text = "Site Edit"
        '
        'SiteEditSelectedComboBox
        '
        Me.SiteEditSelectedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SiteEditSelectedComboBox.FormattingEnabled = True
        Me.SiteEditSelectedComboBox.Location = New System.Drawing.Point(68, 22)
        Me.SiteEditSelectedComboBox.Name = "SiteEditSelectedComboBox"
        Me.SiteEditSelectedComboBox.Size = New System.Drawing.Size(334, 21)
        Me.SiteEditSelectedComboBox.TabIndex = 1
        '
        'SiteEditSelectedFormCancelButton
        '
        Me.SiteEditSelectedFormCancelButton.Location = New System.Drawing.Point(230, 58)
        Me.SiteEditSelectedFormCancelButton.Name = "SiteEditSelectedFormCancelButton"
        Me.SiteEditSelectedFormCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.SiteEditSelectedFormCancelButton.TabIndex = 3
        Me.SiteEditSelectedFormCancelButton.Text = "Cancel"
        Me.SiteEditSelectedFormCancelButton.UseVisualStyleBackColor = True
        '
        'SiteEditSelectedFormOkayButton
        '
        Me.SiteEditSelectedFormOkayButton.Location = New System.Drawing.Point(129, 58)
        Me.SiteEditSelectedFormOkayButton.Name = "SiteEditSelectedFormOkayButton"
        Me.SiteEditSelectedFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.SiteEditSelectedFormOkayButton.TabIndex = 2
        Me.SiteEditSelectedFormOkayButton.Text = "Okay"
        Me.SiteEditSelectedFormOkayButton.UseVisualStyleBackColor = True
        '
        'SiteEditSelectedLabel
        '
        Me.SiteEditSelectedLabel.AutoSize = True
        Me.SiteEditSelectedLabel.Location = New System.Drawing.Point(6, 25)
        Me.SiteEditSelectedLabel.Name = "SiteEditSelectedLabel"
        Me.SiteEditSelectedLabel.Size = New System.Drawing.Size(56, 13)
        Me.SiteEditSelectedLabel.TabIndex = 0
        Me.SiteEditSelectedLabel.Text = "Enter Site:"
        '
        'SiteEditSelectedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 111)
        Me.Controls.Add(Me.SiteEditSelectedGroup)
        Me.MaximumSize = New System.Drawing.Size(450, 150)
        Me.MinimumSize = New System.Drawing.Size(450, 150)
        Me.Name = "SiteEditSelectedForm"
        Me.Text = "Site Edit Selected"
        Me.SiteEditSelectedGroup.ResumeLayout(False)
        Me.SiteEditSelectedGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiteEditSelectedGroup As GroupBox
    Friend WithEvents SiteEditSelectedLabel As Label
    Friend WithEvents SiteEditSelectedFormCancelButton As Button
    Friend WithEvents SiteEditSelectedFormOkayButton As Button
    Friend WithEvents SiteEditSelectedComboBox As ComboBox
End Class
