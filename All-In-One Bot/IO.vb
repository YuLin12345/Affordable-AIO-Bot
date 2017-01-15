'@author Yu Lin
'Import and output handler, saves and loads .csv file.

Imports System.IO

Module IO

    'Account import.
    Public Sub AccountImport()
        Main.ImportFile.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        Main.ImportFile.FilterIndex = 1
        Main.ImportFile.RestoreDirectory = True

        If Main.ImportFile.ShowDialog() = DialogResult.OK Then

            Dim sr As StreamReader = New StreamReader(Main.ImportFile.OpenFile())

            While sr.Peek() <> -1
                row = sr.ReadLine()
                column = row.Split(","c)
                Main.AccountCountText.Text = Main.AccountCountText.Text + 1 'When account is imported, AccountCountText +1 for each account imported.
                Main.AccountData.Rows.Add(column)
            End While

            sr.Close()
        End If
    End Sub

    'Checkout import.
    Public Sub CheckoutImport()
        Main.ImportFile.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        Main.ImportFile.FilterIndex = 1
        Main.ImportFile.RestoreDirectory = True

        If Main.ImportFile.ShowDialog() = DialogResult.OK Then

            Dim sr As StreamReader = New StreamReader(Main.ImportFile.OpenFile())

            While sr.Peek() <> -1
                row = sr.ReadLine()
                column = row.Split(","c)
                Main.CheckoutCountText.Text = Main.CheckoutCountText.Text + 1   'When checkout is imported, CheckoutCountText +1 for each checkout imported.
                Main.CheckoutData.Rows.Add(column)
            End While

            sr.Close()
        End If
    End Sub

    'Account export.
    Public Sub AccountExport()
        Main.ExportFile.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        Main.ExportFile.FilterIndex = 1
        Main.ExportFile.RestoreDirectory = True

        If Main.ExportFile.ShowDialog() = DialogResult.OK Then

            Dim sw As StreamWriter = New StreamWriter(Main.ExportFile.OpenFile())

            If (sw IsNot Nothing) Then

                Dim column = (From columns As DataGridViewColumn In Main.AccountData.Columns.Cast(Of DataGridViewColumn)()
                              Select columns.HeaderText).ToArray
                Dim row = From rows As DataGridViewRow In Main.AccountData.Rows.Cast(Of DataGridViewRow)()
                          Where Not rows.IsNewRow
                          Select Array.ConvertAll(rows.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

                For Each swdata In row
                    sw.WriteLine(String.Join(",", swdata))
                Next

                sw.Close()
            End If
        End If
    End Sub

    'Checkout export.
    Public Sub CheckoutExport()
        Main.ExportFile.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        Main.ExportFile.FilterIndex = 1
        Main.ExportFile.RestoreDirectory = True

        If Main.ExportFile.ShowDialog() = DialogResult.OK Then

            Dim sw As StreamWriter = New StreamWriter(Main.ExportFile.OpenFile())

            If (sw IsNot Nothing) Then

                Dim column = (From columns As DataGridViewColumn In Main.CheckoutData.Columns.Cast(Of DataGridViewColumn)()
                              Select columns.HeaderText).ToArray
                Dim row = From rows As DataGridViewRow In Main.CheckoutData.Rows.Cast(Of DataGridViewRow)()
                          Where Not rows.IsNewRow
                          Select Array.ConvertAll(rows.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

                For Each swdata In row
                    sw.WriteLine(String.Join(",", swdata))
                Next

                sw.Close()
            End If
        End If
    End Sub

    'Load account.
    Public Sub LoadAccount()
        If Not System.IO.File.Exists("autosaveaccount.csv") Then
            System.IO.File.Create("autosaveaccount.csv").Dispose()
        Else

            Dim sr As StreamReader = New StreamReader("autosaveaccount.csv")

            While sr.Peek() <> -1
                row = sr.ReadLine()
                column = row.Split(","c)
                Main.AccountData.Rows.Add(column)
            End While

            sr.Close()
        End If

        'When accounts are loaded, loop through each and initialize the AccountCountText + 1.
        For Each EmailA As DataGridViewRow In Main.AccountData.Rows
            Main.AccountCountText.Text = Main.AccountCountText.Text + 1
        Next
    End Sub

    'Load checkout.
    Public Sub LoadCheckout()
        If Not System.IO.File.Exists("autosavecheckout.csv") Then
            System.IO.File.Create("autosavecheckout.csv").Dispose()
        Else

            Dim sr As StreamReader = New StreamReader("autosavecheckout.csv")

            While sr.Peek() <> -1
                row = sr.ReadLine()
                column = row.Split(","c)
                Main.CheckoutData.Rows.Add(column)
            End While

            sr.Close()
        End If

        'When checkouts are loaded, loop through each and initialize the CheckoutCountText + 1.
        For Each Profile As DataGridViewRow In Main.AccountData.Rows
            Main.CheckoutCountText.Text = Main.CheckoutCountText.Text + 1
        Next
    End Sub

    'Save account.
    Public Sub SaveAccount()
        If Not System.IO.File.Exists("autosaveaccount.csv") Then
            System.IO.File.Create("autosaveaccount.csv").Dispose()
        Else
            Dim sw As StreamWriter = New StreamWriter("autosaveaccount.csv")

            If (sw IsNot Nothing) Then

                Dim column = (From columns As DataGridViewColumn In Main.AccountData.Columns.Cast(Of DataGridViewColumn)()
                              Select columns.HeaderText).ToArray
                Dim row = From rows As DataGridViewRow In Main.AccountData.Rows.Cast(Of DataGridViewRow)()
                          Where Not rows.IsNewRow
                          Select Array.ConvertAll(rows.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

                For Each swdata In row
                    sw.WriteLine(String.Join(",", swdata))
                Next

                sw.Close()
            End If
        End If
    End Sub

    'Save checkout.
    Public Sub SaveCheckout()
        If Not System.IO.File.Exists("autosavecheckout.csv") Then
            System.IO.File.Create("autosavecheckout.csv").Dispose()
        Else
            Dim sw As StreamWriter = New StreamWriter("autosavecheckout.csv")

            If (sw IsNot Nothing) Then

                Dim column = (From columns As DataGridViewColumn In Main.CheckoutData.Columns.Cast(Of DataGridViewColumn)()
                              Select columns.HeaderText).ToArray
                Dim row = From rows As DataGridViewRow In Main.CheckoutData.Rows.Cast(Of DataGridViewRow)()
                          Where Not rows.IsNewRow
                          Select Array.ConvertAll(rows.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

                For Each swdata In row
                    sw.WriteLine(String.Join(",", swdata))
                Next

                sw.Close()
            End If
        End If
    End Sub

    'Load proxy.
    Public Sub LoadProxy()
        If Not System.IO.File.Exists("autosaveproxy.csv") Then
            System.IO.File.Create("autosaveproxy.csv").Dispose()
        Else
            Dim sr As StreamReader = New StreamReader("autosavecheckout.csv")

            If (File.ReadAllText("autosaveproxy.csv").Length = 0) Then
                ProxyForm.ProxyRichTextBox.Text = My.Settings.Proxy
            Else
                ProxyForm.ProxyRichTextBox.LoadFile("autosaveproxy.csv", RichTextBoxStreamType.PlainText)
                ProxyForm.ProxyRichTextBox.Lines = ProxyForm.ProxyRichTextBox.Text.Split(New Char() {ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
            End If
        End If
    End Sub

    'Save proxy.
    Public Sub SaveProxy()
        If Not System.IO.File.Exists("autosaveproxy.csv") Then
            System.IO.File.Create("autosaveproxy.csv").Dispose()
        Else
            ProxyForm.ProxyRichTextBox.SaveFile("autosaveproxy.csv", RichTextBoxStreamType.PlainText)
            ProxyForm.ProxyRichTextBox.Lines = ProxyForm.ProxyRichTextBox.Text.Split(New Char() {ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
        End If
    End Sub

    'Add account.
    Public Sub AddAccount()

        'Variables to get string from textBox.
        Dim EMail, Password, Size, Site, Link, Keyword, Profile, Guest, NotificationEMail, PhoneCarrier, NotificationNumber As String
        Dim Exist As Boolean = False

        EMail = AccountAddForm.EMailBox.Text
        Password = AccountAddForm.PasswordBox.Text
        Size = AccountAddForm.SizeBox.Text
        Site = AccountAddForm.SiteComboBox.Text
        Link = AccountAddForm.LinkBox.Text
        Keyword = AccountAddForm.KeywordBox.Text
        Profile = AccountAddForm.ProfileBox.Text
        Guest = AccountAddForm.GuestCheckBox.CheckState
        NotificationEMail = AccountAddForm.NotificationEMailBox.Text
        PhoneCarrier = AccountAddForm.PhoneCarrierComboBox.Text
        NotificationNumber = AccountAddForm.NotificationNumberBox.Text

        'Check if guest checkbox is enable or disable.
        If (Guest = 0) Then
            Guest = "Off"

            'Check if profile name already exists.
            For Each ProfileRow As DataGridViewRow In Main.CheckoutData.Rows
                If (ProfileRow.Cells("Profile").Value = AccountAddForm.ProfileBox.Text) Then
                    Exist = True
                End If
            Next

            'Use to debug the output.
            'Console.WriteLine("EMail: " + EMail + " Password: " + Password + " Size: " + Size + " Site: " + Site + " Link: " + Link + " Keyword: " + Keyword + " Profile: " + Profile + " Guest: " + Guest + " Notification EMail: " + NotificationEMail + " Phone Carrier: " + PhoneCarrier + " Notification Number: " + NotificationNumber)

            'Check if the following boxes are filled out.
            If (EMail = "" Or Password = "" Or Size = "" Or Site = "") Then
                MsgBox("Please make sure boxes with * are filled out.")
            ElseIf (Not EMail.Contains("@")) Then
                MsgBox("Not a valid E-Mail. It does not contain @.")
            ElseIf ((Not Link = "") And (Not Link.Contains("http://") And Not Link.Contains("https://"))) Then
                MsgBox("Not a valid Link. It does not start with http:// or https://.")
            ElseIf ((Not Profile = "") And (Exist = False)) Then
                MsgBox("Profile does not exist.")
            Else
                Main.AccountCountText.Text = Main.AccountCountText.Text + 1 'When a new account is added AccountCountText + 1.
                Main.AccountData.Rows.Add(New String() {EMail, Password, Size, Site, Link, Keyword, Profile, "", Guest, NotificationEMail, PhoneCarrier, NotificationNumber})   'Add the entered data into Main Form Account Data (DataGridView).
                AccountAddForm.Close()
            End If
        Else
            Guest = "On"

            'Check if profile name already exists.
            For Each ProfileRow As DataGridViewRow In Main.CheckoutData.Rows
                If (ProfileRow.Cells("Profile").Value = AccountAddForm.ProfileBox.Text) Then
                    Exist = True
                End If
            Next

            'Use to debug the output.
            'Console.WriteLine("EMail: " + EMail + " Size: " + Size + " Site: " + Site + " Link: " + Link + " Keyword: " + Keyword + " Profile: " + Profile + " Guest: " + Guest + " Notification EMail: " + NotificationEMail + " Phone Carrier: " + PhoneCarrier + " Notification Number: " + NotificationNumber)

            'Check if the following boxes are filled out.
            If (EMail = "" Or Size = "" Or Site = "") Then
                MsgBox("Please make sure boxes with * are filled out.")
            ElseIf (Not EMail.Contains("@")) Then
                MsgBox("Not a valid E-Mail. It does not contain @.")
            ElseIf ((Not Link = "") And (Not Link.Contains("http://") And Not Link.Contains("https://"))) Then
                MsgBox("Not a valid Link. It does not start with http:// or https://.")
            ElseIf ((Not Profile = "") And (Exist = False)) Then
                MsgBox("Profile does not exist.")
            Else
                Main.AccountCountText.Text = Main.AccountCountText.Text + 1 'When a new account is added AccountCountText + 1.
                Main.AccountData.Rows.Add(New String() {EMail, "", Size, Site, Link, Keyword, Profile, "", Guest, NotificationEMail, PhoneCarrier, NotificationNumber}) 'Add the entered data into Main Form Account Data (DataGridView).
                AccountAddForm.Close()
            End If
        End If
    End Sub

    'Add checkout profile.
    Public Sub AddCheckout()

        'Variables to get String from TextBox.
        Dim Profile, FirstName, LastName, Address1, Address2, ZipCode, City, USState, Country, Phone, Email, CardType, CardNumber, Month, Year, CVV As String
        Dim exist As Boolean = False

        Profile = CheckoutAddForm.ProfileBox.Text
        FirstName = CheckoutAddForm.FirstNameBox.Text
        LastName = CheckoutAddForm.LastNameBox.Text
        Address1 = CheckoutAddForm.Address1Box.Text
        Address2 = CheckoutAddForm.Address2Box.Text
        ZipCode = CheckoutAddForm.ZipCodeBox.Text
        City = CheckoutAddForm.CityBox.Text
        USState = CheckoutAddForm.USStateComboBox.Text
        Country = CheckoutAddForm.CountryComboBox.Text
        Phone = CheckoutAddForm.PhoneBox.Text
        Email = CheckoutAddForm.EmailBox.Text
        CardType = CheckoutAddForm.CardTypeComboBox.Text
        CardNumber = CheckoutAddForm.CardNumberBox.Text
        Month = CheckoutAddForm.MonthComboBox.Text
        Year = CheckoutAddForm.YearComboBox.Text
        CVV = CheckoutAddForm.CVVBox.Text

        'Check if profile name already exists.
        For Each ProfileRow As DataGridViewRow In Main.CheckoutData.Rows
            If ProfileRow.Cells("Profile").Value = CheckoutAddForm.ProfileBox.Text Then
                exist = True
            End If
        Next

        'Use to debug the output.
        'Console.WriteLine("Profile: " + Profile + " First Name: " + FirstName + " Last Name: " + LastName + " Address 1: " + Address1 + " Address 2: " + Address2 + " Zip Code: " + ZipCode + " City: " + City + " State: " + USState + " Country: " + Country + " Phone: " + Phone + " Email: " + Email + " Card Type: " + CardType + " Card Number: " + CardNumber + " Month: " + Month + " Year: " + Year + " CVV: " + CVV)

        'Check if the following boxes are filled out.
        If (Profile = "" Or FirstName = "" Or LastName = "" Or Address1 = "" Or ZipCode = "" Or City = "" Or USState = "" Or Country = "" Or Phone = "" Or Email = "" Or CardType = "" Or CardNumber = "" Or Month = "" Or Year = "" Or CVV = "") Then
            MsgBox("Please make sure boxes with * are filled out.")
        ElseIf (exist = True) Then
            MsgBox("Profile Name already exist.")
        ElseIf ((Not Email.Contains("@"))) Then
            MsgBox("Not a valid E-Mail. It does not contain @.")
        ElseIf ((CardType.Equals("American Express")) And (CheckoutAddForm.CVVBox.Text.Length < 4)) Then
            MsgBox("American Express Card has four digit CVV.")
        ElseIf ((CardType.Equals("Discover")) And (CheckoutAddForm.CVVBox.Text.Length < 3)) Then
            MsgBox("Discover Card has three digit CVV.")
        ElseIf ((CardType.Equals("Mastercard")) And (CheckoutAddForm.CVVBox.Text.Length < 3)) Then
            MsgBox("Master Card has three digit CVV.")
        ElseIf ((CardType.Equals("Visa")) And (CheckoutAddForm.CVVBox.Text.Length < 3)) Then
            MsgBox("Visa Card has three digit CVV.")
        Else
            Main.CheckoutCountText.Text = Main.CheckoutCountText.Text + 1 'When a new checkout is added CheckoutCountText + 1.
            Main.CheckoutData.Rows.Add(New String() {Profile, FirstName, LastName, Address1, Address2, ZipCode, City, USState, Country, Phone, Email, CardType, CardNumber, Month, Year, CVV})  'Add the entered data into Main Form Checkout Data (DataGridView).
            CheckoutAddForm.Close()
        End If
    End Sub

    Public Sub Start()
        Dim EMail, Password, Size, Site, Link, Keyword, Profile, Proxy, Guest, NotificationEMail, PhoneCarrier, NotificationNumber, FirstName, LastName, Address1, Address2, ZipCode, City, USState, Country, Phone, CardType, CardNumber, Month, Year, CVV As String
        EMail = ""
        Password = ""
        Size = ""
        Site = ""
        Link = ""
        Keyword = ""
        Profile = ""
        Proxy = ""
        Guest = ""
        NotificationEMail = ""
        PhoneCarrier = ""
        NotificationNumber = ""
        FirstName = ""
        LastName = ""
        Address1 = ""
        Address2 = ""
        ZipCode = ""
        City = ""
        USState = ""
        Country = ""
        Phone = ""
        CardType = ""
        CardNumber = ""
        Month = ""
        Year = ""
        CVV = ""

        For Each accountRow As DataGridViewRow In Main.AccountData.Rows
            EMail = accountRow.Cells(0).Value
            Password = accountRow.Cells(1).Value
            Size = accountRow.Cells(2).Value
            Site = accountRow.Cells(3).Value
            Link = accountRow.Cells(4).Value
            Keyword = accountRow.Cells(5).Value
            Profile = accountRow.Cells(6).Value
            Guest = accountRow.Cells(8).Value
            NotificationEMail = accountRow.Cells(9).Value
            PhoneCarrier = accountRow.Cells(10).Value
            NotificationNumber = accountRow.Cells(11).Value

            For Each checkoutRow As DataGridViewRow In Main.CheckoutData.Rows
                If (Profile.Contains(checkoutRow.Cells("Profile").Value)) Then

                    FirstName = checkoutRow.Cells(1).Value
                    LastName = checkoutRow.Cells(2).Value
                    Address1 = checkoutRow.Cells(3).Value
                    Address2 = checkoutRow.Cells(4).Value
                    ZipCode = checkoutRow.Cells(5).Value
                    City = checkoutRow.Cells(6).Value
                    USState = checkoutRow.Cells(7).Value
                    Country = checkoutRow.Cells(8).Value
                    Phone = checkoutRow.Cells(9).Value
                    CardType = checkoutRow.Cells(10).Value
                    CardNumber = checkoutRow.Cells(11).Value
                    Month = checkoutRow.Cells(12).Value
                    Year = checkoutRow.Cells(13).Value
                    CVV = checkoutRow.Cells(14).Value
                End If
            Next

            'Use to debug the output.
            'Console.WriteLine(EMail + " " + Password + " " + Size + " " + Site + " " + Link + " " + Keyword + " " + Profile + " " + Proxy + " " + Guest + " " + NotificationEMail + " " + PhoneCarrier + " " + NotificationNumber + " " + FirstName + " " + LastName + " " + Address1 + " " + Address2 + " " + ZipCode + " " + City + " " + USState + " " + Country + " " + Phone + " " + CardType + " " + CardNumber + " " + Month + " " + Year + " " + CVV)
        Next
    End Sub

    Dim Index As Integer = 0
    Dim column() As String
    Dim row As String
End Module