﻿Imports System.Net

Public Class Form

    Public Sub RunCommandCom(arguments As String)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + arguments
        pi.FileName = "fsutil.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    Const wbemFlagReturnImmediately = &H10
    Const wbemFlagForwardOnly = &H20

    Dim wshShell = CreateObject("WScript.Shell")
    Dim objnet = CreateObject("WScript.Network")
    Dim Raum
    Dim Laenge
    Dim Start
    Dim tmp
    Dim hostname
    Dim Domain

    Const HKEY_CURRENT_USER = &H80000001
    Dim oReg = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\default:StdRegProv")
    Dim objFSO = CreateObject("Scripting.FileSystemObject")

    Dim NBdomain = objnet.UserDomain
    Dim realUser = objnet.UserName
    Dim user = realUser

    'Active Directory

    Dim OUPath

    Dim DomainContainer = "OU=SCHULE,DC=" & Replace(wshShell.ExpandEnvironmentStrings("%USERDNSDOMAIN%"), ".", ",dc=")

    Dim ouSchuelerPC = "OU=Computer_Schueler,"
    Dim ouLehrerPC = "OU=Computer_Lehrer,"
    Dim ouOeffentlicherPC = "OU=Computer_oeffentlich,"

    Dim ouKlasse = "OU=Klasse,"
    Dim ouDrucker = "OU=DRUCKER,"
    Dim ouDruckerOeffentlich = "OU=Drucker_oeffentlich,"

    Dim sDefaultPrinter = "Standard"                'Wert der für DefaultPrinterMapping bei mehr als einem Drucker im Raum 
    'abgefragt wird, der Wert muss zu Anfang im Beschreibungsfeld der 
    'PrintQueue (AD) stehen

    'Serverroles
    Dim Fileserver = "\\MNSPlusFile\"
    Dim Printserver = "\\MNSPlusDC\"

    'Shares
    Dim PrivatHome = Fileserver & user & "$"             'Privat Homeshare (wenn nicht über Profileinstellung gesetzt)                
    Dim PublicLehrer = Fileserver & user & "Public" & "$"        'Public Homeshare Lehrer
    Dim HomesSchueler = Fileserver & "PrivatSchueler$"           'Alle Privat Homeshares der Schueler
    Dim PublicLehrerSchueler = Fileserver & "PublicLehrer$"      'Alle Public Homeshares der Lehrer
    Dim TauschLehrer = Fileserver & "LehrerAustausch$"       'Lehrer Austauschshare
    Dim AlleKlassen = Fileserver & "AlleKlassen$"            'Alle Klassenshares
    Dim AlleKurse = Fileserver & "AlleKurse$"            'Alle Kursshares
    Dim AlleAG = Fileserver & "AlleAG$"              'Alle AGshares
    Dim NetProg = Printserver & "Programme$"                      'Vom Netz ausführbare Programme
    Dim SrvCD = Fileserver & "ROM$"                  'CD/DVD des Servers
    Dim AWBShare = Fileserver & "Anwendungsbetreuer$"


    Private Sub lefty_CheckedChanged(sender As Object, e As EventArgs) Handles lefty.CheckedChanged
        If lefty.Checked = False Then
            objFSO.DeleteFile(PrivatHome & "\links.txt", True)
        Else
            objFSO.CreateTextFile(PrivatHome & "\links.txt", True)
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Process.GetCurrentProcess().ProcessName = "TeacherConsole") Then
            Black.Show()
            Me.Text = Me.Text + " [Blackout]"
        End If
        If objFSO.FileExists(PrivatHome & "\links.txt") Then
            lefty.Checked = True
        End If
        NameBox.Text = user
    End Sub

    Private Sub delTemp_Click(sender As Object, e As EventArgs) Handles delTemp.Click
        On Error Resume Next ' skip undeletable temp files...
        Dim tmppath = wshShell.ExpandEnvironmentStrings("%TEMP%")
        If objFSO.FolderExists(tmppath) Then
            Dim fldr = objFSO.GetFolder(tmppath)
            For Each f In fldr.Files
                f.delete(True)
            Next
            For Each f In fldr.SubFolders
                f.delete(True)
            Next
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        user = NameBox.Text

        If objFSO.FileExists(PrivatHome & "\links.txt") Then
            lefty.Checked = True
        End If
    End Sub

    Private Sub Spoof_Click(sender As Object, e As EventArgs) Handles Spoof.Click
        If objFSO.FolderExists("A:") Then
            objnet.RemoveNetworkDrive("A:")
            Threading.Thread.Sleep(500)
        End If
        objnet.MapNetworkDrive("A:", Fileserver & RoomBox.Text & "$", False)
        RoomTxt.Text = "Room: " & RoomBox.Text
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

    Public Function Left(ByVal sText As String,
  ByVal nLen As Integer) As String

        If nLen > sText.Length Then nLen = sText.Length
        Return (sText.Substring(0, nLen))
    End Function

    Private Sub Schülermodul_Click(sender As Object, e As EventArgs)
        Process.Start("Http://mnsplusweb:81/schuelermodul/default.aspx")
    End Sub

    Private Sub Support_Click(sender As Object, e As EventArgs) Handles Support.Click
        Process.Start("https://mns.bildung-rp.de/mnsdb/")
    End Sub

    Private Sub WebAnwendung_Click(sender As Object, e As EventArgs) Handles WebAnwendung.Click
        Process.Start("Http://mnsplusweb:1234/home/start")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Process.Start("Http://mnsplusweb:81/main/index.aspx")
    End Sub

    Public Function Right(ByVal sText As String,
  ByVal nLen As Integer) As String

        If nLen > sText.Length Then nLen = sText.Length
        Return (sText.Substring(sText.Length - nLen))
    End Function

    Sub NetIdentity()
        Const wbemFlagReturnImmediately = &H10
        Const wbemFlagForwardOnly = &H20
        Dim a_Domain

        Dim sNode = "."
        Dim oWMI = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\cimv2")
        Dim colComputer = oWMI.ExecQuery("SELECT * FROM Win32_ComputerSystem", "WQL", wbemFlagReturnImmediately + wbemFlagForwardOnly)
        For Each oComputer In colComputer
            hostname = oComputer.Caption
        Next

        Dim objDomain = GetObject("LDAP://rootDse")

        objDomain = objDomain.Get("DefaultNamingContext")
        a_Domain = Len(objDomain)
        a_Domain = a_Domain - 12
        Domain = Mid(objDomain, 4, a_Domain)
    End Sub

    Private Sub Shortcut_Click(sender As Object, e As EventArgs) Handles Shortcut.Click
        Call MNSLink("Http://mnsplusweb:1234/home/start", "MNS+ v2")
        Call MNSLink("https://mns.bildung-rp.de/mnsdb/", "MNS+ Support")
    End Sub

    Private Sub ProxyLogs_Click(sender As Object, e As EventArgs) Handles WebLogs.Click
        Process.Start("http://mnsplusproxy/")
    End Sub

    Private Sub Wall_Click(sender As Object, e As EventArgs) Handles Wall.Click
        WallpaperChanger.Show()
    End Sub

    Private Sub ArchiveBtn_Click(sender As Object, e As EventArgs) Handles ArchiveBtn.Click
        If MsgBox("This Option Is Highly Experimental And Will Crash!", 48 + 1, "Warning!") = MsgBoxResult.Ok Then
            Archive.Show()
        End If
    End Sub

    Private Sub MapCustom_Click(sender As Object, e As EventArgs) Handles MapCustom.Click
        CustomDrive.Show()
    End Sub

    Private Sub TrayIcon_Click(sender As Object, e As EventArgs) Handles TrayIcon.Click
        Dim ProgramFilesPath = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
        Process.Start(ProgramFilesPath + "\MNS Fernsteuerung.net\TrayIcon.exe")
    End Sub

    Private Sub Experiments_Click(sender As Object, e As EventArgs) Handles ProcessesBtn.Click
        Processes.Show()
    End Sub

    Private Sub Links_Click(sender As Object, e As EventArgs) Handles Links.Click
        LegacyLinks.Show()
    End Sub
    Private Sub Volume_Click(sender As Object, e As EventArgs) Handles Volume.Click
        Process.Start("sndvol.exe")
    End Sub

    Private Sub Tests_Click(sender As Object, e As EventArgs) Handles TestsBtn.Click
        Dim FernsteuerungDir = My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\MNS Fernsteuerung.net"
        Dim DesktopPath = wshShell.SpecialFolders("Desktop"), Response
        If Not (objFSO.FolderExists(DesktopPath & "\MNS Fernsteuerung.net")) Then
            Microsoft.VisualBasic.FileIO.FileSystem.CreateDirectory(DesktopPath & "\MNS Fernsteuerung.net")
            If Silent.Checked = True Then
                IO.File.SetAttributes(DesktopPath & "\MNS Fernsteuerung.net", IO.FileAttributes.Hidden)
            End If
        End If
        On Error Resume Next
        Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(FernsteuerungDir, DesktopPath & "\MNS Fernsteuerung.net")
        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(DesktopPath & "\MNS Fernsteuerung.net\RoomMgr.dll", "RoomMgr.dll.orig")
        Microsoft.VisualBasic.FileIO.FileSystem.WriteAllBytes(DesktopPath & "\MNS Fernsteuerung.net\RoomMgr.dll", My.Resources.ResourceManager.GetObject("RoomMgr"), True)
        Response = MsgBox("Run TeacherConsole.exe?", vbYesNo, "TCPatcher")
        If Response = vbYes Then
            Process.Start(DesktopPath & "\MNS Fernsteuerung.net\TeacherConsole.exe")
        End If
    End Sub

    Private Sub PowerShell_Click(sender As Object, e As EventArgs) Handles PowerShell.Click
        Dim DesktopPath = wshShell.SpecialFolders("Desktop")
        Dim sb As New System.Text.StringBuilder
        sb.AppendLine("@echo off")
        sb.AppendLine("color 17")
        sb.AppendLine("title PowerShell")
        sb.AppendLine("powershell")
        If objFSO.FileExists(DesktopPath & "\PowerShell.cmd") Then
            objFSO.DeleteFile(DesktopPath & "\PowerShell.cmd")
        End If
        IO.File.WriteAllText(DesktopPath & "\PowerShell.cmd", sb.ToString())
        If Silent.Checked = True Then
            IO.File.SetAttributes(DesktopPath & "\PowerShell.cmd", IO.FileAttributes.Hidden)
        End If
        Process.Start(DesktopPath & "\PowerShell.cmd")
    End Sub

    Private Sub BlackBtn_Click(sender As Object, e As EventArgs) Handles BlackBtn.Click
        Black.Show()
    End Sub

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

    Private Sub LSDbtn_Click(sender As Object, e As EventArgs) Handles LSDbtn.Click
        LSD.Show()
    End Sub

    Private Sub LstIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstIP.SelectedIndexChanged

    End Sub

    Private Sub MapPublicLehrer_Click(sender As Object, e As EventArgs)
        If objFSO.FolderExists("L:") Then
            objnet.RemoveNetworkDrive("L:")
        Else
            objnet.MapNetworkDrive("L:", PublicLehrer, False)
        End If
    End Sub

    Private Sub MapPrivatHome_Click(sender As Object, e As EventArgs)
        If objFSO.FolderExists("H:") Then
            objnet.RemoveNetworkDrive("H:")
        Else
            objnet.MapNetworkDrive("H:", PrivatHome, False)
        End If
    End Sub

    Private Sub More_Click(sender As Object, e As EventArgs) Handles More.Click
        Shares.Show()
    End Sub

    Private Sub FindBtn_Click(sender As Object, e As EventArgs) Handles FindBtn.Click
        If objFSO.FileExists("MNSPF.txt") Then
            On Error Resume Next
            objFSO.DeleteFile("MNSPF.txt")
        End If
        If objFSO.FileExists("MNSPDC.txt") Then
            On Error Resume Next
            objFSO.DeleteFile("MNSPDC.txt")
        End If
        On Error Resume Next
        Process.Start("cmd.exe", "/c net view \\MNSPlusFile\ /all > MNSPF.txt 2>&1")
        Process.Start("cmd.exe", "/c net view \\MNSPlusDC\ /all > MNSPDC.txt 2>&1")
        Threading.Thread.Sleep(5000)
        Process.Start("MNSPF.txt")
        Process.Start("MNSPDC.txt")
    End Sub

    Private Sub CMD_Click(sender As Object, e As EventArgs) Handles CMD.Click
        Dim DesktopPath = wshShell.SpecialFolders("Desktop")
        Dim sb As New System.Text.StringBuilder
        sb.AppendLine("@echo off")
        sb.AppendLine("cls")
        sb.AppendLine("title Command Prompt     [Bypass by Bastian Oliver Schwickert]")
        sb.AppendLine("for /f ""tokens=4* delims=. "" %%i in ('ver') do set VERSION=%%i.%%j")
        sb.AppendLine("echo Microsoft Windows [Version %version%")
        sb.AppendLine("echo (c) 2018 Microsoft Corporation. All rights reserved.")
        sb.AppendLine("echo.")
        sb.AppendLine("set command=")
        sb.AppendLine(":start")
        sb.AppendLine("%command%")
        sb.AppendLine("if not ""%command%""=="""" echo.")
        sb.AppendLine("set command=")
        sb.AppendLine("SET /P command=%cd%^>")
        sb.AppendLine("goto :start")
        If objFSO.FileExists(DesktopPath & "\CMD.cmd") Then
            objFSO.DeleteFile(DesktopPath & "\CMD.cmd")
        End If
        IO.File.WriteAllText(DesktopPath & "\CMD.cmd", sb.ToString())
        If Silent.Checked = True Then
            IO.File.SetAttributes(DesktopPath & "\CMD.cmd", IO.FileAttributes.Hidden)
        End If
        Process.Start(DesktopPath & "\CMD.cmd")
    End Sub
End Class