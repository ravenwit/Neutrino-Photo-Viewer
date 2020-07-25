<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkGatherImage = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbDelay = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnlblCustom = New System.Windows.Forms.LinkLabel()
        Me.grpSound = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSound = New System.Windows.Forms.TextBox()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpSound.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(369, 240)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkGatherImage)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(361, 214)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkGatherImage
        '
        Me.chkGatherImage.AutoSize = True
        Me.chkGatherImage.Location = New System.Drawing.Point(8, 24)
        Me.chkGatherImage.Name = "chkGatherImage"
        Me.chkGatherImage.Size = New System.Drawing.Size(250, 17)
        Me.chkGatherImage.TabIndex = 0
        Me.chkGatherImage.Text = "Gather Image from Directory While Opening File"
        Me.chkGatherImage.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.grpSound)
        Me.TabPage2.Controls.Add(Me.chkSound)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(361, 214)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Slideshow"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbDelay)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lnlblCustom)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 80)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delay"
        '
        'cmbDelay
        '
        Me.cmbDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelay.FormattingEnabled = True
        Me.cmbDelay.Items.AddRange(New Object() {"One Second", "Two Second", "Three Second", "Four Second", "Five Second"})
        Me.cmbDelay.Location = New System.Drawing.Point(105, 19)
        Me.cmbDelay.Name = "cmbDelay"
        Me.cmbDelay.Size = New System.Drawing.Size(224, 21)
        Me.cmbDelay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Slideshow Delay :"
        '
        'lnlblCustom
        '
        Me.lnlblCustom.AutoSize = True
        Me.lnlblCustom.Location = New System.Drawing.Point(145, 54)
        Me.lnlblCustom.Name = "lnlblCustom"
        Me.lnlblCustom.Size = New System.Drawing.Size(42, 13)
        Me.lnlblCustom.TabIndex = 2
        Me.lnlblCustom.TabStop = True
        Me.lnlblCustom.Text = "Custom"
        '
        'grpSound
        '
        Me.grpSound.Controls.Add(Me.Label3)
        Me.grpSound.Controls.Add(Me.btnBrowse)
        Me.grpSound.Controls.Add(Me.Label2)
        Me.grpSound.Controls.Add(Me.txtSound)
        Me.grpSound.Location = New System.Drawing.Point(11, 126)
        Me.grpSound.Name = "grpSound"
        Me.grpSound.Size = New System.Drawing.Size(342, 68)
        Me.grpSound.TabIndex = 7
        Me.grpSound.TabStop = False
        Me.grpSound.Text = "Sound"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(300, 19)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(29, 23)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sound Path :"
        '
        'txtSound
        '
        Me.txtSound.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSound.Location = New System.Drawing.Point(83, 19)
        Me.txtSound.Name = "txtSound"
        Me.txtSound.Size = New System.Drawing.Size(209, 20)
        Me.txtSound.TabIndex = 5
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Location = New System.Drawing.Point(11, 103)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(163, 17)
        Me.chkSound.TabIndex = 3
        Me.chkSound.Text = "Play Sound When Slideshow"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 41)
        Me.Panel1.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(273, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 25)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(183, 7)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(84, 25)
        Me.btnOk.TabIndex = 18
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Adding Sound might take more time to load."
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 287)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpSound.ResumeLayout(False)
        Me.grpSound.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chkGatherImage As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmbDelay As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lnlblCustom As System.Windows.Forms.LinkLabel
    Friend WithEvents grpSound As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSound As System.Windows.Forms.TextBox
    Friend WithEvents chkSound As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
