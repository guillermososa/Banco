Public Class Banco
    'Campos
    Private _Clientes As List(Of Cliente)

    'Constructor
    Sub New()
        _Clientes = New List(Of Cliente)
    End Sub

    'Metodos
    Public Sub addCliente(Cliente As Cliente)
        _Clientes.Add(Cliente)
    End Sub

    Public Sub removeCliente(Cliente As Cliente)
        _Clientes.Remove(Cliente)
    End Sub

    Public Function getAllClientes() As List(Of Cliente)
        Return _Clientes
    End Function
End Class