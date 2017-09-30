Public NotInheritable Class CuentaCorriente
    'Herencia
    Inherits Cuenta

    'Campos
    Private _MontoSobreGiro As Single

    'Constructor Sobrecargados
    Sub New(Numero As Integer, MontoSobreGiro As Single, Cliente As Cliente)
        MyBase.New(Numero, Cliente)
        Me.MontoSobreGiro = MontoSobreGiro
    End Sub

    'Propiedades
    Public Property MontoSobreGiro As Single
        Get
            Return _MontoSobreGiro
        End Get
        Set(value As Single)
            _MontoSobreGiro = value
        End Set
    End Property

    Public Overrides Function Extraer(value As Double) As Boolean
        If Balance + MontoSobreGiro >= value Then
            _Balance = Balance - value
            Return True
        Else
            Return False
        End If
    End Function

    'Sobrescribir ToString
    Public Overrides Function ToString() As String
        Return Numero & "(" & Cliente.nombre & ")"
    End Function
End Class