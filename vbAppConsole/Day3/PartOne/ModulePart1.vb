Namespace PartOne
    Module ModulePart1
        Sub InitEmployee()
            'create object employee

            Dim emp1 As New Employee With {
                .empId = 1,
                .firstName = "Hafiz",
                .lastName = "Mursid",
                .joinDate = #12/12/2002 08:00:00 AM#,
                .basicSalary = 5_0000_0000
            }

            Console.WriteLine(emp1.ToString)

        End Sub

    End Module

End Namespace


