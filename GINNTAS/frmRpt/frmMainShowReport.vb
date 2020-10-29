Imports CrystalDecisions.CrystalReports.Engine

Public Class frmMainShowReport
    Public mRptFileName As String
    Public dt As DataTable
    Public Subreports1 As String
    Public dt1 As DataTable
    Public Subreports2 As String
    Public dt2 As DataTable


    Private Sub ShowReportDataTable()
        Dim rpt As New ReportDocument
        Dim mDataSet As New DataSet
        Dim rpFileName As String
        Dim SApp_Path As String = App_Path()

        rpFileName = SApp_Path & "\Report Files\" & mRptFileName

        rpt.Load(rpFileName)
        rpt.SetDataSource(dt)
        If (Not String.IsNullOrEmpty(Subreports1)) Then
            rpt.Subreports(0).SetDataSource(dt1)
        End If
        If (Not String.IsNullOrEmpty(Subreports2)) Then
            rpt.Subreports(1).SetDataSource(dt2)
        End If


        CrysRPTViewer.ReportSource = rpt
        CrysRPTViewer.Refresh()
        CrysRPTViewer = Nothing
    End Sub

    Private Sub frmMainShowReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowReportDataTable()
    End Sub

End Class