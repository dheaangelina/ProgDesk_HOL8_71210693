Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports Microsoft.Reporting.WebForms

Public Class formLaporan
    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub formLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        AutoRefresh()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Dim ds As New DataSet1
        Dim myAdapter As New MySqlDataAdapter
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir WHERE DATE(waktu_masuk) = CURDATE()", myConn)
        myAdapter.Fill(ds.Tables(0))
        ReportViewer1.Reset()
        ReportViewer1.ProcessingMode =
        Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub AutoRefresh()
        Dim ds As New DataSet1
        Dim myAdapt As New MySqlDataAdapter
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        myAdapt.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir WHERE DATE(waktu_masuk) = CURDATE()", myConn)
        myAdapt.Fill(ds.Tables(0))
        ReportViewer1.Reset()
        ReportViewer1.ProcessingMode =
        Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class