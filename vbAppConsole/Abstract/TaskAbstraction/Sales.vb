Namespace Abstract
    Public Class Sales
        Inherits Employee
        Implements ITunjangan

        Private _bonus As Double
        Private _commission As Double

        Public Sub New(fullName As String, hireDate As Date, salary As Double, Optional bonus As Double = Nothing, Optional commission As Double = Nothing)
            MyBase.New(fullName, hireDate, salary)
            _bonus = bonus
            _commission = commission
            MyBase.TotalSalary = TotalSalary + bonus + commission
        End Sub

        Public Property Bonus As Double
            Get
                Return _bonus
            End Get
            Set(value As Double)
                _bonus = value
                TotalSalary = Salary + Commission + value

            End Set
        End Property

        Public Property Commission As Double
            Get
                Return _commission
            End Get
            Set(value As Double)
                _commission = value
                TotalSalary = Salary + Bonus + value
            End Set
        End Property

        Public Overrides Property Salary As Double
            Get
                Return MyBase.Salary
            End Get
            Set(value As Double)
                MyBase.Salary = value
                TotalSalary = Commission + Bonus + value
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
Tunjangan Bomus : {_bonus},
Tunjangan Comm  : {_commission},
Gross Salary    : {Gross()},
Nett Salary     : {Net()}"
        End Function

        Public Function TunjanganMakan(makan As Double) As Double Implements ITunjangan.TunjanganMakan

            MyBase.TotalSalary = Salary + makan
            Return totalSalary
        End Function

        Public Function TunjanganTransportasi(transportasi As Double) As Double Implements ITunjangan.TunjanganTransportasi
            Throw New NotImplementedException()
        End Function

        Public Function TCommission(commissionn As Double) As Double Implements ITunjangan.TCommission
            Throw New NotImplementedException()
        End Function

        Private Function ITunjangan_Bonus(bonuss As Double) As Double Implements ITunjangan.Bonus
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace
