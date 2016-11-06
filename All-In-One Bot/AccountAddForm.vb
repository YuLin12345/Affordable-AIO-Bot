'@author Yu Lin
'This is form will add/save account information into the Main Form account datagridview.

Public Class AccountAddForm

    'If save button is clicked, will insert the information into Main Form account datagridview.
    Private Sub AccountAddSaveButton_Click(sender As Object, e As EventArgs) Handles AccountAddSaveButton.Click
        AddAccount()
    End Sub

    'If cancel button is clicked, form closes.
    Private Sub AccountAddCancelButton_Click(sender As Object, e As EventArgs) Handles AccountAddCancelButton.Click
        Me.Close()
    End Sub

    'If checked, disable password text box.
    Private Sub GuestCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles GuestCheckBox.CheckedChanged
        If GuestCheckBox.Checked = True Then
            PasswordBox.Enabled = False
        Else
            GuestCheckBox.Enabled = True
        End If
    End Sub

    'Account add form will load anything below.
    Private Sub AccountAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiteComboBox.DataSource = My.Settings.Site
        PhoneCarrierComboBox.DataSource = My.Settings.PhoneCarrier

        ToolTip.SetToolTip(EMailBox, "Type account username / e-mail")
        ToolTip.SetToolTip(PasswordBox, "Type account password")
        ToolTip.SetToolTip(SizeBox, "Type Size")
        ToolTip.SetToolTip(SiteComboBox, "Select site")
        ToolTip.SetToolTip(LinkBox, "Type full link with Http:// or Https://")
        ToolTip.SetToolTip(KeywordBox, "Type keyword for monitoring")
        ToolTip.SetToolTip(ProfileBox, "Type checkout profile name")
        ToolTip.SetToolTip(NotificationEMailBox, "Type e-mail to be notified")
        ToolTip.SetToolTip(PhoneCarrierComboBox, "Select phone carrier to be able to receive text / sms")
        ToolTip.SetToolTip(NotificationNumberBox, "Type phone number to be text / sms notified")
        ToolTip.SetToolTip(GuestCheckBox, "Check if you want to use guest checkout")
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class