<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDariArray
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
        lblJudul = New System.Windows.Forms.Label()
        dgvMahasiswa = New System.Windows.Forms.DataGridView()
        colNim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colJurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colAngkatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colIpk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        btnTampilkan = New System.Windows.Forms.Button()
        btnKosongkan = New System.Windows.Forms.Button()
        lblJumlah = New System.Windows.Forms.Label()
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        lblJudul.Location = New System.Drawing.Point(25, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(248, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Data dari Array 2 Dimensi"
        '
        'dgvMahasiswa
        '
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {colNim, colNama, colJurusan, colAngkatan, colIpk})
        dgvMahasiswa.Location = New System.Drawing.Point(25, 60)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New System.Drawing.Size(665, 260)
        dgvMahasiswa.TabIndex = 1
        '
        'colNim
        '
        colNim.HeaderText = "NIM"
        colNim.Name = "colNim"
        colNim.ReadOnly = True
        '
        'colNama
        '
        colNama.HeaderText = "Nama"
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        '
        'colJurusan
        '
        colJurusan.HeaderText = "Jurusan"
        colJurusan.Name = "colJurusan"
        colJurusan.ReadOnly = True
        '
        'colAngkatan
        '
        colAngkatan.HeaderText = "Angkatan"
        colAngkatan.Name = "colAngkatan"
        colAngkatan.ReadOnly = True
        '
        'colIpk
        '
        colIpk.HeaderText = "IPK"
        colIpk.Name = "colIpk"
        colIpk.ReadOnly = True
        '
        'btnTampilkan
        '
        btnTampilkan.Location = New System.Drawing.Point(25, 335)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New System.Drawing.Size(100, 32)
        btnTampilkan.TabIndex = 2
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        '
        'btnKosongkan
        '
        btnKosongkan.Location = New System.Drawing.Point(135, 335)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New System.Drawing.Size(100, 32)
        btnKosongkan.TabIndex = 3
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = True
        '
        'lblJumlah
        '
        lblJumlah.AutoSize = True
        lblJumlah.Location = New System.Drawing.Point(260, 344)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New System.Drawing.Size(86, 15)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Jumlah data: 0"
        '
        'FrmDariArray
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(714, 381)
        Controls.Add(lblJumlah)
        Controls.Add(btnKosongkan)
        Controls.Add(btnTampilkan)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariArray"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "DataGridView dari Array"
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents colNim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colJurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAngkatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIpk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents btnKosongkan As System.Windows.Forms.Button
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
End Class
