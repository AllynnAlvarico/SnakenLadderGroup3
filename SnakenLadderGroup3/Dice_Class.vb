Public Class Dice_Class
    Public Function getDice()
        'declarations
        Dim rndNumber As Random
        Dim intDie1 As Integer
        'generate a new object
        rndNumber = New Random
        'get value between 1 and 6
        intDie1 = rndNumber.Next(1, 7)

        'display the value in the label
        Console.WriteLine(intDie1)
        Return intDie1
    End Function
End Class
