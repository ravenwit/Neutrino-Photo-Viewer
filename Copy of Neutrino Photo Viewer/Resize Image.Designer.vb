<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Photo__Editor
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
        Me.pageResize = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.grpPercentage = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.numPercentage = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.grpCustom = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.numHeight = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.numWidth = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbStandard = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.radPercentage = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.radCustom = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.radStandard = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.radOriginal = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.pageCrop = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.picCrop = New System.Windows.Forms.PictureBox()
        Me.chkCropOpt = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.LinkLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnOk = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblNewSize = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblOriginal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonNavigator1.SuspendLayout()
        CType(Me.pageResize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageResize.SuspendLayout()
        CType(Me.grpPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPercentage.Panel.SuspendLayout()
        Me.grpPercentage.SuspendLayout()
        CType(Me.grpCustom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustom.Panel.SuspendLayout()
        Me.grpCustom.SuspendLayout()
        CType(Me.cmbStandard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pageCrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageCrop.SuspendLayout()
        CType(Me.picCrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'KryptonNavigator1
        '
        Me.KryptonNavigator1.Bar.ItemAlignment = ComponentFactory.Krypton.Toolkit.RelativePositionAlign.Center
        Me.KryptonNavigator1.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.Individual
        Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.ContextNextPrevious
        Me.KryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.RemovePage
        Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.KryptonNavigator1.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonNavigator1.Name = "KryptonNavigator1"
        Me.KryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.HeaderGroupTab
        Me.KryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.pageResize, Me.pageCrop})
        Me.KryptonNavigator1.SelectedIndex = 0
        Me.KryptonNavigator1.Size = New System.Drawing.Size(481, 323)
        Me.KryptonNavigator1.TabIndex = 1
        Me.KryptonNavigator1.Text = "&Resize"
        '
        'pageResize
        '
        Me.pageResize.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.pageResize.Controls.Add(Me.grpPercentage)
        Me.pageResize.Controls.Add(Me.grpCustom)
        Me.pageResize.Controls.Add(Me.cmbStandard)
        Me.pageResize.Controls.Add(Me.radPercentage)
        Me.pageResize.Controls.Add(Me.radCustom)
        Me.pageResize.Controls.Add(Me.radStandard)
        Me.pageResize.Controls.Add(Me.radOriginal)
        Me.pageResize.Flags = 65534
        Me.pageResize.LastVisibleSet = True
        Me.pageResize.MinimumSize = New System.Drawing.Size(50, 50)
        Me.pageResize.Name = "pageResize"
        Me.pageResize.Size = New System.Drawing.Size(479, 244)
        Me.pageResize.Text = "&Rresize"
        Me.pageResize.TextDescription = "Resize a photo to any standard or custom size."
        Me.pageResize.TextTitle = "Resize"
        Me.pageResize.ToolTipBody = "Resize a photo to any standard or custom size."
        Me.pageResize.ToolTipTitle = "Resize"
        Me.pageResize.UniqueName = "71C284BB7A8C4150CDB400E0B2B01298"
        '
        'grpPercentage
        '
        Me.grpPercentage.CaptionOverlap = 1.0R
        Me.grpPercentage.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.grpPercentage.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate
        Me.grpPercentage.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlToolTip
        Me.grpPercentage.Location = New System.Drawing.Point(27, 188)
        Me.grpPercentage.Name = "grpPercentage"
        Me.grpPercentage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        'grpPercentage.Panel
        '
        Me.grpPercentage.Panel.Controls.Add(Me.numPercentage)
        Me.grpPercentage.Panel.Controls.Add(Me.KryptonLabel4)
        Me.grpPercentage.Size = New System.Drawing.Size(388, 47)
        Me.grpPercentage.TabIndex = 22
        Me.grpPercentage.Values.Heading = ""
        '
        'numPercentage
        '
        Me.numPercentage.Location = New System.Drawing.Point(104, 8)
        Me.numPercentage.Name = "numPercentage"
        Me.numPercentage.Size = New System.Drawing.Size(141, 22)
        Me.numPercentage.TabIndex = 1
        Me.numPercentage.ThousandsSeparator = True
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(251, 10)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(21, 20)
        Me.KryptonLabel4.TabIndex = 0
        Me.KryptonLabel4.Values.Text = "%"
        '
        'grpCustom
        '
        Me.grpCustom.CaptionOverlap = 1.0R
        Me.grpCustom.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.grpCustom.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate
        Me.grpCustom.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlToolTip
        Me.grpCustom.Location = New System.Drawing.Point(27, 107)
        Me.grpCustom.Name = "grpCustom"
        Me.grpCustom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        'grpCustom.Panel
        '
        Me.grpCustom.Panel.Controls.Add(Me.numHeight)
        Me.grpCustom.Panel.Controls.Add(Me.KryptonLabel2)
        Me.grpCustom.Panel.Controls.Add(Me.numWidth)
        Me.grpCustom.Panel.Controls.Add(Me.KryptonLabel1)
        Me.grpCustom.Size = New System.Drawing.Size(388, 54)
        Me.grpCustom.TabIndex = 20
        Me.grpCustom.Values.Heading = ""
        '
        'numHeight
        '
        Me.numHeight.Location = New System.Drawing.Point(256, 11)
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(125, 22)
        Me.numHeight.TabIndex = 3
        Me.numHeight.ThousandsSeparator = True
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(186, 11)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(74, 20)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Values.Text = "X    Height :"
        '
        'numWidth
        '
        Me.numWidth.Location = New System.Drawing.Point(55, 11)
        Me.numWidth.Name = "numWidth"
        Me.numWidth.Size = New System.Drawing.Size(125, 22)
        Me.numWidth.TabIndex = 1
        Me.numWidth.ThousandsSeparator = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Width :"
        '
        'cmbStandard
        '
        Me.cmbStandard.AllowButtonSpecToolTips = True
        Me.cmbStandard.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone
        Me.cmbStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStandard.DropDownWidth = 275
        Me.cmbStandard.Items.AddRange(New Object() {"Document - Large (1024 X 768 px)", "Document - Small (800 X 600 px)", "Web - Large (640 X 480 px)", "Web - Small (448 X 336 px)", "E-mail - Large (314 X 235 px)", "E-mail - Small (160 X 160 px)"})
        Me.cmbStandard.Location = New System.Drawing.Point(140, 48)
        Me.cmbStandard.Name = "cmbStandard"
        Me.cmbStandard.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.cmbStandard.Size = New System.Drawing.Size(275, 21)
        Me.cmbStandard.TabIndex = 5
        '
        'radPercentage
        '
        Me.radPercentage.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.radPercentage.Location = New System.Drawing.Point(14, 167)
        Me.radPercentage.Name = "radPercentage"
        Me.radPercentage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.radPercentage.Size = New System.Drawing.Size(92, 22)
        Me.radPercentage.StateCommon.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPercentage.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPercentage.StateNormal.LongText.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPercentage.StateNormal.ShortText.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPercentage.TabIndex = 4
        Me.radPercentage.Values.Text = "Percentage"
        '
        'radCustom
        '
        Me.radCustom.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.radCustom.Location = New System.Drawing.Point(14, 85)
        Me.radCustom.Name = "radCustom"
        Me.radCustom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.radCustom.Size = New System.Drawing.Size(99, 22)
        Me.radCustom.StateCommon.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustom.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustom.StateNormal.LongText.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustom.StateNormal.ShortText.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustom.TabIndex = 3
        Me.radCustom.Values.Text = "Custom Size"
        '
        'radStandard
        '
        Me.radStandard.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.radStandard.Location = New System.Drawing.Point(14, 51)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.radStandard.Size = New System.Drawing.Size(113, 22)
        Me.radStandard.StateCommon.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.StateNormal.LongText.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.StateNormal.ShortText.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.TabIndex = 2
        Me.radStandard.Values.Text = "Standard Size"
        '
        'radOriginal
        '
        Me.radOriginal.Checked = True
        Me.radOriginal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.radOriginal.Location = New System.Drawing.Point(14, 17)
        Me.radOriginal.Name = "radOriginal"
        Me.radOriginal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.radOriginal.Size = New System.Drawing.Size(113, 22)
        Me.radOriginal.StateCommon.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOriginal.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOriginal.StateNormal.LongText.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOriginal.StateNormal.ShortText.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOriginal.TabIndex = 0
        Me.radOriginal.Values.Text = "Original Size"
        '
        'pageCrop
        '
        Me.pageCrop.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.pageCrop.Controls.Add(Me.picCrop)
        Me.pageCrop.Controls.Add(Me.chkCropOpt)
        Me.pageCrop.Controls.Add(Me.LinkLabel1)
        Me.pageCrop.Flags = 65534
        Me.pageCrop.LastVisibleSet = True
        Me.pageCrop.MinimumSize = New System.Drawing.Size(50, 50)
        Me.pageCrop.Name = "pageCrop"
        Me.pageCrop.Size = New System.Drawing.Size(479, 244)
        Me.pageCrop.Text = "Cro&p"
        Me.pageCrop.TextDescription = "Crop  a photo."
        Me.pageCrop.TextTitle = "Crop"
        Me.pageCrop.ToolTipBody = "Crop  a photo."
        Me.pageCrop.ToolTipTitle = "Crop"
        Me.pageCrop.UniqueName = "7270428245A04D6790B261A415BEDAA3"
        '
        'picCrop
        '
        Me.picCrop.Location = New System.Drawing.Point(14, 85)
        Me.picCrop.Name = "picCrop"
        Me.picCrop.Size = New System.Drawing.Size(456, 150)
        Me.picCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCrop.TabIndex = 26
        Me.picCrop.TabStop = False
        '
        'chkCropOpt
        '
        Me.chkCropOpt.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.chkCropOpt.Location = New System.Drawing.Point(14, 59)
        Me.chkCropOpt.Name = "chkCropOpt"
        Me.chkCropOpt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.chkCropOpt.Size = New System.Drawing.Size(267, 26)
        Me.chkCropOpt.TabIndex = 1
        Me.chkCropOpt.Text = "Resize Cropped Photo to Main Photo Size"
        Me.chkCropOpt.Values.Text = "Resize Cropped Photo to Main Photo Size"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(210, 22)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 34)
        Me.LinkLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.Values.Text = "Crop"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnCancel)
        Me.KryptonPanel1.Controls.Add(Me.btnOk)
        Me.KryptonPanel1.Controls.Add(Me.lblNewSize)
        Me.KryptonPanel1.Controls.Add(Me.lblOriginal)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 322)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.KryptonPanel1.Size = New System.Drawing.Size(481, 64)
        Me.KryptonPanel1.TabIndex = 23
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(381, 20)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Values.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(285, 20)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 25)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Values.Text = "OK"
        '
        'lblNewSize
        '
        Me.lblNewSize.Location = New System.Drawing.Point(12, 38)
        Me.lblNewSize.Name = "lblNewSize"
        Me.lblNewSize.Size = New System.Drawing.Size(89, 20)
        Me.lblNewSize.TabIndex = 1
        Me.lblNewSize.Values.Text = "KryptonLabel5"
        '
        'lblOriginal
        '
        Me.lblOriginal.Location = New System.Drawing.Point(12, 7)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(89, 20)
        Me.lblOriginal.TabIndex = 0
        Me.lblOriginal.Values.Text = "KryptonLabel3"
        '
        'Photo__Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(481, 386)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Photo__Editor"
        Me.Text = "Photo Editor"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonNavigator1.ResumeLayout(False)
        CType(Me.pageResize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageResize.ResumeLayout(False)
        Me.pageResize.PerformLayout()
        Me.grpPercentage.Panel.ResumeLayout(False)
        Me.grpPercentage.Panel.PerformLayout()
        CType(Me.grpPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPercentage.ResumeLayout(False)
        Me.grpCustom.Panel.ResumeLayout(False)
        Me.grpCustom.Panel.PerformLayout()
        CType(Me.grpCustom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustom.ResumeLayout(False)
        CType(Me.cmbStandard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pageCrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageCrop.ResumeLayout(False)
        Me.pageCrop.PerformLayout()
        CType(Me.picCrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Friend WithEvents pageResize As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents pageCrop As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblNewSize As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOriginal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpPercentage As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents numPercentage As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpCustom As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents numHeight As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents numWidth As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbStandard As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents radPercentage As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radCustom As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radStandard As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radOriginal As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOk As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents picCrop As System.Windows.Forms.PictureBox
    Friend WithEvents chkCropOpt As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents LinkLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
End Class
