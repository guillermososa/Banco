﻿Public NotInheritable Class CajaDeAhorro
    'Herencia
    Inherits Cuenta

    'Campos
    Private Shared _InteresMensual As Single

    'Constructor Shared se ejecuta solo en el primer objeto
    Shared Sub New()
        InteresMensual = 2
    End Sub

    'Constructor Sobrecargado
    Sub New(Numero As Integer, Cliente As Cliente)
        'Sub New(Numero As Integer, InteresMensual As Single, Cliente As Cliente)
        'Me.InteresMensual = InteresMensual
        MyBase.New(Numero, Cliente)
    End Sub

    'Propiedades
    Public Shared Property InteresMensual As Single
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