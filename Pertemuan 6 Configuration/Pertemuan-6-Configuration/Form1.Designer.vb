<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnTampil = New Button()
        dgvMahasiswa = New DataGridView()
        lblNama = New Label()
        lblNIM = New Label()
        lblJurusan = New Label()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        txtJurusan = New TextBox()
        btnTambah = New Button()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(141, 273)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(112, 34)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(25, 26)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.Size = New Size(360, 225)
        dgvMahasiswa.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(469, 65)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama :"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(482, 141)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(55, 25)
        lblNIM.TabIndex = 3
        lblNIM.Text = "NIM :"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(454, 225)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(80, 25)
        lblJurusan.TabIndex = 4
        lblJurusan.Text = "Jurusan :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(551, 62)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(551, 138)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(150, 31)
        txtNIM.TabIndex = 6
        ' 
        ' txtJurusan
        ' 
        txtJurusan.Location = New Point(551, 223)
        txtJurusan.Name = "txtJurusan"
        txtJurusan.Size = New Size(150, 31)
        txtJurusan.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(526, 334)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnTambah)
        Controls.Add(txtJurusan)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(lblJurusan)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTampil)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents btnTambah As Button

End Class
