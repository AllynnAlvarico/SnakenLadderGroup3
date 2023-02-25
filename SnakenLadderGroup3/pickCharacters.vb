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
        End If
    End Sub
    Public Sub chosenCharacters(chosen As Integer)
        If playerDict.ContainsKey(chosen) Then
            Console.WriteLine("player 1 have chosen: " & playerDict.Item(chosen))
            '"myDictionary.Item(myParameter) gets the value of the key
            'this will allow you to be able to call or show the value in the dictionary
        End If
    End Sub
    Public Sub pickTurn()
        If player1Turn = True Then
            If selectMario = True Then
                player1 = 1
                player1Turn = False
                player2Turn = True
            ElseIf selectLuigi = True Then
                player1 = 2
                player1Turn = False
                player2Turn = True
            ElseIf selectPeach = True Then
                player1 = 3
                player1Turn = False
                player2Turn = True
            ElseIf selectYoshi = True Then
                player1 = 4
                player1Turn = False
                player2Turn = True
            End If
            prompMessage(player1)
        End If

        player2Turn = False


        If player2Turn = True Then
            If selectMario = True Then
                player2 = 1
                player1Turn = False
                player2Turn = False
            ElseIf selectLuigi = True Then
                player1 = 2
                player1Turn = False
                player2Turn = False
            ElseIf selectPeach = True Then
                player1 = 3
                player1Turn = False
                player2Turn = False
            ElseIf selectYoshi = True Then
                player1 = 4
                player1Turn = False
                player2Turn = False
            End If
            prompMessage(player2)
        End If
    End Sub
    Public Sub New()
        InitializeComponent()
        player1Turn = True
        player2Turn = False
    End Sub
    Private Sub pickMario_Click(sender As Object, e As EventArgs) Handles pickMario.Click
        selectMario = True
        pickTurn()
    End Sub

    Private Sub pickLuigi_Click(sender As Object, e As EventArgs) Handles pickLuigi.Click
        selectLuigi = True
        pickTurn()
    End Sub

    Private Sub pickPeach_Click(sender As Object, e As EventArgs) Handles pickPeach.Click
        selectPeach = True
        pickTurn()
    End Sub

    Private Sub pickYoshi_Click(sender As Object, e As EventArgs) Handles pickYoshi.Click
        selectYoshi = True
        pickTurn()
    End Sub
End Class