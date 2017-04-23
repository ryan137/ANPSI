<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertNilaiTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.nilai = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.keterangan = New MaterialSkin.Controls.MaterialLabel()
        Me.testnilai = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.status = New MaterialSkin.Controls.MaterialLabel()
        Me.nama = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(525, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(12, 41)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(545, 282)
        Me.MaterialTabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(537, 256)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pilih Mahasiswa"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.MaterialRaisedButton1)
        Me.TabPage2.Controls.Add(Me.nilai)
        Me.TabPage2.Controls.Add(Me.MaterialLabel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(537, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nilai"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(381, 95)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(68, 36)
        Me.MaterialRaisedButton1.TabIndex = 2
        Me.MaterialRaisedButton1.Text = "Insert"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'nilai
        '
        Me.nilai.Depth = 0
        Me.nilai.Hint = ""
        Me.nilai.Location = New System.Drawing.Point(104, 28)
        Me.nilai.MaxLength = 32767
        Me.nilai.MouseState = MaterialSkin.MouseState.HOVER
        Me.nilai.Name = "nilai"
        Me.nilai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nilai.SelectedText = ""
        Me.nilai.SelectionLength = 0
        Me.nilai.SelectionStart = 0
        Me.nilai.Size = New System.Drawing.Size(270, 23)
        Me.nilai.TabIndex = 1
        Me.nilai.TabStop = False
        Me.nilai.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(31, 28)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(40, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Nilai"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MaterialRaisedButton2)
        Me.TabPage3.Controls.Add(Me.keterangan)
        Me.TabPage3.Controls.Add(Me.testnilai)
        Me.TabPage3.Controls.Add(Me.MaterialLabel3)
        Me.TabPage3.Controls.Add(Me.status)
        Me.TabPage3.Controls.Add(Me.nama)
        Me.TabPage3.Controls.Add(Me.MaterialLabel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(537, 256)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Hasil"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Nothing
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(246, 147)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(56, 36)
        Me.MaterialRaisedButton2.TabIndex = 7
        Me.MaterialRaisedButton2.Text = "Back"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'keterangan
        '
        Me.keterangan.AutoSize = True
        Me.keterangan.Depth = 0
        Me.keterangan.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.keterangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keterangan.Location = New System.Drawing.Point(36, 90)
        Me.keterangan.MouseState = MaterialSkin.MouseState.HOVER
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(0, 19)
        Me.keterangan.TabIndex = 6
        '
        'testnilai
        '
        Me.testnilai.AutoSize = True
        Me.testnilai.Depth = 0
        Me.testnilai.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.testnilai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.testnilai.Location = New System.Drawing.Point(242, 57)
        Me.testnilai.MouseState = MaterialSkin.MouseState.HOVER
        Me.testnilai.Name = "testnilai"
        Me.testnilai.Size = New System.Drawing.Size(65, 19)
        Me.testnilai.TabIndex = 4
        Me.testnilai.Text = "              "
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(130, 57)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(94, 19)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "Dengan Nilai"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Depth = 0
        Me.status.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.status.Location = New System.Drawing.Point(36, 57)
        Me.status.MouseState = MaterialSkin.MouseState.HOVER
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(73, 19)
        Me.status.TabIndex = 2
        Me.status.Text = "                "
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Depth = 0
        Me.nama.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.nama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nama.Location = New System.Drawing.Point(130, 25)
        Me.nama.MouseState = MaterialSkin.MouseState.HOVER
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(61, 19)
        Me.nama.TabIndex = 1
        Me.nama.Text = "             "
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(36, 25)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel2.TabIndex = 0
        Me.MaterialLabel2.Text = "Mahasiswa,"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Enabled = False
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(12, 12)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(545, 23)
        Me.MaterialTabSelector1.TabIndex = 9
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'InsertNilaiTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 335)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Name = "InsertNilaiTest"
        Me.Text = "InsertNilaiTest"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents nilai As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents keterangan As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents testnilai As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents status As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents nama As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
End Class
