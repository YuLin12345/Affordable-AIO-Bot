'@author Yu Lin
'This form will check for login authentication from the backend.

Imports System.Management

Public Class LoginForm

    'If login box is clicked, check the below statements.
    Private Sub LoginBox_Click(sender As Object, e As EventArgs) Handles LoginBox.Click

        'Gets the current computer's HWID.
        Using client As New Net.WebClient

            Dim HWID As String = String.Empty
            Dim manageClass As New ManagementClass("Win32_Processor")
            Dim manageObjectCollection As ManagementObjectCollection = manageClass.GetInstances()

            For Each manageObject As ManagementObject In manageObjectCollection

                If HWID = "" Then
                    HWID = manageObject.Properties("ProcessorId").Value.ToString()

                    Exit For
                End If
            Next

            'Use to debug HWID.
            'Console.WriteLine(HWID)

            'POST the user input: email, pass, and hwid to the backend for authentication.
            Dim requestParameter As New Specialized.NameValueCollection
            requestParameter.Add("email", UsernameBox.Text)
            requestParameter.Add("pass", PasswordBox.Text)
            requestParameter.Add("hwid", HWID)

            'Link decrypted to provide a bit of security.
            Dim responseBytes = client.UploadValues(Decrypt("cFT.eBqtN1f1fw7.cEXfgk7x\Uzq\VKs[0;rN/Ps\UHp\VLAd1T@fVTmNlDme??;"), "POST", requestParameter)
            Dim responseBody = (New Text.UTF8Encoding).GetString(responseBytes)

            Dim uT As Int64
            uT = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds

            'Link decrypted to provide a bit of security.
            Dim timeResult As String = client.DownloadString(Decrypt("cFT.eBqtN1f1fw7.cEXfgk7x\Uzq\VKs[0;rN/Ps\UHp\VLAd1TScU3jNlDme??;"))

            If (uT < timeResult) Then
                'If user is validated, moves the user to the main form.
                If (responseBody = "validated") Then
                    Me.Hide()
                    Main.Show()
                    'If user is banned, display message box and reason.
                ElseIf (responseBody).Contains("banned - ") Then
                    MsgBox(UCase("ACCOUNT " + responseBody))
                    'If HWID does not match the one on the account, ask the user for a license reset.
                ElseIf (responseBody).Contains("unauthorized") Then
                    MsgBox((UCase("License not activated for this computer." & vbLf & "E-Mail admin@theaznseller.com for license reset.")))
                Else
                    'if user info does not match, authorization not granted.
                    MsgBox("Wrong username or password and/or does not exist.")
                End If
            Else
                Me.Hide()
                MaintenanceForm.Show()
            End If
        End Using
    End Sub

    'If purchase textlink is clicked, open the site.
    Private Sub PurchaseText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PurchaseText.LinkClicked
        'Link decrypted to provide a bit of security.
        Dim purchaseLink As String = Decrypt("cFT.eBqtN1f1fw7.cEXfgk7x\Uzq\VKs[0;rNu?;")
        Process.Start(purchaseLink)
    End Sub

    'If copyright textlink is clicked, show about Box.
    Private Sub CopyrightText_Click(sender As Object, e As EventArgs) Handles CopyrightText.Click
        AboutBox.Show()
    End Sub

    'If version textlink is clicked, show about Box.
    Private Sub VersionText_Click(sender As Object, e As EventArgs) Handles VersionText.Click
        AboutBox.Show()
    End Sub

    'Login form will load anything below.
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CheckIfProcessIsRunning()  'Check if application is running. To see if it is closing properly.
        VersionText.Text = My.Settings.Version  'Displays current bot version, bottom-right.
        CopyrightText.Text = My.Settings.Copyright  'Display copyright, bottom-left.
    End Sub
End Class