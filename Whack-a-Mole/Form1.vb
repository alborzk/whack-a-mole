Public Class Form1
    'Alborz Khakbazan
    'Computer Science 20S
    'Whack a Mole

    'Declare game variables

    Dim score As Integer
    Dim health As Integer = 5
    Dim healthCounter As Integer = 0
    Dim healthLoss As Integer = 3

    'Start screen

    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Play BGM
        My.Computer.Audio.Play(My.Resources.bgm,
        AudioPlayMode.BackgroundLoop)

    End Sub

    Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'Menu components
        btnStart.Visible = False
        btnNewGame.Visible = True
        btnQuit.Visible = True

    End Sub

    'Initialize game

    Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click

        picTitleBG.Visible = False
        picBackground.Visible = True
        btnNewGame.Visible = False
        btnQuit.Visible = False
        prgHealth.Visible = True
        lblScore.Visible = True

        tmrMole.Enabled = True

    End Sub

    'Generates random number between 1-12 and assigns it to 1 of 12 open mole positions

    Sub tmrMole_Tick(sender As Object, e As EventArgs) Handles tmrMole.Tick

        Randomize()
        Dim mole As Integer = CInt(Int((12 * Rnd()) + 1))
        Select Case mole
            Case 1
                picMoleyA1.Visible = True
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 2
                picMoleyA1.Visible = False
                picMoleyA2.Visible = True
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 3
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = True
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 4
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = True
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 5
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = True
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 6
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = True
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 7
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = True
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 8
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = True
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 9
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = True
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 10
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = True
                picMoleyD2.Visible = False
                picMoleyD3.Visible = False
            Case 11
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = True
                picMoleyD3.Visible = False
            Case 12
                picMoleyA1.Visible = False
                picMoleyA2.Visible = False
                picMoleyA3.Visible = False
                picMoleyB1.Visible = False
                picMoleyB2.Visible = False
                picMoleyB3.Visible = False
                picMoleyC1.Visible = False
                picMoleyC2.Visible = False
                picMoleyC3.Visible = False
                picMoleyD1.Visible = False
                picMoleyD2.Visible = False
                picMoleyD3.Visible = True
        End Select

    End Sub

    'Timer to control health mechanics (-1 health if mole is not caught)

    Sub tmrHealth_Tick(sender As Object, e As EventArgs) Handles tmrHealth.Tick
        healthCounter = healthCounter + 1
        If healthCounter = healthLoss Then
            health = health - 1
            prgHealth.Value = health
            healthCounter = 0
        End If

    End Sub

    'Timer to control game mechanics (Always checking)

    Sub tmrControl_Tick(sender As Object, e As EventArgs) Handles tmrControl.Tick

        If picMoleyA1.Visible = True Or picMoleyA2.Visible = True Or picMoleyA3.Visible = True Or
            picMoleyB1.Visible = True Or picMoleyB2.Visible = True Or picMoleyB3.Visible = True Or
           picMoleyC1.Visible = True Or picMoleyC2.Visible = True Or picMoleyC3.Visible = True Or
           picMoleyD1.Visible = True Or picMoleyD2.Visible = True Or picMoleyD3.Visible = True Then

            tmrHealth.Enabled = True
        End If

        Select Case score
            'Controls speed up mechanic, moles appear faster depending on score
            Case >= 25
                tmrMole.Interval = 2000
                healthLoss = 2
            Case >= 50
                tmrMole.Interval = 1000
                healthLoss = 1
        End Select

        If prgHealth.Value = 0 Then
            'Controls losing mechanic, if health runs out
            tmrMole.Enabled = False
            tmrHealth.Enabled = False
            tmrControl.Enabled = False
            MessageBox.Show("Oops! You ran out of health and lost!
Better luck next time!")
            Application.Exit()
        End If

    End Sub

    'Mole disappears when clicked

    Sub MoleClicked() Handles picMoleyA1.Click, picMoleyA2.Click, picMoleyA3.Click, picMoleyB1.Click, picMoleyB2.Click, picMoleyB3.Click,
        picMoleyC1.Click, picMoleyC2.Click, picMoleyC3.Click, picMoleyD1.Click, picMoleyD2.Click, picMoleyD3.Click

        healthCounter = 0
        tmrHealth.Enabled = False
        score = score + 1
        lblScore.Text = score
        picMoleyA1.Visible = False
        picMoleyA2.Visible = False
        picMoleyA3.Visible = False
        picMoleyB1.Visible = False
        picMoleyB2.Visible = False
        picMoleyB3.Visible = False
        picMoleyC1.Visible = False
        picMoleyC2.Visible = False
        picMoleyC3.Visible = False
        picMoleyD1.Visible = False
        picMoleyD2.Visible = False
        picMoleyD3.Visible = False

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        'Quits game when clicked
        My.Computer.Audio.Play(My.Resources.quit,
        AudioPlayMode.WaitToComplete)
        Application.Exit()

    End Sub

End Class
