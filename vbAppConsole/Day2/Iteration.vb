Module Iteration

    Sub Dowhile(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine(i)
            i += 1

        Loop
    End Sub

    Sub DowhileExit(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine(i)
            If (i = 8) Then
                Exit Do
            Else
                i += 1
            End If
        Loop
    End Sub

    Sub ForLoop()

        For index = 1 To 10
            Console.Write("* ")
        Next
    End Sub

    Sub KotakBintang(x As Integer)
        For i = 1 To x
            For j = 1 To x - i
                Console.Write("*")          'cetak horizontal
            Next
            Console.WriteLine()             'pindah baris
        Next
    End Sub

End Module
