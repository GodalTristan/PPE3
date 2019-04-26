Public Class Connexion

    Public Shared ORA As New Connexion("SDIS29", "SDIS29", "Iroise29")

    Private myConnection As New Odbc.OdbcConnection
    Private myCommand As New Odbc.OdbcCommand


    Private _dsn As String
    Private _uid As String
    Private _password As String
    Private _connString As String

    Public Sub New(ByVal dsn As String, ByVal uid As String, ByVal password As String)

        _dsn = dsn
        _uid = uid
        _password = password

        _connString = "DSN=" + _dsn + ";Uid=" + _uid + ";Pwd=" + _password + ";"
        myConnection.ConnectionString = _connString

        Try
            myConnection.Open()
        Catch ex As Exception
            MessageBox.Show("Erreur de connexion a la base")
        End Try

    End Sub


    Public Sub Execute(ByVal query As String)
        Dim MyCmd As Odbc.OdbcCommand

        MyCmd = New Odbc.OdbcCommand(query, myConnection)
        MyCmd.ExecuteNonQuery()
    End Sub

    Public Function Table(ByVal query As String)
        Dim myAdapter As Odbc.OdbcDataAdapter
        Dim myBuilder As Odbc.OdbcCommandBuilder
        Dim donnee As New DataTable

        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Return donnee
    End Function

    Public Function Champ(ByVal query As String)
        Return Table(query).Rows(0)
    End Function

End Class
