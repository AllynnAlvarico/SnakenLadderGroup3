Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declarations
        Dim rndNumber As Random
        Dim intValue As Integer

        'generate a new object
        rndNumber = New Random

        'get value between 1 and 6
        intValue = rndNumber.Next(1, 7)

        'display the value in the label


        Console.WriteLine(intValue)



    End Sub
End Class
