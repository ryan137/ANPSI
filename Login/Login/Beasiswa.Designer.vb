﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Beasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.nama = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.bpp = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.sks = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 19)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(117, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Nama Beasiswa"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 51)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "Potong BPP"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 89)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel3.TabIndex = 2
        Me.MaterialLabel3.Text = "Potong SKS"
        '
        'nama
        '
        Me.nama.Depth = 0
        Me.nama.Hint = ""
        Me.nama.Location = New System.Drawing.Point(145, 19)
        Me.nama.MouseState = MaterialSkin.MouseState.HOVER
        Me.nama.Name = "nama"
        Me.nama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nama.SelectedText = ""
        Me.nama.SelectionLength = 0
        Me.nama.SelectionStart = 0
        Me.nama.Size = New System.Drawing.Size(315, 23)
        Me.nama.TabIndex = 3
        Me.nama.UseSystemPasswordChar = False
        '
        'bpp
        '
        Me.bpp.Depth = 0
        Me.bpp.Hint = ""
        Me.bpp.Location = New System.Drawing.Point(145, 51)
        Me.bpp.MouseState = MaterialSkin.MouseState.HOVER
        Me.bpp.Name = "bpp"
        Me.bpp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bpp.SelectedText = ""
        Me.bpp.SelectionLength = 0
        Me.bpp.SelectionStart = 0
        Me.bpp.Size = New System.Drawing.Size(315, 23)
        Me.bpp.TabIndex = 4
        Me.bpp.UseSystemPasswordChar = False
        '
        'sks
        '
        Me.sks.Depth = 0
        Me.sks.Hint = ""
        Me.sks.Location = New System.Drawing.Point(145, 85)
        Me.sks.MouseState = MaterialSkin.MouseState.HOVER
        Me.sks.Name = "sks"
        Me.sks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.sks.SelectedText = ""
        Me.sks.SelectionLength = 0
        Me.sks.SelectionStart = 0
        Me.sks.Size = New System.Drawing.Size(315, 23)
        Me.sks.TabIndex = 5
        Me.sks.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(385, 124)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(75, 23)
        Me.MaterialRaisedButton1.TabIndex = 6
        Me.MaterialRaisedButton1.Text = "Insert"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(641, 124)
        Me.DataGridView1.TabIndex = 7
        '
        'Beasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 311)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.sks)
        Me.Controls.Add(Me.bpp)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "Beasiswa"
        Me.Text = "Beasiswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents nama As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents bpp As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents sks As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents DataGridView1 As DataGridView
End Class
