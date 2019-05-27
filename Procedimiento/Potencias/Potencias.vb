Imports System

Module Potencias
    Sub Main()
        Dim numero As Int16
        Console.WriteLine("Ingrese un valor")
        numero = Console.ReadLine()
        Console.WriteLine("{0}^{1} = {2}", numero, 2, pontencias(numero, 2))
        Console.WriteLine("{0}^{1} = {2}", numero, 3, pontencias(numero, 3))
        Console.WriteLine("{0}^{1} = {2}", numero, 5, pontencias(numero, 5))
    End Sub
    Private Function pontencias(numero, elevado) As Int16
        Return (numero ^ elevado)
    End Function
End Module
