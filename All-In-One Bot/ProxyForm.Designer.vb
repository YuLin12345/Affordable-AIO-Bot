<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProxyForm
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
        Me.AddProxyGroup = New System.Windows.Forms.GroupBox()
        Me.ProxyFormTestButton = New System.Windows.Forms.Button()
        Me.ProxyFormCancelBox = New System.Windows.Forms.Button()
        Me.ProxyFormSaveButton = New System.Windows.Forms.Button()
        Me.ProxyRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AddProxyGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddProxyGroup
        '
        Me.AddProxyGroup.Controls.Add(Me.ProxyFormTestButton)
        Me.AddProxyGroup.Controls.Add(Me.ProxyFormCancelBox)
        Me.AddProxyGroup.Controls.Add(Me.ProxyFormSaveButton)
        Me.AddProxyGroup.Controls.Add(Me.ProxyRichTextBox)
        Me.AddProxyGroup.Location = New System.Drawing.Point(12, 12)
        Me.AddProxyGroup.Name = "AddProxyGroup"
        Me.AddProxyGroup.Size = New System.Drawing.Size(360, 437)
        Me.AddProxyGroup.TabIndex = 0
        Me.AddProxyGroup.TabStop = False
        Me.AddProxyGroup.Text = "Add Proxy"
        '
        'ProxyFormTestButton
        '
        Me.ProxyFormTestButton.Location = New System.Drawing.Point(6, 408)
        Me.ProxyFormTestButton.Name = "ProxyFormTestButton"
        Me.ProxyFormTestButton.Size = New System.Drawing.Size(75, 23)
        Me.ProxyFormTestButton.TabIndex = 4
        Me.ProxyFormTestButton.Text = "Test"
        Me.ProxyFormTestButton.UseVisualStyleBackColor = True
        '
        'ProxyFormCancelBox
        '
        Me.ProxyFormCancelBox.Location = New System.Drawing.Point(279, 408)
        Me.ProxyFormCancelBox.Name = "ProxyFormCancelBox"
        Me.ProxyFormCancelBox.Size = New System.Drawing.Size(75, 23)
        Me.ProxyFormCancelBox.TabIndex = 3
        Me.ProxyFormCancelBox.Text = "Cancel"
        Me.ProxyFormCancelBox.UseVisualStyleBackColor = True
        '
        'ProxyFormSaveButton
        '
        Me.ProxyFormSaveButton.Location = New System.Drawing.Point(198, 408)
        Me.ProxyFormSaveButton.Name = "ProxyFormSaveButton"
        Me.ProxyFormSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.ProxyFormSaveButton.TabIndex = 2
        Me.ProxyFormSaveButton.Text = "Save"
        Me.ProxyFormSaveButton.UseVisualStyleBackColor = True
        '
        'ProxyRichTextBox
        '
        Me.ProxyRichTextBox.Location = New System.Drawing.Point(6, 19)
        Me.ProxyRichTextBox.Name = "ProxyRichTextBox"
        Me.ProxyRichTextBox.Size = New System.Drawing.Size(348, 383)
        Me.ProxyRichTextBox.TabIndex = 1
        Me.ProxyRichTextBox.Text = ""
        '
        'ProxyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.AddProxyGroup)
        Me.MaximumSize = New System.Drawing.Size(400, 500)
        Me.MinimumSize = New System.Drawing.Size(400, 500)
        Me.Name = "ProxyForm"
        Me.Text = "Proxy Settings"
        Me.AddProxyGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddProxyGroup As GroupBox
    Friend WithEvents ProxyRichTextBox As RichTextBox
    Friend WithEvents ProxyFormCancelBox As Button
    Friend WithEvents ProxyFormSaveButton As Button
    Friend WithEvents ProxyFormTestButton As Button
End Class
