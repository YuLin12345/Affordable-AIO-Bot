'@author Yu Lin
'This form will display carted items.

Public Class CartForm

    'Cart tab, right-click.
    Private Sub CartData_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CartData.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CartData.Rows(e.RowIndex).Selected = True
            CartContextMenuStrip.Show(CartData, CartData.PointToClient(Cursor.Position))
        End If
    End Sub

    'Cart tab, contextMenuStrip right-click browser view.
    Private Sub CartViewBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartViewBrowserToolStripMenuItem.Click
        CartBrowserView()
    End Sub

    'Load anything below.
    Private Sub CartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class