Imports FoodOrderingSystem.Services

Partial Public Class AdminDashboardForm
    Public Sub New()
        InitializeComponent()
        SubtitleLabel.Text = "Logged in as " & If(Session.CurrentUser Is Nothing, "Admin", Session.CurrentUser.FullName)
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        Using form As New MenuManagementForm() : form.ShowDialog(Me) : End Using
    End Sub

    Private Sub CategoriesButton_Click(sender As Object, e As EventArgs) Handles CategoriesButton.Click
        Using form As New CategoryManagementForm() : form.ShowDialog(Me) : End Using
    End Sub

    Private Sub OrdersButton_Click(sender As Object, e As EventArgs) Handles OrdersButton.Click
        Using form As New OrderManagementForm() : form.ShowDialog(Me) : End Using
    End Sub

    Private Sub UsersButton_Click(sender As Object, e As EventArgs) Handles UsersButton.Click
        Using form As New UserManagementForm() : form.ShowDialog(Me) : End Using
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Close()
    End Sub
End Class