Public Class FrmLogin

    ' Event saat Role dipilih (mengganti gambar foto avatar jika ada)
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem IsNot Nothing Then
            Dim selectedRole As String = cmbRole.SelectedItem.ToString()

            If selectedRole = "Manager" Then
                picImage.Image = Image.FromFile("Asset\manajer.png")
            ElseIf selectedRole = "Staff" Then
                picImage.Image = Image.FromFile("Asset\staff.png")
            End If
        End If
    End Sub

    ' Validasi input Nama: hanya huruf dan spasi
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi input NIM: hanya angka
    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Logika Tombol Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 1. Validasi jika role belum dipilih
        If cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih Role terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Validasi input nama kosong
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        ' 3. Validasi input NIM kosong
        If String.IsNullOrWhiteSpace(txtNIM.Text) Then
            MessageBox.Show("NIM tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If

        ' Ambil nilai input
        Dim role As String = cmbRole.SelectedItem.ToString()
        Dim namaInput As String = txtNama.Text.Trim().ToLower()
        Dim nimInput As String = txtNIM.Text.Trim()

        Dim isValid As Boolean = False

        ' Pemeriksaan kombinasi data pengujian (Case-Insensitive untuk nama)
        If role = "Staff" AndAlso namaInput = "nadya" AndAlso nimInput = "241712051" Then
            isValid = True
        ElseIf role = "Manager" AndAlso namaInput = "shata diyaul haq" AndAlso nimInput = "241712061" Then
            isValid = True
        End If

        ' Perilaku Hasil Login
        If isValid Then
            ' a. Kosongkan input nama dan NIM
            txtNama.Clear()
            txtNIM.Clear()

            ' b. Buka FrmPajak menggunakan method Show
            FrmPajak.Show()

            ' c. Sembunyikan FrmLogin menggunakan method Hide
            Me.Hide()
        Else
            ' d. Jika gagal: Tampilkan pesan kesalahan, jangan buka FrmPajak, tetap di form login
            MessageBox.Show("Kombinasi Role, Nama, atau NIM tidak sesuai!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNIM.Focus()
        End If
    End Sub

End Class
