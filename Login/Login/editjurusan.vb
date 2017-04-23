Public Class editjurusan
    Dim dal As New DAL
    Private Sub editjurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = dal.getjurusan(id)
        nama.Text = data.Tables(0).Rows(0).Item("jurusan_nama")
        kode.Text = data.Tables(0).Rows(0).Item("jurusan_kode")
    End Sub
    Public id As String

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        MessageBox.Show(dal.updatejurusan(id, nama.Text, kode.Text))
        Dim jurusan As New Jurusan
        jurusan.Show()
        Me.Close()

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

        Dim jurusan As New Jurusan
        jurusan.Show()
        Me.Close()
    End Sub
End Class