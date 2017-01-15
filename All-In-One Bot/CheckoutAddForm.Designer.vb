<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckoutAddForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ProfileText = New System.Windows.Forms.Label()
        Me.AddCheckoutGroup = New System.Windows.Forms.GroupBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.EmailText = New System.Windows.Forms.Label()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.MonthComboBox = New System.Windows.Forms.ComboBox()
        Me.USStateComboBox = New System.Windows.Forms.ComboBox()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.CardTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.CheckoutAddCancelButton = New System.Windows.Forms.Button()
        Me.CheckoutAddSaveButton = New System.Windows.Forms.Button()
        Me.CardNumberBox = New System.Windows.Forms.TextBox()
        Me.CardNumber = New System.Windows.Forms.Label()
        Me.CVVBox = New System.Windows.Forms.TextBox()
        Me.PhoneBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeBox = New System.Windows.Forms.TextBox()
        Me.Address2Box = New System.Windows.Forms.TextBox()
        Me.Address1Box = New System.Windows.Forms.TextBox()
        Me.LastNameBox = New System.Windows.Forms.TextBox()
        Me.FirstNameBox = New System.Windows.Forms.TextBox()
        Me.ProfileBox = New System.Windows.Forms.TextBox()
        Me.CVVText = New System.Windows.Forms.Label()
        Me.ExpireDateText = New System.Windows.Forms.Label()
        Me.CardTypeText = New System.Windows.Forms.Label()
        Me.PhoneText = New System.Windows.Forms.Label()
        Me.CountryText = New System.Windows.Forms.Label()
        Me.USStateText = New System.Windows.Forms.Label()
        Me.CityText = New System.Windows.Forms.Label()
        Me.ZipCodeText = New System.Windows.Forms.Label()
        Me.Address2Text = New System.Windows.Forms.Label()
        Me.Address1Text = New System.Windows.Forms.Label()
        Me.LastNameText = New System.Windows.Forms.Label()
        Me.FirstNameText = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddCheckoutGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProfileText
        '
        Me.ProfileText.AutoSize = True
        Me.ProfileText.Location = New System.Drawing.Point(6, 30)
        Me.ProfileText.Name = "ProfileText"
        Me.ProfileText.Size = New System.Drawing.Size(74, 13)
        Me.ProfileText.TabIndex = 0
        Me.ProfileText.Text = "*Profile Name:"
        '
        'AddCheckoutGroup
        '
        Me.AddCheckoutGroup.Controls.Add(Me.EmailBox)
        Me.AddCheckoutGroup.Controls.Add(Me.EmailText)
        Me.AddCheckoutGroup.Controls.Add(Me.YearComboBox)
        Me.AddCheckoutGroup.Controls.Add(Me.MonthComboBox)
        Me.AddCheckoutGroup.Controls.Add(Me.USStateComboBox)
        Me.AddCheckoutGroup.Controls.Add(Me.CountryComboBox)
        Me.AddCheckoutGroup.Controls.Add(Me.CardTypeComboBox)
        Me.AddCheckoutGroup.Controls.Add(Me.CheckoutAddCancelButton)
        Me.AddCheckoutGroup.Controls.Add(Me.CheckoutAddSaveButton)
        Me.AddCheckoutGroup.Controls.Add(Me.CardNumberBox)
        Me.AddCheckoutGroup.Controls.Add(Me.CardNumber)
        Me.AddCheckoutGroup.Controls.Add(Me.CVVBox)
        Me.AddCheckoutGroup.Controls.Add(Me.PhoneBox)
        Me.AddCheckoutGroup.Controls.Add(Me.CityBox)
        Me.AddCheckoutGroup.Controls.Add(Me.ZipCodeBox)
        Me.AddCheckoutGroup.Controls.Add(Me.Address2Box)
        Me.AddCheckoutGroup.Controls.Add(Me.Address1Box)
        Me.AddCheckoutGroup.Controls.Add(Me.LastNameBox)
        Me.AddCheckoutGroup.Controls.Add(Me.FirstNameBox)
        Me.AddCheckoutGroup.Controls.Add(Me.ProfileBox)
        Me.AddCheckoutGroup.Controls.Add(Me.CVVText)
        Me.AddCheckoutGroup.Controls.Add(Me.ExpireDateText)
        Me.AddCheckoutGroup.Controls.Add(Me.CardTypeText)
        Me.AddCheckoutGroup.Controls.Add(Me.PhoneText)
        Me.AddCheckoutGroup.Controls.Add(Me.CountryText)
        Me.AddCheckoutGroup.Controls.Add(Me.USStateText)
        Me.AddCheckoutGroup.Controls.Add(Me.CityText)
        Me.AddCheckoutGroup.Controls.Add(Me.ZipCodeText)
        Me.AddCheckoutGroup.Controls.Add(Me.Address2Text)
        Me.AddCheckoutGroup.Controls.Add(Me.Address1Text)
        Me.AddCheckoutGroup.Controls.Add(Me.LastNameText)
        Me.AddCheckoutGroup.Controls.Add(Me.FirstNameText)
        Me.AddCheckoutGroup.Controls.Add(Me.ProfileText)
        Me.AddCheckoutGroup.Location = New System.Drawing.Point(12, 12)
        Me.AddCheckoutGroup.Name = "AddCheckoutGroup"
        Me.AddCheckoutGroup.Size = New System.Drawing.Size(520, 367)
        Me.AddCheckoutGroup.TabIndex = 0
        Me.AddCheckoutGroup.TabStop = False
        Me.AddCheckoutGroup.Text = "Add Checkout"
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(310, 27)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(150, 20)
        Me.EmailBox.TabIndex = 11
        '
        'EmailText
        '
        Me.EmailText.AutoSize = True
        Me.EmailText.Location = New System.Drawing.Point(261, 30)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(43, 13)
        Me.EmailText.TabIndex = 0
        Me.EmailText.Text = "*E-Mail:"
        '
        'YearComboBox
        '
        Me.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Location = New System.Drawing.Point(448, 131)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(60, 21)
        Me.YearComboBox.TabIndex = 15
        '
        'MonthComboBox
        '
        Me.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthComboBox.FormattingEnabled = True
        Me.MonthComboBox.Location = New System.Drawing.Point(382, 131)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(60, 21)
        Me.MonthComboBox.TabIndex = 14
        '
        'USStateComboBox
        '
        Me.USStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.USStateComboBox.FormattingEnabled = True
        Me.USStateComboBox.Location = New System.Drawing.Point(69, 265)
        Me.USStateComboBox.Name = "USStateComboBox"
        Me.USStateComboBox.Size = New System.Drawing.Size(150, 21)
        Me.USStateComboBox.TabIndex = 8
        '
        'CountryComboBox
        '
        Me.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Location = New System.Drawing.Point(62, 300)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(150, 21)
        Me.CountryComboBox.TabIndex = 9
        '
        'CardTypeComboBox
        '
        Me.CardTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CardTypeComboBox.FormattingEnabled = True
        Me.CardTypeComboBox.Location = New System.Drawing.Point(330, 62)
        Me.CardTypeComboBox.Name = "CardTypeComboBox"
        Me.CardTypeComboBox.Size = New System.Drawing.Size(150, 21)
        Me.CardTypeComboBox.TabIndex = 12
        '
        'CheckoutAddCancelButton
        '
        Me.CheckoutAddCancelButton.Location = New System.Drawing.Point(433, 338)
        Me.CheckoutAddCancelButton.Name = "CheckoutAddCancelButton"
        Me.CheckoutAddCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckoutAddCancelButton.TabIndex = 18
        Me.CheckoutAddCancelButton.Text = "Cancel"
        Me.CheckoutAddCancelButton.UseVisualStyleBackColor = True
        '
        'CheckoutAddSaveButton
        '
        Me.CheckoutAddSaveButton.Location = New System.Drawing.Point(352, 338)
        Me.CheckoutAddSaveButton.Name = "CheckoutAddSaveButton"
        Me.CheckoutAddSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckoutAddSaveButton.TabIndex = 17
        Me.CheckoutAddSaveButton.Text = "Save"
        Me.CheckoutAddSaveButton.UseVisualStyleBackColor = True
        '
        'CardNumberBox
        '
        Me.CardNumberBox.Location = New System.Drawing.Point(343, 97)
        Me.CardNumberBox.Name = "CardNumberBox"
        Me.CardNumberBox.Size = New System.Drawing.Size(150, 20)
        Me.CardNumberBox.TabIndex = 13
        '
        'CardNumber
        '
        Me.CardNumber.AutoSize = True
        Me.CardNumber.Location = New System.Drawing.Point(261, 100)
        Me.CardNumber.Name = "CardNumber"
        Me.CardNumber.Size = New System.Drawing.Size(76, 13)
        Me.CardNumber.TabIndex = 0
        Me.CardNumber.Text = "*Card Number:"
        '
        'CVVBox
        '
        Me.CVVBox.Location = New System.Drawing.Point(302, 167)
        Me.CVVBox.Name = "CVVBox"
        Me.CVVBox.Size = New System.Drawing.Size(150, 20)
        Me.CVVBox.TabIndex = 16
        '
        'PhoneBox
        '
        Me.PhoneBox.Location = New System.Drawing.Point(57, 335)
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(150, 20)
        Me.PhoneBox.TabIndex = 10
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(43, 230)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(150, 20)
        Me.CityBox.TabIndex = 7
        '
        'ZipCodeBox
        '
        Me.ZipCodeBox.Location = New System.Drawing.Point(69, 195)
        Me.ZipCodeBox.Name = "ZipCodeBox"
        Me.ZipCodeBox.Size = New System.Drawing.Size(150, 20)
        Me.ZipCodeBox.TabIndex = 6
        '
        'Address2Box
        '
        Me.Address2Box.Location = New System.Drawing.Point(69, 163)
        Me.Address2Box.Name = "Address2Box"
        Me.Address2Box.Size = New System.Drawing.Size(150, 20)
        Me.Address2Box.TabIndex = 5
        '
        'Address1Box
        '
        Me.Address1Box.Location = New System.Drawing.Point(73, 130)
        Me.Address1Box.Name = "Address1Box"
        Me.Address1Box.Size = New System.Drawing.Size(150, 20)
        Me.Address1Box.TabIndex = 4
        '
        'LastNameBox
        '
        Me.LastNameBox.Location = New System.Drawing.Point(77, 95)
        Me.LastNameBox.Name = "LastNameBox"
        Me.LastNameBox.Size = New System.Drawing.Size(150, 20)
        Me.LastNameBox.TabIndex = 3
        '
        'FirstNameBox
        '
        Me.FirstNameBox.Location = New System.Drawing.Point(76, 60)
        Me.FirstNameBox.Name = "FirstNameBox"
        Me.FirstNameBox.Size = New System.Drawing.Size(150, 20)
        Me.FirstNameBox.TabIndex = 2
        '
        'ProfileBox
        '
        Me.ProfileBox.Location = New System.Drawing.Point(86, 25)
        Me.ProfileBox.Name = "ProfileBox"
        Me.ProfileBox.Size = New System.Drawing.Size(150, 20)
        Me.ProfileBox.TabIndex = 1
        '
        'CVVText
        '
        Me.CVVText.AutoSize = True
        Me.CVVText.Location = New System.Drawing.Point(261, 170)
        Me.CVVText.Name = "CVVText"
        Me.CVVText.Size = New System.Drawing.Size(35, 13)
        Me.CVVText.TabIndex = 0
        Me.CVVText.Text = "*CVV:"
        '
        'ExpireDateText
        '
        Me.ExpireDateText.AutoSize = True
        Me.ExpireDateText.Location = New System.Drawing.Point(261, 135)
        Me.ExpireDateText.Name = "ExpireDateText"
        Me.ExpireDateText.Size = New System.Drawing.Size(115, 13)
        Me.ExpireDateText.TabIndex = 0
        Me.ExpireDateText.Text = "*Expire Date (MM/YY):"
        '
        'CardTypeText
        '
        Me.CardTypeText.AutoSize = True
        Me.CardTypeText.Location = New System.Drawing.Point(261, 65)
        Me.CardTypeText.Name = "CardTypeText"
        Me.CardTypeText.Size = New System.Drawing.Size(63, 13)
        Me.CardTypeText.TabIndex = 0
        Me.CardTypeText.Text = "*Card Type:"
        '
        'PhoneText
        '
        Me.PhoneText.AutoSize = True
        Me.PhoneText.Location = New System.Drawing.Point(6, 338)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(45, 13)
        Me.PhoneText.TabIndex = 0
        Me.PhoneText.Text = "*Phone:"
        '
        'CountryText
        '
        Me.CountryText.AutoSize = True
        Me.CountryText.Location = New System.Drawing.Point(6, 303)
        Me.CountryText.Name = "CountryText"
        Me.CountryText.Size = New System.Drawing.Size(50, 13)
        Me.CountryText.TabIndex = 0
        Me.CountryText.Text = "*Country:"
        '
        'USStateText
        '
        Me.USStateText.AutoSize = True
        Me.USStateText.Location = New System.Drawing.Point(6, 268)
        Me.USStateText.Name = "USStateText"
        Me.USStateText.Size = New System.Drawing.Size(57, 13)
        Me.USStateText.TabIndex = 0
        Me.USStateText.Text = "*US State:"
        '
        'CityText
        '
        Me.CityText.AutoSize = True
        Me.CityText.Location = New System.Drawing.Point(6, 233)
        Me.CityText.Name = "CityText"
        Me.CityText.Size = New System.Drawing.Size(31, 13)
        Me.CityText.TabIndex = 0
        Me.CityText.Text = "*City:"
        '
        'ZipCodeText
        '
        Me.ZipCodeText.AutoSize = True
        Me.ZipCodeText.Location = New System.Drawing.Point(6, 198)
        Me.ZipCodeText.Name = "ZipCodeText"
        Me.ZipCodeText.Size = New System.Drawing.Size(57, 13)
        Me.ZipCodeText.TabIndex = 0
        Me.ZipCodeText.Text = "*Zip Code:"
        '
        'Address2Text
        '
        Me.Address2Text.AutoSize = True
        Me.Address2Text.Location = New System.Drawing.Point(6, 166)
        Me.Address2Text.Name = "Address2Text"
        Me.Address2Text.Size = New System.Drawing.Size(57, 13)
        Me.Address2Text.TabIndex = 0
        Me.Address2Text.Text = "Address 2:"
        '
        'Address1Text
        '
        Me.Address1Text.AutoSize = True
        Me.Address1Text.Location = New System.Drawing.Point(6, 133)
        Me.Address1Text.Name = "Address1Text"
        Me.Address1Text.Size = New System.Drawing.Size(61, 13)
        Me.Address1Text.TabIndex = 0
        Me.Address1Text.Text = "*Address 1:"
        '
        'LastNameText
        '
        Me.LastNameText.AutoSize = True
        Me.LastNameText.Location = New System.Drawing.Point(6, 98)
        Me.LastNameText.Name = "LastNameText"
        Me.LastNameText.Size = New System.Drawing.Size(65, 13)
        Me.LastNameText.TabIndex = 0
        Me.LastNameText.Text = "*Last Name:"
        '
        'FirstNameText
        '
        Me.FirstNameText.AutoSize = True
        Me.FirstNameText.Location = New System.Drawing.Point(6, 65)
        Me.FirstNameText.Name = "FirstNameText"
        Me.FirstNameText.Size = New System.Drawing.Size(64, 13)
        Me.FirstNameText.TabIndex = 0
        Me.FirstNameText.Text = "*First Name:"
        '
        'CheckoutAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(544, 391)
        Me.Controls.Add(Me.AddCheckoutGroup)
        Me.MaximumSize = New System.Drawing.Size(560, 430)
        Me.MinimumSize = New System.Drawing.Size(560, 430)
        Me.Name = "CheckoutAddForm"
        Me.Text = "Checkout Add"
        Me.AddCheckoutGroup.ResumeLayout(False)
        Me.AddCheckoutGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProfileText As Label
    Friend WithEvents AddCheckoutGroup As GroupBox
    Friend WithEvents LastNameText As Label
    Friend WithEvents FirstNameText As Label
    Friend WithEvents Address1Text As Label
    Friend WithEvents ZipCodeText As Label
    Friend WithEvents Address2Text As Label
    Friend WithEvents USStateText As Label
    Friend WithEvents CityText As Label
    Friend WithEvents CountryText As Label
    Friend WithEvents CardTypeText As Label
    Friend WithEvents PhoneText As Label
    Friend WithEvents CVVText As Label
    Friend WithEvents ExpireDateText As Label
    Friend WithEvents CardNumber As Label
    Friend WithEvents CVVBox As TextBox
    Friend WithEvents PhoneBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents ZipCodeBox As TextBox
    Friend WithEvents Address2Box As TextBox
    Friend WithEvents Address1Box As TextBox
    Friend WithEvents LastNameBox As TextBox
    Friend WithEvents FirstNameBox As TextBox
    Friend WithEvents ProfileBox As TextBox
    Friend WithEvents CardNumberBox As TextBox
    Friend WithEvents CheckoutAddCancelButton As Button
    Friend WithEvents CheckoutAddSaveButton As Button
    Friend WithEvents CardTypeComboBox As ComboBox
    Friend WithEvents CountryComboBox As ComboBox
    Friend WithEvents USStateComboBox As ComboBox
    Friend WithEvents YearComboBox As ComboBox
    Friend WithEvents MonthComboBox As ComboBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents EmailText As Label
End Class
