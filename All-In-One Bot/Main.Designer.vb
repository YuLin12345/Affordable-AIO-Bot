<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AccountTab = New System.Windows.Forms.TabPage()
        Me.AccountManagementGroup = New System.Windows.Forms.GroupBox()
        Me.AccountCountText = New System.Windows.Forms.Label()
        Me.AccountCountLabel = New System.Windows.Forms.Label()
        Me.AccountLink = New System.Windows.Forms.LinkLabel()
        Me.AccountImportButton = New System.Windows.Forms.Button()
        Me.AccountCloneButton = New System.Windows.Forms.Button()
        Me.AccountExportButton = New System.Windows.Forms.Button()
        Me.AccountRemoveButton = New System.Windows.Forms.Button()
        Me.AccountData = New System.Windows.Forms.DataGridView()
        Me.EmailA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainSite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Link = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keyword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Checkout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proxy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotificiationEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneCarrier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotificiationNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutTab = New System.Windows.Forms.TabPage()
        Me.CheckoutManagementGroup = New System.Windows.Forms.GroupBox()
        Me.CheckoutCountText = New System.Windows.Forms.Label()
        Me.CheckoutCountLabel = New System.Windows.Forms.Label()
        Me.CheckoutLink = New System.Windows.Forms.LinkLabel()
        Me.CheckoutCloneButton = New System.Windows.Forms.Button()
        Me.CheckoutImportButton = New System.Windows.Forms.Button()
        Me.CheckoutExportButton = New System.Windows.Forms.Button()
        Me.CheckoutRemoveButton = New System.Windows.Forms.Button()
        Me.CheckoutData = New System.Windows.Forms.DataGridView()
        Me.Profile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogTab = New System.Windows.Forms.TabPage()
        Me.LogRichBox = New System.Windows.Forms.RichTextBox()
        Me.BotOptionsGroup = New System.Windows.Forms.GroupBox()
        Me.CartLink = New System.Windows.Forms.LinkLabel()
        Me.TipsLink = New System.Windows.Forms.LinkLabel()
        Me.MainStartButton = New System.Windows.Forms.Button()
        Me.ProxyLink = New System.Windows.Forms.LinkLabel()
        Me.MainStopButton = New System.Windows.Forms.Button()
        Me.AutomaticUpdater = New wyDay.Controls.AutomaticUpdater()
        Me.ImportFile = New System.Windows.Forms.OpenFileDialog()
        Me.ExportFile = New System.Windows.Forms.SaveFileDialog()
        Me.AccountContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AccountImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountCloneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountRemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountRemoveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountEditAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountKeywordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccounEditSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSizeSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSiteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountLinkSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountKeywordSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckoutImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutCloneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutRemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutRemoveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.AccountTab.SuspendLayout()
        Me.AccountManagementGroup.SuspendLayout()
        CType(Me.AccountData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CheckoutTab.SuspendLayout()
        Me.CheckoutManagementGroup.SuspendLayout()
        CType(Me.CheckoutData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogTab.SuspendLayout()
        Me.BotOptionsGroup.SuspendLayout()
        CType(Me.AutomaticUpdater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountContextMenuStrip.SuspendLayout()
        Me.CheckoutContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AccountTab)
        Me.TabControl1.Controls.Add(Me.CheckoutTab)
        Me.TabControl1.Controls.Add(Me.LogTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1260, 675)
        Me.TabControl1.TabIndex = 6
        '
        'AccountTab
        '
        Me.AccountTab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AccountTab.Controls.Add(Me.AccountManagementGroup)
        Me.AccountTab.Controls.Add(Me.AccountData)
        Me.AccountTab.Location = New System.Drawing.Point(4, 22)
        Me.AccountTab.Name = "AccountTab"
        Me.AccountTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AccountTab.Size = New System.Drawing.Size(1252, 649)
        Me.AccountTab.TabIndex = 0
        Me.AccountTab.Text = "Account Tab"
        '
        'AccountManagementGroup
        '
        Me.AccountManagementGroup.Controls.Add(Me.AccountCountText)
        Me.AccountManagementGroup.Controls.Add(Me.AccountCountLabel)
        Me.AccountManagementGroup.Controls.Add(Me.AccountLink)
        Me.AccountManagementGroup.Controls.Add(Me.AccountImportButton)
        Me.AccountManagementGroup.Controls.Add(Me.AccountCloneButton)
        Me.AccountManagementGroup.Controls.Add(Me.AccountExportButton)
        Me.AccountManagementGroup.Controls.Add(Me.AccountRemoveButton)
        Me.AccountManagementGroup.Location = New System.Drawing.Point(0, 0)
        Me.AccountManagementGroup.Name = "AccountManagementGroup"
        Me.AccountManagementGroup.Size = New System.Drawing.Size(1252, 50)
        Me.AccountManagementGroup.TabIndex = 0
        Me.AccountManagementGroup.TabStop = False
        Me.AccountManagementGroup.Text = "Account Management"
        '
        'AccountCountText
        '
        Me.AccountCountText.AutoSize = True
        Me.AccountCountText.Location = New System.Drawing.Point(1223, 23)
        Me.AccountCountText.Name = "AccountCountText"
        Me.AccountCountText.Size = New System.Drawing.Size(13, 13)
        Me.AccountCountText.TabIndex = 13
        Me.AccountCountText.Text = "0"
        '
        'AccountCountLabel
        '
        Me.AccountCountLabel.AutoSize = True
        Me.AccountCountLabel.Location = New System.Drawing.Point(1167, 23)
        Me.AccountCountLabel.Name = "AccountCountLabel"
        Me.AccountCountLabel.Size = New System.Drawing.Size(50, 13)
        Me.AccountCountLabel.TabIndex = 12
        Me.AccountCountLabel.Text = "Account:"
        '
        'AccountLink
        '
        Me.AccountLink.AutoSize = True
        Me.AccountLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountLink.Location = New System.Drawing.Point(6, 25)
        Me.AccountLink.Name = "AccountLink"
        Me.AccountLink.Size = New System.Drawing.Size(84, 16)
        Me.AccountLink.TabIndex = 7
        Me.AccountLink.TabStop = True
        Me.AccountLink.Text = "Add Account"
        '
        'AccountImportButton
        '
        Me.AccountImportButton.Location = New System.Drawing.Point(96, 18)
        Me.AccountImportButton.Name = "AccountImportButton"
        Me.AccountImportButton.Size = New System.Drawing.Size(75, 23)
        Me.AccountImportButton.TabIndex = 8
        Me.AccountImportButton.Text = "Import"
        Me.AccountImportButton.UseVisualStyleBackColor = True
        '
        'AccountCloneButton
        '
        Me.AccountCloneButton.Location = New System.Drawing.Point(339, 18)
        Me.AccountCloneButton.Name = "AccountCloneButton"
        Me.AccountCloneButton.Size = New System.Drawing.Size(75, 23)
        Me.AccountCloneButton.TabIndex = 11
        Me.AccountCloneButton.Text = "Clone"
        Me.AccountCloneButton.UseVisualStyleBackColor = True
        '
        'AccountExportButton
        '
        Me.AccountExportButton.Location = New System.Drawing.Point(177, 18)
        Me.AccountExportButton.Name = "AccountExportButton"
        Me.AccountExportButton.Size = New System.Drawing.Size(75, 23)
        Me.AccountExportButton.TabIndex = 9
        Me.AccountExportButton.Text = "Export"
        Me.AccountExportButton.UseVisualStyleBackColor = True
        '
        'AccountRemoveButton
        '
        Me.AccountRemoveButton.Location = New System.Drawing.Point(258, 18)
        Me.AccountRemoveButton.Name = "AccountRemoveButton"
        Me.AccountRemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.AccountRemoveButton.TabIndex = 10
        Me.AccountRemoveButton.Text = "Remove"
        Me.AccountRemoveButton.UseVisualStyleBackColor = True
        '
        'AccountData
        '
        Me.AccountData.AllowUserToAddRows = False
        Me.AccountData.AllowUserToOrderColumns = True
        Me.AccountData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmailA, Me.Password, Me.MainSize, Me.MainSite, Me.Link, Me.Keyword, Me.Checkout, Me.Proxy, Me.Guest, Me.NotificiationEmail, Me.PhoneCarrier, Me.NotificiationNumber})
        Me.AccountData.Location = New System.Drawing.Point(0, 47)
        Me.AccountData.Name = "AccountData"
        Me.AccountData.ReadOnly = True
        Me.AccountData.Size = New System.Drawing.Size(1252, 602)
        Me.AccountData.TabIndex = 0
        '
        'EmailA
        '
        Me.EmailA.HeaderText = "Email"
        Me.EmailA.Name = "EmailA"
        Me.EmailA.ReadOnly = True
        Me.EmailA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmailA.Width = 120
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        Me.Password.Width = 120
        '
        'MainSize
        '
        Me.MainSize.HeaderText = "Size"
        Me.MainSize.Name = "MainSize"
        Me.MainSize.ReadOnly = True
        Me.MainSize.Width = 70
        '
        'MainSite
        '
        Me.MainSite.HeaderText = "Site"
        Me.MainSite.Name = "MainSite"
        Me.MainSite.ReadOnly = True
        Me.MainSite.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Link
        '
        Me.Link.HeaderText = "Link"
        Me.Link.Name = "Link"
        Me.Link.ReadOnly = True
        Me.Link.Width = 150
        '
        'Keyword
        '
        Me.Keyword.HeaderText = "Keyword"
        Me.Keyword.Name = "Keyword"
        Me.Keyword.ReadOnly = True
        Me.Keyword.Width = 150
        '
        'Checkout
        '
        Me.Checkout.HeaderText = "Checkout Profile"
        Me.Checkout.Name = "Checkout"
        Me.Checkout.ReadOnly = True
        Me.Checkout.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Checkout.Width = 120
        '
        'Proxy
        '
        Me.Proxy.HeaderText = "Proxy"
        Me.Proxy.Name = "Proxy"
        Me.Proxy.ReadOnly = True
        Me.Proxy.Width = 110
        '
        'Guest
        '
        Me.Guest.HeaderText = "Guest"
        Me.Guest.Name = "Guest"
        Me.Guest.ReadOnly = True
        Me.Guest.Width = 60
        '
        'NotificiationEmail
        '
        Me.NotificiationEmail.HeaderText = "Notificiation Email"
        Me.NotificiationEmail.Name = "NotificiationEmail"
        Me.NotificiationEmail.ReadOnly = True
        Me.NotificiationEmail.Width = 125
        '
        'PhoneCarrier
        '
        Me.PhoneCarrier.HeaderText = "Phone Carrier"
        Me.PhoneCarrier.Name = "PhoneCarrier"
        Me.PhoneCarrier.ReadOnly = True
        Me.PhoneCarrier.Width = 125
        '
        'NotificiationNumber
        '
        Me.NotificiationNumber.HeaderText = "Notificiation Number"
        Me.NotificiationNumber.Name = "NotificiationNumber"
        Me.NotificiationNumber.ReadOnly = True
        Me.NotificiationNumber.Width = 125
        '
        'CheckoutTab
        '
        Me.CheckoutTab.Controls.Add(Me.CheckoutManagementGroup)
        Me.CheckoutTab.Controls.Add(Me.CheckoutData)
        Me.CheckoutTab.Location = New System.Drawing.Point(4, 22)
        Me.CheckoutTab.Name = "CheckoutTab"
        Me.CheckoutTab.Size = New System.Drawing.Size(1252, 649)
        Me.CheckoutTab.TabIndex = 0
        Me.CheckoutTab.Text = "Checkout Tab"
        Me.CheckoutTab.UseVisualStyleBackColor = True
        '
        'CheckoutManagementGroup
        '
        Me.CheckoutManagementGroup.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CheckoutManagementGroup.Controls.Add(Me.CheckoutCountText)
        Me.CheckoutManagementGroup.Controls.Add(Me.CheckoutCountLabel)
        Me.CheckoutManagementGroup.Controls.Add(Me.CheckoutLink)
        Me.CheckoutManagementGroup.Controls.Add(Me.CheckoutCloneButton)
        Me.CheckoutManagementGroup.Controls.Add(Me.CheckoutImportButton)
        Me.CheckoutManagementGroup.Controls.Add(Me.CheckoutExportButton)
        Me.CheckoutManagementGroup.Controls.Add(Me.CheckoutRemoveButton)
        Me.CheckoutManagementGroup.Location = New System.Drawing.Point(0, 0)
        Me.CheckoutManagementGroup.Name = "CheckoutManagementGroup"
        Me.CheckoutManagementGroup.Size = New System.Drawing.Size(1252, 50)
        Me.CheckoutManagementGroup.TabIndex = 0
        Me.CheckoutManagementGroup.TabStop = False
        Me.CheckoutManagementGroup.Text = "Checkout Management"
        '
        'CheckoutCountText
        '
        Me.CheckoutCountText.AutoSize = True
        Me.CheckoutCountText.Location = New System.Drawing.Point(1223, 23)
        Me.CheckoutCountText.Name = "CheckoutCountText"
        Me.CheckoutCountText.Size = New System.Drawing.Size(13, 13)
        Me.CheckoutCountText.TabIndex = 18
        Me.CheckoutCountText.Text = "0"
        '
        'CheckoutCountLabel
        '
        Me.CheckoutCountLabel.AutoSize = True
        Me.CheckoutCountLabel.Location = New System.Drawing.Point(1129, 23)
        Me.CheckoutCountLabel.Name = "CheckoutCountLabel"
        Me.CheckoutCountLabel.Size = New System.Drawing.Size(88, 13)
        Me.CheckoutCountLabel.TabIndex = 17
        Me.CheckoutCountLabel.Text = "Checkout Profile:"
        '
        'CheckoutLink
        '
        Me.CheckoutLink.AutoSize = True
        Me.CheckoutLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutLink.Location = New System.Drawing.Point(6, 25)
        Me.CheckoutLink.Name = "CheckoutLink"
        Me.CheckoutLink.Size = New System.Drawing.Size(92, 16)
        Me.CheckoutLink.TabIndex = 12
        Me.CheckoutLink.TabStop = True
        Me.CheckoutLink.Text = "Add Checkout"
        '
        'CheckoutCloneButton
        '
        Me.CheckoutCloneButton.Location = New System.Drawing.Point(347, 18)
        Me.CheckoutCloneButton.Name = "CheckoutCloneButton"
        Me.CheckoutCloneButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckoutCloneButton.TabIndex = 16
        Me.CheckoutCloneButton.Text = "Clone"
        Me.CheckoutCloneButton.UseVisualStyleBackColor = True
        '
        'CheckoutImportButton
        '
        Me.CheckoutImportButton.Location = New System.Drawing.Point(104, 18)
        Me.CheckoutImportButton.Name = "CheckoutImportButton"
        Me.CheckoutImportButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckoutImportButton.TabIndex = 13
        Me.CheckoutImportButton.Text = "Import"
        Me.CheckoutImportButton.UseVisualStyleBackColor = True
        '
        'CheckoutExportButton
        '
        Me.CheckoutExportButton.Location = New System.Drawing.Point(185, 18)
        Me.CheckoutExportButton.Name = "CheckoutExportButton"
        Me.CheckoutExportButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckoutExportButton.TabIndex = 14
        Me.CheckoutExportButton.Text = "Export"
        Me.CheckoutExportButton.UseVisualStyleBackColor = True
        '
        'CheckoutRemoveButton
        '
        Me.CheckoutRemoveButton.Location = New System.Drawing.Point(266, 18)
        Me.CheckoutRemoveButton.Name = "CheckoutRemoveButton"
        Me.CheckoutRemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckoutRemoveButton.TabIndex = 15
        Me.CheckoutRemoveButton.Text = "Remove"
        Me.CheckoutRemoveButton.UseVisualStyleBackColor = True
        '
        'CheckoutData
        '
        Me.CheckoutData.AllowUserToAddRows = False
        Me.CheckoutData.AllowUserToOrderColumns = True
        Me.CheckoutData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CheckoutData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Profile, Me.FirstName, Me.LastName, Me.Address1, Me.Address2, Me.ZipCode, Me.City, Me.State, Me.Country, Me.Phone, Me.EmailC, Me.CardType, Me.CardNumber, Me.Month, Me.Year, Me.CVV})
        Me.CheckoutData.Location = New System.Drawing.Point(0, 47)
        Me.CheckoutData.Name = "CheckoutData"
        Me.CheckoutData.ReadOnly = True
        Me.CheckoutData.Size = New System.Drawing.Size(1252, 602)
        Me.CheckoutData.TabIndex = 0
        '
        'Profile
        '
        Me.Profile.HeaderText = "Profile Name"
        Me.Profile.Name = "Profile"
        Me.Profile.ReadOnly = True
        Me.Profile.Width = 90
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'Address1
        '
        Me.Address1.HeaderText = "Address 1"
        Me.Address1.Name = "Address1"
        Me.Address1.ReadOnly = True
        Me.Address1.Width = 140
        '
        'Address2
        '
        Me.Address2.HeaderText = "Address 2"
        Me.Address2.Name = "Address2"
        Me.Address2.ReadOnly = True
        Me.Address2.Width = 130
        '
        'ZipCode
        '
        Me.ZipCode.HeaderText = "Zip Code"
        Me.ZipCode.Name = "ZipCode"
        Me.ZipCode.ReadOnly = True
        Me.ZipCode.Width = 90
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        Me.City.ReadOnly = True
        '
        'State
        '
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.ReadOnly = True
        Me.State.Width = 120
        '
        'Country
        '
        Me.Country.HeaderText = "Country"
        Me.Country.Name = "Country"
        Me.Country.ReadOnly = True
        Me.Country.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Country.Width = 120
        '
        'Phone
        '
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        Me.Phone.Width = 120
        '
        'EmailC
        '
        Me.EmailC.HeaderText = "Email"
        Me.EmailC.Name = "EmailC"
        Me.EmailC.ReadOnly = True
        '
        'CardType
        '
        Me.CardType.HeaderText = "Card Type"
        Me.CardType.Name = "CardType"
        Me.CardType.ReadOnly = True
        Me.CardType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'CardNumber
        '
        Me.CardNumber.HeaderText = "Card Number"
        Me.CardNumber.Name = "CardNumber"
        Me.CardNumber.ReadOnly = True
        Me.CardNumber.Width = 120
        '
        'Month
        '
        Me.Month.HeaderText = "Month"
        Me.Month.Name = "Month"
        Me.Month.ReadOnly = True
        Me.Month.Width = 50
        '
        'Year
        '
        Me.Year.HeaderText = "Year"
        Me.Year.Name = "Year"
        Me.Year.ReadOnly = True
        Me.Year.Width = 50
        '
        'CVV
        '
        Me.CVV.HeaderText = "CVV"
        Me.CVV.Name = "CVV"
        Me.CVV.ReadOnly = True
        Me.CVV.Width = 50
        '
        'LogTab
        '
        Me.LogTab.Controls.Add(Me.LogRichBox)
        Me.LogTab.Location = New System.Drawing.Point(4, 22)
        Me.LogTab.Name = "LogTab"
        Me.LogTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LogTab.Size = New System.Drawing.Size(1252, 649)
        Me.LogTab.TabIndex = 1
        Me.LogTab.Text = "Log Tab"
        Me.LogTab.UseVisualStyleBackColor = True
        '
        'LogRichBox
        '
        Me.LogRichBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LogRichBox.Location = New System.Drawing.Point(0, 0)
        Me.LogRichBox.Name = "LogRichBox"
        Me.LogRichBox.Size = New System.Drawing.Size(1252, 649)
        Me.LogRichBox.TabIndex = 17
        Me.LogRichBox.Text = ""
        '
        'BotOptionsGroup
        '
        Me.BotOptionsGroup.Controls.Add(Me.CartLink)
        Me.BotOptionsGroup.Controls.Add(Me.TipsLink)
        Me.BotOptionsGroup.Controls.Add(Me.MainStartButton)
        Me.BotOptionsGroup.Controls.Add(Me.ProxyLink)
        Me.BotOptionsGroup.Controls.Add(Me.MainStopButton)
        Me.BotOptionsGroup.Location = New System.Drawing.Point(12, 12)
        Me.BotOptionsGroup.Name = "BotOptionsGroup"
        Me.BotOptionsGroup.Size = New System.Drawing.Size(1260, 56)
        Me.BotOptionsGroup.TabIndex = 0
        Me.BotOptionsGroup.TabStop = False
        Me.BotOptionsGroup.Text = "Bot Options"
        '
        'CartLink
        '
        Me.CartLink.AutoSize = True
        Me.CartLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartLink.Location = New System.Drawing.Point(1018, 34)
        Me.CartLink.Name = "CartLink"
        Me.CartLink.Size = New System.Drawing.Size(64, 16)
        Me.CartLink.TabIndex = 4
        Me.CartLink.TabStop = True
        Me.CartLink.Text = "View Cart"
        '
        'TipsLink
        '
        Me.TipsLink.ActiveLinkColor = System.Drawing.Color.DarkRed
        Me.TipsLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipsLink.LinkColor = System.Drawing.Color.Red
        Me.TipsLink.Location = New System.Drawing.Point(10, 15)
        Me.TipsLink.Name = "TipsLink"
        Me.TipsLink.Size = New System.Drawing.Size(36, 15)
        Me.TipsLink.TabIndex = 5
        Me.TipsLink.TabStop = True
        Me.TipsLink.Text = "Tips"
        '
        'MainStartButton
        '
        Me.MainStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainStartButton.Location = New System.Drawing.Point(1088, 15)
        Me.MainStartButton.Name = "MainStartButton"
        Me.MainStartButton.Size = New System.Drawing.Size(80, 35)
        Me.MainStartButton.TabIndex = 1
        Me.MainStartButton.Text = "START"
        Me.MainStartButton.UseVisualStyleBackColor = True
        '
        'ProxyLink
        '
        Me.ProxyLink.AutoSize = True
        Me.ProxyLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProxyLink.Location = New System.Drawing.Point(989, 14)
        Me.ProxyLink.Name = "ProxyLink"
        Me.ProxyLink.Size = New System.Drawing.Size(93, 16)
        Me.ProxyLink.TabIndex = 3
        Me.ProxyLink.TabStop = True
        Me.ProxyLink.Text = "Proxy Settings"
        '
        'MainStopButton
        '
        Me.MainStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainStopButton.Location = New System.Drawing.Point(1174, 15)
        Me.MainStopButton.Name = "MainStopButton"
        Me.MainStopButton.Size = New System.Drawing.Size(80, 35)
        Me.MainStopButton.TabIndex = 2
        Me.MainStopButton.Text = "STOP"
        Me.MainStopButton.UseVisualStyleBackColor = True
        '
        'AutomaticUpdater
        '
        Me.AutomaticUpdater.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AutomaticUpdater.ContainerForm = Me
        Me.AutomaticUpdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutomaticUpdater.GUID = "383f3fb9-d179-4107-aca0-2fee16ab15bb"
        Me.AutomaticUpdater.Location = New System.Drawing.Point(86, 2)
        Me.AutomaticUpdater.Name = "AutomaticUpdater"
        Me.AutomaticUpdater.Size = New System.Drawing.Size(16, 16)
        Me.AutomaticUpdater.TabIndex = 0
        Me.AutomaticUpdater.wyUpdateCommandline = Nothing
        '
        'AccountContextMenuStrip
        '
        Me.AccountContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountImportToolStripMenuItem, Me.AccountExportToolStripMenuItem, Me.AccountCloneToolStripMenuItem, Me.AccountRemoveToolStripMenuItem, Me.AccountRemoveAllToolStripMenuItem, Me.AccountEditAllToolStripMenuItem, Me.AccounEditSelectedToolStripMenuItem})
        Me.AccountContextMenuStrip.Name = "ContextMenuStrip1"
        Me.AccountContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.AccountContextMenuStrip.Size = New System.Drawing.Size(142, 158)
        '
        'AccountImportToolStripMenuItem
        '
        Me.AccountImportToolStripMenuItem.Name = "AccountImportToolStripMenuItem"
        Me.AccountImportToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AccountImportToolStripMenuItem.Text = "Import"
        '
        'AccountExportToolStripMenuItem
        '
        Me.AccountExportToolStripMenuItem.Name = "AccountExportToolStripMenuItem"
        Me.AccountExportToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AccountExportToolStripMenuItem.Text = "Export"
        '
        'AccountCloneToolStripMenuItem
        '
        Me.AccountCloneToolStripMenuItem.Name = "AccountCloneToolStripMenuItem"
        Me.AccountCloneToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AccountCloneToolStripMenuItem.Text = "Clone"
        '
        'AccountRemoveToolStripMenuItem
        '
        Me.AccountRemoveToolStripMenuItem.Name = "AccountRemoveToolStripMenuItem"
        Me.AccountRemoveToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AccountRemoveToolStripMenuItem.Text = "Remove"
        '
        'AccountRemoveAllToolStripMenuItem
        '
        Me.AccountRemoveAllToolStripMenuItem.Name = "AccountRemoveAllToolStripMenuItem"
        Me.AccountRemoveAllToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AccountRemoveAllToolStripMenuItem.Text = "Remove All"
        '
        'AccountEditAllToolStripMenuItem
        '
        Me.AccountEditAllToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountSizeToolStripMenuItem, Me.AccountSiteToolStripMenuItem, Me.AccountLinkToolStripMenuItem, Me.AccountKeywordToolStripMenuItem})
        Me.AccountEditAllToolStripMenuItem.Name = "AccountEditAllToolStripMenuItem"
        Me.AccountEditAllToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AccountEditAllToolStripMenuItem.Text = "Edit All"
        '
        'AccountSizeToolStripMenuItem
        '
        Me.AccountSizeToolStripMenuItem.Name = "AccountSizeToolStripMenuItem"
        Me.AccountSizeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountSizeToolStripMenuItem.Text = "Size"
        '
        'AccountSiteToolStripMenuItem
        '
        Me.AccountSiteToolStripMenuItem.Name = "AccountSiteToolStripMenuItem"
        Me.AccountSiteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountSiteToolStripMenuItem.Text = "Site"
        '
        'AccountLinkToolStripMenuItem
        '
        Me.AccountLinkToolStripMenuItem.Name = "AccountLinkToolStripMenuItem"
        Me.AccountLinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountLinkToolStripMenuItem.Text = "Link"
        '
        'AccountKeywordToolStripMenuItem
        '
        Me.AccountKeywordToolStripMenuItem.Name = "AccountKeywordToolStripMenuItem"
        Me.AccountKeywordToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountKeywordToolStripMenuItem.Text = "Keyword"
        '
        'AccounEditSelectedToolStripMenuItem
        '
        Me.AccounEditSelectedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountSizeSelectedToolStripMenuItem, Me.AccountSiteSelectedToolStripMenuItem, Me.AccountLinkSelectedToolStripMenuItem, Me.AccountKeywordSelectedToolStripMenuItem})
        Me.AccounEditSelectedToolStripMenuItem.Name = "AccounEditSelectedToolStripMenuItem"
        Me.AccounEditSelectedToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AccounEditSelectedToolStripMenuItem.Text = "Edit Selected"
        '
        'AccountSizeSelectedToolStripMenuItem
        '
        Me.AccountSizeSelectedToolStripMenuItem.Name = "AccountSizeSelectedToolStripMenuItem"
        Me.AccountSizeSelectedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountSizeSelectedToolStripMenuItem.Text = "Size"
        '
        'AccountSiteSelectedToolStripMenuItem
        '
        Me.AccountSiteSelectedToolStripMenuItem.Name = "AccountSiteSelectedToolStripMenuItem"
        Me.AccountSiteSelectedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountSiteSelectedToolStripMenuItem.Text = "Site"
        '
        'AccountLinkSelectedToolStripMenuItem
        '
        Me.AccountLinkSelectedToolStripMenuItem.Name = "AccountLinkSelectedToolStripMenuItem"
        Me.AccountLinkSelectedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountLinkSelectedToolStripMenuItem.Text = "Link"
        '
        'AccountKeywordSelectedToolStripMenuItem
        '
        Me.AccountKeywordSelectedToolStripMenuItem.Name = "AccountKeywordSelectedToolStripMenuItem"
        Me.AccountKeywordSelectedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountKeywordSelectedToolStripMenuItem.Text = "Keyword"
        '
        'CheckoutContextMenuStrip
        '
        Me.CheckoutContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckoutImportToolStripMenuItem, Me.CheckoutExportToolStripMenuItem, Me.CheckoutCloneToolStripMenuItem, Me.CheckoutRemoveToolStripMenuItem, Me.CheckoutRemoveAllToolStripMenuItem})
        Me.CheckoutContextMenuStrip.Name = "CheckoutContextMenuStrip"
        Me.CheckoutContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CheckoutContextMenuStrip.Size = New System.Drawing.Size(135, 114)
        '
        'CheckoutImportToolStripMenuItem
        '
        Me.CheckoutImportToolStripMenuItem.Name = "CheckoutImportToolStripMenuItem"
        Me.CheckoutImportToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CheckoutImportToolStripMenuItem.Text = "Import"
        '
        'CheckoutExportToolStripMenuItem
        '
        Me.CheckoutExportToolStripMenuItem.Name = "CheckoutExportToolStripMenuItem"
        Me.CheckoutExportToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CheckoutExportToolStripMenuItem.Text = "Export"
        '
        'CheckoutCloneToolStripMenuItem
        '
        Me.CheckoutCloneToolStripMenuItem.Name = "CheckoutCloneToolStripMenuItem"
        Me.CheckoutCloneToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CheckoutCloneToolStripMenuItem.Text = "Clone"
        '
        'CheckoutRemoveToolStripMenuItem
        '
        Me.CheckoutRemoveToolStripMenuItem.Name = "CheckoutRemoveToolStripMenuItem"
        Me.CheckoutRemoveToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CheckoutRemoveToolStripMenuItem.Text = "Remove"
        '
        'CheckoutRemoveAllToolStripMenuItem
        '
        Me.CheckoutRemoveAllToolStripMenuItem.Name = "CheckoutRemoveAllToolStripMenuItem"
        Me.CheckoutRemoveAllToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CheckoutRemoveAllToolStripMenuItem.Text = "Remove All"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 761)
        Me.Controls.Add(Me.AutomaticUpdater)
        Me.Controls.Add(Me.BotOptionsGroup)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximumSize = New System.Drawing.Size(1300, 800)
        Me.MinimumSize = New System.Drawing.Size(1300, 800)
        Me.Name = "Main"
        Me.Text = "Affordable All-In-One Bot"
        Me.TabControl1.ResumeLayout(False)
        Me.AccountTab.ResumeLayout(False)
        Me.AccountManagementGroup.ResumeLayout(False)
        Me.AccountManagementGroup.PerformLayout()
        CType(Me.AccountData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CheckoutTab.ResumeLayout(False)
        Me.CheckoutManagementGroup.ResumeLayout(False)
        Me.CheckoutManagementGroup.PerformLayout()
        CType(Me.CheckoutData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogTab.ResumeLayout(False)
        Me.BotOptionsGroup.ResumeLayout(False)
        Me.BotOptionsGroup.PerformLayout()
        CType(Me.AutomaticUpdater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountContextMenuStrip.ResumeLayout(False)
        Me.CheckoutContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AccountTab As TabPage
    Friend WithEvents LogTab As TabPage
    Friend WithEvents LogRichBox As RichTextBox
    Friend WithEvents BotOptionsGroup As GroupBox
    Friend WithEvents CheckoutLink As LinkLabel
    Friend WithEvents MainStartButton As Button
    Friend WithEvents ProxyLink As LinkLabel
    Friend WithEvents MainStopButton As Button
    Friend WithEvents AccountData As DataGridView
    Friend WithEvents CartLink As LinkLabel
    Friend WithEvents AccountImportButton As Button
    Friend WithEvents AccountCloneButton As Button
    Friend WithEvents AccountRemoveButton As Button
    Friend WithEvents AccountExportButton As Button
    Friend WithEvents ImportFile As OpenFileDialog
    Friend WithEvents ExportFile As SaveFileDialog
    Friend WithEvents AccountLink As LinkLabel
    Friend WithEvents CheckoutTab As TabPage
    Friend WithEvents CheckoutData As DataGridView
    Friend WithEvents AccountManagementGroup As GroupBox
    Friend WithEvents CheckoutManagementGroup As GroupBox
    Friend WithEvents CheckoutCloneButton As Button
    Friend WithEvents CheckoutImportButton As Button
    Friend WithEvents CheckoutExportButton As Button
    Friend WithEvents CheckoutRemoveButton As Button
    Friend WithEvents AccountContextMenuStrip As ContextMenuStrip
    Friend WithEvents AccountRemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountCloneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountRemoveAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipsLink As LinkLabel
    Friend WithEvents CheckoutContextMenuStrip As ContextMenuStrip
    Friend WithEvents CheckoutRemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutCloneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutRemoveAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountEditAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountLinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountKeywordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountSiteToolStripMenuItem As ToolStripMenuItem
    Private WithEvents AutomaticUpdater As wyDay.Controls.AutomaticUpdater
    Friend WithEvents EmailA As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents MainSize As DataGridViewTextBoxColumn
    Friend WithEvents MainSite As DataGridViewTextBoxColumn
    Friend WithEvents Link As DataGridViewTextBoxColumn
    Friend WithEvents Keyword As DataGridViewTextBoxColumn
    Friend WithEvents Checkout As DataGridViewTextBoxColumn
    Friend WithEvents Proxy As DataGridViewTextBoxColumn
    Friend WithEvents Guest As DataGridViewTextBoxColumn
    Friend WithEvents NotificiationEmail As DataGridViewTextBoxColumn
    Friend WithEvents PhoneCarrier As DataGridViewTextBoxColumn
    Friend WithEvents NotificiationNumber As DataGridViewTextBoxColumn
    Friend WithEvents Profile As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents Address1 As DataGridViewTextBoxColumn
    Friend WithEvents Address2 As DataGridViewTextBoxColumn
    Friend WithEvents ZipCode As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents State As DataGridViewTextBoxColumn
    Friend WithEvents Country As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents EmailC As DataGridViewTextBoxColumn
    Friend WithEvents CardType As DataGridViewTextBoxColumn
    Friend WithEvents CardNumber As DataGridViewTextBoxColumn
    Friend WithEvents Month As DataGridViewTextBoxColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents CVV As DataGridViewTextBoxColumn
    Friend WithEvents AccountCountText As Label
    Friend WithEvents AccountCountLabel As Label
    Friend WithEvents CheckoutCountText As Label
    Friend WithEvents CheckoutCountLabel As Label
    Friend WithEvents AccounEditSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountSizeSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountSiteSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountLinkSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountKeywordSelectedToolStripMenuItem As ToolStripMenuItem
End Class
