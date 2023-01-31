Public Class Form1
    Dim intDie1 As Integer
    Dim player As Integer = 6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declarations
        Dim rndNumber As Random
        'generate a new object
        rndNumber = New Random
        'get value between 1 and 6
        intDie1 = rndNumber.Next(1, 7)

        'display the value in the label
        Console.WriteLine(intDie1)

        Select Case intDie1
            Case 1
                picDie1.Image = ImageList1.Images("dice1.JPG")
            Case 2
                picDie1.Image = ImageList1.Images("dice2.JPG")
            Case 3
                picDie1.Image = ImageList1.Images("dice3.JPG")
            Case 4
                picDie1.Image = ImageList1.Images("dice4.JPG")
            Case 5
                picDie1.Image = ImageList1.Images("dice5.JPG")
            Case 6
                picDie1.Image = ImageList1.Images("dice6.JPG")
        End Select

        If intDie1 = player Then

        End If

    End Sub


End Class
