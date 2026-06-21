<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.OrdersGrid = New System.Windows.Forms.DataGridView()
        Me.ProductsDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OrderStatusLabel = New System.Windows.Forms.Label()
        Me.OrderStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.UpdateStatusButton = New System.Windows.Forms.Button()
        Me.ViewItemsButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.CustomerInfoLabel = New System.Windows.Forms.Label()
        Me.OrderNumberLabel = New System.Windows.Forms.Label()
        CType(Me.OrdersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsDetailsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusFilterComboBox
        '
        Me.StatusFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusFilterComboBox.FormattingEnabled = True
        Me.StatusFilterComboBox.Items.AddRange(New Object() {"All", "Pending", "Preparing", "Ready", "Completed", "Cancelled"})
        Me.StatusFilterComboBox.Location = New System.Drawing.Point(118, 51)
        Me.StatusFilterComboBox.Name = "StatusFilterComboBox"
        Me.StatusFilterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StatusFilterComboBox.TabIndex = 0
        '
        'OrdersGrid
        '
        Me.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdersGrid.Location = New System.Drawing.Point(81, 141)
        Me.OrdersGrid.Name = "OrdersGrid"
        Me.OrdersGrid.ReadOnly = True
        Me.OrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrdersGrid.Size = New System.Drawing.Size(240, 150)
        Me.OrdersGrid.TabIndex = 1
        '
        'ProductsDetailsGroupBox
        '
        Me.ProductsDetailsGroupBox.Controls.Add(Me.OrderStatusLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.OrderStatusComboBox)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.UpdateStatusButton)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.ViewItemsButton)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.TotalLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.CustomerInfoLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.OrderNumberLabel)
        Me.ProductsDetailsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsDetailsGroupBox.Location = New System.Drawing.Point(353, 39)
        Me.ProductsDetailsGroupBox.Name = "ProductsDetailsGroupBox"
        Me.ProductsDetailsGroupBox.Size = New System.Drawing.Size(317, 399)
        Me.ProductsDetailsGroupBox.TabIndex = 6
        Me.ProductsDetailsGroupBox.TabStop = False
        Me.ProductsDetailsGroupBox.Text = "Order Details"
        '
        'OrderStatusLabel
        '
        Me.OrderStatusLabel.AutoSize = True
        Me.OrderStatusLabel.Location = New System.Drawing.Point(6, 38)
        Me.OrderStatusLabel.Name = "OrderStatusLabel"
        Me.OrderStatusLabel.Size = New System.Drawing.Size(89, 17)
        Me.OrderStatusLabel.TabIndex = 13
        Me.OrderStatusLabel.Text = "Order Status"
        '
        'OrderStatusComboBox
        '
        Me.OrderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrderStatusComboBox.FormattingEnabled = True
        Me.OrderStatusComboBox.Items.AddRange(New Object() {"All", "Pending", "Preparing", "Ready", "Completed", "Cancelled"})
        Me.OrderStatusComboBox.Location = New System.Drawing.Point(101, 38)
        Me.OrderStatusComboBox.Name = "OrderStatusComboBox"
        Me.OrderStatusComboBox.Size = New System.Drawing.Size(210, 24)
        Me.OrderStatusComboBox.TabIndex = 12
        '
        'UpdateStatusButton
        '
        Me.UpdateStatusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateStatusButton.Location = New System.Drawing.Point(101, 336)
        Me.UpdateStatusButton.Name = "UpdateStatusButton"
        Me.UpdateStatusButton.Size = New System.Drawing.Size(85, 30)
        Me.UpdateStatusButton.TabIndex = 11
        Me.UpdateStatusButton.Text = "Update"
        Me.UpdateStatusButton.UseVisualStyleBackColor = True
        '
        'ViewItemsButton
        '
        Me.ViewItemsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewItemsButton.Location = New System.Drawing.Point(211, 336)
        Me.ViewItemsButton.Name = "ViewItemsButton"
        Me.ViewItemsButton.Size = New System.Drawing.Size(85, 30)
        Me.ViewItemsButton.TabIndex = 10
        Me.ViewItemsButton.Text = "View Items"
        Me.ViewItemsButton.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(6, 205)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(20, 17)
        Me.TotalLabel.TabIndex = 8
        Me.TotalLabel.Text = "..."
        '
        'CustomerInfoLabel
        '
        Me.CustomerInfoLabel.AutoSize = True
        Me.CustomerInfoLabel.Location = New System.Drawing.Point(6, 150)
        Me.CustomerInfoLabel.Name = "CustomerInfoLabel"
        Me.CustomerInfoLabel.Size = New System.Drawing.Size(20, 17)
        Me.CustomerInfoLabel.TabIndex = 7
        Me.CustomerInfoLabel.Text = "..."
        '
        'OrderNumberLabel
        '
        Me.OrderNumberLabel.AutoSize = True
        Me.OrderNumberLabel.Location = New System.Drawing.Point(6, 96)
        Me.OrderNumberLabel.Name = "OrderNumberLabel"
        Me.OrderNumberLabel.Size = New System.Drawing.Size(20, 17)
        Me.OrderNumberLabel.TabIndex = 6
        Me.OrderNumberLabel.Text = "..."
        '
        'OrderManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProductsDetailsGroupBox)
        Me.Controls.Add(Me.OrdersGrid)
        Me.Controls.Add(Me.StatusFilterComboBox)
        Me.Name = "OrderManagementForm"
        Me.Text = "OrderManagementForm"
        CType(Me.OrdersGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsDetailsGroupBox.ResumeLayout(False)
        Me.ProductsDetailsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StatusFilterComboBox As ComboBox
    Friend WithEvents OrdersGrid As DataGridView
    Friend WithEvents ProductsDetailsGroupBox As GroupBox
    Friend WithEvents UpdateStatusButton As Button
    Friend WithEvents ViewItemsButton As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents CustomerInfoLabel As Label
    Friend WithEvents OrderNumberLabel As Label
    Friend WithEvents OrderStatusLabel As Label
    Friend WithEvents OrderStatusComboBox As ComboBox
End Class
