<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCariList
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
        lblCari = New System.Windows.Forms.Label()
        txtCari = New System.Windows.Forms.TextBox()
        dgvMahasiswa = New System.Windows.Forms.DataGridView()
        lblJumlah = New System.Windows.Forms.Label()
        bsMahasiswa = New System.Windows.Forms.BindingSource(components)
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        lblJudul.Location = New System.Drawing.Point(25, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(287, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Mencari di List(Of Mahasiswa)"
        '
        'lblCari
        '
        lblCari.AutoSize = True
        lblCari.Location = New System.Drawing.Point(25, 65)
        lblCari.Name = "lblCari"
        lblCari.Size = New System.Drawing.Size(89, 15)
        lblCari.TabIndex = 1
        lblCari.Text = "Cari nama/NIM:"
        '
        'txtCari
        '
        txtCari.Location = New System.Drawing.Point(125, 62)
        txtCari.Name = "txtCari"
        txtCari.Size = New System.Drawing.Size(565, 23)
        txtCari.TabIndex = 2
        '
        'dgvMahasiswa
        '
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New System.Drawing.Point(25, 100)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New System.Drawing.Size(665, 270)
        dgvMahasiswa.TabIndex = 3
        '
        'lblJumlah
        '
        lblJumlah.AutoSize = True
        lblJumlah.Location = New System.Drawing.Point(25, 385)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New System.Drawing.Size(115, 15)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Menampilkan 0 data"
        '
        'FrmCariList
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(714, 416)
        Controls.Add(lblJumlah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmCariList"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Pencarian dengan Perulangan"
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents bsMahasiswa As System.Windows.Forms.BindingSource
End Class
