Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Services
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Services

Partial Public Class OrderManagementForm
    Private ReadOnly _orderService As New OrderService()
    Private _selectedOrderId As Integer = 0

    Public Sub New()
        InitializeComponent()

        ' 1. CRITICAL SAFETY CHECK
        ' If you haven't added "All", "Pending", etc. in the Designer, 
        ' this prevents a crash and shows you a warning.
        If StatusFilterComboBox.Items.Count = 0 Then
            MessageBox.Show("⚠️ DESIGNER ERROR: 'StatusFilterComboBox' has no items!" & vbCrLf &
                            "Please add 'All', 'Pending', 'Preparing', 'Ready', 'Completed', 'Cancelled' in the Properties window.",
                            "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Set default selection safely
        StatusFilterComboBox.SelectedIndex = 0

        ' 2. Load data safely
        LoadOrders()
    End Sub

    Private Sub LoadOrders()
        Try
            ' Safety check: Ensure an item is actually selected
            If StatusFilterComboBox.SelectedItem Is Nothing Then Return

            Dim filter = StatusFilterComboBox.SelectedItem.ToString()

            ' Fetch all orders from the database
            Dim orders = _orderService.GetAllOrders()

            ' Apply filter if user didn't select "All"
            If filter <> "All" Then
                orders = orders.Where(Function(o) o.Status = filter).ToList()
            End If

            ' Bind to grid (handle empty list gracefully)
            If orders.Count > 0 Then
                OrdersGrid.DataSource = orders.OrderByDescending(Function(o) o.CreatedAt).ToList()
            Else
                OrdersGrid.DataSource = New List(Of Order)()
            End If

            OrdersGrid.ClearSelection()
            ClearDetails()

        Catch ex As Exception
            ' 3. SHOW EXACT ERROR
            ' This tells you if it's a Database issue (e.g., Table not found)
            MessageBox.Show("❌ Error loading orders: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearDetails()
        OrderNumberLabel.Text = "-"
        CustomerInfoLabel.Text = "-"
        TotalLabel.Text = "-"
        OrderStatusComboBox.SelectedIndex = -1
        _selectedOrderId = 0
    End Sub

    Private Sub StatusFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusFilterComboBox.SelectedIndexChanged
        LoadOrders()
    End Sub

    Private Sub OrdersGrid_SelectionChanged(sender As Object, e As EventArgs) Handles OrdersGrid.SelectionChanged
        If OrdersGrid.CurrentRow Is Nothing OrElse OrdersGrid.CurrentRow.DataBoundItem Is Nothing Then Return

        Dim order = DirectCast(OrdersGrid.CurrentRow.DataBoundItem, Order)
        _selectedOrderId = order.Id

        OrderNumberLabel.Text = order.OrderNumber
        CustomerInfoLabel.Text = $"{order.CustomerName} | {order.OrderType.ToUpper()} | Table: {If(String.IsNullOrWhiteSpace(order.TableNumber), "N/A", order.TableNumber)}"
        TotalLabel.Text = order.TotalAmount.ToString("C2")

        ' Set the status dropdown to match the selected order
        OrderStatusComboBox.SelectedItem = order.Status
    End Sub

    Private Sub UpdateStatusButton_Click(sender As Object, e As EventArgs) Handles UpdateStatusButton.Click
        If _selectedOrderId = 0 OrElse OrderStatusComboBox.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an order and a new status.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim newStatus = OrderStatusComboBox.SelectedItem.ToString()
            _orderService.UpdateOrderStatus(_selectedOrderId, newStatus)
            LoadOrders() ' Refresh the list
            MessageBox.Show("✅ Order status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("❌ Error updating status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewItemsButton_Click(sender As Object, e As EventArgs) Handles ViewItemsButton.Click
        If _selectedOrderId = 0 Then Return

        Try
            Dim order = _orderService.GetOrder(_selectedOrderId)
            If order Is Nothing Then Return

            Dim itemsText = String.Join(vbCrLf, order.Items.Select(Function(i) $"  {i.Quantity}x {i.ItemName} - {i.LineTotal:C2}"))

            MessageBox.Show($"Order: {order.OrderNumber}{vbCrLf}Type: {order.OrderType.ToUpper()}{vbCrLf}{vbCrLf}Items:{vbCrLf}{itemsText}{vbCrLf}{vbCrLf}Total: {order.TotalAmount:C2}",
                            "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("❌ Error viewing items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class