Option Strict On

Imports System.Text.RegularExpressions

''' <summary>
''' Form utama aplikasi Inventaris Buku Perpustakaan.
''' Mengelola data buku menggunakan DataTable, BindingSource, dan DataGridView.
''' </summary>
Public Class FrmInventarisBuku

    ' DataTable utama untuk menampung seluruh inventaris buku di memori
    Private tabelBuku As DataTable

    ''' <summary>
    ''' Membuat struktur DataTable tabelBuku dan mengisinya dengan 10 buku awal.
    ''' Memastikan seluruh kategori terwakili dan minimal dua buku memiliki stok 0.
    ''' </summary>
    ''' <returns>DataTable yang telah terisi data awal</returns>
    Private Function InisialisasiTabelBuku() As DataTable
        Dim tabel As New DataTable("InventarisBuku")

        ' Mendefinisikan kolom-kolom tabel beserta tipe datanya
        tabel.Columns.Add("KodeBuku", GetType(String))
        tabel.Columns.Add("Judul", GetType(String))
        tabel.Columns.Add("Penulis", GetType(String))
        tabel.Columns.Add("Kategori", GetType(String))
        tabel.Columns.Add("Tahun", GetType(Integer))
        tabel.Columns.Add("Stok", GetType(Integer))

        ' Mengisi minimal 10 buku contoh (termasuk judul bertanda kutip untuk uji coba filter)
        tabel.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        tabel.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        tabel.Rows.Add("BK0003", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 5)
        tabel.Rows.Add("BK0004", "Kamus Bahasa Indonesia", "Tim Bahasa", "Referensi", 2020, 3)
        tabel.Rows.Add("BK0005", "Majalah Sains Nusantara", "Redaksi Sains", "Majalah", 2024, 0)
        tabel.Rows.Add("BK0006", "Ma'rifat Cahaya", "Ahmad Fauzi", "Nonfiksi", 2019, 4)
        tabel.Rows.Add("BK0007", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 6)
        tabel.Rows.Add("BK0008", "Atlas Indonesia", "Tim Kartografi", "Referensi", 2022, 2)
        tabel.Rows.Add("BK0009", "Majalah Taman Kita", "Redaksi Taman", "Majalah", 2023, 7)
        tabel.Rows.Add("BK0010", "Sejarah Nusantara", "Dewi Lestari Putri", "Nonfiksi", 2021, 0)

        Return tabel
    End Function

    ''' <summary>
    ''' Event yang dipanggil saat form pertama kali dimuat.
    ''' Mengikat DataTable ke BindingSource, menghubungkannya ke DataGridView, dan menyiapkan antarmuka.
    ''' </summary>
    Private Sub FrmInventarisBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabelBuku = InisialisasiTabelBuku()

        ' Menghubungkan DataTable -> BindingSource -> DataGridView
        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

        ' Nilai bawaan filter dan pengurutan
        cboFilterKategori.SelectedIndex = 0 ' "Semua"
        cboUrut.SelectedIndex = 0           ' "Urutan awal"

        ' Mengatur tampilan kolom grid dan memperbarui ringkasan
        AturKolom()
        PerbaruiRingkasan()
    End Sub

    ''' <summary>
    ''' Mengatur format, lebar (FillWeight), perataan teks, dan judul kolom DataGridView.
    ''' </summary>
    Private Sub AturKolom()
        If dgvBuku.Columns.Contains("KodeBuku") Then
            dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
            dgvBuku.Columns("KodeBuku").FillWeight = 85
        End If

        If dgvBuku.Columns.Contains("Judul") Then
            dgvBuku.Columns("Judul").FillWeight = 160
        End If

        If dgvBuku.Columns.Contains("Penulis") Then
            dgvBuku.Columns("Penulis").FillWeight = 130
        End If

        If dgvBuku.Columns.Contains("Kategori") Then
            dgvBuku.Columns("Kategori").FillWeight = 90
        End If

        If dgvBuku.Columns.Contains("Tahun") Then
            dgvBuku.Columns("Tahun").FillWeight = 70
            dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        If dgvBuku.Columns.Contains("Stok") Then
            dgvBuku.Columns("Stok").FillWeight = 60
            dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ''' <summary>
    ''' Memvalidasi seluruh masukan pengguna sebelum data buku baru ditambahkan.
    ''' Menggunakan ErrorProvider untuk menandai letak kesalahan pada kontrol.
    ''' </summary>
    ''' <returns>True jika seluruh isian valid, False jika ada yang salah</returns>
    Private Function ValidasiInput() As Boolean
        Dim valid As Boolean = True
        errBuku.Clear()

        ' 1. Validasi Kode Buku: diawali "BK" diikuti 4 digit angka dan harus unik
        Dim kode As String = txtKodeBuku.Text.Trim()
        If kode = "" Then
            errBuku.SetError(txtKodeBuku, "Kode buku wajib diisi.")
            valid = False
        ElseIf Not Regex.IsMatch(kode, "^BK\d{4}$") Then
            errBuku.SetError(txtKodeBuku, "Kode buku harus diawali 'BK' diikuti 4 digit angka (contoh: BK0001).")
            valid = False
        Else
            ' Memeriksa apakah kode buku sudah ada di dalam DataTable dengan perulangan
            Dim kodeSudahAda As Boolean = False
            For Each baris As DataRow In tabelBuku.Rows
                If baris.RowState <> DataRowState.Deleted Then
                    If baris("KodeBuku").ToString().Equals(kode, StringComparison.OrdinalIgnoreCase) Then
                        kodeSudahAda = True
                        Exit For
                    End If
                End If
            Next

            If kodeSudahAda Then
                errBuku.SetError(txtKodeBuku, "Kode buku sudah terdaftar dalam inventaris.")
                valid = False
            End If
        End If

        ' 2. Validasi Judul Buku
        If txtJudul.Text.Trim() = "" Then
            errBuku.SetError(txtJudul, "Judul buku wajib diisi.")
            valid = False
        End If

        ' 3. Validasi Penulis
        If txtPenulis.Text.Trim() = "" Then
            errBuku.SetError(txtPenulis, "Penulis buku wajib diisi.")
            valid = False
        End If

        ' 4. Validasi Kategori
        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Kategori wajib dipilih.")
            valid = False
        End If

        ' 5. Validasi Tahun Terbit: bilangan bulat antara 1900 dan tahun saat ini
        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) Then
            errBuku.SetError(txtTahun, "Tahun harus berupa bilangan bulat.")
            valid = False
        ElseIf tahun < 1900 OrElse tahun > Date.Today.Year Then
            errBuku.SetError(txtTahun, "Tahun harus antara 1900 dan " & Date.Today.Year.ToString() & ".")
            valid = False
        End If

        ' 6. Validasi Stok: bilangan bulat >= 0
        Dim stok As Integer
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) Then
            errBuku.SetError(txtStok, "Stok harus berupa bilangan bulat.")
            valid = False
        ElseIf stok < 0 Then
            errBuku.SetError(txtStok, "Stok tidak boleh bernilai negatif.")
            valid = False
        End If

        Return valid
    End Function

    ''' <summary>
    ''' Mengosongkan form isian dan menghapus pesan kesalahan pada ErrorProvider.
    ''' </summary>
    Private Sub BersihkanInput()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        errBuku.Clear()
        txtKodeBuku.Focus()
    End Sub

    ''' <summary>
    ''' Menyusun ekspresi kueri pemfilteran gabungan pada BindingSource (judul/penulis, kategori, dan stok habis).
    ''' Karakter khusus pengguna diamankan menggunakan ModPencarian.AmankanTeksFilter.
    ''' </summary>
    Private Sub TerapkanFilter()
        If bsBuku Is Nothing OrElse tabelBuku Is Nothing Then Exit Sub

        Dim daftarSyarat As New List(Of String)()

        ' 1. Syarat pencarian kata pada Judul atau Penulis
        Dim kataCari As String = AmankanTeksFilter(txtCari.Text.Trim())
        If kataCari <> "" Then
            daftarSyarat.Add("(Judul LIKE '%" & kataCari & "%' OR Penulis LIKE '%" & kataCari & "%')")
        End If

        ' 2. Syarat pembatasan kategori
        If cboFilterKategori.SelectedIndex > 0 AndAlso cboFilterKategori.SelectedItem IsNot Nothing Then
            Dim kategoriDipilih As String = cboFilterKategori.SelectedItem.ToString()
            If kategoriDipilih <> "Semua" Then
                daftarSyarat.Add("Kategori = '" & AmankanTeksFilter(kategoriDipilih) & "'")
            End If
        End If

        ' 3. Tantangan: Syarat hanya buku dengan stok habis
        If chkStokHabis.Checked Then
            daftarSyarat.Add("Stok = 0")
        End If

        ' Penggabungan syarat dengan operator AND
        If daftarSyarat.Count = 0 Then
            bsBuku.RemoveFilter()
        Else
            bsBuku.Filter = String.Join(" AND ", daftarSyarat)
        End If

        PerbaruiRingkasan()
    End Sub

    ''' <summary>
    ''' Mengatur pengurutan data pada BindingSource berdasarkan pilihan ComboBox pengurutan.
    ''' </summary>
    Private Sub TerapkanUrutan()
        If bsBuku Is Nothing OrElse cboUrut.SelectedItem Is Nothing Then Exit Sub

        Select Case cboUrut.SelectedItem.ToString()
            Case "Judul A-Z"
                bsBuku.Sort = "Judul ASC"
            Case "Tahun terbaru"
                bsBuku.Sort = "Tahun DESC"
            Case "Stok terbanyak"
                bsBuku.Sort = "Stok DESC"
            Case Else
                ' "Urutan awal"
                bsBuku.RemoveSort()
        End Select
    End Sub

    ''' <summary>
    ''' Memperbarui teks pada lblJumlah dan menghitung total stok dari baris yang sedang tampil di DataGridView.
    ''' </summary>
    Private Sub PerbaruiRingkasan()
        If bsBuku Is Nothing OrElse tabelBuku Is Nothing Then Exit Sub

        ' Menampilkan jumlah buku yang sedang terlihat vs total keseluruhan
        lblJumlah.Text = "Menampilkan " & bsBuku.Count.ToString() & " dari " & tabelBuku.Rows.Count.ToString() & " buku"

        ' Menghitung total stok secara langsung dari baris DataGridView yang sedang tampil
        Dim totalStok As Integer = 0
        For Each baris As DataGridViewRow In dgvBuku.Rows
            If Not baris.IsNewRow AndAlso baris.Cells("Stok").Value IsNot Nothing Then
                totalStok += CInt(baris.Cells("Stok").Value)
            End If
        Next
        lblTotalStok.Text = "Total stok yang tampil: " & totalStok.ToString()
    End Sub

    ''' <summary>
    ''' Event klik tombol Tambah Buku: melakukan validasi dan menambahkan buku baru ke tabelBuku.
    ''' </summary>
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ValidasiInput() Then
            Dim kode As String = txtKodeBuku.Text.Trim()
            Dim judul As String = txtJudul.Text.Trim()
            Dim penulis As String = txtPenulis.Text.Trim()
            Dim kategori As String = cboKategori.SelectedItem.ToString()
            Dim tahun As Integer = Integer.Parse(txtTahun.Text.Trim())
            Dim stok As Integer = Integer.Parse(txtStok.Text.Trim())

            ' Menambahkan baris baru langsung ke DataTable
            tabelBuku.Rows.Add(kode, judul, penulis, kategori, tahun, stok)

            ' Membersihkan isian form dan memperbarui ringkasan
            BersihkanInput()
            PerbaruiRingkasan()
        End If
    End Sub

    ''' <summary>
    ''' Event klik tombol Bersihkan: mereset seluruh isian form dan penanda error.
    ''' </summary>
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanInput()
    End Sub

    ''' <summary>
    ''' Event saat teks pada kotak pencarian berubah: menyaring data saat mengetik.
    ''' </summary>
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    ''' <summary>
    ''' Event saat pilihan kategori filter berubah.
    ''' </summary>
    Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    ''' <summary>
    ''' Event saat status centang "Hanya stok habis" berubah.
    ''' </summary>
    Private Sub chkStokHabis_CheckedChanged(sender As Object, e As EventArgs) Handles chkStokHabis.CheckedChanged
        TerapkanFilter()
    End Sub

    ''' <summary>
    ''' Event saat pilihan urutan buku berubah.
    ''' </summary>
    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
        TerapkanUrutan()
    End Sub

End Class
