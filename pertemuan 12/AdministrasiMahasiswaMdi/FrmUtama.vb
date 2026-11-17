Option Strict On

Partial Class FrmUtama
    Private Sub BukaMahasiswa()
        For Each anak As Form In Me.MdiChildren
            If TypeOf anak Is FrmMahasiswa Then
                If anak.WindowState = FormWindowState.Minimized Then
                    anak.WindowState = FormWindowState.Normal
                End If
                anak.Activate()
                Return
            End If
        Next
        Dim baru As New FrmMahasiswa()
        baru.MdiParent = Me
        baru.Show()
    End Sub

    Private Sub BukaJurusan()
        For Each anak As Form In Me.MdiChildren
            If TypeOf anak Is FrmJurusan Then
                If anak.WindowState = FormWindowState.Minimized Then
                    anak.WindowState = FormWindowState.Normal
                End If
                anak.Activate()
                Return
            End If
        Next
        Dim baru As New FrmJurusan()
        baru.MdiParent = Me
        baru.Show()
    End Sub

    Private Sub mnuDataMahasiswa_Click(sender As Object, e As EventArgs) Handles mnuDataMahasiswa.Click
        BukaMahasiswa()
    End Sub

    Private Sub mnuDataJurusan_Click(sender As Object, e As EventArgs) Handles mnuDataJurusan.Click
        BukaJurusan()
    End Sub

    Private Sub mnuBertumpuk_Click(sender As Object, e As EventArgs) Handles mnuBertumpuk.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuHorizontal_Click(sender As Object, e As EventArgs) Handles mnuHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuVertikal_Click(sender As Object, e As EventArgs) Handles mnuVertikal.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuTutupAktif_Click(sender As Object, e As EventArgs) Handles mnuTutupAktif.Click
        If Me.ActiveMdiChild IsNot Nothing Then Me.ActiveMdiChild.Close()
    End Sub

    Private Sub mnuTutupSemua_Click(sender As Object, e As EventArgs) Handles mnuTutupSemua.Click
        For Each anak As Form In Me.MdiChildren
            anak.Close()
        Next
    End Sub

    Private Sub PerbaruiMenuJendela(sender As Object, e As EventArgs) _
        Handles MyBase.MdiChildActivate, mnuJendela.DropDownOpening
        Dim adaAnak As Boolean = Me.MdiChildren.Length > 0
        mnuTutupAktif.Enabled = Me.ActiveMdiChild IsNot Nothing
        mnuTutupSemua.Enabled = adaAnak
        mnuBertumpuk.Enabled = adaAnak
        mnuHorizontal.Enabled = adaAnak
        mnuVertikal.Enabled = adaAnak
    End Sub

    Private Sub mnuTentang_Click(sender As Object, e As EventArgs) Handles mnuTentang.Click
        Using dialog As New FrmTentang()
            dialog.ShowDialog(Me)
        End Using
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Me.Close()
    End Sub

    Private Sub FrmUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason <> CloseReason.UserClosing Then Return
        Dim jawaban As DialogResult = MessageBox.Show(Me,
            "Keluar dari aplikasi? Catatan sementara pada child akan hilang.", "Konfirmasi keluar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        e.Cancel = jawaban <> DialogResult.Yes
    End Sub
End Class
