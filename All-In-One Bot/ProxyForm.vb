'@author Yu Lin
'This form will test proxies agaisnt sites to see if they are banned. If it is working save them.

Public Class ProxyForm

    'Clear ProxyRichTextBox when double left-clicked.
    Private Sub ProxyRichTextBox_Click(sender As Object, e As EventArgs) Handles ProxyRichTextBox.DoubleClick
        ProxyRichTextBox.Clear()
    End Sub

    'If save button clicked, check and save into autosaveproxy.csv.
    Private Sub ProxyFormSaveButton_Click(sender As Object, e As EventArgs) Handles ProxyFormSaveButton.Click
        SaveProxy()
        Me.Close()
    End Sub

    'If cancel button clicked, close this form.
    Private Sub ProxyFormCancelBox_Click(sender As Object, e As EventArgs) Handles ProxyFormCancelBox.Click
        Me.Close()
    End Sub

    'If proxy test button clicked, test proxies.
    Private Sub ProxyFormTestButton_Click(sender As Object, e As EventArgs) Handles ProxyFormTestButton.Click
        MsgBox("Under development.")
    End Sub

    'Auto load autosaveproxy.csv on to the richtextbox.
    Private Sub ProxyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProxy()
    End Sub
End Class