<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LegacyLinks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LegacyLinks))
        Me.Schülermodul = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintLogs = New System.Windows.Forms.Button()
        Me.UpdateSettings = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Schülermodul
        '
        Me.Schülermodul.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Schülermodul.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Schülermodul.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Schülermodul.ForeColor = System.Drawing.Color.Snow
        Me.Schülermodul.Location = New System.Drawing.Point(3, 3)
        Me.Schülermodul.Name = "Schülermodul"
        Me.Schülermodul.Size = New System.Drawing.Size(88, 23)
        Me.Schülermodul.TabIndex = 1
        Me.Schülermodul.Text = "Schülermodul"
        Me.ToolTip1.SetToolTip(Me.Schülermodul, "Opens Schülermodul In The Browser")
        Me.Schülermodul.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Snow
        Me.Button3.Location = New System.Drawing.Point(97, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "???"
        Me.ToolTip1.SetToolTip(Me.Button3, "Opens Http://mnsplusweb:81/main/index.aspx In The Browser")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(3, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CHPwd"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintLogs
        '
        Me.PrintLogs.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PrintLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintLogs.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintLogs.ForeColor = System.Drawing.Color.Snow
        Me.PrintLogs.Location = New System.Drawing.Point(3, 61)
        Me.PrintLogs.Name = "PrintLogs"
        Me.PrintLogs.Size = New System.Drawing.Size(88, 23)
        Me.PrintLogs.TabIndex = 4
        Me.PrintLogs.Text = "PrintLogs"
        Me.PrintLogs.UseVisualStyleBackColor = False
        '
        'UpdateSettings
        '
        Me.UpdateSettings.BackColor = System.Drawing.Color.LightSeaGreen
        Me.UpdateSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateSettings.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateSettings.ForeColor = System.Drawing.Color.Snow
        Me.UpdateSettings.Location = New System.Drawing.Point(97, 32)
        Me.UpdateSettings.Name = "UpdateSettings"
        Me.UpdateSettings.Size = New System.Drawing.Size(88, 23)
        Me.UpdateSettings.TabIndex = 5
        Me.UpdateSettings.Text = "USettings"
        Me.UpdateSettings.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.Schülermodul)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.UpdateSettings)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintLogs)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(188, 92)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'LegacyLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = Global.MNSTrasher.My.Resources.Resources.Links
        Me.ClientSize = New System.Drawing.Size(209, 116)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LegacyLinks"
        Me.Text = "Broken Legacy Links"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Schülermodul As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintLogs As Button
    Friend WithEvents UpdateSettings As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ToolTip1 As ToolTip
End Class
