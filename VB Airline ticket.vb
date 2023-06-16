Imports System

Module Program
    Sub Main(args As String())

        'Setting syntax to accept strings
        Dim City1, length_City1, City1_uppercase As String
        Dim City2, length_City2, City2_Uppercase As String
        'Asking the user to input the name of city#1
        Console.WriteLine("Enter the name of city #1")
        'Assingning the variable to the text before 
        City1 = Console.ReadLine()
        'Starting from the left side of the word up untill the 4th letter is reached
        length_City1 = Left(City1, 4)
        'Will uppercase the length
        City1_uppercase = UCase(length_City1)
        Console.WriteLine("City one is:" & length_City1)
        Console.WriteLine("Enter the name of city #2")
        City2 = Console.ReadLine()
        'Starting from the left side of the word up untill the 4th letter is reached
        length_City2 = Left(City2, 4)
        'Will uppercase the length
        City2_Uppercase = UCase(length_City2)
        Console.WriteLine("City two is:" & length_City2)
        'Outputs the results stored in the variables
        Console.WriteLine("You will be travelling to " & City1_uppercase & "-" & City2_Uppercase)
        Console.ReadLine()










    End Sub


End Module
