<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.indicator = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ApplicationTitle.Location = New System.Drawing.Point(29, 35)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(250, 39)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Application Title"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Version.Location = New System.Drawing.Point(291, 35)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(182, 39)
        Me.Version.TabIndex = 1
        Me.Version.Text = "v{0}.{1:0}.{2}"
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Copyright.Location = New System.Drawing.Point(32, 77)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(79, 19)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright"
        '
        'indicator
        '
        Me.indicator.AutoSize = True
        Me.indicator.BackColor = System.Drawing.Color.Transparent
        Me.indicator.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator.ForeColor = System.Drawing.Color.Black
        Me.indicator.Location = New System.Drawing.Point(29, 112)
        Me.indicator.Name = "indicator"
        Me.indicator.Size = New System.Drawing.Size(174, 39)
        Me.indicator.TabIndex = 3
        Me.indicator.Text = "[Blackout]"
        Me.indicator.Visible = False
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MNSTrasher.My.Resources.Resources.MainBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(498, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.indicator)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents indicator As Label
End Class
