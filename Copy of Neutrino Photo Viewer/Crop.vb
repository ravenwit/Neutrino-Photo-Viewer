Public Class Crop
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    Dim NewArea As New System.Drawing.Point()
    Dim X, Y As Integer

    Public Function CaptureImage(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer)
        Dim AreaPicture As New System.Drawing.Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(AreaPicture)
        G.CopyFromScreen(New Point(X, Y), New Point(0, 0), AreaPicture.Size)
        G.Dispose()
        Return AreaPicture
    End Function

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrop.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        MenuStrip1.Visible = False

        MainModule.CroppedImage = CaptureImage(Me.Location.X, Me.Location.Y, Me.ClientSize.Width, Me.ClientSize.Height)
        MainModule.ReCroppedImage = New Bitmap(CroppedImage, New Size(OriWidth, OriHeight))

        If Photo__Editor.chkCropOpt.Checked = True Then
            Photo__Editor.picCrop.Image = MainModule.ReCroppedImage
            WidthPic = MainModule.ReCroppedImage.Size.Width
            HeightPic = MainModule.ReCroppedImage.Size.Height
        ElseIf Photo__Editor.chkCropOpt.Checked = False Then
            Photo__Editor.picCrop.Image = MainModule.CroppedImage
            WidthPic = MainModule.CroppedImage.Size.Width
            HeightPic = MainModule.CroppedImage.Size.Height
        End If
        Me.Close()

        Photo__Editor.WindowState = FormWindowState.Normal
        Photo__Editor.Focus()

    End Sub

    Private Sub picCrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCrop.Click

    End Sub

    Private Sub picCrop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCrop.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub picCrop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCrop.MouseMove
        If e.Button = MouseButtons.Left Then
            NewArea = Control.MousePosition
            NewArea.X -= (X)
            NewArea.Y -= (Y)
            Me.Location = NewArea
        End If
    End Sub

    Private Sub btnCrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrop.Click

    End Sub

    Private Sub Crop_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       
    End Sub

    Private Sub Crop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class