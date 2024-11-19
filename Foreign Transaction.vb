Imports System.Text.RegularExpressions
Public Class Foreign_Transaction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menuone.Show()
        Me.Hide()
    End Sub
    Public Function validatename(name As String) As Boolean
        Const minlength As Integer = 2
        Const maxlength As Integer = 100
        If name.Length < minlength OrElse name.Length > maxlength Then
            MsgBox("Invalid Name Length. Please Input a name between 2 and 100 charactors.")
            Return False
        ElseIf Not name.All(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)) Then
            MsgBox("Invalid Data Type. Please Input only String")
            Return False
        Else
            Return True
        End If
        name = name.Trim()
        If name.Length < minlength Then
            MsgBox("Invalid Name Length without space. Please Input a name between 2 and 100 charactors without over spaces.")
            Return False
        Else
            Return True
        End If

    End Function
    Private Function validateaddress(fulladdress As String) As Boolean
        fulladdress = fulladdress.Trim()
        If Not fulladdress.EndsWith(".") Then
            Return False
        Else
            Return True
        End If
        Dim addressparts As String() = fulladdress.Split(","c)

        If addressparts.Count() <= 2 Then
            Return True
        End If
        Dim homenamepattern As String = "^[A-Za-z0-9/ ]+$"
        If Not Regex.IsMatch(addressparts(0), homenamepattern) Then
            Return False
        Else
            Return True

        End If

        Dim stateandtownpattern As String = "^[A-Za-z]+$"
        Dim lastindex As Integer = addressparts.Count() - 1
        If Not Regex.IsMatch(addressparts(lastindex), stateandtownpattern) OrElse
           Not Regex.IsMatch(addressparts(lastindex - 1), stateandtownpattern) OrElse
           Not Regex.IsMatch(addressparts(lastindex - 2), stateandtownpattern) Then
            Return False
        Else
            Return True
        End If

    End Function
    Private Function validatephonenumber(phonenumber As String) As Boolean
        phonenumber = New String(phonenumber.Where(Function(c) Char.IsDigit(c)).ToArray())
        Dim validmobileprefixes As String() = {"077", "076", "074", "071", "070", "072", "075"}
        Dim landlinearecode As String() = {"041", "091", "034"}
        Const expectedlength As Integer = 10
        If phonenumber.Length <> expectedlength Then
            Return False

        End If
        Dim prifix As String = phonenumber.Substring(0, 3)
        If Not validmobileprefixes.Contains(prifix) AndAlso Not landlinearecode.Contains(prifix) Then
            Return False
        End If
        Return True
    End Function
    Private Function validateemail(email As String) As Boolean
        Dim regexpattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        Dim regex As New Regex(regexpattern)
        Return regex.IsMatch(email)
    End Function
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class