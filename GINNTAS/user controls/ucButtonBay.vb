Public Class ucButtonBay

    Dim bayNo
    Dim bayName

    'Event OnClickButtonBay(ByVal BayNo As String, ByVal BayName As String)
#Region "uc Event"
    Private Sub ucClick()
        'RaiseEvent OnClickButtonBay(CType(Me.bayNo, String), CType(Me.bayName, String))
    End Sub
#End Region

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmMMIBayLoading.selectBay(bayNo, bayName)
        Button1.BackColor = Color.Green
        'ucClick()
    End Sub

    Sub createButtonBay(ByRef w, ByRef h, ByRef bNo, ByRef bName)
        bayNo = bNo
        bayName = bName
        Button1.Text = bNo
        'Button1.Size = New Size(w - w * 0.1, h - h * 0.1)
        Me.Size = New Size(w - w * 0.1, h - h * 0.1)
    End Sub

    Public Sub setWhiteButtion()
        Button1.BackColor = Color.WhiteSmoke
    End Sub

    Public Sub setGreenButtion()
        Button1.BackColor = Color.Green
    End Sub

    End Class
