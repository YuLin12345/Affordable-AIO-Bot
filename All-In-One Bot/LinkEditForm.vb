'@author Yu Lin
'Link edit form, use to change the link.

Public Class LinkEditForm

    Private Sub LinkEditFormOkayButton_Click(sender As Object, e As EventArgs) Handles LinkEditFormOkayButton.Click
        For Each LinkRow As DataGridViewRow In Main.AccountData.Rows
            LinkRow.Cells("Link").Value = LinkEditBox.Text
        Next

        'For debug, to check the value.
        'Console.WriteLine(LinkEditBox.Text)

        Me.Close()
    End Sub

    Private Sub LinkEditFormCancelButton_Click(sender As Object, e As EventArgs) Handles LinkEditFormCancelButton.Click
        Me.Close()
    End Sub

    Private Sub LinkEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class