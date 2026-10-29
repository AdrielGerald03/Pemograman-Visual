# Configuration

## Gambaran Proyek

Pada pertemuan ini, kita membuat aplikasi Windows Forms untuk menyimpan dan menampilkan data mahasiswa menggunakan PostgreSQL. Aplikasi terdiri dari satu form, dua tombol, tiga kotak teks, beberapa label, dan sebuah `DataGridView`.

Informasi koneksi database disimpan dalam berkas konfigurasi aplikasi, kemudian dibaca oleh modul database. Perintah SQL dipisahkan ke modul query, sedangkan fungsi untuk membuka koneksi dan menjalankan perintah disimpan dalam modul fungsi.

| Bagian | Isi |
|---|---|
| Bahasa | Visual Basic .NET |
| Antarmuka | Windows Forms App (.NET Framework) |
| Database | PostgreSQL |
| Driver database | Npgsql |
| Data yang disimpan | NIM, nama, dan jurusan mahasiswa |
| Fitur | Menambahkan dan menampilkan data mahasiswa |

## 1. Persiapan

Siapkan hal berikut sebelum membuat proyek:

1. **Visual Studio** dengan workload **.NET desktop development**. Workload ini menyediakan Windows Forms dan alat Visual Basic.
2. **.NET Framework 4.8 Developer Pack / Targeting Pack**. Pilih .NET Framework 4.8 saat membuat proyek. Jika komputer dan Visual Studio Anda menyediakan .NET Framework 4.8.1, versi itu juga dapat dipakai.
3. **PostgreSQL** yang sedang berjalan.
4. **pgAdmin** atau alat lain untuk menjalankan perintah SQL di PostgreSQL.
5. Akses internet saat memasang paket Npgsql dari NuGet.

## 2. Buat Database dan Tabel

### Membuat database

1. Buka pgAdmin dan sambungkan ke server PostgreSQL.
2. Klik kanan **Databases** lalu pilih **Create > Database...**.
3. Isi nama database, misalnya `db_mahasiswa`, lalu klik **Save**.

bisa juga membuat database melalui Query Tool yang terhubung ke database lain, misalnya `postgres`:

```sql
CREATE DATABASE db_mahasiswa;
```

Jalankan perintah tersebut satu kali. Setelah database dibuat, pilih atau sambungkan Query Tool ke `db_mahasiswa` sebelum membuat tabel.

### Membuat tabel `mahasiswa`

Jalankan perintah berikut di Query Tool yang terhubung ke `db_mahasiswa`:

```sql
CREATE TABLE IF NOT EXISTS mahasiswa (
    id SERIAL PRIMARY KEY,
    nim VARCHAR(30) NOT NULL UNIQUE,
    nama VARCHAR(100) NOT NULL,
    jurusan VARCHAR(100) NOT NULL
);
```

Kolom `id` dibuat otomatis oleh PostgreSQL dan dipakai untuk mengurutkan baris. Kolom `nim` tidak boleh kosong dan harus unik. `nama` dan `jurusan` juga wajib diisi.

Untuk memeriksa tabel, jalankan:

```sql
SELECT id, nim, nama, jurusan
FROM mahasiswa
ORDER BY id ASC;
```

Jika tabel `mahasiswa` sudah ada tetapi susunan kolomnya berbeda, pastikan tabel itu memiliki kolom `id`, `nim`, `nama`, dan `jurusan`. Perintah program dalam panduan ini mengacu pada nama kolom tersebut.

## 3. Buat Proyek Windows Forms App (.NET Framework)

1. Buka Visual Studio, lalu pilih **Create a new project**.
2. Cari **Windows Forms App (.NET Framework)**.
3. Pilih template Visual Basic. Pastikan nama template menyebut **.NET Framework**; jangan memilih template Windows Forms untuk .NET modern.
4. Klik **Next**.
5. Beri nama proyek, misalnya `Pertemuan6Configuration`.
6. Pilih lokasi penyimpanan proyek, lalu klik **Create**.
7. Pada pilihan framework, pilih **.NET Framework 4.8** (atau 4.8.1 jika tersedia), lalu buat proyek.

