<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMahasiswa
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
        Me.components = New System.ComponentModel.Container()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.dgvMahasiswa = New System.Windows.Forms.DataGridView()
        Me.lblCatatan = New System.Windows.Forms.Label()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.btnBersihkanCatatan = New System.Windows.Forms.Button()
        Me.cmsCatatan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuPilihSemuaCatatan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBersihkanCatatan = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCatatan.SuspendLayout()
        Me.SuspendLayout()
        Me.lblJudul.Location = New System.Drawing.Point(16, 12)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(590, 28)
        Me.lblJudul.Text = "Daftar mahasiswa (data latihan)"
        Me.dgvMahasiswa.Location = New System.Drawing.Point(16, 46)
        Me.dgvMahasiswa.Name = "dgvMahasiswa"
        Me.dgvMahasiswa.Size = New System.Drawing.Size(590, 168)
        Me.dgvMahasiswa.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.dgvMahasiswa.ReadOnly = True
        Me.dgvMahasiswa.AllowUserToAddRows = False
        Me.dgvMahasiswa.AllowUserToDeleteRows = False
        Me.dgvMahasiswa.RowHeadersVisible = False
        Me.dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMahasiswa.MultiSelect = False
        Me.dgvMahasiswa.AccessibleName = "Daftar mahasiswa"
        Me.dgvMahasiswa.TabIndex = 0
        Me.lblCatatan.Location = New System.Drawing.Point(16, 226)
        Me.lblCatatan.Name = "lblCatatan"
        Me.lblCatatan.Size = New System.Drawing.Size(590, 26)
        Me.lblCatatan.Text = "&Catatan sementara, hilang saat jendela ini ditutup"
        Me.lblCatatan.TabIndex = 1
        Me.txtCatatan.Location = New System.Drawing.Point(16, 256)
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(590, 76)
        Me.txtCatatan.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCatatan.ContextMenuStrip = Me.cmsCatatan
        Me.txtCatatan.AccessibleName = "Catatan sementara"
        Me.txtCatatan.TabIndex = 2
        Me.btnBersihkanCatatan.Location = New System.Drawing.Point(16, 344)
        Me.btnBersihkanCatatan.Name = "btnBersihkanCatatan"
        Me.btnBersihkanCatatan.Size = New System.Drawing.Size(190, 34)
        Me.btnBersihkanCatatan.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
        Me.btnBersihkanCatatan.Text = "&Bersihkan catatan"
        Me.btnBersihkanCatatan.Enabled = False
        Me.btnBersihkanCatatan.TabIndex = 3
        Me.cmsCatatan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPilihSemuaCatatan, Me.mnuBersihkanCatatan})
        Me.cmsCatatan.Name = "cmsCatatan"
        Me.mnuPilihSemuaCatatan.Name = "mnuPilihSemuaCatatan"
        Me.mnuPilihSemuaCatatan.Text = "&Pilih semua"
        Me.mnuPilihSemuaCatatan.Enabled = False
        Me.mnuBersihkanCatatan.Name = "mnuBersihkanCatatan"
        Me.mnuBersihkanCatatan.Text = "&Bersihkan"
        Me.mnuBersihkanCatatan.Enabled = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 396)
        Me.MinimumSize = New System.Drawing.Size(520, 420)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.dgvMahasiswa)
        Me.Controls.Add(Me.lblCatatan)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.btnBersihkanCatatan)
        Me.Name = "FrmMahasiswa"
        Me.Text = "Data Mahasiswa"
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCatatan.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents lblCatatan As System.Windows.Forms.Label
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents btnBersihkanCatatan As System.Windows.Forms.Button
    Friend WithEvents cmsCatatan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPilihSemuaCatatan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBersihkanCatatan As System.Windows.Forms.ToolStripMenuItem
End Class
