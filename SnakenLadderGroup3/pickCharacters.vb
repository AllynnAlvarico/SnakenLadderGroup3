Public Class pickCharacters
    Public playerDict As New Dictionary(Of Integer, String) From {
        {1, "Mario.Png"},
        {2, "Luigi.Png"},
        {3, "Peach.Png"},
        {4, "Yoshi.Png"}
    }
    'Public player1Chosen, player2Chosen As String
    Public chooseTurn, player1Turn, player2Turn As Boolean
    Public selectMario, selectLuigi, selectPeach, selectYoshi As Boolean
    Public player1, player2 As Integer


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
            If selectMario = True Then
                playerSelected = 1
                pickMario.Enabled = False
                player1Turn = False
            ElseIf selectLuigi = True Then
                playerSelected = 2
                pickLuigi.Enabled = False
                player1Turn = False
            ElseIf selectPeach = True Then
                playerSelected = 3
                pickPeach.Enabled = False
                player1Turn = False
            ElseIf selectYoshi = True Then
                playerSelected = 4
                pickYoshi.Enabled = False
                player1Turn = False
            End If
            prompMessage(playerSelected)
        End If
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub pickMario_Click(sender As Object, e As EventArgs) Handles pickMario.Click
        selectMario = True
        pickTurn(True, 1)
    End Sub

    Private Sub pickLuigi_Click(sender As Object, e As EventArgs) Handles pickLuigi.Click
        selectLuigi = True
        pickTurn(True, 2)
    End Sub

    Private Sub pickPeach_Click(sender As Object, e As EventArgs) Handles pickPeach.Click
        selectPeach = True
        pickTurn(True, 3)
    End Sub

    Private Sub pickYoshi_Click(sender As Object, e As EventArgs) Handles pickYoshi.Click
        selectYoshi = True
        pickTurn(True, 4)
    End Sub
End Class