Public Class Form1
    Private Sub LblNama_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ModQuery.TambahData(
            txtNIM.Text,
            txtNama.Text,
            txtJurusan.Text
) Then
            MessageBox.Show("Data berhasil disimpan")
        End If
        txtNIM.Clear()
        txtNama.Clear()
        txtJurusan.Clear()
    End Sub

    Private Sub LblNIM_Click(sender As Object, e As EventArgs) Handles lblNIM.Click

    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub
End Class
