<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboardForm
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
        Me.SubtitleLabel = New System.Windows.Forms.Label()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.CategoriesButton = New System.Windows.Forms.Button()
        Me.OrdersButton = New System.Windows.Forms.Button()
        Me.UsersButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SubtitleLabel
        '
        Me.SubtitleLabel.AutoSize = True
        Me.SubtitleLabel.Location = New System.Drawing.Point(12, 31)
        Me.SubtitleLabel.Name = "SubtitleLabel"
        Me.SubtitleLabel.Size = New System.Drawing.Size(77, 13)
        Me.SubtitleLabel.TabIndex = 0
        Me.SubtitleLabel.Text = "Logged in as..."
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(32, 73)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(140, 23)
        Me.MenuButton.TabIndex = 1
        Me.MenuButton.Text = "Manage Menu"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'CategoriesButton
        '
        Me.CategoriesButton.Location = New System.Drawing.Point(32, 114)
        Me.CategoriesButton.Name = "CategoriesButton"
        Me.CategoriesButton.Size = New System.Drawing.Size(140, 23)
        Me.CategoriesButton.TabIndex = 2
        Me.CategoriesButton.Text = "Manage Categories"
        Me.CategoriesButton.UseVisualStyleBackColor = True
        '
        'OrdersButton
        '
        Me.OrdersButton.Location = New System.Drawing.Point(32, 161)
        Me.OrdersButton.Name = "OrdersButton"
        Me.OrdersButton.Size = New System.Drawing.Size(140, 23)
        Me.OrdersButton.TabIndex = 3
        Me.OrdersButton.Text = "View Orders"
        Me.OrdersButton.UseVisualStyleBackColor = True
        '
        'UsersButton
        '
        Me.UsersButton.Location = New System.Drawing.Point(32, 209)
        Me.UsersButton.Name = "UsersButton"
        Me.UsersButton.Size = New System.Drawing.Size(140, 23)
        Me.UsersButton.TabIndex = 4
        Me.UsersButton.Text = "Manage Users"
        Me.UsersButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(97, 275)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 5
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'AdminDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 327)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.UsersButton)
        Me.Controls.Add(Me.OrdersButton)
        Me.Controls.Add(Me.CategoriesButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.SubtitleLabel)
        Me.Name = "AdminDashboardForm"
        Me.Text = "AdminDashboardForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubtitleLabel As Label
    Friend WithEvents MenuButton As Button
    Friend WithEvents CategoriesButton As Button
    Friend WithEvents OrdersButton As Button
    Friend WithEvents UsersButton As Button
    Friend WithEvents LogoutButton As Button
End Class
