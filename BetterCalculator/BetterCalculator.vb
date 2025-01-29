'Jason Permann
'Spring 2025
'RCET2265
'Better Calculator
'https://github.com/JaceFoxman/BetterCalculator.git

Option Explicit On
Option Strict Off


Module BetterCalculator

    Sub Main()

        Dim userInput As String
        Dim variable1 As Integer
        Dim variable2 As Integer

        'Boot up menu 
        Console.WriteLine("Please enter two numbers. Enter " & "Q" & " at any time to quit")
        Console.WriteLine()

        'Do

        'Enter variables
        Console.Write("Choose a number: ")
            variable1 = Console.ReadLine()

            variable1 = CInt(variable1)
            Console.WriteLine($"You entered {variable1}")
            Console.WriteLine()

            Console.Write("Choose a number: ")
            variable2 = Console.ReadLine()
            variable2 = CInt(variable2)
            Console.WriteLine($"You entered {variable2}")
            Console.WriteLine()

        'choose operator
        Console.WriteLine("Choose one of the following options: 1.Add 2.Subtract 3.Multiply 4.Divide")
        userInput = Console.ReadLine()
        userInput = CInt(userInput)

        Select Case userInput
            Case = 1
                Console.WriteLine($"You entered {userInput}")
                Console.WriteLine($"{variable1} + {variable2} = {variable1 + variable2}")
            Case = 2
                Console.WriteLine($"You entered {userInput}")
                Console.WriteLine($"{variable1} - {variable2} = {variable1 - variable2}")
            Case = 3
                Console.WriteLine($"You entered {userInput}")
                Console.WriteLine($"{variable1} / {variable2} = {variable1 / variable2}")
                Case = 4
                    Console.WriteLine($"You entered {userInput}")
                Console.WriteLine($"{variable1} * {variable2} = {variable1 * variable2}")


        End Select

        'Loop Until userInput = "Q"

        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")

    End Sub

End Module
