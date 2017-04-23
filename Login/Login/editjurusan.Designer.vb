<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editjurusan
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.nama = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.kode = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(23, 50)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "nama"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(23, 94)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(42, 19)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "kode"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(159, 191)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(75, 23)
        Me.MaterialRaisedButton1.TabIndex = 2
        Me.MaterialRaisedButton1.Text = "Edit"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'nama
        '
        Me.nama.Depth = 0
        Me.nama.Hint = ""
        Me.nama.Location = New System.Drawing.Point(103, 50)
        Me.nama.MouseState = MaterialSkin.MouseState.HOVER
        Me.nama.Name = "nama"
        Me.nama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nama.SelectedText = ""
        Me.nama.SelectionLength = 0
        Me.nama.SelectionStart = 0
        Me.nama.Size = New System.Drawing.Size(75, 23)
        Me.nama.TabIndex = 3
        Me.nama.UseSystemPasswordChar = False
        '
        'kode
        '
        Me.kode.Depth = 0
        Me.kode.Hint = ""
        Me.kode.Location = New System.Drawing.Point(103, 90)
        Me.kode.MouseState = MaterialSkin.MouseState.HOVER
        Me.kode.Name = "kode"
        Me.kode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kode.SelectedText = ""
        Me.kode.SelectionLength = 0
        Me.kode.SelectionStart = 0
        Me.kode.Size = New System.Drawing.Size(75, 23)
        Me.kode.TabIndex = 4
        Me.kode.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(27, 191)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(75, 23)
        Me.MaterialRaisedButton2.TabIndex = 5
        Me.MaterialRaisedButton2.Text = "back"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'editjurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "editjurusan"
        Me.Text = "editjurusan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents nama As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents kode As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
End Class
