Module ModuleVariables


    Sub StoreVariable()
        Dim number As Integer = 200
        Dim temp As String = "Hello "

        Console.WriteLine(" Number : " & number & " test " & temp)

    End Sub

    'a=1,b=2,c=3 => a=3, b=1, c=2
    Sub SwapTwoVariable()

        Dim a, b, c As Integer

        Console.Write("value A : ")
        a = Console.ReadLine()

        Console.Write("value B : ")
        b = Console.ReadLine()

        Console.WriteLine("Before Swap the value")
        Console.WriteLine(" A : " & a & " B " & b)

        c = a
        a = b
        b = c
        Console.WriteLine("After Swap the value")
        Console.WriteLine(" A : " & a & " B " & b)

    End Sub

End Module
