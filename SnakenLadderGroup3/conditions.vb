Public Class conditions
    'Ladder M: 3-22: (188, 393)-(188, 175), 5-8: (333, 393)-(333, 320), 11-26: (114, 320)-(114, 99), 20-29: (333, 175)-(333, 99)
    'Ladder Y: 3-22: (188, 424)-(188, 206), 5-8: (333, 424)-(333, 351), 11-26: (114, 351)-(114, 130), 20-29: (333, 206)-(333, 130)
    'Snakes M: 27-1: (188, 99)-(39, 393), 21-9: (260, 175)-(260, 320), 19-7: (407, 175)-(407, 320), 17-4: (333, 248)-(260, 393)
    'Snakes Y: 27-1: (188, 130)-(39, 424), 21-9: (260, 206)-(260, 351), 19-7: (407, 206)-(407, 351), 17-4: (333, 279)-(260, 424)
    Dim effectBox As New Dictionary(Of Integer, Integer)
    Public Sub ladderCondition()
        'Ladder Conditions
        'subtracted 1 to the keys and values inorder to connect with the points array that I have declared
        effectBox.Add(2, 21)
        effectBox.Add(4, 7)
        effectBox.Add(10, 25)
        effectBox.Add(19, 28)
        'Snake Conditions
        effectBox.Add(26, 1)
        effectBox.Add(20, 8)
        effectBox.Add(18, 6)
        effectBox.Add(16, 3)
    End Sub
    Public Sub gameLadder(ByRef player_score As Integer, ByRef playerCounter As PictureBox, place As Point)
        If effectBox.ContainsKey(player_score) Then
            Dim value As Integer = effectBox(player_score)
            player_score = value
            playerCounter.Location = place
            Console.WriteLine(value)
        End If
    End Sub
End Class
