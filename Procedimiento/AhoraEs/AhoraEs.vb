Imports System
Imports System.DateTime

Module AhoraEs
    Sub Main()
        fechaActual()
        Console.WriteLine("La hora Actual es: " & horaActual())
    End Sub
    Private Sub fechaActual()
        Console.WriteLine("La fecha Actual es: " & Today)
    End Sub
    Private Function horaActual()
        Return Now.Hour & ":" & Now.Minute & ":" & Now.Second
    End Function
End Module
