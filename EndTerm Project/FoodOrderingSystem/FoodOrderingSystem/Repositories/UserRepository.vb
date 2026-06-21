Imports FoodOrderingSystem.Data
Imports MySql.Data.MySqlClient
Imports FoodOrderingSystem.Models

Namespace Repositories
    Public Class UserRepository
        Private ReadOnly _factory As New DbConnectionFactory()

        Public Function FindByUsername(username As String) As AppUser
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("SELECT id, full_name, username, password_hash, role, is_active FROM users WHERE username=@username LIMIT 1", connection)
                    command.Parameters.AddWithValue("@username", username)
                    Using reader = command.ExecuteReader()
                        If reader.Read() Then Return MapUser(reader)
                    End Using
                End Using
            End Using
            Return Nothing
        End Function

        Public Function GetAll(Optional includeInactive As Boolean = True) As List(Of AppUser)
            Dim users As New List(Of AppUser)()
            Using connection = _factory.CreateConnection()
                connection.Open()
                Dim sql = "SELECT id, full_name, username, password_hash, role, is_active FROM users"
                If Not includeInactive Then sql &= " WHERE is_active=1"
                sql &= " ORDER BY full_name"
                Using command As New MySqlCommand(sql, connection)
                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            users.Add(MapUser(reader))
                        End While
                    End Using
                End Using
            End Using
            Return users
        End Function

        Public Sub Add(user As AppUser)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("INSERT INTO users(full_name, username, password_hash, role, is_active) VALUES(@fullName,@username,@passwordHash,@role,@active)", connection)
                    FillUserParameters(command, user)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Update(user As AppUser, updatePassword As Boolean)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Dim sql = "UPDATE users SET full_name=@fullName, username=@username, role=@role, is_active=@active"
                If updatePassword Then sql &= ", password_hash=@passwordHash"
                sql &= " WHERE id=@id"
                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@id", user.Id)
                    command.Parameters.AddWithValue("@fullName", user.FullName)
                    command.Parameters.AddWithValue("@username", user.Username)
                    command.Parameters.AddWithValue("@role", user.Role)
                    command.Parameters.AddWithValue("@active", If(user.IsActive, 1, 0))
                    If updatePassword Then command.Parameters.AddWithValue("@passwordHash", user.PasswordHash)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Deactivate(userId As Integer)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("UPDATE users SET is_active=0 WHERE id=@id", connection)
                    command.Parameters.AddWithValue("@id", userId)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Private Function MapUser(reader As MySqlDataReader) As AppUser
            Return New AppUser With {
                .Id = Convert.ToInt32(reader("id")),
                .FullName = reader("full_name").ToString(),
                .Username = reader("username").ToString(),
                .PasswordHash = reader("password_hash").ToString(),
                .Role = reader("role").ToString(),
                .IsActive = Convert.ToBoolean(reader("is_active"))
            }
        End Function

        Private Sub FillUserParameters(command As MySqlCommand, user As AppUser)
            command.Parameters.AddWithValue("@fullName", user.FullName)
            command.Parameters.AddWithValue("@username", user.Username)
            command.Parameters.AddWithValue("@passwordHash", user.PasswordHash)
            command.Parameters.AddWithValue("@role", user.Role)
            command.Parameters.AddWithValue("@active", If(user.IsActive, 1, 0))
        End Sub
    End Class
End Namespace