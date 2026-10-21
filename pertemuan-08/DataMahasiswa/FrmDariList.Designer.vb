<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDariList
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        lblJudul = New System.Windows.Forms.Label()
        lblNim = New System.Windows.Forms.Label()
        txtNim = New System.Windows.Forms.TextBox()
        lblNama = New System.Windows.Forms.Label()
        txtNama = New System.Windows.Forms.TextBox()
        lblJurusan = New System.Windows.Forms.Label()
        cboJurusan = New System.Windows.Forms.ComboBox()
        lblAngkatan = New System.Windows.Forms.Label()
        txtAngkatan = New System.Windows.Forms.TextBox()
        lblIpk = New System.Windows.Forms.Label()
        txtIpk = New System.Windows.Forms.TextBox()
        btnTambah = New System.Windows.Forms.Button()
        dgvMahasiswa = New System.Windows.Forms.DataGridView()
        lblJumlah = New System.Windows.Forms.Label()
        bsMahasiswa = New System.Windows.Forms.BindingSource(components)
        errInput = New System.Windows.Forms.ErrorProvider(components)
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        lblJudul.Location = New System.Drawing.Point(25, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(342, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "List(Of Mahasiswa) + BindingSource"
        '
        'lblNim
        '
        lblNim.AutoSize = True
        lblNim.Location = New System.Drawing.Point(25, 55)
        lblNim.Name = "lblNim"
        lblNim.Size = New System.Drawing.Size(30, 15)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        '
        'txtNim
        '
        txtNim.Location = New System.Drawing.Point(25, 75)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New System.Drawing.Size(120, 23)
        txtNim.TabIndex = 2
        '
        'lblNama
        '
        lblNama.AutoSize = True
        lblNama.Location = New System.Drawing.Point(165, 55)
        lblNama.Name = "lblNama"
        lblNama.Size = New System.Drawing.Size(39, 15)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        '
        'txtNama
        '
        txtNama.Location = New System.Drawing.Point(165, 75)
        txtNama.Name = "txtNama"
        txtNama.Size = New System.Drawing.Size(180, 23)
        txtNama.TabIndex = 4
        '
        'lblJurusan
        '
        lblJurusan.AutoSize = True
        lblJurusan.Location = New System.Drawing.Point(365, 55)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New System.Drawing.Size(47, 15)
        lblJurusan.TabIndex = 5
        lblJurusan.Text = "Jurusan"
        '
        'cboJurusan
        '
        cboJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New System.Drawing.Point(365, 75)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New System.Drawing.Size(160, 23)
        cboJurusan.TabIndex = 6
        '
        'lblAngkatan
        '
        lblAngkatan.AutoSize = True
        lblAngkatan.Location = New System.Drawing.Point(545, 55)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New System.Drawing.Size(58, 15)
        lblAngkatan.TabIndex = 7
        lblAngkatan.Text = "Angkatan"
        '
        'txtAngkatan
        '
        txtAngkatan.Location = New System.Drawing.Point(545, 75)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New System.Drawing.Size(80, 23)
        txtAngkatan.TabIndex = 8
        '
        'lblIpk
        '
        lblIpk.AutoSize = True
        lblIpk.Location = New System.Drawing.Point(645, 55)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New System.Drawing.Size(24, 15)
        lblIpk.TabIndex = 9
        lblIpk.Text = "IPK"
        '
        'txtIpk
        '
        txtIpk.Location = New System.Drawing.Point(645, 75)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New System.Drawing.Size(70, 23)
        txtIpk.TabIndex = 10
        '
        'btnTambah
        '
        btnTambah.Location = New System.Drawing.Point(25, 115)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New System.Drawing.Size(100, 30)
        btnTambah.TabIndex = 11
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        '
        'dgvMahasiswa
        '
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New System.Drawing.Point(25, 155)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New System.Drawing.Size(700, 250)
        dgvMahasiswa.TabIndex = 12
        '
        'lblJumlah
        '
        lblJumlah.AutoSize = True
        lblJumlah.Location = New System.Drawing.Point(25, 420)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New System.Drawing.Size(86, 15)
        lblJumlah.TabIndex = 13
        lblJumlah.Text = "Jumlah data: 0"
        '
        'errInput
        '
        errInput.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        errInput.ContainerControl = Me
        '
        'FrmDariList
        '
        AcceptButton = btnTambah
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(754, 451)
        Controls.Add(lblJumlah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTambah)
        Controls.Add(txtIpk)
        Controls.Add(lblIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(lblAngkatan)
        Controls.Add(cboJurusan)
        Controls.Add(lblJurusan)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariList"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Binding List(Of Mahasiswa)"
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblNim As System.Windows.Forms.Label
    Friend WithEvents txtNim As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents cboJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents lblAngkatan As System.Windows.Forms.Label
    Friend WithEvents txtAngkatan As System.Windows.Forms.TextBox
    Friend WithEvents lblIpk As System.Windows.Forms.Label
    Friend WithEvents txtIpk As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents bsMahasiswa As System.Windows.Forms.BindingSource
    Friend WithEvents errInput As System.Windows.Forms.ErrorProvider
End Class
