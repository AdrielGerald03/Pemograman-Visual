Option Strict On

' Kumpulan fungsi validasi yang dapat dipakai ulang oleh form mana pun
Public Module ModValidasi

    ''' <summary>
    ''' Memeriksa apakah kode buku valid: diawali "BK" (case-insensitive) diikuti tepat 4 digit angka.
    ''' Fungsi ini dipakai di ValidasiInput() dan event Validating txtKodeBuku.
    ''' </summary>
    Public Function KodeBukuValid(kode As String) As Boolean
        Dim kodeUpper As String = kode.ToUpper()
        If kodeUpper.Length <> 6 Then Return False
        If Not kodeUpper.StartsWith("BK") Then Return False
        Return SemuaDigit(kodeUpper.Substring(2), 4)
    End Function

    ''' <summary>
    ''' Memeriksa apakah semua karakter dalam teks adalah digit 0-9 dan panjangnya tepat sesuai parameter.
    ''' </summary>
    Public Function SemuaDigit(teks As String, panjang As Integer) As Boolean
        If teks.Length <> panjang Then Return False
        For Each karakter As Char In teks
            If karakter < "0"c OrElse karakter > "9"c Then Return False
        Next
        Return True
    End Function

End Module
