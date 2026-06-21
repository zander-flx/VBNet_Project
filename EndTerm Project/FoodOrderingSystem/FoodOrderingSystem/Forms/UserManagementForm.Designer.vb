<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementForm
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
        Me.UsersGrid = New System.Windows.Forms.DataGridView()
        Me.UserDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.NoteLabel = New System.Windows.Forms.Label()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeactivateButton = New System.Windows.Forms.Button()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.FullNameLabel = New System.Windows.Forms.Label()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.NewButton = New System.Windows.Forms.Button()
        CType(Me.UsersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDetailsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsersGrid
        '
        Me.UsersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersGrid.Location = New System.Drawing.Point(12, 64)
        Me.UsersGrid.Name = "UsersGrid"
        Me.UsersGrid.ReadOnly = True
        Me.UsersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersGrid.Size = New System.Drawing.Size(450, 361)
        Me.UsersGrid.TabIndex = 9
        '
        'UserDetailsGroupBox
        '
        Me.UserDetailsGroupBox.Controls.Add(Me.NewButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.NoteLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.RoleComboBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.SaveButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.DeactivateButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.RoleLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.PasswordLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.UsernameLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.FullNameLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.ActiveCheckBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.UsernameTextBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.FullNameTextBox)
        Me.UserDetailsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDetailsGroupBox.Location = New System.Drawing.Point(471, 26)
        Me.UserDetailsGroupBox.Name = "UserDetailsGroupBox"
        Me.UserDetailsGroupBox.Size = New System.Drawing.Size(317, 399)
        Me.UserDetailsGroupBox.TabIndex = 8
        Me.UserDetailsGroupBox.TabStop = False
        Me.UserDetailsGroupBox.Text = "User Details"
        '
        'NoteLabel
        '
        Me.NoteLabel.AutoSize = True
        Me.NoteLabel.Location = New System.Drawing.Point(6, 348)
        Me.NoteLabel.Name = "NoteLabel"
        Me.NoteLabel.Size = New System.Drawing.Size(252, 34)
        Me.NoteLabel.TabIndex = 14
        Me.NoteLabel.Text = "Leave password blank when editing to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "keep it unchanged"
        '
        'RoleComboBox
        '
        Me.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Items.AddRange(New Object() {"admin", "cashier", "staff"})
        Me.RoleComboBox.Location = New System.Drawing.Point(87, 202)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(224, 24)
        Me.RoleComboBox.TabIndex = 13
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(87, 147)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(224, 23)
        Me.PasswordTextBox.TabIndex = 12
        Me.PasswordTextBox.UseSystemPasswordChar = True
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
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Location = New System.Drawing.Point(6, 205)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(37, 17)
        Me.RoleLabel.TabIndex = 8
        Me.RoleLabel.Text = "Role"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(6, 150)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(69, 17)
        Me.PasswordLabel.TabIndex = 7
        Me.PasswordLabel.Text = "Password"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(6, 96)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(73, 17)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "Username"
        '
        'FullNameLabel
        '
        Me.FullNameLabel.AutoSize = True
        Me.FullNameLabel.Location = New System.Drawing.Point(6, 38)
        Me.FullNameLabel.Name = "FullNameLabel"
        Me.FullNameLabel.Size = New System.Drawing.Size(71, 17)
        Me.FullNameLabel.TabIndex = 5
        Me.FullNameLabel.Text = "Full Name"
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Checked = True
        Me.ActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActiveCheckBox.Location = New System.Drawing.Point(87, 257)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(65, 21)
        Me.ActiveCheckBox.TabIndex = 4
        Me.ActiveCheckBox.Text = "Active"
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(87, 90)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(224, 23)
        Me.UsernameTextBox.TabIndex = 1
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(87, 35)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(224, 23)
        Me.FullNameTextBox.TabIndex = 0
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(12, 26)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SearchTextBox.TabIndex = 10
        '
        'NewButton
        '
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton.Location = New System.Drawing.Point(9, 302)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(85, 30)
        Me.NewButton.TabIndex = 15
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'UserManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.UsersGrid)
        Me.Controls.Add(Me.UserDetailsGroupBox)
        Me.Name = "UserManagementForm"
        Me.Text = "UserManagementForm"
        CType(Me.UsersGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDetailsGroupBox.ResumeLayout(False)
        Me.UserDetailsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsersGrid As DataGridView
    Friend WithEvents UserDetailsGroupBox As GroupBox
    Friend WithEvents NoteLabel As Label
    Friend WithEvents RoleComboBox As ComboBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeactivateButton As Button
    Friend WithEvents RoleLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents NewButton As Button
End Class
