Public Class Reports

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet1
        Dim ad As New DataSet1TableAdapters.DonorTableTableAdapter
        Dim add As New DataSet1TableAdapters.PTableTableAdapter
        Dim addd As New DataSet1TableAdapters.BStockTableTableAdapter
        ad.Fill(ds.DonorTable)
        add.Fill(ds.PTable)
        addd.Fill(ds.BStockTable)


        Dim rpt1 As New CrystalReport1
        rpt1.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt1

        Dim rpt2 As New CrystalReport2
        rpt2.SetDataSource(ds)
        CrystalReportViewer2.ReportSource = rpt2

        Dim rpt3 As New CrystalReport3
        rpt3.SetDataSource(ds)
        CrystalReportViewer3.ReportSource = rpt3


        Me.CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub
End Class