<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CartData = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartSite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartGroup = New System.Windows.Forms.GroupBox()
        Me.CartContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CartViewBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.CartData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CartGroup.SuspendLayout()
        Me.CartContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CartData
        '
        Me.CartData.AllowUserToAddRows = False
        Me.CartData.AllowUserToOrderColumns = True
        Me.CartData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.Product, Me.EMail, Me.CartSize, Me.CartSite})
        Me.CartData.Location = New System.Drawing.Point(6, 19)
        Me.CartData.Name = "CartData"
        Me.CartData.Size = New System.Drawing.Size(847, 511)
        Me.CartData.TabIndex = 0
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        Me.Time.Width = 150
        '
        'Product
        '
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        Me.Product.Width = 200
        '
        'EMail
        '
        Me.EMail.HeaderText = "Email"
        Me.EMail.Name = "EMail"
        Me.EMail.Width = 150
        '
        'CartSize
        '
        Me.CartSize.HeaderText = "Size"
        Me.CartSize.Name = "CartSize"
        Me.CartSize.Width = 150
        '
        'CartSite
        '
        Me.CartSite.HeaderText = "Site"
        Me.CartSite.Name = "CartSite"
        Me.CartSite.Width = 150
        '
        'CartGroup
        '
        Me.CartGroup.Controls.Add(Me.CartData)
        Me.CartGroup.Location = New System.Drawing.Point(12, 13)
        Me.CartGroup.Name = "CartGroup"
        Me.CartGroup.Size = New System.Drawing.Size(859, 536)
        Me.CartGroup.TabIndex = 0
        Me.CartGroup.TabStop = False
        Me.CartGroup.Text = "Cart"
        '
        'CartContextMenuStrip
        '
        Me.CartContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CartViewBrowserToolStripMenuItem})
        Me.CartContextMenuStrip.Name = "CartContextMenuStrip"
        Me.CartContextMenuStrip.Size = New System.Drawing.Size(145, 26)
        '
        'CartViewBrowserToolStripMenuItem
        '
        Me.CartViewBrowserToolStripMenuItem.Name = "CartViewBrowserToolStripMenuItem"
        Me.CartViewBrowserToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CartViewBrowserToolStripMenuItem.Text = "Browser View"
        '
        'CartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.CartGroup)
        Me.MaximumSize = New System.Drawing.Size(900, 600)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "CartForm"
        Me.Text = "View Cart"
        CType(Me.CartData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CartGroup.ResumeLayout(False)
        Me.CartContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CartData As DataGridView
    Friend WithEvents CartGroup As GroupBox
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents EMail As DataGridViewTextBoxColumn
    Friend WithEvents CartSize As DataGridViewTextBoxColumn
    Friend WithEvents CartSite As DataGridViewTextBoxColumn
    Friend WithEvents CartContextMenuStrip As ContextMenuStrip
    Friend WithEvents CartViewBrowserToolStripMenuItem As ToolStripMenuItem
End Class
