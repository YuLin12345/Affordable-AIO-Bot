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
        Me.ProxyData = New System.Windows.Forms.DataGridView()
        Me.IPnPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ping = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProxyCheckComboBox = New System.Windows.Forms.ComboBox()
        Me.AddProxyGroup.SuspendLayout()
        CType(Me.ProxyData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddProxyGroup
        '
        Me.AddProxyGroup.Controls.Add(Me.ProxyCheckComboBox)
        Me.AddProxyGroup.Controls.Add(Me.ProxyFormTestButton)
        Me.AddProxyGroup.Controls.Add(Me.ProxyFormCancelBox)
        Me.AddProxyGroup.Controls.Add(Me.ProxyFormSaveButton)
        Me.AddProxyGroup.Controls.Add(Me.ProxyRichTextBox)
        Me.AddProxyGroup.Location = New System.Drawing.Point(12, 12)
        Me.AddProxyGroup.Name = "AddProxyGroup"
        Me.AddProxyGroup.Size = New System.Drawing.Size(259, 437)
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
        Me.ProxyFormSaveButton.Location = New System.Drawing.Point(178, 408)
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
        Me.ProxyRichTextBox.Size = New System.Drawing.Size(247, 356)
        Me.ProxyRichTextBox.TabIndex = 1
        Me.ProxyRichTextBox.Text = ""
        '
        'ProxyData
        '
        Me.ProxyData.AllowUserToAddRows = False
        Me.ProxyData.AllowUserToDeleteRows = False
        Me.ProxyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProxyData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IPnPort, Me.Username, Me.Password, Me.Result, Me.Ping})
        Me.ProxyData.Location = New System.Drawing.Point(277, 12)
        Me.ProxyData.Name = "ProxyData"
        Me.ProxyData.ReadOnly = True
        Me.ProxyData.Size = New System.Drawing.Size(495, 437)
        Me.ProxyData.TabIndex = 1
        '
        'IPnPort
        '
        Me.IPnPort.HeaderText = "IP:Port"
        Me.IPnPort.Name = "IPnPort"
        Me.IPnPort.ReadOnly = True
        '
        'Username
        '
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        '
        'Result
        '
        Me.Result.HeaderText = "Result"
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        Me.Result.Width = 75
        '
        'Ping
        '
        Me.Ping.HeaderText = "Ping"
        Me.Ping.Name = "Ping"
        Me.Ping.ReadOnly = True
        Me.Ping.Width = 75
        '
        'ProxyCheckComboBox
        '
        Me.ProxyCheckComboBox.FormattingEnabled = True
        Me.ProxyCheckComboBox.Location = New System.Drawing.Point(6, 381)
        Me.ProxyCheckComboBox.Name = "ProxyCheckComboBox"
        Me.ProxyCheckComboBox.Size = New System.Drawing.Size(247, 21)
        Me.ProxyCheckComboBox.TabIndex = 5
        '
        'ProxyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.ProxyData)
        Me.Controls.Add(Me.AddProxyGroup)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "ProxyForm"
        Me.Text = "Proxy Settings"
        Me.AddProxyGroup.ResumeLayout(False)
        CType(Me.ProxyData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddProxyGroup As GroupBox
    Friend WithEvents ProxyRichTextBox As RichTextBox
    Friend WithEvents ProxyFormCancelBox As Button
    Friend WithEvents ProxyFormSaveButton As Button
    Friend WithEvents ProxyFormTestButton As Button
    Friend WithEvents ProxyData As DataGridView
    Friend WithEvents ProxyCheckComboBox As ComboBox
    Friend WithEvents IPnPort As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewTextBoxColumn
    Friend WithEvents Ping As DataGridViewTextBoxColumn
End Class
