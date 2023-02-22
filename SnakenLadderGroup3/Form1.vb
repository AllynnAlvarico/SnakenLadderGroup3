Imports System.Runtime.InteropServices.WindowsRuntime

Public Class Form1
    Public objDice As New Dice_Class
    Public boardCondition As New conditions


    Public player_Start As Integer
    Public player1_Score, player2_Score As Integer
    Public marioCondition, yoshiCondition, playerTurn As Boolean
    Dim p1_b As Point() = {New Point(39, 393), New Point(114, 393), New Point(188, 393), New Point(260, 393), New Point(333, 393), New Point(407, 393), New Point(407, 320), New Point(333, 320), New Point(260, 320), New Point(188, 320), New Point(114, 320), New Point(39, 320), New Point(39, 248), New Point(114, 248), New Point(188, 248), New Point(260, 248), New Point(333, 248), New Point(407, 248), New Point(407, 175), New Point(333, 175), New Point(260, 175), New Point(188, 175), New Point(114, 175), New Point(39, 175), New Point(39, 99), New Point(114, 99), New Point(188, 99), New Point(260, 99), New Point(333, 99), New Point(407, 99)}
    Dim p2_b As Point() = {New Point(39, 424), New Point(114, 424), New Point(188, 424), New Point(260, 424), New Point(333, 424), New Point(407, 424), New Point(407, 351), New Point(333, 351), New Point(260, 351), New Point(188, 351), New Point(114, 351), New Point(39, 351), New Point(39, 279), New Point(114, 279), New Point(188, 279), New Point(260, 279), New Point(333, 279), New Point(407, 279), New Point(407, 206), New Point(333, 206), New Point(260, 206), New Point(188, 206), New Point(114, 206), New Point(39, 206), New Point(39, 130), New Point(114, 130), New Point(188, 130), New Point(260, 130), New Point(333, 130), New Point(407, 130)}

    'Ladder M: 3-22: (188, 393)-(188, 175), 5-8: (333, 393)-(333, 320), 11-26: (114, 320)-(114, 99), 20-29: (333, 175)-(333, 99)
    'Ladder Y: 3-22: (188, 424)-(188, 206), 5-8: (333, 424)-(333, 351), 11-26: (114, 351)-(114, 130), 20-29: (333, 206)-(333, 130)
    'Snakes M: 27-1: (188, 99)-(39, 393), 21-9: (260, 175)-(260, 320), 19-7: (407, 175)-(407, 320), 17-4: (333, 248)-(260, 393)
    'Snakes Y: 27-1: (188, 130)-(39, 424), 21-9: (260, 206)-(260, 351), 19-7: (407, 206)-(407, 351), 17-4: (333, 279)-(260, 424)

    'Constructor/Initializer
    Public Sub New()
        InitializeComponent()
        boardCondition.ladderCondition()
        player_Start = 6
        player1_Score = 0
        player2_Score = 0
        marioCondition = False
        yoshiCondition = False

    End Sub
    '"ByRef" or Pass by Reference is to enable to change the variable by using or passing an arguement
    '"ByVal" or Pass by Value is to change the actual value of a property or variable
    Public Sub setPlayerCondition(Dice As Integer, img As PictureBox, block As Point, ByRef cond As Boolean)
        'this method sets up the the players condition to start
        'arguement<Dice(random number generated), img(the players counter/picture), block(location of the counter/picture), cond(players condition to start)>
        If cond = False Then
            If Dice = player_Start Then
                MessageBox.Show("Player 1 rolled a 6 now counter")
                img.Location = block 'Starting Player
                img.Visible = True
                cond = True
            End If
        End If
    End Sub
    Public Sub gameLogic(cond As Boolean, ByRef playerScore As Integer, ByRef playerCounter As PictureBox, pointsArray() As Point)
        If cond = True Then
            playerScore = setPlayerScore(playerScore, objDice.getDice)
            If playerScore <= 29 Then
                Player_Position(playerCounter, pointsArray(playerScore), playerScore)
                boardCondition.gameLadder(playerScore, playerCounter, pointsArray(playerScore))
            Else
                MessageBox.Show("player 1 win") 'needs to change this message box
                playerCounter.Location = pointsArray(29)
                Console.WriteLine("Player 1 wins")
            End If
        End If
    End Sub


    'function
    'setting the players score of the dice roll
    'arguements<playerscore, dice>
    'playerscore: gets the player score
    'dice: gets the roll of the dice
    Public Function setPlayerScore(player_score As Integer, Dice As Integer)
        'this "playerScore" Assigns the actual score of the player
        'when the "Dice" is rolled it gets added to the "playerScore"
        player_score += Dice

        '======================================================================================'

        'If (player_score <= 30) Then
        '    player_score += Dice
        'Else
        '    player_score = 30
        'End If
        '======================================================================================'
        'this returns the value of the "playerScore"
        Return player_score
    End Function
    Public Sub Player_Position(player As PictureBox, place As Point, player_score As Integer)
        'this method sets up the location of the player on the board
        'if the player score is under 30 then the code places mario or yoshi on the board "place" is the location of the board)
        If (player_score < 30) Then
            player.Location = place
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click
        'I assigned the diceValue to hold the objDice.getDice to be called easily and remember it easily
        Dim diceValue As Integer = objDice.getDice()
        '======================================================================================'
        'this is the class and method for rolling and showing the dice
        'arguements<PictureBox, Dice, ImageList>
        '"picDie1" = getting the property name of the PictureBox in the Design
        '"ImageList1" = getting the property name of the Image List in the Design
        '"objDice.getDice()" = getting the random number from the class file called "Dice_Class"
        objDice.setPictureDice(picDie1, diceValue, ImageList1)
        Console.WriteLine("player 1 Diced Rolled: " & diceValue)
        Console.WriteLine("Player 1 Score: " & player1_Score)
        '======================================================================================'
        gameLogic(marioCondition, player1_Score, picMario, p1_b)
        setPlayerCondition(diceValue, picMario, p1_b(0), marioCondition)

        'picMario.Location = p1_b(player1_Score)



    End Sub
    Private Sub btnRollDice2_Click(sender As Object, e As EventArgs) Handles btnRollDice2.Click
        'I assigned the diceValue to hold the objDice.getDice to be called easily and remember it easily
        Dim diceValue As Integer = objDice.getDice()
        '======================================================================================'
        'this is the class and method for rolling and showing the dice
        'arguements<PictureBox, Dice, ImageList>
        '"picDie2" = getting the property name of the PictureBox in the Design
        '"ImageList1" = getting the property name of the Image List in the Design
        '"objDice.getDice()" = getting the random number from the class file called "Dice_Class"
        objDice.setPictureDice(picDie2, objDice.getDice, ImageList1)
        Console.WriteLine("player 2 Diced Rolled: " & diceValue)
        Console.WriteLine("Player 2 Score: " & player2_Score)
        '======================================================================================'
        gameLogic(yoshiCondition, player2_Score, picYoshi, p2_b)
        setPlayerCondition(objDice.getDice(), picYoshi, p2_b(0), yoshiCondition)

        'picYoshi.Location = p2_b(player2_Score)

    End Sub
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'this line restarts the windows page of the game.
        Application.Restart()
    End Sub
End Class
