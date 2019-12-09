Option Explicit On
Option Strict On

Module Module1
    Dim maClio As New Voiture()
    Sub Main()
        System.Console.WriteLine(maClio.lesRoues)
        System.Console.ReadKey()
    End Sub
End Module