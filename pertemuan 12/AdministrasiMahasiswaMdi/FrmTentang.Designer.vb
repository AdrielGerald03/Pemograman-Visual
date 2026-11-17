<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTentang
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
        Me.lblIsi = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Me.lblIsi.Location = New System.Drawing.Point(24, 24)
        Me.lblIsi.Name = "lblIsi"
        Me.lblIsi.Size = New System.Drawing.Size(370, 94)
        Me.lblIsi.Text = "Administrasi Mahasiswa MDI" & vbCrLf & "Contoh Pertemuan 12 - Pemrograman Visual" & vbCrLf & "Data latihan disimpan sementara di memori."
        Me.btnTutup.Location = New System.Drawing.Point(264, 130)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(130, 36)
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnTutup.TabIndex = 0
        Me.CancelButton = Me.btnTutup
        Me.AcceptButton = Me.btnTutup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 190)
        Me.Controls.Add(Me.lblIsi)
        Me.Controls.Add(Me.btnTutup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowInTaskbar = False
        Me.Name = "FrmTentang"
        Me.Text = "Tentang aplikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblIsi As System.Windows.Forms.Label
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class
