Imports FoodOrderingSystem.Repositories
Imports FoodOrderingSystem.Models

Namespace Services
    Public Class AuthService
        Private ReadOnly _users As New UserRepository()
        Private ReadOnly _hasher As New PasswordHasher()

        Public Function Login(username As String, password As String) As AppUser
            Dim user = _users.FindByUsername(username.Trim())
            If user Is Nothing OrElse Not user.IsActive Then Return Nothing
            If user.PasswordHash <> _hasher.HashPassword(password) Then Return Nothing
            Return user
        End Function
    End Class
End Namespace