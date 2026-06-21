Imports FoodOrderingSystem.Repositories
Imports FoodOrderingSystem.Models

Namespace Services
    Public Class UserService
        Private ReadOnly _users As New UserRepository()
        Private ReadOnly _hasher As New PasswordHasher()

        Public Function GetAll() As List(Of AppUser)
            Return _users.GetAll()
        End Function

        Public Sub Save(user As AppUser, plainPassword As String)
            ValidateUser(user, plainPassword)
            Dim shouldUpdatePassword = Not String.IsNullOrWhiteSpace(plainPassword)
            If shouldUpdatePassword Then user.PasswordHash = _hasher.HashPassword(plainPassword)

            If user.Id = 0 Then _users.Add(user) Else _users.Update(user, shouldUpdatePassword)
        End Sub

        Public Sub Deactivate(userId As Integer)
            _users.Deactivate(userId)
        End Sub

        Private Sub ValidateUser(user As AppUser, plainPassword As String)
            If String.IsNullOrWhiteSpace(user.FullName) Then Throw New ArgumentException("Full name is required.")
            If String.IsNullOrWhiteSpace(user.Username) Then Throw New ArgumentException("Username is required.")
            If user.Id = 0 AndAlso String.IsNullOrWhiteSpace(plainPassword) Then Throw New ArgumentException("Password is required for new users.")
            If user.Role <> "admin" AndAlso user.Role <> "cashier" AndAlso user.Role <> "staff" Then
                Throw New ArgumentException("Role must be admin, cashier, or staff.")
            End If
        End Sub
    End Class
End Namespace