Public Class NilaiTest
    Dim dal As New DAL
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim insert As New InsertNilaiTest
        insert.Show()
        Me.Close()
    End Sub

    Private Sub NilaiTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
        Dim button As New DataGridViewButtonColumn()
        Dim button1 As New DataGridViewButtonColumn()
        button.UseColumnTextForButtonValue = True
        button1.UseColumnTextForButtonValue = True
        button1.Text = "Delete"
        button1.Name = " "
        button.Text = "Edit"
        button.Name = ""
        DataGridView1.Columns.Add(button)
        DataGridView1.Columns.Add(button1)
        DataGridView1.Columns.Item("mahasiswa_id").Visible = False
    End Sub
    Private Sub isidgv()
        Dim data As New DataSet
        data = dal.getalltest()
        DataGridView1.DataSource = data.Tables(0)
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        If nama.Text = "" Then
            isidgv()
        Else
            Dim data As New DataSet
            data = dal.searchtest(nama.Text, "")
            DataGridView1.DataSource = data.Tables(0)
        End If
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "" Then
            Dim edit As New EditNilaiTest
            edit.id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("mahasiswa_id").Value
            edit.Show()
            Me.Close()
        Else
            dal.deletetestnilai(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item("mahasiswa_id").Value)
            isidgv()
        End If
    End Sub
End Class