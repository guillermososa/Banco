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

    Public Shared Function containsCliente(Cliente As Cliente) As Boolean
        Return _Clientes.Contains(Cliente)
    End Function

    Public Shared Function existsClienteByDocumento(Documento As Integer) As Boolean
        Return _Clientes.Exists(Function(c) c.Documento = Documento)
    End Function

    Public Shared Function findClienteByDocumento(Documento As Integer) As Cliente
        Return _Clientes.Find(Function(c) c.Documento = Documento)
    End Function

    Public Shared Function findAllClienteByNombre(Nombre As String) As List(Of Cliente)
        Return _Clientes.FindAll(Function(c) c.Nombre.Contains(Nombre))
    End Function
End Class