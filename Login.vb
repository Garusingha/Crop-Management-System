Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions



Public Class Login
    Public command As MySqlCommand



    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click

    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        CreateNewAcc.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim connectionstring As String = "server=localhost;user=root;database=main_project;password=;"
        Using conn As New MySqlConnection(connectionstring)
            conn.Open()
            Dim quary As String = "SELECT COUNT(*) FROM admin WHERE username=@Username AND password=@Password"
            Using cmd As New MySqlCommand(quary, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then

                        MsgBox("No required password or Username")
                    ElseIf username.Length > 10 Then
                        MsgBox("invalid Length")
                    ElseIf Not validatepassword(password) Then
                        MsgBox("Invalid password. Password must be 8 characters and include uppercase letters and lowercase letters,numbers, special characters.")
                    Else
                        Menuone.Show()


                    End If
                Else
                    MsgBox("You are not an admin in our system.please regiter.")
                End If
            End Using



        End Using
    End Sub
    Private Function validatepassword(password As String) As Boolean
        Dim regexPattern As String = "^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d$!%*?&]{8,}$"
        Dim regex As New Regex(regexPattern)
        Return regex.IsMatch(password)
    End Function
    Private Sub Login_resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - 40
        Me.Top = 0
        Me.Left = 0
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2


    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckbpw.CheckedChanged

        If ckbpw.Checked Then
            txtpassword.UseSystemPasswordChar = False ' Show the password as regular text
        Else
            txtpassword.UseSystemPasswordChar = True ' Show the password as asterisks
        End If
    End Sub
End Class
