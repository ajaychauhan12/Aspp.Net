Module Module1

    Sub Main()
        Dim marks(9) As Integer
        For i As Integer = 0 To 9
            Console.WriteLine("enter marks for student " & (i + 1) & ":")
            marks(i) = Convert.ToInt32(Console.ReadLine())

        Next
        Array.Sort(marks)
        Console.WriteLine(vbCrLf & "sorted marks:")
        For i As Integer = 0 To 9
            Console.WriteLine("student " & (i + 1) & ": " & marks(i))
        Next
        Console.ReadLine()
    End Sub


End Module


