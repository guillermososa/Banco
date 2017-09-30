Public MustInherit Class Cuenta
    'Campos
    Private _Numero As Integer
    Protected _Balance As Double
    Private _Cliente As Cliente

    'Constructor
    Sub New()
        Me.New(0, New Cliente)
    End Sub

    'Constructor Sobrecargado
    Sub New(Numero As Integer, Cliente As Cliente)
        Me.Numero = Numero
        Me.Cliente = Cliente
        _Balance = 0
    End Sub

    'Propiedades
    Public Property Numero As Integer
        Get
            Return _Numero
        End Get
        Set(value As Integer)
            _Numero = value
        End Set
    End Property

    Public ReadOnly Property Balance As Double
        Get
            Return _Balance
        End Get
    End Property

    Public Property Cliente As Cliente
        Get
            Return _Cliente
        End Get
        Set(value As Cliente)
            value.addCuenta(Me)
            _Cliente = value
        End Set
    End Property

    'Metodos
    Public Sub Depositar(value As Double)
        _Balance = Balance + value
    End Sub

    Public Overridable Function Extraer(value As Double) As Boolean
        If Balance >= value Then
            _Balance = Balance - value
            Return True
        Else
            Return False
        End If
    End Function
End Class