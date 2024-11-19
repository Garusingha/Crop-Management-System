Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class CustomerRegistration
    Private Sub populate()
        Dim connectionsrtring As String = "server=localhost;user=root;database=main_project;password=;"
        Using conn As New MySqlConnection(connectionsrtring)
            conn.Open()
            Dim quary As String = "select * from customer"
            Using adapter As New MySqlDataAdapter(quary, conn)
                Dim ds As New DataSet()
                adapter.Fill(ds, "customer")
                dgvcustomerragistration.DataSource = ds.Tables("customer")
            End Using
        End Using
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnbackcustomer_Click(sender As Object, e As EventArgs) Handles btnbackcustomer.Click
        Menuone.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Clear()
        txtage.Clear()
        txttp.Clear()
        txtaddress.Clear()
        dtpregdate.Value = Now
        txtcropname.Clear()
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub dgvcustomerragistration_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomerragistration.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub CustomerRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
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
    Private Function validatepassword(password As String) As Boolean
        Dim regexPattern As String = "^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d$!%*?&]{8,}$"
        Dim regex As New Regex(regexPattern)
        Return regex.IsMatch(password)
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name As String = txtname.Text
        Dim age As String = txtage.Text

        Dim phonenumber As String = txttp.Text

        Dim fulladdress As String = txtaddress.Text
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text

        Dim regdate As Date = dtpregdate.Value
        Dim cropname As String = txtcropname.Text
        Dim iscropcorrect As Boolean
        If validatename(name) Then
            If validateage() Then
                If validatephonenumber(phonenumber) Then
                    If validateaddress(fulladdress) Then
                        If regdate.Date = Date.Today Then
                            If cropname = "cinnoman" OrElse cropname = "coffee" OrElse cropname = "garcinia" OrElse cropname = "nutmeg" OrElse cropname = "pepper" OrElse cropname = "turmeric" OrElse cropname = "cardamom" Then
                                If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
                                    MsgBox("No required password or Username")
                                ElseIf username.Length > 10 Then
                                    MsgBox("invalid Length.")
                                ElseIf Not validatepassword(password) Then
                                    MsgBox("Invalid password. Password must be 8 characters and include uppercase letters and lowercase letters,numbers, special characters.")
                                Else


                                    Dim connectionstring As String = "server=localhost;user=root;database=main_project;password=;"

                                    Try
                                        Using conn As New MySqlConnection(connectionstring)
                                            conn.Open()

                                            Dim q As String = "INSERT INTO customer(Customer_Name,Age,Address,Telephone,Reg_Date,Crop_Name,Username,Password) 
                                   VALUES(@Customer_Name,@Age,@Address,@Telephone,@Reg_Date,@Crop_Name,@Username,@Password)"

                                            Using cmd As New MySqlCommand(q, conn)
                                                cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text)
                                                cmd.Parameters.AddWithValue("@Age", txtage.Text)
                                                cmd.Parameters.AddWithValue("@Address", txtaddress.Text)
                                                cmd.Parameters.AddWithValue("@Telephone", txttp.Text)
                                                cmd.Parameters.AddWithValue("@Reg_Date", dtpregdate.Value)
                                                cmd.Parameters.AddWithValue("@Crop_Name", txtcropname.Text)
                                                cmd.Parameters.AddWithValue("@Username", txtusername.Text)
                                                cmd.Parameters.AddWithValue("@Password", txtpassword.Text)

                                                Dim insertedRows As Integer = cmd.ExecuteNonQuery()

                                                If insertedRows = 1 Then
                                                    MsgBox("New user successfully registered.")
                                                    Purchase.Show()
                                                Else
                                                    MsgBox("Registration failed")
                                                End If
                                            End Using

                                        End Using
                                        populate()
                                    Catch ex As Exception
                                        MsgBox("Error: " & ex.Message)
                                    End Try



                                End If


                            Else
                                iscropcorrect = False
                                MsgBox("Please enter a valid Crop name")
                            End If
                        Else
                            MsgBox("Please enter today.")
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

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Dim name As String = txtname.Text
        Dim age As Integer = Integer.Parse(txtage.Text)
        Dim address As String = txtaddress.Text
        Dim telephone As String = txttp.Text
        Dim regdate As Date = dtpregdate.Value
        Dim cropname As String = txtcropname.Text
        Me.dgvcustomerragistration.Rows.Add(name, age, address, telephone, regdate, cropname)
    End Sub
    
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnsearch.Click
        TryCast(dgvcustomerragistration.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("Customer_Name like '%" & txtname.Text & "%'")

    End Sub
End Class