Imports FoodOrderingSystem.Data
Imports MySql.Data.MySqlClient
Imports FoodOrderingSystem.Models

Namespace Repositories
    Public Class MenuItemRepository
        Private ReadOnly _factory As New DbConnectionFactory()

        Public Function GetAll() As List(Of MenuItem)
            Return QueryMenuItems("SELECT m.id, m.category_id, c.name AS category_name, m.name, m.description, m.price, m.image_path, m.is_available FROM menu_items m LEFT JOIN categories c ON m.category_id = c.id ORDER BY c.name, m.name")
        End Function

        Public Function GetByCategory(categoryId As Integer) As List(Of MenuItem)
            Dim sql = "SELECT m.id, m.category_id, c.name AS category_name, m.name, m.description, m.price, m.image_path, m.is_available FROM menu_items m LEFT JOIN categories c ON m.category_id = c.id WHERE m.category_id=@catId AND m.is_available=1 ORDER BY m.name"
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@catId", categoryId)
                    Return ExecuteReaderToList(command)
                End Using
            End Using
        End Function

        Public Function Search(term As String) As List(Of MenuItem)
            Dim sql = "SELECT m.id, m.category_id, c.name AS category_name, m.name, m.description, m.price, m.image_path, m.is_available FROM menu_items m LEFT JOIN categories c ON m.category_id = c.id WHERE m.is_available=1 AND (m.name LIKE @term OR m.description LIKE @term) ORDER BY m.name"
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@term", "%" & term & "%")
                    Return ExecuteReaderToList(command)
                End Using
            End Using
        End Function

        Public Sub Add(item As MenuItem)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("INSERT INTO menu_items(category_id, name, description, price, image_path, is_available) VALUES(@catId,@name,@desc,@price,@img,@available)", connection)
                    FillItemParameters(command, item)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Update(item As MenuItem)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("UPDATE menu_items SET category_id=@catId, name=@name, description=@desc, price=@price, image_path=@img, is_available=@available WHERE id=@id", connection)
                    command.Parameters.AddWithValue("@id", item.Id)
                    FillItemParameters(command, item)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub SetAvailability(id As Integer, isAvailable As Boolean)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("UPDATE menu_items SET is_available=@available WHERE id=@id", connection)
                    command.Parameters.AddWithValue("@id", id)
                    command.Parameters.AddWithValue("@available", If(isAvailable, 1, 0))
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Private Function QueryMenuItems(sql As String) As List(Of MenuItem)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand(sql, connection)
                    Return ExecuteReaderToList(command)
                End Using
            End Using
        End Function

        Private Function ExecuteReaderToList(command As MySqlCommand) As List(Of MenuItem)
            Dim items As New List(Of MenuItem)()
            Using reader = command.ExecuteReader()
                While reader.Read()
                    items.Add(New MenuItem With {
                        .Id = Convert.ToInt32(reader("id")),
                        .CategoryId = If(reader("category_id") Is DBNull.Value, 0, Convert.ToInt32(reader("category_id"))),
                        .CategoryName = If(reader("category_name") Is DBNull.Value, "", reader("category_name").ToString()),
                        .Name = reader("name").ToString(),
                        .Description = reader("description").ToString(),
                        .Price = Convert.ToDecimal(reader("price")),
                        .ImagePath = If(reader("image_path") Is DBNull.Value, "", reader("image_path").ToString()),
                        .IsAvailable = Convert.ToBoolean(reader("is_available"))
                    })
                End While
            End Using
            Return items
        End Function

        Private Sub FillItemParameters(command As MySqlCommand, item As MenuItem)
            command.Parameters.AddWithValue("@catId", If(item.CategoryId = 0, DBNull.Value, item.CategoryId))
            command.Parameters.AddWithValue("@name", item.Name)
            command.Parameters.AddWithValue("@desc", item.Description)
            command.Parameters.AddWithValue("@price", item.Price)
            command.Parameters.AddWithValue("@img", item.ImagePath)
            command.Parameters.AddWithValue("@available", If(item.IsAvailable, 1, 0))
        End Sub
    End Class
End Namespace