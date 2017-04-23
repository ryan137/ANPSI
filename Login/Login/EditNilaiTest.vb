Public Class EditNilaiTest
    Dim dal As New DAL
    Private Sub EditNilaiTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = dal.searchtest("", id)
        nama.Text = data.Tables(0).Rows(0).Item("mahasiswa_nama")
        test.Text = data.Tables(0).Rows(0).Item("test_nilai")
    End Sub
    Public id As String

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles test.Click

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.EditNilaiTest(id, test.Text))
    End Sub
End Class