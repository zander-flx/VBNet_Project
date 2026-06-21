<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryManagementForm
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
        Me.CategoriesGrid = New System.Windows.Forms.DataGridView()
        Me.UserDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeactivateButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.FullNameLabel = New System.Windows.Forms.Label()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        CType(Me.CategoriesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDetailsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(12, 15)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(307, 20)
        Me.SearchTextBox.TabIndex = 0
        '
        'CategoriesGrid
        '
        Me.CategoriesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CategoriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoriesGrid.Location = New System.Drawing.Point(12, 41)
        Me.CategoriesGrid.Name = "CategoriesGrid"
        Me.CategoriesGrid.ReadOnly = True
        Me.CategoriesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoriesGrid.Size = New System.Drawing.Size(307, 353)
        Me.CategoriesGrid.TabIndex = 1
        '
        'UserDetailsGroupBox
        '
        Me.UserDetailsGroupBox.Controls.Add(Me.SaveButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.DeactivateButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.NewButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.DescriptionLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.FullNameLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.ActiveCheckBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.DescriptionTextBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.NameTextBox)
        Me.UserDetailsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDetailsGroupBox.Location = New System.Drawing.Point(338, 15)
        Me.UserDetailsGroupBox.Name = "UserDetailsGroupBox"
        Me.UserDetailsGroupBox.Size = New System.Drawing.Size(317, 379)
        Me.UserDetailsGroupBox.TabIndex = 7
        Me.UserDetailsGroupBox.TabStop = False
        Me.UserDetailsGroupBox.Text = "Category Details"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(117, 302)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(85, 30)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DeactivateButton
        '
        Me.DeactivateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeactivateButton.Location = New System.Drawing.Point(226, 302)
        Me.DeactivateButton.Name = "DeactivateButton"
        Me.DeactivateButton.Size = New System.Drawing.Size(85, 30)
        Me.DeactivateButton.TabIndex = 10
        Me.DeactivateButton.Text = "Deactivate"
        Me.DeactivateButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton.Location = New System.Drawing.Point(6, 302)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(85, 30)
        Me.NewButton.TabIndex = 9
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(6, 96)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(79, 17)
        Me.DescriptionLabel.TabIndex = 6
        Me.DescriptionLabel.Text = "Description"
        '
        'FullNameLabel
        '
        Me.FullNameLabel.AutoSize = True
        Me.FullNameLabel.Location = New System.Drawing.Point(6, 38)
        Me.FullNameLabel.Name = "FullNameLabel"
        Me.FullNameLabel.Size = New System.Drawing.Size(45, 17)
        Me.FullNameLabel.TabIndex = 5
        Me.FullNameLabel.Text = "Name"
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Checked = True
        Me.ActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActiveCheckBox.Location = New System.Drawing.Point(87, 137)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(65, 21)
        Me.ActiveCheckBox.TabIndex = 4
        Me.ActiveCheckBox.Text = "Active"
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(87, 90)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(224, 23)
        Me.DescriptionTextBox.TabIndex = 1
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(87, 35)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(224, 23)
        Me.NameTextBox.TabIndex = 0
        '
        'CategoryManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 402)
        Me.Controls.Add(Me.UserDetailsGroupBox)
        Me.Controls.Add(Me.CategoriesGrid)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Name = "CategoryManagementForm"
        Me.Text = "CategoryManagementForm"
        CType(Me.CategoriesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDetailsGroupBox.ResumeLayout(False)
        Me.UserDetailsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents CategoriesGrid As DataGridView
    Friend WithEvents UserDetailsGroupBox As GroupBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeactivateButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
End Class
