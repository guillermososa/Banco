Public Class Banco
    'Campos
    Private Shared _Clientes As List(Of Cliente)

    'Constructor
    Shared Sub New()
        _Clientes = New List(Of Cliente)
    End Sub

    'Metodos
    Public Shared Sub addCliente(Cliente As Cliente)
        _Clientes.Add(Cliente)
    End Sub

    Public Shared Sub removeCliente(Cliente As Cliente)
        _Clientes.Remove(Cliente)
    End Sub

    Public Shared Function getAllClientes() As List(Of Cliente)
        Return _Clientes
    End Function
End Class