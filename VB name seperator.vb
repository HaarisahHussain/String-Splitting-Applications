Imports System

Module Program
    Sub Main(args As String())
        'Setting syntax to accept strings
        Dim foreanme, surname, fullName As String
        Dim number, seperate As String
        'Asking user to input their full name
        Console.WriteLine("Please enter your full name")
        'Assining the variable full name to the text before
        fullName = Console.ReadLine
        'Finds the space between the text 
        seperate = InStr(fullName, " ")
        'Outputs from the left of the space
        foreanme = Left(fullName, seperate)
        'Displays forename to the user
        Console.WriteLine("Forename:" & " " & foreanme)
        number = Len(fullName)
        'Take away the number and seperate so it only outputs the right hand side
        surname = Right(fullName, number - seperate)
        Console.WriteLine("Surname:" & " " & surname)
        Console.ReadLine()






    End Sub
End Module
