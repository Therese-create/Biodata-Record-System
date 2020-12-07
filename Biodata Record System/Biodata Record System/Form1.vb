Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "bio" And TextBox2.Text = "pass" Then
            Form2.Show()
 
            Me.Hide()
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Please fill up necessary fields!")


        Else
            MsgBox("Incorrect Username or Password")

        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If TextBox1.Text = "bio" And TextBox2.Text = "pass" Then

                Me.Hide()
            Else
                MsgBox("Incorrect username or password")


            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox2.PasswordChar = "*"
        Else
            TextBox2.PasswordChar = ""
        End If

    End Sub
End Class
