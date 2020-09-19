<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Wall = New System.Windows.Forms.Button()
        Me.Volume = New System.Windows.Forms.Button()
        Me.PatchTCBtn = New System.Windows.Forms.Button()
        Me.PowerShell = New System.Windows.Forms.Button()
        Me.LSDbtn = New System.Windows.Forms.Button()
        Me.CMD = New System.Windows.Forms.Button()
        Me.Silent = New System.Windows.Forms.CheckBox()
        Me.BlackBtn = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.UnlockPCBtn = New System.Windows.Forms.Button()
        Me.ShutdownPCBtn = New System.Windows.Forms.Button()
        Me.LockPCBtn = New System.Windows.Forms.Button()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.MinimizeBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.InfoBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SilentLbl = New System.Windows.Forms.Label()
        Me.SharesBtn = New System.Windows.Forms.Button()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.ProcessesBtn = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.TitleBar.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.Color.Transparent
        Me.Wall.FlatAppearance.BorderSize = 0
        Me.Wall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Wall.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wall.ForeColor = System.Drawing.Color.Snow
        Me.Wall.Image = CType(resources.GetObject("Wall.Image"), System.Drawing.Image)
        Me.Wall.Location = New System.Drawing.Point(217, 200)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(45, 45)
        Me.Wall.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Wall, "Change The Wallpaper")
        Me.Wall.UseVisualStyleBackColor = False
        '
        'Volume
        '
        Me.Volume.BackColor = System.Drawing.Color.Transparent
        Me.Volume.FlatAppearance.BorderSize = 0
        Me.Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Volume.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volume.ForeColor = System.Drawing.Color.Snow
        Me.Volume.Image = CType(resources.GetObject("Volume.Image"), System.Drawing.Image)
        Me.Volume.Location = New System.Drawing.Point(268, 200)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(45, 45)
        Me.Volume.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Volume, "Opens Volume Mixer")
        Me.Volume.UseVisualStyleBackColor = False
        '
        'PatchTCBtn
        '
        Me.PatchTCBtn.BackColor = System.Drawing.Color.Transparent
        Me.PatchTCBtn.FlatAppearance.BorderSize = 0
        Me.PatchTCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatchTCBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatchTCBtn.ForeColor = System.Drawing.Color.Snow
        Me.PatchTCBtn.Image = CType(resources.GetObject("PatchTCBtn.Image"), System.Drawing.Image)
        Me.PatchTCBtn.Location = New System.Drawing.Point(118, 31)
        Me.PatchTCBtn.Name = "PatchTCBtn"
        Me.PatchTCBtn.Size = New System.Drawing.Size(134, 138)
        Me.PatchTCBtn.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.PatchTCBtn, "Copys TeacherConsole To The Desktop And Patches RoomMgr.dll And Try To Execute TC" &
        " Without Permissions")
        Me.PatchTCBtn.UseVisualStyleBackColor = False
        '
        'PowerShell
        '
        Me.PowerShell.BackColor = System.Drawing.Color.Transparent
        Me.PowerShell.FlatAppearance.BorderSize = 0
        Me.PowerShell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PowerShell.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerShell.ForeColor = System.Drawing.Color.Snow
        Me.PowerShell.Image = CType(resources.GetObject("PowerShell.Image"), System.Drawing.Image)
        Me.PowerShell.Location = New System.Drawing.Point(115, 200)
        Me.PowerShell.Name = "PowerShell"
        Me.PowerShell.Size = New System.Drawing.Size(45, 45)
        Me.PowerShell.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.PowerShell, "Opens PowerShell (Might Be Blocked)")
        Me.PowerShell.UseVisualStyleBackColor = False
        '
        'LSDbtn
        '
        Me.LSDbtn.BackColor = System.Drawing.Color.Transparent
        Me.LSDbtn.FlatAppearance.BorderSize = 0
        Me.LSDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LSDbtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSDbtn.ForeColor = System.Drawing.Color.Snow
        Me.LSDbtn.Image = CType(resources.GetObject("LSDbtn.Image"), System.Drawing.Image)
        Me.LSDbtn.Location = New System.Drawing.Point(166, 200)
        Me.LSDbtn.Name = "LSDbtn"
        Me.LSDbtn.Size = New System.Drawing.Size(45, 45)
        Me.LSDbtn.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.LSDbtn, "Overlay Color Changing Form")
        Me.LSDbtn.UseVisualStyleBackColor = False
        '
        'CMD
        '
        Me.CMD.BackColor = System.Drawing.Color.Transparent
        Me.CMD.FlatAppearance.BorderSize = 0
        Me.CMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD.ForeColor = System.Drawing.Color.Snow
        Me.CMD.Image = CType(resources.GetObject("CMD.Image"), System.Drawing.Image)
        Me.CMD.Location = New System.Drawing.Point(64, 200)
        Me.CMD.Name = "CMD"
        Me.CMD.Size = New System.Drawing.Size(45, 45)
        Me.CMD.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CMD, "Opens CMD (Even When Blocked)")
        Me.CMD.UseVisualStyleBackColor = False
        '
        'Silent
        '
        Me.Silent.BackColor = System.Drawing.Color.Transparent
        Me.Silent.Checked = True
        Me.Silent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Silent.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Silent.ForeColor = System.Drawing.Color.Black
        Me.Silent.Location = New System.Drawing.Point(12, 1)
        Me.Silent.Name = "Silent"
        Me.Silent.Size = New System.Drawing.Size(93, 28)
        Me.Silent.TabIndex = 4
        Me.Silent.Text = "                "
        Me.ToolTip1.SetToolTip(Me.Silent, "Hide Temporary Files")
        Me.Silent.UseVisualStyleBackColor = False
        '
        'BlackBtn
        '
        Me.BlackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BlackBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BlackBtn.FlatAppearance.BorderSize = 0
        Me.BlackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BlackBtn.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlackBtn.ForeColor = System.Drawing.Color.Snow
        Me.BlackBtn.Image = CType(resources.GetObject("BlackBtn.Image"), System.Drawing.Image)
        Me.BlackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BlackBtn.Location = New System.Drawing.Point(0, 264)
        Me.BlackBtn.Name = "BlackBtn"
        Me.BlackBtn.Size = New System.Drawing.Size(108, 36)
        Me.BlackBtn.TabIndex = 5
        Me.BlackBtn.Text = " Blackout"
        Me.BlackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BlackBtn, "Blackout Screen On TeacherConsole")
        Me.BlackBtn.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.UnlockPCBtn)
        Me.GroupBox4.Controls.Add(Me.ShutdownPCBtn)
        Me.GroupBox4.Controls.Add(Me.LockPCBtn)
        Me.GroupBox4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(281, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(119, 116)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Experimental"
        '
        'UnlockPCBtn
        '
        Me.UnlockPCBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.UnlockPCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UnlockPCBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnlockPCBtn.ForeColor = System.Drawing.Color.Snow
        Me.UnlockPCBtn.Location = New System.Drawing.Point(6, 82)
        Me.UnlockPCBtn.Name = "UnlockPCBtn"
        Me.UnlockPCBtn.Size = New System.Drawing.Size(87, 24)
        Me.UnlockPCBtn.TabIndex = 2
        Me.UnlockPCBtn.Text = "UnlockAll"
        Me.UnlockPCBtn.UseVisualStyleBackColor = False
        '
        'ShutdownPCBtn
        '
        Me.ShutdownPCBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ShutdownPCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShutdownPCBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShutdownPCBtn.ForeColor = System.Drawing.Color.Snow
        Me.ShutdownPCBtn.Location = New System.Drawing.Point(6, 52)
        Me.ShutdownPCBtn.Name = "ShutdownPCBtn"
        Me.ShutdownPCBtn.Size = New System.Drawing.Size(87, 24)
        Me.ShutdownPCBtn.TabIndex = 1
        Me.ShutdownPCBtn.Text = "ShutdownAll"
        Me.ShutdownPCBtn.UseVisualStyleBackColor = False
        '
        'LockPCBtn
        '
        Me.LockPCBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LockPCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LockPCBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LockPCBtn.ForeColor = System.Drawing.Color.Snow
        Me.LockPCBtn.Location = New System.Drawing.Point(6, 22)
        Me.LockPCBtn.Name = "LockPCBtn"
        Me.LockPCBtn.Size = New System.Drawing.Size(87, 24)
        Me.LockPCBtn.TabIndex = 0
        Me.LockPCBtn.Text = "LockAll"
        Me.LockPCBtn.UseVisualStyleBackColor = False
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.Title)
        Me.TitleBar.Controls.Add(Me.MinimizeBtn)
        Me.TitleBar.Controls.Add(Me.CloseBtn)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(506, 27)
        Me.TitleBar.TabIndex = 0
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(3, 6)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(156, 15)
        Me.Title.TabIndex = 2
        Me.Title.Text = "MNS+ Trasher @BOS 2020"
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.MinimizeBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.MinimizeBtn.FlatAppearance.BorderSize = 0
        Me.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeBtn.Location = New System.Drawing.Point(406, 0)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.Size = New System.Drawing.Size(50, 27)
        Me.MinimizeBtn.TabIndex = 0
        Me.MinimizeBtn.TabStop = False
        Me.MinimizeBtn.Text = "-"
        Me.MinimizeBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Location = New System.Drawing.Point(456, 0)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(50, 27)
        Me.CloseBtn.TabIndex = 0
        Me.CloseBtn.TabStop = False
        Me.CloseBtn.Text = "x"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.ProcessesBtn)
        Me.MainPanel.Controls.Add(Me.CMD)
        Me.MainPanel.Controls.Add(Me.LSDbtn)
        Me.MainPanel.Controls.Add(Me.GroupBox4)
        Me.MainPanel.Controls.Add(Me.PatchTCBtn)
        Me.MainPanel.Controls.Add(Me.PowerShell)
        Me.MainPanel.Controls.Add(Me.Wall)
        Me.MainPanel.Controls.Add(Me.Volume)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.MainPanel.Location = New System.Drawing.Point(106, 27)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(400, 300)
        Me.MainPanel.TabIndex = 7
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.InfoBtn)
        Me.Sidebar.Controls.Add(Me.Panel1)
        Me.Sidebar.Controls.Add(Me.SharesBtn)
        Me.Sidebar.Controls.Add(Me.DashboardBtn)
        Me.Sidebar.Controls.Add(Me.BlackBtn)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sidebar.Location = New System.Drawing.Point(0, 27)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(108, 300)
        Me.Sidebar.TabIndex = 8
        '
        'InfoBtn
        '
        Me.InfoBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.InfoBtn.FlatAppearance.BorderSize = 0
        Me.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InfoBtn.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoBtn.Image = CType(resources.GetObject("InfoBtn.Image"), System.Drawing.Image)
        Me.InfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InfoBtn.Location = New System.Drawing.Point(0, 72)
        Me.InfoBtn.Name = "InfoBtn"
        Me.InfoBtn.Size = New System.Drawing.Size(108, 36)
        Me.InfoBtn.TabIndex = 3
        Me.InfoBtn.Text = " Info"
        Me.InfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InfoBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SilentLbl)
        Me.Panel1.Controls.Add(Me.Silent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 236)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 28)
        Me.Panel1.TabIndex = 4
        '
        'SilentLbl
        '
        Me.SilentLbl.AutoSize = True
        Me.SilentLbl.BackColor = System.Drawing.Color.Transparent
        Me.SilentLbl.Location = New System.Drawing.Point(30, 5)
        Me.SilentLbl.Name = "SilentLbl"
        Me.SilentLbl.Size = New System.Drawing.Size(45, 18)
        Me.SilentLbl.TabIndex = 0
        Me.SilentLbl.Text = "Silent"
        '
        'SharesBtn
        '
        Me.SharesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SharesBtn.FlatAppearance.BorderSize = 0
        Me.SharesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SharesBtn.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SharesBtn.Image = CType(resources.GetObject("SharesBtn.Image"), System.Drawing.Image)
        Me.SharesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SharesBtn.Location = New System.Drawing.Point(0, 36)
        Me.SharesBtn.Name = "SharesBtn"
        Me.SharesBtn.Size = New System.Drawing.Size(108, 36)
        Me.SharesBtn.TabIndex = 1
        Me.SharesBtn.Text = " Shares"
        Me.SharesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SharesBtn.UseVisualStyleBackColor = True
        '
        'DashboardBtn
        '
        Me.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashboardBtn.FlatAppearance.BorderSize = 0
        Me.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBtn.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardBtn.Image = CType(resources.GetObject("DashboardBtn.Image"), System.Drawing.Image)
        Me.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.Location = New System.Drawing.Point(0, 0)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Size = New System.Drawing.Size(108, 36)
        Me.DashboardBtn.TabIndex = 0
        Me.DashboardBtn.Text = " Dashbord"
        Me.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardBtn.UseVisualStyleBackColor = True
        '
        'ProcessesBtn
        '
        Me.ProcessesBtn.BackColor = System.Drawing.Color.Transparent
        Me.ProcessesBtn.FlatAppearance.BorderSize = 0
        Me.ProcessesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProcessesBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessesBtn.ForeColor = System.Drawing.Color.Snow
        Me.ProcessesBtn.Image = CType(resources.GetObject("ProcessesBtn.Image"), System.Drawing.Image)
        Me.ProcessesBtn.Location = New System.Drawing.Point(166, 243)
        Me.ProcessesBtn.Name = "ProcessesBtn"
        Me.ProcessesBtn.Size = New System.Drawing.Size(45, 45)
        Me.ProcessesBtn.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ProcessesBtn, "Manipulate Processes")
        Me.ProcessesBtn.UseVisualStyleBackColor = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(506, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TitleBar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = " "
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.ResumeLayout(False)
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.Sidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Wall As Button
    Friend WithEvents Volume As Button
    Friend WithEvents PatchTCBtn As Button
    Friend WithEvents PowerShell As Button
    Friend WithEvents BlackBtn As Button
    Friend WithEvents LSDbtn As Button
    Friend WithEvents CMD As Button
    Friend WithEvents Silent As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents UnlockPCBtn As Button
    Friend WithEvents ShutdownPCBtn As Button
    Friend WithEvents LockPCBtn As Button
    Friend WithEvents TitleBar As Panel
    Friend WithEvents MinimizeBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Title As Label
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents Sidebar As Panel
    Private WithEvents SharesBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SilentLbl As Label
    Private WithEvents InfoBtn As Button
    Friend WithEvents ProcessesBtn As Button
End Class
