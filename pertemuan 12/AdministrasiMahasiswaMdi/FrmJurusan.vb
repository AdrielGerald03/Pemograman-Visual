Option Strict On

Partial Class FrmJurusan
    Private Sub lstJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstJurusan.SelectedIndexChanged
        If lstJurusan.SelectedItem Is Nothing Then Return
        lblKeterangan.Text = "Jurusan dipilih: " & lstJurusan.SelectedItem.ToString()
    End Sub
End Class
