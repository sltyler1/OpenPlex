<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenPlex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenPlex))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblStartupItem = New System.Windows.Forms.Label()
        Me.btnStartupItem = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblStop = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.Theme = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Hijack = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlexIcon = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Advanced = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Extras = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WebConnect = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Settings.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Theme.SuspendLayout()
        Me.Hijack.SuspendLayout()
        Me.PlexIcon.SuspendLayout()
        Me.Advanced.SuspendLayout()
        Me.Extras.SuspendLayout()
        Me.WebConnect.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 351)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(659, 31)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(306, 26)
        Me.ToolStripStatusLabel1.Text = "© 2015 Wahlman.j, CyberGhost84, Flipman6, and sltyler1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 26)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Settings)
        Me.TabControl1.Controls.Add(Me.Theme)
        Me.TabControl1.Controls.Add(Me.Hijack)
        Me.TabControl1.Controls.Add(Me.PlexIcon)
        Me.TabControl1.Controls.Add(Me.Advanced)
        Me.TabControl1.Controls.Add(Me.Extras)
        Me.TabControl1.Controls.Add(Me.WebConnect)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(660, 360)
        Me.TabControl1.TabIndex = 1
        '
        'Settings
        '
        Me.Settings.Controls.Add(Me.lblVersion)
        Me.Settings.Controls.Add(Me.picIcon)
        Me.Settings.Controls.Add(Me.lblStartupItem)
        Me.Settings.Controls.Add(Me.btnStartupItem)
        Me.Settings.Controls.Add(Me.Panel1)
        Me.Settings.Location = New System.Drawing.Point(4, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Settings.Size = New System.Drawing.Size(652, 334)
        Me.Settings.TabIndex = 0
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(112, 72)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(85, 13)
        Me.lblVersion.TabIndex = 10
        Me.lblVersion.Text = "Beta Version 0.1"
        '
        'picIcon
        '
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(7, 32)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(98, 62)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picIcon.TabIndex = 9
        Me.picIcon.TabStop = False
        Me.picIcon.Visible = False
        '
        'lblStartupItem
        '
        Me.lblStartupItem.AutoSize = True
        Me.lblStartupItem.Location = New System.Drawing.Point(544, 113)
        Me.lblStartupItem.Name = "lblStartupItem"
        Me.lblStartupItem.Size = New System.Drawing.Size(64, 13)
        Me.lblStartupItem.TabIndex = 8
        Me.lblStartupItem.Text = "Startup Item"
        Me.lblStartupItem.Visible = False
        '
        'btnStartupItem
        '
        Me.btnStartupItem.Location = New System.Drawing.Point(544, 132)
        Me.btnStartupItem.Name = "btnStartupItem"
        Me.btnStartupItem.Size = New System.Drawing.Size(75, 23)
        Me.btnStartupItem.TabIndex = 7
        Me.btnStartupItem.Text = "On"
        Me.btnStartupItem.UseVisualStyleBackColor = True
        Me.btnStartupItem.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLog)
        Me.Panel1.Controls.Add(Me.btnShutdown)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.lblStop)
        Me.Panel1.Controls.Add(Me.btnRestart)
        Me.Panel1.Location = New System.Drawing.Point(377, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 71)
        Me.Panel1.TabIndex = 6
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(3, 40)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 23)
        Me.btnLog.TabIndex = 3
        Me.btnLog.Text = "Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.Location = New System.Drawing.Point(167, 39)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(75, 23)
        Me.btnShutdown.TabIndex = 5
        Me.btnShutdown.Text = "Shutdown"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(3, 10)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(85, 39)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'lblStop
        '
        Me.lblStop.Location = New System.Drawing.Point(85, 9)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(75, 23)
        Me.lblStop.TabIndex = 1
        Me.lblStop.Text = "Stop"
        Me.lblStop.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(167, 9)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 2
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'Theme
        '
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Location = New System.Drawing.Point(4, 22)
        Me.Theme.Name = "Theme"
        Me.Theme.Padding = New System.Windows.Forms.Padding(3)
        Me.Theme.Size = New System.Drawing.Size(652, 334)
        Me.Theme.TabIndex = 1
        Me.Theme.Text = "Theme"
        Me.Theme.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coming Soon!"
        '
        'Hijack
        '
        Me.Hijack.Controls.Add(Me.Label1)
        Me.Hijack.Location = New System.Drawing.Point(4, 22)
        Me.Hijack.Name = "Hijack"
        Me.Hijack.Size = New System.Drawing.Size(652, 334)
        Me.Hijack.TabIndex = 2
        Me.Hijack.Text = "Hijack"
        Me.Hijack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coming Soon!"
        '
        'PlexIcon
        '
        Me.PlexIcon.Controls.Add(Me.Label3)
        Me.PlexIcon.Location = New System.Drawing.Point(4, 22)
        Me.PlexIcon.Name = "PlexIcon"
        Me.PlexIcon.Size = New System.Drawing.Size(652, 334)
        Me.PlexIcon.TabIndex = 3
        Me.PlexIcon.Text = "Plex Icon"
        Me.PlexIcon.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Coming Soon!"
        '
        'Advanced
        '
        Me.Advanced.Controls.Add(Me.Label4)
        Me.Advanced.Location = New System.Drawing.Point(4, 22)
        Me.Advanced.Name = "Advanced"
        Me.Advanced.Size = New System.Drawing.Size(652, 334)
        Me.Advanced.TabIndex = 4
        Me.Advanced.Text = "Advanced"
        Me.Advanced.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 31)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Coming Soon!"
        '
        'Extras
        '
        Me.Extras.Controls.Add(Me.Label5)
        Me.Extras.Location = New System.Drawing.Point(4, 22)
        Me.Extras.Name = "Extras"
        Me.Extras.Size = New System.Drawing.Size(652, 334)
        Me.Extras.TabIndex = 5
        Me.Extras.Text = "Extras"
        Me.Extras.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Coming Soon!"
        '
        'WebConnect
        '
        Me.WebConnect.Controls.Add(Me.Label6)
        Me.WebConnect.Location = New System.Drawing.Point(4, 22)
        Me.WebConnect.Name = "WebConnect"
        Me.WebConnect.Size = New System.Drawing.Size(652, 334)
        Me.WebConnect.TabIndex = 6
        Me.WebConnect.Text = "WebConnect"
        Me.WebConnect.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 31)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Coming Soon!"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "OpenPlex"
        Me.NotifyIcon1.Visible = True
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Image = CType(resources.GetObject("ToolStripStatusLabel3.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(40, 26)
        '
        'WinPlex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 382)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(675, 420)
        Me.MinimumSize = New System.Drawing.Size(675, 420)
        Me.Name = "WinPlex"
        Me.Text = "OpenPlex"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.Hijack.ResumeLayout(False)
        Me.Hijack.PerformLayout()
        Me.PlexIcon.ResumeLayout(False)
        Me.PlexIcon.PerformLayout()
        Me.Advanced.ResumeLayout(False)
        Me.Advanced.PerformLayout()
        Me.Extras.ResumeLayout(False)
        Me.Extras.PerformLayout()
        Me.WebConnect.ResumeLayout(False)
        Me.WebConnect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Settings As System.Windows.Forms.TabPage
    Friend WithEvents Theme As System.Windows.Forms.TabPage
    Friend WithEvents Hijack As System.Windows.Forms.TabPage
    Friend WithEvents PlexIcon As System.Windows.Forms.TabPage
    Friend WithEvents Advanced As System.Windows.Forms.TabPage
    Friend WithEvents Extras As System.Windows.Forms.TabPage
    Friend WithEvents WebConnect As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblStartupItem As System.Windows.Forms.Label
    Friend WithEvents btnStartupItem As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblStop As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel

End Class
