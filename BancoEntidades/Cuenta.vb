Public MustInherit Class Cuenta
    Private _numero As Integer
    Protected _balance As Double
    Private _Cliente As Cliente

    Sub New()
        Me.New(0, 0, New Cliente)
    End Sub

    Sub New(Numero As Integer, Balance As Double, Cliente As Cliente)
        MyBase.New()
        Me.Numero = Numero
        _balance = Balance
        Me.Cliente = Cliente
    End Sub

    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(valor As Integer)
            _numero = valor
        End Set
    End Property

    Public ReadOnly Property Balance As Double
        Get
            Return _balance
        End Get
    End Property

    Public Property Cliente As Cliente
        Get
            Return _Cliente
        End Get
        Set(value As Cliente)
            _Cliente = value
        End Set
    End Property

    Public Sub Depositar(valor As Double)
        _balance += valor
    End Sub

    Public Overridable Function Extraer(valor As Double) As Boolean
        If _balance >= valor Then
            _balance -= valor
            Return True
        Else
            Return False
        End If
    End Function
End Class