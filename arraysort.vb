Module Module1

    Sub Main()

        Dim marks() As Integer = {22, 44, 44, 66, 66}
        Dim i As Integer

        
        Array.Sort(marks)

        Console.WriteLine("Sorted marks:")
        For i = 0 To marks.Length - 1
            Console.WriteLine(" " & marks(i))
        Next

        Console.ReadLine()

    End Sub

End Module
