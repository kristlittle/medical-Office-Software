Public Class frmLogin
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBypass_Click(sender As Object, e As EventArgs) Handles btnBypass.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter Username & Password OR CLICK BYPASS BUTTON")

        ElseIf txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            Me.Hide()
            Dim Obj = New frmHome
            Obj.show()

        Else
            MsgBox("Wrong Username, Try Again OR Click Bypass")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class
