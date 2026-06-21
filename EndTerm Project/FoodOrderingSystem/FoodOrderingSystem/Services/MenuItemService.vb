Imports FoodOrderingSystem.Repositories
Imports FoodOrderingSystem.Models

Namespace Services
    Public Class MenuItemService
        Private ReadOnly _repo As New MenuItemRepository()

        Public Function GetAll() As List(Of MenuItem)
            Return _repo.GetAll()
        End Function

        Public Function GetByCategory(categoryId As Integer) As List(Of MenuItem)
            Return _repo.GetByCategory(categoryId)
        End Function

        Public Function Search(term As String) As List(Of MenuItem)
            Return _repo.Search(term)
        End Function

        Public Sub Save(menuItem As MenuItem)
            ValidateMenuItem(menuItem)
            If menuItem.Id = 0 Then _repo.Add(menuItem) Else _repo.Update(menuItem)
        End Sub

        Public Sub SetAvailability(menuItemId As Integer, isAvailable As Boolean)
            _repo.SetAvailability(menuItemId, isAvailable)
        End Sub

        Private Sub ValidateMenuItem(menuItem As MenuItem)
            If String.IsNullOrWhiteSpace(menuItem.Name) Then
                Throw New ArgumentException("Item name is required.")
            End If
            If menuItem.Price < 0D Then
                Throw New ArgumentException("Price cannot be negative.")
            End If
        End Sub
    End Class
End Namespace