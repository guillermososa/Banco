Public Class Banco
    Private Clientes As List(Of Cliente)

    Sub New()
        Clientes = New List(Of Cliente)
    End Sub

    Public Sub addCliente(Cliente As Cliente)
        Clientes.Add(Cliente)
    End Sub

    Public Sub removeCliente(Cliente As Cliente)
        Clientes.Remove(Cliente)
    End Sub

    Public Function getAllClientes() As List(Of Cliente)
        Return Clientes
    End Function
End Class