Public NotInheritable Class CajaDeAhorro
    'Herencia
    Inherits Cuenta

    'Campos
    Private _InteresMensual As Single

    'Constructor Sobrecargado
    Sub New(Numero As Integer, InteresMensual As Single, Cliente As Cliente)
        MyBase.New(Numero, Cliente)
        Me.InteresMensual = InteresMensual
    End Sub

    'Propiedades
    Public Property InteresMensual As Single
        Get
            Return _InteresMensual
        End Get
        Set(value As Single)
            _InteresMensual = value
        End Set
    End Property

    'Metodos
    Public Sub Capitalizar()
        _Balance = Balance + Balance * InteresMensual / 100
    End Sub
End Class