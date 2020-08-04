Public Class frmrptDepHighwayTotalOfMonth
    Dim sProduct() As String, sCode As String
    Dim rType As Long
    Private Sub InitialCombo()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select t.sale_product_id,t.sale_product_id||' '||t.sale_product_code as sale_product from sale_product t order by t.sale_product_id"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            cbProductID.Text = ""
            Do While dt.Rows.Count > i
                cbProductID.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("sale_product")), "", dt.Rows(i).Item("sale_product").ToString))
                i = i + 1
            Loop
            cbProductID.SelectedIndex = 0
        Else
        End If
        mDataSet = Nothing

    End Sub
    Private Sub frmrptDepHighwayTotalOfMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MVDate.Value = String.Format("{0:dd/MM/yyyy}", Date.Now)
        InitialCombo()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim strQuery As String
        If cbProductID.Text <> "" Then
            sProduct = Split(cbProductID.Text, " ")
            sCode = sProduct(0)
            If rType1.Checked = True Then
                rType = 1
            Else
                rType = 0
            End If
        Else
            MsgBox("คุณยังไม่ได้เลือก Product !", vbCritical)
        End If

        'strQuery = "select * " & _
        '                  "from rpt.view_load_mass_report_daily " & _
        '                  "where sale_product_id='" & sCode & "' " & _
        '                  "and gov_project=" & rType & " " & _
        '                  "and  to_date(eod_date) =  '" & Format(MVDate.Value, "MM/yyyy") & "'" & _
        '                  "order by load_header_no"
        strQuery = _
        "select * " & _
                          " from rpt.view_load_mass_report_daily " & _
                          " where sale_product_id='" & sCode & "' " & _
                          " and gov_project=" & rType & " " & _
                          "and  to_char(eod_date,'MM/yyyy') =  '" & Format(MVDate.Value, "MM/yyyy") & "'" & _
                          " order by load_header_no"
        frmrptShowReport.ValueParameter = 2
        frmrptShowReport.mstrQuery = strQuery
        'frmrptShowReport.mParameter = Format(MVDate.Value, "MM/yyyy")
        frmrptShowReport.mRptFileName = "Government Loading Report Monthly.rpt"
        frmrptShowReport.Show()
    End Sub
End Class