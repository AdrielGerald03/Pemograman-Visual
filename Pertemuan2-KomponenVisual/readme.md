<div align="center">

# Lab 02 — Visual Components, Event Handling & Basic Properties

[![VB.NET](https://img.shields.io/badge/Language-VB.NET-00539C?style=flat-square&logo=dotnet)](https://learn.microsoft.com/dotnet/visual-basic/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-blue?style=flat-square)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Architecture](https://img.shields.io/badge/Architecture-Event--Driven-purple?style=flat-square)](#)

<p align="center">
  Eksplorasi dasar GUI Windows Forms, penanganan delegasi event, manipulasi properti kontrol, dan manajemen state form.
</p>

[📌 Ringkasan Masalah](#-ringkasan-masalah) •
[🧱 Komponen & Setup UI](#-komponen--setup-ui) •
[💻 Implementasi Kode](#-implementasi-kode) •
[⚙️ Bedah Teknis](#️-bedah-teknis) •
[🚀 Petunjuk Eksekusi](#-petunjuk-eksekusi)

</div>

---

### 📌 Ringkasan Masalah

Pada modul ini dibangun formulir rekapitulasi data mahasiswa berbasis arsitektur *event-driven*. Form menangani masukan identitas pengguna dan menyediakan alur interaksi terpadu:

1. **Data Aggregation**: Mengumpulkan data input (`Nama`, `NIM`, `KOM`) dan memunculkannya via modal dialog (`MessageBox`).
2. **Form Sanitization / Reset**: Membersihkan seluruh isian form secara simultan dan mengembalikan fokus pengguna (*UX refinement*).
3. **Graceful Lifecycle Termination**: Menutup instansi form dan membebaskan alokasi *unmanaged resources*.

---

### 🧱 Komponen & Setup UI

Konfigurasi kontrol antarmuka pada `Form1.vb [Design]`:

| Control Type | Control Name | Property Key | Kegunaan |
| :--- | :--- | :--- | :--- |
| `Form` | `Form1` | `StartPosition: CenterScreen` | Window container utama |
| `Label` | `lblNama`, `lblNIM`, `lblKom` | `AutoSize: True` | Visual identifier setiap kolom input |
| `TextBox` | `txtNama` | `TabIndex: 0` | Input teks nama mahasiswa |
| `TextBox` | `txtNim` | `TabIndex: 1` | Input teks nomor induk mahasiswa |
| `TextBox` | `txtKom` | `TabIndex: 2` | Input teks kelas mahasiswa |
| `Button` | `btnTampilkan` | `TabIndex: 3` | Trigger dialog rekapitulasi data |
| `Button` | `txtHapus` *(btnHapus)* | `TabIndex: 4` | Trigger reset nilai field form |
| `Button` | `txtKeluar` *(btnKeluar)* | `TabIndex: 5` | Trigger penutupan form aktif |

---

### 💻 Implementasi Kode

Dokumentasi implementasi logika *event handler* pada `Form1.vb`:

```vb
Public Class Form1

    ''' <summary>
    ''' Menggabungkan input form dan menampilkannya dalam format modal dialog.
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
    ''' Mengosongkan isian seluruh field teks dan mereset fokus cursor ke input awal.
    ''' </summary>
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles txtHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()

        ' UX Guard: Kembalikan keyboard focus ke kontrol pertama
        txtNama.Focus()
    End Sub

    ''' <summary>
    ''' Mengakhiri siklus hidup form saat ini secara aman.
    ''' </summary>
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles txtKeluar.Click
        Me.Close()
    End Sub

End Class