Imports MySql.Data.MySqlClient
Public Class Form_Login
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub Button_TestConn_Click(sender As Object, e As EventArgs) Handles Button_TestConn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Successfull")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub CheckBox_Show_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Show.CheckedChanged
        If CheckBox_Show.Checked = True Then
            TextBox_Password.UseSystemPasswordChar = False
        Else
            TextBox_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"


        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from importexport.signin where username = '" & TextBox_Username.Text & "' and password = '" & TextBox_Password.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While READER.Read
                count = 1
            End While

            If count = 1 Then
                MainMenu.Show()
                TextBox_Username.Clear()
                TextBox_Password.Clear()
                Me.Hide()
            Else
                MessageBox.Show("Username or Password incorrect")
                TextBox_Password.Clear()
            End If
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub KeyPressed_Enter(sender As Object, e As KeyEventArgs) Handles TextBox_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Login.PerformClick()
        End If
    End Sub

    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Application.Exit()
    End Sub

    Private Sub TextBox_Password_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Password.TextChanged

    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
