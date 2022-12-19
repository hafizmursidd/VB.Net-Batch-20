Module ModuleMath


    Sub OperationMath()
        Dim x As Integer = 12 + (15 + 3) - 2 ^ 3 / 4 * 5
        Console.WriteLine(x)

    End Sub


    Sub Modulus()
        Dim num1, num2, bagi, sisa As Integer

        Console.WriteLine("Input First Number : ")
        num1 = Console.ReadLine()
        Console.WriteLine("Input Second Number : ")
        num2 = Console.ReadLine()


        bagi = num1 \ num2
        sisa = num1 Mod num2

        Console.WriteLine("Result bagi :  " & bagi)
        Console.WriteLine("Result Modulus:  " & sisa)
    End Sub
End Module
