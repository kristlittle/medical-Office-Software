Public Class frmLogin
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBypass_Click(sender As Object, e As EventArgs) Handles btnBypass.Click
        Me.Hide()
        Dim Obj = New frmHome
            Obj.show()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter Username & Password OR CLICK BYPASS BUTTON")

        Else
            MsgBox("Wrong Username, Try Again OR Click Bypass")
        End If
    End Sub
End Class
