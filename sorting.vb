Module Module1

    Private Property i As Object

    Sub Main()
        Dim marks(4) As Integer
        Dim grade(4) As String
        For i As Integer = 0 To 4
            Console.WriteLine("enter the marks of subject" & (i + 1) & ":")
            marks(i) = Integer.Parse(Console.ReadLine())
        Next
        For i As Integer = 0 To 4
            Select Case marks(i)
                Case Is >= 70
                    grade(i) = "A"
                Case Is >= 60
                    grade(i) = "B"
                Case Is >= 41
                    grade(i) = "C"
                Case Else
                    grade(i) = "F"

            End Select
        Next
        Console.WriteLine("grade is :")
        For i As Integer = 0 To 4

        Next
        Console.WriteLine("student " & (i() + 1) & ":" & grade(i))
        Console.ReadLine()
    End Sub

    

End Module
