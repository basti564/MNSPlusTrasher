<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Processes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Processes))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Eradicate = New System.Windows.Forms.Button()
        Me.Only = New System.Windows.Forms.CheckBox()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Eradicate
        '
        Me.Eradicate.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Eradicate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Eradicate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Eradicate.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eradicate.ForeColor = System.Drawing.Color.Snow
        Me.Eradicate.Location = New System.Drawing.Point(0, 309)
        Me.Eradicate.Name = "Eradicate"
        Me.Eradicate.Size = New System.Drawing.Size(245, 26)
        Me.Eradicate.TabIndex = 5
        Me.Eradicate.Text = "Eradicate"
        Me.ToolTip1.SetToolTip(Me.Eradicate, "Eradicate Selected Task")
        Me.Eradicate.UseVisualStyleBackColor = False
        '
        'Only
        '
        Me.Only.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Only.AutoSize = True
        Me.Only.BackColor = System.Drawing.Color.Transparent
        Me.Only.Location = New System.Drawing.Point(218, 17)
        Me.Only.Name = "Only"
        Me.Only.Size = New System.Drawing.Size(15, 14)
        Me.Only.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Only, "Only Include MNS+ Processes (Probably Incomplete List)")
        Me.Only.UseVisualStyleBackColor = False
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RefreshBtn.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.ForeColor = System.Drawing.Color.Snow
        Me.RefreshBtn.Location = New System.Drawing.Point(12, 12)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(200, 23)
        Me.RefreshBtn.TabIndex = 2
        Me.RefreshBtn.Text = "Refresh"
        Me.ToolTip1.SetToolTip(Me.RefreshBtn, "Refresh Process List")
        Me.RefreshBtn.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Items.AddRange(New Object() {"Placeholder"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 41)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(221, 256)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Processes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(245, 335)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.Only)
        Me.Controls.Add(Me.Eradicate)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Processes"
        Me.Text = " Task Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Eradicate As Button
    Friend WithEvents Only As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RefreshBtn As Button
End Class
