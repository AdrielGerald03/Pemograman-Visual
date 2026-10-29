<div align="center">

# Lab 05 — Array 1 Dimensi, Multidimensi & Modul Global

[![VB.NET](https://img.shields.io/badge/Language-VB.NET-00539C?style=flat-square&logo=dotnet)](https://learn.microsoft.com/dotnet/visual-basic/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms%20%7C%20.NET%2010-blue?style=flat-square)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Topic](https://img.shields.io/badge/Topic-Array%20%26%20Modular%20Programming-purple?style=flat-square)](#)

<p align="center">
  Dokumentasi praktikum implementasi struktur data koleksi Array (1D & Multidimensi/2D), integrasi prosedur/fungsi modular, serta manipulasi kontrol formulir Windows Forms.
</p>

[📌 Ringkasan Praktikum](#-ringkasan-praktikum) •
[🧱 Komponen & Setup UI](#-komponen--setup-ui) •
[💻 Implementasi Kode](#-implementasi-kode) •
[⚙️ Bedah Konsep & Teknis](#️-bedah-konsep--teknis) •
[🚀 Petunjuk Eksekusi](#-petunjuk-eksekusi)

</div>

---

### 📌 Ringkasan Praktikum

Pada modul **Pertemuan 05: Array & Modul** (`Pertemuan5-Array`), pembelajaran difokuskan pada pengorganisasian data menggunakan struktur array dan modularisasi fungsi di VB.NET:

1. **Struktur Data Array 1 Dimensi (1D)**: Deklarasi, inisialisasi, dan pembacaan elemen array numerik secara berurutan menggunakan perulangan `For...Next`.
2. **Struktur Data Array 2 Dimensi (Multidimensi)**: Representasi data dalam format matriks/tabel (baris dan kolom), serta pengindeksan elemen spesifik berbasis koordinat `(baris, kolom)`.
3. **Modularisasi Kode (`Module`)**: Pemisahan variabel global (`Public nilai`, `Public nilai2D`) serta prosedur/fungsi bantuan (`Sub tampilkanPesan`, `Function hitung`) ke dalam modul terpisah (`Module1.vb`) untuk mempermudah pemeliharaan kode dan reusabilitas.
4. **Integrasi Kontrol Visual**: Pemuatan data array ke kontrol visual seperti `ListBox` (`lstNilai`) serta penayangan nilai melalui pesan interaktif `MessageBox`.

---

### 🧱 Komponen & Setup UI

Konfigurasi kontrol antarmuka pada `Form1.vb [Design]`:

| Kontrol | Nama Kontrol | Konfigurasi Properti | Fungsi & Deskripsi |
| :--- | :--- | :--- | :--- |
| `Form` | `Form1` | `Text: "Form1"`, `Size: (800, 450)` | Window container utama |
| `TextBox` | `TextBox1` | `Location: (287, 88)` | Input data teks / parameter 1 |
| `TextBox` | `TextBox2` | `Location: (287, 117)` | Input data teks / parameter 2 |
| `Button` | `btnTampilkan` | `Text: "Tampilkan"`, `Location: (287, 146)` | Pemicu eksekusi penampilan data array / fungsi |
| `ListBox` | `lstNilai` | `Location: (287, 186)`, `Size: (120, 94)` | Kontrol daftar untuk menampung deret elemen array |

---

### 💻 Implementasi Kode

#### 1. Modul Global (`Module1.vb`)
Modul ini bertindak sebagai tempat penyimpanan data terpusat dan fungsi logika independen:

```vb
Module Module1

    ''' <summary>
    ''' Prosedur untuk menampilkan dialog salam.
    ''' </summary>
    Public Sub tampilkanPesan(nama As String)
        MessageBox.Show("Halo, " & nama)
    End Sub

    ''' <summary>
    ''' Fungsi evaluasi perhitungan dengan percabangan logika nilai panjang dan lebar.
    ''' </summary>
    Public Function hitung(panjang As Integer, lebar As Integer) As Integer
        If panjang > 20 Then
            Return panjang * lebar
        Else
            Return 2 * (panjang + lebar)
        End If
    End Function

    ' Inisialisasi data array 1 dimensi (1D)
    Public nilai() As Integer = {70, 80, 90, 100}

    ' Inisialisasi data array 2 dimensi (3 baris x 3 kolom)
    Public nilai2D(,) As Integer = {
        {80, 85, 82},
        {70, 72, 78},
        {90, 92, 98}
    }

End Module
```

#### 2. Logika Form (`Form1.vb`)
Menghubungkan event klik tombol antarmuka dengan pengambilan elemen array dari modul:

```vb
Public Class Form1

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        ' --- Alternatif 1: Menampilkan Array 1 Dimensi ke ListBox ---
        ' lstNilai.Items.Clear()
        ' For i As Integer = 0 To Module1.nilai.Length - 1
        '     lstNilai.Items.Add(Module1.nilai(i))
        ' Next

        ' --- Alternatif 2: Mengakses Elemen Array 2 Dimensi (Baris 1, Kolom 2) ---
        MessageBox.Show(nilai2D(1, 2).ToString())
    End Sub

End Class
```

---

### ⚙️ Bedah Konsep & Teknis

#### A. Array 1 Dimensi (Single-Dimensional Array)
Array 1D menyimpan elemen-elemen data bertipe sama dalam urutan linier. Indeks dimulai dari `0` (*zero-based indexing*).
- **Deklarasi:** `Public nilai() As Integer = {70, 80, 90, 100}`
- **Panjang Array:** Dapat diakses menggunakan properti `.Length` (bernilai `4`).
- **Iterasi:** Menggunakan perulangan `For i As Integer = 0 To nilai.Length - 1` untuk menambahkan setiap elemen ke `lstNilai.Items`.

#### B. Array Multidimensi / 2 Dimensi (Matrix Array)
Array multidimensi dideklarasikan dengan tanda koma `,` di dalam kurung `(,)`.
- **Format:** `nilai2D(baris, kolom)`
- **Indeks Baris & Kolom:**
  - Baris 0: `{80, 85, 82}`
  - Baris 1: `{70, 72, 78}`
  - Baris 2: `{90, 92, 98}`
- **Akses Elemen:** Pemanggilan `nilai2D(1, 2)` mengambil baris indeks ke-1 (baris ke-2) dan kolom indeks ke-2 (kolom ke-3), yaitu nilai **`78`**.

#### C. Penggunaan Modul (`Module`) di VB.NET
Berbeda dengan class instan (`Class`), semua anggota bertaraf akses `Public` di dalam `Module` bersifat statis secara global dan dapat diakses langsung oleh form manapun tanpa perlu membuat objek instansiasi baru.

---

### 🚀 Petunjuk Eksekusi

1. **Buka Proyek**: Buka file solusi `Pertemuan5-Array.slnx` menggunakan Visual Studio 2022 / 2026.
2. **Kompilasi Solusi**: Tekan shortcut `Ctrl + Shift + B` untuk memastikan tidak ada eror kompilasi.
3. **Jalankan Aplikasi**: Tekan `F5` untuk menjalankan program.
4. **Uji Coba**:
   - Klik tombol **Tampilkan** untuk memicu penayangan nilai array 2D indeks `(1, 2)` (menampilkan dialog angka `78`).
   - Kode looping pada `Form1.vb` dapat di-uncomment jika ingin menguji pengisian data array 1D ke dalam kontrol `lstNilai`.

---

<div align="center">
  <sub>Practical Documentation &bull; Pemrograman Visual 05</sub>
</div>

