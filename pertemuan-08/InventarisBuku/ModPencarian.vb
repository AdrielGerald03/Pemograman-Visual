Option Strict On

''' <summary>
''' Module bantuan untuk operasi pencarian dan pemfilteran pada BindingSource/DataTable.
''' </summary>
Public Module ModPencarian

    ''' <summary>
    ''' Mengamankan karakter khusus agar tidak merusak ekspresi BindingSource.Filter.
    ''' Kutip tunggal digandakan; karakter [, ], *, dan % dibungkus dengan kurung siku.
    ''' </summary>
    ''' <param name="teks">Teks input mentah dari pengguna</param>
    ''' <returns>Teks yang sudah diamankan untuk ekspresi Filter</returns>
    Public Function AmankanTeksFilter(teks As String) As String
        Dim hasil As String = ""
        For Each karakter As Char In teks
            Select Case karakter
                Case "'"c
                    hasil &= "''"
                Case "["c, "]"c, "*"c, "%"c
                    hasil &= "[" & karakter & "]"
                Case Else
                    hasil &= karakter
            End Select
        Next
        Return hasil
    End Function

End Module
