<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuManagementForm
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
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.MenuGrid = New System.Windows.Forms.DataGridView()
        Me.CategoryFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductsDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.AvailableCheckBox = New System.Windows.Forms.CheckBox()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeactivateButton = New System.Windows.Forms.Button()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PriceInput = New System.Windows.Forms.NumericUpDown()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NewButton = New System.Windows.Forms.Button()
        CType(Me.MenuGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsDetailsGroupBox.SuspendLayout()
        CType(Me.PriceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(12, 12)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(225, 20)
        Me.SearchTextBox.TabIndex = 0
        '
        'MenuGrid
        '
        Me.MenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuGrid.Location = New System.Drawing.Point(12, 48)
        Me.MenuGrid.Name = "MenuGrid"
        Me.MenuGrid.ReadOnly = True
        Me.MenuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MenuGrid.Size = New System.Drawing.Size(338, 330)
        Me.MenuGrid.TabIndex = 1
        '
        'CategoryFilterComboBox
        '
        Me.CategoryFilterComboBox.FormattingEnabled = True
        Me.CategoryFilterComboBox.Items.AddRange(New Object() {"All Categories", "Appetizers", "Beverages", "Desserts", "Main Dishes"})
        Me.CategoryFilterComboBox.Location = New System.Drawing.Point(243, 11)
        Me.CategoryFilterComboBox.Name = "CategoryFilterComboBox"
        Me.CategoryFilterComboBox.Size = New System.Drawing.Size(107, 21)
        Me.CategoryFilterComboBox.TabIndex = 2
        '
        'ProductsDetailsGroupBox
        '
        Me.ProductsDetailsGroupBox.Controls.Add(Me.NewButton)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.AvailableCheckBox)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.CategoryLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.CategoryComboBox)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.DescriptionTextBox)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.DescriptionLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.SaveButton)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.DeactivateButton)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.PriceLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.NameLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.PriceInput)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.NameTextBox)
        Me.ProductsDetailsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsDetailsGroupBox.Location = New System.Drawing.Point(356, 11)
        Me.ProductsDetailsGroupBox.Name = "ProductsDetailsGroupBox"
        Me.ProductsDetailsGroupBox.Size = New System.Drawing.Size(317, 367)
        Me.ProductsDetailsGroupBox.TabIndex = 6
        Me.ProductsDetailsGroupBox.TabStop = False
        Me.ProductsDetailsGroupBox.Text = "Menu Details"
        '
        'AvailableCheckBox
        '
        Me.AvailableCheckBox.AutoSize = True
        Me.AvailableCheckBox.Checked = True
        Me.AvailableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AvailableCheckBox.Location = New System.Drawing.Point(87, 256)
        Me.AvailableCheckBox.Name = "AvailableCheckBox"
        Me.AvailableCheckBox.Size = New System.Drawing.Size(84, 21)
        Me.AvailableCheckBox.TabIndex = 16
        Me.AvailableCheckBox.Text = "Available"
        Me.AvailableCheckBox.UseVisualStyleBackColor = True
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Location = New System.Drawing.Point(6, 146)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(65, 17)
        Me.CategoryLabel.TabIndex = 15
        Me.CategoryLabel.Text = "Category"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"All Categories"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(87, 139)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(224, 24)
        Me.CategoryComboBox.TabIndex = 14
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(87, 87)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(224, 23)
        Me.DescriptionTextBox.TabIndex = 13
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(6, 87)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(79, 17)
        Me.DescriptionLabel.TabIndex = 12
        Me.DescriptionLabel.Text = "Description"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(113, 331)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(85, 30)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DeactivateButton
        '
        Me.DeactivateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeactivateButton.Location = New System.Drawing.Point(226, 331)
        Me.DeactivateButton.Name = "DeactivateButton"
        Me.DeactivateButton.Size = New System.Drawing.Size(85, 30)
        Me.DeactivateButton.TabIndex = 10
        Me.DeactivateButton.Text = "Deactivate"
        Me.DeactivateButton.UseVisualStyleBackColor = True
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(6, 199)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(40, 17)
        Me.PriceLabel.TabIndex = 7
        Me.PriceLabel.Text = "Price"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 39)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Name"
        '
        'PriceInput
        '
        Me.PriceInput.DecimalPlaces = 2
        Me.PriceInput.Location = New System.Drawing.Point(87, 197)
        Me.PriceInput.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.PriceInput.Name = "PriceInput"
        Me.PriceInput.Size = New System.Drawing.Size(224, 23)
        Me.PriceInput.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(87, 33)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(224, 23)
        Me.NameTextBox.TabIndex = 1
        '
        'NewButton
        '
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton.Location = New System.Drawing.Point(9, 331)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(85, 30)
        Me.NewButton.TabIndex = 17
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'MenuManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 389)
        Me.Controls.Add(Me.ProductsDetailsGroupBox)
        Me.Controls.Add(Me.CategoryFilterComboBox)
        Me.Controls.Add(Me.MenuGrid)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Name = "MenuManagementForm"
        Me.Text = "MenuManagementForm"
        CType(Me.MenuGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsDetailsGroupBox.ResumeLayout(False)
        Me.ProductsDetailsGroupBox.PerformLayout()
        CType(Me.PriceInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents MenuGrid As DataGridView
    Friend WithEvents CategoryFilterComboBox As ComboBox
    Friend WithEvents ProductsDetailsGroupBox As GroupBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeactivateButton As Button
    Friend WithEvents PriceLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents PriceInput As NumericUpDown
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AvailableCheckBox As CheckBox
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents NewButton As Button
End Class
