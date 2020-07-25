Public Class Settings
    

    Private Sub chkGatherImage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGatherImage.CheckedChanged
        
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkSound.Checked = False
        grpSound.Enabled = False
        cmbDelay.SelectedIndex = 0
        SlideDelay = 1000
        If My.Settings.IsGatherImage = True Then
            chkGatherImage.Checked = True
        ElseIf My.Settings.IsGatherImage = False Then
            chkGatherImage.Checked = False

        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim openSound As New OpenFileDialog
        openSound.Title = "Select a sound file"
        openSound.Filter = "Sound Files (*.mp3, *.mid, *.wav, *wma|*.mp3; *.mid; *.wav; *wma"
        Try
            If openSound.ShowDialog = DialogResult.OK Then
                SoundPath = openSound.FileName
                txtSound.Text = SoundPath
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured ." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub chkSound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSound.CheckedChanged
        If chkSound.Checked = True Then
            grpSound.Enabled = True
            Sound = True
        ElseIf chkSound.Checked = False Then
            grpSound.Enabled = False
            Sound = False
        End If
    End Sub

    Private Sub lnlblCustom_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnlblCustom.LinkClicked
        On Error Resume Next
        Dim delay As Integer = InputBox("Type in the seconds value for slideshow delay.", "Slideshow Delay")
        SlideDelay = delay * 1000

    End Sub

    Private Sub cmbDelay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDelay.SelectedIndexChanged
        SlideDelay = (cmbDelay.SelectedIndex + 1) * 1000

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If TabControl1.SelectedIndex = 0 Then
            If chkGatherImage.Checked = True Then
                My.Settings.IsGatherImage = True
            ElseIf chkGatherImage.Checked = False Then
                My.Settings.IsGatherImage = False
            End If
        ElseIf TabControl1.SelectedIndex = 1 Then
            isOK = True

        End If
        Me.Close()

    End Sub

    Private Sub txtSound_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSound.TextChanged

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        isOK = False
        Me.Close()

    End Sub
End Class