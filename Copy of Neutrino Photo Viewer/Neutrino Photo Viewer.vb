Imports System.Collections
Imports System.IO

Public Class Neutrino_Photo_Viewer
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    Dim filepath As String = vbNullString
    Dim filename As String = vbNullString
    Dim imagename As String
    Dim imagepath As String
    Dim ImageDirectory As String = vbNullString
    Dim imageofDirectory As New SortedList

    Dim imageform As New Form
    Dim PictureBox As New PictureBox
    Dim save As Integer = 1
    Dim isPause As Boolean = False

    Dim isFull As Boolean


    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
       (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As _
           Integer, ByVal hwndCallback As Integer) As Integer




    Private Sub OpenImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem.Click

        Dim openImage As New OpenFileDialog
        openImage.Title = "Open Image..."
        openImage.Filter = "All Files |*.*"
        Try
            If openImage.ShowDialog = DialogResult.OK Then
                PictureBox1.Image = System.Drawing.Image.FromFile(openImage.FileName)
                filepath = openImage.FileName
                filename = openImage.SafeFileName
                btnDeleteList.PerformClick()
                lblStatus.Text = "Gathering Image from Current Directory..."
                lblSsize.Text = ""
                lblImageName.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to open image. Please check your file format and try again." & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        'ToolStripButton16.PerformClick()
        Try
            If My.Settings.IsGatherImage = True Then
                ImageDirectory = filepath.Replace("\" & filename, "")
                lblStatus.Text = "Gathering Image from Current Directory..."

                For Each Me.imagepath In My.Computer.FileSystem.GetFiles(ImageDirectory)
                    If My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".jpg" Or _
                        My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".jpeg" Or _
                         My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".png" Or _
                          My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".bmp" Or _
                           My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".gif" Or _
                            My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".tiff" Or _
                             My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".emf" Or _
                              My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".exif" Or _
                               My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".wmf" Then

                        imagename = My.Computer.FileSystem.GetName(imagepath)

                        If Not imageofDirectory.ContainsKey(imagename) Then

                            imageofDirectory.Add(imagename, imagepath)
                            cmbImages.Items.Add(imagename)

                        End If

                    End If

                Next
                lblImageCounter.Text = "Photos In Current Directory (" & (imageofDirectory.Count).ToString & ") :"
                lblImageCounter.ToolTipText = "Current Directory has " & (imageofDirectory.Count.ToString) & " supported photo. "
                lblStatus.Text = ""
                cmbImages.SelectedIndex = imageofDirectory.IndexOfKey(openImage.SafeFileName)

            End If
        Catch es As Exception
            MsgBox(es.Message)
        End Try

    End Sub

    Private Sub SaveImageToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveImageToolStripMenuItem2.Click
        Try
            Dim ImageSource As String = (imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).ToString
            PictureBox1.Image.Save(ImageSource)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub SaveImageAsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveImageAsToolStripMenuItem1.Click
        Dim savefile As New SaveFileDialog
        savefile.Title = "Save Image - Neutrino Photo Viewer"
        savefile.FileName = filename
        savefile.Filter = "Joint Photographic Experts Group |*.jpeg | Joint Photographic Group |*.jpg |Graphics Interchange Format |*.gif | Bitmap |*.bmp | W3C Portable Network Graphics |*.png | Tagged Image File |*.tiff | Enhanced Metafile |*.emf | Exchangable Image Format |*.exif | Windows Metafile |*.wmf"
        Try
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again." & vbCrLf & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try


    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End

    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click

        Dim ImageSource As String = (imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).ToString

        Dim CopyImage As New SaveFileDialog
        CopyImage.Title = "Copy Photo To..."
        CopyImage.Filter = "All Files |*.*"
        CopyImage.FileName = My.Computer.FileSystem.GetFileInfo(ImageSource).Name
        CopyImage.OverwritePrompt = True
        CopyImage.RestoreDirectory = True

        Try
            If CopyImage.ShowDialog = DialogResult.OK Then
                System.IO.File.Copy(ImageSource, CopyImage.FileName)
                MsgBox((cmbImages.SelectedItem & " has been successfully copied to " & My.Computer.FileSystem.GetFileInfo(CopyImage.FileName).DirectoryName).ToString, MsgBoxStyle.OkOnly, "Move Successful")

            End If
        Catch ex As Exception
            MsgBox("An error occured" & vbCrLf & ex.Message, , "Error")
        End Try

    End Sub

    Private Sub PasteAImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteAImageToolStripMenuItem.Click
        Try
            If My.Computer.Clipboard.GetDataObject.GetDataPresent(DataFormats.Bitmap) Then
                Me.PictureBox1.Image = My.Computer.Clipboard.GetDataObject()
            End If

        Catch ex As Exception
            MsgBox("Sorry! An error occured." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.None

        NormalToolStripMenuItem.Checked = True
        StrechToolStripMenuItem.Checked = False
        AutoSizeToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = False

        Normal1.Checked = True
        Stretch1.Checked = False
        AutoSize1.Checked = False
        Center1.Checked = False
        Zoom1.Checked = False

        PictureBox1.Refresh()


    End Sub

    Private Sub StrechToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrechToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.Stretch
        NormalToolStripMenuItem.Checked = False
        StrechToolStripMenuItem.Checked = True
        AutoSizeToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = False
        Normal1.Checked = False
        Stretch1.Checked = True
        AutoSize1.Checked = False
        Center1.Checked = False
        Zoom1.Checked = False

        PictureBox1.Refresh()

    End Sub

    Private Sub AutoSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoSizeToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.Tile
        NormalToolStripMenuItem.Checked = False
        StrechToolStripMenuItem.Checked = False
        AutoSizeToolStripMenuItem.Checked = True
        CenterToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = False
        Normal1.Checked = False
        Stretch1.Checked = False
        AutoSize1.Checked = True
        Center1.Checked = False
        Zoom1.Checked = False

        PictureBox1.Refresh()

    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.Center
        NormalToolStripMenuItem.Checked = False
        StrechToolStripMenuItem.Checked = False
        AutoSizeToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = True
        ZoomToolStripMenuItem.Checked = False
        Normal1.Checked = False
        Stretch1.Checked = False
        AutoSize1.Checked = False
        Center1.Checked = True
        Zoom1.Checked = False

        PictureBox1.Refresh()

    End Sub

    Private Sub ZoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.Zoom
        NormalToolStripMenuItem.Checked = False
        StrechToolStripMenuItem.Checked = False
        AutoSizeToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = True
        Normal1.Checked = False
        Stretch1.Checked = False
        AutoSize1.Checked = False
        Center1.Checked = False
        Zoom1.Checked = True

        PictureBox1.Refresh()

    End Sub

    Private Sub MainWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        If StatusBarToolStripMenuItem.Checked = True Then
            StatusBarToolStripMenuItem.Checked = False
            StatusStrip1.Visible = False

        ElseIf StatusBarToolStripMenuItem.Checked = False Then
            StatusBarToolStripMenuItem.Checked = True
            StatusStrip1.Visible = True

        End If
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullScreenToolStripMenuItem.Click
        imageform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        imageform.WindowState = FormWindowState.Maximized
        imageform.BackColor = Color.Black
        PictureBox.Dock = DockStyle.Fill
        PictureBox.BackColor = Color.Black
        PictureBox.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox.Image = Me.PictureBox1.Image
        imageform.Controls.Add(PictureBox)

        imageform.Show()

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        imageform.Close()
    End Sub

    Private Sub AboutNeutrinoScreenCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutNeutrinoScreenCaptureToolStripMenuItem.Click
        About_Neutrino_Photo_Viewer.Show()

    End Sub

    Private Sub OpenToolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolButton.Click
        OpenImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SaveImageToolStripMenuItem2.PerformClick()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        SaveImageAsToolStripMenuItem1.PerformClick()
        CopyToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click
        PasteAImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePhoto.Click
        DeleteImageToolStripMenuItem2.PerformClick()

    End Sub

    Private Sub DeleteImageToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteImageToolStripMenuItem2.Click
        Dim ImageSource As String = (imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).ToString
        Dim Filename As String = My.Computer.FileSystem.GetFileInfo(ImageSource).Name

        Dim conf = MsgBox("Are you sure you want to delete this photo ?", MsgBoxStyle.YesNo, "Delete File")
        If conf = vbYes Then
            imageofDirectory.Remove(cmbImages.SelectedItem)
            cmbImages.Items.Remove(cmbImages.SelectedItem)
            Me.PictureBox1.Image = Nothing
            PictureBox1.Image = Nothing
            System.IO.File.Delete(ImageSource)
            btnRefreshList.PerformClick()
        ElseIf conf = vbNo Then
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        PrintImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub PrintImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintImageToolStripMenuItem.Click

        Dim image As System.Drawing.Image
        image = Me.PictureBox1.Image
        If IsNothing(PictureBox1.Image) = False Then
            imageform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            imageform.BackColor = Color.White
            imageform.WindowState = FormWindowState.Maximized
            PictureBox.SizeMode = PictureBoxSizeMode.Normal
            PictureBox.Dock = DockStyle.Fill
            PictureBox.Image = image
            imageform.Controls.Add(PictureBox)
            imageform.Show()
            Timer2.Enabled = True
            Timer2.Interval = 1000
        Else
            MsgBox("There is no image to print")
        End If

    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefereshImage.Click
        RefreshToolStripMenuItem.PerformClick()


    End Sub

    Private Sub Neutrino_Photo_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.CenterToScreen()
        Me.ShowIcon = True
        Me.ShowInTaskbar = True
        Me.Visible = True
        Me.PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        StatusBarToolStripMenuItem.Checked = True
        StatusStrip1.Visible = True
        Panel1.Width = 37
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        Dim hotkey, hotkeyright, hotkeyleft As Boolean

        hotkey = GetAsyncKeyState(Keys.Escape)
        hotkeyright = GetAsyncKeyState(Keys.Right)
        hotkeyleft = GetAsyncKeyState(Keys.Left)
        If hotkey = True Then
            imageform.Hide()
        ElseIf hotkeyright = True Then
            btnNext.PerformClick()
        ElseIf hotkeyleft = True Then
            btnPrevious.PerformClick()
        End If

    End Sub


    Private Sub OpenImageToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem.MouseHover

    End Sub

    Private Sub OpenImageToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem.MouseLeave

    End Sub

    Private Sub SaveImageToolStripMenuItem2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveImageToolStripMenuItem2.MouseHover

    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullscreen.Click
        FullScreenToolStripMenuItem.PerformClick()

    End Sub

    Private Sub picNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub picPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub ResizeImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResizeImageToolStripMenuItem.Click
        If Not IsNothing(Me.PictureBox1.Image) Then
            Photo__Editor.Show()

            Photo__Editor.pageResize.Show()
        Else
            MsgBox("Please Open a Photo First")
        End If


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        lblImageName.Text = My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetKey(cmbImages.SelectedIndex)).Name & " | "
        lblSsize.Text = ("Width : " & Me.PictureBox1.Image.Size.Width.ToString & " ; Height : " & Me.PictureBox1.Image.Size.Height.ToString).ToString
        lblProperties.Text = "Name : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Name.ToString & vbCrLf _
            & vbCrLf _
             & "Type : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension.Replace("*.", "").ToUpper & vbCrLf _
             & vbCrLf _
             & "Width : " & Me.PictureBox1.Image.Size.Width.ToString & " pixel" & vbCrLf _
             & vbCrLf _
             & "Height : " & Me.PictureBox1.Image.Size.Height.ToString & " pixel" & vbCrLf _
             & vbCrLf _
             & "Size : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Length & " bytes" & vbCrLf _
             & vbCrLf _
             & "Last Modified : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).LastWriteTime.ToString & vbCrLf _
             & vbCrLf _
             & "Last Modified (UTC) : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).LastWriteTimeUtc.ToString & vbCrLf _
             & vbCrLf _
             & "Last Access : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).LastAccessTime.ToString & vbCrLf _
             & vbCrLf _
             & "Last Access (UTC) : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).LastAccessTimeUtc.ToString & vbCrLf _
             & vbCrLf _
             & "Created on : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).CreationTime.ToString & vbCrLf _
             & vbCrLf _
             & "Created on (UTC) : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).CreationTimeUtc.ToString & vbCrLf _
             & vbCrLf _
             & "Read-Only : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).IsReadOnly.ToString & vbCrLf _
             & vbCrLf _
             & "Loation : " & My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).DirectoryName.ToString & vbCrLf

        If Not IsNothing(Me.PictureBox1.Image) Then
            CutImageToolStripMenuItem.Enabled = True
            btnCut.Enabled = True

            CopyToolStripMenuItem.Enabled = True
            btnCut.Enabled = True

            DeleteImageToolStripMenuItem2.Enabled = True
            btnDeletePhoto.Enabled = True
        Else
            CutImageToolStripMenuItem.Enabled = False
            btnCut.Enabled = False

            CopyToolStripMenuItem.Enabled = False
            btnCut.Enabled = False

            DeleteImageToolStripMenuItem2.Enabled = False
            btnDeletePhoto.Enabled = False
        End If
        If cmbImages.Items.Count > 2 Then
            btnNext.Enabled = True
            btnPrevious.Enabled = True
            ToolStripMenuItem30.Enabled = True
            ToolStripMenuItem31.Enabled = True
        Else
            btnNext.Enabled = False
            btnPrevious.Enabled = False
            ToolStripMenuItem30.Enabled = False
            ToolStripMenuItem31.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            PrintForm1.Form = imageform
            PrintForm1.Print()
        Catch ex As Exception
            MsgBox("Sorry! An error occured to print the image file. Please try again. " & vbCrLf & ex.Message, vbOKOnly, "ERROR")
        End Try

        imageform.Hide()
        Timer2.Enabled = False

    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlipVer.Click
        VerticalToolStripMenuItem.PerformClick()

    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        Try
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            PictureBox1.Refresh()
            PictureBox1.Image.Save((My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).DirectoryName + "\" + My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Name.Replace(My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension, vbNullString) + "_RotatedCounterClok" + My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension).ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        Try
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            PictureBox1.Refresh()
            PictureBox1.Image.Save((My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).DirectoryName + "\" + My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Name.Replace(My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension, vbNullString) + "_RotatedClock" + My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension).ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizontalToolStripMenuItem.Click
        Try
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            PictureBox1.Refresh()
            PictureBox1.Image.Save((My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).DirectoryName + "\" + My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Name.Replace(My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension, vbNullString) + "_FlippedHorizontal" + My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension).ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub VerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerticalToolStripMenuItem.Click
        Try
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
            PictureBox1.Refresh()
            PictureBox1.Image.Save((My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).DirectoryName + "\" + My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Name.Replace(My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension, vbNullString) + "_FlippedVertical" + My.Computer.FileSystem.GetFileInfo(imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).Extension).ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotateLeft.Click
        LeftToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotateRight.Click
        RightToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlipHori.Click
        HorizontalToolStripMenuItem.PerformClick()

    End Sub


    Private Sub cmbImages_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbImages.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmbImages.Items.Remove(cmbImages.SelectedItem)
        End If
    End Sub

    Private Sub cmbImages_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbImages.SelectedIndexChanged
        Dim index As Integer
        index = imageofDirectory.IndexOfKey(cmbImages.SelectedItem)

        If Not index = -1 Then
            Me.PictureBox1.Image = Image.FromFile(imageofDirectory.Item(cmbImages.SelectedItem))
            PictureBox.Image = Image.FromFile(imageofDirectory.Item(cmbImages.SelectedItem))

        End If
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If Not cmbImages.SelectedIndex = cmbImages.Items.Count - 1 Then
                cmbImages.SelectedIndex += 1
            ElseIf cmbImages.SelectedIndex = cmbImages.Items.Count - 1 Then
                cmbImages.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Try
            If Not cmbImages.SelectedIndex <= 0 Then
                cmbImages.SelectedIndex -= 1
            ElseIf cmbImages.SelectedIndex = 0 Then
                cmbImages.SelectedIndex = cmbImages.Items.Count - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshList.Click
        ImageDirectory = filepath.Replace("\" & filename, "")
        lblStatus.Text = "Gathering Image from Current Directory..."

        For Each Me.imagepath In My.Computer.FileSystem.GetFiles(ImageDirectory)
            If My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".jpg" Or _
                My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".jpeg" Or _
                 My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".png" Or _
                  My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".bmp" Or _
                   My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".gif" Or _
                    My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".tiff" Or _
                     My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".emf" Or _
                      My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".exif" Or _
                       My.Computer.FileSystem.GetFileInfo(imagepath).Extension.ToLower = ".wmf" Then

                imagename = My.Computer.FileSystem.GetName(imagepath)

                If Not imageofDirectory.ContainsKey(imagename) Then

                    imageofDirectory.Add(imagename, imagepath)
                    cmbImages.Items.Add(imagename)

                End If

            End If

        Next
        lblImageCounter.Text = "Photos In Current Directory (" & (imageofDirectory.Count).ToString & ") :"
        lblImageCounter.ToolTipText = "Current Directory has " & (imageofDirectory.Count.ToString) & " supported photo. "
        lblStatus.Text = "Ready"
        cmbImages.SelectedIndex = imageofDirectory.IndexOfKey(Me.PictureBox1.Image.ToString)
    End Sub


    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If isFull = True Then
            Try
               
                cmbImages.SelectedIndex += 1
            Catch ex As Exception
                imageform.Hide()
                Timer4.Stop()
            End Try
        ElseIf isFull = False Then
            Try
              
                cmbImages.SelectedIndex += 1
            Catch ex As Exception
                MsgBox(ex.Message)
                Timer4.Enabled = False
            End Try
        End If
    End Sub

    Private Sub cmbImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbImages.Click

    End Sub

    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        Timer4.Enabled = True
        PlayToolStripMenuItem.Enabled = False
        PauseToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        Timer4.Enabled = False
        PlayToolStripMenuItem.Enabled = True
        PauseToolStripMenuItem.Enabled = False
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click

        Try
            cmbImages.SelectedIndex += 1

        Catch ex As Exception
            imageform.Hide()
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        imageform.Hide()
        Timer4.Enabled = False
    End Sub

    Private Sub SlideshowWithFullScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlideshowWithFullScreenToolStripMenuItem.Click
        isFull = True
        On Error Resume Next
        Timer4.Enabled = True
        Timer4.Interval = SlideDelay
        If Sound = True Then
            PlaySoundToolStripMenuItem.Enabled = False
            PauseSoundToolStripMenuItem.Enabled = True

            If Not String.IsNullOrEmpty(SoundPath) And My.Computer.FileSystem.FileExists(SoundPath) Then
                loadAndSetSoundFile(SoundPath)
                playSoundFile()
            End If
        End If


        imageform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        imageform.WindowState = FormWindowState.Maximized
        imageform.BackColor = Color.Black
        PictureBox.Dock = DockStyle.Fill
        PictureBox.BackColor = Color.Black
        PictureBox.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox.Image = Me.PictureBox1.Image
        imageform.Controls.Add(PictureBox)
        imageform.ContextMenuStrip = ContextMenuStrip1
        PictureBox.ContextMenuStrip = ContextMenuStrip1
        imageform.Show()
        imageform.Focus()

        PlayToolStripMenuItem.Enabled = False
        PauseToolStripMenuItem.Enabled = True

    End Sub

    Private Sub PreviousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousToolStripMenuItem.Click

        Try
            cmbImages.SelectedIndex -= 1
        Catch ex As Exception
            imageform.Hide()
        End Try
    End Sub

    Private Sub Delay1SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delay1SToolStripMenuItem.Click
        Timer4.Interval = 1000
    End Sub

    Private Sub Delay2SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delay2SToolStripMenuItem.Click
        Timer4.Interval = 2000
    End Sub

    Private Sub Delay3SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delay3SToolStripMenuItem.Click
        Timer4.Interval = 3000
    End Sub

    Private Sub Delay4SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delay4SToolStripMenuItem.Click
        Timer4.Interval = 4000
    End Sub

    Private Sub Delay5SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delay5SToolStripMenuItem.Click
        Timer4.Interval = 5000
    End Sub

    Private Sub SlideshowWithoutFullScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlideshowWithoutFullScreenToolStripMenuItem.Click
        isFull = False
        Me.PictureBox1.ContextMenuStrip = ContextMenuStrip1
        Timer4.Enabled = True
        Timer4.Interval = SlideDelay
        If Sound = True Then
            PlaySoundToolStripMenuItem.Enabled = False
            PauseSoundToolStripMenuItem.Enabled = True

            If Not String.IsNullOrEmpty(SoundPath) And My.Computer.FileSystem.FileExists(SoundPath) Then
                loadAndSetSoundFile(SoundPath)
                playSoundFile()
            End If
        End If
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
        On Error Resume Next
        imageform.Hide()
        Timer4.Enabled = False
        My.Computer.Audio.Stop()
        Me.PictureBox1.ContextMenuStrip = contextPicture
        stopSound()
    End Sub

    Private Sub GeneralSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralSettingsToolStripMenuItem.Click
        Settings.Show()
        Settings.KryptonNavigator1.SelectedIndex = 0
    End Sub

    Private Sub SlideshowSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlideshowSettingsToolStripMenuItem.Click
        Settings.Show()
        Settings.KryptonNavigator1.SelectedIndex = 1
    End Sub


    Private Sub PlaySoundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaySoundToolStripMenuItem.Click
        If isPause = True Then Resume Else playSoundFile()
        isPause = False
        PlaySoundToolStripMenuItem.Enabled = False
        PauseSoundToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PauseSoundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseSoundToolStripMenuItem.Click
        pausePlay()
        isPause = True
        PlaySoundToolStripMenuItem.Enabled = True
        PauseSoundToolStripMenuItem.Enabled = False
    End Sub

    Private Sub StopSoundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopSoundToolStripMenuItem.Click
        stopSound()
        isPause = False
        PlaySoundToolStripMenuItem.Enabled = True

    End Sub



    Private Sub btnProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProperties.Click
        If btnProperties.CheckState = CheckState.Checked Then
            Panel1.Width = 300
        ElseIf btnProperties.CheckState = CheckState.Unchecked Then
            Panel1.Width = 37
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(My.Computer.FileSystem.GetFileInfo(Me.PictureBox1.ImageLocation).Name)
    End Sub

    Private Sub PictureMenu_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles PictureMenu.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        PictureBox1.Refresh()

    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteList.Click
        imageofDirectory.Clear()
        cmbImages.Items.Clear()
        cmbImages.Text = vbNullString
        Me.Refresh()
    End Sub

    Private Sub ToolStripMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem30.Click
        btnNext.PerformClick()
    End Sub

    Private Sub NextToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem1.Click
        btnNext.PerformClick()

    End Sub

    Private Sub PreviousToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousToolStripMenuItem1.Click
        btnPrevious.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        btnPrevious.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem34.Click
        btnRefereshImage.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem33.Click
        btnRefreshList.PerformClick()

    End Sub

    Private Sub OpenImageToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem1.Click
        OpenImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        SaveImageToolStripMenuItem2.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        SaveImageAsToolStripMenuItem1.PerformClick()

    End Sub

    Private Sub EditPhotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditPhotoToolStripMenuItem.Click
        ResizeImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        LeftToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem26.Click
        RightToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        HorizontalToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        VerticalToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Normal1.Click
        NormalToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stretch1.Click
        StrechToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoSize1.Click
        AutoSizeToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Center1.Click
        CenterToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zoom1.Click
        ZoomToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem32.Click
        FullScreenToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        CopyToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        PasteAImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub DeleteImageToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteImageToolStripMenuItem1.Click
        DeleteImageToolStripMenuItem2.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem37.Click
        PrintImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        End
    End Sub

    Private Sub ToolStripMenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        Try
            SetWallpaper(Me.PictureBox1.Image)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SetAsDesktopBackgroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAsDesktopBackgroundToolStripMenuItem.Click
        Try
            SetWallpaper(Me.PictureBox1.Image)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CutImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutImageToolStripMenuItem.Click
        Dim ImageSource As String = (imageofDirectory.GetByIndex(cmbImages.SelectedIndex)).ToString
        Dim Filename As String = My.Computer.FileSystem.GetFileInfo(ImageSource).Name

        Dim CutFile As New SaveFileDialog
        CutFile.Filter = "All Files |*.*"
        CutFile.OverwritePrompt = True
        CutFile.RestoreDirectory = True
        CutFile.Title = "Move Photo To..."
        CutFile.FileName = Filename
        Try
            If CutFile.ShowDialog = DialogResult.OK Then
                imageofDirectory.Remove(cmbImages.SelectedItem)
                cmbImages.Items.Remove(cmbImages.SelectedItem)
                Me.PictureBox1.Image = Nothing

                System.IO.File.Move(ImageSource, CutFile.FileName)
                MsgBox((cmbImages.SelectedItem & " has been successfully moved to " & My.Computer.FileSystem.GetFileInfo(CutFile.FileName).DirectoryName).ToString, MsgBoxStyle.OkOnly, "Move Successful")

            End If
        Catch ex As Exception
            MsgBox("An error occured" & vbCrLf & ex.Message, , "Error")
        End Try
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCut.Click
        CutImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        CopyToolStripMenuItem.PerformClick()

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        CutImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub HelpFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpFileToolStripMenuItem.Click

    End Sub
End Class
