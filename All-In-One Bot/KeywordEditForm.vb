'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'Keyword edit form, use to change the keyword.

Public Class KeywordEditForm

    Private Sub KeywordEditFormOkayButton_Click(sender As Object, e As EventArgs) Handles KeywordEditFormOkayButton.Click
        For Each KeywordRow As DataGridViewRow In Main.AccountData.Rows
            KeywordRow.Cells("Keyword").Value = KeywordEditBox.Text
        Next

        'For debug, to check the value.
        'Console.WriteLine(KeywordEditBox.Text)

        Me.Close()
    End Sub

    Private Sub KeywordEditFormCancelButton_Click(sender As Object, e As EventArgs) Handles KeywordEditFormCancelButton.Click
        Me.Close()
    End Sub

    Private Sub KeywordEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class