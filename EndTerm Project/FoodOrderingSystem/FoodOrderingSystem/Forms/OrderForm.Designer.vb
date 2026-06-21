<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.MenuGrid = New System.Windows.Forms.DataGridView()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.PlaceOrderButton = New System.Windows.Forms.Button()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CartGrid = New System.Windows.Forms.DataGridView()
        Me.QuantityPlusButton = New System.Windows.Forms.Button()
        Me.QuantityMinusButton = New System.Windows.Forms.Button()
        Me.OrderTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.TableNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.MenuGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(14, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(151, 26)
        Me.TitleLabel.TabIndex = 13
        Me.TitleLabel.Text = "Cashier POS"
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.Location = New System.Drawing.Point(16, 35)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(142, 17)
        Me.UserLabel.TabIndex = 14
        Me.UserLabel.Text = "Logged in as Cashier"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(11, 425)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(191, 17)
        Me.StatusLabel.TabIndex = 24
        Me.StatusLabel.Text = "Status message appear here"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(158, 62)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(300, 20)
        Me.SearchTextBox.TabIndex = 17
        '
        'MenuGrid
        '
        Me.MenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuGrid.Location = New System.Drawing.Point(12, 88)
        Me.MenuGrid.Name = "MenuGrid"
        Me.MenuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MenuGrid.Size = New System.Drawing.Size(446, 117)
        Me.MenuGrid.TabIndex = 18
        '
        'RemoveButton
        '
        Me.RemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.Location = New System.Drawing.Point(15, 381)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(101, 34)
        Me.RemoveButton.TabIndex = 19
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(127, 381)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(101, 34)
        Me.ClearButton.TabIndex = 20
        Me.ClearButton.Text = "Clear Cart"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(262, 383)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(124, 26)
        Me.TotalLabel.TabIndex = 21
        Me.TotalLabel.Text = "Total: 0.00"
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(556, 381)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(101, 34)
        Me.LogoutButton.TabIndex = 22
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'PlaceOrderButton
        '
        Me.PlaceOrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceOrderButton.Location = New System.Drawing.Point(449, 381)
        Me.PlaceOrderButton.Name = "PlaceOrderButton"
        Me.PlaceOrderButton.Size = New System.Drawing.Size(101, 34)
        Me.PlaceOrderButton.TabIndex = 23
        Me.PlaceOrderButton.Text = "Place Order"
        Me.PlaceOrderButton.UseVisualStyleBackColor = True
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(19, 61)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(133, 21)
        Me.CategoryComboBox.TabIndex = 25
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(15, 338)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 26
        Me.AddButton.Text = "Add to Cart"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CartGrid
        '
        Me.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartGrid.Location = New System.Drawing.Point(12, 211)
        Me.CartGrid.Name = "CartGrid"
        Me.CartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CartGrid.Size = New System.Drawing.Size(446, 119)
        Me.CartGrid.TabIndex = 27
        '
        'QuantityPlusButton
        '
        Me.QuantityPlusButton.Location = New System.Drawing.Point(250, 338)
        Me.QuantityPlusButton.Name = "QuantityPlusButton"
        Me.QuantityPlusButton.Size = New System.Drawing.Size(34, 23)
        Me.QuantityPlusButton.TabIndex = 28
        Me.QuantityPlusButton.Text = "+"
        Me.QuantityPlusButton.UseVisualStyleBackColor = True
        '
        'QuantityMinusButton
        '
        Me.QuantityMinusButton.Location = New System.Drawing.Point(210, 338)
        Me.QuantityMinusButton.Name = "QuantityMinusButton"
        Me.QuantityMinusButton.Size = New System.Drawing.Size(34, 23)
        Me.QuantityMinusButton.TabIndex = 29
        Me.QuantityMinusButton.Text = "-"
        Me.QuantityMinusButton.UseVisualStyleBackColor = True
        '
        'OrderTypeComboBox
        '
        Me.OrderTypeComboBox.FormattingEnabled = True
        Me.OrderTypeComboBox.Items.AddRange(New Object() {"Dine-in", "Takeout", "Delivery"})
        Me.OrderTypeComboBox.Location = New System.Drawing.Point(127, 338)
        Me.OrderTypeComboBox.Name = "OrderTypeComboBox"
        Me.OrderTypeComboBox.Size = New System.Drawing.Size(77, 21)
        Me.OrderTypeComboBox.TabIndex = 30
        '
        'TableNumberTextBox
        '
        Me.TableNumberTextBox.Location = New System.Drawing.Point(536, 170)
        Me.TableNumberTextBox.Name = "TableNumberTextBox"
        Me.TableNumberTextBox.Size = New System.Drawing.Size(44, 20)
        Me.TableNumberTextBox.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Table No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Customer"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(536, 200)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CustomerNameTextBox.TabIndex = 34
        '
        'CustomerPhoneTextBox
        '
        Me.CustomerPhoneTextBox.Location = New System.Drawing.Point(536, 236)
        Me.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox"
        Me.CustomerPhoneTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CustomerPhoneTextBox.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Phone Num."
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(536, 273)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AddressTextBox.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Address"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Location = New System.Drawing.Point(536, 310)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NotesTextBox.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Notes"
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 450)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CustomerPhoneTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableNumberTextBox)
        Me.Controls.Add(Me.OrderTypeComboBox)
        Me.Controls.Add(Me.QuantityMinusButton)
        Me.Controls.Add(Me.QuantityPlusButton)
        Me.Controls.Add(Me.CartGrid)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.PlaceOrderButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.MenuGrid)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        CType(Me.MenuGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents MenuGrid As DataGridView
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents PlaceOrderButton As Button
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents AddButton As Button
    Friend WithEvents CartGrid As DataGridView
    Friend WithEvents QuantityPlusButton As Button
    Friend WithEvents QuantityMinusButton As Button
    Friend WithEvents OrderTypeComboBox As ComboBox
    Friend WithEvents TableNumberTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents CustomerPhoneTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents Label5 As Label
End Class
