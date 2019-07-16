Public Class CustomDrive
    Dim objnet = CreateObject("WScript.Network")
    Dim objFSO = CreateObject("Scripting.FileSystemObject")
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

    Private Sub CustomDrive_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class