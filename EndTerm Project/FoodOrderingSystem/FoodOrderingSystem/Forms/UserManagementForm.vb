Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Services

Partial Public Class UserManagementForm
    Private ReadOnly _service As New UserService()
    Private _selectedId As Integer = 0

    Public Sub New()
        InitializeComponent()
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        UsersGrid.DataSource = Nothing
        UsersGrid.DataSource = _service.GetAll()
        UsersGrid.ClearSelection()
        ClearForm()
    End Sub

    Private Sub ClearForm()
        FullNameTextBox.Text = String.Empty
        UsernameTextBox.Text = String.Empty
        PasswordTextBox.Text = String.Empty
        ' Ensure "cashier" exists in your ComboBox Items in Designer
        RoleComboBox.SelectedItem = "cashier"
        ActiveCheckBox.Checked = True
        _selectedId = 0
    End Sub

    Private Sub UsersGrid_SelectionChanged(sender As Object, e As EventArgs) Handles UsersGrid.SelectionChanged
        If UsersGrid.SelectedRows.Count = 0 OrElse UsersGrid.CurrentRow Is Nothing OrElse
            UsersGrid.CurrentRow.DataBoundItem Is Nothing Then
            Return
        End If

        Dim user = DirectCast(UsersGrid.CurrentRow.DataBoundItem, AppUser)
        _selectedId = user.Id
        FullNameTextBox.Text = user.FullName
        UsernameTextBox.Text = user.Username
        PasswordTextBox.Text = String.Empty ' Security: Never show existing hash
        RoleComboBox.SelectedItem = user.Role
        ActiveCheckBox.Checked = user.IsActive
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            ' 1. Get the selected role safely
            Dim role As String = "cashier"
            If RoleComboBox.SelectedItem IsNot Nothing Then
                role = RoleComboBox.SelectedItem.ToString()
            End If

            ' 2. Create the User Object (No validation here, let Service do it)
            Dim user As New AppUser With {
                .Id = _selectedId,
                .FullName = FullNameTextBox.Text.Trim(),
                .Username = UsernameTextBox.Text.Trim(),
                .Role = role, ' Fixed: Capital R
                .IsActive = ActiveCheckBox.Checked
            }

            ' 3. Pass the plain password to the Service. 
            ' The Service will hash it if it's not empty, or keep the old one if it is.
            _service.Save(user, PasswordTextBox.Text.Trim())

            LoadUsers()
            MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DeactivateButton_Click(sender As Object, e As EventArgs) Handles DeactivateButton.Click
        If _selectedId = 0 Then Return
        If MessageBox.Show("Deactivate this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _service.Deactivate(_selectedId)
            LoadUsers()
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        ClearForm()
        UsersGrid.ClearSelection()
        FullNameTextBox.Focus() ' Better UX: Focus on first input field
    End Sub
End Class