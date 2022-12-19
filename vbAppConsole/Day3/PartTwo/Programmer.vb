Namespace PartTwo
    Public Class Programmer
        Inherits Employee

        Private _transportasi As Double

        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _transportasi = transportasi
            MyBase.TotalSalary += transportasi

        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, TunjanganPRG : {_transportasi}, TotalSalary: {MyBase.TotalSalary}"
        End Function

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + _transportasi
            End Set
        End Property


        Public Property Transportasi As Double
            Get
                Return Transportasi
            End Get
            Set(value As Double)
                _transportasi = value
                TotalSalary = value + BasicSalary
            End Set
        End Property




    End Class
End Namespace


