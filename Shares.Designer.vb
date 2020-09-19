<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Shares
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shares))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MapNetProg = New System.Windows.Forms.Button()
        Me.MapAWBShare = New System.Windows.Forms.Button()
        Me.MapSrvCD = New System.Windows.Forms.Button()
        Me.MapAlleAG = New System.Windows.Forms.Button()
        Me.MapAlleKurse = New System.Windows.Forms.Button()
        Me.MapAlleKlassen = New System.Windows.Forms.Button()
        Me.MapTauschLehrer = New System.Windows.Forms.Button()
        Me.MapPublicLehrerSchüler = New System.Windows.Forms.Button()
        Me.MapHomesSchüler = New System.Windows.Forms.Button()
        Me.FindBtn = New System.Windows.Forms.Button()
        Me.Mapbtn = New System.Windows.Forms.Button()
        Me.Removebtn = New System.Windows.Forms.Button()
        Me.Path = New System.Windows.Forms.TextBox()
        Me.Letter = New System.Windows.Forms.TextBox()
        Me.RoomBox = New System.Windows.Forms.TextBox()
        Me.Spoof = New System.Windows.Forms.Button()
        Me.LockBtn = New System.Windows.Forms.Button()
        Me.UnlockBtn = New System.Windows.Forms.Button()
        Me.HideBtn = New System.Windows.Forms.Button()
        Me.ShowBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NetworkDrive = New System.Windows.Forms.Label()
        Me.SpoofRoom = New System.Windows.Forms.Label()
        Me.AdminOnly = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MapNetProg
        '
        Me.MapNetProg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MapNetProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapNetProg.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapNetProg.ForeColor = System.Drawing.Color.Snow
        Me.MapNetProg.Location = New System.Drawing.Point(253, 184)
        Me.MapNetProg.Name = "MapNetProg"
        Me.MapNetProg.Size = New System.Drawing.Size(87, 24)
        Me.MapNetProg.TabIndex = 15
        Me.MapNetProg.Text = "NetProg"
        Me.ToolTip1.SetToolTip(Me.MapNetProg, "Vom Netz ausführbare Programme")
        Me.MapNetProg.UseVisualStyleBackColor = False
        '
        'MapAWBShare
        '
        Me.MapAWBShare.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.MapAWBShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapAWBShare.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAWBShare.ForeColor = System.Drawing.Color.Snow
        Me.MapAWBShare.Location = New System.Drawing.Point(65, 184)
        Me.MapAWBShare.Name = "MapAWBShare"
        Me.MapAWBShare.Size = New System.Drawing.Size(87, 24)
        Me.MapAWBShare.TabIndex = 13
        Me.MapAWBShare.Text = "AWBShare"
        Me.ToolTip1.SetToolTip(Me.MapAWBShare, "AnwendungsBetreuer Share")
        Me.MapAWBShare.UseVisualStyleBackColor = False
        '
        'MapSrvCD
        '
        Me.MapSrvCD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MapSrvCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapSrvCD.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapSrvCD.ForeColor = System.Drawing.Color.Snow
        Me.MapSrvCD.Location = New System.Drawing.Point(159, 184)
        Me.MapSrvCD.Name = "MapSrvCD"
        Me.MapSrvCD.Size = New System.Drawing.Size(87, 24)
        Me.MapSrvCD.TabIndex = 14
        Me.MapSrvCD.Text = "SrvCD"
        Me.ToolTip1.SetToolTip(Me.MapSrvCD, "CD/DVD des Servers (Only Works On A Server Duh!)")
        Me.MapSrvCD.UseVisualStyleBackColor = False
        '
        'MapAlleAG
        '
        Me.MapAlleAG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MapAlleAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapAlleAG.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleAG.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleAG.Location = New System.Drawing.Point(65, 214)
        Me.MapAlleAG.Name = "MapAlleAG"
        Me.MapAlleAG.Size = New System.Drawing.Size(87, 24)
        Me.MapAlleAG.TabIndex = 16
        Me.MapAlleAG.Text = "AlleAG"
        Me.ToolTip1.SetToolTip(Me.MapAlleAG, "Alle AGshares")
        Me.MapAlleAG.UseVisualStyleBackColor = False
        '
        'MapAlleKurse
        '
        Me.MapAlleKurse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MapAlleKurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapAlleKurse.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleKurse.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleKurse.Location = New System.Drawing.Point(159, 214)
        Me.MapAlleKurse.Name = "MapAlleKurse"
        Me.MapAlleKurse.Size = New System.Drawing.Size(87, 24)
        Me.MapAlleKurse.TabIndex = 17
        Me.MapAlleKurse.Text = "AlleKurse"
        Me.ToolTip1.SetToolTip(Me.MapAlleKurse, "Alle Kursshares")
        Me.MapAlleKurse.UseVisualStyleBackColor = False
        '
        'MapAlleKlassen
        '
        Me.MapAlleKlassen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MapAlleKlassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapAlleKlassen.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleKlassen.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleKlassen.Location = New System.Drawing.Point(253, 214)
        Me.MapAlleKlassen.Name = "MapAlleKlassen"
        Me.MapAlleKlassen.Size = New System.Drawing.Size(87, 24)
        Me.MapAlleKlassen.TabIndex = 18
        Me.MapAlleKlassen.Text = "AlleKlassen"
        Me.ToolTip1.SetToolTip(Me.MapAlleKlassen, "Alle Klassenshares")
        Me.MapAlleKlassen.UseVisualStyleBackColor = False
        '
        'MapTauschLehrer
        '
        Me.MapTauschLehrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MapTauschLehrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapTauschLehrer.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapTauschLehrer.ForeColor = System.Drawing.Color.Snow
        Me.MapTauschLehrer.Location = New System.Drawing.Point(65, 244)
        Me.MapTauschLehrer.Name = "MapTauschLehrer"
        Me.MapTauschLehrer.Size = New System.Drawing.Size(87, 24)
        Me.MapTauschLehrer.TabIndex = 19
        Me.MapTauschLehrer.Text = "TauschLehrer"
        Me.ToolTip1.SetToolTip(Me.MapTauschLehrer, "Lehrer Austauschshare")
        Me.MapTauschLehrer.UseVisualStyleBackColor = False
        '
        'MapPublicLehrerSchüler
        '
        Me.MapPublicLehrerSchüler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MapPublicLehrerSchüler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapPublicLehrerSchüler.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapPublicLehrerSchüler.ForeColor = System.Drawing.Color.Snow
        Me.MapPublicLehrerSchüler.Location = New System.Drawing.Point(159, 244)
        Me.MapPublicLehrerSchüler.Name = "MapPublicLehrerSchüler"
        Me.MapPublicLehrerSchüler.Size = New System.Drawing.Size(87, 24)
        Me.MapPublicLehrerSchüler.TabIndex = 20
        Me.MapPublicLehrerSchüler.Text = "PublicLehrer"
        Me.ToolTip1.SetToolTip(Me.MapPublicLehrerSchüler, "Alle Public Homeshares der Lehrer")
        Me.MapPublicLehrerSchüler.UseVisualStyleBackColor = False
        '
        'MapHomesSchüler
        '
        Me.MapHomesSchüler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MapHomesSchüler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapHomesSchüler.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapHomesSchüler.ForeColor = System.Drawing.Color.Snow
        Me.MapHomesSchüler.Location = New System.Drawing.Point(253, 244)
        Me.MapHomesSchüler.Name = "MapHomesSchüler"
        Me.MapHomesSchüler.Size = New System.Drawing.Size(87, 24)
        Me.MapHomesSchüler.TabIndex = 21
        Me.MapHomesSchüler.Text = "HomesSchüler"
        Me.ToolTip1.SetToolTip(Me.MapHomesSchüler, "Alle Privat Homeshares der Schueler")
        Me.MapHomesSchüler.UseVisualStyleBackColor = False
        '
        'FindBtn
        '
        Me.FindBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.FindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindBtn.ForeColor = System.Drawing.Color.Snow
        Me.FindBtn.Location = New System.Drawing.Point(201, 57)
        Me.FindBtn.Name = "FindBtn"
        Me.FindBtn.Size = New System.Drawing.Size(87, 24)
        Me.FindBtn.TabIndex = 5
        Me.FindBtn.Text = "Find"
        Me.ToolTip1.SetToolTip(Me.FindBtn, "Find /Hidden/ Shares")
        Me.FindBtn.UseVisualStyleBackColor = False
        '
        'Mapbtn
        '
        Me.Mapbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Mapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mapbtn.ForeColor = System.Drawing.Color.Snow
        Me.Mapbtn.Location = New System.Drawing.Point(108, 57)
        Me.Mapbtn.Name = "Mapbtn"
        Me.Mapbtn.Size = New System.Drawing.Size(87, 24)
        Me.Mapbtn.TabIndex = 4
        Me.Mapbtn.Text = "Map"
        Me.ToolTip1.SetToolTip(Me.Mapbtn, "Map That Drive")
        Me.Mapbtn.UseVisualStyleBackColor = False
        '
        'Removebtn
        '
        Me.Removebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Removebtn.ForeColor = System.Drawing.Color.Snow
        Me.Removebtn.Location = New System.Drawing.Point(15, 57)
        Me.Removebtn.Name = "Removebtn"
        Me.Removebtn.Size = New System.Drawing.Size(87, 24)
        Me.Removebtn.TabIndex = 3
        Me.Removebtn.Text = "Remove"
        Me.ToolTip1.SetToolTip(Me.Removebtn, "Remove Drive")
        Me.Removebtn.UseVisualStyleBackColor = False
        '
        'Path
        '
        Me.Path.Location = New System.Drawing.Point(43, 30)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(244, 21)
        Me.Path.TabIndex = 2
        Me.Path.Text = "\\MNSPlusFile\Anwendungsbetreuer$"
        Me.ToolTip1.SetToolTip(Me.Path, "Network Drive Path")
        '
        'Letter
        '
        Me.Letter.Location = New System.Drawing.Point(15, 30)
        Me.Letter.Name = "Letter"
        Me.Letter.Size = New System.Drawing.Size(19, 21)
        Me.Letter.TabIndex = 1
        Me.Letter.Text = "S:"
        Me.ToolTip1.SetToolTip(Me.Letter, "DriveLetter")
        '
        'RoomBox
        '
        Me.RoomBox.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomBox.Location = New System.Drawing.Point(293, 30)
        Me.RoomBox.Name = "RoomBox"
        Me.RoomBox.Size = New System.Drawing.Size(88, 21)
        Me.RoomBox.TabIndex = 6
        Me.RoomBox.Text = "R-CO1"
        Me.ToolTip1.SetToolTip(Me.RoomBox, "Room To Be Spoofed")
        '
        'Spoof
        '
        Me.Spoof.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Spoof.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Spoof.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spoof.ForeColor = System.Drawing.Color.Snow
        Me.Spoof.Location = New System.Drawing.Point(294, 57)
        Me.Spoof.Name = "Spoof"
        Me.Spoof.Size = New System.Drawing.Size(87, 24)
        Me.Spoof.TabIndex = 7
        Me.Spoof.Text = "SpoofRoom"
        Me.ToolTip1.SetToolTip(Me.Spoof, "Spoof Room Shares (A:)")
        Me.Spoof.UseVisualStyleBackColor = False
        '
        'LockBtn
        '
        Me.LockBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LockBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LockBtn.ForeColor = System.Drawing.Color.Snow
        Me.LockBtn.Location = New System.Drawing.Point(15, 117)
        Me.LockBtn.Name = "LockBtn"
        Me.LockBtn.Size = New System.Drawing.Size(87, 24)
        Me.LockBtn.TabIndex = 10
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
        Me.UnlockBtn.Location = New System.Drawing.Point(109, 117)
        Me.UnlockBtn.Name = "UnlockBtn"
        Me.UnlockBtn.Size = New System.Drawing.Size(87, 24)
        Me.UnlockBtn.TabIndex = 11
        Me.UnlockBtn.Text = "UnlockHome"
        Me.ToolTip1.SetToolTip(Me.UnlockBtn, "Unlock All Files And Folders In PrivateHome")
        Me.UnlockBtn.UseVisualStyleBackColor = False
        '
        'HideBtn
        '
        Me.HideBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.HideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideBtn.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HideBtn.ForeColor = System.Drawing.Color.Snow
        Me.HideBtn.Location = New System.Drawing.Point(15, 87)
        Me.HideBtn.Name = "HideBtn"
        Me.HideBtn.Size = New System.Drawing.Size(87, 24)
        Me.HideBtn.TabIndex = 8
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
        Me.ShowBtn.Location = New System.Drawing.Point(109, 87)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(87, 24)
        Me.ShowBtn.TabIndex = 9
        Me.ShowBtn.Text = "ShowHome"
        Me.ToolTip1.SetToolTip(Me.ShowBtn, "Show All Files And Folders In PrivateHome")
        Me.ShowBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AdminOnly)
        Me.Panel1.Controls.Add(Me.SpoofRoom)
        Me.Panel1.Controls.Add(Me.LockBtn)
        Me.Panel1.Controls.Add(Me.UnlockBtn)
        Me.Panel1.Controls.Add(Me.HideBtn)
        Me.Panel1.Controls.Add(Me.ShowBtn)
        Me.Panel1.Controls.Add(Me.RoomBox)
        Me.Panel1.Controls.Add(Me.Spoof)
        Me.Panel1.Controls.Add(Me.NetworkDrive)
        Me.Panel1.Controls.Add(Me.Mapbtn)
        Me.Panel1.Controls.Add(Me.Removebtn)
        Me.Panel1.Controls.Add(Me.Path)
        Me.Panel1.Controls.Add(Me.Letter)
        Me.Panel1.Controls.Add(Me.FindBtn)
        Me.Panel1.Controls.Add(Me.MapAWBShare)
        Me.Panel1.Controls.Add(Me.MapNetProg)
        Me.Panel1.Controls.Add(Me.MapHomesSchüler)
        Me.Panel1.Controls.Add(Me.MapPublicLehrerSchüler)
        Me.Panel1.Controls.Add(Me.MapSrvCD)
        Me.Panel1.Controls.Add(Me.MapTauschLehrer)
        Me.Panel1.Controls.Add(Me.MapAlleAG)
        Me.Panel1.Controls.Add(Me.MapAlleKlassen)
        Me.Panel1.Controls.Add(Me.MapAlleKurse)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 300)
        Me.Panel1.TabIndex = 0
        '
        'NetworkDrive
        '
        Me.NetworkDrive.AutoSize = True
        Me.NetworkDrive.BackColor = System.Drawing.Color.Transparent
        Me.NetworkDrive.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkDrive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NetworkDrive.Location = New System.Drawing.Point(12, 9)
        Me.NetworkDrive.Name = "NetworkDrive"
        Me.NetworkDrive.Size = New System.Drawing.Size(103, 18)
        Me.NetworkDrive.TabIndex = 55
        Me.NetworkDrive.Text = "Network Drive"
        '
        'SpoofRoom
        '
        Me.SpoofRoom.AutoSize = True
        Me.SpoofRoom.BackColor = System.Drawing.Color.Transparent
        Me.SpoofRoom.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpoofRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SpoofRoom.Location = New System.Drawing.Point(291, 9)
        Me.SpoofRoom.Name = "SpoofRoom"
        Me.SpoofRoom.Size = New System.Drawing.Size(87, 18)
        Me.SpoofRoom.TabIndex = 63
        Me.SpoofRoom.Text = "Spoof Room"
        '
        'AdminOnly
        '
        Me.AdminOnly.AutoSize = True
        Me.AdminOnly.BackColor = System.Drawing.Color.Transparent
        Me.AdminOnly.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AdminOnly.Location = New System.Drawing.Point(93, 163)
        Me.AdminOnly.Name = "AdminOnly"
        Me.AdminOnly.Size = New System.Drawing.Size(223, 18)
        Me.AdminOnly.TabIndex = 64
        Me.AdminOnly.Text = "Teacher/AWB/Server Only Sorry!"
        '
        'Shares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Shares"
        Me.Text = "Shares"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MapNetProg As Button
    Friend WithEvents MapAWBShare As Button
    Friend WithEvents MapSrvCD As Button
    Friend WithEvents MapAlleAG As Button
    Friend WithEvents MapAlleKurse As Button
    Friend WithEvents MapAlleKlassen As Button
    Friend WithEvents MapTauschLehrer As Button
    Friend WithEvents MapPublicLehrerSchüler As Button
    Friend WithEvents MapHomesSchüler As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FindBtn As Button
    Friend WithEvents NetworkDrive As Label
    Friend WithEvents Mapbtn As Button
    Friend WithEvents Removebtn As Button
    Friend WithEvents Path As TextBox
    Friend WithEvents Letter As TextBox
    Friend WithEvents RoomBox As TextBox
    Friend WithEvents Spoof As Button
    Friend WithEvents LockBtn As Button
    Friend WithEvents UnlockBtn As Button
    Friend WithEvents HideBtn As Button
    Friend WithEvents ShowBtn As Button
    Friend WithEvents AdminOnly As Label
    Friend WithEvents SpoofRoom As Label
End Class
