Public Class EditSekolah
    Dim dal As New DAL
    Private Sub EditSekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = dal.getsekolah(id)
        namasekolah.Text = data.Tables(0).Rows(0).Item("Nama Sekolah")
        alamatsekolah.Text = data.Tables(0).Rows(0).Item("Alamat Sekolah")
    End Sub

    Public id As String

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim sekolah As New Sekolah
        sekolah.Show()
        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.updatesekolah(id, namasekolah.Text, alamatsekolah.Text))
        Dim sekolah As New Sekolah
        sekolah.Show()
        Me.Close()
    End Sub
End Class