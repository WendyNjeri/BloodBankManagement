Imports System.Data.SqlClient

Public Class Transfers
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Documents\bloodvbdb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub getPatients()
        Con.Open()
        Dim sql = "select * from PTable "
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        adapter.Fill(tbl)
        PatIdcb.DataSource = tbl
        PatIdcb.DisplayMember = "PId"
        PatIdcb.ValueMember = "PId"

        Con.Close()

    End Sub
    Private Sub Transfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPatients()

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub getData()
        Con.Open()

        Dim querry = "select * from PTable where PId = " & PatIdcb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(querry, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader

        reader = cmd.ExecuteReader()

        While reader.Read
            PatnameTb.Text = reader(1).ToString()
            Bgrouptb.Text = reader(5).ToString()

        End While


        Con.Close()
    End Sub


    Private Sub PatIdcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PatIdcb.SelectionChangeCommitted
        getData()
        fetchQuantity()

        If availablestOck = 0 Then
            LblAvailable.Text = "No Blood Available"
            LblAvailable.Visible = True
        Else
            LblAvailable.Text = availablestOck
            LblAvailable.Visible = True


        End If

    End Sub
    Dim availablestOck As Integer

    Private Sub fetchQuantity()
        Con.Open()
        Dim query = "select * from BstockTable where Bgroup = '" & Bgrouptb.Text & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            availablestock = Convert.ToInt32(reader(2))
        End While

        Con.Close()
    End Sub

    Private Sub updateBlood()
        fetchQuantity()

        Dim newstock As Integer

        newstock = availablestOck - 1

        Con.Open()
        Dim query = "update BStockTable set Bstock = " & newstock & "where Bgroup = '" & Bgrouptb.Text & "'"
        Dim cmd As New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()


        If newstock = 0 Then
            transfer.Visible = False
        Else
            transfer.Visible = True
        End If

        Con.Close()

    End Sub
    Private Sub transfer_Click(sender As Object, e As EventArgs) Handles transfer.Click
        Try
            Con.Open()
            Dim query = "insert into TransferTable(Tpat, TBgroup) values (@Trpat, @RrBgroup) "
            Dim CMD As New SqlCommand(query, Con)
            CMD.Parameters.AddWithValue("@Trpat", PatnameTb.Text)
            CMD.Parameters.AddWithValue("@RrBgroup", Bgrouptb.Text)
            CMD.ExecuteNonQuery()
            MsgBox("Blood Transfered")
            Con.Close()
            fetchQuantity()
            updateBlood()

        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            Con.Close()
        End Try
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim obj = New DashBoard
        obj.Show()

    End Sub
End Class