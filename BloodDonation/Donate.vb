Imports System.Data.SqlClient
Public Class Donate
    Dim key As Integer
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Documents\bloodvbdb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub displayDonors()
        Con.Open()
        Dim query = "select Dname, DBgroup from DonorTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DonorsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub displayBlood()
        Con.Open()
        Dim query = "select * from BStockTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        BloodDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Donate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayDonors()
        displayBlood()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub


    Private Sub DonorsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DonorsDGV.CellMouseClick
        Dim row As DataGridViewRow = DonorsDGV.Rows(e.RowIndex)
        DnameTb.Text = row.Cells(0).Value.ToString
        DBgrouptb.Text = row.Cells(1).Value.ToString

    End Sub

    Private Sub BloodDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BloodDGV.CellMouseClick

    End Sub
    Dim oldstock As Integer

    Private Sub fetchQuantity()
        Con.Open()
        Dim query = "select * from BstockTable where Bgroup = '" & DBgrouptb.Text & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            oldstock = Convert.ToInt32(reader(2))
        End While

        Con.Close()
        displayBlood()
    End Sub

    Private Sub DonateBtn_Click(sender As Object, e As EventArgs) Handles DonateBtn.Click

        If DnameTb.Text = "" Or DBgrouptb.Text = "" Then
            MsgBox("Select a donor")
        Else
            fetchQuantity()

            Dim newstock As Integer

            newstock = oldstock + 1

            Con.Open()
            Dim query = "update BStockTable set Bstock = " & newstock & "where Bgroup = '" & DBgrouptb.Text & "'"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Blood Record Updated SuccessFully")
            Con.Close()
            displayBlood()
        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim obj = New Donors
        obj.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim obj = New Patients
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