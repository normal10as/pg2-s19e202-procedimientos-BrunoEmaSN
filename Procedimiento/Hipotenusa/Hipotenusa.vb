Imports System.Math

Module Hipotenusa
    Sub Main()
        Dim c1 As Double
        Dim c2 As Double
        Console.WriteLine("Ingrese valor(Cateto 1)")
        c1 = Console.ReadLine()
        Console.WriteLine("Ingrese valor(Cateto 2)")
        c2 = Console.ReadLine()
        Console.WriteLine("Hiputenusa = " & piteagoras(c1, c2))
    End Sub
    Private Function piteagoras(c1, c2) As Double
        Return sqrt(c1 ^ 2 + c2 ^ 2)
    End Function
End Module
