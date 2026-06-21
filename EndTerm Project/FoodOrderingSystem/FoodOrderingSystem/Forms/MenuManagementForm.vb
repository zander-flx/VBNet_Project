Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Services

Partial Public Class MenuManagementForm
    Private ReadOnly _itemService As New MenuItemService()
    Private ReadOnly _catService As New CategoryService()
    Private _selectedId As Integer = 0

    Public Sub New()
        InitializeComponent()
        Try
            LoadCategories()
            LoadMenuItems()
        Catch ex As Exception
            MessageBox.Show("Form Init Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadCategories()
        Dim cats = _catService.GetAll()
        cats.Insert(0, New Category With {.Id = 0, .Name = "All Categories"})
        CategoryFilterComboBox.DataSource = cats
        CategoryFilterComboBox.DisplayMember = "Name"
        CategoryFilterComboBox.ValueMember = "Id"
        CategoryFilterComboBox.SelectedIndex = 0

        CategoryComboBox.DataSource = _catService.GetAll()
        CategoryComboBox.DisplayMember = "Name"
        CategoryComboBox.ValueMember = "Id"
    End Sub

    Private Sub ClearForm()
        NameTextBox.Text = String.Empty
        DescriptionTextBox.Text = String.Empty
        PriceInput.Value = 0
        AvailableCheckBox.Checked = True
        _selectedId = 0

        ' Use SelectedIndex instead of SelectedValue to avoid binding exceptions
        If CategoryComboBox.Items.Count > 0 Then
            CategoryComboBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadMenuItems()
    End Sub

    Private Sub CategoryFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryFilterComboBox.SelectedIndexChanged
        If CategoryFilterComboBox.SelectedIndex < 0 Then Return
        Try
            LoadMenuItems()
        Catch ex As Exception
            MessageBox.Show("Filter Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadMenuItems()
        ' 1. Safely extract category ID (handles Nothing, DBNull, and binding quirks)
        Dim catId As Integer = 0
        Dim selVal = CategoryFilterComboBox.SelectedValue

        If selVal IsNot Nothing AndAlso TypeOf selVal Is Integer Then
            catId = CInt(selVal)
        End If

        ' 2. Fetch items safely
        Dim items As List(Of MenuItem) = Nothing
        Try
            items = If(catId = 0, _itemService.GetAll(), _itemService.GetByCategory(catId))
        Catch ex As Exception
            ' Prevents form from closing on temporary DB/binding glitches
            items = New List(Of MenuItem)()
        End Try

        ' 3. Guarantee list is never Nothing
        If items Is Nothing Then items = New List(Of MenuItem)()

        ' 4. Apply search filter if user typed something
        If Not String.IsNullOrWhiteSpace(SearchTextBox.Text) Then
            items = items.Where(Function(i) i.Name.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList()
        End If

        ' 5. Bind to grid
        MenuGrid.DataSource = items
        MenuGrid.ClearSelection()
        ClearForm()
    End Sub

    Private Sub MenuGrid_SelectionChanged(sender As Object, e As EventArgs) Handles MenuGrid.SelectionChanged
        If MenuGrid.CurrentRow Is Nothing OrElse MenuGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        Dim item = DirectCast(MenuGrid.CurrentRow.DataBoundItem, MenuItem)
        _selectedId = item.Id
        NameTextBox.Text = item.Name
        DescriptionTextBox.Text = item.Description
        CategoryComboBox.SelectedValue = item.CategoryId
        PriceInput.Value = item.Price
        AvailableCheckBox.Checked = item.IsAvailable
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            _itemService.Save(New MenuItem With {
                .Id = _selectedId,
                .Name = NameTextBox.Text.Trim(),
                .Description = DescriptionTextBox.Text.Trim(),
                .CategoryId = If(CategoryComboBox.SelectedValue, 0),
                .Price = PriceInput.Value,
                .IsAvailable = AvailableCheckBox.Checked
            })
            LoadMenuItems()
            MessageBox.Show("Menu item saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DeactivateButton_Click(sender As Object, e As EventArgs) Handles DeactivateButton.Click
        If _selectedId = 0 Then Return
        If MessageBox.Show("Mark this item as unavailable?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _itemService.SetAvailability(_selectedId, False)
            LoadMenuItems()
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        ClearForm()
        MenuGrid.ClearSelection()
        SearchTextBox.Focus()
    End Sub
End Class