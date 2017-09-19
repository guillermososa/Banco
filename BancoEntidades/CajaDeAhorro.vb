Public Class CajaDeAhorro
    Inherits Cuenta
    Private _InteresMensual As Single

    Sub New(Numero As Integer, Balance As Double, InteresMensual As Single, Cliente As Cliente)
        MyBase.New(Numero, Balance, Cliente)
        Me.InteresMensual = 0
    End Sub

    'Sub New()
    '    MyBase.New()
    '    _InteresMensual = 0
    'End Sub

    Public Property InteresMensual As Single
        Get
            Return _InteresMensual
        End Get
        Set(value As Single)
            _InteresMensual = value
        End Set
    End Property

    Public Sub Capitalizar()

    End Sub
End Class