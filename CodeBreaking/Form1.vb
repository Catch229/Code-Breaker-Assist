Imports System.Runtime.InteropServices

Public Class Form1
    Dim CrkRunning As Boolean = False
    Private WithEvents kbHook As New KeyboardHook
    Dim Ikey As Integer
    Dim Setup As Boolean = True
    Dim allowInput As Boolean = False
    Dim Input As String
    Dim Guess As Integer = -1
    Dim Hi As Integer
    Dim Low As Integer
    Dim Steps As Integer = 0
    Dim Kbd As Byte() = {&H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37, &H38, &H39}
    Dim Start_time As DateTime
    Dim End_time As DateTime
    Dim Elapsed_time As TimeSpan

    Private Sub EnableBtn_Click(sender As Object, e As EventArgs) Handles EnableBtn.Click
        ToggleState()
    End Sub

    Public Sub ToggleState()
        CrkRunning = Not CrkRunning
        If CrkRunning Then
            EnableBtn.BackColor = Color.LightGreen
            OutputInfo("ENABLED.")
        Else
            EnableBtn.BackColor = Color.Salmon
            OutputInfo("DISABLED.")
        End If
        Input = Nothing
        Setup = True
        Steps = 0
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If CrkRunning Then
            If Setup Then
                If Integer.TryParse(Key.ToString().Last(), Ikey) And allowInput Then
                    Input = Input & Ikey
                    OutputInfo(Ikey & " entered.")
                ElseIf Key = &H25 And Not allowInput Then
                    allowInput = True
                ElseIf Key = &H25 And allowInput Then
                    allowInput = False
                    Setup = False
                    Integer.TryParse(Input, Ikey)
                    OutputInfo("Maximum Number: " & Ikey)
                    Hi = Ikey + 1
                    Low = 0
                    Guess = 0
                    Start_time = Now
                End If
            Else
                If Key = &H26 Then
                    CalcGuess(True)
                ElseIf Key = &H28 Then
                    CalcGuess(False)
                End If
            End If
        End If
    End Sub

    Public Sub CalcGuess(higher As Boolean)
        Steps = Steps + 1
        If higher Then
            Low = Guess
            OutputInfo("Higher")
            Guess = CInt(Math.Floor((Guess + Hi) / 2))
            OutputInfo("Guessing: " & Guess.ToString())
            KeyboardOut(Guess)
        Else
            OutputInfo("Lower")
            Hi = Guess
            Guess = CInt(Math.Floor((Guess + Low) / 2))
            OutputInfo("Guessing: " & Guess.ToString())
            KeyboardOut(Guess)
        End If
        If Guess = Hi Or Guess = Low Or ((Low + 2) = Hi) Then
            End_time = Now
            Elapsed_time = End_time.Subtract(Start_time)
            OutputInfo("Time: " & Elapsed_time.TotalSeconds.ToString("0.000") & "s  " & "Steps: " & Steps & "  Answer: " & Guess)
            ToggleState()
        End If
    End Sub

    <DllImport("user32.dll", CallingConvention:=CallingConvention.StdCall,
           CharSet:=CharSet.Unicode, EntryPoint:="keybd_event",
           ExactSpelling:=True, SetLastError:=True)>
    Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte,
                                  ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    End Sub

    Public Sub KeyboardOut(Num As Integer)
        Dim StringNum As String = Num.ToString()
        Dim Value As Integer
        For Each C As Char In StringNum
            Value = (Convert.ToInt32(C)) - 48
            'OutputInfo(Value.ToString())
            keybd_event(Kbd(Value), &H45, 0, 0)   ' Generates a KEY_DOWN
            keybd_event(Kbd(Value), &H45, &H2, 0) ' Generates a KEY_UP
        Next

        keybd_event(&HD, &H45, 0, 0)   ' Generates a KEY_DOWN
        keybd_event(&HD, &H45, &H2, 0) ' Generates a KEY_UP

    End Sub

    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        OutputInfo("This program will help you to crack number games that allow for keyboard input.")
        OutputInfo("To get started you press 'Enable/Disable' this will set the program to look for input.")
        OutputInfo("After pressing 'Enable/Disable' press the LEFT arrow key to begin entering the maximum number.")
        OutputInfo("After entering the maximum number press the LEFT arrow again.")
        OutputInfo("Now when you press the UP arrow key the program will begin guessing automatically.")
        OutputInfo("All you need to do is press UP and DOWN if it needs to guess higher or lower.")
        OutputInfo("Have fun cracking! Only use this for approved activities.")

    End Sub

    Public Sub OutputInfo(info As String)
        OutputBox.AppendText(Environment.NewLine & "[" & Format(DateAndTime.Now(), ("hh:mm:ss")) & "] " & info)
    End Sub

End Class
