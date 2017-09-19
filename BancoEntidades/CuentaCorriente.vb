Public NotInheritable Class CuentaCorriente
    Inherits Cuenta
    Private _MontoSobreGiro As Single

    Sub New(Numero As Integer, Balance As Double, MontoSobreGiro As Single, Cliente As Cliente)
        MyBase.New(Numero, Balance, Cliente)
        Me.MontoSobreGiro = 0
    End Sub

    Public Property MontoSobreGiro As Single
        Get
            Return _MontoSobreGiro
        End Get
        Set(value As Single)
            _MontoSobreGiro = value
        End Set
    End Property


    Public Overrides Function Extraer(valor As Double) As Boolean
        If _balance + MontoSobreGiro >= valor Then
            _balance -= valor
            Return True
        Else
            Return False
        End If
    End Function
End Class