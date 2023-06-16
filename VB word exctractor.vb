Imports System
Module Program
    Sub Main()
        'Delcaring variables 
        Dim _Le, _R As String
        Dim word As String
        Dim length1, length2 As Integer
        'Assigning string to the variable
        Dim sentence As String = ("Quick brown fox jumps over the lazy dog".ToUpper)
        'Outputting the sentence
        Console.Write(sentence)
        'Checking the input before executing
        Console.ReadLine()
        'Asking the user to input the word to be extracted 
        Console.WriteLine("Please enter a word from the sentence")
        word = Console.ReadLine()
        'Finding the length of each sentence
        length1 = Len(sentence)
        length2 = Len(word)
        'Finding the position of the word inside of the sentence
        Dim position As Integer
        position = InStr(sentence, word)
        'Minus a character from position, from the left of the sentence
        _Le = Left(sentence, position - 1)
        'Outputting the result 
        Console.Write(_Le)
        'Right hand side of the sentence
        _R = Right(sentence, (length1 - length2 - position))
        Console.Write(_R)
        Console.ReadLine()












    End Sub
End Module
