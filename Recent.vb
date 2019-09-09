Imports System.IO

Public Class Recent
    Dim UserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Dim UsersPath = IO.Directory.GetParent(UserPath)

    Private Sub Recent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserList.Items.Clear()
        NameTxt.Text = Environment.UserName
        AccessTxt.Text = "Last Access: " + Directory.GetLastAccessTime(UserPath)
        ActionTxt.Text = "Last Action: " + Directory.GetLastWriteTime(UserPath)
        fAccessTxt.Text = "First Login: " + Directory.GetCreationTime(UserPath)
        For Each folder In Directory.GetParent(UserPath).GetDirectories
            UserList.Items.Add(folder)
        Next
    End Sub

    Private Sub UserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserList.SelectedIndexChanged
        NameTxt.Text = UserList.SelectedItem.ToString
        AccessTxt.Text = "Last Access: " + Directory.GetLastAccessTime(UsersPath.ToString + "\" + UserList.SelectedItem.ToString)
        ActionTxt.Text = "Last Action: " + Directory.GetLastWriteTime(UsersPath.ToString + "\" + UserList.SelectedItem.ToString)
        fAccessTxt.Text = "First Login: " + Directory.GetCreationTime(UsersPath.ToString + "\" + UserList.SelectedItem.ToString)
    End Sub
End Class