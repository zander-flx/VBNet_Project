Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Repositories

Namespace Services
    Public Class OrderService
        Private ReadOnly _repo As New OrderRepository()

        Public Function SaveOrder(order As Order) As Integer
            ValidateOrder(order)
            order.OrderNumber = GenerateOrderNumber()
            Return _repo.Save(order)
        End Function

        Public Function GetOrder(orderId As Integer) As Order
            Return _repo.GetById(orderId)
        End Function

        Public Function GetAllOrders() As List(Of Order)
            Return _repo.GetAll()
        End Function

        Public Sub UpdateOrderStatus(orderId As Integer, status As String)
            _repo.UpdateStatus(orderId, status)
        End Sub

        Private Function GenerateOrderNumber() As String
            ' Format: ORD-20240619-001
            Return "ORD-" & DateTime.Now.ToString("yyyyMMdd") & "-" & _repo.GetTodayCount().ToString("D3")
        End Function

        Private Sub ValidateOrder(order As Order)
            If order.Items Is Nothing OrElse order.Items.Count = 0 Then
                Throw New ArgumentException("Order has no items.")
            End If
            If String.IsNullOrWhiteSpace(order.OrderType) Then
                Throw New ArgumentException("Order type is required.")
            End If
            If order.OrderType = "dine-in" AndAlso String.IsNullOrWhiteSpace(order.TableNumber) Then
                Throw New ArgumentException("Table number is required for dine-in.")
            End If
            If order.OrderType = "delivery" AndAlso String.IsNullOrWhiteSpace(order.CustomerAddress) Then
                Throw New ArgumentException("Delivery address is required.")
            End If
            If order.TotalAmount <= 0 Then
                Throw New ArgumentException("Total amount must be greater than zero.")
            End If
        End Sub
    End Class
End Namespace