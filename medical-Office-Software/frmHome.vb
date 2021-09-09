Public Class frmHome
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        Dim Obj = New frmAppointment
        Obj.Show()
    End Sub
End Class