'@author Yu Lin
'This form will add/save account information into the Main Form checkout datagridview.

Public Class CheckoutAddForm

    'If save button is clicked, will insert the information into Main Form checkout datagridview.
    Private Sub CheckoutAddSaveButton_Click(sender As Object, e As EventArgs) Handles CheckoutAddSaveButton.Click

        'Variables to get String from TextBox.
        Dim Profile, FirstName, LastName, Address1, Address2, ZipCode, City, USState, Country, Phone, CardType, CardNumber, Month, Year, CVV As String
        Dim exist As Boolean = False

        Profile = ProfileBox.Text
        FirstName = FirstNameBox.Text
        LastName = LastNameBox.Text
        Address1 = Address1Box.Text
        Address2 = Address2Box.Text
        ZipCode = ZipCodeBox.Text
        City = CityBox.Text
        USState = USStateComboBox.Text
        Country = CountryComboBox.Text
        Phone = PhoneBox.Text
        CardType = CardTypeComboBox.Text
        CardNumber = CardNumberBox.Text
        Month = MonthComboBox.Text
        Year = YearComboBox.Text
        CVV = CVVBox.Text

        'Check if profile name already exists.
        For Each ProfileRow As DataGridViewRow In Main.CheckoutData.Rows
            If ProfileRow.Cells("Profile").Value = ProfileBox.Text Then
                exist = True
            End If
        Next

        'Use to debug the output.
        'Console.WriteLine("Profile: " + Profile + " First Name: " + FirstName + " Last Name: " + LastName + " Address 1: " + Address1 + " Address 2: " + Address2 + " Zip Code: " + ZipCode + " City: " + City + " State: " + USState + " Country: " + Country + " Phone: " + Phone + " Card Type: " + CardType + " Card Number: " + CardNumber + " Month: " + Month + " Year: " + Year + " CVV: " + CVV)

        'Check if the following boxes are filled out.
        If (Profile = "" Or FirstName = "" Or LastName = "" Or Address1 = "" Or ZipCode = "" Or City = "" Or USState = "" Or Country = "" Or Phone = "" Or CardType = "" Or CardNumber = "" Or Month = "" Or Year = "" Or CVV = "") Then
            MsgBox("Please make sure boxes with * are filled out.")
        ElseIf (exist = True)
            MsgBox("Profile Name already exist.")
        ElseIf ((CardType.Equals("American Express")) And (CVVBox.Text.Length < 4)) Then
            MsgBox("American Express Card has four digit CVV.")
        ElseIf ((CardType.Equals("Discover")) And (CVVBox.Text.Length < 3)) Then
            MsgBox("Discover Card has three digit CVV.")
        ElseIf ((CardType.Equals("Mastercard")) And (CVVBox.Text.Length < 3)) Then
            MsgBox("Master Card has three digit CVV.")
        ElseIf ((CardType.Equals("Visa")) And (CVVBox.Text.Length < 3)) Then
            MsgBox("Visa Card has three digit CVV.")
        Else
            Main.CheckoutData.Rows.Add(New String() {Profile, FirstName, LastName, Address1, Address2, ZipCode, City, USState, Country, Phone, CardType, CardNumber, Month, Year, CVV})
            Me.Close()
        End If
    End Sub

    'If cancel button is clicked, form closes.
    Private Sub CheckoutAddCancelButton_Click(sender As Object, e As EventArgs) Handles CheckoutAddCancelButton.Click
        Me.Close()
    End Sub

    'Checkout add form will load anything below.
    Private Sub CheckoutAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountryComboBox.DataSource = My.Settings.Country
        USStateComboBox.DataSource = My.Settings.USState
        CardTypeComboBox.DataSource = My.Settings.CardType
        MonthComboBox.DataSource = My.Settings.Month
        YearComboBox.DataSource = My.Settings.Year

        ToolTip.SetToolTip(ProfileBox, "Type checkout profile name")
        ToolTip.SetToolTip(FirstNameBox, "Type first name")
        ToolTip.SetToolTip(LastNameBox, "Type last name")
        ToolTip.SetToolTip(Address1Box, "Type address 1, street number, and street name")
        ToolTip.SetToolTip(Address2Box, "Type address 2, put apt / unit")
        ToolTip.SetToolTip(ZipCodeBox, "Type zip code")
        ToolTip.SetToolTip(CityBox, "Type city")
        ToolTip.SetToolTip(USStateComboBox, "Select US state")
        ToolTip.SetToolTip(CountryComboBox, "Select country")
        ToolTip.SetToolTip(PhoneBox, "Type phone number")
        ToolTip.SetToolTip(CardTypeComboBox, "Select card type")
        ToolTip.SetToolTip(CardNumberBox, "Type card number")
        ToolTip.SetToolTip(MonthComboBox, "Select month of the card's expiration date")
        ToolTip.SetToolTip(YearComboBox, "Select year of the card's expiration date")
        ToolTip.SetToolTip(CVVBox, "Type card CVV")
    End Sub
End Class