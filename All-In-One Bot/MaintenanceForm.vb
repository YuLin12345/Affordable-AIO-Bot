'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'This form will display if the bot is under maintenance.

Public Class MaintenanceForm

    'If okay button click, form will close.
    Private Sub MaintenanceFormOkayButton_Click(sender As Object, e As EventArgs) Handles MaintenanceFormOkayButton.Click
        Me.Close()
    End Sub

    'Maintenance form will load anything below.
    Private Sub MaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class