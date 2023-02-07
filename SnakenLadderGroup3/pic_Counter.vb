Public Class pic_Counter

    Public startCondition As Integer

    'Constructors/Initializers
    Public Sub player_StartCondition()
        startCondition = 6
    End Sub

    Public Sub setPlayer1(Dice As Integer)
        If Dice = startCondition Then
            MessageBox.Show("Player 1 rolled a 6 now counter")
        End If
    End Sub
    'Public Sub setPlayer2(Dice As Integer)
    '    If Dice = startCondition2() Then
    '        MessageBox.Show("Player 2 rolled a 6 now counter")
    '        picYoshi.Location = New Point(39, 426) 'Starting Player 2(Yoshi)
    '        picYoshi.Visible = True
    '    End If
    'End Sub

End Class
