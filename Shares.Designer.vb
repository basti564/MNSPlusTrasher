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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NetworkDrive = New System.Windows.Forms.Label()
        Me.RoomBox = New System.Windows.Forms.TextBox()
        Me.Spoof = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MapNetProg
        '
        Me.MapNetProg.BackColor = System.Drawing.Color.Firebrick
        Me.MapNetProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapNetProg.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapNetProg.ForeColor = System.Drawing.Color.Snow
        Me.MapNetProg.Location = New System.Drawing.Point(215, 164)
        Me.MapNetProg.Name = "MapNetProg"
        Me.MapNetProg.Size = New System.Drawing.Size(87, 24)
        Me.MapNetProg.TabIndex = 15
        Me.MapNetProg.Text = "NetProg"
        Me.ToolTip1.SetToolTip(Me.MapNetProg, "Vom Netz ausführbare Programme")
        Me.MapNetProg.UseVisualStyleBackColor = False
        '
        'MapAWBShare
        '
        Me.MapAWBShare.BackColor = System.Drawing.Color.DarkOrange
        Me.MapAWBShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapAWBShare.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAWBShare.ForeColor = System.Drawing.Color.Snow
        Me.MapAWBShare.Location = New System.Drawing.Point(27, 164)
        Me.MapAWBShare.Name = "MapAWBShare"
        Me.MapAWBShare.Size = New System.Drawing.Size(87, 24)
        Me.MapAWBShare.TabIndex = 13
        Me.MapAWBShare.Text = "AWBShare"
        Me.ToolTip1.SetToolTip(Me.MapAWBShare, "AnwendungsBetreuer Share")
        Me.MapAWBShare.UseVisualStyleBackColor = False
        '
        'MapSrvCD
        '
        Me.MapSrvCD.BackColor = System.Drawing.Color.Firebrick
        Me.MapSrvCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapSrvCD.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapSrvCD.ForeColor = System.Drawing.Color.Snow
        Me.MapSrvCD.Location = New System.Drawing.Point(121, 164)
        Me.MapSrvCD.Name = "MapSrvCD"
        Me.MapSrvCD.Size = New System.Drawing.Size(87, 24)
        Me.MapSrvCD.TabIndex = 14
        Me.MapSrvCD.Text = "SrvCD"
        Me.ToolTip1.SetToolTip(Me.MapSrvCD, "CD/DVD des Servers (Only Works On A Server Duh!)")
        Me.MapSrvCD.UseVisualStyleBackColor = False
        '
        'MapAlleAG
        '
        Me.MapAlleAG.BackColor = System.Drawing.Color.Firebrick
        Me.MapAlleAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapAlleAG.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleAG.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleAG.Location = New System.Drawing.Point(27, 194)
        Me.MapAlleAG.Name = "MapAlleAG"
        Me.MapAlleAG.Size = New System.Drawing.Size(87, 24)
        Me.MapAlleAG.TabIndex = 16
        Me.MapAlleAG.Text = "AlleAG"
        Me.ToolTip1.SetToolTip(Me.MapAlleAG, "Alle AGshares")
        Me.MapAlleAG.UseVisualStyleBackColor = False
        '
        'MapAlleKurse
        '
        Me.MapAlleKurse.BackColor = System.Drawing.Color.Firebrick
        Me.MapAlleKurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapAlleKurse.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleKurse.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleKurse.Location = New System.Drawing.Point(121, 194)
        Me.MapAlleKurse.Name = "MapAlleKurse"
        Me.MapAlleKurse.Size = New System.Drawing.Size(87, 24)
        Me.MapAlleKurse.TabIndex = 17
        Me.MapAlleKurse.Text = "AlleKurse"
        Me.ToolTip1.SetToolTip(Me.MapAlleKurse, "Alle Kursshares")
        Me.MapAlleKurse.UseVisualStyleBackColor = False
        '
        'MapAlleKlassen
        '
        Me.MapAlleKlassen.BackColor = System.Drawing.Color.Firebrick
        Me.MapAlleKlassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapAlleKlassen.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleKlassen.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleKlassen.Location = New System.Drawing.Point(215, 194)
        Me.MapAlleKlassen.Name = "MapAlleKlassen"
        Me.MapAlleKlassen.Size = New System.Drawing.Size(87, 24)
        Me.MapAlleKlassen.TabIndex = 18
        Me.MapAlleKlassen.Text = "AlleKlassen"
        Me.ToolTip1.SetToolTip(Me.MapAlleKlassen, "Alle Klassenshares")
        Me.MapAlleKlassen.UseVisualStyleBackColor = False
        '
        'MapTauschLehrer
        '
        Me.MapTauschLehrer.BackColor = System.Drawing.Color.Firebrick
        Me.MapTauschLehrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapTauschLehrer.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapTauschLehrer.ForeColor = System.Drawing.Color.Snow
        Me.MapTauschLehrer.Location = New System.Drawing.Point(27, 224)
        Me.MapTauschLehrer.Name = "MapTauschLehrer"
        Me.MapTauschLehrer.Size = New System.Drawing.Size(87, 24)
        Me.MapTauschLehrer.TabIndex = 19
        Me.MapTauschLehrer.Text = "TauschLehrer"
        Me.ToolTip1.SetToolTip(Me.MapTauschLehrer, "Lehrer Austauschshare")
        Me.MapTauschLehrer.UseVisualStyleBackColor = False
        '
        'MapPublicLehrerSchüler
        '
        Me.MapPublicLehrerSchüler.BackColor = System.Drawing.Color.Firebrick
        Me.MapPublicLehrerSchüler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapPublicLehrerSchüler.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapPublicLehrerSchüler.ForeColor = System.Drawing.Color.Snow
        Me.MapPublicLehrerSchüler.Location = New System.Drawing.Point(121, 224)
        Me.MapPublicLehrerSchüler.Name = "MapPublicLehrerSchüler"
        Me.MapPublicLehrerSchüler.Size = New System.Drawing.Size(87, 24)
        Me.MapPublicLehrerSchüler.TabIndex = 20
        Me.MapPublicLehrerSchüler.Text = "PublicLehrer"
        Me.ToolTip1.SetToolTip(Me.MapPublicLehrerSchüler, "Alle Public Homeshares der Lehrer")
        Me.MapPublicLehrerSchüler.UseVisualStyleBackColor = False
        '
        'MapHomesSchüler
        '
        Me.MapHomesSchüler.BackColor = System.Drawing.Color.Firebrick
        Me.MapHomesSchüler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MapHomesSchüler.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapHomesSchüler.ForeColor = System.Drawing.Color.Snow
        Me.MapHomesSchüler.Location = New System.Drawing.Point(215, 224)
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
        Me.FindBtn.Location = New System.Drawing.Point(120, 122)
        Me.FindBtn.Name = "FindBtn"
        Me.FindBtn.Size = New System.Drawing.Size(87, 24)
        Me.FindBtn.TabIndex = 23
        Me.FindBtn.Text = "Find"
        Me.ToolTip1.SetToolTip(Me.FindBtn, "Find /Hidden/ Shares")
        Me.FindBtn.UseVisualStyleBackColor = False
        '
        'Mapbtn
        '
        Me.Mapbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Mapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mapbtn.ForeColor = System.Drawing.Color.Snow
        Me.Mapbtn.Location = New System.Drawing.Point(121, 68)
        Me.Mapbtn.Name = "Mapbtn"
        Me.Mapbtn.Size = New System.Drawing.Size(88, 23)
        Me.Mapbtn.TabIndex = 54
        Me.Mapbtn.Text = "Map"
        Me.ToolTip1.SetToolTip(Me.Mapbtn, "Map That Drive")
        Me.Mapbtn.UseVisualStyleBackColor = False
        '
        'Removebtn
        '
        Me.Removebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Removebtn.ForeColor = System.Drawing.Color.Snow
        Me.Removebtn.Location = New System.Drawing.Point(27, 68)
        Me.Removebtn.Name = "Removebtn"
        Me.Removebtn.Size = New System.Drawing.Size(88, 23)
        Me.Removebtn.TabIndex = 53
        Me.Removebtn.Text = "Remove"
        Me.ToolTip1.SetToolTip(Me.Removebtn, "Remove Drive")
        Me.Removebtn.UseVisualStyleBackColor = False
        '
        'Path
        '
        Me.Path.Location = New System.Drawing.Point(52, 42)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(250, 21)
        Me.Path.TabIndex = 52
        Me.Path.Text = "\\MNSPlusFile\Anwendungsbetreuer$"
        Me.ToolTip1.SetToolTip(Me.Path, "Network Drive Path")
        '
        'Letter
        '
        Me.Letter.Location = New System.Drawing.Point(27, 42)
        Me.Letter.Name = "Letter"
        Me.Letter.Size = New System.Drawing.Size(19, 21)
        Me.Letter.TabIndex = 51
        Me.Letter.Text = "S:"
        Me.ToolTip1.SetToolTip(Me.Letter, "DriveLetter")
        '
        'Panel1
        '
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(86, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 265)
        Me.Panel1.TabIndex = 22
        '
        'NetworkDrive
        '
        Me.NetworkDrive.AutoSize = True
        Me.NetworkDrive.BackColor = System.Drawing.Color.Transparent
        Me.NetworkDrive.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkDrive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NetworkDrive.Location = New System.Drawing.Point(24, 21)
        Me.NetworkDrive.Name = "NetworkDrive"
        Me.NetworkDrive.Size = New System.Drawing.Size(103, 18)
        Me.NetworkDrive.TabIndex = 55
        Me.NetworkDrive.Text = "Network Drive"
        '
        'RoomBox
        '
        Me.RoomBox.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomBox.Location = New System.Drawing.Point(27, 97)
        Me.RoomBox.Name = "RoomBox"
        Me.RoomBox.Size = New System.Drawing.Size(88, 21)
        Me.RoomBox.TabIndex = 57
        Me.RoomBox.Text = "R-CO1"
        Me.ToolTip1.SetToolTip(Me.RoomBox, "Room To Be Spoofed")
        '
        'Spoof
        '
        Me.Spoof.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Spoof.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Spoof.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spoof.ForeColor = System.Drawing.Color.Snow
        Me.Spoof.Location = New System.Drawing.Point(27, 122)
        Me.Spoof.Name = "Spoof"
        Me.Spoof.Size = New System.Drawing.Size(87, 24)
        Me.Spoof.TabIndex = 58
        Me.Spoof.Text = "SpoofRoom"
        Me.ToolTip1.SetToolTip(Me.Spoof, "Spoof Room Shares (A:)")
        Me.Spoof.UseVisualStyleBackColor = False
        '
        'Shares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 265)
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
End Class