Visual Studio biasanya membuat form awal bernama `Form1`. Jika form awal diberi nama lain, gunakan nama tersebut secara konsisten atau ubah namanya menjadi `Form1`.

## 4. Pasang Paket Npgsql

Npgsql adalah driver ADO.NET untuk menghubungkan aplikasi .NET dengan PostgreSQL.

### Melalui antarmuka NuGet

1. Klik kanan proyek di **Solution Explorer**.
2. Pilih **Manage NuGet Packages...**.
3. Buka tab **Browse**, cari `Npgsql`.
4. Pilih versi **8.0.9**, lalu klik **Install**.
5. Terima persetujuan lisensi jika diminta.

### Alternatif melalui Package Manager Console

Buka **Tools > NuGet Package Manager > Package Manager Console**, pastikan proyek yang benar dipilih sebagai **Default project**, lalu jalankan:

```powershell
Install-Package Npgsql -Version 8.0.9
```

Paket `Microsoft.Extensions.Configuration.Json` dari proyek ZIP tidak diperlukan karena versi panduan ini membaca connection string melalui `System.Configuration` dan `App.config`.

## 5. Tambahkan `App.config`

1. Klik kanan nama proyek di **Solution Explorer**.
2. Pilih **Add > New Item...**.
3. Cari **Application Configuration File**.
4. Beri nama `App.config`, lalu klik **Add**.
5. Isi connection string dengan konfigurasi seperti berikut. Jika Visual Studio telah membuat isi awal, gabungkan bagian `<connectionStrings>` ke dalam elemen `<configuration>` yang sudah ada.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <connectionStrings>
    <add name="DefaultConnection"
         connectionString="Host=localhost;Port=5432;Database=db_mahasiswa;Username=postgres;Password=GANTI_DENGAN_PASSWORD_POSTGRES"
         providerName="Npgsql" />
  </connectionStrings>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
  </startup>
