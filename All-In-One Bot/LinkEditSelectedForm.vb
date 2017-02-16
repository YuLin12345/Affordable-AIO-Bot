'@author Yu Lin
'Link edit selected form, use to change selected link.

Public Class LinkEditSelectedForm

    Private Sub LinkEditSelectedFormOkayButton_Click(sender As Object, e As EventArgs) Handles LinkEditSelectedFormOkayButton.Click
        Dim Link As String
        Link = LinkEditSelectedBox.Text

        If (Not Link.Contains("http://") And Not Link.Contains("https://")) Then
            MsgBox("Not a valid Link. It does not start with http:// or https://.")
        Else
            For Each linkRow As DataGridViewRow In Main.AccountData.SelectedRows
                linkRow.Cells("Link").Value = LinkEditSelectedBox.Text
            Next
        End If

        'For debug, to check the value.
        'Console.WriteLine(LinkEditSelectedBox.Text)

        Me.Close()
    End Sub

    Private Sub LinkEditSelectedFormCancelButton_Click(sender As Object, e As EventArgs) Handles LinkEditSelectedFormCancelButton.Click
        Me.Close()
    End Sub

    Private Sub LinkEditSelectedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class