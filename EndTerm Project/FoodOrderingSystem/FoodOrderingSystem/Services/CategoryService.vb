Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Repositories

Namespace Services
    Public Class CategoryService
        Private ReadOnly _repo As New CategoryRepository()

        Public Function GetAll() As List(Of Category)
            Return _repo.GetAll()
        End Function

        Public Sub Save(category As Category)
            ValidateCategory(category)
            If category.Id = 0 Then _repo.Add(category) Else _repo.Update(category)
        End Sub

        Public Sub Deactivate(categoryId As Integer)
            _repo.Deactivate(categoryId)
        End Sub

        Private Sub ValidateCategory(category As Category)
            If String.IsNullOrWhiteSpace(category.Name) Then
                Throw New ArgumentException("Category name is required.")
            End If
        End Sub
    End Class
End Namespace