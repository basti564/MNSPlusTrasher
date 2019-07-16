Public Class Archive
    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32

    Private Const SHERB_NOCONFIRMATION = &H1
    Private Const SHERB_NOPROGRESSUI = &H2
    Private Const SHERB_NOSOUND = &H4

    Private Sub EmptyRecycleBin()
        SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION + SHERB_NOSOUND)
        SHUpdateRecycleBinIcon()
    End Sub

    Dim wshShell = CreateObject("WScript.Shell")

    Public Sub RunCommandCom(arguments As String)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + arguments
        pi.FileName = "fsutil.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    Private Sub ArchiveBtn_Click(sender As Object, e As EventArgs) Handles ArchiveBtn.Click
        Dim DesktopPath = wshShell.SpecialFolders("Desktop")
        For i As Integer = 0 To IterationsBox.Text
            RunCommandCom("file createnew " & DesktopPath & "\test" & i & ".txt " & SizeBox.Text)
            Threading.Thread.Sleep(IntervallBox.Text)
            My.Computer.FileSystem.DeleteFile(DesktopPath & "\test" & i & ".txt", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            EmptyRecycleBin()
        Next
    End Sub
End Class