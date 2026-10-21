<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventarisBuku
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
        components = New System.ComponentModel.Container()
        lblJudulForm = New System.Windows.Forms.Label()
        lblKodeBuku = New System.Windows.Forms.Label()
        txtKodeBuku = New System.Windows.Forms.TextBox()
        lblJudulBuku = New System.Windows.Forms.Label()
        txtJudul = New System.Windows.Forms.TextBox()
        lblPenulis = New System.Windows.Forms.Label()
        txtPenulis = New System.Windows.Forms.TextBox()
        lblKategori = New System.Windows.Forms.Label()
        cboKategori = New System.Windows.Forms.ComboBox()
        lblTahun = New System.Windows.Forms.Label()
        txtTahun = New System.Windows.Forms.TextBox()
        lblStok = New System.Windows.Forms.Label()
        txtStok = New System.Windows.Forms.TextBox()
        btnTambah = New System.Windows.Forms.Button()
        btnBersihkan = New System.Windows.Forms.Button()
        lblCari = New System.Windows.Forms.Label()
        txtCari = New System.Windows.Forms.TextBox()
        lblFilterKategori = New System.Windows.Forms.Label()
        cboFilterKategori = New System.Windows.Forms.ComboBox()
        chkStokHabis = New System.Windows.Forms.CheckBox()
        lblUrutkan = New System.Windows.Forms.Label()
        cboUrut = New System.Windows.Forms.ComboBox()
        dgvBuku = New System.Windows.Forms.DataGridView()
        lblJumlah = New System.Windows.Forms.Label()
        lblTotalStok = New System.Windows.Forms.Label()
        bsBuku = New System.Windows.Forms.BindingSource(components)
        errBuku = New System.Windows.Forms.ErrorProvider(components)
        CType(dgvBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudulForm
        '
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        lblJudulForm.Location = New System.Drawing.Point(25, 20)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New System.Drawing.Size(262, 25)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        '
        'lblKodeBuku
        '
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New System.Drawing.Point(25, 65)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New System.Drawing.Size(64, 15)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode buku"
        '
        'txtKodeBuku
        '
        txtKodeBuku.Location = New System.Drawing.Point(25, 88)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New System.Drawing.Size(260, 23)
        txtKodeBuku.TabIndex = 2
        '
        'lblJudulBuku
        '
        lblJudulBuku.AutoSize = True
        lblJudulBuku.Location = New System.Drawing.Point(25, 125)
        lblJudulBuku.Name = "lblJudulBuku"
        lblJudulBuku.Size = New System.Drawing.Size(65, 15)
        lblJudulBuku.TabIndex = 3
        lblJudulBuku.Text = "Judul buku"
        '
        'txtJudul
        '
        txtJudul.Location = New System.Drawing.Point(25, 148)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New System.Drawing.Size(260, 23)
        txtJudul.TabIndex = 4
        '
        'lblPenulis
        '
        lblPenulis.AutoSize = True
        lblPenulis.Location = New System.Drawing.Point(25, 185)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New System.Drawing.Size(44, 15)
        lblPenulis.TabIndex = 5
        lblPenulis.Text = "Penulis"
        '
        'txtPenulis
        '
        txtPenulis.Location = New System.Drawing.Point(25, 208)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New System.Drawing.Size(260, 23)
        txtPenulis.TabIndex = 6
        '
        'lblKategori
        '
        lblKategori.AutoSize = True
        lblKategori.Location = New System.Drawing.Point(25, 245)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New System.Drawing.Size(51, 15)
        lblKategori.TabIndex = 7
        lblKategori.Text = "Kategori"
        '
        'cboKategori
        '
        cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New System.Drawing.Point(25, 268)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New System.Drawing.Size(260, 23)
        cboKategori.TabIndex = 8
        '
        'lblTahun
        '
        lblTahun.AutoSize = True
        lblTahun.Location = New System.Drawing.Point(25, 305)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New System.Drawing.Size(73, 15)
        lblTahun.TabIndex = 9
        lblTahun.Text = "Tahun terbit"
        '
        'txtTahun
        '
        txtTahun.Location = New System.Drawing.Point(25, 328)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New System.Drawing.Size(260, 23)
        txtTahun.TabIndex = 10
        '
        'lblStok
        '
        lblStok.AutoSize = True
        lblStok.Location = New System.Drawing.Point(25, 365)
        lblStok.Name = "lblStok"
        lblStok.Size = New System.Drawing.Size(30, 15)
        lblStok.TabIndex = 11
        lblStok.Text = "Stok"
        '
        'txtStok
        '
        txtStok.Location = New System.Drawing.Point(25, 388)
        txtStok.Name = "txtStok"
        txtStok.Size = New System.Drawing.Size(260, 23)
        txtStok.TabIndex = 12
        '
        'btnTambah
        '
        btnTambah.Location = New System.Drawing.Point(25, 435)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New System.Drawing.Size(125, 32)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        btnBersihkan.Location = New System.Drawing.Point(160, 435)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New System.Drawing.Size(125, 32)
        btnBersihkan.TabIndex = 14
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        '
        'lblCari
        '
        lblCari.AutoSize = True
        lblCari.Location = New System.Drawing.Point(325, 65)
        lblCari.Name = "lblCari"
        lblCari.Size = New System.Drawing.Size(100, 15)
        lblCari.TabIndex = 15
        lblCari.Text = "Cari judul/penulis"
        '
        'txtCari
        '
        txtCari.Location = New System.Drawing.Point(325, 88)
        txtCari.Name = "txtCari"
        txtCari.Size = New System.Drawing.Size(630, 23)
        txtCari.TabIndex = 16
        '
        'lblFilterKategori
        '
        lblFilterKategori.AutoSize = True
        lblFilterKategori.Location = New System.Drawing.Point(325, 125)
        lblFilterKategori.Name = "lblFilterKategori"
        lblFilterKategori.Size = New System.Drawing.Size(80, 15)
        lblFilterKategori.TabIndex = 17
        lblFilterKategori.Text = "Filter kategori"
        '
        'cboFilterKategori
        '
        cboFilterKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboFilterKategori.Location = New System.Drawing.Point(325, 148)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New System.Drawing.Size(185, 23)
        cboFilterKategori.TabIndex = 18
        '
        'chkStokHabis
        '
        chkStokHabis.AutoSize = True
        chkStokHabis.Location = New System.Drawing.Point(530, 150)
        chkStokHabis.Name = "chkStokHabis"
        chkStokHabis.Size = New System.Drawing.Size(113, 19)
        chkStokHabis.TabIndex = 19
        chkStokHabis.Text = "Hanya stok habis"
        chkStokHabis.UseVisualStyleBackColor = True
        '
        'lblUrutkan
        '
        lblUrutkan.AutoSize = True
        lblUrutkan.Location = New System.Drawing.Point(725, 125)
        lblUrutkan.Name = "lblUrutkan"
        lblUrutkan.Size = New System.Drawing.Size(76, 15)
        lblUrutkan.TabIndex = 20
        lblUrutkan.Text = "Urutkan buku"
        '
        'cboUrut
        '
        cboUrut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        cboUrut.Location = New System.Drawing.Point(725, 148)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New System.Drawing.Size(230, 23)
        cboUrut.TabIndex = 21
        '
        'dgvBuku
        '
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AllowUserToDeleteRows = False
        dgvBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New System.Drawing.Point(325, 185)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New System.Drawing.Size(630, 310)
        dgvBuku.TabIndex = 22
        '
        'lblJumlah
        '
        lblJumlah.AutoSize = True
        lblJumlah.Location = New System.Drawing.Point(325, 515)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New System.Drawing.Size(149, 15)
        lblJumlah.TabIndex = 23
        lblJumlah.Text = "Menampilkan 0 dari 0 buku"
        '
        'lblTotalStok
        '
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New System.Drawing.Point(325, 545)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New System.Drawing.Size(127, 15)
        lblTotalStok.TabIndex = 24
        lblTotalStok.Text = "Total stok yang tampil: 0"
        '
        'errBuku
        '
        errBuku.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        errBuku.ContainerControl = Me
        '
        'FrmInventarisBuku
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(984, 591)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(dgvBuku)
        Controls.Add(cboUrut)
        Controls.Add(lblUrutkan)
        Controls.Add(chkStokHabis)
        Controls.Add(cboFilterKategori)
        Controls.Add(lblFilterKategori)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(txtStok)
        Controls.Add(lblStok)
        Controls.Add(txtTahun)
        Controls.Add(lblTahun)
        Controls.Add(cboKategori)
        Controls.Add(lblKategori)
        Controls.Add(txtPenulis)
        Controls.Add(lblPenulis)
        Controls.Add(txtJudul)
        Controls.Add(lblJudulBuku)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmInventarisBuku"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Inventaris Buku Perpustakaan"
        CType(dgvBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As System.Windows.Forms.Label
    Friend WithEvents lblKodeBuku As System.Windows.Forms.Label
    Friend WithEvents txtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents lblJudulBuku As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblPenulis As System.Windows.Forms.Label
    Friend WithEvents txtPenulis As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblTahun As System.Windows.Forms.Label
    Friend WithEvents txtTahun As System.Windows.Forms.TextBox
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents lblFilterKategori As System.Windows.Forms.Label
    Friend WithEvents cboFilterKategori As System.Windows.Forms.ComboBox
    Friend WithEvents chkStokHabis As System.Windows.Forms.CheckBox
    Friend WithEvents lblUrutkan As System.Windows.Forms.Label
    Friend WithEvents cboUrut As System.Windows.Forms.ComboBox
    Friend WithEvents dgvBuku As System.Windows.Forms.DataGridView
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents lblTotalStok As System.Windows.Forms.Label
    Friend WithEvents bsBuku As System.Windows.Forms.BindingSource
    Friend WithEvents errBuku As System.Windows.Forms.ErrorProvider
End Class
