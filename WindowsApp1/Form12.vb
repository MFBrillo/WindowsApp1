Imports MySql.Data.MySqlClient
Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOfficer()
    End Sub
    Public Sub LoadOfficer()
        Dim i As Integer
        DataGridView1.Rows.Clear()
        openCon()
        cmd = New MySqlCommand("SELECT * , YEAR(startofterm) AS start_year, YEAR(endofterm) as end_year FROM capesdatabase.officer;", con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("position").ToString, dr.Item("name").ToString, dr.Item("contact").ToString, dr.Item("address").ToString, dr.Item("start_year").ToString, dr.Item("end_year").ToString)

        End While
        con.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Form2.switchPanel(Form10)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class