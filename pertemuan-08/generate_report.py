import os
import base64
import subprocess

base_dir = r"c:\Users\dk\Downloads\pemograman-visual-main\pemograman-visual-main sata\pertemuan-08"
img_dir = os.path.join(base_dir, "gambar", "praktik")

def get_base64_img(filename):
    path = os.path.join(img_dir, filename)
    if os.path.exists(path):
        with open(path, "rb") as f:
            return "data:image/png;base64," + base64.b64encode(f.read()).decode("utf-8")
    return ""

img_01 = get_base64_img("01.png")
img_02 = get_base64_img("02.png")
img_03 = get_base64_img("03.png")
img_04 = get_base64_img("04.png")
img_05 = get_base64_img("05.png")
img_06 = get_base64_img("06.png")
img_07 = get_base64_img("07.png")
img_08 = get_base64_img("08.png")
img_09 = get_base64_img("09.png")
img_10 = get_base64_img("10.png")
img_11 = get_base64_img("11.png")
img_12 = get_base64_img("12.png")
img_13 = get_base64_img("13.png")
img_14 = get_base64_img("14.png")

html_content = f"""<!DOCTYPE html>
<html lang="id">
<head>
<meta charset="UTF-8">
<title>Laporan Praktik Pertemuan 8 - DataGridView, Array & Koleksi Data</title>
<style>
    @page {{
        size: A4;
        margin: 1.5cm;
    }}
    body {{
        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        color: #222;
        line-height: 1.5;
        font-size: 11pt;
        margin: 0;
        padding: 0;
    }}
    .header-box {{
        border-bottom: 3px double #0d6efd;
        padding-bottom: 15px;
        margin-bottom: 25px;
        text-align: center;
    }}
    .header-box h1 {{
        margin: 0 0 5px 0;
        font-size: 18pt;
        color: #0d6efd;
        text-transform: uppercase;
        letter-spacing: 0.5px;
    }}
    .header-box h2 {{
        margin: 0 0 10px 0;
        font-size: 13pt;
        font-weight: 600;
        color: #333;
    }}
    .info-table {{
        width: 100%;
        border-collapse: collapse;
        margin-bottom: 25px;
        background-color: #f8f9fa;
        border: 1px solid #dee2e6;
        border-radius: 6px;
    }}
    .info-table td {{
        padding: 8px 14px;
        font-size: 10.5pt;
    }}
    .info-table td.label {{
        width: 25%;
        font-weight: bold;
        color: #495057;
    }}
    h3.section-title {{
        color: #0d6efd;
        border-left: 4px solid #0d6efd;
        padding-left: 10px;
        font-size: 13pt;
        margin-top: 30px;
        margin-bottom: 12px;
    }}
    h4.subsection-title {{
        color: #333;
        font-size: 11pt;
        margin-top: 15px;
        margin-bottom: 8px;
    }}
    .figure-container {{
        text-align: center;
        margin: 15px 0 20px 0;
        page-break-inside: avoid;
    }}
    .figure-container img {{
        max-width: 90%;
        max-height: 380px;
        border: 1px solid #ced4da;
        border-radius: 4px;
        box-shadow: 0 2px 4px rgba(0,0,0,0.08);
    }}
    .caption {{
        font-size: 9.5pt;
        color: #555;
        margin-top: 6px;
        font-style: italic;
    }}
    .table-data {{
        width: 100%;
        border-collapse: collapse;
        margin: 12px 0;
        font-size: 10pt;
    }}
    .table-data th, .table-data td {{
        border: 1px solid #dee2e6;
        padding: 6px 10px;
        text-align: left;
    }}
    .table-data th {{
        background-color: #e9ecef;
        font-weight: bold;
    }}
    .callout {{
        background-color: #e7f1ff;
        border-left: 4px solid #0d6efd;
        padding: 10px 14px;
        margin: 12px 0;
        font-size: 10pt;
        border-radius: 0 4px 4px 0;
    }}
    .page-break {{
        page-break-after: always;
    }}
</style>
</head>
<body>

<div class="header-box">
    <h1>Laporan Praktik Pemrograman Visual</h1>
    <h2>Pertemuan 8: DataGridView, Array & Koleksi Data</h2>
    <div style="font-size: 10pt; color: #6c757d;">Mata Kuliah: Pemrograman Visual (TIF 3 031) - Semester Ganjil 2026/2027</div>
</div>

<table class="info-table">
    <tr>
        <td class="label">Materi Praktik</td>
        <td>: Praktik 8 - DataGridView, BindingSource, DataTable & Pencarian</td>
    </tr>
    <tr>
        <td class="label">Nama Proyek</td>
        <td>: DataMahasiswa (Windows Forms App VB.NET .NET 10, Option Strict On)</td>
    </tr>
    <tr>
        <td class="label">Status Pengerjaan</td>
        <td>: Lengkap (Langkah 0 sampai Praktik 4 beserta seluruh pengujian)</td>
    </tr>
</table>

<div class="callout">
    <strong>Ringkasan Praktik:</strong> Praktik ini membangun aplikasi <strong>DataMahasiswa</strong> dengan satu form utama (<code>FrmUtama</code>) dan empat form studi kasus yang membandingkan berbagai cara mengelola data di Windows Forms: melalui Array 2 Dimensi (<code>FrmDariArray</code>), List terikat BindingSource (<code>FrmDariList</code>), DataTable dengan filter kueri memori (<code>FrmDataTable</code>), serta pencarian iteratif pada List (<code>FrmCariList</code>).
</div>

<!-- ================= LANGKAH 0 ================= -->
<h3 class="section-title">Langkah 0: Inisialisasi Proyek dan Salin ModValidasi</h3>
<p>Proyek dibuat menggunakan template <strong>Windows Forms App</strong> Visual Basic (.NET 10) dengan opsi <code>Option Strict = On</code>. Form pembuka dinamai <code>FrmUtama.vb</code> dan modul validasi <code>ModValidasi.vb</code> disalin dari Pertemuan 7.</p>

<div class="figure-container">
    <img src="{img_01}" alt="Gambar 01">
    <div class="caption">Gambar 1: Solution Explorer proyek DataMahasiswa berisi FrmUtama.vb dan ModValidasi.vb</div>
</div>

<!-- ================= PRAKTIK 1 ================= -->
<div class="page-break"></div>
<h3 class="section-title">Praktik 1: DataGridView dari Array 2 Dimensi (FrmDariArray)</h3>
<p>Pada praktik ini, DataGridView diisi secara manual menggunakan perulangan bertingkat dari array dua dimensi <code>dataMahasiswa(,)</code>. Dimensi pertama mewakili baris dan dimensi kedua mewakili kolom.</p>

<h4 class="subsection-title">1.1 Perancangan Kolom DataGridView</h4>
<p>Lima kolom didefinisikan lewat dialog <em>Edit Columns</em>: <code>colNim</code> (NIM), <code>colNama</code> (Nama), <code>colJurusan</code> (Jurusan), <code>colAngkatan</code> (Angkatan), dan <code>colIpk</code> (IPK).</p>

<div class="figure-container">
    <img src="{img_02}" alt="Gambar 02">
    <div class="caption">Gambar 2: Dialog Edit Columns dgvMahasiswa dengan lima kolom terkonfigurasi</div>
</div>

<h4 class="subsection-title">1.2 Desain Form FrmDariArray</h4>
<div class="figure-container">
    <img src="{img_03}" alt="Gambar 03">
    <div class="caption">Gambar 3: Tampilan form FrmDariArray di Visual Studio Form Designer</div>
</div>

<h4 class="subsection-title">1.3 Pengujian Form FrmDariArray</h4>
<p>Saat tombol <strong>Tampilkan</strong> diklik, seluruh 8 data dari array berhasil masuk ke grid dan label jumlah menunjukkan <code>Jumlah data: 8</code>. Baris terpilih secara penuh (FullRowSelect) dan grid berstatus ReadOnly.</p>

<div class="figure-container">
    <img src="{img_04}" alt="Gambar 04">
    <div class="caption">Gambar 4: FrmDariArray setelah tombol Tampilkan diklik, 8 baris data tampil</div>
</div>

<!-- ================= PRAKTIK 2 ================= -->
<div class="page-break"></div>
<h3 class="section-title">Praktik 2: List(Of Mahasiswa) dan BindingSource (FrmDariList)</h3>
<p>Praktik ini menerapkan konsep Object-Oriented Programming (OOP) dengan membuat class <code>Mahasiswa</code> yang memiliki properti Nim, Nama, Jurusan, Angkatan, dan Ipk. Data ditampung dalam <code>List(Of Mahasiswa)</code> dan diikat ke DataGridView melalui perantara <strong>BindingSource</strong>.</p>

<h4 class="subsection-title">2.1 Desain Form FrmDariList</h4>
<p>Form dilengkapi kontrol masukan di bagian atas, tabel DataGridView di bawah, serta komponen <code>bsMahasiswa</code> dan <code>errInput</code> di component tray.</p>

<div class="figure-container">
    <img src="{img_05}" alt="Gambar 05">
    <div class="caption">Gambar 5: FrmDariList di Form Designer dengan bsMahasiswa dan errInput di component tray</div>
</div>

<h4 class="subsection-title">2.2 Tampilan Awal Form FrmDariList</h4>
<p>Saat form dimuat, 4 data mahasiswa contoh langsung tampil pada DataGridView melalui BindingSource.</p>

<div class="figure-container">
    <img src="{img_06}" alt="Gambar 06">
    <div class="caption">Gambar 6: FrmDariList saat pertama kali dijalankan dengan 4 data mahasiswa</div>
</div>

<h4 class="subsection-title">2.3 Penambahan Data Baru dengan Validasi</h4>
<p>Menambahkan data baru (NIM: <code>241712011</code>, Nama: <code>Putri Lubis</code>, Jurusan: <code>Sistem Informasi</code>, Angkatan: <code>2024</code>, IPK: <code>3.91</code>). Karena data ditambahkan melalui <code>bsMahasiswa.Add(baru)</code>, baris kelima langsung muncul otomatis di DataGridView tanpa perlu memuat ulang data.</p>

<div class="figure-container">
    <img src="{img_07}" alt="Gambar 07">
    <div class="caption">Gambar 7: FrmDariList setelah data Putri Lubis berhasil ditambahkan (jumlah data: 5)</div>
</div>

<!-- ================= PRAKTIK 3 ================= -->
<div class="page-break"></div>
<h3 class="section-title">Praktik 3: DataTable, Rapikan Kolom, dan Filter (FrmDataTable)</h3>
<p>Menggunakan objek <code>DataTable</code> sebagai basis data memori. Kolom dibuat dinamis dan data disaring menggunakan sintaks ekspresi <code>BindingSource.Filter</code> dengan pengamanan karakter khusus melalui modul <code>ModPencarian.vb</code>.</p>

<h4 class="subsection-title">3.1 Desain Form FrmDataTable</h4>
<div class="figure-container">
    <img src="{img_08}" alt="Gambar 08">
    <div class="caption">Gambar 8: FrmDataTable di Designer dengan komponen bsMahasiswa</div>
</div>

<h4 class="subsection-title">3.2 Sebelum dan Sesudah Merapikan Kolom</h4>
<table style="width: 100%; border: none;">
    <tr>
        <td style="width: 50%; vertical-align: top; text-align: center;">
            <div class="figure-container">
                <img src="{img_09}" style="max-height: 220px;" alt="Gambar 09">
                <div class="caption">Gambar 9: Sebelum tombol Rapikan Kolom diklik</div>
            </div>
        </td>
        <td style="width: 50%; vertical-align: top; text-align: center;">
            <div class="figure-container">
                <img src="{img_10}" style="max-height: 220px;" alt="Gambar 10">
                <div class="caption">Gambar 10: Sesudah tombol Rapikan Kolom diklik</div>
            </div>
        </td>
    </tr>
</table>
<p style="font-size: 9.5pt; color: #555;"><em>Penjelasan:</em> Tombol <strong>Rapikan Kolom</strong> mengubah judul kolom menjadi huruf kapital rapi (NIM, IPK), meratakan teks IPK ke kanan dengan format 2 desimal (<code>N2</code>), meratakan Angkatan ke tengah, memperlebar kolom Nama (<code>FillWeight = 200</code>), serta mengatur <code>AutoSizeColumnsMode = Fill</code>.</p>

<h4 class="subsection-title">3.3 Pencarian Real-Time dengan Filter BindingSource</h4>
<p>Saat kata <code>sari</code> diketik pada kotak pencarian, ekspresi <code>bsMahasiswa.Filter = "Nama LIKE '%sari%' OR Nim LIKE '%sari%'"</code> dieksekusi secara instan dan menampilkan 2 data (Sari Wulandari dan Maya Sari Hasibuan).</p>

<div class="figure-container">
    <img src="{img_11}" alt="Gambar 11">
    <div class="caption">Gambar 11: FrmDataTable dengan txtCari berisi "sari", menampilkan 2 dari 8 data</div>
</div>

<!-- ================= PRAKTIK 4 ================= -->
<div class="page-break"></div>
<h3 class="section-title">Praktik 4: Pencarian pada List(Of T) dengan Perulangan (FrmCariList)</h3>
<p>Karena objek generic <code>List(Of T)</code> tidak memiliki properti ekspresi <code>Filter</code> seperti DataTable, proses pencarian dilakukan menggunakan perulangan <code>For Each</code> yang menyaring data secara manual dan memasukkannya ke List hasil baru.</p>

<h4 class="subsection-title">4.1 Desain Form FrmCariList dan FrmUtama</h4>
<table style="width: 100%; border: none;">
    <tr>
        <td style="width: 50%; vertical-align: top; text-align: center;">
            <div class="figure-container">
                <img src="{img_12}" style="max-height: 230px;" alt="Gambar 12">
                <div class="caption">Gambar 12: FrmCariList di Form Designer</div>
            </div>
        </td>
        <td style="width: 50%; vertical-align: top; text-align: center;">
            <div class="figure-container">
                <img src="{img_13}" style="max-height: 230px;" alt="Gambar 13">
                <div class="caption">Gambar 13: FrmUtama di Designer dengan 4 tombol</div>
            </div>
        </td>
    </tr>
</table>

<h4 class="subsection-title">4.2 Pengujian Pencarian Menggunakan Perulangan</h4>
<p>Mengetik kata <code>sari</code> di <code>txtCari</code> memicu event <code>TextChanged</code> yang melakukan iterasi dan menghasilkan 2 baris data yang cocok.</p>

<div class="figure-container">
    <img src="{img_14}" alt="Gambar 14">
    <div class="caption">Gambar 14: FrmCariList menyaring 2 data dengan kata kunci "sari"</div>
</div>

<!-- ================= TABEL PENGUJIAN ================= -->
<h3 class="section-title">Hasil Pengujian Keseluruhan Praktik 8</h3>
<table class="table-data">
    <thead>
        <tr>
            <th>No</th>
            <th>Form / Praktik</th>
            <th>Langkah Uji</th>
            <th>Hasil yang Diharapkan</th>
            <th>Status</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td>
            <td>FrmDariArray</td>
            <td>Klik tombol Tampilkan dan Kosongkan</td>
            <td>Grid menampilkan 8 data; saat dikosongkan grid bersih</td>
            <td><strong style="color: green;">Berhasil</strong></td>
        </tr>
        <tr>
            <td>2</td>
            <td>FrmDariList</td>
            <td>Tambah data baru Putri Lubis</td>
            <td>Baris ke-5 langsung muncul di grid melalui BindingSource</td>
            <td><strong style="color: green;">Berhasil</strong></td>
        </tr>
        <tr>
            <td>3</td>
            <td>FrmDariList</td>
            <td>Uji validasi isian kosong & NIM ganda</td>
            <td>Ikon ErrorProvider muncul di samping kontrol yang salah</td>
            <td><strong style="color: green;">Berhasil</strong></td>
        </tr>
        <tr>
            <td>4</td>
            <td>FrmDataTable</td>
            <td>Klik Rapikan Kolom & Cari "sari"</td>
            <td>Kolom rapi dan grid menampilkan 2 data yang cocok</td>
            <td><strong style="color: green;">Berhasil</strong></td>
        </tr>
        <tr>
            <td>5</td>
            <td>FrmDataTable</td>
            <td>Ketik tanda kutip (') di kotak cari</td>
            <td>Aplikasi aman dari error filter dan tidak crash</td>
            <td><strong style="color: green;">Berhasil</strong></td>
        </tr>
        <tr>
            <td>6</td>
            <td>FrmCariList</td>
            <td>Cari kata "sari" atau NIM "2317"</td>
            <td>Perulangan For Each berhasil memfilter data ke grid</td>
            <td><strong style="color: green;">Berhasil</strong></td>
        </tr>
    </tbody>
</table>

<div class="callout" style="margin-top: 25px;">
    <strong>Kesimpulan Praktik:</strong> Penggunaan <code>BindingSource</code> sangat memudahkan pembaruan tampilan antarmuka saat data bertambah. Untuk skenario data tabel yang dinamis dengan kebutuhan pencarian berbasis filter string, <code>DataTable</code> memberikan performa dan fleksibilitas lebih baik karena mendukung ekspresi kueri langsung di memori. Sementara itu, untuk struktur objek berorientasi objek yang ketat, <code>List(Of T)</code> sangat aman dan pencarian dilakukan menggunakan iterasi kode program.
</div>

</body>
</html>
"""

html_path = os.path.join(base_dir, "Laporan_Praktik_Pertemuan_08.html")
with open(html_path, "w", encoding="utf-8") as f:
    f.write(html_content)

print("HTML report successfully generated at:", html_path)
