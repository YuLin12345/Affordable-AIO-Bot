'@author Yu Lin
'This is form will display .txt file from the backend onto the richtextbox.

Public Class TipsForm

    'Auto load text from the link onto the richtextbox.
    Private Sub TipsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using client As New Net.WebClient

            'Link decrypted to provide a bit of security.
            Dim tipsResult As String = client.DownloadString(Crypt.Decrypt("cFT.eBqtN1f1fw7.cEXfgk7x\Uzq\VKs[0;rN/Ps\UHp\VLAd1TScVDxNlL.\e?;"))

            TipsRichTextBox.Text = tipsResult
        End Using
    End Sub
End Class