Namespace Abstract
    Public MustInherit Class Employee
        Private _empId As Integer
        Private _fullName As String
        Private _hireDate As DateTime
        Private _salary As Double
        Private _totalSalary As Double

        'default constructor
        Public Sub New()
        End Sub


        Public Sub New(empId As Integer, fullName As String, hireDate As Date, salary As Double)
            Me.EmpId = empId
            Me.FullName = fullName
            Me.HireDate = hireDate
            Me.Salary = salary
        End Sub

        Public Sub New(fullName As String, hireDate As Date, salary As Double)
            EmpId = New Random().NextInt64(1, 10) 'id
            Me.FullName = fullName
            Me.HireDate = hireDate
            Me.Salary = salary
        End Sub

        Public Property EmpId As Integer
            Get
                Return _empId
            End Get
            Set(value As Integer)
                _empId = value
            End Set
        End Property

        Public Property FullName As String
            Get
                Return _fullName
            End Get
            Set(value As String)
                _fullName = value
            End Set
        End Property

        Public Property HireDate As Date
            Get
                Return _hireDate
            End Get
            Set(value As Date)
                _hireDate = value
            End Set
        End Property

        Public Overridable Property Salary As Double
            Get
                Return _salary
            End Get
            Set(value As Double)
                _salary = value
            End Set
        End Property

        Public Overridable Property TotalSalary As Double
            Get
                Return _totalSalary
            End Get
            Set(value As Double)
                _totalSalary = value
            End Set
        End Property

        Public MustOverride Function Net() As Double
        Public MustOverride Function Gross() As Double


        Public Overrides Function ToString() As String
            Return $"
EmpId : {Me._empId}, 
FullName : {_fullName},
HireDate : {_hireDate}, 
Nett Salary {_salary},
Gross Salary {_totalSalary}"
        End Function
    End Class

End Namespace


