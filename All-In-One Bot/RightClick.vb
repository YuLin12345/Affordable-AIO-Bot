'@author Yu Lin
'Right click functions.

Module RightClick

    'Remove account.
    Public Sub AccountRemove()
        For Each row As DataGridViewRow In Main.AccountData.SelectedRows
            Main.AccountCountText.Text = Main.AccountCountText.Text - 1 '-1 for every account removed.
            Main.AccountData.Rows.Remove(row)
        Next
    End Sub

    'Clone account.
    Public Sub AccountClone()
        For Each cdata As DataGridViewRow In Main.AccountData.SelectedRows

            row = CType(cdata.Clone(), DataGridViewRow)

            For index As Integer = 0 To cdata.Cells.Count - 1
                row.Cells(index).Value = cdata.Cells(index).Value
            Next
            Main.AccountCountText.Text = Main.AccountCountText.Text + 1 '+1 for every account cloned.
            Main.AccountData.Rows.Add(row)
        Next
    End Sub

    'Remove checkout profile.
    Public Sub CheckoutRemove()
        For Each row As DataGridViewRow In Main.CheckoutData.SelectedRows
            Main.CheckoutCountText.Text = Main.CheckoutCountText.Text - 1 '-1 for every checkout removed.
            Main.CheckoutData.Rows.Remove(row)
        Next
    End Sub

    'Clone checkout profile.
    Public Sub CheckoutClone()
        For Each rdata As DataGridViewRow In Main.CheckoutData.SelectedRows

            row = CType(rdata.Clone(), DataGridViewRow)

            For index As Integer = 0 To rdata.Cells.Count - 1
                row.Cells(index).Value = rdata.Cells(index).Value
            Next
            Main.CheckoutCountText.Text = Main.CheckoutCountText.Text + 1 '+1 for every account cloned.
            Main.CheckoutData.Rows.Add(row)
        Next
    End Sub

    'Remove all accounts.
    Public Sub AccountRemoveAll()
        Main.AccountCountText.Text = 0  'AccountCountText = 0, since all accounts are removed.
        Main.AccountData.Rows.Clear()
    End Sub

    'Remove all checkout profiles.
    Public Sub CheckoutRemoveAll()
        Main.CheckoutCountText.Text = 0  'CheckoutCountText = 0, since all checkouts are removed.
        Main.CheckoutData.Rows.Clear()
    End Sub

    'Display edit size form.
    Public Sub EditSize()
        SizeEditForm.Show()
    End Sub

    'Display edit site form.
    Public Sub EditSite()
        SiteEditForm.Show()
    End Sub

    'Display edit link form.
    Public Sub EditLink()
        LinkEditForm.Show()
    End Sub

    'Display edit keyword form.
    Public Sub EditKeyword()
        KeywordEditForm.Show()
    End Sub

    'Display browser form.
    Public Sub CartBrowserView()
        BrowserForm.Show()
    End Sub

    Dim row As DataGridViewRow
End Module