Imports System

Module Program
    Sub Main(args As String())
        'Setting the syntax to string, assining the string to Len and U(case)
        Dim forename, length_name As String
        Dim surname, surname_uppercase As String
        'Asking the user to input their forename
        Console.WriteLine("Enter your forename:")
        'Assining the forename variable to Console.WriteLine()
        forename = Console.ReadLine()
        'The string is going to make the length of the name equivalent to 1
        length_name = Left(forename, 1)
        'Outputs the users forename 
        Console.WriteLine("Your forename is" & "  " & forename)
        Console.WriteLine("Please enter your surname")
        surname = Console.ReadLine()
        Console.WriteLine("Your surname is" & " " & surname)
        'The string should now output the surname as completely uppercase
        surname_uppercase = UCase(surname)
        'Should output the username as one
        Console.WriteLine("Your name in capital letters is:" & "  " & surname_uppercase)
        Console.WriteLine("Your username will be" & " " & length_name & " " & surname_uppercase)
        Console.ReadLine()




    End Sub

    Private ReadOnly Property Len(forename As String, v As Integer) As String
        Get
            Throw New NotImplementedException()
        End Get
    End Property
End Module
