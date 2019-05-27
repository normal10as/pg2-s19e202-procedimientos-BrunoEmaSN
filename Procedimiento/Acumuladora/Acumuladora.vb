Imports System

Module Acumuladora
    Sub Main()
        Dim numero As Double
        Dim acumulador As Double = 0
        Console.WriteLine("Ingrese un numero(decimal)")
        numero = Console.ReadLine()
        Acumular(numero, acumulador)
        Acumular(numero, acumulador)
        Acumular(numero, acumulador)
    End Sub
    Private Sub Acumular(ByVal numero, ByRef acumulador)
        acumulador += numero
        Console.WriteLine("acumulador = " & acumulador)
    End Sub
End Module
