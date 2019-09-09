<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Archive))
        Me.ArchiveBtn = New System.Windows.Forms.Button()
        Me.SizeBox = New System.Windows.Forms.TextBox()
        Me.IterationsBox = New System.Windows.Forms.TextBox()
        Me.IntervallBox = New System.Windows.Forms.TextBox()
        Me.ArchiveTxt = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'ArchiveBtn
        '
        Me.ArchiveBtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ArchiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ArchiveBtn.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveBtn.ForeColor = System.Drawing.Color.Snow
        Me.ArchiveBtn.Location = New System.Drawing.Point(12, 54)
        Me.ArchiveBtn.Name = "ArchiveBtn"
        Me.ArchiveBtn.Size = New System.Drawing.Size(88, 23)
        Me.ArchiveBtn.TabIndex = 48
        Me.ArchiveBtn.Text = "Spam"
        Me.ToolTip1.SetToolTip(Me.ArchiveBtn, "Start Spamming")
        Me.ArchiveBtn.UseVisualStyleBackColor = False
        '
        'SizeBox
        '
        Me.SizeBox.Location = New System.Drawing.Point(12, 28)
        Me.SizeBox.Name = "SizeBox"
        Me.SizeBox.Size = New System.Drawing.Size(88, 20)
        Me.SizeBox.TabIndex = 49
        Me.SizeBox.Text = "8000000000"
        Me.ToolTip1.SetToolTip(Me.SizeBox, "File Size In Byte")
        '
        'IterationsBox
        '
        Me.IterationsBox.Location = New System.Drawing.Point(106, 28)
        Me.IterationsBox.Name = "IterationsBox"
        Me.IterationsBox.Size = New System.Drawing.Size(37, 20)
        Me.IterationsBox.TabIndex = 50
        Me.IterationsBox.Text = "100"
        Me.ToolTip1.SetToolTip(Me.IterationsBox, "Iterations")
        '
        'IntervallBox
        '
        Me.IntervallBox.Location = New System.Drawing.Point(106, 54)
        Me.IntervallBox.Name = "IntervallBox"
        Me.IntervallBox.Size = New System.Drawing.Size(37, 20)
        Me.IntervallBox.TabIndex = 51
        Me.IntervallBox.Text = "400"
        Me.ToolTip1.SetToolTip(Me.IntervallBox, "Intervall")
        '
        'ArchiveTxt
        '
        Me.ArchiveTxt.AutoSize = True
        Me.ArchiveTxt.BackColor = System.Drawing.Color.Transparent
        Me.ArchiveTxt.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveTxt.ForeColor = System.Drawing.Color.Teal
        Me.ArchiveTxt.Location = New System.Drawing.Point(12, 9)
        Me.ArchiveTxt.Name = "ArchiveTxt"
        Me.ArchiveTxt.Size = New System.Drawing.Size(104, 17)
        Me.ArchiveTxt.TabIndex = 52
        Me.ArchiveTxt.Text = "Archive Spammer"
        '
        'Archive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = Global.MNSTrasher.My.Resources.Resources.Links
        Me.ClientSize = New System.Drawing.Size(154, 86)
        Me.Controls.Add(Me.ArchiveTxt)
        Me.Controls.Add(Me.IntervallBox)
        Me.Controls.Add(Me.SizeBox)
        Me.Controls.Add(Me.IterationsBox)
        Me.Controls.Add(Me.ArchiveBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Archive"
        Me.Text = "Archive Spammer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArchiveBtn As Button
    Friend WithEvents SizeBox As TextBox
    Friend WithEvents IterationsBox As TextBox
    Friend WithEvents IntervallBox As TextBox
    Friend WithEvents ArchiveTxt As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
