Imports System.Runtime.InteropServices.WindowsRuntime

Public Class Form1
    Public ClassDice As New Dice_Class
    Public position As position

    Public player_Start As Integer
    Public player1_pos, player2_pos As Integer
    Public startCondition, playTurn As Boolean
    'Constructor/Initializer
    Public Sub gameInit()
        player_Start = 6
        player1_pos = 0
        player2_pos = 0
        startCondition = False

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click
        Dice_Show1()
        setPlayer1(ClassDice.getDice())
    End Sub
    Private Sub btnRollDice2_Click(sender As Object, e As EventArgs) Handles btnRollDice2.Click
        Dice_Show2()
        setPlayer2(ClassDice.getDice())
    End Sub
    Public Sub Dice_Show1()
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
    Public Sub Dice_Show2()
        Dim objDice2 As Integer = ClassDice.getDice()
        Select Case objDice2
            Case 1
                picDie2.Image = ImageList1.Images("dice1.JPG")
            Case 2
                picDie2.Image = ImageList1.Images("dice2.JPG")
            Case 3
                picDie2.Image = ImageList1.Images("dice3.JPG")
            Case 4
                picDie2.Image = ImageList1.Images("dice4.JPG")
            Case 5
                picDie2.Image = ImageList1.Images("dice5.JPG")
            Case 6
                picDie2.Image = ImageList1.Images("dice6.JPG")
        End Select
    End Sub

    Public Sub setPlayer1(Dice As Integer)
        gameInit()
        'playerPosition()
        If startCondition = False Then
            If Dice = player_Start Then
                'MessageBox.Show("Player 1 rolled a 6 now counter")
                picMario.Location = New Point(39, 390) 'Starting Player 1(Mario)
                'picMario.Visible = True
                'player1_pos += 0
                startCondition = True
            End If
        End If
        player1_pos += ClassDice.getDice()
        Console.WriteLine(player1_pos)


    End Sub
    Public Sub setPlayer2(Dice As Integer)
        gameInit()
        If Dice = player_Start Then
            MessageBox.Show("Player 2 rolled a 6 now counter")
            picYoshi.Location = New Point(39, 426) 'Starting Player 2(Yoshi)
            picYoshi.Visible = True
            'player2_pos = 0
            'player2_pos += ClassDice.getDice()
            'Console.WriteLine(player2_pos)
        End If
    End Sub
End Class
