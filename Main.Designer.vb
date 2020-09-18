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
        Me.lefty = New System.Windows.Forms.CheckBox()
        Me.msgBtn = New System.Windows.Forms.Button()
        Me.Spoof = New System.Windows.Forms.Button()
        Me.RoomBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WebAnwendung = New System.Windows.Forms.Button()
        Me.Support = New System.Windows.Forms.Button()
        Me.RoomTxt = New System.Windows.Forms.Label()
        Me.Shortcut = New System.Windows.Forms.Button()
        Me.WebLogs = New System.Windows.Forms.Button()
        Me.Wall = New System.Windows.Forms.Button()
        Me.MapCustom = New System.Windows.Forms.Button()
        Me.TrayIcon = New System.Windows.Forms.Button()
        Me.ProcessesBtn = New System.Windows.Forms.Button()
        Me.Links = New System.Windows.Forms.Button()
        Me.Volume = New System.Windows.Forms.Button()
        Me.PatchTCBtn = New System.Windows.Forms.Button()
        Me.PowerShell = New System.Windows.Forms.Button()
        Me.BlackBtn = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.btnIP = New System.Windows.Forms.Button()
        Me.LSDbtn = New System.Windows.Forms.Button()
        Me.FindBtn = New System.Windows.Forms.Button()
        Me.CMD = New System.Windows.Forms.Button()
        Me.Silent = New System.Windows.Forms.CheckBox()
        Me.RecentBtn = New System.Windows.Forms.Button()
        Me.HideBtn = New System.Windows.Forms.Button()
        Me.ShowBtn = New System.Windows.Forms.Button()
        Me.LockBtn = New System.Windows.Forms.Button()
        Me.UnlockBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LstIP = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SharesBtn = New System.Windows.Forms.Button()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TitleBar.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lefty
        '
        Me.lefty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lefty.AutoSize = True
        Me.lefty.BackColor = System.Drawing.Color.Transparent
        Me.lefty.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lefty.ForeColor = System.Drawing.Color.Black
        Me.lefty.Location = New System.Drawing.Point(103, 21)
        Me.lefty.Name = "lefty"
        Me.lefty.Size = New System.Drawing.Size(54, 19)
        Me.lefty.TabIndex = 1
        Me.lefty.Text = "Lefty"
        Me.ToolTip1.SetToolTip(Me.lefty, "Let MNS+ Think You Are A Lefty (Swaps Mouse Buttons After Next Login)")
        Me.lefty.UseVisualStyleBackColor = False
        '
        'msgBtn
        '
        Me.msgBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.msgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.msgBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgBtn.ForeColor = System.Drawing.Color.Snow
        Me.msgBtn.Location = New System.Drawing.Point(6, 22)
        Me.msgBtn.Name = "msgBtn"
        Me.msgBtn.Size = New System.Drawing.Size(87, 24)
        Me.msgBtn.TabIndex = 1
        Me.msgBtn.Text = "AWBMsg"
        Me.ToolTip1.SetToolTip(Me.msgBtn, "Send Spoofed Messages To The AWB (Requires Permissions To Write To T:\Admin)")
        Me.msgBtn.UseVisualStyleBackColor = False
        '
        'Spoof
        '
        Me.Spoof.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Spoof.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Spoof.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Spoof.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spoof.ForeColor = System.Drawing.Color.Black
        Me.Spoof.Location = New System.Drawing.Point(9, 76)
        Me.Spoof.Name = "Spoof"
        Me.Spoof.Size = New System.Drawing.Size(87, 24)
        Me.Spoof.TabIndex = 7
        Me.Spoof.Text = "SpoofRoom"
        Me.ToolTip1.SetToolTip(Me.Spoof, "Spoof Room Shares (A:)")
        Me.Spoof.UseVisualStyleBackColor = False
        '
        'RoomBox
        '
        Me.RoomBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RoomBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomBox.Location = New System.Drawing.Point(9, 46)
        Me.RoomBox.Name = "RoomBox"
        Me.RoomBox.Size = New System.Drawing.Size(88, 23)
        Me.RoomBox.TabIndex = 6
        Me.RoomBox.Text = "R-CO1"
        Me.ToolTip1.SetToolTip(Me.RoomBox, "Room To Be Spoofed")
        '
        'WebAnwendung
        '
        Me.WebAnwendung.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.WebAnwendung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WebAnwendung.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebAnwendung.ForeColor = System.Drawing.Color.Snow
        Me.WebAnwendung.Location = New System.Drawing.Point(194, 22)
        Me.WebAnwendung.Name = "WebAnwendung"
        Me.WebAnwendung.Size = New System.Drawing.Size(87, 24)
        Me.WebAnwendung.TabIndex = 3
        Me.WebAnwendung.Text = "MNS+ v2"
        Me.ToolTip1.SetToolTip(Me.WebAnwendung, "Opens MNS+ v2 In The Browser (Old)")
        Me.WebAnwendung.UseVisualStyleBackColor = False
        '
        'Support
        '
        Me.Support.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Support.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Support.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Support.ForeColor = System.Drawing.Color.Snow
        Me.Support.Location = New System.Drawing.Point(6, 52)
        Me.Support.Name = "Support"
        Me.Support.Size = New System.Drawing.Size(87, 24)
        Me.Support.TabIndex = 5
        Me.Support.Text = "Support"
        Me.ToolTip1.SetToolTip(Me.Support, "Opens MNS+ Support (Default Password PLZ)")
        Me.Support.UseVisualStyleBackColor = False
        '
        'RoomTxt
        '
        Me.RoomTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RoomTxt.AutoSize = True
        Me.RoomTxt.BackColor = System.Drawing.Color.Transparent
        Me.RoomTxt.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTxt.ForeColor = System.Drawing.Color.Black
        Me.RoomTxt.Location = New System.Drawing.Point(6, 22)
        Me.RoomTxt.Name = "RoomTxt"
        Me.RoomTxt.Size = New System.Drawing.Size(43, 15)
        Me.RoomTxt.TabIndex = 5
        Me.RoomTxt.Text = "Room:"
        Me.ToolTip1.SetToolTip(Me.RoomTxt, "Your /Un/ Spoofed Room (AD Link Broken)")
        '
        'Shortcut
        '
        Me.Shortcut.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Shortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Shortcut.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Shortcut.ForeColor = System.Drawing.Color.Snow
        Me.Shortcut.Location = New System.Drawing.Point(288, 52)
        Me.Shortcut.Name = "Shortcut"
        Me.Shortcut.Size = New System.Drawing.Size(87, 24)
        Me.Shortcut.TabIndex = 8
        Me.Shortcut.Text = "Shortcut"
        Me.ToolTip1.SetToolTip(Me.Shortcut, "Adds MNS+ v2 And MNS+ Support To The Desktop")
        Me.Shortcut.UseVisualStyleBackColor = False
        '
        'WebLogs
        '
        Me.WebLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.WebLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WebLogs.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebLogs.ForeColor = System.Drawing.Color.Snow
        Me.WebLogs.Location = New System.Drawing.Point(100, 22)
        Me.WebLogs.Name = "WebLogs"
        Me.WebLogs.Size = New System.Drawing.Size(87, 24)
        Me.WebLogs.TabIndex = 2
        Me.WebLogs.Text = "WebLogs"
        Me.ToolTip1.SetToolTip(Me.WebLogs, "Opens WebLogs In The Browser (Requires Permissions)")
        Me.WebLogs.UseVisualStyleBackColor = False
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Wall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Wall.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wall.ForeColor = System.Drawing.Color.Snow
        Me.Wall.Location = New System.Drawing.Point(194, 52)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(87, 24)
        Me.Wall.TabIndex = 7
        Me.Wall.Text = "Wallpaper"
        Me.ToolTip1.SetToolTip(Me.Wall, "Change The Wallpaper")
        Me.Wall.UseVisualStyleBackColor = False
        '
        'MapCustom
        '
        Me.MapCustom.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.MapCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapCustom.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapCustom.ForeColor = System.Drawing.Color.Snow
        Me.MapCustom.Location = New System.Drawing.Point(6, 22)
        Me.MapCustom.Name = "MapCustom"
        Me.MapCustom.Size = New System.Drawing.Size(87, 24)
        Me.MapCustom.TabIndex = 3
        Me.MapCustom.Text = "CustomDrive"
        Me.ToolTip1.SetToolTip(Me.MapCustom, "Map / UnMap Custom Network Drive")
        Me.MapCustom.UseVisualStyleBackColor = False
        '
        'TrayIcon
        '
        Me.TrayIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TrayIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrayIcon.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrayIcon.ForeColor = System.Drawing.Color.Snow
        Me.TrayIcon.Location = New System.Drawing.Point(6, 82)
        Me.TrayIcon.Name = "TrayIcon"
        Me.TrayIcon.Size = New System.Drawing.Size(87, 24)
        Me.TrayIcon.TabIndex = 9
        Me.TrayIcon.Text = "TrayIcon"
        Me.ToolTip1.SetToolTip(Me.TrayIcon, "Add /Another/ Monitoring Indicator To The Tray")
        Me.TrayIcon.UseVisualStyleBackColor = False
        '
        'ProcessesBtn
        '
        Me.ProcessesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ProcessesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProcessesBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessesBtn.ForeColor = System.Drawing.Color.Snow
        Me.ProcessesBtn.Location = New System.Drawing.Point(100, 82)
        Me.ProcessesBtn.Name = "ProcessesBtn"
        Me.ProcessesBtn.Size = New System.Drawing.Size(87, 24)
        Me.ProcessesBtn.TabIndex = 10
        Me.ProcessesBtn.Text = "Processes"
        Me.ToolTip1.SetToolTip(Me.ProcessesBtn, "Manipulate Processes")
        Me.ProcessesBtn.UseVisualStyleBackColor = False
        '
        'Links
        '
        Me.Links.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Links.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Links.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Links.ForeColor = System.Drawing.Color.Snow
        Me.Links.Location = New System.Drawing.Point(194, 82)
        Me.Links.Name = "Links"
        Me.Links.Size = New System.Drawing.Size(87, 24)
        Me.Links.TabIndex = 11
        Me.Links.Text = "LegacyLinks"
        Me.ToolTip1.SetToolTip(Me.Links, "Mostly Broken Links")
        Me.Links.UseVisualStyleBackColor = False
        '
        'Volume
        '
        Me.Volume.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Volume.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volume.ForeColor = System.Drawing.Color.Snow
        Me.Volume.Location = New System.Drawing.Point(288, 82)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(87, 24)
        Me.Volume.TabIndex = 12
        Me.Volume.Text = "VolumeMix"
        Me.ToolTip1.SetToolTip(Me.Volume, "Opens Volume Mixer")
        Me.Volume.UseVisualStyleBackColor = False
        '
        'PatchTCBtn
        '
        Me.PatchTCBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PatchTCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatchTCBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatchTCBtn.ForeColor = System.Drawing.Color.Snow
        Me.PatchTCBtn.Location = New System.Drawing.Point(288, 112)
        Me.PatchTCBtn.Name = "PatchTCBtn"
        Me.PatchTCBtn.Size = New System.Drawing.Size(87, 24)
        Me.PatchTCBtn.TabIndex = 16
        Me.PatchTCBtn.Text = "PatchTC"
        Me.ToolTip1.SetToolTip(Me.PatchTCBtn, "Copys TeacherConsole To The Desktop And Patches RoomMgr.dll And Try To Execute TC" &
        " Without Permissions")
        Me.PatchTCBtn.UseVisualStyleBackColor = False
        '
        'PowerShell
        '
        Me.PowerShell.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PowerShell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PowerShell.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerShell.ForeColor = System.Drawing.Color.Snow
        Me.PowerShell.Location = New System.Drawing.Point(100, 52)
        Me.PowerShell.Name = "PowerShell"
        Me.PowerShell.Size = New System.Drawing.Size(87, 24)
        Me.PowerShell.TabIndex = 6
        Me.PowerShell.Text = "PowerSH"
        Me.ToolTip1.SetToolTip(Me.PowerShell, "Opens PowerShell (Might Be Blocked)")
        Me.PowerShell.UseVisualStyleBackColor = False
        '
        'BlackBtn
        '
        Me.BlackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BlackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BlackBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlackBtn.ForeColor = System.Drawing.Color.Snow
        Me.BlackBtn.Location = New System.Drawing.Point(194, 112)
        Me.BlackBtn.Name = "BlackBtn"
        Me.BlackBtn.Size = New System.Drawing.Size(87, 24)
        Me.BlackBtn.TabIndex = 15
        Me.BlackBtn.Text = "Blackout"
        Me.ToolTip1.SetToolTip(Me.BlackBtn, "Blackout Screen On TeacherConsole")
        Me.BlackBtn.UseVisualStyleBackColor = False
        '
        'txtIP
        '
        Me.txtIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIP.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(103, 76)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(42, 23)
        Me.txtIP.TabIndex = 8
        Me.txtIP.Text = "1-01"
        Me.ToolTip1.SetToolTip(Me.txtIP, "PC Name")
        '
        'btnIP
        '
        Me.btnIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIP.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIP.ForeColor = System.Drawing.Color.Black
        Me.btnIP.Location = New System.Drawing.Point(147, 76)
        Me.btnIP.Name = "btnIP"
        Me.btnIP.Size = New System.Drawing.Size(40, 24)
        Me.btnIP.TabIndex = 9
        Me.btnIP.Text = "GET"
        Me.ToolTip1.SetToolTip(Me.btnIP, "Get IP Of PC")
        Me.btnIP.UseVisualStyleBackColor = False
        '
        'LSDbtn
        '
        Me.LSDbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LSDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LSDbtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSDbtn.ForeColor = System.Drawing.Color.Snow
        Me.LSDbtn.Location = New System.Drawing.Point(6, 112)
        Me.LSDbtn.Name = "LSDbtn"
        Me.LSDbtn.Size = New System.Drawing.Size(87, 24)
        Me.LSDbtn.TabIndex = 13
        Me.LSDbtn.Text = "LSD"
        Me.ToolTip1.SetToolTip(Me.LSDbtn, "Overlay Color Changing Form")
        Me.LSDbtn.UseVisualStyleBackColor = False
        '
        'FindBtn
        '
        Me.FindBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.FindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindBtn.ForeColor = System.Drawing.Color.Snow
        Me.FindBtn.Location = New System.Drawing.Point(6, 52)
        Me.FindBtn.Name = "FindBtn"
        Me.FindBtn.Size = New System.Drawing.Size(87, 24)
        Me.FindBtn.TabIndex = 4
        Me.FindBtn.Text = "Find"
        Me.ToolTip1.SetToolTip(Me.FindBtn, "Find /Hidden/ Shares")
        Me.FindBtn.UseVisualStyleBackColor = False
        '
        'CMD
        '
        Me.CMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.CMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD.ForeColor = System.Drawing.Color.Snow
        Me.CMD.Location = New System.Drawing.Point(100, 112)
        Me.CMD.Name = "CMD"
        Me.CMD.Size = New System.Drawing.Size(87, 24)
        Me.CMD.TabIndex = 14
        Me.CMD.Text = "CMD"
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
        Me.Silent.TabIndex = 11
        Me.Silent.Text = "                "
        Me.ToolTip1.SetToolTip(Me.Silent, "Hide Temporary Files")
        Me.Silent.UseVisualStyleBackColor = False
        '
        'RecentBtn
        '
        Me.RecentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.RecentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecentBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecentBtn.ForeColor = System.Drawing.Color.Snow
        Me.RecentBtn.Location = New System.Drawing.Point(288, 22)
        Me.RecentBtn.Name = "RecentBtn"
        Me.RecentBtn.Size = New System.Drawing.Size(87, 24)
        Me.RecentBtn.TabIndex = 4
        Me.RecentBtn.Text = "Recent"
        Me.ToolTip1.SetToolTip(Me.RecentBtn, "Lists Recent Users Logged Into The Local PC")
        Me.RecentBtn.UseVisualStyleBackColor = False
        '
        'HideBtn
        '
        Me.HideBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.HideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HideBtn.ForeColor = System.Drawing.Color.Snow
        Me.HideBtn.Location = New System.Drawing.Point(6, 142)
        Me.HideBtn.Name = "HideBtn"
        Me.HideBtn.Size = New System.Drawing.Size(87, 24)
        Me.HideBtn.TabIndex = 17
        Me.HideBtn.Text = "HideHome"
        Me.ToolTip1.SetToolTip(Me.HideBtn, "Hide All Files And Folders In PrivateHome")
        Me.HideBtn.UseVisualStyleBackColor = False
        '
        'ShowBtn
        '
        Me.ShowBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowBtn.ForeColor = System.Drawing.Color.Snow
        Me.ShowBtn.Location = New System.Drawing.Point(100, 142)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(87, 24)
        Me.ShowBtn.TabIndex = 18
        Me.ShowBtn.Text = "ShowHome"
        Me.ToolTip1.SetToolTip(Me.ShowBtn, "Show All Files And Folders In PrivateHome")
        Me.ShowBtn.UseVisualStyleBackColor = False
        '
        'LockBtn
        '
        Me.LockBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LockBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LockBtn.ForeColor = System.Drawing.Color.Snow
        Me.LockBtn.Location = New System.Drawing.Point(194, 142)
        Me.LockBtn.Name = "LockBtn"
        Me.LockBtn.Size = New System.Drawing.Size(87, 24)
        Me.LockBtn.TabIndex = 19
        Me.LockBtn.Text = "LockHome"
        Me.ToolTip1.SetToolTip(Me.LockBtn, "Lock All Files And Folders In PrivateHome")
        Me.LockBtn.UseVisualStyleBackColor = False
        '
        'UnlockBtn
        '
        Me.UnlockBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.UnlockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UnlockBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnlockBtn.ForeColor = System.Drawing.Color.Snow
        Me.UnlockBtn.Location = New System.Drawing.Point(288, 142)
        Me.UnlockBtn.Name = "UnlockBtn"
        Me.UnlockBtn.Size = New System.Drawing.Size(87, 24)
        Me.UnlockBtn.TabIndex = 20
        Me.UnlockBtn.Text = "UnlockHome"
        Me.ToolTip1.SetToolTip(Me.UnlockBtn, "Unlock All Files And Folders In PrivateHome")
        Me.UnlockBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LockBtn)
        Me.GroupBox1.Controls.Add(Me.UnlockBtn)
        Me.GroupBox1.Controls.Add(Me.HideBtn)
        Me.GroupBox1.Controls.Add(Me.ShowBtn)
        Me.GroupBox1.Controls.Add(Me.RecentBtn)
        Me.GroupBox1.Controls.Add(Me.CMD)
        Me.GroupBox1.Controls.Add(Me.BlackBtn)
        Me.GroupBox1.Controls.Add(Me.LSDbtn)
        Me.GroupBox1.Controls.Add(Me.PatchTCBtn)
        Me.GroupBox1.Controls.Add(Me.PowerShell)
        Me.GroupBox1.Controls.Add(Me.Volume)
        Me.GroupBox1.Controls.Add(Me.Links)
        Me.GroupBox1.Controls.Add(Me.msgBtn)
        Me.GroupBox1.Controls.Add(Me.ProcessesBtn)
        Me.GroupBox1.Controls.Add(Me.TrayIcon)
        Me.GroupBox1.Controls.Add(Me.Wall)
        Me.GroupBox1.Controls.Add(Me.Support)
        Me.GroupBox1.Controls.Add(Me.WebLogs)
        Me.GroupBox1.Controls.Add(Me.WebAnwendung)
        Me.GroupBox1.Controls.Add(Me.Shortcut)
        Me.GroupBox1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(114, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 173)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LstIP)
        Me.GroupBox3.Controls.Add(Me.btnIP)
        Me.GroupBox3.Controls.Add(Me.txtIP)
        Me.GroupBox3.Controls.Add(Me.RoomTxt)
        Me.GroupBox3.Controls.Add(Me.lefty)
        Me.GroupBox3.Controls.Add(Me.RoomBox)
        Me.GroupBox3.Controls.Add(Me.Spoof)
        Me.GroupBox3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(115, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(197, 106)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Settings"
        '
        'LstIP
        '
        Me.LstIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LstIP.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstIP.FormattingEnabled = True
        Me.LstIP.ItemHeight = 15
        Me.LstIP.Items.AddRange(New Object() {"IP"})
        Me.LstIP.Location = New System.Drawing.Point(102, 47)
        Me.LstIP.Name = "LstIP"
        Me.LstIP.Size = New System.Drawing.Size(84, 19)
        Me.LstIP.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.FindBtn)
        Me.GroupBox2.Controls.Add(Me.MapCustom)
        Me.GroupBox2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(429, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(101, 85)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shares"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.UnlockPCBtn)
        Me.GroupBox4.Controls.Add(Me.ShutdownPCBtn)
        Me.GroupBox4.Controls.Add(Me.LockPCBtn)
        Me.GroupBox4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(318, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(105, 112)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Experiment"
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
        Me.ShutdownPCBtn.TabIndex = 3
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
        Me.LockPCBtn.TabIndex = 1
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
        Me.TitleBar.Size = New System.Drawing.Size(539, 27)
        Me.TitleBar.TabIndex = 5
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
        Me.MinimizeBtn.Location = New System.Drawing.Point(439, 0)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.Size = New System.Drawing.Size(50, 27)
        Me.MinimizeBtn.TabIndex = 1
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
        Me.CloseBtn.Location = New System.Drawing.Point(489, 0)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(50, 27)
        Me.CloseBtn.TabIndex = 0
        Me.CloseBtn.TabStop = False
        Me.CloseBtn.Text = "x"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.GroupBox2)
        Me.MainPanel.Controls.Add(Me.GroupBox1)
        Me.MainPanel.Controls.Add(Me.GroupBox3)
        Me.MainPanel.Controls.Add(Me.GroupBox4)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 27)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(539, 301)
        Me.MainPanel.TabIndex = 7
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.Panel1)
        Me.Sidebar.Controls.Add(Me.SharesBtn)
        Me.Sidebar.Controls.Add(Me.DashboardBtn)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sidebar.Location = New System.Drawing.Point(0, 27)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(108, 301)
        Me.Sidebar.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Silent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 273)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 28)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Silent"
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
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(539, 328)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.Sidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lefty As CheckBox
    Friend WithEvents msgBtn As Button
    Friend WithEvents Spoof As Button
    Friend WithEvents RoomBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents WebAnwendung As Button
    Friend WithEvents Support As Button
    Friend WithEvents RoomTxt As Label
    Friend WithEvents Shortcut As Button
    Friend WithEvents WebLogs As Button
    Friend WithEvents Wall As Button
    Friend WithEvents MapCustom As Button
    Friend WithEvents TrayIcon As Button
    Friend WithEvents ProcessesBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Links As Button
    Friend WithEvents Volume As Button
    Friend WithEvents PatchTCBtn As Button
    Friend WithEvents PowerShell As Button
    Friend WithEvents BlackBtn As Button
    Friend WithEvents btnIP As Button
    Friend WithEvents txtIP As TextBox
    Friend WithEvents LstIP As ListBox
    Friend WithEvents LSDbtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FindBtn As Button
    Friend WithEvents CMD As Button
    Friend WithEvents Silent As CheckBox
    Friend WithEvents RecentBtn As Button
    Friend WithEvents HideBtn As Button
    Friend WithEvents ShowBtn As Button
    Friend WithEvents LockBtn As Button
    Friend WithEvents UnlockBtn As Button
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
    Friend WithEvents Label1 As Label
End Class
