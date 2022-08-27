Option Explicit On
Option Strict Off
Imports System.Data.SqlClient
Public Class Donors
    Dim key As Integer
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Documents\bloodvbdb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Con.Open()
            Dim query = "insert into DonorTable(Dname, Dage, Dgene, Dphone, DBgroup, Dadd) values (@Donname, @Donage, @Dongene, @Donphone, @DonBgroup, @Donadd) "
            Dim CMD As New SqlCommand(query, Con)
            CMD.Parameters.AddWithValue("@Donname", DnameTb.Text)
            CMD.Parameters.AddWithValue("@Donage", Dagetb.Text)
            CMD.Parameters.AddWithValue("@Dongene", DGendercb.SelectedItem.ToString())
            CMD.Parameters.AddWithValue("@Donphone", DphoneTB.Text)
            CMD.Parameters.AddWithValue("@DonBgroup", DBGroupcb.SelectedItem.ToString())
            CMD.Parameters.AddWithValue("@Donadd", DAddresstb.Text)
            CMD.ExecuteNonQuery()
            MsgBox("DONOR SAVED")
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            Con.Close()
        End Try

    End Sub
    Private Sub displaydonor()
        Con.Open()
        Dim query = "select * from DonorTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DonorsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Donors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaydonor()
    End Sub

    Private Sub Donors_Load_1(sender As Object, e As EventArgs)
        displaydonor()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Select Donor to be deleted")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            Dim query = "delete from DonorTable where DId = " & key & ""
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Donor Deleted")
            Con.Close()
            displaydonor()

        End If
    End Sub


    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If key = 0 Or DnameTb.Text = "" Or Dagetb.Text = "" Or DphoneTB.Text = "" Or DAddresstb.Text = "" Then
            MsgBox("incomplete iformation")
        Else
            Con.Open()
            Dim query = "update DonorTable set Dname = '" & DnameTb.Text & "',Dage = '" & Dagetb.Text & "', Dgene = '" & DGendercb.SelectedItem.ToString & "', Dphone= '" & DphoneTB.Text & "', DBgroup=' " & DBGroupcb.ToString() & "', Dadd =' " & DAddresstb.Text & "'where DId = " & key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Donor Edited SuccessFully")
            Con.Close()
            displaydonor()

        End If
    End Sub

    Private Sub DonorsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DonorsDGV.CellMouseClick
        Dim row As DataGridViewRow = DonorsDGV.Rows(e.RowIndex)
        DnameTb.Text = row.Cells(1).Value.ToString
        Dagetb.Text = row.Cells(2).Value.ToString
        DGendercb.SelectedItem = row.Cells(3).Value.ToString
        DphoneTB.Text = row.Cells(4).Value.ToString
        DBGroupcb.SelectedItem = row.Cells(5).Value.ToString
        DAddresstb.Text = row.Cells(6).Value.ToString

        If DnameTb.Text = "donor name" Or DnameTb.Text = "" Then
            key = 0
        Else
            key = row.Cells(0).Value.ToString
        End If
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim obj = New DashBoard
        obj.Show()
    End Sub

End Class