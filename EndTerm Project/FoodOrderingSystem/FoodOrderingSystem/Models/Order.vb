Namespace Models
    Public Class Order
        Public Property Id As Integer
        Public Property OrderNumber As String
        Public Property CashierId As Integer
        Public Property OrderType As String ' dine-in, takeout, delivery
        Public Property TableNumber As String
        Public Property CustomerName As String
        Public Property CustomerPhone As String
        Public Property CustomerAddress As String
        Public Property TotalAmount As Decimal
        Public Property Status As String ' pending, preparing, ready, completed, cancelled
        Public Property Notes As String
        Public Property Items As List(Of OrderItem)
        Public Property CreatedAt As DateTime
    End Class
End Namespace