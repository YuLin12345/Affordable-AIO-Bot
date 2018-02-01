'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'This is form will display .txt file from the backend onto the richtextbox.

Public Class TipsForm

    'Auto load text from the link onto the richtextbox.
    Private Sub TipsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using client As New Net.WebClient

            'Link decrypted to provide a bit of security.
            Dim tipsResult As String = client.DownloadString(Crypt.Decrypt("cFT.eBqtN0Hk\k;w\EHgdEXfcU;gd1Ssf0Xge0n.\Q;@\k\tekTf[kzjKCHHVwDAd1StW07j[UvjeiLtfDTneFOselTk"))

            TipsRichTextBox.Text = tipsResult
        End Using
    End Sub
End Class