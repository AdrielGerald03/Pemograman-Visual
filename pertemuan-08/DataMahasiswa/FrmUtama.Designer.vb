<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtama
    Inherits System.Windows.Forms.Form

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
        lblJudul = New System.Windows.Forms.Label()
        btnDariArray = New System.Windows.Forms.Button()
        btnDariList = New System.Windows.Forms.Button()
        btnDataTable = New System.Windows.Forms.Button()
        btnCariList = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        lblJudul.Location = New System.Drawing.Point(30, 25)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(189, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Contoh Pertemuan 8"
        '
        'btnDariArray
        '
        btnDariArray.Location = New System.Drawing.Point(30, 70)
        btnDariArray.Name = "btnDariArray"
        btnDariArray.Size = New System.Drawing.Size(370, 40)
        btnDariArray.TabIndex = 1
        btnDariArray.Text = "1. DataGridView dari Array"
        btnDariArray.UseVisualStyleBackColor = True
        '
        'btnDariList
        '
        btnDariList.Location = New System.Drawing.Point(30, 120)
        btnDariList.Name = "btnDariList"
        btnDariList.Size = New System.Drawing.Size(370, 40)
        btnDariList.TabIndex = 2
        btnDariList.Text = "2. Binding List(Of Mahasiswa)"
        btnDariList.UseVisualStyleBackColor = True
        '
        'btnDataTable
        '
        btnDataTable.Location = New System.Drawing.Point(30, 170)
        btnDataTable.Name = "btnDataTable"
        btnDataTable.Size = New System.Drawing.Size(370, 40)
        btnDataTable.TabIndex = 3
        btnDataTable.Text = "3. DataTable, Rapikan Kolom dan Filter"
        btnDataTable.UseVisualStyleBackColor = True
        '
        'btnCariList
        '
        btnCariList.Location = New System.Drawing.Point(30, 220)
        btnCariList.Name = "btnCariList"
        btnCariList.Size = New System.Drawing.Size(370, 40)
        btnCariList.TabIndex = 4
        btnCariList.Text = "4. Pencarian dengan Perulangan"
        btnCariList.UseVisualStyleBackColor = True
        '
        'FrmUtama
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(434, 281)
        Controls.Add(btnCariList)
        Controls.Add(btnDataTable)
        Controls.Add(btnDariList)
        Controls.Add(btnDariArray)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUtama"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Pertemuan 8 - DataGridView, Array & Koleksi Data"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents btnDariArray As System.Windows.Forms.Button
    Friend WithEvents btnDariList As System.Windows.Forms.Button
    Friend WithEvents btnDataTable As System.Windows.Forms.Button
    Friend WithEvents btnCariList As System.Windows.Forms.Button
End Class
