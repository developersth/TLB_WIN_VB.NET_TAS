﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Public Class frmrptDepHighway
    Dim sProduct() As String, sCode As String
    Dim rType As Long
    Dim strSql As String
    Private Sub InitialCombo()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select t.sale_product_id,t.sale_product_id||' '||t.sale_product_code as sale_product from sale_product t order by t.sale_product_code"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            cbProduct.Text = ""
            Do While dt.Rows.Count > i
                cbProduct.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("sale_product")), "", dt.Rows(i).Item("sale_product").ToString))
                i = i + 1
            Loop
            cbProduct.SelectedIndex = 5
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub frmrptDepHighway_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitialCombo()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        If cbProduct.Text <> "" Then
            sProduct = Split(cbProduct.Text, " ")
            sCode = sProduct(0)
            If optType1.Checked = True Then
                rType = 1
            Else
                rType = 0
            End If
        Else
            MsgBox("คุณยังไม่ได้เลือก Product !", vbCritical)
        End If
        Sqlquery()
        frmrptShowReport.ValueParameter = 2
        frmrptShowReport.mParameter = MVDate.SelectionStart()
        frmrptShowReport.mRptFileName = "Government Loading By Company.rpt"
        frmrptShowReport.Show()
    End Sub
    Private Sub Sqlquery()
        strSql = "select * " &
                         "from rpt.view_load_mass_report_daily " &
                         "where sale_product_id='" & sCode & "' " &
                         "and gov_project=" & rType & " " &
                         "and trunc(eod_date) =to_date('" & MVDate.SelectionStart() & "','dd/mm/yyyy') " &
                         "order by customer_code,load_header_no"
        frmrptShowReport.mstrQuery = strSql
    End Sub

    Private Sub cmdPrint_Click_1(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If MsgBox("ท่านต้องการพิมพ์รายงานทางหลวงเรียงตามบริษัท หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        DirectPrint("Government Loading By Company.rpt")
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub DirectPrint(iRptFileName As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim rpt As New ReportDocument
        Dim rpFileName As String
        Dim SApp_Path As String = App_Path()
        Dim Str As String = ""
        Dim PrinterName As String
        rpFileName = SApp_Path & "\Report Files\" & iRptFileName
        PrinterName = GetPrinterName()

        If cbProduct.Text <> "" Then
            sProduct = Split(cbProduct.Text, " ")
            sCode = sProduct(0)
            If optType1.Checked = True Then
                rType = 1
            Else
                rType = 0
            End If
        Else
            MsgBox("คุณยังไม่ได้เลือก Product !", vbCritical)
        End If

        sql_str = "select * " &
                         "from rpt.view_load_mass_report_daily " &
                         "where sale_product_id='" & sCode & "' " &
                         "and gov_project=" & rType & " " &
                         "and trunc(eod_date) =to_date('" & MVDate.SelectionStart() & "','dd/mm/yyyy') " &
                         "order by customer_code,load_header_no"
        Try
            If Oradb.OpenDys(sql_str, "view_load_mass_report_daily", mDataSet) Then
                dt = mDataSet.Tables("view_load_mass_report_daily")
                If dt.Rows.Count > 0 Then
                    rpt.Load(rpFileName)
                    rpt.SetDataSource(dt)
                    'rpt.SetDatabaseLogon("tas", "tam")
                    rpt.SetParameterValue(0, MVDate.SelectionStart())
                    rpt.PrintOptions.PrinterName = PrinterName
                    rpt.PrintToPrinter(1, False, 0, 0)
                    rpt.Dispose()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด " & ex.Message)
        End Try

        mDataSet = Nothing
    End Sub
    Function GetPrinterName() As String
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        GetPrinterName = ""
        sql_str = "select t.*, rt.*" +
                                    " from tas.VIEW_REPORT_PARA_CONFIG t, tas.PRINTER_TAS rt " +
                                    " where t.PRINTER_ID= rt.PRINTER_ID" +
                                    " and t.Report_ID= 52010049"
        If Oradb.OpenDys(sql_str, "tbName", mDataSet) Then
            dt = mDataSet.Tables("tbName")
            If dt.Rows.Count > 0 Then
                GetPrinterName = dt.Rows(0)("PRINTER_NAME").ToString()
            End If
        End If
    End Function
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function
End Class