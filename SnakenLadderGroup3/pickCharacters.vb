Public Class pickCharacters
    Public playerDict As New Dictionary(Of Integer, String) From {
        {1, "Mario.Png"},
        {2, "Luigi.Png"},
        {3, "Peach.Png"},
        {4, "Yoshi.Png"}
    }
    Public chooseTurn, player1Turn, player2Turn As Boolean
    Public p1_note, p2_note As String
    Public player1, player2 As Integer
    Public Sub New()
        InitializeComponent()
        p1_note = "Player 1 have chosen: "
        p2_note = "Player 2 have chosen: "
    End Sub

    Public Sub prompMessage(player As Integer)
        Dim defaultMessage = MessageBox.Show("Are you Sure?", "confirmation!", MessageBoxButtons.YesNo)
        If defaultMessage = DialogResult.Yes Then
            chosenCharacters(player)
        Else
            MessageBox.Show("No Character has been Choosen")
            player1 = 0
            player2 = 0
            pickMario.Enabled = True
            pickLuigi.Enabled = True
            pickPeach.Enabled = True
            pickYoshi.Enabled = True
        End If
    End Sub
    Public Sub chosenCharacters(chosen As Integer)
        If playerDict.ContainsKey(chosen) Then
            Console.WriteLine("player 1 have chosen: " & playerDict.Item(chosen))
            '"myDictionary.Item(myParameter) gets the value of the key
            'this will allow you to be able to call or show the value in the dictionary
        End If
    End Sub
    Public Sub pickTurn(PlayerTurn As Boolean, playerSelected As Integer)
        If PlayerTurn = True Then
            Select Case playerSelected
                Case 1
                    pickMario.Enabled = False
                    player1Turn = False
                    Exit Select
                Case 2
                    pickLuigi.Enabled = False
                    player1Turn = False
                    Exit Select
                Case 3
                    pickPeach.Enabled = False
                    player1Turn = False
                    Exit Select
                Case 4
                    pickYoshi.Enabled = False
                    player1Turn = False
                    Exit Select
            End Select
            prompMessage(playerSelected)
        End If
    End Sub
    Private Sub pickMario_Click(sender As Object, e As EventArgs) Handles pickMario.Click
        pickTurn(True, 1)
    End Sub

    Private Sub pickLuigi_Click(sender As Object, e As EventArgs) Handles pickLuigi.Click
        pickTurn(True, 2)
    End Sub

    Private Sub pickPeach_Click(sender As Object, e As EventArgs) Handles pickPeach.Click
        pickTurn(True, 3)
    End Sub

    Private Sub pickYoshi_Click(sender As Object, e As EventArgs) Handles pickYoshi.Click
        pickTurn(True, 4)
    End Sub
End Class