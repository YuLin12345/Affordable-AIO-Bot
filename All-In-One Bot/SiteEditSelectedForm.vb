'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'Site edit selected form, use to change selected site.

Public Class SiteEditSelectedForm

    Private Sub SiteEditSelectedFormOkayButton_Click(sender As Object, e As EventArgs) Handles SiteEditSelectedFormOkayButton.Click
        For Each siteRow As DataGridViewRow In Main.AccountData.SelectedRows
            siteRow.Cells("MainSite").Value = SiteEditSelectedComboBox.Text
        Next

        'For debug, to check the value.
        'Console.WriteLine(SiteEditSelectedComboBox.Text)

        Me.Close()
    End Sub

    Private Sub SiteEditSelectedFormCancelButton_Click(sender As Object, e As EventArgs) Handles SiteEditSelectedFormCancelButton.Click
        Me.Close()
    End Sub

    Private Sub SiteEditSelectedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiteEditSelectedComboBox.DataSource = My.Settings.Site
    End Sub
End Class