Module Quizday1and2

    'Nomor 1
    Sub TahunHari(input As Integer)
        Dim TotalJam As Integer = input \ 60
        Dim TotalHari = TotalJam \ 24
        Dim TotalTahun = TotalHari \ 365
        Dim SisaHari = TotalHari Mod 365

        Console.WriteLine("Inputan User : " & input)
        Console.WriteLine("output  : " & TotalTahun & " Tahun, " & SisaHari & " hari")

    End Sub

    'Nomor 2
    Sub ShioCalender()
        Dim year, temp As Integer

        Console.WriteLine("Enter tahun lahir : ")
        year = Console.ReadLine()

        temp = year Mod 12
        Console.Write("Anda lahir di tahun : ")

        Select Case temp
            Case = 0
                Console.WriteLine("Monyet")
            Case = 1
                Console.WriteLine("Ayam")
            Case = 2
                Console.WriteLine("Anjing")
            Case = 3
                Console.WriteLine("Babi")
            Case = 4
                Console.WriteLine("Tikus")
            Case = 5
                Console.WriteLine("Kerbau")
            Case = 6
                Console.WriteLine("Harimau")
            Case = 7
                Console.WriteLine("Kelinci")
            Case = 8
                Console.WriteLine("Naga")
            Case = 9
                Console.WriteLine("Ular")
            Case = 10
                Console.WriteLine("Kuda")
            Case = 11
                Console.WriteLine("Kambing")
        End Select
    End Sub

    'Nomor 3
    Sub SimulasiATM()
        Dim Pass As Integer = 12345
        Dim salah As Integer = 3
        Dim JumlahUang As Integer
        Dim PassInput As Integer
        Dim hasil10 As Integer = 0
        Dim hasil5 As Integer = 0
        Dim temp10 As Integer = 0

        Do While salah > 0
            Console.WriteLine("Masukkan Password : ")
            PassInput = Console.ReadLine()

            If Pass = PassInput Then
                Console.Write("Masukkan jumlah uang : ")
                JumlahUang = Console.ReadLine()

                hasil10 = JumlahUang \ 10
                temp10 = JumlahUang Mod 10

                hasil5 = temp10 \ 5
                temp10 = JumlahUang Mod 5

                Console.Write(“$10 = " & hasil10 & " lembar, $5= " & hasil5 & " lembar, $1= " & temp10 & " lembar” & vbCrLf)

                Exit Do
            Else
                Console.WriteLine("Kesempatan anda " & salah - 1 & " kali lagi mencoba ")
            End If

            salah = salah - 1
        Loop

        If salah = 0 Then
            Console.WriteLine("Pin Anda dilock, Silahkan hubungi CS")
        Else
            Console.WriteLine("Transaksi Selesai")
        End If

    End Sub

    'Nomor 4
    Sub BatuGuntingKertas()
        Dim input As Integer
        Dim rand As New Random()

        Console.WriteLine("1 (Gunting) : ")
        Console.WriteLine("2 (Batu) : ")
        Console.WriteLine("3 (Kertas) : ")

        Console.WriteLine("Input Your Number : ")
        input = Console.ReadLine()

        If (input < 1) Or (input > 3) Then
            Console.WriteLine("Out OF Range")

        Else
            Dim com As Integer = rand.NextInt64(1, 4)
            Console.WriteLine("Your Input : " & input & vbCrLf & "Computer : " & com)

            If (input = com) Then
                Console.WriteLine("Draw")
            ElseIf (input > com) Then
                Console.WriteLine("You Won")
            Else
                Console.WriteLine("You Lose")
            End If
        End If
    End Sub

    'Nomor 5
    Sub TebakHadiah()

        Dim inputUser As Integer
        Dim rand As New Random()
        Dim PuluhanUser As Integer
        Dim SatuanUser As Integer
        Dim PuluhanCom As Integer
        Dim SatuanCom As Integer

        Console.WriteLine("Input Your Number : ")
        inputUser = Console.ReadLine()

        Dim InputCom As Integer = rand.NextInt64(10, 100)

        PuluhanUser = inputUser \ 10
        SatuanUser = inputUser Mod 10
        PuluhanCom = InputCom \ 10
        SatuanCom = InputCom Mod 10
        Console.WriteLine("Your Number : " & inputUser)
        Console.WriteLine("Com Number : " & InputCom)

        If ((PuluhanUser = PuluhanCom) And (SatuanUser = SatuanCom)) Then
            Console.WriteLine("Exact two number Match : you win Rp.100.000 ")

        ElseIf ((PuluhanUser = PuluhanCom) Or (SatuanUser = SatuanCom)) Then

            Console.WriteLine("Exact one number Match : you win Rp.50.000")
        Else
            Console.WriteLine("No number Match : You Lose ")
        End If
    End Sub

    'Nomor 6

    Sub DeretAngka(n As Integer)
        Dim x As Integer
        Dim y As Integer = -1

        Console.Write(y & ", ")
        For x = 1 To 12
            y -= 1
            Console.Write(x & ", " & y & ", ")
        Next
    End Sub

    ''Nomor 7
    Sub AngkaUrut(n As Integer)
        Dim x As Integer
        Dim y As Integer

        For i = 1 To 6
            If i Mod 2 <> 0 Then
                For j = n To 1 Step -1
                    Console.Write(j)
                Next
            Else
                For k = 1 To n
                    Console.Write(k)
                Next
            End If
            Console.WriteLine()

        Next
    End Sub

    ''nomor 8
    Sub Segitiga(n As Integer)

        For i = 1 To n
            For j = 1 To n + 1 - i
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        For i = 1 To n
            For j = n - i To 1 Step -1
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    ''nomor 9
    Sub BilanganPrima()

        Dim tempBaris = 0

        For i = 2 To 100
            Dim temp As Integer = 0
            For j = 1 To i
                If (i Mod j = 0) Then
                    temp = temp + 1

                End If
            Next

            If (temp = 2) Then
                Console.Write(i & " ")
                tempBaris += 1
            End If

            If (tempBaris = 5) Then
                Console.WriteLine()
                tempBaris = 0
            End If


        Next
    End Sub

    'Nomor 10
    Sub IsCharUnique(x As String)

        Dim isChar As Boolean = True
        For i = 0 To Len(x) - 1

            For j = i + 1 To Len(x) - 1
                If (x(i) = x(j)) Then
                    isChar = False
                    Exit For
                End If
            Next
        Next
        Console.WriteLine("Is Unique: " & isChar)
    End Sub

    'Nomor 11
    Sub IsPalindrom(kata As String)
        Dim isPalindrom = True
        Dim length = Len(kata) - 1
        Dim tempKata As String = kata.ToLower

        For i = 0 To (length / 2)
            Dim indexAwal = i
            Dim indexAkhir = length - i
            If tempKata(indexAwal) <> tempKata(indexAkhir) Then
                isPalindrom = False
                Exit For
            End If

        Next
        Console.WriteLine("Is Palindrom: " & isPalindrom)

        ''katak

    End Sub

    'Nomor 12
    Sub MaxWordLength()
        Dim input As String = "Aku ada adsa sasaasuka fsafdsafsadsekali"
        Dim temp() = Split(input)
        Dim tempLength = 0
        Dim tempIndex = 0

        For i = 0 To (temp.Count - 1)
            If Len(temp(i)) > tempLength Then
                tempLength = Len(temp(i))
                tempIndex = i
            End If
        Next
        Console.WriteLine(temp(tempIndex))
    End Sub


    'nomor 13
    Sub HowManyKabisat()
        Dim tahun1 As Integer = 1997
        Dim tahun2 As Integer = 2021
        Dim HitungTahun As Integer
        Dim hasil As String

        For i = tahun1 To tahun2
            If (i Mod 400 = 0) Or (i Mod 4 = 0) And (i Mod 100 <> 0) Then
                hasil = hasil + " " + i.ToString()
                HitungTahun += 1
            End If
        Next
        Console.WriteLine($"Banyak tahun kabisat : {HitungTahun} tahun ={hasil}")
    End Sub

End Module



