Option Strict On

Public Class FrmDataTable
    Private tabelMahasiswa As DataTable

    Private Function BuatTabelMahasiswa() As DataTable
        Dim tabel As New DataTable("Mahasiswa")
        ' Kolom: nama dan tipe data
        tabel.Columns.Add("Nim", GetType(String))
        tabel.Columns.Add("Nama", GetType(String))
        tabel.Columns.Add("Jurusan", GetType(String))
        tabel.Columns.Add("Angkatan", GetType(Integer))
        tabel.Columns.Add("Ipk", GetType(Decimal))
        ' Baris: urutan nilai mengikuti urutan kolom
        tabel.Rows.Add("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D)
        tabel.Rows.Add("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D)
        tabel.Rows.Add("221712015", "Budi Santoso", "Teknik Informatika", 2022, 3.12D)
        tabel.Rows.Add("241712007", "Dimas Siregar", "Teknik Komputer", 2024, 2.95D)
        tabel.Rows.Add("221712020", "Rina Marpaung", "Manajemen Informatika", 2022, 3.5D)
        tabel.Rows.Add("241712011", "Putri Lubis", "Sistem Informasi", 2024, 3.91D)
        tabel.Rows.Add("231712019", "Fajar Nasution", "Teknik Informatika", 2023, 3.28D)
        tabel.Rows.Add("221712031", "Maya Sari Hasibuan", "Teknik Komputer", 2022, 3.55D)
        Return tabel
    End Function

    Private Sub FrmDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabelMahasiswa = BuatTabelMahasiswa()
        bsMahasiswa.DataSource = tabelMahasiswa         ' DataTable -> BindingSource
        dgvMahasiswa.DataSource = bsMahasiswa           ' BindingSource -> DataGridView
        PerbaruiJumlah()
    End Sub

    Private Sub PerbaruiJumlah()
        lblJumlah.Text = "Menampilkan " & bsMahasiswa.Count.ToString() & " dari " &
                         tabelMahasiswa.Rows.Count.ToString() & " data"
    End Sub

    ' Kolom dibuat otomatis saat DataSource diisi, jadi pengaturannya dilakukan sesudahnya
    Private Sub AturKolom()
        dgvMahasiswa.Columns("Nim").HeaderText = "NIM"
        dgvMahasiswa.Columns("Ipk").HeaderText = "IPK"
        dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Format = "N2"
        dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvMahasiswa.Columns("Angkatan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvMahasiswa.Columns("Nama").FillWeight = 200
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnRapikan_Click(sender As Object, e As EventArgs) Handles btnRapikan.Click
        AturKolom()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim kata As String = AmankanTeksFilter(txtCari.Text.Trim())
        If kata = "" Then
            bsMahasiswa.RemoveFilter()                  ' tampilkan semua data
        Else
            ' Ekspresi Filter milik DataTable, diproses di memori, bukan perintah SQL
            bsMahasiswa.Filter = "Nama LIKE '%" & kata & "%' OR Nim LIKE '%" & kata & "%'"
        End If
        PerbaruiJumlah()
    End Sub
End Class
