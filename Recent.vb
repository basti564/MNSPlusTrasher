Imports System.IO

Public Class Recent
    Dim UserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Dim UsersPath = IO.Directory.GetParent(UserPath)

    Private Sub Recent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserList.Items.Clear()
        NameTxt.Text = Environment.UserName
        AccessTxt.Text = "Last Access: " + Directory.GetLastAccessTime(UserPath)
        fAccessTxt.Text = "First Login: " + Directory.GetCreationTime(UserPath)
        For Each folder In Directory.GetParent(UserPath).GetDirectories
            'Don't show "Default" "Default User" "All Users" "Public" 
            If Not folder.Name = "Default" And Not folder.Name = "Default User" And Not folder.Name = "Public" And Not folder.Name = "All Users" Then
                UserList.Items.Add(folder)
            End If
        Next
    End Sub

    Private Sub UserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserList.SelectedIndexChanged
        If Not UserList.SelectedItem Is Nothing Then
            NameTxt.Text = UserList.SelectedItem.ToString
            AccessTxt.Text = "Last Access: " + Directory.GetLastAccessTime(UsersPath.ToString + "\" + UserList.SelectedItem.ToString)
            fAccessTxt.Text = "First Login: " + Directory.GetCreationTime(UsersPath.ToString + "\" + UserList.SelectedItem.ToString)
        End If
    End Sub
End Class