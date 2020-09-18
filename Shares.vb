Public Class Shares
    Dim objnet = CreateObject("WScript.Network")
    Dim objFSO = CreateObject("Scripting.FileSystemObject")

    Dim realUser = objnet.UserName
    Dim user = realUser

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

    Private Sub MapAWBShare_Click_1(sender As Object, e As EventArgs) Handles MapAWBShare.Click
        If objFSO.FolderExists("S:") Then
            objnet.RemoveNetworkDrive("S:")
        Else
            objnet.MapNetworkDrive("S:", AWBShare, False)
        End If
    End Sub

    Private Sub MapSrvCD_Click_1(sender As Object, e As EventArgs) Handles MapSrvCD.Click
        If objFSO.FolderExists("U:") Then
            objnet.RemoveNetworkDrive("U:")
        Else
            objnet.MapNetworkDrive("U:", SrvCD, False)
        End If
    End Sub

    Private Sub MapNetProg_Click_1(sender As Object, e As EventArgs) Handles MapNetProg.Click
        If objFSO.FolderExists("V:") Then
            objnet.RemoveNetworkDrive("V:")
        Else
            objnet.MapNetworkDrive("V:", NetProg, False)
        End If
    End Sub

    Private Sub MapAlleAG_Click_1(sender As Object, e As EventArgs) Handles MapAlleAG.Click
        If objFSO.FolderExists("N:") Then
            objnet.RemoveNetworkDrive("N:")
        Else
            objnet.MapNetworkDrive("N:", AlleAG, False)
        End If
    End Sub

    Private Sub MapAlleKurse_Click_1(sender As Object, e As EventArgs) Handles MapAlleKurse.Click
        If objFSO.FolderExists("M:") Then
            objnet.RemoveNetworkDrive("M:")
        Else
            objnet.MapNetworkDrive("M:", AlleKurse, False)
        End If
    End Sub

    Private Sub MapAlleKlassen_Click_1(sender As Object, e As EventArgs) Handles MapAlleKlassen.Click
        If objFSO.FolderExists("I:") Then
            objnet.RemoveNetworkDrive("I:")
        Else
            objnet.MapNetworkDrive("I:", AlleKlassen, False)
        End If
    End Sub

    Private Sub MapTauschLehrer_Click_1(sender As Object, e As EventArgs) Handles MapTauschLehrer.Click
        If objFSO.FolderExists("T:") Then
            objnet.RemoveNetworkDrive("T:")
        Else
            objnet.MapNetworkDrive("T:", TauschLehrer, False)
        End If
    End Sub

    Private Sub MapPublicLehrerSchüler_Click_1(sender As Object, e As EventArgs) Handles MapPublicLehrerSchüler.Click
        If objFSO.FolderExists("P:") Then
            objnet.RemoveNetworkDrive("P:")
        Else
            objnet.MapNetworkDrive("P:", PublicLehrerSchueler, False)
        End If
    End Sub

    Private Sub MapHomesSchüler_Click_1(sender As Object, e As EventArgs) Handles MapHomesSchüler.Click
        If objFSO.FolderExists("O:") Then
            objnet.RemoveNetworkDrive("O:")
        Else
            objnet.MapNetworkDrive("O:", HomesSchueler, False)
        End If
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
        Threading.Thread.Sleep(10000)
        Process.Start("MNSPF.txt")
        Process.Start("MNSPDC.txt")
    End Sub

    Private Sub Removebtn_Click(sender As Object, e As EventArgs) Handles Removebtn.Click
        If objFSO.FolderExists(Letter.Text) Then
            objnet.RemoveNetworkDrive(Letter.Text)
        End If
    End Sub

    Private Sub Mapbtn_Click(sender As Object, e As EventArgs) Handles Mapbtn.Click
        If objFSO.FolderExists(Letter.Text) Then
            objnet.RemoveNetworkDrive(Letter.Text)
        End If
        objnet.MapNetworkDrive(Letter.Text, Path.Text, False)
    End Sub

    Private Sub Spoof_Click(sender As Object, e As EventArgs) Handles Spoof.Click
        Try
            If objFSO.FolderExists("A:") Then
                objnet.RemoveNetworkDrive("A:")
                Threading.Thread.Sleep(500)
            End If
            objnet.MapNetworkDrive("A:", Fileserver & RoomBox.Text & "$", False)
        Catch ex As Exception
            MsgBox(ex.Message, 16, "ERROR!")
        End Try
    End Sub
End Class