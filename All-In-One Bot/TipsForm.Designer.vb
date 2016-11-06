<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipsForm
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
        Me.TipsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'TipsRichTextBox
        '
        Me.TipsRichTextBox.Location = New System.Drawing.Point(12, 12)
        Me.TipsRichTextBox.Name = "TipsRichTextBox"
        Me.TipsRichTextBox.Size = New System.Drawing.Size(510, 487)
        Me.TipsRichTextBox.TabIndex = 1
        Me.TipsRichTextBox.Text = ""
        '
        'TipsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 511)
        Me.Controls.Add(Me.TipsRichTextBox)
        Me.MaximumSize = New System.Drawing.Size(550, 550)
        Me.MinimumSize = New System.Drawing.Size(550, 550)
        Me.Name = "TipsForm"
        Me.Text = "Tips"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TipsRichTextBox As RichTextBox
End Class
