Imports System.ComponentModel
Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Services

Partial Public Class OrderForm
    Private ReadOnly _cart As New BindingList(Of OrderItem)()
    Private ReadOnly _itemService As New MenuItemService()
    Private ReadOnly _catService As New CategoryService()
    Private ReadOnly _orderService As New OrderService()

    Public Sub New()
        InitializeComponent()

        ' Show cashier name
        UserLabel.Text = "Staff: " & If(Session.CurrentUser Is Nothing, "Guest", Session.CurrentUser.FullName)
        CartGrid.DataSource = _cart

        ' ✅ FIX: Set default selection to prevent Null Reference errors
        If OrderTypeComboBox.Items.Count > 0 Then
            OrderTypeComboBox.SelectedIndex = 0
        End If

        LoadCategories()
        LoadMenu()
    End Sub

    Private Sub LoadCategories()
        Dim cats = _catService.GetAll()
        cats.Insert(0, New Category With {.Id = 0, .Name = "All"})
        CategoryComboBox.DataSource = cats
        CategoryComboBox.DisplayMember = "Name"
        CategoryComboBox.ValueMember = "Id"
        CategoryComboBox.SelectedIndex = 0
    End Sub

    Private Sub LoadMenu()
        ' 1. Safely extract category ID (handles Nothing, DBNull, and init state)
        Dim catId As Integer = 0
        Dim selVal = CategoryComboBox.SelectedValue

        If selVal IsNot Nothing AndAlso TypeOf selVal Is Integer Then
            catId = CInt(selVal)
        End If

        ' 2. Fetch items (wrapped to prevent load-time crashes)
        Dim items As List(Of MenuItem) = Nothing
        Try
            items = If(catId = 0, _itemService.GetAll(), _itemService.GetByCategory(catId))
        Catch ex As Exception
            ' Silently ignore DB errors during form initialization
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
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        ' Prevents the event from running during form startup
        If CategoryComboBox.SelectedIndex < 0 Then Return

        LoadMenu()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadMenu()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If MenuGrid.CurrentRow Is Nothing OrElse MenuGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        AddToCart(DirectCast(MenuGrid.CurrentRow.DataBoundItem, MenuItem))
    End Sub

    Private Sub MenuGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MenuGrid.CellDoubleClick
        If e.RowIndex >= 0 AndAlso MenuGrid.Rows(e.RowIndex).DataBoundItem IsNot Nothing Then
            AddToCart(DirectCast(MenuGrid.Rows(e.RowIndex).DataBoundItem, MenuItem))
        End If
    End Sub

    Private Sub AddToCart(menuItem As MenuItem)
        If Not menuItem.IsAvailable Then
            MessageBox.Show("This item is currently unavailable.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim existing = _cart.FirstOrDefault(Function(c) c.MenuItemId = menuItem.Id)
        If existing Is Nothing Then
            _cart.Add(New OrderItem With {
                .MenuItemId = menuItem.Id,
                .ItemName = menuItem.Name,
                .Quantity = 1,
                .UnitPrice = menuItem.Price,
                .SpecialInstructions = ""
            })
        Else
            existing.Quantity += 1
            _cart.ResetBindings()
        End If
        RefreshTotal()
    End Sub

    Private Sub QuantityPlusButton_Click(sender As Object, e As EventArgs) Handles QuantityPlusButton.Click
        If CartGrid.CurrentRow Is Nothing OrElse CartGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        DirectCast(CartGrid.CurrentRow.DataBoundItem, OrderItem).Quantity += 1
        _cart.ResetBindings()
        RefreshTotal()
    End Sub

    Private Sub QuantityMinusButton_Click(sender As Object, e As EventArgs) Handles QuantityMinusButton.Click
        If CartGrid.CurrentRow Is Nothing OrElse CartGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        Dim item = DirectCast(CartGrid.CurrentRow.DataBoundItem, OrderItem)
        If item.Quantity > 1 Then
            item.Quantity -= 1
        Else
            _cart.Remove(item)
        End If
        _cart.ResetBindings()
        RefreshTotal()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        If CartGrid.CurrentRow Is Nothing OrElse CartGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        _cart.Remove(DirectCast(CartGrid.CurrentRow.DataBoundItem, OrderItem))
        RefreshTotal()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        _cart.Clear()
        RefreshTotal()
    End Sub

    Private Sub RefreshTotal()
        TotalLabel.Text = "Total: " & _cart.Sum(Function(i) i.LineTotal).ToString("C2")
    End Sub

    Private Sub OrderTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrderTypeComboBox.SelectedIndexChanged
        ' ✅ FIX: Stop if nothing is selected
        If OrderTypeComboBox.SelectedItem Is Nothing Then Return

        Dim type = OrderTypeComboBox.SelectedItem.ToString()

        ' Show/Hide fields based on type
        TableNumberTextBox.Enabled = (type = "Dine-in")
        AddressTextBox.Enabled = (type = "Delivery")

        ' Clear fields if they become disabled
        If Not TableNumberTextBox.Enabled Then TableNumberTextBox.Clear()
        If Not AddressTextBox.Enabled Then AddressTextBox.Clear()
    End Sub

    Private Sub PlaceOrderButton_Click(sender As Object, e As EventArgs) Handles PlaceOrderButton.Click
        Try
            ' 1. Check if Cart is empty
            If _cart Is Nothing OrElse _cart.Count = 0 Then
                MessageBox.Show("Cart is empty.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' 2. Check if User is logged in
            If Session.CurrentUser Is Nothing Then
                MessageBox.Show("Session expired. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If

            ' 3. ✅ FIX: Check if Order Type is selected
            If OrderTypeComboBox.SelectedItem Is Nothing Then
                MessageBox.Show("Please select an Order Type (Dine-in, Takeout, Delivery).", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim orderType As String = OrderTypeComboBox.SelectedItem.ToString().ToLower()

            ' Create Order object
            Dim order As New Order With {
                .CashierId = Session.CurrentUser.Id,
                .OrderType = orderType,
                .TableNumber = If(orderType = "dine-in", TableNumberTextBox.Text.Trim(), ""),
                .CustomerName = CustomerNameTextBox.Text.Trim(),
                .CustomerPhone = CustomerPhoneTextBox.Text.Trim(),
                .CustomerAddress = If(orderType = "delivery", AddressTextBox.Text.Trim(), ""),
                .TotalAmount = _cart.Sum(Function(i) i.LineTotal),
                .Status = "pending",
                .Notes = NotesTextBox.Text.Trim(),
                .Items = _cart.ToList()
            }

            Dim id = _orderService.SaveOrder(order)
            MessageBox.Show($"Order Placed Successfully!{vbCrLf}Order No: {order.OrderNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset Form
            _cart.Clear()
            CustomerNameTextBox.Clear()
            CustomerPhoneTextBox.Clear()
            TableNumberTextBox.Clear()
            AddressTextBox.Clear()
            NotesTextBox.Clear()
            ' Reset ComboBox to default
            OrderTypeComboBox.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Close()
    End Sub
End Class