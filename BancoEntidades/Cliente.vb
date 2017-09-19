Public Class Cliente
    Private _nombre As String
    Private _documento As Integer
    Private _fechaNacimiento As Date

    'constructor
    Sub New()
        _nombre = ""
        _documento = 0
        _fechaNacimiento = Nothing
    End Sub

    Sub New(nombre As String, documento As Integer, fechaNacimiento As Date)
        Me.nombre = nombre
        Me.documento = documento
        Me.fechaNacimiento = fechaNacimiento
    End Sub

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(valor As String)
            _nombre = valor
        End Set
    End Property

    Public Property documento As Integer
        Get
            Return _documento
        End Get
        Set(valor As Integer)
            _documento = valor
        End Set
    End Property

    Public Property fechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(valor As Date)
            _fechaNacimiento = valor
        End Set
    End Property

    'Private Function CalcularEdad(ByVal Fecha As Date) As UShort
    '    Return
    'End Function
End Class