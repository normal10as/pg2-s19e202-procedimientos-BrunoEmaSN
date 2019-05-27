Imports System

Module SuperficieFiguras
    Sub Main()
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Console.WriteLine("Ingrese lado(cuadrado)")
        a = Console.ReadLine()
        Console.WriteLine("Area: " & areaCuadrado(a))
        Console.WriteLine("Ingrese altura(rectangulo)")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese base(rectangulo)")
        b = Console.ReadLine()
        Console.WriteLine("Area: " & areaRectangulo(a, b))
        Console.WriteLine("Ingrese altura(trapecio)")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese base(trapecio)")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese mediana(trapecio)")
        c = Console.ReadLine()
        Console.WriteLine("Area: " & areaTrapecio(a, b, c))
    End Sub
    Private Function areaCuadrado(a) As Double
        Return a * a
    End Function
    Private Function areaRectangulo(a, b) As Double
        Return a * b
    End Function
    Private Function areaTrapecio(a, b, c) As Double
        Return ((a + b) * c) / 2
    End Function
End Module
