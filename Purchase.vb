Imports MySql.Data.MySqlClient

Public Class Purchase
    Private Sub populate()
        Dim connectionsrtring As String = "server=localhost;user=root;database=main_project;password=;"
        Using conn As New MySqlConnection(connectionsrtring)
            conn.Open()
            Dim quary As String = "select * from purchase_details"
            Using adapter As New MySqlDataAdapter(quary, conn)
                Dim ds As New DataSet()
                adapter.Fill(ds, "purchase_details")
                dgvpurchase.DataSource = ds.Tables("purchase_details")
            End Using
        End Using
    End Sub
    Private Sub btnpurchase_Click(sender As Object, e As EventArgs) Handles btnpurchase.Click
        Menuone.Show()
        Me.Hide()
    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click


        Dim customerName As String = txtcustomername.Text
        Dim cropName As String = txtcropname.Text
        Dim quantity As Integer
        Dim unitPrice As Double

        If Integer.TryParse(txtquantity.Text, quantity) AndAlso Double.TryParse(txtunitprice.Text, unitPrice) Then
            Dim totalValue As Double = quantity * unitPrice
            ' Display the calculated total value in a label or textbox
            txttotal.Text = totalValue.ToString("0.00")

            Try
                Dim connectionstring As String = "server=localhost;user=root;database=main_project;password=;"
                Using conn As New MySqlConnection(connectionstring)
                    conn.Open()

                    Dim insertQuery As String = "INSERT INTO purchase_details(`Customer Name`, `Crop Name`, `Quantity`, `Unit Price`, `Total Value`, `Purchase Date`) VALUES (@customerName, @cropName, @quantity, @unitPrice, @totalValue, @purchaseDate)"


                    '"INSERT INTO purchase_details (Customer Name, Crop Name, Quantity, Unit Price, Total Value, Purchase Date) 
                    'VALUES (@customerName, @cropName, @quantity, @unitPrice, @totalValue, @purchaseDate)"

                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@customerName", customerName)
                        cmd.Parameters.AddWithValue("@cropName", cropName)
                        cmd.Parameters.AddWithValue("@quantity", quantity)
                        cmd.Parameters.AddWithValue("@unitPrice", unitPrice)
                        cmd.Parameters.AddWithValue("@totalValue", totalValue)
                        cmd.Parameters.AddWithValue("@purchaseDate", dtppurcase.Value)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Purchase data inserted successfully.")
                End Using
                populate()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            MsgBox("Invalid quantity or unit price values. Please enter valid numbers.")
        End If


    End Sub

    'Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
    'Dim customername As String = txtcustomername.Text
    'Dim quantity As Integer = Integer.Parse(txtquantity.Text)
    'Dim totalvalue As String = txttotal.Text
    'Dim unitprice As String = txtunitprice.Text
    'Dim purchasedate As Date = dtppurcase.Value
    'Dim cropname As String = txtcropname.Text
    'Me.dgvpurchase.Rows.Add(customername, cropname, quantity, unitprice, totalvalue, purchasedate)
    'End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcustomername.Clear()
        txtcropname.Clear()
        txtquantity.Clear()
        txttotal.Clear()
        dtppurcase.Value = Now
        txtunitprice.Clear()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click



        TryCast(dgvpurchase.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("[Customer Name] like '%" & txtcustomername.Text & "%'")


    End Sub

    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs)

    End Sub
End Class