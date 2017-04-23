Public Class Form1
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim dal As New DAL
        If dal.login(user.Text, pass.Text) = "superadmin" Then
            Dim menu As New SUMenu
            menu.Show()
            Me.Close()
        ElseIf dal.login(user.Text, pass.Text) = "admin" Then
            Me.Close()
            Dim menu As New AMenu
            menu.Show()
        Else
            MessageBox.Show("login salah")
        End If
    End Sub


End Class
