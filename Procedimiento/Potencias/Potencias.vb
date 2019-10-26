Imports System

Module Potencias
    Private elevado As Byte = 1
    Sub Main()
        Dim numero As Single
        Console.WriteLine("Ingrese un valor")
        numero = Console.ReadLine()
        Console.WriteLine("{0}^{1} = {2}", numero, elevado + 1, pontencias(numero))
        Console.WriteLine("{0}^{1} = {2}", numero, elevado + 1, pontencias(numero))
        pontencias(numero)
        Console.WriteLine("{0}^{1} = {2}", numero, elevado + 1, pontencias(numero))
    End Sub
    Private Function pontencias(numero As Single) As Single
        elevado += 1
        Return (numero ^ elevado)
    End Function
End Module
