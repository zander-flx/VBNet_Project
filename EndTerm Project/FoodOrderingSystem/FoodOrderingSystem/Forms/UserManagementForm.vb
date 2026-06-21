Imports System.ComponentModel
Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Services

Partial Public Class UserManagementForm
    Private ReadOnly _service As New UserService()
    Private _selectedId As Integer = 0

    Public Sub New()
        InitializeComponent()
        LoadUsers()
    End Sub

    Private Sub LoadUsers(Optional term As String = "")
        Dim list = _service.GetAll()
        If Not String.IsNullOrWhiteSpace(term) Then
            list = list.Where(Function(u) u.FullName.ToLower().Contains(term.ToLower()) OrElse u.Username.ToLower().Contains(term.ToLower())).ToList()
        End If
        UsersGrid.DataSource = list
        UsersGrid.ClearSelection()
        ClearForm()
    End Sub

    Private Sub ClearForm()
        FullNameTextBox.Text = String.Empty
        UsernameTextBox.Text = String.Empty
        PasswordTextBox.Text = String.Empty
        RoleComboBox.SelectedIndex = 0
        ActiveCheckBox.Checked = True
        _selectedId = 0
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadUsers(SearchTextBox.Text)
    End Sub

    Private Sub UsersGrid_SelectionChanged(sender As Object, e As EventArgs) Handles UsersGrid.SelectionChanged
        If UsersGrid.CurrentRow Is Nothing OrElse UsersGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        Dim user = DirectCast(UsersGrid.CurrentRow.DataBoundItem, AppUser)
        _selectedId = user.Id
        FullNameTextBox.Text = user.FullName
        UsernameTextBox.Text = user.Username
        PasswordTextBox.Text = String.Empty ' Security: Never show hashed passwords
        RoleComboBox.SelectedItem = user.Role
        ActiveCheckBox.Checked = user.IsActive
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim role = If(RoleComboBox.SelectedItem Is Nothing, "cashier", RoleComboBox.SelectedItem.ToString())
            _service.Save(New AppUser With {
                .Id = _selectedId,
                .FullName = FullNameTextBox.Text.Trim(),
                .Username = UsernameTextBox.Text.Trim(),
                .role = role,
                .IsActive = ActiveCheckBox.Checked
            }, PasswordTextBox.Text.Trim())

            LoadUsers(SearchTextBox.Text)
            MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DeactivateButton_Click(sender As Object, e As EventArgs) Handles DeactivateButton.Click
        If _selectedId = 0 Then Return
        If MessageBox.Show("Deactivate this user account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _service.Deactivate(_selectedId)
            LoadUsers(SearchTextBox.Text)
        End If
    End Sub
End Class