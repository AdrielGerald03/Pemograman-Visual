Option Strict On

Imports System.Runtime.InteropServices

Public Class FrmAsistenPresentasi

    ' Deklarasi Windows API untuk Global Hotkey (Ctrl+Alt+F9 & Ctrl+Alt+F10)
    <DllImport("user32.dll")>
    Private Shared Function RegisterHotKey(hWnd As IntPtr, id As Integer, fsModifiers As UInteger, vk As UInteger) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function UnregisterHotKey(hWnd As IntPtr, id As Integer) As Boolean
    End Function

    Private Const MOD_ALT As UInteger = &H1
    Private Const MOD_CONTROL As UInteger = &H2
    Private Const WM_HOTKEY As Integer = &H312

    Private Const HOTKEY_MULAI_JEDA As Integer = 1
    Private Const HOTKEY_ULANGI As Integer = 2

    Private Const VK_F9 As UInteger = &H78
    Private Const VK_F10 As UInteger = &H79

    ' Variabel logika timer
    Private sisaDetik As Integer = 300
    Private totalDurasiDetik As Integer = 300
    Private sedangBerjalan As Boolean = False
    Private isModeRingkas As Boolean = False

    Private Sub FrmAsistenPresentasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Daftarkan Hotkey global
        RegisterHotKey(Me.Handle, HOTKEY_MULAI_JEDA, MOD_CONTROL Or MOD_ALT, VK_F9)
        RegisterHotKey(Me.Handle, HOTKEY_ULANGI, MOD_CONTROL Or MOD_ALT, VK_F10)

        ' Set awal durasi dari numeric up down
        HitungDurasiAwal()
        PerbaruiTampilanTimer()
        lblStatusTimer.Text = "Siap presentasi"
        lblHintTimer.Text = "Atur durasi, lalu mulai ketika Anda siap."
        lblStatusBawah.Text = "Timer siap. Aktifkan Tetap di atas agar terlihat saat berganti aplikasi."
    End Sub

    Private Sub FrmAsistenPresentasi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Hapus pendaftaran hotkey saat form ditutup
        UnregisterHotKey(Me.Handle, HOTKEY_MULAI_JEDA)
        UnregisterHotKey(Me.Handle, HOTKEY_ULANGI)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As Integer = m.WParam.ToInt32()
            If id = HOTKEY_MULAI_JEDA Then
                ToggleMulaiJeda()
            ElseIf id = HOTKEY_ULANGI Then
                ResetTimer()
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub HitungDurasiAwal()
        totalDurasiDetik = CInt(nudMenit.Value * 60 + nudDetik.Value)
        If totalDurasiDetik <= 0 Then
            totalDurasiDetik = 1
        End If
        sisaDetik = totalDurasiDetik
    End Sub

    Private Sub PerbaruiTampilanTimer()
        Dim m As Integer = sisaDetik \ 60
        Dim s As Integer = sisaDetik Mod 60
        lblDisplayTimer.Text = String.Format("{0:00}:{1:00}", m, s)
    End Sub

    Private Sub ToggleMulaiJeda()
        If Not sedangBerjalan Then
            ' Jika timer baru dimulai atau setelah selesai/reset
            If sisaDetik <= 0 Then
                HitungDurasiAwal()
            End If

            timerHitungMundur.Start()
            sedangBerjalan = True
            btnMulaiJeda.Text = "Jeda"
            lblStatusTimer.Text = "Presentasi sedang berlangsung..."
            lblHintTimer.Text = "Fokus pada materi Anda."
            lblStatusBawah.Text = "Timer berjalan. Tekan Jeda atau Ctrl+Alt+F9 untuk menghentikan sementara."
            nudMenit.Enabled = False
            nudDetik.Enabled = False
        Else
            ' Jeda timer
            timerHitungMundur.Stop()
            sedangBerjalan = False
            btnMulaiJeda.Text = "Lanjutkan"
            lblStatusTimer.Text = "Timer dijeda"
            lblHintTimer.Text = "Klik Lanjutkan untuk meneruskan."
            lblStatusBawah.Text = "Timer dijeda. Tekan Mulai presentasi atau Ctrl+Alt+F9 untuk lanjut."
            nudMenit.Enabled = True
            nudDetik.Enabled = True
        End If
    End Sub

    Private Sub ResetTimer()
        timerHitungMundur.Stop()
        sedangBerjalan = False
        HitungDurasiAwal()
        PerbaruiTampilanTimer()
        btnMulaiJeda.Text = "Mulai presentasi"
        lblStatusTimer.Text = "Siap presentasi"
        lblHintTimer.Text = "Atur durasi, lalu mulai ketika Anda siap."
        lblStatusBawah.Text = "Timer diatur ulang. Siap untuk presentasi baru."
        nudMenit.Enabled = True
        nudDetik.Enabled = True
    End Sub

    Private Sub btnMulaiJeda_Click(sender As Object, e As EventArgs) Handles btnMulaiJeda.Click
        ToggleMulaiJeda()
    End Sub

    Private Sub btnUlangi_Click(sender As Object, e As EventArgs) Handles btnUlangi.Click
        ResetTimer()
    End Sub

    Private Sub timerHitungMundur_Tick(sender As Object, e As EventArgs) Handles timerHitungMundur.Tick
        If sisaDetik > 0 Then
            sisaDetik -= 1
            PerbaruiTampilanTimer()

            If sisaDetik = 0 Then
                timerHitungMundur.Stop()
                sedangBerjalan = False
                btnMulaiJeda.Text = "Mulai presentasi"
                lblStatusTimer.Text = "Waktu habis!"
                lblHintTimer.Text = "Presentasi telah selesai."
                lblStatusBawah.Text = "Waktu presentasi telah berakhir."
                nudMenit.Enabled = True
                nudDetik.Enabled = True

                If chkBunyi.Checked Then
                    System.Media.SystemSounds.Exclamation.Play()
                End If
            End If
        End If
    End Sub

    Private Sub chkTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles chkTopMost.CheckedChanged
        Me.TopMost = chkTopMost.Checked
    End Sub

    Private Sub nudMenit_ValueChanged(sender As Object, e As EventArgs) Handles nudMenit.ValueChanged
        If Not sedangBerjalan Then
            HitungDurasiAwal()
            PerbaruiTampilanTimer()
        End If
    End Sub

    Private Sub nudDetik_ValueChanged(sender As Object, e As EventArgs) Handles nudDetik.ValueChanged
        If Not sedangBerjalan Then
            HitungDurasiAwal()
            PerbaruiTampilanTimer()
        End If
    End Sub

    Private Sub btnModeRingkas_Click(sender As Object, e As EventArgs) Handles btnModeRingkas.Click
        isModeRingkas = Not isModeRingkas

        If isModeRingkas Then
            btnModeRingkas.Text = "Mode normal"
            lblJudul.Visible = False
            lblSubJudul.Visible = False
            lblDurasiJudul.Visible = False
            lblMenit.Visible = False
            nudMenit.Visible = False
            lblDetik.Visible = False
            nudDetik.Visible = False
            chkBunyi.Visible = False
            lblShortcutInfo1.Visible = False
            lblShortcutInfo2.Visible = False
            lblStatusBawah.Visible = False

            ' Posisikan ulang di tampilan ringkas
            pnlTimer.Location = New Point(12, 12)
            pnlTimer.Size = New Size(280, 100)
            lblDisplayTimer.Font = New Font("Segoe UI", 32.0F, FontStyle.Bold)

            btnMulaiJeda.Location = New Point(12, 120)
            btnMulaiJeda.Size = New Size(135, 30)

            btnUlangi.Location = New Point(155, 120)
            btnUlangi.Size = New Size(65, 30)

            btnModeRingkas.Location = New Point(225, 120)
            btnModeRingkas.Size = New Size(67, 30)

            chkTopMost.Location = New Point(12, 158)

            Me.ClientSize = New Size(305, 185)
        Else
            btnModeRingkas.Text = "Mode ringkas"
            lblJudul.Visible = True
            lblSubJudul.Visible = True
            lblDurasiJudul.Visible = True
            lblMenit.Visible = True
            nudMenit.Visible = True
            lblDetik.Visible = True
            nudDetik.Visible = True
            chkBunyi.Visible = True
            lblShortcutInfo1.Visible = True
            lblShortcutInfo2.Visible = True
            lblStatusBawah.Visible = True

            ' Kembalikan posisi awal
            pnlTimer.Location = New Point(28, 88)
            pnlTimer.Size = New Size(420, 160)
            lblDisplayTimer.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold)

            btnMulaiJeda.Location = New Point(28, 262)
            btnMulaiJeda.Size = New Size(256, 38)

            btnUlangi.Location = New Point(298, 262)
            btnUlangi.Size = New Size(150, 32)

            btnModeRingkas.Location = New Point(298, 308)
            btnModeRingkas.Size = New Size(150, 32)

            chkTopMost.Location = New Point(28, 324)

            Me.ClientSize = New Size(478, 545)
        End If
    End Sub

End Class

