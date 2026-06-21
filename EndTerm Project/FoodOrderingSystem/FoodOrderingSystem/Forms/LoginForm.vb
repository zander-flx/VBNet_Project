Imports FoodOrderingSystem.Services

Partial Public Class LoginForm
    Private ReadOnly _auth As New AuthService()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            Dim user = _auth.Login(UsernameTextBox.Text, PasswordTextBox.Text)
            If user Is Nothing Then
                MessageLabel.Text = "Invalid username or password."
                Return
            End If

            Session.CurrentUser = user
            MessageLabel.Text = String.Empty
            Hide()

            Select Case user.Role.ToLower()
                Case "admin", "manager"
                    Using form As New AdminDashboardForm()
                        form.ShowDialog(Me)
                    End Using
                Case Else
                    Using form As New OrderForm()
                        form.ShowDialog(Me)
                    End Using
            End Select

            Session.CurrentUser = Nothing
            PasswordTextBox.Clear()
            Show()
            UsernameTextBox.Focus()
        Catch ex As Exception
            MessageLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoginButton_Click(sender, EventArgs.Empty)
        End If
    End Sub
End Class