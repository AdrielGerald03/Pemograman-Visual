<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerulangan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnInput = New Button()
        lblNilaiAwal = New Label()
        lblNilaiAkhir = New Label()
        txtNilaiAwal = New TextBox()
        txtNilaiAkhir = New TextBox()
        lstHasil = New ListBox()
        SuspendLayout()
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(118, 226)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(112, 34)
        btnInput.TabIndex = 0
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' lblNilaiAwal
        ' 
        lblNilaiAwal.AutoSize = True
        lblNilaiAwal.Location = New Point(118, 35)
        lblNilaiAwal.Name = "lblNilaiAwal"
        lblNilaiAwal.Size = New Size(98, 25)
        lblNilaiAwal.TabIndex = 1
        lblNilaiAwal.Text = "Nilai Awal :"
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(118, 124)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(101, 25)
        lblNilaiAkhir.TabIndex = 2
        lblNilaiAkhir.Text = "Nilai Akhir :"
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(118, 72)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(150, 31)
        txtNilaiAwal.TabIndex = 3
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(118, 169)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(150, 31)
        txtNilaiAkhir.TabIndex = 4
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(99, 287)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(180, 129)
        lstHasil.TabIndex = 5
        ' 
        ' FrmPerulangan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(385, 450)
        Controls.Add(lstHasil)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(txtNilaiAwal)
        Controls.Add(lblNilaiAkhir)
        Controls.Add(lblNilaiAwal)
        Controls.Add(btnInput)
        Name = "FrmPerulangan"
        Text = "Form Perulangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents lblNilaiAwal As Label
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents lstHasil As ListBox
End Class
