Public Class insertjurusan
    Dim dal As New DAL
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MessageBox.Show(dal.insertjurusan(namajurusan.Text, kodejurusan.Text))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim jurusan As New Jurusan
        jurusan.Show()
        Me.Close()
    End Sub
End Class