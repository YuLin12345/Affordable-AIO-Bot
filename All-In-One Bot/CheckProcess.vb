'@author Yu Lin
'https://github.com/yulin12345
'admin@yulin12345.site
'Check if application is closing properly.

Module CheckProcess

    Public Sub CheckIfProcessIsRunning()

        p = Process.GetProcessesByName("Affordable AIO Bot")

        If p.Count > 0 Then

            'Use to debug it application is closing properly.
            MsgBox("Application currently running." & vbLf & "Close it using Task Manager")
        End If
    End Sub

    Dim p() As Process
End Module