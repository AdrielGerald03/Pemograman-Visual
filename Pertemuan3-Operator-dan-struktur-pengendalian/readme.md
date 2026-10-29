<div align="center">

# Lab 03 — Operators, Flow Control & Input Validation

[![VB.NET](https://img.shields.io/badge/Language-VB.NET-00539C?style=flat-square&logo=dotnet)](https://learn.microsoft.com/dotnet/visual-basic/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-blue?style=flat-square)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Topic](https://img.shields.io/badge/Topic-Input%20Sanitization%20%26%20Dynamic%20UI-orange?style=flat-square)](#)

<p align="center">
  Implementasi pengondisian logika, validasi input bertingkat, dan dynamic asset rendering pada Windows Forms.
</p>

[📌 Ringkasan Masalah](#-ringkasan-masalah) •
[🧱 Komponen & Setup UI](#-komponen--setup-ui) •
[💻 Implementasi Kode](#-implementasi-kode) •
[⚙️ Bedah Teknis](#️-bedah-teknis) •
[📊 Business Logic Table](#-business-logic-table)

</div>

---

### 📌 Ringkasan Masalah

Pada modul ini dibangun modul evaluasi skor nilai sederhana. Program dirancang untuk menguji keandalan penanganan input pengguna (*defensive programming*) sebelum memproses logika bisnis:

1. **Input Sanitization**: Memastikan hanya karakter numerik yang dapat diketik.
2. **Range Guard**: Memastikan nilai berada pada rentang batas valid (`0 - 100`).
3. **Dynamic Asset Swapping**: Menampilkan aset visual (`PictureBox`) secara dinamis saat runtime sesuai kategori rentang nilai.

---

### 🧱 Komponen & Setup UI

Konfigurasi kontrol pada `Form1.vb [Design]`:

| Control Type | Control Name | Property Key | Kegunaan |
| :--- | :--- | :--- | :--- |
| `TextBox` | `txtNilai` | `MaxLength: 3` | Input field skor pengguna |
| `Button` | `btnInput` | `Text: "Evaluasi"` | Trigger proses validasi & rendering |
| `PictureBox` | `picImage` | `SizeMode: StretchImage` | Wadah render gambar status skor |

---

### 💻 Implementasi Kode

Dokumentasi implementasi handler pada `Form1.vb`:

```vb
Public Class Form1

    ''' <summary>
    ''' Mengeksekusi validasi parsing, range check, dan update tampilan gambar.
    ''' </summary>
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilai As Integer

        ' 1. Guard Clause: Format Parsing Check
        If Not Integer.TryParse(txtNilai.Text, nilai) Then
            MessageBox.Show("Input harus berupa bilangan bulat!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNilai.SelectAll()
            txtNilai.Focus()
            Return
        End If

        ' 2. Guard Clause: Value Range Check (0 - 100)
        If nilai < 0 OrElse nilai > 100 Then
            MessageBox.Show("Nilai harus berada pada rentang 0 hingga 100.", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNilai.SelectAll()
            txtNilai.Focus()
            Return
        End If

        ' 3. State Mapping & Dynamic Asset Loading
        If nilai <= 50 Then
            picImage.Image = Image.FromFile("Asset\1.jpeg")
        ElseIf nilai <= 70 Then
            picImage.Image = Image.FromFile("Asset\2.png")
        Else
            picImage.Image = Image.FromFile("Asset\3.png")
        End If
    End Sub

    ''' <summary>
    ''' Restriksi keystroke di level UI: Menolak karakter non-digit secara real-time.
    ''' </summary>
    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Drop event keystroke yang tidak valid
        End If
    End Sub

End Class