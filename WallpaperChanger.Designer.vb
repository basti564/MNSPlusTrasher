<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WallpaperChanger
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
        Me.Wallpaper = New System.Windows.Forms.Label()
        Me.TextBoxLocation = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Wallpaper
        '
        Me.Wallpaper.AutoSize = True
        Me.Wallpaper.BackColor = System.Drawing.Color.Transparent
        Me.Wallpaper.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wallpaper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Wallpaper.Location = New System.Drawing.Point(12, 9)
        Me.Wallpaper.Name = "Wallpaper"
        Me.Wallpaper.Size = New System.Drawing.Size(132, 18)
        Me.Wallpaper.TabIndex = 30
        Me.Wallpaper.Text = "Wallpaper Changer"
        '
        'TextBoxLocation
        '
        Me.TextBoxLocation.Location = New System.Drawing.Point(15, 28)
        Me.TextBoxLocation.Name = "TextBoxLocation"
        Me.TextBoxLocation.Size = New System.Drawing.Size(182, 21)
        Me.TextBoxLocation.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.TextBoxLocation, "Wallpaper Path")
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.ForeColor = System.Drawing.Color.Snow
        Me.btnApply.Location = New System.Drawing.Point(109, 54)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(88, 23)
        Me.btnApply.TabIndex = 32
        Me.btnApply.Text = "Apply"
        Me.ToolTip1.SetToolTip(Me.btnApply, "Try To Apply The Wallpaper")
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnbrowse
        '
        Me.btnbrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.ForeColor = System.Drawing.Color.Snow
        Me.btnbrowse.Location = New System.Drawing.Point(15, 54)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(88, 23)
        Me.btnbrowse.TabIndex = 31
        Me.btnbrowse.Text = "Browse"
        Me.ToolTip1.SetToolTip(Me.btnbrowse, "Browse The Wallpaper Path")
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'WallpaperChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(209, 89)
        Me.Controls.Add(Me.Wallpaper)
        Me.Controls.Add(Me.TextBoxLocation)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnbrowse)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WallpaperChanger"
        Me.ShowInTaskbar = False
        Me.Text = "Wallpaper Changer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wallpaper As Label
    Friend WithEvents TextBoxLocation As TextBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnbrowse As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
