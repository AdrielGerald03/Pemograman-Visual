<div align="center">

# Lab 02 — GUI Controls, Event-Driven Architecture & State Handling

[![VB.NET](https://img.shields.io/badge/Language-VB.NET-00539C?style=flat-square&logo=dotnet)](https://learn.microsoft.com/dotnet/visual-basic/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-blue?style=flat-square)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Architecture](https://img.shields.io/badge/Architecture-Event--Driven-purple?style=flat-square)](#)

<p align="center">
  Eksplorasi antarmuka Windows Forms, manipulasi properti kontrol runtime, integrasi event delegator, dan sanitasi input form.
</p>

[📌 Overview Masalah](#-overview-masalah) •
[🧱 Arsitektur Kontrol UI](#-arsitektur-kontrol-ui) •
[💻 Implementasi Kode](#-implementasi-kode) •
[⚙️ Bedah Teknis & Catatan Arsitektur](#️-bedah-teknis--catatan-arsitektur) •
[🚀 Petunjuk Eksekusi](#-petunjuk-eksekusi)

</div>

---

### 📌 Overview Masalah

Modul ini mengimplementasikan modul formulir pencatatan profil identitas mahasiswa berbasis paradigma *event-driven*. Program berfokus pada sinkronisasi data antar-komponen visual melalui tiga fungsionalitas inti:

1. **Aggregation & Display**: Mengambil isi bidang teks (`Nama`, `NIM`, `KOM`) dan memproyeksikannya ke antarmuka dialog modal (`MessageBox`).
2. **Form Reset & UX Recovery**: Mengosongkan seluruh bidang isian secara serempak sekaligus mengembalikan posisi fokus kursor pengguna.
3. **Graceful Application Teardown**: Memutus alur eksekusi aplikasi secara aman dengan pelepasan alokasi memori yang tepat.

---

### 🧱 Arsitektur Kontrol UI

Spesifikasi komponen antarmuka yang terpasang pada `Form1.vb [Design]`:

| Jenis Kontrol | Identifier `(Name)` | Properti Kunci | Deskripsi Fungsional |
| :--- | :--- | :--- | :--- |
| `Form` | `Form1` | `StartPosition: CenterScreen` | Top-level container untuk seluruh hierarki UI |
| `Label` | `lblNama`, `lblNIM`, `Label1` | `AutoSize: True` | Penanda teks statis pada form |
| `TextBox` | `txtNama` | `TabIndex: 0` | Input teks untuk data nama |
| `TextBox` | `txtNim` | `TabIndex: 1` | Input teks untuk nomor induk mahasiswa |
| `TextBox` | `txtKom` | `TabIndex: 2` | Input teks untuk kelas komputasi |
| `Button` | `btnTampilkan` | `TabIndex: 3` | Trigger pemanggilan modal rekapitulasi data |
| `Button` | `txtHapus` *(btnHapus)* | `TabIndex: 4` | Trigger pembersihan nilai seluruh TextBox |
| `Button` | `txtKeluar` *(btnKeluar)* | `TabIndex: 5` | Trigger terminasi form aktif |

---

### 💻 Implementasi Kode

Logika penanganan interaksi form yang didefinisikan pada `Form1.vb`:

```vb
Public Class Form1

    ''' <summary>
    ''' Menggabungkan input teks form dan menampilkannya melalui modal dialog.
    ''' </summary>
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo Selamat Datang!" & vbCrLf &
                        "Nama: " & txtNama.Text & vbCrLf &
                        "NIM: " & txtNim.Text & vbCrLf &
                        "Kom: " & txtKom.Text,
                        "Informasi Data Mahasiswa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    ''' <summary>
    ''' Membersihkan seluruh field input dan mengarahkan keyboard focus ke kontrol awal.
    ''' </summary>
    Private Sub txtHapus_Click(sender As Object, e As EventArgs) Handles txtHapus.Click
        ' Pengosongan teks kontrol
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()

        ' UX Optimization: Kembalikan kursor aktif ke input pertama
        txtNama.Focus()
    End Sub

    ''' <summary>
    ''' Menutup instansi form aktif dan memicu disposal unmanaged resources.
    ''' </summary>
    Private Sub txtKeluar_Click(sender As Object, e As EventArgs) Handles txtKeluar.Click
        Me.Close()
    End Sub

End Class
