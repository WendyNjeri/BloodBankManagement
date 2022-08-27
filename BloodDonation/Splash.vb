Public Class Splash

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgress.Increment(1)
        PercentageLbl.Text = MyProgress.Value
        If MyProgress.Value = 100 Then
            Me.Hide()
            Dim obj As New LogIn
            obj.Show()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
