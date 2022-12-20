Imports System
'Imports vbAppConsole.PartOne
Imports vbAppConsole.PartTwo



Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        ' SayMyName()

        'panggil method
        'ModuleVariables.StoreVariable()

        'ModuleVariables.SwapTwoVariable()
        ' ModuleMath.OperationMath()
        'ModuleMath.Modulus()
        ' ModuleDecision.OddEvenNUmber()
        ' ModuleDecision.GradeCase()
        'ModuleDecision.TheGreatest()


        'ModuleDateTime.ShowDate()
        'Iteration.Dowhile(10)
        'Iteration.DowhileExit(10)
        'Iteration.ForLoop()
        'Iteration.KotakBintang(9)




        'Quizday1and2.TahunHari(1000000000)
        'Quizday1and2.ShioCalender()
        'Quizday1and2.SimulasiATM()
        'Quizday1and2.BatuGuntingKertas()
        'Quizday1and2.TebakHadiah()
        'Quizday1and2.DeretAngka(13)
        'Quizday1and2.AngkaUrut(9)
        'Quizday1and2.Segitiga(6)
        'Quizday1and2.BilanganPrima()
        'Quizday1and2.IsCharUnique("limb0to")
        'Quizday1and2.IsPalindrom("katak ini katak")
        'Quizday1and2.MaxWordLength()
        'Quizday1and2.HowManyKabisat()

        'ModulePartTwo.InitEmployee()

        'ModuleArray.DisplayArray()

        ''Call interface kiri and implementation kanan
        Dim IHumanResource As IHR = New HR
        Dim listEmp = IHumanResource.InitEmployee()

        IHumanResource.DisplayEmployee(listEmp)

        Dim emp = IHumanResource.FindEmployeeById(listEmp, 1)

        If emp Is Nothing Then
            Console.WriteLine($"Data Not Found")
        Else
            Console.WriteLine($"Data is Found: {emp}")
        End If

        Console.WriteLine("")

        Dim totalEmp = IHumanResource.TotalEmployeeByRole(listEmp, "Programmer")
        Console.WriteLine($"Total Programmer: {totalEmp}")
        totalEmp = IHumanResource.TotalEmployeeByRole(listEmp, "Sales")
        Console.WriteLine($"Total Sales: {totalEmp}")
        totalEmp = IHumanResource.TotalEmployeeByRole(listEmp, "QA")
        Console.WriteLine($"Total QA: {totalEmp}")

        Console.WriteLine("")

        Dim totalSalary = IHumanResource.TotalEmployeeSalaryByRole(listEmp, "Programmer")
        Console.WriteLine($"Total Salary Programmer: {totalSalary }")
        totalSalary = IHumanResource.TotalEmployeeSalaryByRole(listEmp, "Sales")
        Console.WriteLine($"Total Salary Sales: {totalSalary }")
        totalSalary = IHumanResource.TotalEmployeeSalaryByRole(listEmp, "QA")
        Console.WriteLine($"Total Salary QA: {totalSalary}")

        Console.WriteLine("")
        Dim totalSalarayEmp = IHumanResource.TotalSalaryAll(listEmp)
        Console.WriteLine($"Total Seluruh Salary: {totalSalarayEmp}")






    End Sub
    Sub SayMyName()
        'declaration variable
        Dim myName As String
        Console.Write("Enter your name : ")
        myName = Console.ReadLine()

        Console.WriteLine("Hello : " & myName)





    End Sub
End Module
