Imports System

Module Acumuladora
    Sub Main()
        Dim numero As Double
        Dim acumulador As Double = 0
        Console.WriteLine("Ingrese un numero(decimal)")
        numero = Console.ReadLine()
        Acumular(numero, acumulador)
        Console.WriteLine("acumulador = " & acumulador)
        Acumular(numero, acumulador)
        Console.WriteLine("acumulador = " & acumulador)
        Acumular(numero, acumulador)
        Console.WriteLine("acumulador = " & acumulador)
    End Sub
    Private Sub Acumular(ByVal numero, ByRef acumulador)
        acumulador += numero
    End Sub
End Module
