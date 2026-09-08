# PERTEMUAN 02: PEMROGRAMAN VISUAL
## Komponen Visual Windows Forms, Event Handling, dan Properti Dasar

---

## 1. Informasi Praktikum

| Komponen | Detail |
| :--- | :--- |
| **Mata Kuliah** | Pemrograman Visual |
| **Topik** | Komponen Visual, Properti Dasar, dan Penanganan Event |
| **Bahasa Pemrograman** | Visual Basic .NET (VB.NET) |
| **Platform Target** | .NET / Windows Forms (WinForms) |
| **Lingkungan Pengembangan** | Visual Studio |

---

## 2. Deskripsi Praktikum

Praktikum ini berfokus pada perancangan antarmuka berbasis *Graphical User Interface* (GUI) menggunakan Windows Forms pada lingkungan Visual Basic .NET. 

Studi kasus yang diimplementasikan adalah sistem form profil data mahasiswa yang menampung masukan:
- **Nama Mahasiswa** (`txtNama`)
- **Nomor Induk Mahasiswa (NIM)** (`txtNim`)
- **Kelas Komputasi (KOM)** (`txtKom`)

Form dilengkapi dengan pengujian mekanisme interaksi *event-driven* melalui tiga tombol kendali utama:
1. **Tampilkan**: Menampilkan rekapitulasi data input ke dalam jendela pesan (*modal dialog / MessageBox*).
2. **Hapus**: Mengosongkan seluruh bidang isian teks secara simultan.
3. **Keluar**: Menghentikan siklus hidup (*lifecycle termination*) form dan membebaskan alokasi memori.

---

## 3. Arsitektur Komponen Visual (UI Controls)

Tabel berikut merinci konfigurasi objek kontrol form pada perancangan antarmuka:

| Jenis Kontrol | Identitas `(Name)` | Nilai Awal `Text` | Properti Tambahan | Deskripsi Fungsional |
| :--- | :--- | :--- | :--- | :--- |
| **Form** | `Form1` | `Profille Mahasiswa` | `StartPosition: CenterScreen` | Jendela induk penampung seluruh hierarki komponen UI |
| **Label** | `lblNama` | `Nama` | `AutoSize: True` | Penanda visual kolom input nama |
| **Label** | `lblNIM` | `NIM` | `AutoSize: True` | Penanda visual kolom input NIM |
| **Label** | `Label1` | `KOM` | `AutoSize: True` | Penanda visual kolom input kelas KOM |
| **TextBox** | `txtNama` | `""` | `TabIndex: 0` | Kolom input data nama mahasiswa |
| **TextBox** | `txtNim` | `""` | `TabIndex: 1` | Kolom input data NIM mahasiswa |
| **TextBox** | `txtKom` | `""` | `TabIndex: 2` | Kolom input data kelas KOM mahasiswa |
| **Button** | `btnTampilkan` | `Tampilkan` | `TabIndex: 3` | Pemicu pembacaan data dan penayangan MessageBox |
| **Button** | `txtHapus` | `Hapus` | `TabIndex: 4` | Pemicu pengosongan nilai properti seluruh TextBox |
| **Button** | `txtKeluar` | `Keluar` | `TabIndex: 5` | Pemicu penutupan jendela dan terminasi proses |

---

## 4. Implementasi Kode Sumber (`Form1.vb`)

Berikut adalah struktur kode logika penanganan *event* pada form:

```vb
Public Class Form1

    ' Event Handler: Menampilkan Rekapitulasi Data ke MessageBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo Selamat Datang!" & vbCrLf &
                        "Nama: " & txtNama.Text & vbCrLf &
                        "NIM: " & txtNim.Text & vbCrLf &
                        "Kom: " & txtKom.Text,
                        "Informasi Data Mahasiswa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    ' Event Handler: Menghapus Seluruh Isian Form
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles txtHapus.Click
        ' Membersihkan nilai teks dari setiap kontrol input
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()

        ' Mengembalikan fokus kursor ke input pertama (UX Enhancement)
        txtNama.Focus()
    End Sub

    ' Event Handler: Menutup Form dan Mengakhiri Sesi
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles txtKeluar.Click
        ' Menutup form aktif dan membebaskan alokasi sumber daya
        Me.Close()
    End Sub

End Class
```

