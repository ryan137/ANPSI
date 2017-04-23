Public Class Jurusan
    Dim dal As New DAL

    Private Sub jurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isidgv()
        Dim Button As New DataGridViewButtonColumn()
        Dim Button1 As New DataGridViewButtonColumn()
        Button1.UseColumnTextForButtonValue = True
        Button1.Text = "Delete"
        Button1.Name = "  "
        Button.UseColumnTextForButtonValue = True
        Button.Text = "Edit"
        Button.Name = " "
        DataGridView1.Columns.Add(Button)
        DataGridView1.Columns.Add(Button1)


    End Sub

    Public Sub isidgv()
        Dim data As DataSet
        data = dal.getalljurusan()
        DataGridView1.DataSource = data.Tables(0)


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub namajurusan_Click(sender As Object, e As EventArgs) Handles namajurusan.Click

    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click

    End Sub
End Class