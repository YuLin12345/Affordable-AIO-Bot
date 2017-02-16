'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'This form will test proxies agaisnt sites to see if they are banned. If it is working save them.

Public Class ProxyForm

    'Test proxy from ProxyRichTextBox and enter it into the ProxyDataGrid.
    Public Sub TestProxy()
        ProxyData.Rows.Clear()  'Clear the ProxyDataGrid, remove every row.
        ProxyCountText.Text = 0 'Initialize ProxyCountText back to 0 after remove.

        'Take proxies (IP:PORT:USERNAME:PASSWORD) and parse it into the ProxyDataGrid.
        For Each line In ProxyRichTextBox.Lines
            ProxyCountText.Text = ProxyCountText.Text + 1   '+1 for every proxy added to update the ProxyCounter.

            Dim split As String()
            split = line.Split(":"c)

            Console.WriteLine(split.ToString)

            'Me.ProxyData.Rows.Add(split)

        Next
    End Sub

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
        TestProxy()
    End Sub

    'Auto load autosaveproxy.csv on to the richtextbox.
    Private Sub ProxyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProxy()
        ProxyCheckComboBox.DataSource = My.Settings.Site
    End Sub
End Class