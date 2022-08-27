Public Class LogIn

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        If UnameTb.Text = "" Or PaswordTb.Text = "" Then
            MsgBox("Enter both username and password")
        ElseIf UnameTb.Text = "Admin" And PaswordTb.Text = "Pass" Then
            Dim obj As New Patients()
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong username or password")

        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        UnameTb.Text = ""
        PaswordTb.Text = ""
    End Sub
End Class