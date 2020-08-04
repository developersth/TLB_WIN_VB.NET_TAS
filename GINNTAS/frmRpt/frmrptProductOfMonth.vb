Public Class frmrptProductOfMonth

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim strSQL As String
        If rType1.Checked = True = True Then
            strSQL = "select * " & _
                  "from rpt.view_load_mass_report_daily " & _
                  "where  to_date(eod_date) =  to_date('" & Format(MVDate.Value, "MM/yyyy") & "','MM/yyyy') " & _
                  "order by eod_date"
            frmrptShowReport.mRptFileName = "MonthlySummaryMassByCompany.rpt"
        Else
            strSQL = "select * " & _
                      "from rpt.view_load_volume_report_daily " & _
                      "where  to_date(eod_date) =  to_date('" & Format(MVDate.Value, "MM/yyyy") & "' ,'MM/yyyy')" & _
                      "order by eod_date"
            frmrptShowReport.mRptFileName = "MonthlySummaryVolumeByCompany.rpt"
        End If
        frmrptShowReport.ValueParameter = 2
        frmrptShowReport.mstrQuery = strSQL
        'frmrptShowReport.mParameter = Format(MVDate.Value, "MM/yyyy")
        frmrptShowReport.Show()
    End Sub

    Private Sub frmrptProductOfMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MVDate.Value = String.Format("{0:dd/MM/yyyy}", Date.Now)
    End Sub
End Class