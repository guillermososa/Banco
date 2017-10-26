Imports BancoEntidades
Module ClienteTest
    Sub Main()
        ' declaración
        Dim cliente1 As Cliente
        ' instanciacion
        cliente1 = New Cliente()
        ' test de setters
        cliente1.Nombre = "Pepe"
        cliente1.Documento = 676765
        cliente1.FechaNacimiento = #4-20-1989#
        ' test de getters
        Console.WriteLine("Nombre: " & cliente1.Nombre)
        Console.WriteLine("Documento: " & cliente1.Documento)
        Console.WriteLine("Fecha de nacimiento: " & cliente1.FechaNacimiento)
        Console.WriteLine("ToString: " & cliente1.ToString())

        Dim cliente2 As New Cliente("Juan", 7797987, #5-12-1990#)
        Console.WriteLine("Nombre: " & cliente2.Nombre)
        Console.WriteLine("Documento: " & cliente2.Documento)
        Console.WriteLine("Fecha de nacimiento: " & cliente2.FechaNacimiento)
        Console.WriteLine("ToString: " & cliente2.ToString())

        Console.WriteLine("Cliente1 and Cliente2: {0}", cliente1.Equals(cliente2))
        Dim cliente3 As New Cliente(cliente1.Nombre, cliente1.Documento, cliente1.FechaNacimiento)
        Console.WriteLine("Cliente1 and Cliente3: {0}", cliente1.Equals(cliente3))

        '' declaración
        'Dim cliente1 As Cliente
        '' instanciacion
        'cliente1 = New Cliente()
        '' test de setters
        'cliente1.Nombre = "Pepe"
        'cliente1.Documento = 676765
        'cliente1.FechaNacimiento = #4-20-1989#
        '' test de getters
        'Console.WriteLine("Nombre: " & cliente1.Nombre)
        'Console.WriteLine("Documento: " & cliente1.Documento)
        'Console.WriteLine("Fecha de nacimiento: " & cliente1.FechaNacimiento)
        'Console.WriteLine("ToString: " & cliente1.ToString())

        'Dim cliente2 As New Cliente("Juan", 7797987, #5-12-1990#)
        'Console.WriteLine("Nombre: " & cliente2.Nombre)
        'Console.WriteLine("Documento: " & cliente2.Documento)
        'Console.WriteLine("Fecha de nacimiento: " & cliente2.FechaNacimiento)
        'Console.WriteLine("ToString: " & cliente2.ToString())
        Console.ReadKey()
    End Sub
End Module