Public Class Login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Silahkan isi Username dan Password")
        Else
            If UsernameTextBox.Text = "ADMIN" And PasswordTextBox.Text = "ADMIN" Then
                Form1.Show()
                Me.Visible = False
            Else
                MsgBox("Username atau Password Salah")
            End If
        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Focus()
    End Sub



    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            PasswordTextBox.Focus()
        End If
    End Sub



    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        PasswordTextBox.PasswordChar = "x"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class