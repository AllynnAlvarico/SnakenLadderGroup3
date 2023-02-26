Public Class pickCharacters
    Public playerDict As New Dictionary(Of Integer, String) From {
        {1, "Mario"},
        {2, "Luigi"},
        {3, "Peach"},
        {4, "Yoshi"}
    }
    Public player1Turn, player2Turn As Boolean
    Public p1_note, p2_note As String
    Public player1, player2, btnClicked, charSelected As Integer
    Public Sub New()
        InitializeComponent()
        p1_note = "Player 1 have chosen: "
        p2_note = "Player 2 have chosen: "
        player1Turn = True
        player2Turn = True
        gameDefault()
    End Sub
    Public Sub gameDefault()
        player1 = 0
        player2 = 0
        pickMario.Enabled = True
        pickLuigi.Enabled = True
        pickPeach.Enabled = True
        pickYoshi.Enabled = True
    End Sub
    Public Sub prompMessage(player As Integer)
        Dim defaultMessage = MessageBox.Show("Are you Sure?", "confirmation!", MessageBoxButtons.YesNo)
        If defaultMessage = DialogResult.Yes Then
            chosenCharacters(player)
        Else
            MessageBox.Show("No Character has been Choosen")
            gameDefault()
        End If
    End Sub
    Public Sub chosenCharacters(chosen As Integer)
        If playerDict.ContainsKey(chosen) Then
            Console.WriteLine(playerDict.Item(chosen))
            '"myDictionary.ContainsKey(myParameter)" this checks if key is present on the dictionary
            '"myDictionary.Item(myParameter)" gets the value of the key
            'this will allow you to be able to call or show the value in the dictionary
        End If
    End Sub

    Private Sub playerChoosingPhase(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Player 1" Then
            characterSelection(player1Turn, player1)
            player1Turn = False
            Console.WriteLine("hello player 1")
        ElseIf ComboBox1.SelectedItem = "Player 2" Then
            characterSelection(player2Turn, player2)
            player2Turn = False
            Console.WriteLine("hello player 2")
        Else
            Console.WriteLine("No player selected")
        End If
    End Sub
    Private Sub characterSelection(ByRef playerChange As Boolean, ByRef playerSelected As Integer)
        If playerChange = True Then
            Select Case btnClicked
                Case 1
                    charSelected = 1
                    pickMario.Enabled = False
                    Exit Select
                Case 2
                    charSelected = 2
                    pickLuigi.Enabled = False
                    Exit Select
                Case 3
                    charSelected = 3
                    pickPeach.Enabled = False
                    Exit Select
                Case 4
                    charSelected = 4
                    pickYoshi.Enabled = False
                    Exit Select
            End Select
        End If
        chosenCharacters(playerSelected)
        'prompMessage(playerSelected)
    End Sub

    Private Sub pickMario_Click(sender As Object, e As EventArgs) Handles pickMario.Click
        btnClicked = 1
        playerChoosingPhase(sender, e)
    End Sub

    Private Sub pickLuigi_Click(sender As Object, e As EventArgs) Handles pickLuigi.Click
        btnClicked = 2
        playerChoosingPhase(sender, e)
    End Sub

    Private Sub pickPeach_Click(sender As Object, e As EventArgs) Handles pickPeach.Click
        btnClicked = 3
        playerChoosingPhase(sender, e)
    End Sub

    Private Sub pickYoshi_Click(sender As Object, e As EventArgs) Handles pickYoshi.Click
        btnClicked = 4
        playerChoosingPhase(sender, e)
    End Sub
End Class