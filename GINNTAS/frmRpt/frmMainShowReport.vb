Imports CrystalDecisions.CrystalReports.Engine

Public Class frmMainShowReport
    Public mRptFileName As String
    Public dt As DataTable

    Private Sub ShowReportDataTable()
        Dim rpt As New ReportDocument
        Dim mDataSet As New DataSet
        Dim rpFileName As String
        Dim SApp_Path As String = App_Path()

        rpFileName = SApp_Path & "\Report Files\" & mRptFileName
        rpt.Load(rpFileName)
        rpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1 = Nothing
    End Sub

    Private Sub frmMainShowReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowReportDataTable()
    End Sub
End Class