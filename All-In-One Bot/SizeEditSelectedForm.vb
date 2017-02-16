'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'Size edit selected form, use to change selected sizes.

Public Class SizeEditSelectedForm

    Private Sub SizeEditSelectedFormOkayButton_Click(sender As Object, e As EventArgs) Handles SizeEditSelectedFormOkayButton.Click
        For Each sizeRow As DataGridViewRow In Main.AccountData.SelectedRows
            sizeRow.Cells("MainSize").Value = SizeEditSelectedBox.Text
        Next

        'For debug, to check the value.
        'Console.WriteLine(SizeEditSelectedBox.Text)

        Me.Close()
    End Sub

    Private Sub SizeEditSelectedFormCancelButton_Click(sender As Object, e As EventArgs) Handles SizeEditSelectedFormCancelButton.Click
        Me.Close()
    End Sub

    Private Sub SizeEditSelectedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class