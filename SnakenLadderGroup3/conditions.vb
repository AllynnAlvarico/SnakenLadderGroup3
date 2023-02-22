Public Class conditions
    'Ladder M: 3-22: (188, 393)-(188, 175), 5-8: (333, 393)-(333, 320), 11-26: (114, 320)-(114, 99), 20-29: (333, 175)-(333, 99)
    'Ladder Y: 3-22: (188, 424)-(188, 206), 5-8: (333, 424)-(333, 351), 11-26: (114, 351)-(114, 130), 20-29: (333, 206)-(333, 130)
    'Snakes M: 27-1: (188, 99)-(39, 393), 21-9: (260, 175)-(260, 320), 19-7: (407, 175)-(407, 320), 17-4: (333, 248)-(260, 393)
    'Snakes Y: 27-1: (188, 130)-(39, 424), 21-9: (260, 206)-(260, 351), 19-7: (407, 206)-(407, 351), 17-4: (333, 279)-(260, 424)
    Public Sub ladder(player_score As Integer)
        If (player_score = 3) Then
            player_score = 22
        End If
        If (player_score = 5) Then
            player_score = 8
        End If
        If (player_score = 11) Then
            player_score = 26
        End If
        If (player_score = 20) Then
            player_score = 29
        End If
    End Sub
    Public Sub Snake(player_score As Integer)
        If (player_score = 27) Then
            player_score = 1
        End If
        If (player_score = 21) Then
            player_score = 9
        End If
        If (player_score = 19) Then
            player_score = 7
        End If
        If (player_score = 17) Then
            player_score = 4
        End If
    End Sub
End Class
