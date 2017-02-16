'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'Keyword edit selected form, use to change selected keyword.

Public Class KeywordEditSelectedForm

    Private Sub KeywordEditSelectedFormOkayButton_Click(sender As Object, e As EventArgs) Handles KeywordEditSelectedFormOkayButton.Click
        For Each keywordRow As DataGridViewRow In Main.AccountData.SelectedRows
            keywordRow.Cells("Keyword").Value = KeywordEditSelectedBox.Text
        Next

        'For debug, to check the value.
        'Console.WriteLine(KeywordEditSelectedBox.Text)

        Me.Close()
    End Sub

    Private Sub KeywordEditSelectedFormCancelButton_Click(sender As Object, e As EventArgs) Handles KeywordEditSelectedFormCancelButton.Click
        Me.Close()
    End Sub

    Private Sub KeywordEditSelectedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class