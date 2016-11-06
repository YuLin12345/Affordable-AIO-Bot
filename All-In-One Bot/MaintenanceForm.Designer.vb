<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceForm
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
        Me.Maintenance1Text = New System.Windows.Forms.Label()
        Me.Maintenance2Text = New System.Windows.Forms.Label()
        Me.MaintenanceFormOkayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Maintenance1Text
        '
        Me.Maintenance1Text.AutoSize = True
        Me.Maintenance1Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maintenance1Text.Location = New System.Drawing.Point(16, 14)
        Me.Maintenance1Text.Name = "Maintenance1Text"
        Me.Maintenance1Text.Size = New System.Drawing.Size(453, 46)
        Me.Maintenance1Text.TabIndex = 0
        Me.Maintenance1Text.Text = "Bot under maintenance"
        '
        'Maintenance2Text
        '
        Me.Maintenance2Text.AutoSize = True
        Me.Maintenance2Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maintenance2Text.Location = New System.Drawing.Point(232, 429)
        Me.Maintenance2Text.Name = "Maintenance2Text"
        Me.Maintenance2Text.Size = New System.Drawing.Size(159, 16)
        Me.Maintenance2Text.TabIndex = 0
        Me.Maintenance2Text.Text = "Please check again later."
        '
        'MaintenanceFormOkayButton
        '
        Me.MaintenanceFormOkayButton.Location = New System.Drawing.Point(397, 426)
        Me.MaintenanceFormOkayButton.Name = "MaintenanceFormOkayButton"
        Me.MaintenanceFormOkayButton.Size = New System.Drawing.Size(75, 23)
        Me.MaintenanceFormOkayButton.TabIndex = 1
        Me.MaintenanceFormOkayButton.Text = "Okay"
        Me.MaintenanceFormOkayButton.UseVisualStyleBackColor = True
        '
        'MaintenanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Affordable_AIO_Bot.My.Resources.Resources.Maintenance
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.MaintenanceFormOkayButton)
        Me.Controls.Add(Me.Maintenance2Text)
        Me.Controls.Add(Me.Maintenance1Text)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "MaintenanceForm"
        Me.Text = "Affordable All-In-One Bot Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Maintenance1Text As Label
    Friend WithEvents Maintenance2Text As Label
    Friend WithEvents MaintenanceFormOkayButton As Button
End Class
