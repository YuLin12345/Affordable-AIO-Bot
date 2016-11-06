'@author Yu Lin
'Main Form, where the magic happens.

Public Class Main

    'Account tab right-click.
    Private Sub AccountData_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles AccountData.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            AccountData.Rows(e.RowIndex).Selected = True
            AccountContextMenuStrip.Show(AccountData, AccountData.PointToClient(Cursor.Position))
        End If
    End Sub

    'Checkout tab right-click.
    Private Sub CheckoutData_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CheckoutData.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CheckoutData.Rows(e.RowIndex).Selected = True
            CheckoutContextMenuStrip.Show(CheckoutData, CheckoutData.PointToClient(Cursor.Position))
        End If
    End Sub

    'If checkoutLink is clicked, open checkout add form.
    Private Sub CheckoutLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CheckoutLink.LinkClicked
        CheckoutAddForm.Show()
    End Sub

    'If accountLink is clicked, open account add form.
    Private Sub AccountLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AccountLink.LinkClicked
        AccountAddForm.Show()
    End Sub

    'If cartLink is clicked, open cart form.
    Private Sub CartLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CartLink.LinkClicked
        CartForm.Show()
    End Sub

    'If proxyLink is clicked, open proxy form.
    Private Sub ProxyLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProxyLink.LinkClicked
        ProxyForm.Show()
    End Sub

    'If tipsLink is clicked, open tips form.
    Private Sub TipsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TipsLink.LinkClicked
        TipsForm.Show()
    End Sub

    'If account remove button is clicked, selected row will be deleted on the account tab.
    Private Sub AccountRemoveButton_Click(sender As Object, e As EventArgs) Handles AccountRemoveButton.Click
        AccountRemove()
    End Sub

    'If account clone button is clicked, selected row will be cloned on the account tab.
    Private Sub AccountCloneButton_Click(sender As Object, e As EventArgs) Handles AccountCloneButton.Click
        AccountClone()
    End Sub

    'If account import button is clicked, import accounts into account datagridview.
    Private Sub AccountImportButton_Click(sender As Object, e As EventArgs) Handles AccountImportButton.Click
        AccountImport()
    End Sub

    'If account export button is clicked, export accounts into account datagridview.
    Private Sub AccountExportButton_Click(sender As Object, e As EventArgs) Handles AccountExportButton.Click
        AccountExport()
    End Sub

    'If checkout remove button is clicked, selected row will be deleted on the checkout tab.
    Private Sub CheckoutRemoveButton_Click(sender As Object, e As EventArgs) Handles CheckoutRemoveButton.Click
        CheckoutRemove()
    End Sub

    'If checkout clone button is clicked, selected row will be cloned on the checkout tab.
    Private Sub CheckoutCloneButton_Click(sender As Object, e As EventArgs) Handles CheckoutCloneButton.Click
        CheckoutClone()
    End Sub

    'If checkout import button is clicked, import checkouts into checkout datagridview.
    Private Sub CheckoutImportButtonButton_Click(sender As Object, e As EventArgs) Handles CheckoutImportButton.Click
        CheckoutImport()
    End Sub

    'If checkout export button is clicked, export checkouts into checkout datagridview.
    Private Sub CheckoutExportButton_Click(sender As Object, e As EventArgs) Handles CheckoutExportButton.Click
        CheckoutExport()
    End Sub

    'Account tab contextMenuStrip right-click remove.
    Private Sub AccountRemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountRemoveToolStripMenuItem.Click
        AccountRemove()
    End Sub

    'Account tab contextMenuStrip right-click clone.
    Private Sub AccountCloneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountCloneToolStripMenuItem.Click
        AccountClone()
    End Sub

    'Account tab contextMenuStrip right-click import.
    Private Sub AccountImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountImportToolStripMenuItem.Click
        AccountImport()
    End Sub

    'Account tab contextMenuStrip right-click export.
    Private Sub AccountExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountExportToolStripMenuItem.Click
        AccountExport()
    End Sub

    'Account tab contextMenuStrip right-click remove all.
    Private Sub AccountRemoveAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountRemoveAllToolStripMenuItem.Click
        AccountRemoveAll()
    End Sub

    'Checkout tab contextMenuStrip right-click remove.
    Private Sub CheckoutRemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutRemoveToolStripMenuItem.Click
        CheckoutRemove()
    End Sub

    'Checkout tab contextMenuStrip right-click clone.
    Private Sub CheckoutCloneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutCloneToolStripMenuItem.Click
        CheckoutClone()
    End Sub

    'Checkout tab contextMenuStrip right-click import.
    Private Sub CheckoutImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutImportToolStripMenuItem.Click
        CheckoutImport()
    End Sub

    'Checkout tab contextMenuStrip right-click export.
    Private Sub CheckoutExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutExportToolStripMenuItem.Click
        CheckoutExport()
    End Sub

    'Checkout tab contextMenuStrip right-click remove all.
    Private Sub CheckoutRemoveAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutRemoveAllToolStripMenuItem.Click
        CheckoutRemoveAll()
    End Sub

    'Account tab contextMenuStrip right-click edit size.
    Private Sub AccountSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountSizeToolStripMenuItem.Click
        EditSize()
    End Sub

    'Account tab contextMenuStrip right-click edit site.
    Private Sub AccountSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountSiteToolStripMenuItem.Click
        EditSite()
    End Sub

    'Account tab contextMenuStrip right-click edit link.
    Private Sub AccountLinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountLinkToolStripMenuItem.Click
        EditLink()
    End Sub

    'Account tab contextMenuStrip right-click edit keyword.
    Private Sub AccountKeywordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountKeywordToolStripMenuItem.Click
        EditKeyword()
    End Sub

    'Auto load autosaveaccount.csv and autosavecheckout.csv onto the datagridview.
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutomaticUpdater.ForceCheckForUpdate()  'Checks for updates. Wybuild.
        LoadAccount()
        LoadCheckout()
    End Sub

    'Auto save on exit, create if dont exist or overwrite autosaveaccount.csv and autosavecheckout.csv.
    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SaveAccount()
        SaveCheckout()
        Environment.Exit(0)
    End Sub

    Private Sub MainStartButton_Click(sender As Object, e As EventArgs) Handles MainStartButton.Click
        Start()
    End Sub
End Class