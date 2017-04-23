Public Class editmahasiswa
    Dim dal As New DAL
    Private Sub editmahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = dal.getmahasiswa(id)

        isidata()
        cbxjurusan.SelectedValue = data.Tables(0).Rows(0).Item("jurusan_id")
        lblnama.Text = data.Tables(0).Rows(0).Item("mahasiswa_nama")
        lbltempatlahir.Text = data.Tables(0).Rows(0).Item("mahasiswa_tempatlahir")
        tanggallahirmahasiswa.Value = data.Tables(0).Rows(0).Item("mahasiswa_tanggallahir")

        If (data.Tables(0).Rows(0).Item("mahasiswa_jeniskelamin") = "Laki") Then
            Pria.Checked = True
        Else
            Wanita.Checked = True
        End If

        alamatmahasiswa.Text = data.Tables(0).Rows(0).Item("mahasiswa_alamat")
        nohpmahasiwa.Text = data.Tables(0).Rows(0).Item("mahasiswa_nohp")
        emailmahasiswa.Text = data.Tables(0).Rows(0).Item("mahasiswa_email")

    End Sub
    Public id As String

    Private Sub isidata()
        Dim data As DataSet
        Dim data1 As DataSet
        Dim data2 As DataSet
        data = dal.getalljurusan
        data1 = dal.getallsekolah
        data2 = dal.getallwali
        cbxjurusan.DataSource = data.Tables(0)
        cbxjurusan.ValueMember = "jurusan_id"
        cbxjurusan.DisplayMember = "nama"
        DataGridView1.DataSource = data1.Tables(0)
        DataGridView2.DataSource = data2.Tables(0)
    End Sub
End Class