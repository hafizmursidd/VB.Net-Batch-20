Namespace PartTwo

    Public Class HR
        Implements IHR

        Public Sub DisplayEmployee(ListEmp As List(Of Employee)) Implements IHR.DisplayEmployee

            For Each emp In ListEmp
                Console.WriteLine(emp)
            Next

        End Sub

        Public Function InitEmployee() As List(Of Employee) Implements IHR.InitEmployee

            Dim listEmp As New List(Of Employee) From {
            New Programmer("Mas", "Nopal", DateTime.Now, 5_000, 500),
            New Programmer("Hadi", "Ningtyas", DateTime.Now, 7_000, 555),
            New Sales("Budi", "Nopal", DateTime.Now, 8_000, 500),
            New Sales("Ani", "Ningtyas", DateTime.Now, 6_000, 2_00, 3_00),
            New QA("Adi", "Nopal", DateTime.Now, 9_000, 700),
            New QA("Adnan", "Ningtyas", DateTime.Now, 9_000, 700)
            }
            Return listEmp

        End Function

        Public Function FindEmployeeById(ListEmp As List(Of Employee), id As Integer) As Employee Implements IHR.FindEmployeeById

            ' Dim emp As Employee = Nothing

            For Each em In ListEmp
                If (em.EmpId.Equals(id)) Then
                    Return em
                End If
            Next

            Return Nothing

        End Function

        Public Function TotalSalaryAll(ListEmp As List(Of Employee)) As Double Implements IHR.TotalSalaryAll

            Dim sumSalary As Double
            For Each em In ListEmp
                sumSalary += em.TotalSalary

            Next

            Return sumSalary
        End Function

        Public Function TotalEmployeeByRole(ListEmp As List(Of Employee), role As String) As Integer Implements IHR.TotalEmployeeByRole
            Dim totalEmp As Integer

            For Each em In ListEmp
                If TypeName(em) = role Then
                    totalEmp += 1
                End If
            Next
            Return totalEmp
        End Function

        Public Function TotalEmployeeSalaryByRole(ListEmp As List(Of Employee), role As String) As Double Implements IHR.TotalEmployeeSalaryByRole
            Dim totalSalary As Double
            For Each em In ListEmp
                If TypeName(em) = role Then
                    totalSalary = totalSalary + em.TotalSalary
                End If
            Next
            Return totalSalary
        End Function
    End Class

End Namespace

