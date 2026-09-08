Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblNIM.Click

    End Sub

    Private Sub txtNIM_TextChanged(sender As Object, e As EventArgs) Handles txtNim.TextChanged

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo Selamat Datang!" & vbCrLf &
                        "Nama " & txtNama.Text & vbCrLf &
                        "NIM " & txtNim.Text & vbCrLf &
                        "Kom " & txtKom.Text
                        )




    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles txtHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles txtKeluar.Click
        Me.Close()

    End Sub
End Class
