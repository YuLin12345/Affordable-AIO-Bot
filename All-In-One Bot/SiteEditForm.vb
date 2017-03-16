'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'Site edit form, use to change the site.

Public Class SiteEditForm

    Private Sub SiteEditFormOkayButton_Click(sender As Object, e As EventArgs) Handles SiteEditFormOkayButton.Click
        For Each SiteRow As DataGridViewRow In Main.AccountData.Rows
            SiteRow.Cells("MainSite").Value = SiteEditComboBox.Text
        Next

        'For debug, to check the value.
        'Console.WriteLine(SiteEditComboBox.Text)

        Me.Close()
    End Sub

    Private Sub SiteEditFormCancelButton_Click(sender As Object, e As EventArgs) Handles SiteEditFormCancelButton.Click
        Me.Close()
    End Sub

    Private Sub SiteEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiteEditComboBox.DataSource = My.Settings.Site
    End Sub
End Class