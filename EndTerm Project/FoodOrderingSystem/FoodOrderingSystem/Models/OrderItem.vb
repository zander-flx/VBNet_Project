Namespace Models
    Public Class OrderItem
        Public Property MenuItemId As Integer
        Public Property ItemName As String
        Public Property Quantity As Integer
        Public Property UnitPrice As Decimal
        Public Property SpecialInstructions As String

        Public ReadOnly Property LineTotal As Decimal
            Get
                Return Quantity * UnitPrice
            End Get
        End Property
    End Class
End Namespace