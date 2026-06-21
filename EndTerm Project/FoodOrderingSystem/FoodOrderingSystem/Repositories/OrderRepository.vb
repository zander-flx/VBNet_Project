Imports FoodOrderingSystem.Data
Imports FoodOrderingSystem.Models
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class OrderRepository
        Private ReadOnly _factory As New DbConnectionFactory()

        Public Function Save(order As Order) As Integer
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using transaction = connection.BeginTransaction()
                    Try
                        ' 1. Save Order Header
                        Using cmd As New MySqlCommand("INSERT INTO orders(order_number, cashier_id, order_type, table_number, customer_name, customer_phone, customer_address, total_amount, status, notes) VALUES(@orderNum,@cashierId,@type,@table,@custName,@custPhone,@custAddr,@total,@status,@notes); SELECT LAST_INSERT_ID();", connection, transaction)
                            cmd.Parameters.AddWithValue("@orderNum", order.OrderNumber)
                            cmd.Parameters.AddWithValue("@cashierId", order.CashierId)
                            cmd.Parameters.AddWithValue("@type", order.OrderType)
                            cmd.Parameters.AddWithValue("@table", If(String.IsNullOrWhiteSpace(order.TableNumber), DBNull.Value, order.TableNumber))
                            cmd.Parameters.AddWithValue("@custName", If(String.IsNullOrWhiteSpace(order.CustomerName), DBNull.Value, order.CustomerName))
                            cmd.Parameters.AddWithValue("@custPhone", If(String.IsNullOrWhiteSpace(order.CustomerPhone), DBNull.Value, order.CustomerPhone))
                            cmd.Parameters.AddWithValue("@custAddr", If(String.IsNullOrWhiteSpace(order.CustomerAddress), DBNull.Value, order.CustomerAddress))
                            cmd.Parameters.AddWithValue("@total", order.TotalAmount)
                            cmd.Parameters.AddWithValue("@status", order.Status)
                            cmd.Parameters.AddWithValue("@notes", If(String.IsNullOrWhiteSpace(order.Notes), DBNull.Value, order.Notes))
                            order.Id = Convert.ToInt32(cmd.ExecuteScalar())
                        End Using

                        ' 2. Save Order Items
                        For Each item In order.Items
                            Using itemCmd As New MySqlCommand("INSERT INTO order_items(order_id, menu_item_id, item_name, quantity, unit_price, line_total, special_instructions) VALUES(@orderId,@menuId,@itemName,@qty,@price,@lineTotal,@instr)", connection, transaction)
                                itemCmd.Parameters.AddWithValue("@orderId", order.Id)
                                itemCmd.Parameters.AddWithValue("@menuId", item.MenuItemId)
                                itemCmd.Parameters.AddWithValue("@itemName", item.ItemName)
                                itemCmd.Parameters.AddWithValue("@qty", item.Quantity)
                                itemCmd.Parameters.AddWithValue("@price", item.UnitPrice)
                                itemCmd.Parameters.AddWithValue("@lineTotal", item.LineTotal)
                                itemCmd.Parameters.AddWithValue("@instr", If(String.IsNullOrWhiteSpace(item.SpecialInstructions), DBNull.Value, item.SpecialInstructions))
                                itemCmd.ExecuteNonQuery()
                            End Using
                        Next

                        transaction.Commit()
                        Return order.Id
                    Catch ex As Exception
                        transaction.Rollback()
                        Throw New Exception("Failed to save order: " & ex.Message)
                    End Try
                End Using
            End Using
        End Function

        Public Function GetById(orderId As Integer) As Order
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using cmd As New MySqlCommand("SELECT id, order_number, cashier_id, order_type, table_number, customer_name, customer_phone, customer_address, total_amount, status, notes, created_at FROM orders WHERE id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", orderId)
                    Using reader = cmd.ExecuteReader()
                        If Not reader.Read() Then Return Nothing
                        Dim order As New Order With {
                            .Id = reader.GetInt32("id"),
                            .OrderNumber = reader.GetString("order_number"),
                            .CashierId = reader.GetInt32("cashier_id"),
                            .OrderType = reader.GetString("order_type"),
                            .TableNumber = If(reader.IsDBNull(reader.GetOrdinal("table_number")), "", reader.GetString("table_number")),
                            .CustomerName = If(reader.IsDBNull(reader.GetOrdinal("customer_name")), "", reader.GetString("customer_name")),
                            .CustomerPhone = If(reader.IsDBNull(reader.GetOrdinal("customer_phone")), "", reader.GetString("customer_phone")),
                            .CustomerAddress = If(reader.IsDBNull(reader.GetOrdinal("customer_address")), "", reader.GetString("customer_address")),
                            .TotalAmount = reader.GetDecimal("total_amount"),
                            .Status = reader.GetString("status"),
                            .Notes = If(reader.IsDBNull(reader.GetOrdinal("notes")), "", reader.GetString("notes")),
                            .CreatedAt = reader.GetDateTime("created_at"),
                            .Items = New List(Of OrderItem)()
                        }

                        ' Load items
                        Using itemCmd As New MySqlCommand("SELECT menu_item_id, item_name, quantity, unit_price, line_total, special_instructions FROM order_items WHERE order_id=@orderId", connection)
                            itemCmd.Parameters.AddWithValue("@orderId", orderId)
                            Using itemReader = itemCmd.ExecuteReader()
                                While itemReader.Read()
                                    order.Items.Add(New OrderItem With {
                                        .MenuItemId = itemReader.GetInt32("menu_item_id"),
                                        .ItemName = itemReader.GetString("item_name"),
                                        .Quantity = itemReader.GetInt32("quantity"),
                                        .UnitPrice = itemReader.GetDecimal("unit_price"),
                                        .SpecialInstructions = If(itemReader.IsDBNull(itemReader.GetOrdinal("special_instructions")), "", itemReader.GetString("special_instructions"))
                                    })
                                End While
                            End Using
                        End Using
                        Return order
                    End Using
                End Using
            End Using
        End Function

        Public Function GetAll() As List(Of Order)
            Dim orders As New List(Of Order)()
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using cmd As New MySqlCommand("SELECT id, order_number, cashier_id, order_type, table_number, customer_name, total_amount, status, created_at FROM orders ORDER BY created_at DESC", connection)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            orders.Add(New Order With {
                                .Id = reader.GetInt32("id"),
                                .OrderNumber = reader.GetString("order_number"),
                                .CashierId = reader.GetInt32("cashier_id"),
                                .OrderType = reader.GetString("order_type"),
                                .TableNumber = If(reader.IsDBNull(reader.GetOrdinal("table_number")), "", reader.GetString("table_number")),
                                .CustomerName = If(reader.IsDBNull(reader.GetOrdinal("customer_name")), "", reader.GetString("customer_name")),
                                .TotalAmount = reader.GetDecimal("total_amount"),
                                .Status = reader.GetString("status"),
                                .CreatedAt = reader.GetDateTime("created_at")
                            })
                        End While
                    End Using
                End Using
            End Using
            Return orders
        End Function

        Public Function GetTodayCount() As Integer
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM orders WHERE DATE(created_at) = CURDATE()", connection)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        End Function

        Public Sub UpdateStatus(orderId As Integer, status As String)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using cmd As New MySqlCommand("UPDATE orders SET status=@status WHERE id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", orderId)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub
    End Class
End Namespace