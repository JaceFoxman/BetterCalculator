'Jason Permann
'Spring 2025
'RCET2265
'Better Calculator
'https://github.com/JaceFoxman/BetterCalculator.git

Option Explicit On
Option Strict On
Option Compare Text

Imports System.Diagnostics.Eventing.Reader
Imports System.Linq.Expressions

Module BetterCalculator

    Sub Main()

        Dim userInput As String
        Dim variable1 As Integer
        Dim variable2 As Integer
        Dim nextLoop As Boolean = False

        'Boot up menu 
        Console.WriteLine("Please enter two numbers. Enter " & "Q" & " at any time to quit")
        Console.WriteLine()

        Do

            Do
                Try
                    'Enter variables
                    Console.Write("Choose a number: ")
                    userInput = Console.ReadLine()
                    variable1 = CInt(userInput)
                    Console.WriteLine($"You entered {variable1}")
                    Console.WriteLine()

                    nextLoop = True

                Catch ex As Exception
                    If userInput <> "Q" Then Console.WriteLine($"You entered {userInput}, please enter a whole number")
                End Try
            Loop While userInput <> "Q" And nextLoop = False

            Console.WriteLine()
            nextLoop = False

            Do While userInput <> "Q" And nextLoop = False
                Try
                    Console.Write("Choose a number: ")
                    userInput = Console.ReadLine()
                    variable2 = CInt(userInput)
                    Console.WriteLine($"You entered {variable2}")
                    Console.WriteLine()

                    nextLoop = True

                Catch ex As Exception
                    If userInput <> "Q" Then Console.WriteLine($"You entered {userInput}, please enter a whole number")
                End Try
            Loop

            Console.WriteLine()
            nextLoop = False

            Do While userInput <> "Q" And nextLoop = False
                'choose operator
                Console.WriteLine("Choose one of the following options: 1.Add 2.Subtract 3.Multiply 4.Divide")

                userInput = Console.ReadLine()
                Try
                    nextLoop = True

                    Select Case userInput

                        Case = "1"
                            Console.WriteLine($"You entered {userInput}")
                            Console.WriteLine($"{variable1} + {variable2} = {variable1 + variable2}")
                        Case = "2"
                            Console.WriteLine($"You entered {userInput}")
                            Console.WriteLine($"{variable1} - {variable2} = {variable1 - variable2}")
                        Case = "3"
                            Console.WriteLine($"You entered {userInput}")
                            Console.WriteLine($"{variable1} / {variable2} = {variable1 / variable2}")
                        Case = "4"
                            Console.WriteLine($"You entered {userInput}")
                            Console.WriteLine($"{variable1} * {variable2} = {variable1 * variable2}")
                        Case Else
                            nextLoop = False
                    End Select

                Catch ex As Exception
                    If userInput <> "Q" Then Console.WriteLine($"You entered {userInput}, Choose one of the following options: 1.Add 2.Subtract 3.Multiply 4.Divide")
                End Try
            Loop

            Console.WriteLine()
            nextLoop = False

        Loop Until userInput = "Q" And nextLoop = False

        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")


    End Sub

End Module
