Option Strict On

Friend Module Program

    ''' <summary>Titik masuk aplikasi, menjalankan FrmPeminjaman sebagai form utama.</summary>
    <STAThread()>
    Friend Sub Main(args As String())
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FrmPeminjaman())
    End Sub

End Module
