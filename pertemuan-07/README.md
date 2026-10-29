<div align="center">

# Lab 07 — Validasi Input, Error Handling & Naming Convention

[![VB.NET](https://img.shields.io/badge/Language-VB.NET-00539C?style=flat-square&logo=dotnet)](https://learn.microsoft.com/dotnet/visual-basic/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms%20%7C%20.NET%2010-blue?style=flat-square)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Architecture](https://img.shields.io/badge/Architecture-Defensive%20Programming-purple?style=flat-square)](#)

<p align="center">
  Dokumentasi proyek formulir Peminjaman Buku dengan validasi input terpusat non-blocking menggunakan ErrorProvider, penanganan eksepsi bertingkat (Try...Catch), dan standar penamaan kontrol.
</p>

[📌 Ringkasan Masalah](#-ringkasan-masalah) •
[🧱 Komponen & Setup UI](#-komponen--setup-ui) •
[💻 Implementasi Kode](#-implementasi-kode) •
[⚙️ Bedah Teknis](#️-bedah-teknis) •
[📊 Business Logic & Aturan Validasi](#-business-logic--aturan-validasi)

</div>

---

### 📌 Ringkasan Masalah

Pada modul ini dibangun aplikasi desktop **Peminjaman Buku Perpustakaan** (`PeminjamanBuku`) berbasis arsitektur *defensive programming*. Aplikasi menggantikan pencatatan manual di kertas untuk mencegah kesalahan input, mempermudah kalkulasi tanggal pengembalian, dan mencegah peminjaman ganda:

1. **Centralized Non-Blocking Validation**: Memeriksa seluruh isian formulir sekaligus tanpa menggunakan popup `MessageBox` yang menghentikan alur pengguna, melainkan menandai kontrol yang salah secara visual melalui `ErrorProvider`.
2. **Duplicate Borrowing Guard**: Mencegah peminjaman buku yang sedang berstatus dipinjam dengan mencocokkan kode pada daftar aktif (`kodeDipinjam`).
3. **Automatic Due Date Calculation**: Menghitung otomatis tanggal batas kembali berdasarkan tanggal transaksi ditambah durasi pinjam.
4. **Structured Exception Handling**: Menyimpan riwayat transaksi ke berkas `peminjaman.csv` dengan penanganan eksepsi bertingkat (`UnauthorizedAccessException`, `IOException`, dan `Exception` umum).

---

### 🧱 Komponen & Setup UI

Konfigurasi kontrol antarmuka pada `FrmPeminjaman.vb [Design]`:

| Control Type | Control Name | Property Key / Nilai | Kegunaan |
| :--- | :--- | :--- | :--- |
| `Label` | `lblJudulForm` | `Text: "Peminjaman Buku"` | Label judul formulir utama |
| `TextBox` | `txtKodeBuku` | `CharacterCasing: Normal` | Input kode buku (format `BK` + 4 digit) |
| `TextBox` | `txtJudul` | - | Input judul buku yang dipinjam |
| `ComboBox` | `cboKategori` | `DropDownStyle: DropDownList` | Pilihan kategori: Fiksi, Nonfiksi, Referensi, Majalah |
| `TextBox` | `txtNamaPeminjam` | - | Input identitas nama peminjam |
| `TextBox` | `txtLamaPinjam` | - | Input durasi hari pinjam (1 - 14 hari) |
| `Button` | `btnPinjam` | `Text: "Pinjam"` | Trigger validasi dan pencatatan transaksi |
| `Button` | `btnBersihkan` | `Text: "Bersihkan"` | Reset isian form dan hapus pesan error |
| `ListBox` | `lstPeminjaman` | - | Wadah daftar transaksi peminjaman aktif |
| `Button` | `btnEkspor` | `Text: "Ekspor ke CSV"` | Trigger penyimpanan data ke file CSV |
| `Label` | `lblStatus` | `Text: "0 peminjaman dicatat"` | Indikator status jumlah data |
| `ErrorProvider` | `errPinjam` | `BlinkStyle: NeverBlink` | Komponen visual penanda input tidak valid |

---

### 💻 Implementasi Kode

Dokumentasi implementasi kode logika pada `FrmPeminjaman.vb`:

#### 1. Fungsi Validasi Terpusat (`ValidasiInput`)

```vb
Private Function ValidasiInput() As Boolean
    errPinjam.Clear()
    Dim valid As Boolean = True

    ' 1. Validasi Kode Buku (Format BK + 4 digit)
    Dim kodeUpper As String = txtKodeBuku.Text.ToUpper()
    If Not KodeBukuValid(txtKodeBuku.Text) Then
        errPinjam.SetError(txtKodeBuku, "Kode buku harus BK diikuti 4 digit, contoh BK0012.")
        valid = False
    ElseIf kodeDipinjam.Contains(kodeUpper) Then
        errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
        valid = False
    End If

    ' 2. Validasi Judul Buku
    If txtJudul.Text.Trim() = "" Then
        errPinjam.SetError(txtJudul, "Judul buku wajib diisi.")
        valid = False
    End If

    ' 3. Validasi Kategori Buku
    If cboKategori.SelectedIndex = -1 Then
        errPinjam.SetError(cboKategori, "Pilih salah satu kategori.")
        valid = False
    End If

    ' 4. Validasi Nama Peminjam
    If txtNamaPeminjam.Text.Trim().Length < 3 Then
        errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
        valid = False
    End If

    ' 5. Validasi Lama Pinjam (Integer.TryParse 1 s.d. 14)
    Dim lama As Integer
    If Not Integer.TryParse(txtLamaPinjam.Text, lama) Then
        errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus berupa angka bulat.")
        valid = False
    ElseIf lama < 1 OrElse lama > 14 Then
        errPinjam.SetError(txtLamaPinjam, "Lama pinjam antara 1 sampai 14 hari.")
        valid = False
    End If

    Return valid
End Function
```

#### 2. Pencatatan Transaksi (`btnPinjam_Click`)

```vb
Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
    If Not ValidasiInput() Then Return

    Dim kodeUpper As String = txtKodeBuku.Text.ToUpper()
    Dim lama As Integer = Integer.Parse(txtLamaPinjam.Text)
    Dim tglKembali As Date = Date.Today.AddDays(lama)

    ' Catat transaksi ke ListBox dan list kode aktif
    Dim baris As String = $"{kodeUpper} | {txtJudul.Text.Trim()} | {cboKategori.Text} | {txtNamaPeminjam.Text.Trim()} | Kembali: {tglKembali:dd/MM/yyyy}"
    lstPeminjaman.Items.Add(baris)
    kodeDipinjam.Add(kodeUpper)

    ' Perbarui status dan bersihkan input
    lblStatus.Text = $"{lstPeminjaman.Items.Count} peminjaman dicatat"
    BersihkanForm()
End Sub
```

#### 3. Ekspor Data dengan Penanganan Error Bertingkat (`btnEkspor_Click`)

```vb
Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
    If lstPeminjaman.Items.Count = 0 Then
        MessageBox.Show("Belum ada data untuk diekspor.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    Try
        Using sw As New StreamWriter(lokasiEkspor, False)
            sw.WriteLine("KodeBuku,Judul,Kategori,NamaPeminjam,TglKembali")
            For Each item As Object In lstPeminjaman.Items
                sw.WriteLine(item.ToString().Replace(" | ", ","))
            Next
        End Using
        MessageBox.Show($"Data berhasil diekspor ke:{vbCrLf}{lokasiEkspor}", "Ekspor Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As UnauthorizedAccessException
        MessageBox.Show("Tidak ada izin untuk menulis file di lokasi tersebut.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Catch ex As IOException
        MessageBox.Show("File sedang dibuka program lain atau media penyimpanan bermasalah.", "Kesalahan I/O", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Catch ex As Exception
        MessageBox.Show($"Terjadi kesalahan tak terduga:{vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub
```

---

### ⚙️ Bedah Teknis

1. **Option Strict On**: Memastikan pengetikan tipe data secara ketat tanpa konversi implisit (*implicit type casting*) yang berpotensi menimbulkan bug saat runtime.
2. **Integer.TryParse vs Val / CInt**:
   * `CInt`: Melempar crash `InvalidCastException` bila input berupa teks non-angka.
   * `Val`: Berbahaya karena mengabaikan karakter huruf di belakang angka (`12abc` dibaca `12`) tanpa memberi sinyal kegagalan.
   * `Integer.TryParse`: Mengembalikan status keberhasilan `Boolean` tanpa melempar eksepsi (*defensive approach*).
3. **Penyimpanan Format Huruf Besar (`ToUpper`)**: Input kode seperti `bk0012` dinormalisasi secara otomatis menjadi `BK0012` sebelum divalidasi dan disimpan.

---

### 📊 Business Logic & Aturan Validasi

| Kolom Input | Komponen | Syarat & Ketentuan Validasi | Respon Bila Tidak Valid |
| :--- | :--- | :--- | :--- |
| **Kode Buku** | `txtKodeBuku` | Pola `BK` + 4 digit angka (`BK0001` - `BK9999`) & buku belum dipinjam | Ikon error di samping textbox dengan tooltip pesan kesalahan |
| **Judul Buku** | `txtJudul` | Tidak boleh kosong (`Trim() <> ""`) | Ikon error "Judul buku wajib diisi." |
| **Kategori** | `cboKategori` | Salah satu item wajib dipilih (`SelectedIndex <> -1`) | Ikon error "Pilih salah satu kategori." |
| **Nama Peminjam** | `txtNamaPeminjam` | Minimal 3 karakter setelah spasi diabaikan | Ikon error "Nama peminjam minimal 3 karakter." |
| **Lama Pinjam** | `txtLamaPinjam` | Tipe data integer rentang 1 s.d. 14 hari | Ikon error terkait tipe data atau batasan rentang |

---

<div align="center">
  <sub>Pemrograman Visual &bull; Visual Basic .NET Windows Forms</sub>
</div>
