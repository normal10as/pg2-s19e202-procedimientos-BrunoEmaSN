Imports System
Imports System.DateTime

Module Nueva_fecha
    Sub Main()
        Dim fecha As Date
        Dim dias As Integer
        Console.WriteLine("Ingrese una fecha(AAAA-MM-DD)")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese dias")
        dias = Console.ReadLine()
        Console.WriteLine("Fecha Sumada: " & sumarFechas(fecha, dias))
    End Sub
    Private Function sumarFechas(fecha As Date, dias As Integer) As Date
        Return fecha.AddDays(dias)
    End Function
End Module
