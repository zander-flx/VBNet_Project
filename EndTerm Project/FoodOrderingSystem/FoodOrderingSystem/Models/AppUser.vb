Namespace Models
    Public Class AppUser
        ' Unique ID for database primary key
        Public Property Id As Integer

        ' Full name of the employee/admin
        Public Property FullName As String

        ' Login username (must be unique)
        Public Property Username As String

        ' Encrypted password stored in DB
        Public Property PasswordHash As String

        ' Role determines permissions (admin, cashier, staff)
        Public Property Role As String

        ' True = Can login, False = Account Deactivated
        Public Property IsActive As Boolean
    End Class
End Namespace