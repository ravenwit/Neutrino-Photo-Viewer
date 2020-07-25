<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Photo__Editor
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Photo__Editor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStandard = New System.Windows.Forms.ComboBox()
        Me.numWidth = New System.Windows.Forms.NumericUpDown()
        Me.numHeight = New System.Windows.Forms.NumericUpDown()
        Me.numPercentage = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.radCustom = New System.Windows.Forms.RadioButton()
        Me.radPercentage = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpPercentage = New System.Windows.Forms.GroupBox()
        Me.grpCustom = New System.Windows.Forms.GroupBox()
        Me.radOriginal = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.picCrop = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.chkCropOpt = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.lblNewSize = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpPercentage.SuspendLayout()
        Me.grpCustom.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.picCrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Width :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Height :"
        '
        'cmbStandard
        '
        Me.cmbStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStandard.FormattingEnabled = True
        Me.cmbStandard.Items.AddRange(New Object() {"Document - Large (1024 X 768 px)", "Document - Small (800 X 600 px)", "Web - Large (640 X 480 px)", "Web - Small (448 X 336 px)", "E-mail - Large (314 X 235 px)", "E-mail - Small (160 X 160 px)"})
        Me.cmbStandard.Location = New System.Drawing.Point(134, 34)
        Me.cmbStandard.Name = "cmbStandard"
        Me.cmbStandard.Size = New System.Drawing.Size(214, 21)
        Me.cmbStandard.TabIndex = 6
        '
        'numWidth
        '
        Me.numWidth.Location = New System.Drawing.Point(69, 21)
        Me.numWidth.Name = "numWidth"
        Me.numWidth.Size = New System.Drawing.Size(107, 20)
        Me.numWidth.TabIndex = 10
        '
        'numHeight
        '
        Me.numHeight.Location = New System.Drawing.Point(245, 19)
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(107, 20)
        Me.numHeight.TabIndex = 11
        '
        'numPercentage
        '
        Me.numPercentage.Location = New System.Drawing.Point(131, 19)
        Me.numPercentage.Name = "numPercentage"
        Me.numPercentage.Size = New System.Drawing.Size(107, 20)
        Me.numPercentage.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "%"
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Location = New System.Drawing.Point(26, 34)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(102, 17)
        Me.radStandard.TabIndex = 14
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard Sizes :"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'radCustom
        '
        Me.radCustom.AutoSize = True
        Me.radCustom.Location = New System.Drawing.Point(26, 66)
        Me.radCustom.Name = "radCustom"
        Me.radCustom.Size = New System.Drawing.Size(86, 17)
        Me.radCustom.TabIndex = 15
        Me.radCustom.TabStop = True
        Me.radCustom.Text = "Custom Size "
        Me.radCustom.UseVisualStyleBackColor = True
        '
        'radPercentage
        '
        Me.radPercentage.AutoSize = True
        Me.radPercentage.Location = New System.Drawing.Point(26, 146)
        Me.radPercentage.Name = "radPercentage"
        Me.radPercentage.Size = New System.Drawing.Size(83, 17)
        Me.radPercentage.TabIndex = 16
        Me.radPercentage.TabStop = True
        Me.radPercentage.Text = "Percentage "
        Me.radPercentage.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(483, 254)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpPercentage)
        Me.TabPage1.Controls.Add(Me.grpCustom)
        Me.TabPage1.Controls.Add(Me.radOriginal)
        Me.TabPage1.Controls.Add(Me.radPercentage)
        Me.TabPage1.Controls.Add(Me.radCustom)
        Me.TabPage1.Controls.Add(Me.radStandard)
        Me.TabPage1.Controls.Add(Me.cmbStandard)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(475, 228)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resize "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpPercentage
        '
        Me.grpPercentage.Controls.Add(Me.numPercentage)
        Me.grpPercentage.Controls.Add(Me.Label4)
        Me.grpPercentage.Location = New System.Drawing.Point(48, 166)
        Me.grpPercentage.Name = "grpPercentage"
        Me.grpPercentage.Size = New System.Drawing.Size(376, 47)
        Me.grpPercentage.TabIndex = 19
        Me.grpPercentage.TabStop = False
        Me.grpPercentage.Text = "Percentage"
        '
        'grpCustom
        '
        Me.grpCustom.Controls.Add(Me.numHeight)
        Me.grpCustom.Controls.Add(Me.numWidth)
        Me.grpCustom.Controls.Add(Me.Label3)
        Me.grpCustom.Controls.Add(Me.Label2)
        Me.grpCustom.Controls.Add(Me.Label1)
        Me.grpCustom.Location = New System.Drawing.Point(45, 88)
        Me.grpCustom.Name = "grpCustom"
        Me.grpCustom.Size = New System.Drawing.Size(376, 52)
        Me.grpCustom.TabIndex = 18
        Me.grpCustom.TabStop = False
        Me.grpCustom.Text = "Custom Size"
        '
        'radOriginal
        '
        Me.radOriginal.AutoSize = True
        Me.radOriginal.Location = New System.Drawing.Point(26, 3)
        Me.radOriginal.Name = "radOriginal"
        Me.radOriginal.Size = New System.Drawing.Size(83, 17)
        Me.radOriginal.TabIndex = 17
        Me.radOriginal.TabStop = True
        Me.radOriginal.Text = "Original Size"
        Me.radOriginal.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.picCrop)
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.chkCropOpt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(475, 228)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Crop "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'picCrop
        '
        Me.picCrop.Location = New System.Drawing.Point(11, 64)
        Me.picCrop.Name = "picCrop"
        Me.picCrop.Size = New System.Drawing.Size(456, 158)
        Me.picCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCrop.TabIndex = 25
        Me.picCrop.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(469, 25)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripButton1.Text = "Crop"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.WindowText
        Me.LinkLabel1.Location = New System.Drawing.Point(159, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(106, 26)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Crop Photo"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Click for crop photo")
        '
        'chkCropOpt
        '
        Me.chkCropOpt.AutoSize = True
        Me.chkCropOpt.Location = New System.Drawing.Point(11, 41)
        Me.chkCropOpt.Name = "chkCropOpt"
        Me.chkCropOpt.Size = New System.Drawing.Size(224, 17)
        Me.chkCropOpt.TabIndex = 22
        Me.chkCropOpt.Text = "Resize Cropped Photo to Main Photo Size"
        Me.chkCropOpt.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(297, 16)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(84, 23)
        Me.btnOk.TabIndex = 18
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(387, 16)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Location = New System.Drawing.Point(12, 4)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(39, 13)
        Me.lblOriginal.TabIndex = 20
        Me.lblOriginal.Text = "Label5"
        '
        'lblNewSize
        '
        Me.lblNewSize.AutoSize = True
        Me.lblNewSize.Location = New System.Drawing.Point(12, 31)
        Me.lblNewSize.Name = "lblNewSize"
        Me.lblNewSize.Size = New System.Drawing.Size(39, 13)
        Me.lblNewSize.TabIndex = 21
        Me.lblNewSize.Text = "Label6"
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblNewSize)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.lblOriginal)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 51)
        Me.Panel1.TabIndex = 0
        '
        'Photo__Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(483, 307)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Photo__Editor"
        Me.Text = "Photo Editor"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpPercentage.ResumeLayout(False)
        Me.grpPercentage.PerformLayout()
        Me.grpCustom.ResumeLayout(False)
        Me.grpCustom.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.picCrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbStandard As System.Windows.Forms.ComboBox
    Friend WithEvents numWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents numHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents numPercentage As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents radStandard As System.Windows.Forms.RadioButton
    Friend WithEvents radCustom As System.Windows.Forms.RadioButton
    Friend WithEvents radPercentage As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblOriginal As System.Windows.Forms.Label
    Friend WithEvents lblNewSize As System.Windows.Forms.Label
    Friend WithEvents radOriginal As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grpPercentage As System.Windows.Forms.GroupBox
    Friend WithEvents grpCustom As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkCropOpt As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents picCrop As System.Windows.Forms.PictureBox
End Class
