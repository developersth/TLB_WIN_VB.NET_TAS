Public Class frmrptProductOfMeter

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        If rType1.Checked = True Then
            frmrptShowReport.mRptFileName = "MassLoadReportByMeter.rpt"
        Else
            frmrptShowReport.mRptFileName = "MassLoadReportByTank.rpt"
        End If
        frmrptShowReport.mParameter = MVDate.SelectionStart()
        frmrptShowReport.Show()
    End Sub
End Class