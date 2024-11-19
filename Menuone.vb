Public Class Menuone
    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        CustomerRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnforeignimporter_Click(sender As Object, e As EventArgs) Handles btnforeignimporter.Click
        Foreign_Importer.Show()
        Me.Hide()
    End Sub

    Private Sub btnpurchases_Click(sender As Object, e As EventArgs) Handles btnpurchases.Click
        Purchase.Show()
        Me.Hide()
    End Sub

    Private Sub btnforeigntransaction_Click(sender As Object, e As EventArgs) Handles btnforeigntransaction.Click
        Foreign_Transaction.Show()
        Me.Hide()
    End Sub

    Private Sub btnstore_Click(sender As Object, e As EventArgs) Handles btnstore.Click
        Stores.Show()
        Me.Hide()
    End Sub
    Private Sub Login_resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - 40
        Me.Top = 0
        Me.Left = 0
        Panel1.Left = (Me.Width - Panel1.Width)
        Panel1.Top = (Me.Height - Panel1.Height) / 2


    End Sub

    Private Sub Menuone_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pcbforeigntransaction_Click(sender As Object, e As EventArgs) Handles pcbforeigntransaction.Click

    End Sub

    Private Sub pcbforeignimporter_Click(sender As Object, e As EventArgs) Handles pcbforeignimporter.Click

    End Sub
End Class