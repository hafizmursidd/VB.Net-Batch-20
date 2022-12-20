Namespace PartTwo

    Public Interface IHR
        Function InitEmployee() As List(Of Employee)

        Function FindEmployeeById(ListEmp As List(Of Employee), id As Integer) As Employee

        Sub DisplayEmployee(ListEmp As List(Of Employee))

        Function TotalSalaryAll(ListEmp As List(Of Employee)) As Double

        Function TotalEmployeeByRole(ListEmp As List(Of Employee), role As String) As Integer

        Function TotalEmployeeSalaryByRole(ListEmp As List(Of Employee), role As String) As Double

    End Interface

End Namespace
