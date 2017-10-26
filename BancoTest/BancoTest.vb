Imports BancoEntidades
Module BancoTest
    Sub Main()
        'Dim banco As New Banco()
        Console.WriteLine("Agrego 2 clientes")
        Dim documentoNeymar As Integer = 463743
        Dim cliente1 = New Cliente("Neymar", 463743, #01-01-1993#)
        Banco.addCliente(cliente1)
        Banco.addCliente(New Cliente("Icardi", 545454, #08-08-1993#))
        Console.WriteLine("Mostrar")

        Console.WriteLine("Esiste Neymar: " & Banco.containsCliente(cliente1))
        Console.WriteLine("Esiste documento 463743 de Neymar: " & Banco.existsClienteByDocumento(documentoNeymar))
        Console.WriteLine("Buscar Cliente por documento 463743: ")
        Console.WriteLine(Banco.findClienteByDocumento(documentoNeymar))

        Console.WriteLine("Mostrar Nombre de Cliente con la letra 'a': ")
        For Each cliente As Cliente In Banco.findAllClienteByNombre("N")
            Console.WriteLine(cliente.ToString)
        Next

        For Each cliente As Cliente In Banco.getAllClientes
            Console.WriteLine(cliente.ToString)
        Next
        Console.WriteLine("Eliminar")
        Banco.removeCliente(cliente1)
        Console.WriteLine("Mostrar")
        For Each cliente As Cliente In Banco.getAllClientes
            Console.WriteLine(cliente.ToString)
        Next

        Console.ReadKey()
    End Sub
End Module