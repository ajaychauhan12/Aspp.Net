
Imports System
Imports System.Net.Mail
Imports System.Threading

Module Program
    Class VEHICLE
        Protected speed As Double
        Protected n As String
        Protected type As String

        Public Sub New()
            Dim speed As Double
            speed = 0
        End Sub

        Public Sub New(name As String, sped As Double)
            n = name
            speed = sped
            Console.WriteLine("Speed is " & speed)
        End Sub

        Public Overridable Sub typ(typ As String)
            type = typ
            Console.WriteLine("Type of vehicle is " & type)
        End Sub
    End Class

    Class BMW
        Inherits VEHICLE
        Protected mile As Double

        Public Sub New(name, sped)
            MyBase.New("bmw", 40)
        End Sub

        Public Sub mileage(distance As Double, litres As Double)
            mile = distance / litres
            Console.WriteLine("Mileage is " & mile)
        End Sub

        Public Function getValue() As Integer
            Return mile
        End Function

        Public Overridable Sub typ(typ As String)
            MyBase.typ("automatic")
        End Sub
    End Class

    Class ferrari
        Inherits VEHICLE
        Public mil As Double

        Public Sub New(name, sped)
            MyBase.New("ferrari", 60)
        End Sub

        Public Sub mileage(distance As Double, litres As Double)
            mil = distance / litres
            Console.WriteLine("Mileage is " & mil)
        End Sub

        Public Function val() As Integer
            Return mil
        End Function

        Public Overridable Sub typ(type As String)
            MyBase.typ("automatic")
        End Sub
    End Class

    Class audi
        Inherits VEHICLE
        Public mil As Double

        Public Sub New(name, sped)
            MyBase.New("AUDI", 70)
        End Sub

        Public Sub mileage(distance As Double, litres As Double)
            mil = distance / litres
            Console.WriteLine("Mileage is " & mil)
        End Sub

        Public Function val() As Integer
            Return mil
        End Function

        Public Overridable Sub typ(typ As String)
            MyBase.typ("automatic")
        End Sub
    End Class

    Sub main()
        Dim mee As Double
        Dim meet As Double
        Dim meetu As Double
        Console.WriteLine("Information of BMW " & vbCrLf)
        Dim c1 As BMW = New BMW("BMW", 48)
        c1.typ("automatic")
        c1.mileage(165, 5)
        mee = c1.getValue()
        Console.WriteLine("")

        Console.WriteLine("Information fo Ferrari" & vbCrLf)
        Dim c2 As ferrari = New ferrari("ferrari", 50)
        c2.typ("automatic")
        c2.mileage(175, 5)
        meet = c2.val()
        Console.WriteLine("")

        Console.WriteLine("Information of AUDI" & vbCrLf)
        Dim c3 As audi = New audi("AUDI", 78)
        Type.GetType("Automatic")
        c3.mileage(185, 5)
        meetu = c3.val()
        Console.WriteLine("")

        If mee > meet Then
            If mee > meetu Then
                Console.WriteLine("BMW has more mileage than Ferrari  so its more econimical")
            End If
        ElseIf meet > meetu Then
            Console.WriteLine("Ferrari is more economical with high mileage")
        Else
            Console.WriteLine("Audi is more economical with high mileage")
        End If

        Console.ReadLine()
    End Sub
End Module


