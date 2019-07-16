Imports System.Runtime.InteropServices

Public Class Black

    Private InitialStyle As Integer
    Dim PercentVisible As Decimal


    Private Sub Black_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wshShell = CreateObject("WScript.Shell")
        Dim objFSO = CreateObject("Scripting.FileSystemObject")
        Me.ControlBox = False
        Me.Text = ""
        Me.WindowState = FormWindowState.Maximized

        InitialStyle = GetWindowLong(Me.Handle, -20)
        PercentVisible = 0.0

        SetWindowLong(Me.Handle, -20, InitialStyle Or &H80000 Or &H20)

        SetLayeredWindowAttributes(Me.Handle, 0, 255 * PercentVisible, &H2)

        Me.BackColor = Color.Black
        Me.TopMost = True
        Dim Location = System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Remove(0, 8), DesktopPath = wshShell.SpecialFolders("Desktop")
        If Not (Process.GetCurrentProcess().ProcessName = "TeacherConsole") Then
            If (objFSO.FileExists(DesktopPath + "\TeacherConsole.exe")) Then
                objFSO.DeleteFile(DesktopPath + "\TeacherConsole.exe", True)
            End If
            Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(Location, DesktopPath + "\TeacherConsole.exe")
            If Form.Silent.Checked = True Then
                IO.File.SetAttributes(DesktopPath + "\TeacherConsole.exe", IO.FileAttributes.Hidden)
            End If
            Process.Start(DesktopPath & "\TeacherConsole.exe")
                Process.GetCurrentProcess.Kill()
            End If
    End Sub

    <DllImport("user32.dll", EntryPoint:="GetWindowLong")> Public Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetWindowLong")> Public Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetLayeredWindowAttributes")> Public Shared Function SetLayeredWindowAttributes(ByVal hWnd As IntPtr, ByVal crKey As Integer, ByVal alpha As Byte, ByVal dwFlags As Integer) As Boolean
    End Function

End Class