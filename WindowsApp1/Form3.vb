Imports MySql.Data.MySqlClient
Public Class Form3
    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        openCon()
        Dim READER As MySqlDataReader

        Try
            Dim Query As String
            Query = "insert into information (fname, mname, lname, dob, contactno, status, address, gender, dom, entryservice, office, designation, remark) values ('" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & txtdob.Text & "','" & txtcontactno.Text & "','" & txtstatus.Text & "','" & txtaddress.Text & "','" & txtgender.Text & "','" & txtdom.Text & "','" & txtentry.Text & "','" & txtoffice.Text & "','" & txtdesignation.Text & "','" & txtremark.Text & "')"
            cmd = New MySqlCommand(Query, con)
            READER = cmd.ExecuteReader
            MsgBox("Successfuly Added Record!")
            con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
            txtaddress.Text = ""
            txtcontactno.Text = ""
            txtdesignation.Text = ""
            txtfname.Text = ""
            txtgender.Text = ""
            txtlname.Text = ""
            txtmname.Text = ""
            txtoffice.Text = ""
            txtremark.Text = ""
            txtstatus.Text = ""
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class