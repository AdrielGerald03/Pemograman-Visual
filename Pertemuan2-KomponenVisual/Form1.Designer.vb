<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNama = New Label()
        txtNama = New TextBox()
        lblNIM = New Label()
        txtNim = New TextBox()
        Label1 = New Label()
        txtKom = New TextBox()
        btnTampilkan = New Button()
        txtHapus = New Button()
        txtKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(167, 98)
        lblNama.Margin = New Padding(4, 0, 4, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(231, 93)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(141, 31)
        txtNama.TabIndex = 1
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(171, 147)
        lblNIM.Margin = New Padding(4, 0, 4, 0)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(46, 25)
        lblNIM.TabIndex = 2
        lblNIM.Text = "NIM"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(230, 142)
        txtNim.Margin = New Padding(4, 5, 4, 5)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(141, 31)
        txtNim.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(170, 195)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 25)
        Label1.TabIndex = 4
        Label1.Text = "KOM"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(231, 190)
        txtKom.Margin = New Padding(4, 5, 4, 5)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(141, 31)
        txtKom.TabIndex = 5
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(199, 267)
        btnTampilkan.Margin = New Padding(4, 5, 4, 5)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(107, 38)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(327, 267)
        txtHapus.Margin = New Padding(4, 5, 4, 5)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(107, 38)
        txtHapus.TabIndex = 7
        txtHapus.Text = "Hapus"
        txtHapus.UseVisualStyleBackColor = True
        ' 
        ' txtKeluar
        ' 
        txtKeluar.Location = New Point(267, 315)
        txtKeluar.Margin = New Padding(4, 5, 4, 5)
        txtKeluar.Name = "txtKeluar"
        txtKeluar.Size = New Size(107, 38)
        txtKeluar.TabIndex = 8
        txtKeluar.Text = "Keluar"
        txtKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(647, 415)
        Controls.Add(txtKeluar)
        Controls.Add(txtHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(txtKom)
        Controls.Add(Label1)
        Controls.Add(txtNim)
        Controls.Add(lblNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Profille Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents txtHapus As Button
    Friend WithEvents txtKeluar As Button

End Class
