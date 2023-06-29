Imports MySql.Data.MySqlClient
Public Class Form7
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtupdate_Click(sender As Object, e As EventArgs) Handles txtupdate.Click
        If (MsgBox("DO YOU WANT TO UPDATES THIS RECORD?", vbQuestion + vbYesNo, "CAPES SYSTEM")) = vbYes Then

            openCon()
            Dim READER As MySqlDataReader

            Try
                Dim Query As String
                Query = "Update capesdatabase.information set id = '" + txtid.Text + "', fname = '" + txtfname.Text + "', mname = '" + txtmname.Text + "', lname = '" + txtlname.Text + "', dob = '" + txtdob.Text + "', contactno = '" + txtcontactno.Text + "', status = '" + txtstatus.Text + "', address = '" + txtaddress.Text + "', gender = '" + txtgender.Text + "', dom = '" + txtdob.Text + "', entryservice = '" + txtentry.Text + "', office = '" + txtoffice.Text + "', designation = '" + txtdesignation.Text + "', remark = '" + txtremark.Text + "', remarkdate = '" + txtremarkdate.Text + "' where id='" + txtid.Text + "'"
                cmd = New MySqlCommand(Query, con)
                READER = cmd.ExecuteReader
                MsgBox("Successfuly Update Record!")
                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
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
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()


        Try
            Dim Query As String
            Query = "Select * from information where id='" & txtid.Text & "'"
            cmd = New MySqlCommand(Query, con)
            adapter.SelectCommand = cmd
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtfname.Text = dt.Rows(0)(1).ToString
                txtmname.Text = dt.Rows(0)(2).ToString
                txtlname.Text = dt.Rows(0)(3).ToString
                txtdob.Text = dt.Rows(0)(4).ToString
                txtcontactno.Text = dt.Rows(0)(5).ToString
                txtstatus.Text = dt.Rows(0)(6).ToString
                txtaddress.Text = dt.Rows(0)(7).ToString
                txtgender.Text = dt.Rows(0)(8).ToString
                txtdom.Text = dt.Rows(0)(9).ToString
                txtentry.Text = dt.Rows(0)(10).ToString
                txtoffice.Text = dt.Rows(0)(11).ToString
                txtdesignation.Text = dt.Rows(0)(12).ToString
                txtremark.Text = dt.Rows(0)(13).ToString
                txtremarkdate.Text = dt.Rows(0)(14).ToString

            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            age()
            con.Close()

        End Try
    End Sub

    Private Sub age()
        Dim datecheck As String
        Dim today As System.DateTime = System.DateTime.Now
        datecheck = txtdob.Text

        Dim yearnow As Integer = today.Year
        Dim yeardtp As Integer = txtdob.Value.Year
        Dim rightyear As Integer = txtdob.Value.Year
        Dim minimage As Integer = yeardtp - rightyear
        Dim currentage As Integer = yearnow - yeardtp
        txtage.Text = currentage.ToString
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If (MsgBox("DO YOU WANT TO DELETE THIS RECORD?", vbQuestion + vbYesNo, "CAPES SYSTEm")) = vbYes Then
            openCon()
            Dim READER As MySqlDataReader

            Try
                Dim Query As String
                Query = "Delete from capesdatabase.information where id = '" & txtid.Text & "'"
                cmd = New MySqlCommand(Query, con)
                READER = cmd.ExecuteReader
                MsgBox("Record Deleted")
                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
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
        End If



    End Sub

    Private Sub txtremark_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtremark.SelectedIndexChanged

    End Sub
End Class