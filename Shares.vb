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
End Class