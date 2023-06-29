Imports MySql.Data.MySqlClient
Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOfficer()
    End Sub

    Public Sub LoadOfficer()
        Dim i As Integer
        DataGridView1.Rows.Clear()
        openCon()
        cmd = New MySqlCommand("SELECT id, concat(fname, SPACE(2),mname,SPACE(2),lname) as Name, date_format(dob, '%M %d %Y' ) as dob FROM information WHERE 1 = (FLOOR(DATEDIFF(DATE_ADD(DATE(NOW()),INTERVAL 30 DAY),dob) / 365.25)) - (FLOOR(DATEDIFF(DATE(NOW()),dob) / 365.25))ORDER BY MONTH(dob),DAY(dob)", con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("Name").ToString, dr.Item("dob").ToString)

        End While
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class