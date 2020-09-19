Imports System.Net

Public Class Info
    Dim wshShell = CreateObject("WScript.Shell")
    Dim objnet = CreateObject("WScript.Network")
    Dim objFSO = CreateObject("Scripting.FileSystemObject")
    Dim user = objnet.UserName

    Dim Fileserver = "\\MNSPlusFile\"
    Dim PrivatHome = Fileserver & user & "$"             'Privat Homeshare

    Private Sub GetBtn_Click(sender As Object, e As EventArgs) Handles btnIP.Click
        LstIP.Items.Clear()
        Try
            ' Host Name resolution to IP
            Dim host As IPHostEntry = Dns.GetHostEntry(txtIP.Text.Trim() + ".schule.mnsplus")
            Dim ipaddr As IPAddress() = host.AddressList
            ' Loop through the IP Address array and add the IP address to Listbox
            For Each addr As IPAddress In ipaddr
                LstIP.Items.Add(addr.ToString())
            Next addr
            ' Catch unknown host names
        Catch ex As System.Net.Sockets.SocketException
            MessageBox.Show(ex.Message)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lefty_CheckedChanged(sender As Object, e As EventArgs) Handles lefty.CheckedChanged
        If lefty.Checked = False Then
            objFSO.DeleteFile(PrivatHome & "\links.txt", True)
        Else
            objFSO.CreateTextFile(PrivatHome & "\links.txt", True)
        End If
    End Sub

    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If objFSO.FileExists(PrivatHome & "\links.txt") Then
            lefty.Checked = True
        Else
            lefty.Checked = False
        End If
    End Sub

    Private Sub TrayIcon_Click(sender As Object, e As EventArgs) Handles TrayIcon.Click
        Dim ProgramFilesPath = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
        Process.Start(ProgramFilesPath + "\MNS Fernsteuerung.net\TrayIcon.exe")
    End Sub

    Private Sub RecentBtn_Click(sender As Object, e As EventArgs) Handles RecentBtn.Click
        Recent.Show()
    End Sub

    Private Sub WebAnwendung_Click(sender As Object, e As EventArgs) Handles WebAnwendung.Click
        Process.Start("Http://mnsplusweb:1234/home/start")
    End Sub

    Private Sub Support_Click(sender As Object, e As EventArgs) Handles Support.Click
        Process.Start("https://mns.bildung-rp.de/mnsdb/")
    End Sub

    Sub MNSLink(sTURL, linklabel)
        Dim MNSShortcut, DesktopPath

        DesktopPath = wshShell.SpecialFolders("Desktop")

        MNSShortcut = wshShell.CreateShortcut(DesktopPath & "\" & linklabel & ".lnk")
        MNSShortcut.TargetPath = wshShell.ExpandEnvironmentStrings("%PROGRAMFILES%\Internet Explorer\iexplore.exe")
        MNSShortcut.Arguments = wshShell.ExpandEnvironmentStrings(sTURL)
        MNSShortcut.WindowStyle = 4
        MNSShortcut.IconLocation = wshShell.ExpandEnvironmentStrings("%PROGRAMFILES%\mnsplus\wallpaper\MNSplus.ico")
        MNSShortcut.Save
    End Sub

    Private Sub Shortcut_Click(sender As Object, e As EventArgs) Handles Shortcut.Click
        Call MNSLink("Http://mnsplusweb:1234/home/start", "MNS+ v2")
        Call MNSLink("https://mns.bildung-rp.de/mnsdb/", "MNS+ Support")
    End Sub

    Private Sub ProxyLogs_Click(sender As Object, e As EventArgs) Handles WebLogs.Click
        Process.Start("http://mnsplusproxy/")
    End Sub

    Private Sub msgBtn_Click(sender As Object, e As EventArgs) Handles msgBtn.Click
        MSG.Show()
    End Sub

    Private Sub Links_Click(sender As Object, e As EventArgs) Handles Links.Click
        LegacyLinks.Show()
    End Sub
End Class