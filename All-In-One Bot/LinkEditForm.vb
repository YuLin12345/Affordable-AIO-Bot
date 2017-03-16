'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'Link edit form, use to change the link.

Public Class LinkEditForm

    Private Sub LinkEditFormOkayButton_Click(sender As Object, e As EventArgs) Handles LinkEditFormOkayButton.Click
        Dim Link As String
        Link = LinkEditBox.Text

        If (Not Link.Contains("http://") And Not Link.Contains("https://")) Then
            MsgBox("Not a valid Link. It does not start with http:// or https://.")
        Else
            For Each LinkRow As DataGridViewRow In Main.AccountData.Rows
                LinkRow.Cells("Link").Value = LinkEditBox.Text
            Next
        End If

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