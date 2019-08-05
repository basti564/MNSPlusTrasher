Public Class Processes

    Dim Processes() As String = {"TrayIcon", "FullScreen", "MNSInterface", "TeacherConsole", "ScreenGrabber", "ADReader", "FastHookLoader_Win32", "IPCGrabber", "IPCGrabberU"}
    Dim Selection As String

    Private Sub Experiments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Reset()
    End Sub

    Private Sub Eradicate_Click(sender As Object, e As EventArgs) Handles Eradicate.Click
        On Error Resume Next
        Dim myProcess As Process = System.Diagnostics.Process.GetProcessById(Selection.Substring(0, Selection.IndexOf(" ")))
        myProcess.Kill()
        Call Reset()
    End Sub

    Public Sub Reset()
        ListBox1.Items.Clear()
        For Each p As Process In Process.GetProcesses
            If Only.Checked Then
                If Processes.Contains(p.ProcessName.ToString) Then
                    If p.Id = Process.GetCurrentProcess().Id Then
                        ListBox1.Items.Add("**" + p.Id.ToString + " " + p.ProcessName.ToString + "**")
                    Else
                        ListBox1.Items.Add(p.Id.ToString + " " + p.ProcessName.ToString)
                    End If
                End If
                Else
                If p.Id = Process.GetCurrentProcess().Id Then
                    ListBox1.Items.Add("**" + p.Id.ToString + " " + p.ProcessName.ToString + "**")
                Else
                    ListBox1.Items.Add(p.Id.ToString + " " + p.ProcessName.ToString)
                End If
            End If
        Next
    End Sub

    Private Sub Only_CheckedChanged(sender As Object, e As EventArgs) Handles Only.CheckedChanged
        Call Reset()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Only.Checked Then
            Call Reset()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Selection = ListBox1.SelectedItem
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Call Reset()
    End Sub
End Class