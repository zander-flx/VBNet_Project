Imports FoodOrderingSystem.Data
Imports FoodOrderingSystem.Models
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class CategoryRepository
        Private ReadOnly _factory As New DbConnectionFactory()

        Public Function GetAll() As List(Of Category)
            Dim categories As New List(Of Category)()
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("SELECT id, name, description, is_active FROM categories WHERE is_active=1 ORDER BY name", connection)
                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            categories.Add(MapCategory(reader))
                        End While
                    End Using
                End Using
            End Using
            Return categories
        End Function

        Public Sub Add(category As Category)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("INSERT INTO categories(name, description, is_active) VALUES(@name,@desc,@active)", connection)
                    FillCategoryParameters(command, category)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Update(category As Category)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("UPDATE categories SET name=@name, description=@desc, is_active=@active WHERE id=@id", connection)
                    command.Parameters.AddWithValue("@id", category.Id)
                    FillCategoryParameters(command, category)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Deactivate(categoryId As Integer)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("UPDATE categories SET is_active=0 WHERE id=@id", connection)
                    command.Parameters.AddWithValue("@id", categoryId)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Private Function MapCategory(reader As MySqlDataReader) As Category
            Return New Category With {
                .Id = Convert.ToInt32(reader("id")),
                .Name = reader("name").ToString(),
                .Description = reader("description").ToString(),
                .IsActive = Convert.ToBoolean(reader("is_active"))
            }
        End Function

        Private Sub FillCategoryParameters(command As MySqlCommand, category As Category)
            command.Parameters.AddWithValue("@name", category.Name)
            command.Parameters.AddWithValue("@desc", category.Description)
            command.Parameters.AddWithValue("@active", If(category.IsActive, 1, 0))
        End Sub
    End Class
End Namespace