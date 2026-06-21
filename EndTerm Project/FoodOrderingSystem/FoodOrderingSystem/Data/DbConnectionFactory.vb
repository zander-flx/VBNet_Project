Imports System.Configuration
Imports MySql.Data.MySqlClient
Namespace Data
    Public Class DbConnectionFactory
        Public Function CreateConnection() As MySqlConnection
            Dim settings = ConfigurationManager.ConnectionStrings("PosDb")
            If settings Is Nothing Then
                Throw New InvalidOperationException("Missing PosDb connection string in App.config.")
            End If
            Return New MySqlConnection(settings.ConnectionString)
        End Function
    End Class
End Namespace