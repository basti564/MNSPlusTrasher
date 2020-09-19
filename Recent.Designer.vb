<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recent
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
        Me.UserList = New System.Windows.Forms.ListBox()
        Me.NameTxt = New System.Windows.Forms.Label()
        Me.fAccessTxt = New System.Windows.Forms.Label()
        Me.AccessTxt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserList
        '
        Me.UserList.FormattingEnabled = True
        Me.UserList.Location = New System.Drawing.Point(12, 12)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(215, 238)
        Me.UserList.TabIndex = 1
        '
        'NameTxt
        '
        Me.NameTxt.AutoSize = True
        Me.NameTxt.BackColor = System.Drawing.Color.Transparent
        Me.NameTxt.Location = New System.Drawing.Point(12, 255)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(41, 13)
        Me.NameTxt.TabIndex = 8
        Me.NameTxt.Text = "*name*"
        '
        'fAccessTxt
        '
        Me.fAccessTxt.AutoSize = True
        Me.fAccessTxt.BackColor = System.Drawing.Color.Transparent
        Me.fAccessTxt.Location = New System.Drawing.Point(12, 268)
        Me.fAccessTxt.Name = "fAccessTxt"
        Me.fAccessTxt.Size = New System.Drawing.Size(31, 13)
        Me.fAccessTxt.TabIndex = 7
        Me.fAccessTxt.Text = "*first*"
        '
        'AccessTxt
        '
        Me.AccessTxt.AutoSize = True
        Me.AccessTxt.BackColor = System.Drawing.Color.Transparent
        Me.AccessTxt.Location = New System.Drawing.Point(12, 281)
        Me.AccessTxt.Name = "AccessTxt"
        Me.AccessTxt.Size = New System.Drawing.Size(49, 13)
        Me.AccessTxt.TabIndex = 5
        Me.AccessTxt.Text = "*access*"
        '
        'Recent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(239, 298)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.fAccessTxt)
        Me.Controls.Add(Me.AccessTxt)
        Me.Controls.Add(Me.UserList)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Recent"
        Me.ShowInTaskbar = False
        Me.Text = "Recent Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserList As ListBox
    Friend WithEvents NameTxt As Label
    Friend WithEvents fAccessTxt As Label
    Friend WithEvents AccessTxt As Label
End Class
