<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UsernameText = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.Label()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.AuthenticationGroup = New System.Windows.Forms.GroupBox()
        Me.PurchaseText = New System.Windows.Forms.LinkLabel()
        Me.LoginBox = New System.Windows.Forms.Button()
        Me.VersionText = New System.Windows.Forms.Label()
        Me.CopyrightText = New System.Windows.Forms.Label()
        Me.AuthenticationGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameText
        '
        Me.UsernameText.AutoSize = True
        Me.UsernameText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UsernameText.Location = New System.Drawing.Point(74, 46)
        Me.UsernameText.Name = "UsernameText"
        Me.UsernameText.Size = New System.Drawing.Size(58, 13)
        Me.UsernameText.TabIndex = 0
        Me.UsernameText.Text = "Username:"
        '
        'PasswordText
        '
        Me.PasswordText.AutoSize = True
        Me.PasswordText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PasswordText.Location = New System.Drawing.Point(74, 80)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(56, 13)
        Me.PasswordText.TabIndex = 0
        Me.PasswordText.Text = "Password:"
        '
        'UsernameBox
        '
        Me.UsernameBox.Location = New System.Drawing.Point(138, 43)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(170, 20)
        Me.UsernameBox.TabIndex = 1
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(138, 77)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(170, 20)
        Me.PasswordBox.TabIndex = 2
        '
        'AuthenticationGroup
        '
        Me.AuthenticationGroup.Controls.Add(Me.PurchaseText)
        Me.AuthenticationGroup.Controls.Add(Me.LoginBox)
        Me.AuthenticationGroup.Controls.Add(Me.PasswordBox)
        Me.AuthenticationGroup.Controls.Add(Me.UsernameText)
        Me.AuthenticationGroup.Controls.Add(Me.UsernameBox)
        Me.AuthenticationGroup.Controls.Add(Me.PasswordText)
        Me.AuthenticationGroup.Location = New System.Drawing.Point(12, 12)
        Me.AuthenticationGroup.Name = "AuthenticationGroup"
        Me.AuthenticationGroup.Size = New System.Drawing.Size(460, 137)
        Me.AuthenticationGroup.TabIndex = 0
        Me.AuthenticationGroup.TabStop = False
        Me.AuthenticationGroup.Text = "Authentication"
        '
        'PurchaseText
        '
        Me.PurchaseText.ActiveLinkColor = System.Drawing.Color.DarkRed
        Me.PurchaseText.AutoSize = True
        Me.PurchaseText.LinkColor = System.Drawing.Color.Red
        Me.PurchaseText.Location = New System.Drawing.Point(6, 121)
        Me.PurchaseText.Name = "PurchaseText"
        Me.PurchaseText.Size = New System.Drawing.Size(81, 13)
        Me.PurchaseText.TabIndex = 4
        Me.PurchaseText.TabStop = True
        Me.PurchaseText.Text = "Purchase Here!"
        '
        'LoginBox
        '
        Me.LoginBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LoginBox.Location = New System.Drawing.Point(327, 46)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(110, 47)
        Me.LoginBox.TabIndex = 3
        Me.LoginBox.Text = "Login"
        Me.LoginBox.UseVisualStyleBackColor = True
        '
        'VersionText
        '
        Me.VersionText.AutoSize = True
        Me.VersionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionText.Location = New System.Drawing.Point(427, 151)
        Me.VersionText.Name = "VersionText"
        Me.VersionText.Size = New System.Drawing.Size(31, 9)
        Me.VersionText.TabIndex = 0
        Me.VersionText.Text = "Version"
        '
        'CopyrightText
        '
        Me.CopyrightText.AutoSize = True
        Me.CopyrightText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.CopyrightText.Location = New System.Drawing.Point(5, 151)
        Me.CopyrightText.Name = "CopyrightText"
        Me.CopyrightText.Size = New System.Drawing.Size(38, 9)
        Me.CopyrightText.TabIndex = 0
        Me.CopyrightText.Text = "Copyright"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 161)
        Me.Controls.Add(Me.CopyrightText)
        Me.Controls.Add(Me.VersionText)
        Me.Controls.Add(Me.AuthenticationGroup)
        Me.MaximumSize = New System.Drawing.Size(500, 200)
        Me.MinimumSize = New System.Drawing.Size(500, 200)
        Me.Name = "LoginForm"
        Me.Text = "Affordable All-In-One Bot Login"
        Me.AuthenticationGroup.ResumeLayout(False)
        Me.AuthenticationGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameText As Label
    Friend WithEvents PasswordText As Label
    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents AuthenticationGroup As GroupBox
    Friend WithEvents LoginBox As Button
    Friend WithEvents PurchaseText As LinkLabel
    Friend WithEvents VersionText As Label
    Friend WithEvents CopyrightText As Label
End Class
