Public Class frmAppointment
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        Dim Obj = New frmDashboard
        Obj.Show()
    End Sub
End Class