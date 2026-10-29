# Database

## Pembahasan

- Pengantar Database dengan PostgreSQL, Supabase dan Npgsql di VB.Net
- Koneksi Database PostgreSQL Menggunakan Npgsql ke Supabase
- Manipulasi Data CRUD dengan Npgsql

## Database

Database adalah kumpulan data terstruktur yang disimpan agar bisa diakses, dikelola, dan dimanipulasi oleh aplikasi. Dalam aplikasi, database menyimpan informasi penting sehingga aplikasi bisa menyajikan, mengubah, dan menjaga konsistensi data.

## PostgreSQL

PostgreSQL (sering disebut Postgres) adalah sistem manajemen basis data relasional objek (ORDBMS) kelas atas yang bersifat sumber terbuka (open-source). Sistem ini menggunakan dan memperluas bahasa SQL untuk menyimpan, mengelola, dan mengambil data secara aman dan efisien.

## Supabase

Supabase adalah platform Backend-as-a-Service (BaaS) yang membungkus PostgreSQL menjadi solusi siap pakai. Jika PostgreSQL adalah "mesin" utamanya, Supabase adalah "pabrik" lengkap dengan panel kendali (API, Auth, Dashboard) agar Anda bisa langsung mengembangkan aplikasi tanpa harus membangun infrastruktur dari nol.

## Npgsql

Npgsql adalah data provider ADO.NET sumber terbuka (open-source) yang berfungsi sebagai "jembatan" penghubung utama antara aplikasi .NET (seperti C#, F#, atau VB.NET) dengan database PostgreSQL.

### NpgsqlConnection

Berfungsi untuk membuat, membuka, dan mengelola jalur koneksi fisik (sesi) antara aplikasi .NET Anda dengan database PostgreSQL.

### NpgsqlCommand

Digunakan untuk mendefinisikan dan mengeksekusi kueri teks SQL (seperti SELECT, INSERT, UPDATE, DELETE) atau stored procedure terhadap database melalui jalur koneksi yang sudah dibuka.

### DataAdapter

Bertindak sebagai perantara jembatan yang mengambil kumpulan data dari PostgreSQL untuk disimpan ke dalam memori aplikasi (seperti DataTable atau DataSet), serta bertugas mengirimkan kembali perubahan data dari memori tersebut kembali ke database.

### NpgsqlCommandBuilder

Utilitas pembuat kueri INSERT, UPDATE, dan DELETE otomatis untuk NpgsqlDataAdapter berdasarkan kueri SELECT, sehingga Anda terbebas dari keharusan menulis kueri modifikasi tersebut secara manual.