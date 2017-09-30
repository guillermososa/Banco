Public Class Cliente
    'Campos
    Private _Nombre As String
    Private _Documento As Integer
    Private _FechaNacimiento As Date
    Private _Cuentas As List(Of Cuenta)

    'Constructor
    Sub New()
        Me.New("", 0, Nothing)
    End Sub

    'Constructor Sobrecargado
    Sub New(Nombre As String, Documento As Integer, FechaNacimiento As Date)
        Me.Nombre = Nombre
        Me.Documento = Documento
        Me.FechaNacimiento = FechaNacimiento
        _Cuentas = New List(Of Cuenta)
    End Sub

    'Propiedades
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 30 Then _Nombre = value
        End Set
    End Property

    Public Property Documento As Integer
        Get
            Return _Documento
        End Get
        Set(value As Integer)
            _Documento = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
        End Set
    End Property

    'Metodos
    Public Sub addCuenta(Cuenta As Cuenta)
        _Cuentas.Add(Cuenta)
    End Sub

    Public Sub removeCuenta(Cuenta As Cuenta)
        _Cuentas.Remove(Cuenta)
    End Sub

    Public Function getAllCuentas() As List(Of Cuenta)
        Return _Cuentas
    End Function

    'Sobrescribir ToString
    Public Overrides Function ToString() As String
        Return Nombre & "(" & Documento & ")"
    End Function
End Class