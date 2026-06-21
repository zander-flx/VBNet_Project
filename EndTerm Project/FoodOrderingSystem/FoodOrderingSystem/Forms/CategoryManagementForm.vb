Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Services

Partial Public Class CategoryManagementForm
    Private ReadOnly _service As New CategoryService()
    Private _selectedId As Integer = 0

    Public Sub New()
        InitializeComponent()
        LoadCategories()
    End Sub

    Private Sub LoadCategories(Optional term As String = "")
        Dim list = _service.GetAll()
        If Not String.IsNullOrWhiteSpace(term) Then
            list = list.Where(Function(c) c.Name.ToLower().Contains(term.ToLower())).ToList()
        End If
        CategoriesGrid.DataSource = list
        CategoriesGrid.ClearSelection()
        ClearForm()
    End Sub

    Private Sub ClearForm()
        NameTextBox.Text = String.Empty
        DescriptionTextBox.Text = String.Empty
        ActiveCheckBox.Checked = True
        _selectedId = 0
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadCategories(SearchTextBox.Text)
    End Sub

    Private Sub CategoriesGrid_SelectionChanged(sender As Object, e As EventArgs) Handles CategoriesGrid.SelectionChanged
        If CategoriesGrid.CurrentRow Is Nothing OrElse CategoriesGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        Dim cat = DirectCast(CategoriesGrid.CurrentRow.DataBoundItem, Category)
        _selectedId = cat.Id
        NameTextBox.Text = cat.Name
        DescriptionTextBox.Text = cat.Description
        ActiveCheckBox.Checked = cat.IsActive
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            _service.Save(New Category With {
                .Id = _selectedId,
                .Name = NameTextBox.Text.Trim(),
                .Description = DescriptionTextBox.Text.Trim(),
                .IsActive = ActiveCheckBox.Checked
            })
            LoadCategories(SearchTextBox.Text)
            MessageBox.Show("Category saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DeactivateButton_Click(sender As Object, e As EventArgs) Handles DeactivateButton.Click
        If _selectedId = 0 Then Return
        If MessageBox.Show("Deactivate this category?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _service.Deactivate(_selectedId)
            LoadCategories(SearchTextBox.Text)
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        ClearForm()
        CategoriesGrid.ClearSelection()
        SearchTextBox.Focus()
    End Sub
End Class