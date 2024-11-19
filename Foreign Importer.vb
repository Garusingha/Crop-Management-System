Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class Foreign_Importer
    Private Sub populate()
        Dim connectionsrtring As String = "server=localhost;user=root;database=main_project;password=;"
        Using conn As New MySqlConnection(connectionsrtring)
            conn.Open()
            Dim quary As String = "select * from foreign_importer"
            Using adapter As New MySqlDataAdapter(quary, conn)
                Dim ds As New DataSet()
                adapter.Fill(ds, "foreign_importer")
                dgvforeignimporter.DataSource = ds.Tables("foreign_importer")
            End Using
        End Using
    End Sub
    Private Sub btnback3_Click(sender As Object, e As EventArgs) Handles btnback3.Click
        Menuone.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtpoition.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblname.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblage.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbltp.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblregno.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcompanyname.TextChanged

    End Sub
    Public Function validateparsonname(name As String) As Boolean
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
    Private Sub Foreign_Importer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim personname As String = txtpersonname.Text
        Dim company As String = txtcompanyname.Text
        Dim agestring As String = txtage.Text
        Dim regno As String = txtregno.Text
        Dim position As String = txtpoition.Text
        Dim phonenumber As String = txttp.Text
        Dim email As String = txtemail.Text
        Dim fulladdress As String = txtaddress.Text

        If validateparsonname(personname) Then
            If validateage() Then
                If validatephonenumber(phonenumber) Then
                    If validateaddress(fulladdress) Then
                        If validateemail(email) Then


                            Dim connectionstring As String = "server=localhost;user=root;database=main_project;password=;"
                            Try

                                Using conn As New MySqlConnection(connectionstring)
                                    conn.Open()

                                    Dim insertQuery As String = "INSERT INTO foreign_importer(Company_Name,Parsone_Name,Position,Age,Reg_Date,Telephone,Address,E_Mail,Company_Reg_No) VALUES (@Company_Name,@Parsone_Name,@Position,@Age,@Reg_Date,@Telephone,@Address,@E_Mail,@Company_Reg_No)"




                                    Using cmd As New MySqlCommand(insertQuery, conn)
                                        cmd.Parameters.AddWithValue("@Company_Name", txtcompanyname.Text)
                                        cmd.Parameters.AddWithValue("@Parsone_Name", txtpersonname.Text)
                                        cmd.Parameters.AddWithValue("@Position", txtpoition.Text)
                                        cmd.Parameters.AddWithValue("@Age", txtage.Text)
                                        cmd.Parameters.AddWithValue("@Reg_Date", dtpforeignimporter.Value)
                                        cmd.Parameters.AddWithValue("@Telephone", txttp.Text)
                                        cmd.Parameters.AddWithValue("@Address", txtaddress.Text)
                                        cmd.Parameters.AddWithValue("@E_Mail", txtemail.Text)
                                        cmd.Parameters.AddWithValue("@Company_Reg_No", txtregno.Text)
                                        cmd.ExecuteNonQuery()
                                    End Using

                                    MsgBox("Purchase data inserted successfully.")
                                End Using
                                populate()
                            Catch ex As Exception
                                MsgBox("Error: " & ex.Message)
                            End Try
                            Menuone.Show()


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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TryCast(dgvforeignimporter.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("Company_Name like '%" & txtcompanyname.Text & "%'")
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcompanyname.Clear()
        txtaddress.Clear()
        txtage.Clear()
        txtemail.Clear()
        txtpersonname.Clear()
        txtpoition.Clear()
        txtregno.Clear()
        txttp.Clear()
        dtpforeignimporter.Value = Now
    End Sub
End Class