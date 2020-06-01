Public Class LoginForm1





    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim oform As New Form1
        If (UsernameTextBox.Text = "Riya") And (PasswordTextBox.Text = "1234") Then
            Me.Hide()
            oform.ShowDialog()
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Question)
            MessageBox.Show("Incorrect username or password")

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim nform As New Form2
        Form2.ShowDialog()
        Me.Hide()


    End Sub


    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Select()
    End Sub
End Class
