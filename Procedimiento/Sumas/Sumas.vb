Imports System

Module Sumas
    Sub Main()
        Dim a As Single
        Dim b As Single
        Dim c As Single
        Dim d As Single
        a = ingresarValores(a)
        b = ingresarValores(b)
        c = ingresarValores(c)
        d = ingresarValores(d)
        Console.WriteLine("Sumar A y B: {0}", sumar(a, b))
        Console.WriteLine("Sumar A, B y C: {0}", sumar(a, b, c))
        Console.WriteLine("Sumar A, B, C y D: {0}", sumar(a, b, c, d))
    End Sub
    Private Function ingresarValores(x) As Single
        Console.WriteLine("Ingrese un valor")
        x = Console.ReadLine()
        Return x
    End Function
    Private Function sumar(a, b) As Single
        Return a + b
    End Function
    Private Function sumar(a, b, c) As Single
        Return sumar(a, sumar(b, c))
    End Function
    Private Function sumar(a, b, c, d) As Single
        Return sumar(a, sumar(b, c, d))
    End Function
End Module
