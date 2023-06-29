Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        openCon()
        Dim READER As MySqlDataReader

        Try

            Dim Query As String
            Query = "Select * from capesdatabase.login where username='" & txtusername.Text & "' and password = '" & txtpassword.Text & "'"
            cmd = New MySqlCommand(Query, con)
            READER = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1

            End While

            If count = 1 Then
                MessageBox.Show("Username and password are correct")
                con.Close()
                Form2.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are Incorrect")

            End If

            con.Close()

            txtpassword.Text = ""
            txtusername.Text = ""
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
