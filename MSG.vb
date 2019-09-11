Imports System.IO
Public Class MSG
    Dim date1
    Dim time
    Dim user = Environment.UserName

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date1 = DateTime.Now.ToString("dd.MM.yyyy")
        time = DateTime.Now.ToString("HH:mm:ss")
        DateTimePicker1.Value = DateTime.Now
        Update_Header()
        UserBox.Text = user
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using sw As StreamWriter = File.AppendText("T:\Admin\Nachricht.txt")
            sw.WriteLine("---------------------------------------------------------------------------")
            sw.WriteLine(date1 + " | " + time + " |  Benutzer: " + user)
            sw.WriteLine("")
            sw.WriteLine(Input.Text)
        End Using
    End Sub

    Private Sub UserBox_TextChanged(sender As Object, e As EventArgs) Handles UserBox.TextChanged
        user = UserBox.Text
        Update_Header()
    End Sub

    Private Sub Update_Header()
        Info.Text = date1 + " | " + time + " |  Benutzer: " + user
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        date1 = DateTimePicker1.Value.ToString("dd.MM.yyyy")
        time = DateTimePicker1.Value.ToString("HH:mm:ss")
        Update_Header()
    End Sub
End Class