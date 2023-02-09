Imports System.Runtime.InteropServices.WindowsRuntime

Public Class Form1
    Public ClassDice As New Dice_Class

    Public player_Start As Integer
    Public player1_pos, player2_pos As Integer
    Public startCondition, playTurn As Boolean

    Public p1_b1, p1_b2, p1_b3, p1_b4, p1_b5 As Point
    Public p1_b6, p1_b7, p1_b8, p1_b9, p1_b10 As Point
    Public p1_b11, p1_b12, p1_b13, p1_b14, p1_b15 As Point
    Public p1_b16, p1_b17, p1_b18, p1_b19, p1_b20 As Point
    Public p1_b21, p1_b22, p1_b23, p1_b24, p1_b25 As Point
    Public p1_b26, p1_b27, p1_b28, p1_b29, p1_b30 As Point

    Public p2_b1, p2_b2, p2_b3, p2_b4, p2_b5 As Point
    Public p2_b6, p2_b7, p2_b8, p2_b9, p2_b10 As Point
    Public p2_b11, p2_b12, p2_b13, p2_b14, p2_b15 As Point
    Public p2_b16, p2_b17, p2_b18, p2_b19, p2_b20 As Point
    Public p2_b21, p2_b22, p2_b23, p2_b24, p2_b25 As Point
    Public p2_b26, p2_b27, p2_b28, p2_b29, p2_b30 As Point
    'Constructor/Initializer
    Public Sub gameInit()
        player_Start = 6
        player1_pos = 0
        player2_pos = 0
        startCondition = False
    End Sub
    Public Sub p1_pos() ' Update this point location
        p1_b1 = New Point(39, 390)
        p1_b2 = New Point(139, 390)
        p1_b3 = New Point(219, 387)
        p1_b4 = New Point(306, 390)
        p1_b5 = New Point(392, 390)
        p1_b6 = New Point(482, 394)
        p1_b7 = New Point(483, 308)
        p1_b8 = New Point(395, 304)
        p1_b9 = New Point(313, 300)
        p1_b10 = New Point(227, 303)
        p1_b11 = New Point(137, 301)
        p1_b12 = New Point(48, 304)
        p1_b13 = New Point(48, 213)
        p1_b14 = New Point(134, 220)
        p1_b15 = New Point(221, 215)
        p1_b16 = New Point(303, 218)
        p1_b17 = New Point(394, 214)
        p1_b18 = New Point(486, 216)
        p1_b19 = New Point(485, 124)
        p1_b20 = New Point(392, 125)
        p1_b21 = New Point(307, 124)
        p1_b22 = New Point(218, 124)
        p1_b23 = New Point(136, 126)
        p1_b24 = New Point(43, 124)
        p1_b25 = New Point(43, 37)
        p1_b26 = New Point(134, 37)
        p1_b27 = New Point(221, 37)
        p1_b28 = New Point(305, 37)
        p1_b29 = New Point(393, 37)
        p1_b30 = New Point(482, 37)
    End Sub
    Public Sub p2_pos() ' Update this point location
        p2_b1 = New Point(39, 390)
        p2_b2 = New Point(139, 390)
        p2_b3 = New Point(219, 387)
        p2_b4 = New Point(306, 390)
        p2_b5 = New Point(392, 390)
        p2_b6 = New Point(482, 394)
        p2_b7 = New Point(483, 308)
        p2_b8 = New Point(395, 304)
        p2_b9 = New Point(313, 300)
        p2_b10 = New Point(227, 303)
        p2_b11 = New Point(137, 301)
        p2_b12 = New Point(48, 304)
        p2_b13 = New Point(48, 213)
        p2_b14 = New Point(134, 220)
        p2_b15 = New Point(221, 215)
        p2_b16 = New Point(303, 218)
        p2_b17 = New Point(394, 214)
        p2_b18 = New Point(486, 216)
        p2_b19 = New Point(485, 124)
        p2_b20 = New Point(392, 125)
        p2_b21 = New Point(307, 124)
        p2_b22 = New Point(218, 124)
        p2_b23 = New Point(136, 126)
        p2_b24 = New Point(43, 124)
        p2_b25 = New Point(43, 37)
        p2_b26 = New Point(134, 37)
        p2_b27 = New Point(221, 37)
        p2_b28 = New Point(305, 37)
        p2_b29 = New Point(393, 37)
        p2_b30 = New Point(482, 37)
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
        p1_pos()
        'playerPosition()
        If startCondition = False Then
            If Dice = player_Start Then
                'MessageBox.Show("Player 1 rolled a 6 now counter")
                picMario.Location = p1_b15 'Starting Player 1(Mario)
                picMario.Visible = True
                'player1_pos += 0
                startCondition = True
            End If
        End If
        player1_pos += ClassDice.getDice()
        Console.WriteLine(player1_pos)


    End Sub
    Public Sub setPlayer2(Dice As Integer)
        gameInit()
        p2_pos()
        If Dice = player_Start Then
            MessageBox.Show("Player 2 rolled a 6 now counter")
            picYoshi.Location = p2_b6 'Starting Player 2(Yoshi)
            picYoshi.Visible = True
            'player2_pos = 0
            'player2_pos += ClassDice.getDice()
            'Console.WriteLine(player2_pos)
        End If
    End Sub
End Class
