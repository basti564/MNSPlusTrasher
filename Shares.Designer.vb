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
        Me.SuspendLayout()
        '
        'MapNetProg
        '
        Me.MapNetProg.BackColor = System.Drawing.Color.Firebrick
        Me.MapNetProg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapNetProg.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapNetProg.ForeColor = System.Drawing.Color.Snow
        Me.MapNetProg.Location = New System.Drawing.Point(200, 11)
        Me.MapNetProg.Name = "MapNetProg"
        Me.MapNetProg.Size = New System.Drawing.Size(88, 24)
        Me.MapNetProg.TabIndex = 15
        Me.MapNetProg.Text = "NetProg"
        Me.ToolTip1.SetToolTip(Me.MapNetProg, "Vom Netz ausführbare Programme")
        Me.MapNetProg.UseVisualStyleBackColor = False
        '
        'MapAWBShare
        '
        Me.MapAWBShare.BackColor = System.Drawing.Color.DarkOrange
        Me.MapAWBShare.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapAWBShare.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAWBShare.ForeColor = System.Drawing.Color.Snow
        Me.MapAWBShare.Location = New System.Drawing.Point(12, 11)
        Me.MapAWBShare.Name = "MapAWBShare"
        Me.MapAWBShare.Size = New System.Drawing.Size(88, 24)
        Me.MapAWBShare.TabIndex = 13
        Me.MapAWBShare.Text = "AWBShare"
        Me.ToolTip1.SetToolTip(Me.MapAWBShare, "AnwendungsBetreuer Share")
        Me.MapAWBShare.UseVisualStyleBackColor = False
        '
        'MapSrvCD
        '
        Me.MapSrvCD.BackColor = System.Drawing.Color.Firebrick
        Me.MapSrvCD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapSrvCD.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapSrvCD.ForeColor = System.Drawing.Color.Snow
        Me.MapSrvCD.Location = New System.Drawing.Point(106, 11)
        Me.MapSrvCD.Name = "MapSrvCD"
        Me.MapSrvCD.Size = New System.Drawing.Size(88, 24)
        Me.MapSrvCD.TabIndex = 14
        Me.MapSrvCD.Text = "SrvCD"
        Me.ToolTip1.SetToolTip(Me.MapSrvCD, "CD/DVD des Servers (Only Works On A Server Duh!)")
        Me.MapSrvCD.UseVisualStyleBackColor = False
        '
        'MapAlleAG
        '
        Me.MapAlleAG.BackColor = System.Drawing.Color.Firebrick
        Me.MapAlleAG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapAlleAG.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleAG.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleAG.Location = New System.Drawing.Point(12, 41)
        Me.MapAlleAG.Name = "MapAlleAG"
        Me.MapAlleAG.Size = New System.Drawing.Size(88, 24)
        Me.MapAlleAG.TabIndex = 16
        Me.MapAlleAG.Text = "AlleAG"
        Me.ToolTip1.SetToolTip(Me.MapAlleAG, "Alle AGshares")
        Me.MapAlleAG.UseVisualStyleBackColor = False
        '
        'MapAlleKurse
        '
        Me.MapAlleKurse.BackColor = System.Drawing.Color.Firebrick
        Me.MapAlleKurse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapAlleKurse.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleKurse.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleKurse.Location = New System.Drawing.Point(106, 41)
        Me.MapAlleKurse.Name = "MapAlleKurse"
        Me.MapAlleKurse.Size = New System.Drawing.Size(88, 24)
        Me.MapAlleKurse.TabIndex = 17
        Me.MapAlleKurse.Text = "AlleKurse"
        Me.ToolTip1.SetToolTip(Me.MapAlleKurse, "Alle Kursshares")
        Me.MapAlleKurse.UseVisualStyleBackColor = False
        '
        'MapAlleKlassen
        '
        Me.MapAlleKlassen.BackColor = System.Drawing.Color.Firebrick
        Me.MapAlleKlassen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapAlleKlassen.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapAlleKlassen.ForeColor = System.Drawing.Color.Snow
        Me.MapAlleKlassen.Location = New System.Drawing.Point(200, 41)
        Me.MapAlleKlassen.Name = "MapAlleKlassen"
        Me.MapAlleKlassen.Size = New System.Drawing.Size(88, 24)
        Me.MapAlleKlassen.TabIndex = 18
        Me.MapAlleKlassen.Text = "AlleKlassen"
        Me.ToolTip1.SetToolTip(Me.MapAlleKlassen, "Alle Klassenshares")
        Me.MapAlleKlassen.UseVisualStyleBackColor = False
        '
        'MapTauschLehrer
        '
        Me.MapTauschLehrer.BackColor = System.Drawing.Color.Firebrick
        Me.MapTauschLehrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapTauschLehrer.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapTauschLehrer.ForeColor = System.Drawing.Color.Snow
        Me.MapTauschLehrer.Location = New System.Drawing.Point(12, 71)
        Me.MapTauschLehrer.Name = "MapTauschLehrer"
        Me.MapTauschLehrer.Size = New System.Drawing.Size(88, 24)
        Me.MapTauschLehrer.TabIndex = 19
        Me.MapTauschLehrer.Text = "TauschLehrer"
        Me.ToolTip1.SetToolTip(Me.MapTauschLehrer, "Lehrer Austauschshare")
        Me.MapTauschLehrer.UseVisualStyleBackColor = False
        '
        'MapPublicLehrerSchüler
        '
        Me.MapPublicLehrerSchüler.BackColor = System.Drawing.Color.Firebrick
        Me.MapPublicLehrerSchüler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapPublicLehrerSchüler.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapPublicLehrerSchüler.ForeColor = System.Drawing.Color.Snow
        Me.MapPublicLehrerSchüler.Location = New System.Drawing.Point(106, 71)
        Me.MapPublicLehrerSchüler.Name = "MapPublicLehrerSchüler"
        Me.MapPublicLehrerSchüler.Size = New System.Drawing.Size(88, 24)
        Me.MapPublicLehrerSchüler.TabIndex = 20
        Me.MapPublicLehrerSchüler.Text = "PublicLehrer"
        Me.ToolTip1.SetToolTip(Me.MapPublicLehrerSchüler, "Alle Public Homeshares der Lehrer")
        Me.MapPublicLehrerSchüler.UseVisualStyleBackColor = False
        '
        'MapHomesSchüler
        '
        Me.MapHomesSchüler.BackColor = System.Drawing.Color.Firebrick
        Me.MapHomesSchüler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MapHomesSchüler.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapHomesSchüler.ForeColor = System.Drawing.Color.Snow
        Me.MapHomesSchüler.Location = New System.Drawing.Point(200, 71)
        Me.MapHomesSchüler.Name = "MapHomesSchüler"
        Me.MapHomesSchüler.Size = New System.Drawing.Size(88, 24)
        Me.MapHomesSchüler.TabIndex = 21
        Me.MapHomesSchüler.Text = "HomesSchüler"
        Me.ToolTip1.SetToolTip(Me.MapHomesSchüler, "Alle Privat Homeshares der Schueler")
        Me.MapHomesSchüler.UseVisualStyleBackColor = False
        '
        'Shares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MNSTrasher.My.Resources.Resources.Links
        Me.ClientSize = New System.Drawing.Size(301, 103)
        Me.Controls.Add(Me.MapNetProg)
        Me.Controls.Add(Me.MapAWBShare)
        Me.Controls.Add(Me.MapSrvCD)
        Me.Controls.Add(Me.MapAlleAG)
        Me.Controls.Add(Me.MapAlleKurse)
        Me.Controls.Add(Me.MapAlleKlassen)
        Me.Controls.Add(Me.MapTauschLehrer)
        Me.Controls.Add(Me.MapPublicLehrerSchüler)
        Me.Controls.Add(Me.MapHomesSchüler)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Shares"
        Me.Text = "Shares"
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
End Class
