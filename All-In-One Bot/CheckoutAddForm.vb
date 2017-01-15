'@author Yu Lin
'This form will add/save account information into the Main Form checkout datagridview.

Public Class CheckoutAddForm

    'If save button is clicked, will insert the information into Main Form checkout datagridview.
    Private Sub CheckoutAddSaveButton_Click(sender As Object, e As EventArgs) Handles CheckoutAddSaveButton.Click
        AddCheckout()
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

        ToolTip.SetToolTip(ProfileBox, "Type checkout profile name.")
        ToolTip.SetToolTip(FirstNameBox, "Type first name.")
        ToolTip.SetToolTip(LastNameBox, "Type last name.")
        ToolTip.SetToolTip(Address1Box, "Type address 1, street number, street name, and apartment/unit number.")
        ToolTip.SetToolTip(Address2Box, "Type address 2, apartment/unit number. If address 1 does not fit everything.")
        ToolTip.SetToolTip(ZipCodeBox, "Type zip code.")
        ToolTip.SetToolTip(CityBox, "Type city.")
        ToolTip.SetToolTip(USStateComboBox, "Select US state. If INTERNATIONAL select NONE.")
        ToolTip.SetToolTip(CountryComboBox, "Select country.")
        ToolTip.SetToolTip(PhoneBox, "Type phone number.")
        ToolTip.SetToolTip(EmailBox, "Type email.")
        ToolTip.SetToolTip(CardTypeComboBox, "Select card type.")
        ToolTip.SetToolTip(CardNumberBox, "Type card number.")
        ToolTip.SetToolTip(MonthComboBox, "Select month of the card's expiration date.")
        ToolTip.SetToolTip(YearComboBox, "Select year of the card's expiration date.")
        ToolTip.SetToolTip(CVVBox, "Type card CVV.")
    End Sub
End Class