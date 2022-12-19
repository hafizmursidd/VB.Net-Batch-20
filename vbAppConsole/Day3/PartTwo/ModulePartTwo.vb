Namespace PartTwo
    Module ModulePartTwo
        Sub InitEmployee()
            'create object employee
            Dim emp1 As New Employee(1, "hafiz", "ababa", DateTime.Now, 5_000)
            'Console.WriteLine(emp1.ToString)

            Dim emp2 As New Employee("Budi", "Ani", DateTime.Now, 5_000)

            emp1.LastName = "Mursyid"
            emp1.BasicSalary = 6_000
            Console.WriteLine(emp1.ToString)

            Console.WriteLine(emp2.ToString)

            'create object programmer
            Dim emp3 As New Programmer("Mas", "Nopal", DateTime.Now, 5_000, 500)

            emp3.BasicSalary = 6_0000
            emp3.Transportasi = 7_00

            Console.WriteLine(emp3.ToString)


        End Sub

    End Module

End Namespace


