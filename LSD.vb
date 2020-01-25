Imports System.Runtime.InteropServices

Public Class LSD

    Private InitialStyle As Integer
    Dim PercentVisible As Decimal
    Dim rnd As New Random

    Private Sub Black_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wshShell = CreateObject("WScript.Shell")
        Dim objFSO = CreateObject("Scripting.FileSystemObject")
        Me.ControlBox = False
        Me.Text = ""
        Me.WindowState = FormWindowState.Maximized

        InitialStyle = GetWindowLong(Me.Handle, -20)
        PercentVisible = 0.3

        SetWindowLong(Me.Handle, -20, InitialStyle Or &H80000 Or &H20)

        SetLayeredWindowAttributes(Me.Handle, 0, 255 * PercentVisible, &H2)

        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        Me.TopMost = True
    End Sub

    <DllImport("user32.dll", EntryPoint:="GetWindowLong")> Public Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetWindowLong")> Public Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetLayeredWindowAttributes")> Public Shared Function SetLayeredWindowAttributes(ByVal hWnd As IntPtr, ByVal crKey As Integer, ByVal alpha As Byte, ByVal dwFlags As Integer) As Boolean
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub
End Class