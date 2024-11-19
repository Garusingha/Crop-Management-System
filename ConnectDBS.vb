Imports MySql.Data.MySqlClient




Module ConnectDBS
    Private ReadOnly host = "localhost"
    Private ReadOnly user = "root"
    Private ReadOnly password = ""
    Private ReadOnly database = "main_project"
    Public conn As New MySqlConnection
    Public status As Boolean = False



    Public Function DbConnection()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = String.Format("host={0};user={1};password={2};database={3};", host, user, password, database)
                conn.Open()
                If conn.State = 1 Then
                    status = True
                End If

            End If
        Catch ex As Exception

            status = False

        End Try
        Return status
    End Function


End Module

