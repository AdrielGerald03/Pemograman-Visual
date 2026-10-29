Option Strict On

''' <summary>File Designer yang dibuat otomatis oleh Visual Studio. Mengatur layout semua kontrol FrmPeminjaman.</summary>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPeminjaman
    Inherits System.Windows.Forms.Form

    ' Diperlukan oleh Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Bersihkan semua resource yang digunakan
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

    ' Prosedur yang dibutuhkan Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()

        ' Deklarasi semua kontrol
        Me.lblJudulForm = New System.Windows.Forms.Label()
        Me.lblKodeBuku = New System.Windows.Forms.Label()
        Me.txtKodeBuku = New System.Windows.Forms.TextBox()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.cboKategori = New System.Windows.Forms.ComboBox()
        Me.lblNamaPeminjam = New System.Windows.Forms.Label()
        Me.txtNamaPeminjam = New System.Windows.Forms.TextBox()
        Me.lblLamaPinjam = New System.Windows.Forms.Label()
        Me.txtLamaPinjam = New System.Windows.Forms.TextBox()
        Me.btnPinjam = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnEkspor = New System.Windows.Forms.Button()
        Me.lstPeminjaman = New System.Windows.Forms.ListBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.errPinjam = New System.Windows.Forms.ErrorProvider(components)

        CType(Me.errPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ----------------------------------------------------------------
        ' lblJudulForm
        ' ----------------------------------------------------------------
        Me.lblJudulForm.AutoSize = True
        Me.lblJudulForm.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudulForm.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.lblJudulForm.Location = New System.Drawing.Point(20, 15)
        Me.lblJudulForm.Name = "lblJudulForm"
        Me.lblJudulForm.Size = New System.Drawing.Size(220, 30)
        Me.lblJudulForm.TabIndex = 0
        Me.lblJudulForm.Text = "Peminjaman Buku"

        ' ----------------------------------------------------------------
        ' lblKodeBuku
        ' ----------------------------------------------------------------
        Me.lblKodeBuku.AutoSize = True
        Me.lblKodeBuku.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKodeBuku.Location = New System.Drawing.Point(20, 60)
        Me.lblKodeBuku.Name = "lblKodeBuku"
        Me.lblKodeBuku.Size = New System.Drawing.Size(70, 15)
        Me.lblKodeBuku.TabIndex = 1
        Me.lblKodeBuku.Text = "Kode Buku"

        ' ----------------------------------------------------------------
        ' txtKodeBuku
        ' ----------------------------------------------------------------
        Me.txtKodeBuku.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKodeBuku.Location = New System.Drawing.Point(20, 78)
        Me.txtKodeBuku.MaxLength = 6
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.Size = New System.Drawing.Size(290, 23)
        Me.txtKodeBuku.TabIndex = 2

        ' ----------------------------------------------------------------
        ' lblJudul
        ' ----------------------------------------------------------------
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblJudul.Location = New System.Drawing.Point(20, 112)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(55, 15)
        Me.lblJudul.TabIndex = 3
        Me.lblJudul.Text = "Judul Buku"

        ' ----------------------------------------------------------------
        ' txtJudul
        ' ----------------------------------------------------------------
        Me.txtJudul.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJudul.Location = New System.Drawing.Point(20, 130)
        Me.txtJudul.MaxLength = 100
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(290, 23)
        Me.txtJudul.TabIndex = 4

        ' ----------------------------------------------------------------
        ' lblKategori
        ' ----------------------------------------------------------------
        Me.lblKategori.AutoSize = True
        Me.lblKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKategori.Location = New System.Drawing.Point(20, 164)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(52, 15)
        Me.lblKategori.TabIndex = 5
        Me.lblKategori.Text = "Kategori"

        ' ----------------------------------------------------------------
        ' cboKategori
        ' ----------------------------------------------------------------
        Me.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        Me.cboKategori.Location = New System.Drawing.Point(20, 182)
        Me.cboKategori.Name = "cboKategori"
        Me.cboKategori.Size = New System.Drawing.Size(290, 23)
        Me.cboKategori.TabIndex = 6

        ' ----------------------------------------------------------------
        ' lblNamaPeminjam
        ' ----------------------------------------------------------------
        Me.lblNamaPeminjam.AutoSize = True
        Me.lblNamaPeminjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaPeminjam.Location = New System.Drawing.Point(20, 216)
        Me.lblNamaPeminjam.Name = "lblNamaPeminjam"
        Me.lblNamaPeminjam.Size = New System.Drawing.Size(85, 15)
        Me.lblNamaPeminjam.TabIndex = 7
        Me.lblNamaPeminjam.Text = "Nama Peminjam"

        ' ----------------------------------------------------------------
        ' txtNamaPeminjam
        ' ----------------------------------------------------------------
        Me.txtNamaPeminjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaPeminjam.Location = New System.Drawing.Point(20, 234)
        Me.txtNamaPeminjam.MaxLength = 100
        Me.txtNamaPeminjam.Name = "txtNamaPeminjam"
        Me.txtNamaPeminjam.Size = New System.Drawing.Size(290, 23)
        Me.txtNamaPeminjam.TabIndex = 8

        ' ----------------------------------------------------------------
        ' lblLamaPinjam
        ' ----------------------------------------------------------------
        Me.lblLamaPinjam.AutoSize = True
        Me.lblLamaPinjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLamaPinjam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLamaPinjam.Location = New System.Drawing.Point(20, 268)
        Me.lblLamaPinjam.Name = "lblLamaPinjam"
        Me.lblLamaPinjam.Size = New System.Drawing.Size(100, 15)
        Me.lblLamaPinjam.TabIndex = 9
        Me.lblLamaPinjam.Text = "Lama Pinjam (hari)"

        ' ----------------------------------------------------------------
        ' txtLamaPinjam
        ' ----------------------------------------------------------------
        Me.txtLamaPinjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLamaPinjam.Location = New System.Drawing.Point(20, 286)
        Me.txtLamaPinjam.MaxLength = 2
        Me.txtLamaPinjam.Name = "txtLamaPinjam"
        Me.txtLamaPinjam.Size = New System.Drawing.Size(290, 23)
        Me.txtLamaPinjam.TabIndex = 10

        ' ----------------------------------------------------------------
        ' btnPinjam
        ' ----------------------------------------------------------------
        Me.btnPinjam.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPinjam.FlatAppearance.BorderSize = 0
        Me.btnPinjam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPinjam.ForeColor = System.Drawing.Color.White
        Me.btnPinjam.Location = New System.Drawing.Point(20, 325)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.Size = New System.Drawing.Size(90, 30)
        Me.btnPinjam.TabIndex = 11
        Me.btnPinjam.Text = "Pinjam"
        Me.btnPinjam.UseVisualStyleBackColor = False

        ' ----------------------------------------------------------------
        ' btnBersihkan
        ' ----------------------------------------------------------------
        Me.btnBersihkan.CausesValidation = False
        Me.btnBersihkan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBersihkan.Location = New System.Drawing.Point(120, 325)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(90, 30)
        Me.btnBersihkan.TabIndex = 12
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True

        ' ----------------------------------------------------------------
        ' btnEkspor
        ' ----------------------------------------------------------------
        Me.btnEkspor.CausesValidation = False
        Me.btnEkspor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEkspor.Location = New System.Drawing.Point(330, 325)
        Me.btnEkspor.Name = "btnEkspor"
        Me.btnEkspor.Size = New System.Drawing.Size(100, 30)
        Me.btnEkspor.TabIndex = 13
        Me.btnEkspor.Text = "Ekspor CSV"
        Me.btnEkspor.UseVisualStyleBackColor = True

        ' ----------------------------------------------------------------
        ' lstPeminjaman
        ' ----------------------------------------------------------------
        Me.lstPeminjaman.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lstPeminjaman.HorizontalScrollbar = True
        Me.lstPeminjaman.IntegralHeight = False
        Me.lstPeminjaman.Location = New System.Drawing.Point(340, 60)
        Me.lstPeminjaman.Name = "lstPeminjaman"
        Me.lstPeminjaman.Size = New System.Drawing.Size(430, 285)
        Me.lstPeminjaman.TabIndex = 14

        ' ----------------------------------------------------------------
        ' lblStatus
        ' ----------------------------------------------------------------
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.lblStatus.Location = New System.Drawing.Point(18, 368)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(752, 20)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Siap."

        ' ----------------------------------------------------------------
        ' errPinjam (ErrorProvider)
        ' ----------------------------------------------------------------
        Me.errPinjam.ContainerControl = Me

        ' ----------------------------------------------------------------
        ' FrmPeminjaman (Form itu sendiri)
        ' ----------------------------------------------------------------
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 400)
        Me.Controls.Add(Me.lblJudulForm)
        Me.Controls.Add(Me.lblKodeBuku)
        Me.Controls.Add(Me.txtKodeBuku)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.lblKategori)
        Me.Controls.Add(Me.cboKategori)
        Me.Controls.Add(Me.lblNamaPeminjam)
        Me.Controls.Add(Me.txtNamaPeminjam)
        Me.Controls.Add(Me.lblLamaPinjam)
        Me.Controls.Add(Me.txtLamaPinjam)
        Me.Controls.Add(Me.btnPinjam)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnEkspor)
        Me.Controls.Add(Me.lstPeminjaman)
        Me.Controls.Add(Me.lblStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman Buku"

        CType(Me.errPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    ' Deklarasi variabel kontrol (sesuai tabel di tugas.md)
    Friend WithEvents lblJudulForm As System.Windows.Forms.Label
    Friend WithEvents lblKodeBuku As System.Windows.Forms.Label
    Friend WithEvents txtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaPeminjam As System.Windows.Forms.Label
    Friend WithEvents txtNamaPeminjam As System.Windows.Forms.TextBox
    Friend WithEvents lblLamaPinjam As System.Windows.Forms.Label
    Friend WithEvents txtLamaPinjam As System.Windows.Forms.TextBox
    Friend WithEvents btnPinjam As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents btnEkspor As System.Windows.Forms.Button
    Friend WithEvents lstPeminjaman As System.Windows.Forms.ListBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents errPinjam As System.Windows.Forms.ErrorProvider

End Class
