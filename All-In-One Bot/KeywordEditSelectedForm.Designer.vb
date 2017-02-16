<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeywordEditSelectedForm
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
        Me.KeywordEditSelectedGroup = New System.Windows.Forms.GroupBox()
        Me.KeywordEditSelectedFormCancelButton = New System.Windows.Forms.Button()
        Me.KeywordEditSelectedFormOkayButton = New System.Windows.Forms.Button()
        Me.KeywordEditSelectedBox = New System.Windows.Forms.TextBox()
        Me.KeywordEditSelectedLabel = New System.Windows.Forms.Label()
        Me.KeywordEditSelectedGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'KeywordEditSelectedGroup
        '
        Me.KeywordEditSelectedGroup.Controls.Add(Me.KeywordEditSelectedFormCancelButton)
        Me.KeywordEditSelectedGroup.Controls.Add(Me.KeywordEditSelectedFormOkayButton)
        Me.KeywordEditSelectedGroup.Controls.Add(Me.KeywordEditSelectedBox)
        Me.KeywordEditSelectedGroup.Controls.Add(Me.KeywordEditSelectedLabel)
        Me.KeywordEditSelectedGroup.Location = New System.Drawing.Point(12, 12)
        Me.KeywordEditSelectedGroup.Name = "KeywordEditSelectedGroup"
        Me.KeywordEditSelectedGroup.Size = New System.Drawing.Size(410, 87)
        Me.KeywordEditSelectedGroup.TabIndex = 0
        Me.KeywordEditSelectedGroup.TabStop = False
        Me.KeywordEditSelectedGroup.Text = "Keyword Edit"
        '
        'KeywordEditSelectedFormCancelButton
        '
        Me.KeywordEditSelectedFormCancelButton.Location = New System.Drawing.Point(230, 58)
        Me.KeywordEditSelectedFormCancelButton.Name = "KeywordEditSelectedFormCancelButton"
        Me.KeywordEditSelectedFormCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.KeywordEditSelectedFormCancelButton.TabIndex = 3
        Me.KeywordEditSelectedFormCancelButton.Text = "Cancel"
        Me.KeywordEditSelectedFormCancelButton.UseVisualStyleBackColor = True
        '
        'KeywordEditSelectedFormOkayButton
        '
        Me.KeywordEditSelectedFormOkayButton.Location = New System.Drawing.Point(129, 58)
        Me.KeywordEditSelectedFormOkayButton.Name = "KeywordEditSelectedFormOkayButton"
        Me.KeywordEditSelectedFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.KeywordEditSelectedFormOkayButton.TabIndex = 2
        Me.KeywordEditSelectedFormOkayButton.Text = "Okay"
        Me.KeywordEditSelectedFormOkayButton.UseVisualStyleBackColor = True
        '
        'KeywordEditSelectedBox
        '
        Me.KeywordEditSelectedBox.Location = New System.Drawing.Point(91, 22)
        Me.KeywordEditSelectedBox.Name = "KeywordEditSelectedBox"
        Me.KeywordEditSelectedBox.Size = New System.Drawing.Size(313, 20)
        Me.KeywordEditSelectedBox.TabIndex = 1
        '
        'KeywordEditSelectedLabel
        '
        Me.KeywordEditSelectedLabel.AutoSize = True
        Me.KeywordEditSelectedLabel.Location = New System.Drawing.Point(6, 25)
        Me.KeywordEditSelectedLabel.Name = "KeywordEditSelectedLabel"
        Me.KeywordEditSelectedLabel.Size = New System.Drawing.Size(79, 13)
        Me.KeywordEditSelectedLabel.TabIndex = 0
        Me.KeywordEditSelectedLabel.Text = "Enter Keyword:"
        '
        'KeywordEditSelectedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 111)
        Me.Controls.Add(Me.KeywordEditSelectedGroup)
        Me.MaximumSize = New System.Drawing.Size(450, 150)
        Me.MinimumSize = New System.Drawing.Size(450, 150)
        Me.Name = "KeywordEditSelectedForm"
        Me.Text = "Keyword Edit Selected"
        Me.KeywordEditSelectedGroup.ResumeLayout(False)
        Me.KeywordEditSelectedGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KeywordEditSelectedGroup As GroupBox
    Friend WithEvents KeywordEditSelectedFormCancelButton As Button
    Friend WithEvents KeywordEditSelectedFormOkayButton As Button
    Friend WithEvents KeywordEditSelectedBox As TextBox
    Friend WithEvents KeywordEditSelectedLabel As Label
End Class
