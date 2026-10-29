

        ' Validasi nama peminjam (minimal 3 karakter setelah Trim)
        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
            valid = False
        End If

        ' Validasi lama pinjam (bilangan bulat 1-14 hari)
        Dim lamaPinjam As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text, lamaPinjam) OrElse
           lamaPinjam < 1 OrElse lamaPinjam > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus angka 1 sampai 14 hari.")
            valid = False
        End If

        Return valid
    End Function

    ' -------------------------------------------------------------------------
    ' Event Validating (Tantangan Tambahan)
    ' -------------------------------------------------------------------------

    ''' <summary>
    ''' Validasi format kode buku saat fokus meninggalkan txtKodeBuku.
    ''' e.Cancel tidak dipakai agar fokus bisa berpindah bebas.
    ''' </summary>
    Private Sub txtKodeBuku_Validating(sender As Object, e As CancelEventArgs) Handles txtKodeBuku.Validating
        If txtKodeBuku.Text = "" Then Return  ' kosong akan diperiksa saat tombol Pinjam ditekan
        If KodeBukuValid(txtKodeBuku.Text) Then
            errPinjam.SetError(txtKodeBuku, "")
        Else
            errPinjam.SetError(txtKodeBuku, "Kode buku harus BK diikuti 4 digit, contoh BK0012.")
        End If
    End Sub

    ' -------------------------------------------------------------------------
    ' Tombol Pinjam
    ' -------------------------------------------------------------------------

    ''' <summary>Mencatat peminjaman baru ke lstPeminjaman jika semua isian valid.</summary>
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa isian yang bertanda merah."
            Return
        End If

        ' Normalkan kode menjadi huruf besar
        Dim kodeUpper As String = txtKodeBuku.Text.ToUpper()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.Text
        Dim namaPeminjam As String = txtNamaPeminjam.Text.Trim()
        Dim lamaPinjam As Integer
        Integer.TryParse(txtLamaPinjam.Text, lamaPinjam)

        ' Hitung tanggal kembali
        Dim tanggalKembali As String = Date.Today.AddDays(lamaPinjam).ToString("dd/MM/yyyy")

        ' Format baris daftar
        Dim baris As String = $"{kodeUpper} | {judul} | {kategori} | {namaPeminjam} | {lamaPinjam} hari | kembali {tanggalKembali}"
        lstPeminjaman.Items.Add(baris)

        ' Catat kode sebagai sedang dipinjam
        kodeDipinjam.Add(kodeUpper)

        ' Perbarui status dan bersihkan form
        lblStatus.Text = $"Jumlah peminjaman: {lstPeminjaman.Items.Count}"
        BersihkanForm()
    End Sub

    ' -------------------------------------------------------------------------
    ' Tombol Bersihkan
    ' -------------------------------------------------------------------------

    ''' <summary>Mengosongkan semua isian dan menghapus semua ikon ErrorProvider.</summary>
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
        lblStatus.Text = "Form dibersihkan."
    End Sub

    ''' <summary>Prosedur pembantu yang benar-benar mengosongkan isian dan tanda error.</summary>
    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        errPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' -------------------------------------------------------------------------
    ' Tombol Ekspor
    ' -------------------------------------------------------------------------

    ''' <summary>
    ''' Menyimpan daftar peminjaman ke file CSV di folder Documents.
    ''' Menangani IOException dan UnauthorizedAccessException secara terpisah.
    ''' StreamWriter selalu ditutup di blok Finally.
    ''' </summary>
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        ' Jangan ekspor jika daftar masih kosong
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Daftar peminjaman masih kosong. Tidak ada data yang diekspor.",
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim penulis As StreamWriter = Nothing
        Try
            penulis = New StreamWriter(lokasiEkspor, False, System.Text.Encoding.UTF8)
            ' Tulis baris judul kolom
            penulis.WriteLine("Kode Buku;Judul;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")
            ' Tulis setiap baris peminjaman
            For Each item As Object In lstPeminjaman.Items
                penulis.WriteLine(item.ToString().Replace(" | ", ";"))
            Next
            lblStatus.Text = $"Data diekspor ke {lokasiEkspor}"
            MessageBox.Show($"File berhasil disimpan di:{vbCrLf}{lokasiEkspor}",
                            "Ekspor Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As IOException
            MessageBox.Show("File sedang digunakan program lain (misalnya Excel)." & vbCrLf &
                            "Tutup file tersebut lalu coba ekspor kembali." & vbCrLf & vbCrLf &
                            "Detail: " & ex.Message,
                            "Ekspor Gagal - File Sedang Dipakai",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Tidak memiliki izin untuk menulis ke lokasi tersebut." & vbCrLf &
                            "Coba jalankan program sebagai Administrator." & vbCrLf & vbCrLf &
                            "Detail: " & ex.Message,
                            "Ekspor Gagal - Akses Ditolak",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' File selalu ditutup meskipun terjadi exception
            If penulis IsNot Nothing Then penulis.Close()
        End Try
    End Sub


    ' -------------------------------------------------------------------------
    ' Mode Demo (untuk screenshot otomatis)
    ' -------------------------------------------------------------------------

    ''' <summary>Jika dijalankan dengan argumen "--demo", otomatis isi 3 data peminjaman setelah form tampil.</summary>
    Private Sub FrmPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim args As String() = Environment.GetCommandLineArgs()
        For Each arg As String In args
            If arg.ToLower() = "--demo" Then
                Dim t As New System.Windows.Forms.Timer()
                t.Interval = 800
                AddHandler t.Tick, Sub(s As Object, ev As EventArgs)
                                       t.Stop()
                                       IsiDataDemo()
                                   End Sub
                t.Start()
                Exit For
            End If
        Next
    End Sub

    ''' <summary>Mengisi 3 entri peminjaman secara programatik untuk keperluan demo/screenshot.</summary>
    Public Sub IsiDataDemo()
        Try
            ' Entry 1: Laskar Pelangi - Fiksi
            txtKodeBuku.Text = "BK0012"
            txtJudul.Text = "Laskar Pelangi"
            cboKategori.SelectedIndex = 0
            txtNamaPeminjam.Text = "Rina Lubis"
            txtLamaPinjam.Text = "7"
            btnPinjam_Click(Me, EventArgs.Empty)
            Application.DoEvents()

            ' Entry 2: Sapiens - Nonfiksi
            txtKodeBuku.Text = "BK0105"
            txtJudul.Text = "Sapiens"
            cboKategori.SelectedIndex = 1
            txtNamaPeminjam.Text = "Dimas Siregar"
            txtLamaPinjam.Text = "14"
            btnPinjam_Click(Me, EventArgs.Empty)
            Application.DoEvents()

            ' Entry 3: Atlas Dunia - Referensi
            txtKodeBuku.Text = "BK0230"
            txtJudul.Text = "Atlas Dunia"
            cboKategori.SelectedIndex = 2
            txtNamaPeminjam.Text = "Fajar Nasution"
            txtLamaPinjam.Text = "3"
            btnPinjam_Click(Me, EventArgs.Empty)
            Application.DoEvents()
        Catch ex As Exception
            lblStatus.Text = "Demo error: " & ex.Message
        End Try
    End Sub
End Class
