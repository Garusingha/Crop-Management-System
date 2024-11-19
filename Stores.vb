Imports MySql.Data.MySqlClient

Public Class Stores
    Private Sub populate()
        Dim connectionsrtring As String = "server=localhost;user=root;database=main_project;password=;"
        Using conn As New MySqlConnection(connectionsrtring)
            conn.Open()
            Dim quary As String = "select * from store"
            Using adapter As New MySqlDataAdapter(quary, conn)
                Dim ds As New DataSet()
                adapter.Fill(ds, "store")
                dgvstores.DataSource = ds.Tables("store")
            End Using
        End Using

    End Sub

    Private Sub btnback2_Click(sender As Object, e As EventArgs) Handles btnback2.Click
        Menuone.Show()
        Me.Hide()
    End Sub






    Private Function GetValueFromDatabase(cropName As String) As Integer
        ' You should implement this function to retrieve the value of the crop from the database
        ' For now, let's return a placeholder value
        Return 50
    End Function



    Private Sub Stores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        'Dim connectiontring As String = (server = "localhost";database ="main_project";user="root";password=;)
        Dim cropName As List(Of String) = New List(Of String) From {"cinnoman", "coffee", "garcinia", "nutmeg", "pepper", "turmeric", "cardamom"}
        Dim unitPrice As Decimal
        Dim quantity As Integer
        Dim transactiondate As Date = dtpstore.Value
        Dim transactionType As String = cmbstore.SelectedItem.ToString()

        If Integer.TryParse(txtreceive.Text, Quantity) AndAlso Double.TryParse(txtunitprice.Text, unitprice) Then
            Try
                Dim connectionstring As String = "server=localhost;user=root;database=main_project;password=;"
                Using conn As New MySqlConnection(connectionstring)
                    conn.Open()
                    Dim newcropname As String = txtcropname.Text
                    If cropName.Contains(newcropname) Then

                        Dim currentQuantity As Integer = 0
                        Dim currentValue As Decimal = 0.0






                        Decimal.TryParse(txtunitprice.Text, unitPrice)
                        Integer.TryParse(txtreceive.Text, quantity)


                        If transactionType = "receive" Then
                            currentQuantity += quantity
                            currentValue += unitPrice * quantity
                        ElseIf transactionType = "issue" Then
                            If quantity > currentQuantity Then
                                MessageBox.Show("Insufficient quantity for issuing.")
                                Return
                            End If
                            currentQuantity -= quantity
                            currentValue -= unitPrice * quantity
                        End If

                        txtcurrentquantity.Text = currentQuantity.ToString()
                        txtcurrentvalue.Text = currentValue.ToString("0,00")



                        Dim insertQuery As String = "INSERT INTO store(`Crop Name`, `Current Quantity`, `Current Value`, `Transaction Type`, Quantity, `Unit Price`, Date) VALUES (@CropName, @CurrentQuantity, @CurrentValue, @TransactionType, @Quantity, @UnitPrice, @Date)"
                        Using cmdInsert As New MySqlCommand(insertQuery, conn)
                            cmdInsert.Parameters.AddWithValue("@CropName", newcropname)
                            cmdInsert.Parameters.AddWithValue("@CurrentQuantity", currentQuantity)
                            cmdInsert.Parameters.AddWithValue("@CurrentValue", currentValue)
                            cmdInsert.Parameters.AddWithValue("@TransactionType", transactionType)
                            cmdInsert.Parameters.AddWithValue("@Quantity", Quantity)
                            cmdInsert.Parameters.AddWithValue("@UnitPrice", unitprice)
                            cmdInsert.Parameters.AddWithValue("@Date", transactiondate)
                            cmdInsert.ExecuteNonQuery()
                        End Using

                        MsgBox("Transaction data inserted successfully.")
                        ' Update the DataGridView
                    Else
                        MsgBox("Invalid crop name.")
                    End If
                End Using
                populate()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            MsgBox("Invalid quantity or unit price values. Please enter valid numbers.")
        End If



    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcropname.Clear()
        txtcurrentquantity.Clear()
        txtcurrentvalue.Clear()
        txtreceive.Clear()
        dtpstore.Value = Now
        txtunitprice.Clear()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        TryCast(dgvstores.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("[Crop Name] like '%" & txtcropname.Text & "%'")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvstores.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvstores.SelectedRows
                dgvstores.Rows.Remove(row)
            Next
        Else
            MsgBox("Please select rows to delete.")
        End If
    End Sub
End Class