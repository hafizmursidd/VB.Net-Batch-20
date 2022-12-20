Namespace Abstract
    Public Class Programmer
        Inherits Employee

        Private _transportasi As Double


        Public Sub New(fullName As String, hireDate As Date, salary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(fullName, hireDate, salary)
            Me.Transportasi = transportasi
            MyBase.TotalSalary += transportasi
        End Sub

        Public Overrides Property Salary As Double
            Get
                Return MyBase.Salary
            End Get
            Set(value As Double)
                MyBase.Salary = value
                TotalSalary = value + _transportasi
            End Set
        End Property

        Public Property Transportasi As Double
            Get
                Return _transportasi
            End Get
            Set(value As Double)
                _transportasi = value
                TotalSalary = Salary + value
            End Set
        End Property

        Public Overrides Function Net() As Double
            Static tax = 0.05 * TotalSalary
            Static netSalary = TotalSalary - tax

            Return netSalary
        End Function

        Public Overrides Function Gross() As Double

            Return TotalSalary
        End Function

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, 
Tunjangan Transport : {_transportasi},
Gross Salary    : {Gross()},
Nett Salary     : {Net()}"
        End Function

    End Class

End Namespace


