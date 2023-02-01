Public Class Form1
    Dim ClassDice As New Dice_Class
    Dim player_StartCondition As Integer = 6



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click

        Dice_Show()
        setGameCondition(ClassDice.getDice())
    End Sub
    Public Sub Dice_Show()
        Dim objDice As Integer = ClassDice.getDice()
        Select Case objDice
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
    End Sub
    Public Sub setGameCondition(Dice As Integer)
        If Dice = player_StartCondition Then
            MessageBox.Show("Player 1 rolled a 6 now counter")
            lblBlock1.Visible = True
            lblBlock1.BackColor = Color.Red

        End If
    End Sub


End Class
