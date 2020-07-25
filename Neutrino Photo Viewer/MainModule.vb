Module MainModule
    Public SlideDelay As Integer = 1000
    Public Sound As Boolean
    Public SoundPath As String = vbNullString
    Public isOK As Boolean

    Public soundToPlay As String

    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Public Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
      (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As _
          Integer, ByVal hwndCallback As Integer) As Integer

    Public Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam _
As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    '____ Sound Options _____'

    Sub loadAndSetSoundFile(ByVal soundPath As String)

        soundToPlay = soundPath

        Dim fileToPlay As String = Chr(34) + (soundPath) + Chr(34)

        mciSendString("close soundFile", Nothing, 0, 0)

        mciSendString("open " & fileToPlay & " alias soundFile", Nothing, 0, 0)

    End Sub

    Sub playSoundFile()

        mciSendString("play soundFile", Nothing, 0, 0)

    End Sub

    Sub stopSound()

        If mediaIsPlaying() Then

            mciSendString("stop soundFile", Nothing, 0, 0)

        End If

    End Sub

    Sub pausePlay()

        If mediaIsPlaying() Then

            mciSendString("pause soundFile", Nothing, 0, 0)

        End If

    End Sub

    Sub resumePlay()

        mciSendString("resume soundFile", Nothing, 0, 0)

    End Sub

    Function mediaIsPlaying() As Boolean

        Dim stat As String = Space(128)

        mciSendString("status soundFile mode", stat, 128, 0)

        If stat.StartsWith("playing") Then

            Return True

        Else

            Return False

        End If

        stat = Nothing

    End Function

    '___ Set Background _________'

    Public Sub SetWallpaper(ByVal Wallpaper As Object)
        Dim Background As System.Drawing.Image = Nothing
        Dim Location As String = Environment.SystemDirectory & "\CurrentWallpaper.Bmp"
        Try
            Try
                If TypeOf Wallpaper Is String Then
                    Background = System.Drawing.Image.FromFile(Wallpaper)
                ElseIf TypeOf Wallpaper Is Image Then
                    Background = Wallpaper
                End If
            Catch ex As Exception
                MsgBox("An error occured." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            End Try
            Background.Save(Location, System.Drawing.Imaging.ImageFormat.Bmp)
            SystemParametersInfo(&H14, 0, Location, &H1 Or &H2)
        Catch ex As Exception
            MsgBox("An error occured." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
        
    End Sub

End Module
