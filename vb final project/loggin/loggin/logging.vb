Public Class logging
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        txtUname.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtUname.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter UserName and PassWord")
        ElseIf txtUname.Text = "Admin" And txtPassword.Text = "PassWord" Then
            Dim Obj = New frmstudent
            Obj.Show()
            Me.Hide()

        Else
            MsgBox("Wrong UserName or Password")
            txtUname.Text = ""
            txtPassword.Text = ""



        End If
    End Sub
End Class