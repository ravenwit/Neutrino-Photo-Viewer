Imports ComponentFactory.Krypton.Toolkit.KryptonForm
Imports ComponentFactory.Krypton.Docking
Imports ComponentFactory.Krypton.Navigator
Public Class Photo__Editor
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm


    'Resize Staff
    Public Percentage As Integer
    'Crop Staff
    Dim NewArea As New System.Drawing.Point()
    Dim X, Y As Integer

    Public CroppedImage As Image
    Public ReCroppedImage As Bitmap

    Dim CropForm As New Form
    Dim CropPicture As New PictureBox

    Public Function CreateCrop()
        picCrop.Visible = False

        CropForm.TransparencyKey = Color.Black
        CropForm.BackColor = Color.Black
        CropForm.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        CropForm.StartPosition = Windows.Forms.FormStartPosition.WindowsDefaultBounds
        CropForm.MaximizeBox = True
        CropForm.MinimizeBox = False
        CropForm.ShowInTaskbar = False
        CropForm.Size = New Size(300, 300)

        picCrop.BackColor = Color.Black
        picCrop.Dock = DockStyle.Fill

        ' CropForm.Controls.Add(ToolStrip1)
        CropForm.Controls.Add(picCrop)

        CropForm.ShowIcon = False

        CType(CropForm.Controls.Item(0), ToolStrip).Visible = True
        Neutrino_Photo_Viewer.IsMdiContainer = True

        CropForm.MdiParent = Neutrino_Photo_Viewer

        CropForm.Show()

        Return 0
    End Function


    Public Function CaptureImage(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer)
        Dim AreaPicture As New System.Drawing.Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(AreaPicture)
        G.CopyFromScreen(New Point(X, Y), New Point(0, 0), AreaPicture.Size)
        G.Dispose()
        Return AreaPicture
    End Function

    Private Sub Photo_Editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radOriginal.Checked = True
        radStandard.Checked = False
        cmbStandard.Enabled = False
        radCustom.Checked = False
        grpCustom.Enabled = False
        radPercentage.Checked = False
        grpPercentage.Enabled = False
        Timer1.Enabled = True
        Timer1.Interval = 100

        KryptonNavigator1.SelectedIndex = 0
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Me.BackColor = Color.WhiteSmoke
        Me.Size = New Size(491, 416)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If KryptonNavigator1.SelectedIndex = 0 Then
            If radOriginal.Checked = True Then
                'Do Nothing
            ElseIf radStandard.Checked = True Then
                Select Case cmbStandard.SelectedIndex
                    Case Is < 0
                        MsgBox("Please select a standard type of size from the combo box.", MsgBoxStyle.Exclamation, "Select")
                    Case 0
                        WidthPic = 1024
                        HeightPic = 768
                    Case 1
                        WidthPic = 800
                        HeightPic = 600
                    Case 2
                        WidthPic = 640
                        HeightPic = 480
                    Case 3
                        WidthPic = 448
                        HeightPic = 336
                    Case 4
                        WidthPic = 314
                        HeightPic = 235
                    Case 5
                        WidthPic = 160
                        HeightPic = 160
                End Select
            ElseIf radCustom.Checked = True Then
                If numWidth.Value > 0 And numHeight.Value > 0 Then
                    WidthPic = numWidth.Value
                    HeightPic = numHeight.Value
                Else
                    MsgBox("Please enter valid value.", MsgBoxStyle.Exclamation)
                End If
            ElseIf radPercentage.Checked = True Then
                If numPercentage.Value > 0 Then
                    Percentage = numPercentage.Value

                    WidthPic = (OriWidth / 100) * Percentage
                    HeightPic = (OriHeight / 100) * Percentage
                Else
                    MsgBox("Please enter a valid value.", MsgBoxStyle.Exclamation)
                End If

            End If

            Dim ResizedPic As New Bitmap(Neutrino_Photo_Viewer.PictureBox1.Image, New Size(WidthPic, HeightPic))
            Neutrino_Photo_Viewer.PictureBox1.Image = ResizedPic
        ElseIf KryptonNavigator1.SelectedIndex = 1 Then

            If chkCropOpt.Checked = True Then
                Neutrino_Photo_Viewer.PictureBox1.Image = Me.picCrop.Image
            ElseIf chkCropOpt.Checked = False Then
                Neutrino_Photo_Viewer.PictureBox1.Image = Me.picCrop.Image

            End If

        End If
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub radStandard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStandard.CheckedChanged
        If radStandard.Checked = True Then
            cmbStandard.Enabled = True
        ElseIf radStandard.Checked = False Then
            cmbStandard.Enabled = False

        End If
    End Sub

    Private Sub radOriginal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub radCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCustom.CheckedChanged
        If radCustom.Checked = True Then
            grpCustom.Enabled = True
        ElseIf radCustom.Checked = False Then
            grpCustom.Enabled = False

        End If
    End Sub

    Private Sub radPercentage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPercentage.CheckedChanged
        If radPercentage.Checked = True Then
            grpPercentage.Enabled = True
        ElseIf radPercentage.Checked = False Then
            grpPercentage.Enabled = False

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        lblOriginal.Text = ("Original Size :  " & OriWidth.ToString & " X " & OriHeight.ToString & "  px").ToString
        lblNewSize.Text = ("New Size :  " & WidthPic.ToString & " X " & HeightPic.ToString & "  px").ToString


    End Sub

    Private Sub cmbStandard_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStandard.SelectedIndexChanged
        Select Case cmbStandard.SelectedIndex
            Case Is < 0
                MsgBox("Please select a standard type of size from the combo box.", MsgBoxStyle.Exclamation, "Select")
            Case 0
                WidthPic = 1024
                HeightPic = 768
            Case 1
                WidthPic = 800
                HeightPic = 600
            Case 2
                WidthPic = 640
                HeightPic = 480
            Case 3
                WidthPic = 448
                HeightPic = 336
            Case 4
                WidthPic = 314
                HeightPic = 235
            Case 5
                WidthPic = 160
                HeightPic = 160
        End Select
    End Sub

    Private Sub numWidth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numWidth.ValueChanged
        If numWidth.Value > 0 Then
            WidthPic = numWidth.Value

        Else
            MsgBox("Please enter valid value.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub numHeight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numHeight.ValueChanged
        If numHeight.Value > 0 Then

            HeightPic = numHeight.Value
        Else
            MsgBox("Please enter valid value.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub numPercentage_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numPercentage.ValueChanged
        If numPercentage.Value > 0 Then
            Percentage = numPercentage.Value

            WidthPic = (OriWidth / 100) * Percentage
            HeightPic = (OriHeight / 100) * Percentage
        Else
            MsgBox("Please enter a valid value.", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Private Sub picCrop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub picCrop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CropForm.Hide()

        CroppedImage = CaptureImage(CropForm.Location.X, CropForm.Location.Y, CropForm.ClientSize.Width, CropForm.ClientSize.Height)
        ReCroppedImage = New Bitmap(CroppedImage, New Size(OriWidth, OriHeight))

        Me.Controls.Add(picCrop)
        Me.picCrop.Size = New Size(456, 124)
        Me.picCrop.Location = New Point(11, 91)

        Me.picCrop.BackColor = Color.White

        If chkCropOpt.Checked = True Then
            Me.picCrop.Image = ReCroppedImage
            WidthPic = ReCroppedImage.Size.Width
            HeightPic = ReCroppedImage.Size.Height
        ElseIf chkCropOpt.Checked = False Then
            Me.picCrop.Image = CroppedImage
            WidthPic = CroppedImage.Size.Width
            HeightPic = CroppedImage.Size.Height
        End If


    End Sub

    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        Dim cropform As New Crop
        'cropform.MdiParent = Neutrino_Photo_Viewer
        cropform.Size = New Size(100, 100)
        cropform.MenuStrip1.Visible = True
        cropform.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.WindowState = FormWindowState.Minimized
        cropform.ShowDialog()
        cropform.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim cropform As New Crop
        'cropform.MdiParent = Neutrino_Photo_Viewer
        cropform.Size = New Size(100, 100)
        cropform.MenuStrip1.Visible = True
        cropform.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.WindowState = FormWindowState.Minimized
        cropform.ShowDialog()
        cropform.Focus()

    End Sub

    Private Sub chkCropOpt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCropOpt.CheckedChanged
        If chkCropOpt.Checked = True Then
            Me.picCrop.Image = MainModule.ReCroppedImage
            WidthPic = MainModule.ReCroppedImage.Size.Width
            HeightPic = MainModule.ReCroppedImage.Size.Height
        ElseIf chkCropOpt.Checked = False Then
            Me.picCrop.Image = MainModule.CroppedImage
            WidthPic = MainModule.CroppedImage.Size.Width
            HeightPic = MainModule.CroppedImage.Size.Height
        End If
    End Sub
End Class