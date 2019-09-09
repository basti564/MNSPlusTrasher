<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomDrive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomDrive))
        Me.NetworkDrive = New System.Windows.Forms.Label()
        Me.Mapbtn = New System.Windows.Forms.Button()
        Me.Removebtn = New System.Windows.Forms.Button()
        Me.Path = New System.Windows.Forms.TextBox()
        Me.Letter = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'NetworkDrive
        '
        Me.NetworkDrive.AutoSize = True
        Me.NetworkDrive.BackColor = System.Drawing.Color.Transparent
        Me.NetworkDrive.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkDrive.ForeColor = System.Drawing.Color.Teal
        Me.NetworkDrive.Location = New System.Drawing.Point(12, 9)
        Me.NetworkDrive.Name = "NetworkDrive"
        Me.NetworkDrive.Size = New System.Drawing.Size(83, 17)
        Me.NetworkDrive.TabIndex = 50
        Me.NetworkDrive.Text = "Network Drive"
        '
        'Mapbtn
        '
        Me.Mapbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Mapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Mapbtn.ForeColor = System.Drawing.Color.Snow
        Me.Mapbtn.Location = New System.Drawing.Point(106, 54)
        Me.Mapbtn.Name = "Mapbtn"
        Me.Mapbtn.Size = New System.Drawing.Size(88, 23)
        Me.Mapbtn.TabIndex = 49
        Me.Mapbtn.Text = "Map"
        Me.ToolTip1.SetToolTip(Me.Mapbtn, "Map That Drive")
        Me.Mapbtn.UseVisualStyleBackColor = False
        '
        'Removebtn
        '
        Me.Removebtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Removebtn.ForeColor = System.Drawing.Color.Snow
        Me.Removebtn.Location = New System.Drawing.Point(12, 54)
        Me.Removebtn.Name = "Removebtn"
        Me.Removebtn.Size = New System.Drawing.Size(88, 23)
        Me.Removebtn.TabIndex = 48
        Me.Removebtn.Text = "Remove"
        Me.ToolTip1.SetToolTip(Me.Removebtn, "Remove Drive")
        Me.Removebtn.UseVisualStyleBackColor = False
        '
        'Path
        '
        Me.Path.Location = New System.Drawing.Point(37, 28)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(157, 20)
        Me.Path.TabIndex = 47
        Me.Path.Text = "\\MNSPlusFile\Anwendungsbetreuer$"
        Me.ToolTip1.SetToolTip(Me.Path, "Network Drive Path")
        '
        'Letter
        '
        Me.Letter.Location = New System.Drawing.Point(12, 28)
        Me.Letter.Name = "Letter"
        Me.Letter.Size = New System.Drawing.Size(19, 20)
        Me.Letter.TabIndex = 46
        Me.Letter.Text = "S:"
        Me.ToolTip1.SetToolTip(Me.Letter, "DriveLetter")
        '
        'CustomDrive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = Global.MNSTrasher.My.Resources.Resources.Links
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(204, 86)
        Me.Controls.Add(Me.NetworkDrive)
        Me.Controls.Add(Me.Mapbtn)
        Me.Controls.Add(Me.Removebtn)
        Me.Controls.Add(Me.Path)
        Me.Controls.Add(Me.Letter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomDrive"
        Me.Text = "Custom Drive"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NetworkDrive As Label
    Friend WithEvents Mapbtn As Button
    Friend WithEvents Removebtn As Button
    Friend WithEvents Path As TextBox
    Friend WithEvents Letter As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
