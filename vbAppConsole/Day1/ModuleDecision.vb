Module ModuleDecision

    Sub OddEvenNUmber()
        Dim a As Integer
        Console.Write("Input A Number : ")
        a = Console.ReadLine()

        If a Mod 2 = 0 Then
            Console.WriteLine("Even Number")

        Else
            Console.WriteLine("Odd Number")

        End If
    End Sub


    'Multiple IF

    Sub Grade()
        Dim Grade As Integer
        Console.Write("Input a Number : ")
        Grade = Console.ReadLine()

        If Grade < 50 Then
            Console.WriteLine("C")
        ElseIf Grade > 50 Then
            Console.WriteLine("A")
        Else
            Console.WriteLine("Failed")
        End If

    End Sub

    Sub GradeCase()
        Dim Grade As Integer
        Console.Write("Input a Number : ")
        Grade = Console.ReadLine()

        Select Case Grade
            Case < 50
                Console.WriteLine("E")
            Case 50 To 60
                Console.WriteLine("D")
            Case 61 To 70
                Console.WriteLine("D")
            Case Else
                Console.WriteLine("Failed")
        End Select
    End Sub

    Sub TheGreatest()
        Dim x As Integer
        Dim rand As New Random()

        Console.WriteLine("Input A Number : ")
        x = Console.Read()

        If (x > 10) Or (x < 0) Then
            Console.WriteLine("Out OF Range")

        Else
            Dim temp As Integer = rand.NextInt64(1, 11)
            Console.WriteLine("Your Input : " & x & vbCrLf & "Computer : " & temp)

            If (x > temp) Then
                Console.WriteLine("You Won")
            Else
                Console.WriteLine("You Lose")
            End If


        End If


    End Sub



End Module
