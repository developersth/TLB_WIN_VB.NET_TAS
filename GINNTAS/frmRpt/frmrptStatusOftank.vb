Public Class frmrptStatusOftank

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        If (optStatus1.Checked = True) Then
            frmrptShowReport.mRptFileName = "Tank OIL Open_Report.rpt"
        Else
            frmrptShowReport.mRptFileName = "Tank OIL Close_Report.rpt"
        End If
        frmrptShowReport.mParameter = MVDate.SelectionStart()
        frmrptShowReport.Show()
    End Sub
End Class