Public Class InsertNilaiTest
    Dim dal As New DAL
    Dim idmahasiswa As String
    Private Sub InsertNilaiTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
        DataGridView1.Columns.Item("mahasiswa_id").Visible = False
        Dim button As New DataGridViewButtonColumn
        button.UseColumnTextForButtonValue = True
        button.Text = "Pilih"
        button.Name = ""
        DataGridView1.Columns.Add(button)
    End Sub

    Private Sub isidgv()
        Dim data As New DataSet
        data = dal.getmahasiswanotest
        DataGridView1.DataSource = data.Tables(0)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "" Then
            idmahasiswa = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("mahasiswa_id").Value
        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.insertnilaitest(idmahasiswa, nilai.Text))
        MaterialTabControl1.SelectedIndex = 2
        Dim data As DataSet
        data = dal.getmahasiswa(idmahasiswa)
        nama.Text = data.Tables(0).Rows(0).Item("mahasiswa_nama")
        status.Text = data.Tables(0).Rows(0).Item("mahasiswa_status")
        testnilai.Text = data.Tables(0).Rows(0).Item("test_nilai")

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        MaterialTabControl1.SelectedIndex = MaterialTabControl1.TabIndex + 1
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class