---

## 5. Pembahasan Konsep Teknis

### A. Mekanisme Event-Driven Programming (`Handles`)
VB.NET mengeksekusi logika berdasarkan tindakan pengguna (*event-driven*). Klausa `Handles btnTampilkan.Click` mendaftarkan subrutin tersebut ke sistem delegasi event Windows Forms. 
- Nama subrutin di sebelah kiri (misalnya `Button1_Click`) bersifat arbitrer (dapat diganti).
- Penentu pemicu sebenarnya adalah deklarasi event setelah kata kunci `Handles`.

### B. Konkatenasi String: Operator `&` vs `+`
Pada VB.NET, selalu prioritaskan operator `&` untuk penggabungan teks string.

> [!NOTE]
> Operator `+` memiliki ambiguitas logika (*operator overloading*) yang dapat memicu konversi numerik implisit (*type mismatch error*) jika salah satu nilai teks berisi representasi angka.

### C. Konstanta Karakter Baris Baru (*Newline*)
Beberapa opsi konstanta pemisah baris pada VB.NET:
- `vbCrLf`: Format tradisional Visual Basic untuk kombinasi *Carriage Return* (`\r`) dan *Line Feed* (`\n`).
- `vbNewLine`: Konstanta ekuivalen bawaan Visual Basic Runtime.
- `Environment.NewLine`: Standar platform .NET modern yang fleksibel menyesuaikan pemisah baris dengan sistem operasi *host*.

### D. Variasi Metode Pembersihan Bidang Input
Terdapat tiga pendekatan untuk mengosongkan nilai `TextBox`:
1. `txtNama.Clear()` *(Disarankan)*: Metode bawaan kontrol `TextBox`.
2. `txtNama.Text = String.Empty`: Pendekatan efisien yang menghindari alokasi string baru.
3. `txtNama.Text = ""`: Penugasan literal string kosong standar.

### E. Manajemen Fokus Input (`.Focus()`)
Pemanggilan `txtNama.Focus()` setelah operasi pembersihan memindahkan kursor keyboard secara otomatis ke kotak teks pertama. Hal ini meningkatkan ergonomi interaksi pengguna (*user experience*).

### F. Siklus Hidup Form: `Me.Close()` vs `Application.Exit()` vs `End`
- `Me.Close()`: Menutup instansi form saat ini dan melepas alokasi sumber daya (*dispose resources*). Jika form ini merupakan *Main Form*, aplikasi berhenti secara normal.
- `Application.Exit()`: Menghentikan seluruh antrean pesan (*message loop*) aplikasi di semua form yang sedang aktif.
- `End`: Mematikan proses aplikasi secara paksa tanpa melalui prosedur *cleanup* atau event `FormClosing` (*tidak direkomendasikan*).

### G. Evaluasi Konvensi Penamaan Kontrol (*Naming Convention*)

> [!WARNING]
> Penamaan objek tombol menggunakan awalan `txt` (seperti `txtHapus` dan `txtKeluar`) merupakan anomali konvensi penamaan standar.

Standar rekayasa perangkat lunak menganjurkan prefiks singkatan yang konsisten sesuai tipe kontrol:
- `btn` untuk **Button** (contoh: `btnHapus`, `btnKeluar`, `btnTampilkan`)
- `txt` untuk **TextBox** (contoh: `txtNama`, `txtNim`, `txtKom`)
- `lbl` untuk **Label** (contoh: `lblNama`, `lblNIM`, `lblKom`)

---

## 6. Petunjuk Menjalankan Proyek

1. **Buka Proyek**: Buka file `Pertemuan2-KomponenVisual.slnx` atau file proyek `.vbproj` menggunakan Visual Studio.
2. **Kompilasi**: Pilih menu **Build** > **Build Solution** (atau tekan `Ctrl + Shift + B`).
3. **Eksekusi**: Tekan tombol **Start** / `F5` untuk menjalankan aplikasi dalam mode *debugging*.
4. **Pengujian Form**:
   - Masukkan data pada kolom **Nama**, **NIM**, dan **KOM**.
   - Klik **Tampilkan** untuk memvalidasi keluaran jendela pesan.
   - Klik **Hapus** untuk menguji pembersihan seluruh input.
   - Klik **Keluar** untuk mengakhiri program.
