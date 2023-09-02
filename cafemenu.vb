Dim totalCost As Integer = 0

        Console.WriteLine("Welcome to the Cafe Menu!")
        Console.WriteLine("Menu:")
        Console.WriteLine("1. Coffee - 20 INR")
        Console.WriteLine("2. Tea - 10 INR")
        Console.WriteLine("3. Sandwich - 35 INR")
        Console.WriteLine("4. Pizza - 70 INR")
        Console.WriteLine("5. Burger - 40 INR")
        Console.WriteLine("6. Noodles - 50 INR")
        Console.WriteLine("7. Exit")

        While True
            Console.Write("Enter your choice (1-7): ")
            Dim choice As Integer = Console.ReadLine()

            Select Case choice
                Case 1
                    totalCost += 20
                Case 2
                    totalCost += 10
                Case 3
                    totalCost += 35
                Case 4
                    totalCost += 70
                Case 5
                    totalCost += 40
                Case 6
                    totalCost += 50
                Case 7
                    Exit While
                Case Else
                    Console.WriteLine("Invalid choice! Please enter a valid option.")
            End Select
        End While

        Console.WriteLine("Thank you for your order!")
        Console.WriteLine("Enjoy your meal :-)")
        Console.WriteLine("Your total cost is: " & totalCost & " INR")
