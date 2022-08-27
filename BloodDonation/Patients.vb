Imports System.Data.SqlClient

Public Class Patients
    Dim key As Integer
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Documents\bloodvbdb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub displaypatient()
        Con.Open()
        Dim query = "select * from PTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        PatientsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Con.Open()
            Dim query = "insert into PTable(Pname, Page, Pgene, Pphone, PBgroup, Padd) values (@Ponname, @Ponage, @Pongene, @Ponphone, @PonBgroup, @Ponadd) "
            Dim CMD As New SqlCommand(query, Con)
            CMD.Parameters.AddWithValue("@Ponname", Pnametb.Text)
            CMD.Parameters.AddWithValue("@Ponage", Pagetb.Text)
            CMD.Parameters.AddWithValue("@Pongene", PGendercb.SelectedItem.ToString())
            CMD.Parameters.AddWithValue("@Ponphone", PphoneTB.Text)
            CMD.Parameters.AddWithValue("@PonBgroup", PBGroupcb.SelectedItem.ToString())
            CMD.Parameters.AddWithValue("@Ponadd", PAddresstb.Text)
            CMD.ExecuteNonQuery()
            MsgBox("Patient SAVED")
            Con.Close()
            displaypatient()

        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            Con.Close()
        End Try
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Select Patient to be deleted")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            Dim query = "delete from PTable where PId = " & key & ""
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient Deleted successfully")
            Con.Close()
            displaypatient()

        End If
    End Sub

    Private Sub PatientsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PatientsDGV.CellMouseClick
        Dim row As DataGridViewRow = PatientsDGV.Rows(e.RowIndex)
        Pnametb.Text = row.Cells(1).Value.ToString
        Pagetb.Text = row.Cells(2).Value.ToString
        PGendercb.SelectedItem = row.Cells(3).Value.ToString
        PphoneTB.Text = row.Cells(4).Value.ToString
        PBGroupcb.SelectedItem = row.Cells(5).Value.ToString
        PAddresstb.Text = row.Cells(6).Value.ToString

        If Pnametb.Text = "Patients name" Or Pnametb.Text = "" Then
            key = 0
        Else
            key = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If key = 0 Or Pnametb.Text = "" Or Pagetb.Text = "" Or PphoneTB.Text = "" Or PAddresstb.Text = "" Then
            MsgBox("incomplete iformation")
        Else
            Con.Open()
            Dim query = "update PTable set Pname = '" & Pnametb.Text & "',Page = '" & Pagetb.Text & "', Pgene = '" & PGendercb.SelectedItem.ToString & "',Pphone= '" & PphoneTB.Text & "', PBgroup= '" & PBGroupcb.ToString() & "', Padd = '" & PAddresstb.Text & "' where PId = " & key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("PATIENT Edited SuccessFully")
            Con.Close()
            displaypatient()
        End If
    End Sub

    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaypatient()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim obj = New DashBoard
        obj.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim obj = New Transfers
        obj.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim obj = New Donate
        obj.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim obj = New Donors
        obj.Show()
    End Sub
End Class