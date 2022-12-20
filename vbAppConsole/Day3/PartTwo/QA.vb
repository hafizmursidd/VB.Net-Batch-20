Namespace PartTwo
    Public Class QA
        Inherits Employee

        Private _makan As Double

        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional makan As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _makan = makan
            MyBase.TotalSalary += makan
        End Sub

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + _makan
            End Set
        End Property
        Public Property Makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
                TotalSalary = value + BasicSalary
            End Set
        End Property


        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, 
TunjanganMakan : {Makan}, 
TotalSalary: {MyBase.TotalSalary}"
        End Function
    End Class
End Namespace


