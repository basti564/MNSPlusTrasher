Public Class WallpaperChanger
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    'Declare two constant

    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1

    Private Function GetCurrentWallpaper() As String
        ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
        Dim rkWallPaper As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        ' Return the current wallpaper path
        Return WallpaperPath
    End Function
    Private Sub Wallpaper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxLocation.Text = GetCurrentWallpaper()
    End Sub
    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click

        Dim dlg As New OpenFileDialog

        dlg.Title = "Choose Desktop background image"

        dlg.Filter = ""

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            TextBoxLocation.Text = dlg.FileName
            SystemParametersInfo(SETDESKWALLPAPER, 0, dlg.FileName, UPDATEINIFILE)

        End If

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        SystemParametersInfo(SETDESKWALLPAPER, 0, TextBoxLocation.Text, UPDATEINIFILE)

    End Sub
End Class