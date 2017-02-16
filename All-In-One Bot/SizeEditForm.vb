'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'Size edit form, use to change the size.

Public Class SizeEditForm

    Private Sub SizeEditFormOkayButton_Click(sender As Object, e As EventArgs) Handles SizeEditFormOkayButton.Click
        For Each sizeRow As DataGridViewRow In Main.AccountData.Rows
            sizeRow.Cells("MainSize").Value = SizeEditBox.Text
        Next

        'For debug, to check the value.
        'Console.WriteLine(SizeEditBox.Text)

        Me.Close()
    End Sub

    Private Sub SizeEditFormCancelButton_Click(sender As Object, e As EventArgs) Handles SizeEditFormCancelButton.Click
        Me.Close()
    End Sub

    Private Sub SizeEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class