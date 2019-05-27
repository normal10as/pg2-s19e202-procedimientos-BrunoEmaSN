Imports System

Module Sumas
    Sub Main()
        Dim a As Int16
        Dim b As Int16
        Dim c As Int16
        Dim d As Int16
        Console.WriteLine("Ingrese un valor(A)")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese un valor(B)")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese un valor(C)")
        c = Console.ReadLine()
        Console.WriteLine("Ingrese un valor(D)")
        d = Console.ReadLine()
        Console.WriteLine("Sumar A y B: {0}", sumar(a, b))
        Console.WriteLine("Sumar A, B y C: {0}", sumar(a, b, c))
        Console.WriteLine("Sumar A, B, C y D: {0}", sumar(a, b, c, d))
    End Sub
    Private Function sumar(a, b) As Int16
        Return a + b
    End Function
    Private Function sumar(a, b, c) As Int16
        Return a + b + c
    End Function
    Private Function sumar(a, b, c, d) As Int16
        Return a + b + c + d
    End Function
End Module
