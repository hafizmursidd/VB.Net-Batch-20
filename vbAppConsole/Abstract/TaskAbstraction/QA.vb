Namespace Abstract
    Public Class QA
        Inherits Employee

        Private _makan As Double

        Public Sub New(fullName As String, hireDate As Date, salary As Double, totalSalary As Double, Optional Makan As Double = Nothing)
            MyBase.New(fullName, hireDate, totalSalary)
            _makan = Makan
            MyBase.TotalSalary += Makan
        End Sub

        Public Property Makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
                MyBase.TotalSalary = Salary + value
            End Set
        End Property

        Public Overrides Property Salary As Double
            Get
                Return MyBase.Salary
            End Get
            Set(value As Double)
                _makan = value
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
Tunjangan  Makan: {_makan},
Gross Salary    : {Gross()},
Nett Salary     : {Net()}"
        End Function
    End Class

End Namespace

