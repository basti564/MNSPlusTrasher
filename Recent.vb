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
            UserList.Items.Add(folder)
        Next
        If Not UserList.SelectedItem Is Nothing Then
            MsgBox("sees")
        End If
    End Sub

    Private Sub UserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserList.SelectedIndexChanged
        If Not UserList.SelectedItem Is Nothing Then
            NameTxt.Text = UserList.SelectedItem.ToString
            AccessTxt.Text = "Last Access: " + Directory.GetLastAccessTime(UsersPath.ToString + "\" + UserList.SelectedItem.ToString)
            fAccessTxt.Text = "First Login: " + Directory.GetCreationTime(UsersPath.ToString + "\" + UserList.SelectedItem.ToString)
        End If
    End Sub
End Class