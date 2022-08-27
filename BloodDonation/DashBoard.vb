Imports System.Data.SqlClient

Public Class DashBoard
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Documents\bloodvbdb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub
    Private Sub countpatients()
        Dim patnum As Integer
        Con.Open()
        Dim sql = "select count(*) from PTable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        patnum = cmd.ExecuteScalar
        Patnumlbl.Text = patnum

        Con.Close()

    End Sub
    Private Sub countdonors()
        Dim donnum As Integer
        Con.Open()
        Dim sql = "select count(*) from DonorTable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        donnum = cmd.ExecuteScalar
        Donnumlbl.Text = donnum

        Con.Close()

    End Sub
    Private Sub counttransfers()
        Dim trfnum As Integer
        Con.Open()
        Dim sql = "select count(*) from TransferTable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        trfnum = cmd.ExecuteScalar
        TrtnumLbl.Text = trfnum

        Con.Close()

    End Sub
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countpatients()
        countdonors()
        counttransfers()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim obj = New Donors
        obj.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim obj = New Patients
        obj.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim obj = New Donate
        obj.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim obj = New Transfers
        obj.Show()
    End Sub

    Private Sub repbtn_Click(sender As Object, e As EventArgs) Handles repbtn.Click
        Dim obj = New Reports
        obj.Show()

    End Sub
End Class