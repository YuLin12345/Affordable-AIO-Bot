<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountAddForm
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
        Me.components = New System.ComponentModel.Container()
        Me.AddAccountGroup = New System.Windows.Forms.GroupBox()
        Me.PhoneCarrierComboBox = New System.Windows.Forms.ComboBox()
        Me.PhoneCarrierText = New System.Windows.Forms.Label()
        Me.NotificationNumberText = New System.Windows.Forms.Label()
        Me.NotificationNumberBox = New System.Windows.Forms.TextBox()
        Me.NotificationEMailBox = New System.Windows.Forms.TextBox()
        Me.NotificationEMailText = New System.Windows.Forms.Label()
        Me.GuestCheckBox = New System.Windows.Forms.CheckBox()
        Me.SiteComboBox = New System.Windows.Forms.ComboBox()
        Me.AccountAddCancelButton = New System.Windows.Forms.Button()
        Me.AccountAddSaveButton = New System.Windows.Forms.Button()
        Me.ProfileBox = New System.Windows.Forms.TextBox()
        Me.KeywordBox = New System.Windows.Forms.TextBox()
        Me.LinkBox = New System.Windows.Forms.TextBox()
        Me.SizeBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.EMailBox = New System.Windows.Forms.TextBox()
        Me.ProfileText = New System.Windows.Forms.Label()
        Me.KeywordText = New System.Windows.Forms.Label()
        Me.LinkText = New System.Windows.Forms.Label()
        Me.SiteText = New System.Windows.Forms.Label()
        Me.SizeText = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.Label()
        Me.EMailText = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddAccountGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddAccountGroup
        '
        Me.AddAccountGroup.Controls.Add(Me.PhoneCarrierComboBox)
        Me.AddAccountGroup.Controls.Add(Me.PhoneCarrierText)
        Me.AddAccountGroup.Controls.Add(Me.NotificationNumberText)
        Me.AddAccountGroup.Controls.Add(Me.NotificationNumberBox)
        Me.AddAccountGroup.Controls.Add(Me.NotificationEMailBox)
        Me.AddAccountGroup.Controls.Add(Me.NotificationEMailText)
        Me.AddAccountGroup.Controls.Add(Me.GuestCheckBox)
        Me.AddAccountGroup.Controls.Add(Me.SiteComboBox)
        Me.AddAccountGroup.Controls.Add(Me.AccountAddCancelButton)
        Me.AddAccountGroup.Controls.Add(Me.AccountAddSaveButton)
        Me.AddAccountGroup.Controls.Add(Me.ProfileBox)
        Me.AddAccountGroup.Controls.Add(Me.KeywordBox)
        Me.AddAccountGroup.Controls.Add(Me.LinkBox)
        Me.AddAccountGroup.Controls.Add(Me.SizeBox)
        Me.AddAccountGroup.Controls.Add(Me.PasswordBox)
        Me.AddAccountGroup.Controls.Add(Me.EMailBox)
        Me.AddAccountGroup.Controls.Add(Me.ProfileText)
        Me.AddAccountGroup.Controls.Add(Me.KeywordText)
        Me.AddAccountGroup.Controls.Add(Me.LinkText)
        Me.AddAccountGroup.Controls.Add(Me.SiteText)
        Me.AddAccountGroup.Controls.Add(Me.SizeText)
        Me.AddAccountGroup.Controls.Add(Me.PasswordText)
        Me.AddAccountGroup.Controls.Add(Me.EMailText)
        Me.AddAccountGroup.Location = New System.Drawing.Point(12, 12)
        Me.AddAccountGroup.Name = "AddAccountGroup"
        Me.AddAccountGroup.Size = New System.Drawing.Size(275, 442)
        Me.AddAccountGroup.TabIndex = 0
        Me.AddAccountGroup.TabStop = False
        Me.AddAccountGroup.Text = "Add Account"
        '
        'PhoneCarrierComboBox
        '
        Me.PhoneCarrierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PhoneCarrierComboBox.FormattingEnabled = True
        Me.PhoneCarrierComboBox.Location = New System.Drawing.Point(86, 305)
        Me.PhoneCarrierComboBox.Name = "PhoneCarrierComboBox"
        Me.PhoneCarrierComboBox.Size = New System.Drawing.Size(150, 21)
        Me.PhoneCarrierComboBox.TabIndex = 9
        '
        'PhoneCarrierText
        '
        Me.PhoneCarrierText.AutoSize = True
        Me.PhoneCarrierText.Location = New System.Drawing.Point(6, 308)
        Me.PhoneCarrierText.Name = "PhoneCarrierText"
        Me.PhoneCarrierText.Size = New System.Drawing.Size(74, 13)
        Me.PhoneCarrierText.TabIndex = 0
        Me.PhoneCarrierText.Text = "Phone Carrier:"
        '
        'NotificationNumberText
        '
        Me.NotificationNumberText.AutoSize = True
        Me.NotificationNumberText.Location = New System.Drawing.Point(6, 341)
        Me.NotificationNumberText.Name = "NotificationNumberText"
        Me.NotificationNumberText.Size = New System.Drawing.Size(103, 13)
        Me.NotificationNumberText.TabIndex = 0
        Me.NotificationNumberText.Text = "Notification Number:"
        '
        'NotificationNumberBox
        '
        Me.NotificationNumberBox.Location = New System.Drawing.Point(115, 338)
        Me.NotificationNumberBox.Name = "NotificationNumberBox"
        Me.NotificationNumberBox.Size = New System.Drawing.Size(150, 20)
        Me.NotificationNumberBox.TabIndex = 10
        '
        'NotificationEMailBox
        '
        Me.NotificationEMailBox.Location = New System.Drawing.Point(107, 272)
        Me.NotificationEMailBox.Name = "NotificationEMailBox"
        Me.NotificationEMailBox.Size = New System.Drawing.Size(150, 20)
        Me.NotificationEMailBox.TabIndex = 8
        '
        'NotificationEMailText
        '
        Me.NotificationEMailText.AutoSize = True
        Me.NotificationEMailText.Location = New System.Drawing.Point(6, 275)
        Me.NotificationEMailText.Name = "NotificationEMailText"
        Me.NotificationEMailText.Size = New System.Drawing.Size(95, 13)
        Me.NotificationEMailText.TabIndex = 0
        Me.NotificationEMailText.Text = "Notification E-Mail:"
        '
        'GuestCheckBox
        '
        Me.GuestCheckBox.AutoSize = True
        Me.GuestCheckBox.Location = New System.Drawing.Point(209, 14)
        Me.GuestCheckBox.Name = "GuestCheckBox"
        Me.GuestCheckBox.Size = New System.Drawing.Size(54, 17)
        Me.GuestCheckBox.TabIndex = 11
        Me.GuestCheckBox.Text = "Guest"
        Me.GuestCheckBox.UseVisualStyleBackColor = True
        '
        'SiteComboBox
        '
        Me.SiteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SiteComboBox.FormattingEnabled = True
        Me.SiteComboBox.Location = New System.Drawing.Point(44, 138)
        Me.SiteComboBox.Name = "SiteComboBox"
        Me.SiteComboBox.Size = New System.Drawing.Size(150, 21)
        Me.SiteComboBox.TabIndex = 4
        '
        'AccountAddCancelButton
        '
        Me.AccountAddCancelButton.Location = New System.Drawing.Point(138, 397)
        Me.AccountAddCancelButton.Name = "AccountAddCancelButton"
        Me.AccountAddCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.AccountAddCancelButton.TabIndex = 13
        Me.AccountAddCancelButton.Text = "Cancel"
        Me.AccountAddCancelButton.UseVisualStyleBackColor = True
        '
        'AccountAddSaveButton
        '
        Me.AccountAddSaveButton.Location = New System.Drawing.Point(49, 397)
        Me.AccountAddSaveButton.Name = "AccountAddSaveButton"
        Me.AccountAddSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.AccountAddSaveButton.TabIndex = 12
        Me.AccountAddSaveButton.Text = "Save"
        Me.AccountAddSaveButton.UseVisualStyleBackColor = True
        '
        'ProfileBox
        '
        Me.ProfileBox.Location = New System.Drawing.Point(100, 239)
        Me.ProfileBox.Name = "ProfileBox"
        Me.ProfileBox.Size = New System.Drawing.Size(150, 20)
        Me.ProfileBox.TabIndex = 7
        '
        'KeywordBox
        '
        Me.KeywordBox.Location = New System.Drawing.Point(63, 206)
        Me.KeywordBox.Name = "KeywordBox"
        Me.KeywordBox.Size = New System.Drawing.Size(150, 20)
        Me.KeywordBox.TabIndex = 6
        '
        'LinkBox
        '
        Me.LinkBox.Location = New System.Drawing.Point(42, 173)
        Me.LinkBox.Name = "LinkBox"
        Me.LinkBox.Size = New System.Drawing.Size(150, 20)
        Me.LinkBox.TabIndex = 5
        '
        'SizeBox
        '
        Me.SizeBox.Location = New System.Drawing.Point(49, 104)
        Me.SizeBox.Name = "SizeBox"
        Me.SizeBox.Size = New System.Drawing.Size(150, 20)
        Me.SizeBox.TabIndex = 3
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(72, 71)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(150, 20)
        Me.PasswordBox.TabIndex = 2
        '
        'EMailBox
        '
        Me.EMailBox.Location = New System.Drawing.Point(55, 38)
        Me.EMailBox.Name = "EMailBox"
        Me.EMailBox.Size = New System.Drawing.Size(150, 20)
        Me.EMailBox.TabIndex = 1
        '
        'ProfileText
        '
        Me.ProfileText.AutoSize = True
        Me.ProfileText.Location = New System.Drawing.Point(6, 242)
        Me.ProfileText.Name = "ProfileText"
        Me.ProfileText.Size = New System.Drawing.Size(88, 13)
        Me.ProfileText.TabIndex = 0
        Me.ProfileText.Text = "Checkout Profile:"
        '
        'KeywordText
        '
        Me.KeywordText.AutoSize = True
        Me.KeywordText.Location = New System.Drawing.Point(6, 209)
        Me.KeywordText.Name = "KeywordText"
        Me.KeywordText.Size = New System.Drawing.Size(51, 13)
        Me.KeywordText.TabIndex = 0
        Me.KeywordText.Text = "Keyword:"
        '
        'LinkText
        '
        Me.LinkText.AutoSize = True
        Me.LinkText.Location = New System.Drawing.Point(6, 176)
        Me.LinkText.Name = "LinkText"
        Me.LinkText.Size = New System.Drawing.Size(30, 13)
        Me.LinkText.TabIndex = 0
        Me.LinkText.Text = "Link:"
        '
        'SiteText
        '
        Me.SiteText.AutoSize = True
        Me.SiteText.Location = New System.Drawing.Point(6, 141)
        Me.SiteText.Name = "SiteText"
        Me.SiteText.Size = New System.Drawing.Size(32, 13)
        Me.SiteText.TabIndex = 0
        Me.SiteText.Text = "*Site:"
        '
        'SizeText
        '
        Me.SizeText.AutoSize = True
        Me.SizeText.Location = New System.Drawing.Point(6, 107)
        Me.SizeText.Name = "SizeText"
        Me.SizeText.Size = New System.Drawing.Size(37, 13)
        Me.SizeText.TabIndex = 0
        Me.SizeText.Text = "*Size: "
        '
        'PasswordText
        '
        Me.PasswordText.AutoSize = True
        Me.PasswordText.Location = New System.Drawing.Point(6, 74)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(60, 13)
        Me.PasswordText.TabIndex = 0
        Me.PasswordText.Text = "*Password:"
        '
        'EMailText
        '
        Me.EMailText.AutoSize = True
        Me.EMailText.Location = New System.Drawing.Point(6, 41)
        Me.EMailText.Name = "EMailText"
        Me.EMailText.Size = New System.Drawing.Size(43, 13)
        Me.EMailText.TabIndex = 0
        Me.EMailText.Text = "*E-Mail:"
        '
        'ToolTip1
        '
        '
        'AccountAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 466)
        Me.Controls.Add(Me.AddAccountGroup)
        Me.MaximumSize = New System.Drawing.Size(315, 505)
        Me.MinimumSize = New System.Drawing.Size(315, 505)
        Me.Name = "AccountAddForm"
        Me.Text = "Account Add"
        Me.AddAccountGroup.ResumeLayout(False)
        Me.AddAccountGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddAccountGroup As GroupBox
    Friend WithEvents EMailText As Label
    Friend WithEvents SizeText As Label
    Friend WithEvents PasswordText As Label
    Friend WithEvents SiteText As Label
    Friend WithEvents KeywordText As Label
    Friend WithEvents LinkText As Label
    Friend WithEvents ProfileBox As TextBox
    Friend WithEvents KeywordBox As TextBox
    Friend WithEvents LinkBox As TextBox
    Friend WithEvents SizeBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents EMailBox As TextBox
    Friend WithEvents ProfileText As Label
    Friend WithEvents AccountAddCancelButton As Button
    Friend WithEvents AccountAddSaveButton As Button
    Friend WithEvents SiteComboBox As ComboBox
    Friend WithEvents GuestCheckBox As CheckBox
    Friend WithEvents NotificationNumberText As Label
    Friend WithEvents NotificationNumberBox As TextBox
    Friend WithEvents NotificationEMailBox As TextBox
    Friend WithEvents NotificationEMailText As Label
    Friend WithEvents PhoneCarrierComboBox As ComboBox
    Friend WithEvents PhoneCarrierText As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
End Class
