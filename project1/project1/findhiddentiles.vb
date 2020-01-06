Public Class findhiddentiles
    Dim pick1 As Integer
    Dim pick2 As Integer
    Dim pick3 As Integer
    Dim clicks As Integer = 0
    Dim timerValue As Integer = 3000
    Dim totalRight As Integer = 0
    Dim totalWrong As Integer = 0
    Dim winningScore As Integer = 0


    ' STARTING THE GAME AND TIMER
    ' DISABLE BUTTONS AS REQUIRMENT
    Private Sub random_Click(sender As Object, e As EventArgs) Handles random.Click
        clear()

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Label3.Text = " "
        Label4.Text = " "
        Label5.Text = " "
        random.Enabled = False

        Timer1.Interval = timerValue
        Label1.Text = "TIMER IS ON "
        Timer1.Start()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False

        ' CREATING 3 RANDOM RED COLORS IN 9 TILES
        Dim random_number As Random = New Random
        pick1 = random_number.Next(1, 10)
        Do
            pick2 = random_number.Next(1, 10)

        Loop While pick1 = pick2
        Do
            pick3 = random_number.Next(1, 10)

        Loop While pick3 = pick1 Or pick3 = pick2

        ' FIRST RANDOM RED
        If pick1 = 1 Then
            Button1.BackColor = Color.Red
        End If
        If pick1 = 2 Then
            Button2.BackColor = Color.Red
        End If
        If pick1 = 3 Then
            Button3.BackColor = Color.Red
        End If
        If pick1 = 4 Then
            Button4.BackColor = Color.Red
        End If
        If pick1 = 5 Then
            Button5.BackColor = Color.Red
        End If
        If pick1 = 6 Then
            Button6.BackColor = Color.Red
        End If
        If pick1 = 7 Then
            Button7.BackColor = Color.Red
        End If
        If pick1 = 8 Then
            Button8.BackColor = Color.Red
        End If
        If pick1 = 9 Then
            Button9.BackColor = Color.Red
        End If

        ' SECOND RANDOM RED 
        If pick2 = 1 Then
            Button1.BackColor = Color.Red
        End If
        If pick2 = 2 Then
            Button2.BackColor = Color.Red
        End If
        If pick2 = 3 Then
            Button3.BackColor = Color.Red
        End If
        If pick2 = 4 Then
            Button4.BackColor = Color.Red
        End If
        If pick2 = 5 Then
            Button5.BackColor = Color.Red
        End If
        If pick2 = 6 Then
            Button6.BackColor = Color.Red
        End If
        If pick2 = 7 Then
            Button7.BackColor = Color.Red
        End If
        If pick2 = 8 Then
            Button8.BackColor = Color.Red
        End If
        If pick2 = 9 Then
            Button9.BackColor = Color.Red
        End If

        ' THIRD RANDOM RED
        If pick3 = 1 Then
            Button1.BackColor = Color.Red
        End If
        If pick3 = 2 Then
            Button2.BackColor = Color.Red
        End If
        If pick3 = 3 Then
            Button3.BackColor = Color.Red
        End If
        If pick3 = 4 Then
            Button4.BackColor = Color.Red
        End If
        If pick3 = 5 Then
            Button5.BackColor = Color.Red
        End If
        If pick3 = 6 Then
            Button6.BackColor = Color.Red
        End If
        If pick3 = 7 Then
            Button7.BackColor = Color.Red
        End If
        If pick3 = 8 Then
            Button8.BackColor = Color.Red
        End If
        If pick3 = 9 Then
            Button9.BackColor = Color.Red
        End If
    End Sub

    ' TIMER IS OFF AND TILES ARE COVERD IN BLACK AND ENABLED
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "TIME IS DONE"
        Timer1.Stop()
        Button1.BackColor = Color.Black
        Button2.BackColor = Color.Black
        Button3.BackColor = Color.Black
        Button4.BackColor = Color.Black
        Button5.BackColor = Color.Black
        Button6.BackColor = Color.Black
        Button7.BackColor = Color.Black
        Button8.BackColor = Color.Black
        Button9.BackColor = Color.Black

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

    End Sub
    ' CLEAR FUNCTION TO REST COLORS
    Private Sub clear()
        Button1.BackColor = Color.Black
        Button2.BackColor = Color.Black
        Button3.BackColor = Color.Black
        Button4.BackColor = Color.Black
        Button5.BackColor = Color.Black
        Button6.BackColor = Color.Black
        Button7.BackColor = Color.Black
        Button8.BackColor = Color.Black
        Button9.BackColor = Color.Black

    End Sub
    ' CHECKING BUTTONS FOR RED SELECTION AND SETTING [ O OR X ] AND COUNTERS FOR RESULTS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If pick1 = 1 Or pick2 = 1 Or pick3 = 1 Then
            Button1.BackColor = Color.Red
            Button1.Text = " O "
            Button1.Enabled = False
            totalRight += 1
        Else
            Button1.BackColor = Color.Blue
            Button1.Text = " X "
            totalWrong += 1
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If pick1 = 2 Or pick2 = 2 Or pick3 = 2 Then
            Button2.BackColor = Color.Red
            Button2.Text = " O "
            Button2.Enabled = False
            totalRight += 1

        Else
            Button2.BackColor = Color.Blue
            Button2.Text = " X "
            totalWrong += 1
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If pick1 = 3 Or pick2 = 3 Or pick3 = 3 Then
            Button3.BackColor = Color.Red
            Button3.Text = " O "
            Button3.Enabled = False
            totalRight += 1

        Else
            Button3.BackColor = Color.Blue
            Button3.Text = " X "
            totalWrong += 1
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If pick1 = 4 Or pick2 = 4 Or pick3 = 4 Then
            Button4.BackColor = Color.Red
            Button4.Text = " O "
            Button4.Enabled = False
            totalRight += 1

        Else
            Button4.BackColor = Color.Blue
            Button4.Text = " X "
            totalWrong += 1
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If pick1 = 5 Or pick2 = 5 Or pick3 = 5 Then
            Button5.BackColor = Color.Red
            Button5.Text = " O "
            Button5.Enabled = False
            totalRight += 1

        Else
            Button5.BackColor = Color.Blue
            Button5.Text = " X "
            totalWrong += 1
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If pick1 = 6 Or pick2 = 6 Or pick3 = 6 Then
            Button6.BackColor = Color.Red
            Button6.Text = " O "
            Button6.Enabled = False
            totalRight += 1

        Else
            Button6.BackColor = Color.Blue
            Button6.Text = " X "
            totalWrong += 1
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If pick1 = 7 Or pick2 = 7 Or pick3 = 7 Then
            Button7.BackColor = Color.Red
            Button7.Text = " O "
            Button7.Enabled = False
            totalRight += 1

        Else
            Button7.BackColor = Color.Blue
            Button7.Text = " X "
            totalWrong += 1
            Button7.Enabled = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If pick1 = 8 Or pick2 = 8 Or pick3 = 8 Then
            Button8.BackColor = Color.Red
            Button8.Text = " O "
            Button8.Enabled = False
            totalRight += 1

        Else
            Button8.BackColor = Color.Blue
            Button8.Text = " X "
            totalWrong += 1
            Button8.Enabled = False
        End If
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If pick1 = 9 Or pick2 = 9 Or pick3 = 9 Then
            Button9.BackColor = Color.Red
            Button9.Text = " O "
            Button9.Enabled = False
            totalRight += 1

        Else
            Button9.BackColor = Color.Blue
            Button9.Text = " X "
            totalWrong += 1
            Button9.Enabled = False
        End If
    End Sub
    ' BUTTONS CLICK SENDERS
    Private Sub clicking(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        Dim btn As Button = sender
        clickstotal(btn.Tag)

    End Sub

    ' TOTALS AND TIMER REST 
    Private Sub clickstotal(coin As Decimal)

        Label4.Text = " worng answer " & totalWrong

        Label5.Text = " right answer " & totalRight

        clicks = clicks + 1
        Label3.Text = " " & clicks

        If totalRight = 3 Then
            winningScore += 1
            score.Text = " Your Score is = " & winningScore

        End If
        If clicks = 3 Then
            If totalRight = 3 And timerValue > 1000 Then
                timerValue -= 1000
            End If
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            clicks = 0
            totalWrong = 0
            totalRight = 0
            random.Enabled = True
        End If

    End Sub

End Class
