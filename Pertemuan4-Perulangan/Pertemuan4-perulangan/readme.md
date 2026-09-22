# Perulangan
---
## 1. Konsep Perulangan
### 1.1 Pengertian Perulangan
Perulangan atau looping adalah salah satu struktur kontrol dalam pemrograman yang digunakan untuk menjalankan satu atau beberapa baris perintah secara berulang-ulang selama kondisi tertentu masih terpenuhi.<br>
Secara sederhana, perulangan memungkinkan program untuk mengeksekusi blok kode tertentu sebanyak yang dibutuhkan, baik berdasarkan jumlah pengulangan yang sudah ditentukan (fixed) maupun berdasarkan kondisi logika yang dievaluasi setiap kali perulangan berjalan (conditional).
### 1.2 Manfaat Perulangan dalam Pemrograman
Beberapa manfaat utama penggunaan perulangan dalam Visual Basic antara lain:
- Mengurangi duplikasi kode, sehingga program menjadi lebih ringkas dan mudah dipelihara.
- Mempercepat proses pengolahan data dalam jumlah besar, misalnya mengisi data ke dalam array atau tabel.
- Memungkinkan pembuatan program yang fleksibel, karena jumlah pengulangan dapat disesuaikan dengan kondisi atau input pengguna.
- Mendukung proses validasi, seperti meminta input hingga data yang dimasukkan benar.
---

## 2. Struktur Perulangan
Berikur beberapa jenis struktur perulangan dalam bahasa Visual Basic.
### 2.1 For...Next
Struktur `For...Next` digunakan ketika jumlah pengulangan sudah diketahui atau ditentukan sejak awal. Struktur ini menggunakan variabel penghitung (counter) yang nilainya berubah secara otomatis pada setiap iterasi.
 
Sintaks umum:
```vb
For counter = nilai_awal To nilai_akhir [Step nilai_langkah]
    ' blok perintah
Next counter
```
Contoh:
```vb
For i As Integer = 1 To 5
    Console.WriteLine("Iterasi ke-" & i)
Next
```
Jika ingin melakukan pengulangan mundur atau dengan kelipatan tertentu, kata kunci `Step` dapat digunakan.
```vb
For i As Integer = 10 To 1 Step -2
    Console.WriteLine(i)
Next
```
### 2.2 For Each...Next
Struktur `For Each...Next` digunakan khusus untuk melakukan iterasi terhadap setiap elemen dalam suatu koleksi data, seperti array, List, atau ArrayList, tanpa perlu mengetahui jumlah elemen secara pasti.
Sintaks umum:
```vb
For Each elemen As Tipe In koleksi
    ' blok perintah
Next
```
Contoh:
```vb
Dim buah() As String = {"Apel", "Jeruk", "Mangga"}
For Each item As String In buah
    Console.WriteLine(item)
Next
```
### 2.3 Do While...Loop
Struktur `Do While...Loop` menjalankan blok perintah selama kondisi yang diuji bernilai True. Pengecekan kondisi dilakukan di awal, sehingga jika kondisi sejak awal bernilai False, blok perintah tidak akan pernah dijalankan sama sekali.
Sintaks umum:
```vb
Do While kondisi
    ' blok perintah
Loop
```
Contoh:
```vb
Dim angka As Integer = 1
Do While angka <= 5
    Console.WriteLine(angka)
    angka += 1
Loop
```
### 2.4 Do...Loop While
Berbeda dengan `Do While...Loop`, struktur ini menguji kondisi di akhir blok perintah. Akibatnya, blok perintah akan tetap dijalankan minimal satu kali meskipun kondisinya bernilai False sejak awal.
Sintaks umum:
```vb
Do
    ' blok perintah
Loop While kondisi
```
Contoh:
```vb
Dim angka As Integer = 1
Do
    Console.WriteLine(angka)
    angka += 1
Loop While angka <= 5
```
### 2.5 Do Until...Loop
Struktur `Do Until...Loop` merupakan kebalikan logika dari `Do While...Loop`. Perulangan akan terus berjalan selama kondisi masih bernilai False, dan akan berhenti ketika kondisi menjadi True. Pengecekan dilakukan di awal.
Sintaks umum: 
```vb
Do Until kondisi
    ' blok perintah
Loop
```
Contoh:
```vb
Dim angka As Integer = 1
Do Until angka > 5
    Console.WriteLine(angka)
    angka += 1
Loop
```
### 2.6 Do...Loop Until
Sama seperti `Do...Loop While`, struktur ini menguji kondisi di akhir, namun perulangan berhenti ketika kondisi bernilai True. Blok perintah tetap dijalankan minimal satu kali.
Sintaks umum: 
```vb
Do
    ' blok perintah
Loop Until kondisi
```
Contoh:
```vb
Dim angka As Integer = 1
Do
    Console.WriteLine(angka)
    angka += 1
Loop Until angka > 5
```
### 2.7 While...End While
Struktur `While...End While` memiliki fungsi yang mirip dengan `Do While...Loop`, yaitu menjalankan blok perintah selama kondisi bernilai True dengan pengecekan di awal. Struktur ini merupakan bentuk alternatif yang lebih sederhana secara penulisan.
Sintaks umum: 
```vb
While kondisi
    ' blok perintah
End While
``` 
Contoh:
```vb
Dim angka As Integer = 1
While angka <= 5
    Console.WriteLine(angka)
    angka += 1
End While
```
---
## 3. Kontrol Alur dalam Perulangan
Dalam praktiknya, terkadang program perlu menghentikan perulangan lebih awal atau melompati sebagian iterasi tanpa menghentikan keseluruhan proses perulangan. Visual Basic menyediakan pernyataan khusus untuk keperluan ini.
### 3.1 Exit For dan Exit Do
Pernyataan `Exit For` dan `Exit Do` digunakan untuk menghentikan perulangan secara langsung, meskipun kondisi perulangan belum terpenuhi. Biasanya digunakan bersama pernyataan kondisional seperti `If`.
Contoh pada `For...Next`:
```vb
For i As Integer = 1 To 10
    If i = 5 Then
        Exit For
    End If
    Console.WriteLine(i)
Next
```
Contoh pada `Do While...Loop`:
```vb
Dim angka As Integer = 1
Do While angka <= 10
    If angka = 5 Then
        Exit Do
    End If
    Console.WriteLine(angka)
    angka += 1
Loop
```
output : 1,2,3,4
### 3.2 Continue For dan Continue Do 
Pernyataan `Continue For` dan `Continue Do` digunakan untuk melompati sisa perintah pada iterasi yang sedang berjalan dan langsung melanjutkan ke iterasi berikutnya, tanpa menghentikan keseluruhan perulangan. 
Contoh: 
```vb
For i As Integer = 1 To 10
    If i Mod 2 = 0 Then
        Continue For
    End If
    Console.WriteLine(i)
Next
```
Kode di atas hanya akan menampilkan bilangan ganjil, karena bilangan genap akan dilompati oleh `Continue For`.

