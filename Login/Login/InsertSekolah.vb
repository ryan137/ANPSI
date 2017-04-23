Public Class InsertSekolah
    Dim dal As New DAL
    Private Sub InsertSekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim sekolah As New Sekolah
        sekolah.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(DAL.insertsekolah(namasekolah.Text, alamatsekolah.Text))
        Dim sekolah As New Sekolah
        sekolah.Show()
        Me.Close()
    End Sub
End Class