Public Class LegacyLinks
    Dim Printserver As String = "\\MNSPlusDC\"

    Private Sub Schülermodul_Click(sender As Object, e As EventArgs) Handles Schülermodul.Click
        Process.Start("Http://mnsplusweb:81/schuelermodul/default.aspx")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("Http://mnsplusweb:81/main/index.aspx")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(Printserver & "Netlogon$\chpwd.hta") 'Change back to Natlogon\chpwd.hta
    End Sub

    Private Sub PrintLogs_Click(sender As Object, e As EventArgs) Handles PrintLogs.Click
        Process.Start(Printserver & "Printlogs$\Print\html\index.html")
    End Sub

    Private Sub UpdateSettings_Click(sender As Object, e As EventArgs) Handles UpdateSettings.Click
        Process.Start("V:\UPDATES\MNSplusUpdateSettings.hta")
    End Sub

    Private Sub LegacyLinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class