---
## 4. Perulangan Bersarang (Nested Loop)
Perulangan bersarang adalah struktur perulangan yang diletakkan di dalam perulangan lain. Struktur ini umum digunakan untuk memproses data dua dimensi, seperti tabel, matriks, atau pola tampilan tertentu.
Contoh: 
```vb
For i As Integer = 1 To 3
    For j As Integer = 1 To 3
        Console.Write(i & "," & j & " ")
    Next
    Console.WriteLine()
Next
```
Pada contoh tersebut, perulangan luar (variabel `i`) akan berjalan sebanyak tiga kali, dan setiap satu kali perulangan luar berjalan, perulangan dalam (variabel `j`) akan berjalan penuh sebanyak tiga kali. Total kombinasi yang dihasilkan adalah sembilan kali.

---
## 5. Perbandingan Antar Struktur Perulangan
| Struktur Perulangan | Pengecekan Kondisi | Minimal Eksekusi | Logika Berhenti | Cocok Digunakan Untuk |
| :--- | :--- | :--- | :--- | :--- |
| `For...Next`** | Di awal (otomatis via counter) | 0 kali | Saat counter melewati nilai akhir (To) | Jumlah perulangan sudah diketahui pasti sejak awal |
| `For Each...Next` | Di awal (berdasarkan elemen) | 0 kali | Saat semua item dalam koleksi selesai dibaca | Mengakses/membaca seluruh isi Array atau `List` tanpa butuh indeks |
| `Do While...Loop` | Di awal (sebelum masuk blok) | 0 kali | Saat kondisi bernilai False (Salah) | Perulangan fleksibel berbasis syarat, jumlah putaran tidak pasti |
| `Do...Loop While` | Di akhir (setelah blok selesai) | 1 kali | Saat kondisi bernilai False (Salah) | Proses yang wajib jalan minimal 1 kali sebelum diperiksa syaratnya |
| `Do Until...Loop` | Di awal (sebelum masuk blok) | 0 kali | Saat kondisi bernilai True (Benar) | Pengulangan yang berjalan sampai suatu target/kondisi tercapai |
| `Do...Loop Until` | Di akhir (setelah blok selesai) | 1 kali | Saat kondisi bernilai True (Benar) | Sama seperti `Do Until`, tetapi **wajib dijalankan minimal 1 kali** |
| `While...End While` | Di awal | 0 kali | Saat kondisi bernilai False (Salah) | Alternatif simpel/legacy dari `Do While...Loop` |
---  
>  Catatan Penting untuk Diingat
>  1. Perbedaan Logika: `While` vs `Until`
> * `While` $\rightarrow$ Jalan terus selama `True`
>    Syarat: Berhenti ketika kondisi bernilai `False`.
> * `Until` $\rightarrow$ Jalan terus selama `False`
>     Syarat: Berhenti ketika kondisi menjadi `True`.
> 2. Perbedaan Posisi Syarat: Atas vs Bawah
> * Syarat di Atas (`Do While...` / `Do Until...`)
>   Pengecekan dilakukan sebelum masuk ke dalam perulangan.
>   Minimal eksekusi: `0 kali` (jika syarat awal sudah tidak memenuhi, kode di dalamnya langsung dilewati).
> * Syarat di Bawah (`...Loop While` / `...Loop Until`)
>   Pengecekan dilakukan setelah kode di dalam perulangan selesai dijalankan.
>   Minimal eksekusi: `1 kali` (dijamin pasti berjalan minimal sekali, baru kemudian syaratnya diuji). 
