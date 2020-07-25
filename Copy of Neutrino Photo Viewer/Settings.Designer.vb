<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
        Me.pageGeneral = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.chkGatherImage = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.pageSlideshow = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.grpSound = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.btnBrowse = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtSound = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkSound = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.lnlblCustom = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.cmbDelay = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnOk = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pageGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageGeneral.SuspendLayout()
        CType(Me.pageSlideshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageSlideshow.SuspendLayout()
        CType(Me.grpSound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSound.Panel.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        CType(Me.cmbDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonNavigator1
        '
        Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.ContextNextPrevious
        Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.KryptonNavigator1.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.KryptonNavigator1.Location = New System.Drawing.Point(1, 0)
        Me.KryptonNavigator1.Name = "KryptonNavigator1"
        Me.KryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.HeaderGroupTab
        Me.KryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.pageGeneral, Me.pageSlideshow})
        Me.KryptonNavigator1.SelectedIndex = 1
        Me.KryptonNavigator1.Size = New System.Drawing.Size(378, 297)
        Me.KryptonNavigator1.TabIndex = 0
        Me.KryptonNavigator1.Text = "KryptonNavigator1"
        '
        'pageGeneral
        '
        Me.pageGeneral.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.pageGeneral.Controls.Add(Me.chkGatherImage)
        Me.pageGeneral.Flags = 65534
        Me.pageGeneral.LastVisibleSet = True
        Me.pageGeneral.MinimumSize = New System.Drawing.Size(50, 50)
        Me.pageGeneral.Name = "pageGeneral"
        Me.pageGeneral.Size = New System.Drawing.Size(376, 218)
        Me.pageGeneral.Text = "General"
        Me.pageGeneral.TextDescription = "General Settings"
        Me.pageGeneral.TextTitle = "General"
        Me.pageGeneral.ToolTipTitle = "General Settings"
        Me.pageGeneral.UniqueName = "2462DBD0858549D1E1A756FEC6AC84E9"
        '
        'chkGatherImage
        '
        Me.chkGatherImage.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.chkGatherImage.Location = New System.Drawing.Point(10, 37)
        Me.chkGatherImage.Name = "chkGatherImage"
        Me.chkGatherImage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.chkGatherImage.Size = New System.Drawing.Size(308, 26)
        Me.chkGatherImage.TabIndex = 0
        Me.chkGatherImage.Text = "Gather Image from Directory While Opening File"
        Me.chkGatherImage.Values.Text = "Gather Image from Directory While Opening File"
        '
        'pageSlideshow
        '
        Me.pageSlideshow.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.pageSlideshow.Controls.Add(Me.grpSound)
        Me.pageSlideshow.Controls.Add(Me.chkSound)
        Me.pageSlideshow.Controls.Add(Me.KryptonGroupBox1)
        Me.pageSlideshow.Flags = 65534
        Me.pageSlideshow.LastVisibleSet = True
        Me.pageSlideshow.MinimumSize = New System.Drawing.Size(50, 50)
        Me.pageSlideshow.Name = "pageSlideshow"
        Me.pageSlideshow.Size = New System.Drawing.Size(376, 218)
        Me.pageSlideshow.Text = "Slideshow"
        Me.pageSlideshow.TextDescription = "Slideshow Settings. Adding sound in slideshow might take more time to load slides" & _
    "how."
        Me.pageSlideshow.TextTitle = "Slideshow"
        Me.pageSlideshow.ToolTipTitle = "Slideshow Settings"
        Me.pageSlideshow.UniqueName = "99DCE9EEDAF54ADE6ABAE0540183A73B"
        '
        'grpSound
        '
        Me.grpSound.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.grpSound.Controls.Add(Me.grpSound.Panel)
        Me.grpSound.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.grpSound.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlToolTip
        Me.grpSound.Location = New System.Drawing.Point(10, 125)
        Me.grpSound.Name = "grpSound"
        Me.grpSound.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.grpSound.Size = New System.Drawing.Size(356, 82)
        Me.grpSound.TabIndex = 2
        Me.grpSound.Text = "Sound"
        Me.grpSound.Values.Heading = "Sound"
        '
        'btnBrowse
        '
        Me.btnBrowse.AutoSize = True
        Me.btnBrowse.Location = New System.Drawing.Point(310, 14)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(32, 24)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Values.Text = "..."
        '
        'txtSound
        '
        Me.txtSound.Enabled = False
        Me.txtSound.Location = New System.Drawing.Point(79, 14)
        Me.txtSound.Name = "txtSound"
        Me.txtSound.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.txtSound.Size = New System.Drawing.Size(225, 20)
        Me.txtSound.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtSound.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.txtSound.StateActive.Content.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSound.StateNormal.Content.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSound.TabIndex = 3
        Me.txtSound.Text = "Sound Path"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 14)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Values.Text = "Sound Path :"
        '
        'chkSound
        '
        Me.chkSound.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.chkSound.Location = New System.Drawing.Point(10, 106)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.chkSound.Size = New System.Drawing.Size(190, 26)
        Me.chkSound.TabIndex = 1
        Me.chkSound.Text = "Play Sound When Slideshow"
        Me.chkSound.Values.Text = "Play Sound When Slideshow"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.KryptonGroupBox1.Controls.Add(Me.KryptonGroupBox1.Panel)
        Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.KryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlToolTip
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        Me.KryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(356, 97)
        Me.KryptonGroupBox1.TabIndex = 0
        Me.KryptonGroupBox1.Text = "Delay"
        Me.KryptonGroupBox1.Values.Heading = "Delay"
        '
        'lnlblCustom
        '
        Me.lnlblCustom.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline
        Me.lnlblCustom.Location = New System.Drawing.Point(139, 36)
        Me.lnlblCustom.Name = "lnlblCustom"
        Me.lnlblCustom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.lnlblCustom.Size = New System.Drawing.Size(78, 31)
        Me.lnlblCustom.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.lnlblCustom.StateNormal.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.lnlblCustom.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lnlblCustom.StateNormal.ShortText.Color2 = System.Drawing.Color.Black
        Me.lnlblCustom.StateNormal.ShortText.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlblCustom.TabIndex = 2
        Me.lnlblCustom.Values.Text = "Custom"
        '
        'cmbDelay
        '
        Me.cmbDelay.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone
        Me.cmbDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelay.DropDownWidth = 224
        Me.cmbDelay.Items.AddRange(New Object() {"One Second", "Two Second", "Three Second", "Four Second", "Five Second"})
        Me.cmbDelay.Location = New System.Drawing.Point(105, 14)
        Me.cmbDelay.Name = "cmbDelay"
        Me.cmbDelay.Size = New System.Drawing.Size(224, 21)
        Me.cmbDelay.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(105, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Slideshow Delay :"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnCancel)
        Me.KryptonPanel1.Controls.Add(Me.btnOk)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 300)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.KryptonPanel1.Size = New System.Drawing.Size(379, 39)
        Me.KryptonPanel1.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(278, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Values.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(182, 8)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.TabIndex = 4
        Me.btnOk.Values.Text = "OK"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 339)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonNavigator1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pageGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageGeneral.ResumeLayout(False)
        Me.pageGeneral.PerformLayout()
        CType(Me.pageSlideshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageSlideshow.ResumeLayout(False)
        Me.pageSlideshow.PerformLayout()
        Me.grpSound.Panel.ResumeLayout(False)
        Me.grpSound.Panel.PerformLayout()
        CType(Me.grpSound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Private WithEvents pageGeneral As ComponentFactory.Krypton.Navigator.KryptonPage
    Private WithEvents chkGatherImage As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents pageSlideshow As ComponentFactory.Krypton.Navigator.KryptonPage
    Private WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Private WithEvents cmbDelay As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lnlblCustom As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents grpSound As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Private WithEvents btnBrowse As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtSound As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents chkSound As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnOk As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
