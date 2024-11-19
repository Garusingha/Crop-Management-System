Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class CreateNewAcc

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
    Private Function validatepassword(password As String) As Boolean
        Dim regexPattern As String = "^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d$!%*?&]{8,}$"
        Dim regex As New Regex(regexPattern)
        Return regex.IsMatch(password)
    End Function
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Function validateemail(email As String) As Boolean
        Dim regexpattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        Dim regex As New Regex(regexpattern)
        Return regex.IsMatch(email)
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
    Private Function validateage() As Boolean
        Dim agestring As String = txtage.Text.Trim()
        Dim age As Integer
        If Integer.TryParse(agestring, age) Then
            If age >= 18 AndAlso age <= 80 Then
                Return True
            Else

                MsgBox("Age must be between 18 and 80.")
                Return False
            End If
        Else

            MsgBox("Please enter a valid number.")
            Return False
        End If
    End Function
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click

        Dim name As String = txtname.Text
        Dim agestring As String = txtage.Text

        Dim phonenumber As String = txttp.Text
        Dim email As String = txtemail.Text
        Dim fulladdress As String = txtaddres.Text
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        If validatename(name) Then
            If validateage() Then
                If validatephonenumber(phonenumber) Then
                    If validateaddress(fulladdress) Then

                        If validateemail(email) Then
                            If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
                                MsgBox("No required password or Username")
                            ElseIf username.Length > 10 Then
                                MsgBox("invalid Length")
                            ElseIf Not validatepassword(password) Then
                                MsgBox("Invalid password. Password must be 8 characters and include uppercase letters and lowercase letters,numbers, special characters.")
                            Else
                                Try
                                    Dim connectionstring As String = "server=localhost;user=root;database=main_project;password=;"
                                    Using conn As New MySqlConnection(connectionstring)
                                        conn.Open()

                                        Dim insertQuery As String = "INSERT INTO admin(Admin_Name,Age,Telephone,Address,Email,Username,Password) VALUES (@Admin_Name,@Age,@Telephone,@Address,@Email,@Username,@Password)"




                                        Using cmd As New MySqlCommand(insertQuery, conn)
                                            cmd.Parameters.AddWithValue("@Admin_Name", txtname.Text)
                                            cmd.Parameters.AddWithValue("@Age", txtage.Text)
                                            cmd.Parameters.AddWithValue("@Telephone", txttp.Text)
                                            cmd.Parameters.AddWithValue("@Address", txtaddres.Text)
                                            cmd.Parameters.AddWithValue("@Email", txtemail.Text)
                                            cmd.Parameters.AddWithValue("@Username", txtusername.Text)
                                            cmd.Parameters.AddWithValue("@Password", txtpassword.Text)
                                            cmd.ExecuteNonQuery()
                                        End Using

                                        MsgBox("Purchase data inserted successfully.")
                                    End Using
                                Catch ex As Exception
                                    MsgBox("Error: " & ex.Message)
                                End Try
                                Menuone.Show()

                            End If
                        Else
                            MsgBox("Invalid Email.Please Enter an Email with only lowercase letters and number.")

                        End If
                    Else
                        MsgBox("invalid Address.Please start with uppercase letter any part of yor address and divide it using comma and end of the address put full stop mark. ")
                    End If
                Else
                    MsgBox("Invalid Telephone Number")

                End If
            Else
                MsgBox("Invalid Age. ")
            End If
        Else
            MsgBox("Name is Invalid.Please Reenter a valid Name.")

        End If
    End Sub

    Private Sub btncreatenew_Click(sender As Object, e As EventArgs) Handles btncreatenew.Click
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub CreateNewAcc_resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - 40
        Me.Top = 0
        Me.Left = 0
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Clear()
        txtage.Clear()
        txtaddres.Clear()
        txtemail.Clear()
        txttp.Clear()
        txtusername.Clear()
        txtpassword.Clear()
    End Sub


End Class
