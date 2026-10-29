<div align="center">

# Lab 06 — Database Configuration & CRUD Sederhana (PostgreSQL & Npgsql)

[![VB.NET](https://img.shields.io/badge/Language-VB.NET-00539C?style=flat-square&logo=dotnet)](https://learn.microsoft.com/dotnet/visual-basic/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-0078D7?style=flat-square&logo=windows)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Database](https://img.shields.io/badge/Database-PostgreSQL%20%7C%20Supabase-4169E1?style=flat-square&logo=postgresql)](https://www.postgresql.org/)
[![Driver](https://img.shields.io/badge/Driver-Npgsql-336791?style=flat-square)](#)

<p align="center">
  Dokumentasi proyek aplikasi Windows Forms <b>Data Mahasiswa</b> dengan integrasi database relasional PostgreSQL (Supabase/Local) menggunakan driver ADO.NET Npgsql, konfigurasi koneksi eksternal, pemisahan modular (ModDatabase, ModFunction, ModQuery), serta penanganan data via DataGridView.
</p>

[📌 Ringkasan Proyek](#-ringkasan-proyek) •
[🧱 Komponen & Setup UI](#-komponen--setup-ui) •
[💻 Implementasi Kode](#-implementasi-kode) •
[⚙️ Bedah Teknis](#️-bedah-teknis) •
[🗄️ Skema Database](#️-skema-database)

</div>

---

### 📌 Ringkasan Proyek

Pada pertemuan ini, dibangun aplikasi **Data Mahasiswa** (`Pertemuan-6-Configuration`) berbasis arsitektur modular yang terhubung langsung ke database PostgreSQL:

1. **Konfigurasi Eksternal Fleksibel**: Menyimpan connection string di konfigurasi aplikasi (`appsettings.json` / `App.config`) sehingga detail kredensial basis data terpisah dari kode sumber logika form.
2. **Modularisasi Kode (Separation of Concerns)**:
   - `ModDatabase`: Bertanggung jawab atas pembacaan konfigurasi connection string dan tes pembukaan koneksi.
   - `ModFunction`: Layer utilitas eksekusi query (metode `AmbilData` untuk mengisi `DataTable` dan `EksekusiData` untuk `ExecuteNonQuery` berparameter).
   - `ModQuery`: Abstraksi kueri spesifik bisnis (seperti fungsi `TambahData` dan `TampilkanData`).
3. **Prepared Statements & Parameterized Query**: Mencegah kerentanan *SQL Injection* dengan passing parameter `@nim`, `@nama`, dan `@jurusan` via `Dictionary(Of String, Object)`.
4. **Visualisasi Data**: Menampilkan seluruh data record dari tabel `mahasiswa` ke komponen `DataGridView` secara otomatis.

---

### 🗄️ Skema Database

Tabel `mahasiswa` dikonfigurasikan pada PostgreSQL / Supabase dengan struktur:

```sql
CREATE TABLE IF NOT EXISTS mahasiswa (
    id SERIAL PRIMARY KEY,
    nim VARCHAR(30) NOT NULL UNIQUE,
    nama VARCHAR(100) NOT NULL,
    jurusan VARCHAR(100) NOT NULL
);
```

---

### 🧱 Komponen & Setup UI

Daftar kontrol pada `Form1.vb [Design]`:

| Kontrol | Nama Kontrol | Properti Utama | Fungsi & Deskripsi |
| :--- | :--- | :--- | :--- |
| `Label` | `lblNIM` | `Text: "NIM"` | Label keterangan isian NIM |
| `TextBox` | `txtNIM` | - | Input NIM mahasiswa (harus unik) |
| `Label` | `lblNama` | `Text: "Nama"` | Label keterangan isian Nama |
| `TextBox` | `txtNama` | - | Input nama lengkap mahasiswa |
| `Label` | `lblJurusan` | `Text: "Jurusan"` | Label keterangan isian Jurusan |
| `TextBox` | `txtJurusan` | - | Input program studi/jurusan |
| `Button` | `btnTambah` | `Text: "Tambah"` | Menyimpan record baru ke tabel PostgreSQL |
| `Button` | `btnTampil` | `Text: "Tampilkan"` | Memuat dan me-refresh isi tabel ke DataGridView |
| `DataGridView`| `dgvMahasiswa` | - | Menampilkan baris data mahasiswa |

---

### 💻 Implementasi Kode

#### 1. Modul Konfigurasi Koneksi (`ModDatabase.vb`)
```vb
Imports System.Configuration
Imports Microsoft.Extensions.Configuration
Imports Npgsql

Module ModDatabase
    Public Function GetConnectionString() As String
        Dim config As IConfiguration =
            New ConfigurationBuilder() _
            .SetBasePath(AppContext.BaseDirectory) _
            .AddJsonFile("Appsettings.json", optional:=False, reloadOnChange:=True) _
            .Build()

        Return config.GetConnectionString("DefaultConnection")
    End Function

    Public Sub DatabaseKoneksi()
        Try
            Using conn As New NpgsqlConnection(GetConnectionString)
                conn.Open()
                MessageBox.Show("Koneksi database berhasil")
            End Using
        Catch ex As Exception
            MessageBox.Show("Koneksi database gagal" & vbCrLf & ex.Message & "database")
        End Try
    End Sub
End Module
```

#### 2. Modul Helper Eksekusi Query (`ModFunction.vb`)
```vb
Imports Npgsql
Imports System.Data

Module ModFunction
    Public Function AmbilData(query As String) As DataTable
        Dim dt As New DataTable

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
            MessageBox.Show("Gagal mengambil data" & vbCrLf & ex.Message, " database")
        End Try

        Return dt
    End Function

    Public Function EksekusiData(query As String, parameters As Dictionary(Of String, Object)) As Boolean
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
            MessageBox.Show("Gagal mengeksekusi data:" & vbCrLf & ex.Message, "Error Database")
            Return False
        End Try
    End Function
End Module
```

#### 3. Modul Kueri Data (`ModQuery.vb`)
```vb
Imports System.Data

Module ModQuery
    Public Function TambahData(nim As String, nama As String, jurusan As String) As Boolean
        Dim query As String = "INSERT INTO mahasiswa (nim, nama, jurusan) VALUES (@nim, @nama, @jurusan)"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@nim", nim},
            {"@nama", nama},
            {"@jurusan", jurusan}
        }
        Return ModFunction.EksekusiData(query, parameters)
    End Function

    Public Function TampilkanData() As DataTable
        Return ModFunction.AmbilData("SELECT * FROM mahasiswa ORDER BY id ASC")
    End Function
End Module
```

#### 4. Kode Antarmuka Utama (`Form1.vb`)
```vb
Public Class Form1
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ModQuery.TambahData(txtNIM.Text, txtNama.Text, txtJurusan.Text) Then
            MessageBox.Show("Data berhasil disimpan")
        End If
        txtNIM.Clear()
        txtNama.Clear()
        txtJurusan.Clear()
    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub
End Class
```

---

### ⚙️ Bedah Teknis

1. **NpgsqlConnection & Block `Using`**:
   Semua koneksi dibungkus dalam blok `Using conn As New NpgsqlConnection(...)` untuk memastikan koneksi database selalu ditutup (*dispose/close*) secara aman dan mencegah kebocoran koneksi (*connection pool exhaustion*).
2. **NpgsqlDataAdapter & DataTable**:
   Metode `AmbilData` memanfaatkan `NpgsqlDataAdapter` untuk menarik hasil query SQL dan mengisinya ke `DataTable` dalam memori secara disconnected.
3. **Parameterized Queries**:
   Penggunaan parameter `@nim`, `@nama`, `@jurusan` via `cmd.Parameters.AddWithValue` memastikan seluruh karakter spesial lolos sanitasi dan terhindar dari bahaya SQL Injection.
4. **Pemisahan Konfigurasi**:
   Penyimpanan kredensial server di file konfigurasi memudahkan perpindahan environment (misal dari database lokal ke Supabase cloud) tanpa mengompilasi ulang kode aplikasi.

---

<div align="center">
  <sub>Pemrograman Visual &bull; Visual Basic .NET Windows Forms</sub>
</div>

