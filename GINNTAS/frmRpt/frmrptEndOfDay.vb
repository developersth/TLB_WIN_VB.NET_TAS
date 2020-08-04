Public Class frmrptEndOfDay

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        If (optStatus1.Checked = True) Then
            frmrptShowReport.mRptFileName = "Detail Oil Bulk Loading Volume By Product.rpt"
        ElseIf (optStatus2.Checked = True) Then
            frmrptShowReport.mRptFileName = "Detail Oil Bulk Loading Mass By Product.rpt"
        ElseIf (optStatus3.Checked = True) Then
            frmrptShowReport.mRptFileName = "Detail Oil Bulk Loading Volume By Company.rpt"
        ElseIf (optStatus4.Checked = True) Then
            frmrptShowReport.mRptFileName = "Detail Oil Bulk Loading Mass By Cust.rpt"
        ElseIf (optStatus5.Checked = True) Then
            frmrptShowReport.mRptFileName = "SummaryVolumeLoadReportByCompany.rpt"
        Else
            frmrptShowReport.mRptFileName = "SummaryMassLoadReportByCompany.rpt"
        End If
        frmrptShowReport.mParameter = MVDate.SelectionStart()
        frmrptShowReport.Show()
    End Sub
End Class