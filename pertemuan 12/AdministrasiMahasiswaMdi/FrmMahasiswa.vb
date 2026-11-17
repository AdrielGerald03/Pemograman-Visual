Option Strict On
Imports System.ComponentModel

Partial Class FrmMahasiswa
    Private Sub FrmMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabel As New DataTable()
        tabel.Columns.Add("NIM", GetType(String))
        tabel.Columns.Add("Nama", GetType(String))
        tabel.Columns.Add("Jurusan", GetType(String))
        tabel.Rows.Add("260100001", "Alya", "Teknik Informatika")
        tabel.Rows.Add("260100002", "Bima", "Teknik Informatika")
        tabel.Rows.Add("260100003", "Citra", "Sistem Informasi")
        dgvMahasiswa.DataSource = tabel
        PerbaruiMenuCatatan()
    End Sub

    Private Sub BersihkanCatatan()
        txtCatatan.Clear()
        txtCatatan.Focus()
    End Sub

    Private Sub Bersihkan_Click(sender As Object, e As EventArgs) _
        Handles btnBersihkanCatatan.Click, mnuBersihkanCatatan.Click
        BersihkanCatatan()
    End Sub

    Private Sub mnuPilihSemuaCatatan_Click(sender As Object, e As EventArgs) Handles mnuPilihSemuaCatatan.Click
        txtCatatan.Focus()
        txtCatatan.SelectAll()
    End Sub

    Private Sub PerbaruiMenuCatatan()
        Dim adaTeks As Boolean = txtCatatan.TextLength > 0
        mnuPilihSemuaCatatan.Enabled = adaTeks
        mnuBersihkanCatatan.Enabled = adaTeks
        btnBersihkanCatatan.Enabled = adaTeks
    End Sub

    Private Sub txtCatatan_TextChanged(sender As Object, e As EventArgs) Handles txtCatatan.TextChanged
        PerbaruiMenuCatatan()
    End Sub

    Private Sub cmsCatatan_Opening(sender As Object, e As CancelEventArgs) Handles cmsCatatan.Opening
        PerbaruiMenuCatatan()
    End Sub
End Class
