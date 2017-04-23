<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditNilaiTest
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
        Me.nama = New MaterialSkin.Controls.MaterialLabel()
        Me.test = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.labeltext = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(21, 27)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(49, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Nama"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Depth = 0
        Me.nama.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.nama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nama.Location = New System.Drawing.Point(106, 27)
        Me.nama.MouseState = MaterialSkin.MouseState.HOVER
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(77, 19)
        Me.nama.TabIndex = 1
        Me.nama.Text = "                 "
        '
        'test
        '
        Me.test.Depth = 0
        Me.test.Hint = ""
        Me.test.Location = New System.Drawing.Point(108, 61)
        Me.test.MouseState = MaterialSkin.MouseState.HOVER
        Me.test.Name = "test"
        Me.test.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.test.SelectedText = ""
        Me.test.SelectionLength = 0
        Me.test.SelectionStart = 0
        Me.test.Size = New System.Drawing.Size(204, 23)
        Me.test.TabIndex = 2
        Me.test.UseSystemPasswordChar = False
        '
        'labeltext
        '
        Me.labeltext.AutoSize = True
        Me.labeltext.Depth = 0
        Me.labeltext.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.labeltext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labeltext.Location = New System.Drawing.Point(21, 61)
        Me.labeltext.MouseState = MaterialSkin.MouseState.HOVER
        Me.labeltext.Name = "labeltext"
        Me.labeltext.Size = New System.Drawing.Size(40, 19)
        Me.labeltext.TabIndex = 3
        Me.labeltext.Text = "Nilai"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(225, 108)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(75, 23)
        Me.MaterialRaisedButton1.TabIndex = 4
        Me.MaterialRaisedButton1.Text = "Edit"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'EditNilaiTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 277)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.labeltext)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "EditNilaiTest"
        Me.Text = "EditNilaiTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents nama As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents test As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents labeltext As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
