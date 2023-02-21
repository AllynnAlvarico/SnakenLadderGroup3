Imports System.Runtime.InteropServices.WindowsRuntime

Public Class Form1
    Public objDice As New Dice_Class
    Public player_Start As Integer
    'Public Game_is_valid As Boolean
    Public player1_Score, player2_Score As Integer
    Public marioCondition, yoshiCondition, startCOndition, playerTurn As Boolean
    Dim p1_b As Point() = {New Point(39, 393), New Point(114, 393), New Point(188, 393), New Point(260, 393), New Point(333, 393), New Point(407, 393), New Point(407, 320), New Point(333, 320), New Point(260, 320), New Point(188, 320), New Point(114, 320), New Point(39, 320), New Point(39, 248), New Point(114, 248), New Point(188, 248), New Point(260, 248), New Point(333, 248), New Point(407, 248), New Point(407, 175), New Point(333, 175), New Point(260, 175), New Point(188, 175), New Point(114, 175), New Point(39, 175), New Point(39, 99), New Point(114, 99), New Point(188, 99), New Point(260, 99), New Point(333, 99), New Point(407, 99)}
    Dim p2_b As Point() = {New Point(39, 424), New Point(114, 424), New Point(188, 424), New Point(260, 424), New Point(333, 424), New Point(407, 424), New Point(407, 351), New Point(333, 351), New Point(260, 351), New Point(188, 351), New Point(114, 351), New Point(39, 351), New Point(39, 279), New Point(114, 279), New Point(188, 279), New Point(260, 279), New Point(333, 279), New Point(407, 279), New Point(407, 206), New Point(333, 206), New Point(260, 206), New Point(188, 206), New Point(114, 206), New Point(39, 206), New Point(39, 130), New Point(114, 130), New Point(188, 130), New Point(260, 130), New Point(333, 130), New Point(407, 130)}

    'Ladder M: 3-22: (188, 393)-(188, 175), 5-8: (333, 393)-(333, 320), 11-26: (114, 320)-(114, 99), 20-29: (333, 175)-(333, 99)
    'Ladder Y: 3-22: (188, 424)-(188, 206), 5-8: (333, 424)-(333, 351), 11-26: (114, 351)-(114, 130), 20-29: (333, 206)-(333, 130)
    'Snakes M: 27-1: (188, 99)-(39, 393), 21-9: (260, 175)-(260, 320), 19-7: (407, 175)-(407, 320), 17-4: (333, 248)-(260, 393)
    'Snakes Y: 27-1: (188, 130)-(39, 424), 21-9: (260, 206)-(260, 351), 19-7: (407, 206)-(407, 351), 17-4: (333, 279)-(260, 424)

    'Constructor/Initializer
    Public Sub New()
        InitializeComponent()
        player_Start = 6
        player1_Score = 0
        player2_Score = 0
        marioCondition = False
        yoshiCondition = False
    End Sub
    Public Sub setPlayerCondition(Dice As Integer, img As PictureBox, block As Point, ByRef cond As Boolean)
        If cond = False Then
            If Dice = player_Start Then
                MessageBox.Show("Player 1 rolled a 6 now counter")
                img.Location = block 'Starting Player
                img.Visible = True
                cond = True
            End If
        End If
    End Sub
    Public Sub gameLogic(cond As Boolean, ByRef playerScore As Integer, playerCounter As PictureBox, pointsArray() As Point)
        If cond = True Then
            playerScore = setPlayerScore(playerScore, objDice.getDice)
            If playerScore <= 29 Then
                PlayerPos(playerCounter, pointsArray(playerScore), playerScore)
            Else
                'MessageBox.Show("player 1 win")
                playerCounter.Location = pointsArray(29)
                Console.WriteLine("Player 1 wins")
            End If
        End If
        Console.WriteLine(player1_Score + 1)
    End Sub

    'function
    'setting the players score of the dice roll
    'arguements<playerscore, dice>
    'playerscore: gets the player score
    'dice: gets the roll of the dice
    Public Function setPlayerScore(playerScore As Integer, Dice As Integer)
        playerScore += Dice
        Return playerScore
    End Function
    Public Sub PlayerPos(player As PictureBox, place As Point, player_score As Integer)
        If (player_score < 30) Then
            player.Location = place
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click
        'this is the class and method for rolling and showing the dice
        'arguements<PictureBox, Dice, ImageList>
        '"picDie1" = getting the property name of the PictureBox in the Design
        '"ImageList1" = getting the property name of the Image List in the Design
        '"objDice.getDice()" = getting the random number from the class file called "Dice_Class"
        objDice.rolledDice(picDie1, objDice.getDice, ImageList1)

        gameLogic(marioCondition, player1_Score, picMario, p1_b)
        setPlayerCondition(objDice.getDice(), picMario, p1_b(0), marioCondition)

    End Sub
    Private Sub btnRollDice2_Click(sender As Object, e As EventArgs) Handles btnRollDice2.Click
        'this is the class and method for rolling and showing the dice
        'arguements<PictureBox, Dice, ImageList>
        '"picDie2" = getting the property name of the PictureBox in the Design
        '"ImageList1" = getting the property name of the Image List in the Design
        '"objDice.getDice()" = getting the random number from the class file called "Dice_Class"
        objDice.rolledDice(picDie2, objDice.getDice, ImageList1)

        gameLogic(yoshiCondition, player2_Score, picYoshi, p2_b)
        setPlayerCondition(objDice.getDice(), picYoshi, p2_b(0), yoshiCOndition)
    End Sub
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
End Class
