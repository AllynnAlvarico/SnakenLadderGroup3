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
        'Console.WriteLine(intDie1)
        Return intDie1
    End Function

    Public Sub setPictureDice(img As PictureBox, diceNum As Integer, imgList As ImageList)

        Select Case diceNum
            Case 1
                img.Image = imgList.Images("dice1.JPG")
            Case 2
                img.Image = imgList.Images("dice2.JPG")
            Case 3
                img.Image = imgList.Images("dice3.JPG")
            Case 4
                img.Image = imgList.Images("dice4.JPG")
            Case 5
                img.Image = imgList.Images("dice5.JPG")
            Case 6
                img.Image = imgList.Images("dice6.JPG")
        End Select
    End Sub

End Class
