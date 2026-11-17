<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmJurusan
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lstJurusan = New System.Windows.Forms.ListBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        Me.lblJudul.Location = New System.Drawing.Point(16, 16)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(380, 26)
        Me.lblJudul.Text = "Daftar jurusan (data latihan)"
        Me.lstJurusan.Location = New System.Drawing.Point(16, 54)
        Me.lstJurusan.Name = "lstJurusan"
        Me.lstJurusan.Size = New System.Drawing.Size(380, 124)
        Me.lstJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika"})
        Me.lstJurusan.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.lstJurusan.AccessibleName = "Daftar jurusan"
        Me.lstJurusan.TabIndex = 0
        Me.lblKeterangan.Location = New System.Drawing.Point(16, 198)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(380, 52)
        Me.lblKeterangan.Text = "Pilih jurusan pada daftar."
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 270)
        Me.MinimumSize = New System.Drawing.Size(436, 309)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.lstJurusan)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Name = "FrmJurusan"
        Me.Text = "Data Jurusan"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lstJurusan As System.Windows.Forms.ListBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
End Class
