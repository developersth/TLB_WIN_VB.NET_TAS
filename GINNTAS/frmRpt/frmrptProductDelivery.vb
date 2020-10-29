Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Public Class frmrptProductDelivery
    Public LoadNo As String
    Dim ReportID() As Long
    Dim DateStart As String
    Dim TimeStart As String
    Dim DateEnd As String
    Dim TimeEnd As String
    Dim PrinterNameGovProject As String
    Private Sub FindDataTime()
        DateStart = Format(dtpChoosDate.Value, "dd/MM/yyyy")
        TimeStart = Format(DTPTimeStart.Value, "HH:mm:ss")
        DateEnd = Format(dtpChoosDateEnd.Value, "dd/MM/yyyy")
        TimeEnd = Format(DTPTimeEnd.Value, "HH:mm:ss")
        DateStart = DateStart & " " & TimeStart
        DateEnd = DateEnd & " " & TimeEnd

        Call ShowGridData(DateStart, DateEnd)
    End Sub
    Private Sub Show_fixGrindColor()
        With msGridLoad
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightPink
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowHeadersDefaultCellStyle.BackColor = Color.LightPink
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.LightPink
            .RowHeadersDefaultCellStyle.SelectionForeColor = Color.LightPink
            .AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Yellow
            .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Maroon
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.Yellow
            .DefaultCellStyle.SelectionForeColor = Color.Maroon
        End With
    End Sub
    Private Sub ShowGridData(ByVal iDateStart As String, ByVal iDateEnd As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim showdate As String = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now)

        sql_str = _
           "SELECT DISTINCT " & _
            "T.LOAD_HEADER_NO,SHIPMENT_NO,T.TU_ID, " & _
            "T.DRIVER_NAME,T.LOAD_STATUS,T.GOV_PROJECT,T.GOV_PRINT_NO " & _
            "FROM RPT.DAILY_LOADING_DETAIL T " & _
            "WHERE T.EOD_DATE Between " & _
            " to_date('" & iDateStart & "','dd/mm/yyyy hh24:mi:ss') and " & _
            " to_date('" & iDateEnd & "','dd/mm/yyyy hh24:mi:ss') " & _
            "and T.LOAD_STATUS >=54 " & _
            "and T.cancel_status=0 " & _
            "ORDER BY T.LOAD_HEADER_NO ASC"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            msGridLoad.RowCount = 0
            txtCount.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                msGridLoad.RowCount = msGridLoad.RowCount + 1
                'msGridLoad.Rows.Item(i).Height = Grid_Height
                msGridLoad.Item(0, i).Value = (i + 1).ToString()

                msGridLoad.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                msGridLoad.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)
                msGridLoad.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                msGridLoad.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
                msGridLoad.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_STATUS")), "", dt.Rows(i).Item("LOAD_STATUS").ToString)
                msGridLoad.Item(6, i).Value = IIf(IIf(IsDBNull(dt.Rows(i).Item("GOV_PROJECT")), "", dt.Rows(i).Item("GOV_PROJECT").ToString) = 1, "ผ่าน", "")
                msGridLoad.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GOV_PRINT_NO")), "", dt.Rows(i).Item("GOV_PRINT_NO").ToString)

                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub CmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRefresh.Click
        FindDataTime()
    End Sub

    Private Sub frmrptProductDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpChoosDate.Value = Date.Today
        DTPTimeStart.Value = Convert.ToDateTime(dtpChoosDate.Value.Date.ToLongDateString & " " & "00:00:00")
        dtpChoosDateEnd.Value = Date.Today
        DTPTimeEnd.Value = Now
        FindDataTime()
        Show_fixGrindColor()
    End Sub
    Private Sub SqlParameter(LoadHeader_NO As String)
        Dim strSQL As String
        strSQL = _
                               "select t.*" & _
                              " from rpt.VIEW_DELIV_HEADER t " & _
                              " where t.LOAD_HEADER_NO=" + LoadHeader_NO
        frmShowReportDelivery.strSQL = strSQL
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        Dim vLoadHeader_NO As String = String.Empty

        vLoadHeader_NO = msGridLoad.Rows(index).Cells(1).Value.ToString()
        P_GEN_DELIVERY_REPORT(vLoadHeader_NO)
        ShowReport(vLoadHeader_NO)

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        P_GEN_DELIVERY_REPORT(msGridLoad.Rows(index).Cells(1).Value)
        If MsgBox("ท่านต้องการพิมพ์หมายเลข Load No. " & msGridLoad.Rows(index).Cells(1).Value & " หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        Call DirectPrint(msGridLoad.Rows(index).Cells(1).Value, "Delivery_Receipt.rpt")
    End Sub
    Private Sub ShowReport(ByVal pLoadNo)
        Dim rptFileName = GetReportFileName(52010040)
        Dim dt As DataTable = CRService.VIEW_DELIV_HEADER(pLoadNo)
        Dim dt1 As DataTable = CRService.VIEW_DELIV_LINE(pLoadNo)
        Dim dt2 As DataTable = CRService.VIEW_DELIV_SUM_LINE(pLoadNo)
        With frmMainShowReport
            .mRptFileName = rptFileName
            .Subreports1 = "SUB_DELIV_LINE"
            .Subreports2 = "SUB_DELIV_SUM_LINE"
            .dt = dt
            .dt1 = dt1
            .dt2 = dt2
            .Show()
        End With
    End Sub
    Private Sub DirectPrint(iLoadHeader_NO As String, iRptFileName As String)
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
        sql_str = _
                "select t.*" & _
                " from rpt.VIEW_DELIV_HEADER t " & _
                " where t.LOAD_HEADER_NO=" + iLoadHeader_NO '
        Try
            If Oradb.OpenDys(sql_str, "VIEW_DELIV_HEADER", mDataSet) Then
                dt = mDataSet.Tables("VIEW_DELIV_HEADER")
                If dt.Rows.Count > 0 Then
                    rpt.Load(rpFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetDatabaseLogon("tas", "tam")
                    rpt.SetParameterValue(0, iLoadHeader_NO)
                    rpt.PrintOptions.PrinterName = PrinterName
                    rpt.PrintToPrinter(1, False, 0, 0)
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
                                    " and t.Report_ID= 52010048"
        If Oradb.OpenDys(sql_str, "tbName", mDataSet) Then
            dt = mDataSet.Tables("tbName")
            If dt.Rows.Count > 0 Then
                GetPrinterName = dt.Rows(0)("PRINTER_NAME").ToString()
            End If
        End If
    End Function
    Private Sub DirectPrintAttach(iLoadHeader_NO As String, iRptFileName As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim rpt As New ReportDocument
        Dim rpFileName As String
        Dim SApp_Path As String = App_Path()
        Dim Str As String = ""
        Dim PrinterName As String
        rpFileName = SApp_Path & "\Report Files\" & iRptFileName
        PrinterName = GetPrinterNameAttach()
        sql_str =
                "select t.*" &
                " from rpt.view_gov_project_attachas  t " &
                " where t.LOAD_HEADER_NO=" + iLoadHeader_NO '
        Try
            If Oradb.OpenDys(sql_str, "view_gov_project_attachas", mDataSet) Then
                dt = mDataSet.Tables("view_gov_project_attachas")
                If dt.Rows.Count > 0 Then
                    rpt.Load(rpFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetDatabaseLogon("tas", "tam")
                    rpt.SetParameterValue(0, iLoadHeader_NO)
                    rpt.PrintOptions.PrinterName = PrinterName
                    rpt.PrintToPrinter(1, False, 0, 0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด " & ex.Message)
        End Try

        mDataSet = Nothing
    End Sub
    Function GetPrinterNameAttach() As String
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        GetPrinterNameAttach = ""
        sql_str = "select t.*, rt.*" +
                                    " from tas.VIEW_REPORT_PARA_CONFIG t, tas.PRINTER_TAS rt " +
                                    " where t.PRINTER_ID= rt.PRINTER_ID" +
                                    " and t.Report_ID= 52010058"
        If Oradb.OpenDys(sql_str, "tbName", mDataSet) Then
            dt = mDataSet.Tables("tbName")
            If dt.Rows.Count > 0 Then
                GetPrinterNameAttach = dt.Rows(0)("PRINTER_NAME").ToString()
            End If
        End If
    End Function
    Private Sub cmdPreadyAttach_Click(sender As Object, e As EventArgs) Handles cmdPreadyAttach.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        P_GEN_DELIVERY_REPORT(msGridLoad.Rows(index).Cells(1).Value)
        If MsgBox("ท่านต้องการพิมพ์หมายเลข Load No. " & msGridLoad.Rows(index).Cells(1).Value & " หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        Call DirectPrintAttach(msGridLoad.Rows(index).Cells(1).Value, "Gov Project Attach Report.rpt")
    End Sub

    Private Sub cmdPrintAttach_Click(sender As Object, e As EventArgs) Handles cmdPrintAttach.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        P_GEN_DELIVERY_REPORT(msGridLoad.Rows(index).Cells(1).Value)
        frmrptShowReport.mParameter = msGridLoad.Rows(index).Cells(1).Value
        frmrptShowReport.mRptFileName = "Gov Project Attach Report.rpt"
        frmrptShowReport.Show()
    End Sub

    Private Sub msGridLoad_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles msGridLoad.CellDoubleClick
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        P_GEN_DELIVERY_REPORT(msGridLoad.Rows(index).Cells(1).Value)
        ShowReport(msGridLoad.Rows(index).Cells(1).Value.ToString())

    End Sub
    Private Sub P_GEN_DELIVERY_REPORT(LoadNO As String)
        Dim strSQL As String
        strSQL = " "
        strSQL = strSQL & " Begin "
        strSQL = strSQL & " RPT.GEN_DELIVERY_REPORT(" & LoadNO & ");End;"
        If Oradb.ExeSQL(strSQL) Then
        End If
    End Sub
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function
End Class