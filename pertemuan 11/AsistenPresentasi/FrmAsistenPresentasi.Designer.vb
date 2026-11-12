<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsistenPresentasi
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        lblJudul = New System.Windows.Forms.Label()
        lblSubJudul = New System.Windows.Forms.Label()
        pnlTimer = New System.Windows.Forms.Panel()
        lblStatusTimer = New System.Windows.Forms.Label()
        lblDisplayTimer = New System.Windows.Forms.Label()
        lblHintTimer = New System.Windows.Forms.Label()
        btnMulaiJeda = New System.Windows.Forms.Button()
        btnUlangi = New System.Windows.Forms.Button()
        chkTopMost = New System.Windows.Forms.CheckBox()
        btnModeRingkas = New System.Windows.Forms.Button()
        lblDurasiJudul = New System.Windows.Forms.Label()
        lblMenit = New System.Windows.Forms.Label()
        nudMenit = New System.Windows.Forms.NumericUpDown()
        lblDetik = New System.Windows.Forms.Label()
        nudDetik = New System.Windows.Forms.NumericUpDown()
        chkBunyi = New System.Windows.Forms.CheckBox()
        lblShortcutInfo1 = New System.Windows.Forms.Label()
        lblShortcutInfo2 = New System.Windows.Forms.Label()
        lblStatusBawah = New System.Windows.Forms.Label()
        timerHitungMundur = New System.Windows.Forms.Timer(components)
        pnlTimer.SuspendLayout()
        CType(nudMenit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDetik, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold)
        lblJudul.ForeColor = System.Drawing.Color.FromArgb(40, 50, 60)
        lblJudul.Location = New System.Drawing.Point(24, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(206, 30)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Asisten Presentasi"
        '
        'lblSubJudul
        '
        lblSubJudul.AutoSize = True
        lblSubJudul.Font = New System.Drawing.Font("Segoe UI", 9.25F)
        lblSubJudul.ForeColor = System.Drawing.Color.FromArgb(100, 110, 120)
        lblSubJudul.Location = New System.Drawing.Point(26, 54)
        lblSubJudul.Name = "lblSubJudul"
        lblSubJudul.Size = New System.Drawing.Size(232, 17)
        lblSubJudul.TabIndex = 1
        lblSubJudul.Text = "Jaga durasi tanpa meninggalkan slide Anda."
        '
        'pnlTimer
        '
        pnlTimer.BackColor = System.Drawing.Color.FromArgb(85, 95, 110)
        pnlTimer.Controls.Add(lblStatusTimer)
        pnlTimer.Controls.Add(lblDisplayTimer)
        pnlTimer.Controls.Add(lblHintTimer)
        pnlTimer.Location = New System.Drawing.Point(28, 88)
        pnlTimer.Name = "pnlTimer"
        pnlTimer.Size = New System.Drawing.Size(420, 160)
        pnlTimer.TabIndex = 2
        '
        'lblStatusTimer
        '
        lblStatusTimer.Dock = System.Windows.Forms.DockStyle.Top
        lblStatusTimer.Font = New System.Drawing.Font("Segoe UI", 9.75F)
        lblStatusTimer.ForeColor = System.Drawing.Color.FromArgb(210, 220, 230)
        lblStatusTimer.Location = New System.Drawing.Point(0, 0)
        lblStatusTimer.Name = "lblStatusTimer"
        lblStatusTimer.Padding = New System.Windows.Forms.Padding(0, 14, 0, 0)
        lblStatusTimer.Size = New System.Drawing.Size(420, 32)
        lblStatusTimer.TabIndex = 0
        lblStatusTimer.Text = "Siap presentasi"
        lblStatusTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplayTimer
        '
        lblDisplayTimer.Dock = System.Windows.Forms.DockStyle.Fill
        lblDisplayTimer.Font = New System.Drawing.Font("Segoe UI", 48.0F, System.Drawing.FontStyle.Bold)
        lblDisplayTimer.ForeColor = System.Drawing.Color.White
        lblDisplayTimer.Location = New System.Drawing.Point(0, 32)
        lblDisplayTimer.Name = "lblDisplayTimer"
        lblDisplayTimer.Size = New System.Drawing.Size(420, 96)
        lblDisplayTimer.TabIndex = 1
        lblDisplayTimer.Text = "05:00"
        lblDisplayTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHintTimer
        '
        lblHintTimer.Dock = System.Windows.Forms.DockStyle.Bottom
        lblHintTimer.Font = New System.Drawing.Font("Segoe UI", 8.5F)
        lblHintTimer.ForeColor = System.Drawing.Color.FromArgb(200, 210, 220)
        lblHintTimer.Location = New System.Drawing.Point(0, 128)
        lblHintTimer.Name = "lblHintTimer"
        lblHintTimer.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        lblHintTimer.Size = New System.Drawing.Size(420, 32)
        lblHintTimer.TabIndex = 2
        lblHintTimer.Text = "Atur durasi, lalu mulai ketika Anda siap."
        lblHintTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMulaiJeda
        '
        btnMulaiJeda.BackColor = System.Drawing.Color.FromArgb(88, 101, 192)
        btnMulaiJeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnMulaiJeda.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
        btnMulaiJeda.ForeColor = System.Drawing.Color.White
        btnMulaiJeda.Location = New System.Drawing.Point(28, 262)
        btnMulaiJeda.Name = "btnMulaiJeda"
        btnMulaiJeda.Size = New System.Drawing.Size(256, 38)
        btnMulaiJeda.TabIndex = 3
        btnMulaiJeda.Text = "Mulai presentasi"
        btnMulaiJeda.UseVisualStyleBackColor = False
        '
        'btnUlangi
        '
        btnUlangi.BackColor = System.Drawing.Color.White
        btnUlangi.FlatStyle = System.Windows.Forms.FlatStyle.System
        btnUlangi.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        btnUlangi.Location = New System.Drawing.Point(298, 262)
        btnUlangi.Name = "btnUlangi"
        btnUlangi.Size = New System.Drawing.Size(150, 32)
        btnUlangi.TabIndex = 4
        btnUlangi.Text = "Ulangi"
        btnUlangi.UseVisualStyleBackColor = True
        '
        'chkTopMost
        '
        chkTopMost.AutoSize = True
        chkTopMost.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        chkTopMost.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80)
        chkTopMost.Location = New System.Drawing.Point(28, 324)
        chkTopMost.Name = "chkTopMost"
        chkTopMost.Size = New System.Drawing.Size(147, 19)
        chkTopMost.TabIndex = 5
        chkTopMost.Text = "Tetap di atas aplikasi lain"
        chkTopMost.UseVisualStyleBackColor = True
        '
        'btnModeRingkas
        '
        btnModeRingkas.BackColor = System.Drawing.Color.White
        btnModeRingkas.FlatStyle = System.Windows.Forms.FlatStyle.System
        btnModeRingkas.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        btnModeRingkas.Location = New System.Drawing.Point(298, 308)
        btnModeRingkas.Name = "btnModeRingkas"
        btnModeRingkas.Size = New System.Drawing.Size(150, 32)
        btnModeRingkas.TabIndex = 6
        btnModeRingkas.Text = "Mode ringkas"
        btnModeRingkas.UseVisualStyleBackColor = True
        '
        'lblDurasiJudul
        '
        lblDurasiJudul.AutoSize = True
        lblDurasiJudul.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
        lblDurasiJudul.ForeColor = System.Drawing.Color.FromArgb(50, 60, 70)
        lblDurasiJudul.Location = New System.Drawing.Point(26, 366)
        lblDurasiJudul.Name = "lblDurasiJudul"
        lblDurasiJudul.Size = New System.Drawing.Size(111, 17)
        lblDurasiJudul.TabIndex = 7
        lblDurasiJudul.Text = "Durasi presentasi"
        '
        'lblMenit
        '
        lblMenit.AutoSize = True
        lblMenit.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        lblMenit.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80)
        lblMenit.Location = New System.Drawing.Point(26, 396)
        lblMenit.Name = "lblMenit"
        lblMenit.Size = New System.Drawing.Size(38, 15)
        lblMenit.TabIndex = 8
        lblMenit.Text = "Menit"
        '
        'nudMenit
        '
        nudMenit.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        nudMenit.Location = New System.Drawing.Point(68, 393)
        nudMenit.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        nudMenit.Name = "nudMenit"
        nudMenit.Size = New System.Drawing.Size(55, 23)
        nudMenit.TabIndex = 9
        nudMenit.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblDetik
        '
        lblDetik.AutoSize = True
        lblDetik.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        lblDetik.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80)
        lblDetik.Location = New System.Drawing.Point(142, 396)
        lblDetik.Name = "lblDetik"
        lblDetik.Size = New System.Drawing.Size(34, 15)
        lblDetik.TabIndex = 10
        lblDetik.Text = "Detik"
        '
        'nudDetik
        '
        nudDetik.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        nudDetik.Location = New System.Drawing.Point(180, 393)
        nudDetik.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        nudDetik.Name = "nudDetik"
        nudDetik.Size = New System.Drawing.Size(55, 23)
        nudDetik.TabIndex = 11
        '
        'chkBunyi
        '
        chkBunyi.AutoSize = True
        chkBunyi.Checked = True
        chkBunyi.CheckState = System.Windows.Forms.CheckState.Checked
        chkBunyi.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        chkBunyi.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80)
        chkBunyi.Location = New System.Drawing.Point(265, 395)
        chkBunyi.Name = "chkBunyi"
        chkBunyi.Size = New System.Drawing.Size(117, 19)
        chkBunyi.TabIndex = 12
        chkBunyi.Text = "Bunyi saat selesai"
        chkBunyi.UseVisualStyleBackColor = True
        '
        'lblShortcutInfo1
        '
        lblShortcutInfo1.AutoSize = True
        lblShortcutInfo1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
        lblShortcutInfo1.ForeColor = System.Drawing.Color.FromArgb(120, 130, 140)
        lblShortcutInfo1.Location = New System.Drawing.Point(26, 442)
        lblShortcutInfo1.Name = "lblShortcutInfo1"
        lblShortcutInfo1.Size = New System.Drawing.Size(126, 13)
        lblShortcutInfo1.TabIndex = 13
        lblShortcutInfo1.Text = "Ctrl+Alt+F9: mulai/jeda"
        '
        'lblShortcutInfo2
        '
        lblShortcutInfo2.AutoSize = True
        lblShortcutInfo2.Font = New System.Drawing.Font("Segoe UI", 8.25F)
        lblShortcutInfo2.ForeColor = System.Drawing.Color.FromArgb(120, 130, 140)
        lblShortcutInfo2.Location = New System.Drawing.Point(26, 460)
        lblShortcutInfo2.Name = "lblShortcutInfo2"
        lblShortcutInfo2.Size = New System.Drawing.Size(262, 13)
        lblShortcutInfo2.TabIndex = 14
        lblShortcutInfo2.Text = "Ctrl+Alt+F10: ulangi. Tombol tetap dapat digunakan."
        '
        'lblStatusBawah
        '
        lblStatusBawah.AutoSize = True
        lblStatusBawah.Font = New System.Drawing.Font("Segoe UI", 8.25F)
        lblStatusBawah.ForeColor = System.Drawing.Color.FromArgb(90, 100, 110)
        lblStatusBawah.Location = New System.Drawing.Point(26, 498)
        lblStatusBawah.Name = "lblStatusBawah"
        lblStatusBawah.Size = New System.Drawing.Size(306, 13)
        lblStatusBawah.TabIndex = 15
        lblStatusBawah.Text = "Timer siap. Aktifkan Tetap di atas agar terlihat saat berganti aplikasi."
        '
        'timerHitungMundur
        '
        timerHitungMundur.Interval = 1000
        '
        'FrmAsistenPresentasi
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.FromArgb(215, 235, 218)
        ClientSize = New System.Drawing.Size(478, 545)
        Controls.Add(lblStatusBawah)
        Controls.Add(lblShortcutInfo2)
        Controls.Add(lblShortcutInfo1)
        Controls.Add(chkBunyi)
        Controls.Add(nudDetik)
        Controls.Add(lblDetik)
        Controls.Add(nudMenit)
        Controls.Add(lblMenit)
        Controls.Add(lblDurasiJudul)
        Controls.Add(btnModeRingkas)
        Controls.Add(chkTopMost)
        Controls.Add(btnUlangi)
        Controls.Add(btnMulaiJeda)
        Controls.Add(pnlTimer)
        Controls.Add(lblSubJudul)
        Controls.Add(lblJudul)
        Font = New System.Drawing.Font("Segoe UI", 9.0F)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        KeyPreview = True
        MaximizeBox = False
        Name = "FrmAsistenPresentasi"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Asisten Presentasi | Pertemuan 11"
        pnlTimer.ResumeLayout(False)
        CType(nudMenit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(nudDetik, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSubJudul As Label
    Friend WithEvents pnlTimer As Panel
    Friend WithEvents lblStatusTimer As Label
    Friend WithEvents lblDisplayTimer As Label
    Friend WithEvents lblHintTimer As Label
    Friend WithEvents btnMulaiJeda As Button
    Friend WithEvents btnUlangi As Button
    Friend WithEvents chkTopMost As CheckBox
    Friend WithEvents btnModeRingkas As Button
    Friend WithEvents lblDurasiJudul As Label
    Friend WithEvents lblMenit As Label
    Friend WithEvents nudMenit As NumericUpDown
    Friend WithEvents lblDetik As Label
    Friend WithEvents nudDetik As NumericUpDown
    Friend WithEvents chkBunyi As CheckBox
    Friend WithEvents lblShortcutInfo1 As Label
    Friend WithEvents lblShortcutInfo2 As Label
    Friend WithEvents lblStatusBawah As Label
    Friend WithEvents timerHitungMundur As Timer
End Class

