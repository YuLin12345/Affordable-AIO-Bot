'@author Yu Lin

Public Module Crypt

    Public Function Encrypt(originalString As String)
        Dim modifiedString As String
        Dim bit As Byte()
        Dim result As String = ""
        Dim x As Integer
        Dim currentchar As Char
        Dim isEven As Boolean

        bit = System.Text.Encoding.UTF8.GetBytes(originalString)

        modifiedString = Convert.ToBase64String(bit)

        For x = 0 To modifiedString.Length - 1
            currentchar = modifiedString(x)

            If x Mod 2 = 0 Then
                isEven = True
            Else
                isEven = False
            End If

            If isEven Then
                result += Chr(Asc(currentchar) + 6 / 3)
            Else
                result += Chr(Asc(currentchar) - 10 / 5)
            End If
        Next

        Return result
    End Function

    Public Function Decrypt(modifiedString As String)
        Dim originalString As String
        Dim bit As Byte()
        Dim result As String = ""
        Dim x As Integer
        Dim currentchar As Char
        Dim isEven As Boolean

        For x = 0 To modifiedString.Length - 1
            currentchar = modifiedString(x)

            If x Mod 2 = 0 Then
                isEven = True
            Else
                isEven = False
            End If

            If isEven Then
                result += Chr(Asc(currentchar) - 6 / 3)
            Else
                result += Chr(Asc(currentchar) + 10 / 5)
            End If
        Next

        bit = Convert.FromBase64String(result)

        originalString = System.Text.Encoding.UTF8.GetString(bit)

        Return originalString
    End Function
End Module