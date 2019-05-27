Imports System.Math

Module VolumenCilindro
    Sub Main()
        Dim r As Double
        Dim h As Double
        Console.WriteLine("Ingrese radio")
        r = Console.ReadLine()
        Console.WriteLine("Ingrese altura")
        h = Console.ReadLine()
        Console.WriteLine("Volumen del Cilindro: " & volumen_cilindro(r, h))

    End Sub
    Private Function volumen_cilindro(r, h) As Double
        Return (PI * r ^ 2 * h)
    End Function
End Module