</configuration>
```

Ganti nilai password dengan password PostgreSQL di komputer Anda. Jika Anda memilih .NET Framework 4.8.1, sesuaikan nilai `sku` menjadi `.NETFramework,Version=v4.8.1`. Jika Visual Studio sudah memiliki elemen `<startup>`, pertahankan elemen tersebut dan tambahkan `<connectionStrings>` saja. Pastikan hanya ada satu elemen `<configuration>` utama.

Connection string di atas menganggap PostgreSQL berjalan di komputer yang sama (`localhost`) pada port standar `5432`, dengan database `db_mahasiswa` dan pengguna `postgres`. Ubah nilai `Host`, `Port`, `Database`, `Username`, atau `Password` jika konfigurasi server Anda berbeda. `DefaultConnection` harus sama persis dengan nama yang dibaca oleh kode.

`App.config` disalin Visual Studio ke folder keluaran program sebagai berkas `NamaProgram.exe.config`. Kode akan membaca bagian `<connectionStrings>` melalui `ConfigurationManager`.

## 6. Tambahkan Referensi `System.Configuration`

Pada beberapa proyek, referensi ini sudah tersedia. Jika kode `ConfigurationManager` nanti ditandai sebagai tidak dikenal:

1. Klik kanan **References** di bawah proyek, lalu pilih **Add Reference...**.
2. Pilih **Assemblies > Framework**.
3. Centang **System.Configuration** dan klik **OK**.

Di kode Visual Basic, gunakan `Imports System.Configuration`.

## 7. Rancang Form

Buka `Form1` dengan tampilan **Windows Forms Designer**. Dari **Toolbox**, seret kontrol ke form, lalu ubah properti di jendela **Properties**. Gunakan nama kontrol berikut agar cocok dengan kode di bawah.

### Properti form

| Properti | Nilai |
|---|---|
| `(Name)` | `Form1` |
| `Text` | `Data Mahasiswa - Pertemuan 6` |
| `StartPosition` | `CenterScreen` |
| `ClientSize` | kira-kira `900, 520` |

### Kontrol tabel

Tambahkan satu `DataGridView` di sisi kiri form.

| Properti | Nilai |
|---|---|
| `(Name)` | `dgvMahasiswa` |
| `Location` | `25, 25` |
| `Size` | kira-kira `450, 450` |
| `ReadOnly` | `True` |
| `AllowUserToAddRows` | `False` |
| `AutoSizeColumnsMode` | `Fill` |
| `SelectionMode` | `FullRowSelect` |

### Label, kotak teks, dan tombol

Tempatkan tiga label dan kotak teks di sisi kanan form. Letakkan kedua tombol di bawah isian.

| Jenis kontrol | `(Name)` | `Text` |
|---|---|---|
| Label | `lblNIM` | `NIM:` |
| TextBox | `txtNIM` | *(kosong)* |
| Label | `lblNama` | `Nama:` |
| TextBox | `txtNama` | *(kosong)* |
| Label | `lblJurusan` | `Jurusan:` |
| TextBox | `txtJurusan` | *(kosong)* |
| Button | `btnTambah` | `Tambah` |
| Button | `btnTampil` | `Tampilkan` |

Contoh posisi yang dapat disesuaikan:

| Kontrol | `Location` contoh | `Size` contoh |
|---|---:|---:|
| `lblNIM` | `515, 75` | mengikuti teks |
| `txtNIM` | `620, 70` | `230, 30` |
| `lblNama` | `515, 145` | mengikuti teks |
| `txtNama` | `620, 140` | `230, 30` |
| `lblJurusan` | `515, 215` | mengikuti teks |
| `txtJurusan` | `620, 210` | `230, 30` |
| `btnTambah` | `620, 285` | `110, 35` |
| `btnTampil` | `740, 285` | `110, 35` |

Nama kontrol bersifat penting karena dipakai oleh event handler. Jika memakai nama lain, samakan nama tersebut pada seluruh kode atau ubah lewat properti `(Name)` di Designer.

## 8. Buat Modul Database

1. Klik kanan proyek di **Solution Explorer**.
2. Pilih **Add > Module...**.
3. Beri nama `ModDatabase.vb`.
4. Ganti isi modul dengan kode berikut:

```vb
Imports System.Configuration
Imports Npgsql

Module ModDatabase

    Public Function GetConnectionString() As String
        Dim setting As ConnectionStringSettings =
            ConfigurationManager.ConnectionStrings("DefaultConnection")

        If setting Is Nothing OrElse String.IsNullOrWhiteSpace(setting.ConnectionString) Then
            Throw New ConfigurationErrorsException(
                "Connection string 'DefaultConnection' tidak ditemukan di App.config."
            )
        End If

        Return setting.ConnectionString
    End Function

    Public Sub DatabaseKoneksi()
        Try
            Using conn As New NpgsqlConnection(GetConnectionString())
                conn.Open()
                MessageBox.Show(
                    "Koneksi database berhasil.",
                    "Koneksi PostgreSQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Koneksi database gagal:" & vbCrLf & ex.Message,
                "Koneksi PostgreSQL",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

End Module
```

`GetConnectionString` mencari nama `DefaultConnection` di konfigurasi. `DatabaseKoneksi` membuka koneksi sebentar sebagai pemeriksaan dan menampilkan hasilnya. Koneksi ditutup otomatis oleh blok `Using`.

### Uji koneksi satu kali

Sebelum melanjutkan, Anda dapat menguji kredensial database. Tambahkan event `Load` sementara pada `Form1.vb`:

```vb
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ModDatabase.DatabaseKoneksi()
End Sub
```

Jalankan aplikasi. Jika pesan menyatakan koneksi berhasil, hapus pemanggilan sementara tersebut agar pesan tidak muncul setiap aplikasi dibuka. Jika gagal, periksa nama database, server, port, pengguna, password, dan status layanan PostgreSQL.

## 9. Buat Modul Fungsi Database

Tambahkan modul bernama `ModFunction.vb`, lalu masukkan kode berikut:

```vb
Imports System.Collections.Generic
Imports System.Data
Imports Npgsql

Module ModFunction

    Public Function AmbilData(query As String) As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As New NpgsqlConnection(ModDatabase.GetConnectionString())
                conn.Open()

                Using cmd As New NpgsqlCommand(query, conn)
                    Using adapter As New NpgsqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Gagal mengambil data:" & vbCrLf & ex.Message,
                "Error Database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

        Return dt
    End Function

    Public Function EksekusiData(
        query As String,
        parameters As Dictionary(Of String, Object)
    ) As Boolean

        Try
            Using conn As New NpgsqlConnection(ModDatabase.GetConnectionString())
                conn.Open()

                Using cmd As New NpgsqlCommand(query, conn)
                    For Each parameter In parameters
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value)
                    Next

                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Gagal menyimpan data:" & vbCrLf & ex.Message,
                "Error Database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return False
        End Try
    End Function

End Module
```

`AmbilData` menjalankan query baca dan mengembalikan hasilnya sebagai `DataTable`. `EksekusiData` menjalankan perintah perubahan data. Nilai yang dikirim ke query menggunakan parameter, bukan disambungkan langsung ke teks SQL.

## 10. Buat Modul Query

Tambahkan modul bernama `ModQuery.vb`, lalu masukkan kode berikut:

```vb
Imports System.Collections.Generic
Imports System.Data

Module ModQuery

    Public Function TambahData(
        nim As String,
        nama As String,
        jurusan As String
    ) As Boolean

        Dim query As String =
            "INSERT INTO mahasiswa (nim, nama, jurusan) " &
            "VALUES (@nim, @nama, @jurusan)"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@nim", nim},
            {"@nama", nama},
            {"@jurusan", jurusan}
        }

        Return ModFunction.EksekusiData(query, parameters)
    End Function

    Public Function TampilkanData() As DataTable
        Dim query As String =
            "SELECT id, nim, nama, jurusan " &
            "FROM mahasiswa ORDER BY id ASC"

        Return ModFunction.AmbilData(query)
    End Function

End Module
```

Fungsi `TambahData` menambahkan satu baris ke tabel `mahasiswa`. Fungsi `TampilkanData` membaca isi tabel dan mengurutkan hasil berdasarkan `id`.

## 11. Tulis Kode `Form1`

Buka berkas `Form1.vb` (bukan `Form1.Designer.vb`) dan isi kelas form dengan kode berikut:

```vb
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuatDataMahasiswa()
    End Sub

    Private Sub MuatDataMahasiswa()
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        MuatDataMahasiswa()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim nim As String = txtNIM.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim jurusan As String = txtJurusan.Text.Trim()

        If String.IsNullOrWhiteSpace(nim) Then
            MessageBox.Show("NIM harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(nama) Then
            MessageBox.Show("Nama harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(jurusan) Then
            MessageBox.Show("Jurusan harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJurusan.Focus()
            Return
        End If

        If ModQuery.TambahData(nim, nama, jurusan) Then
            MessageBox.Show(
                "Data mahasiswa berhasil disimpan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            txtNIM.Clear()
            txtNama.Clear()
            txtJurusan.Clear()
            txtNIM.Focus()
            MuatDataMahasiswa()
        End If
    End Sub

End Class
```

Form menampilkan data saat dibuka dan saat tombol **Tampilkan** diklik. Tombol **Tambah** memeriksa agar semua isian terisi, lalu menyimpan data. Isian hanya dikosongkan jika penyimpanan berhasil. Jika NIM sudah terdaftar, PostgreSQL menolak data karena kolom `nim` memiliki aturan unik; pesan kesalahan database akan ditampilkan.

Pastikan nama kontrol di Designer sama dengan nama yang digunakan di kode. Jangan mengedit `Form1.Designer.vb` secara manual; gunakan Windows Forms Designer untuk menambah, menghapus, atau mengubah kontrol.

## 12. Jalankan dan Coba Aplikasi

1. Simpan semua berkas dengan **Ctrl+S**.
2. Pilih **Build > Build Solution**. Pastikan proses build selesai tanpa error.
3. Tekan **F5** untuk menjalankan aplikasi.
4. Jika belum ada baris di database, tabel akan tampak kosong.
5. Isi NIM, nama, dan jurusan, lalu klik **Tambah**.
6. Pastikan pesan berhasil muncul dan data baru terlihat di `DataGridView`.
7. Klik **Tampilkan** untuk memuat ulang isi tabel.
8. Tutup dan buka kembali aplikasi. Data yang sudah tersimpan tetap ada karena disimpan di PostgreSQL, bukan hanya di memori form.
9. Uji validasi dengan mengosongkan satu isian. Aplikasi harus meminta isian itu dilengkapi.
10. Coba masukkan NIM yang sama dua kali. Baris kedua harus ditolak oleh database.

## 13. Alur Program

| Tindakan | Urutan proses |
|---|---|
| Aplikasi dibuka | `Form1_Load` memanggil `MuatDataMahasiswa` → `ModQuery.TampilkanData` → `ModFunction.AmbilData` → PostgreSQL |
| Tombol **Tampilkan** diklik | `btnTampil_Click` memuat ulang data dari tabel `mahasiswa` |
| Tombol **Tambah** diklik | Form memvalidasi input → `ModQuery.TambahData` membentuk query dan parameter → `ModFunction.EksekusiData` menyimpan baris ke PostgreSQL → tabel dimuat ulang |
| Koneksi database dibuat | `ModDatabase.GetConnectionString` membaca `DefaultConnection` dari `App.config` → Npgsql membuka koneksi PostgreSQL |

## 14. Pemecahan Masalah

| Gejala | Hal yang perlu diperiksa |
|---|---|
| `ConfigurationManager` tidak dikenal | Pastikan `Imports System.Configuration` ada dan referensi **System.Configuration** telah ditambahkan. |
| Connection string tidak ditemukan | Pastikan berkas bernama `App.config`, nama entry `DefaultConnection`, dan kode menggunakan nama yang sama. Pastikan XML berada di dalam `<configuration>`. |
| Password authentication failed | Periksa nama pengguna dan password PostgreSQL di `App.config`. Jangan menambahkan tanda kutip ke dalam nilai password kecuali memang bagian dari password. |
| Could not connect / connection refused | Pastikan layanan PostgreSQL berjalan dan nilai `Host` serta `Port` benar. Port default biasanya `5432`. |
| Database tidak ditemukan | Pastikan database `db_mahasiswa` sudah dibuat dan nama di connection string sama persis. |
| Relation `mahasiswa` does not exist | Buat tabel di database yang sedang dipakai aplikasi. Pastikan Query Tool terhubung ke `db_mahasiswa`. |
| Kolom `id` tidak ditemukan | Periksa struktur tabel. Query di panduan mengharapkan kolom `id`, `nim`, `nama`, dan `jurusan`. |
| Duplicate key pada `nim` | NIM harus unik. Gunakan NIM baru atau periksa data yang sudah tersimpan. |
| Tipe atau paket Npgsql tidak cocok | Targetkan .NET Framework 4.8/4.8.1 dan gunakan Npgsql 8.x yang mendukung .NET Standard 2.0. Npgsql 9+ tidak mendukung .NET Framework. |
| Perubahan kode tidak tampak | Simpan berkas, hentikan aplikasi yang berjalan, lalu jalankan ulang dengan **F5**. |

Jika terjadi error, baca pesan lengkapnya untuk mengetahui apakah masalahnya ada di konfigurasi, jaringan database, nama tabel, atau data yang dimasukkan.