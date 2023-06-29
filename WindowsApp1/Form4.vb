Imports MySql.Data.MySqlClient
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub LoadRecord()
        Dim i As Integer
        DataGridView1.Rows.Clear()
        openCon()
        cmd = New MySqlCommand("select *, date_format(dom, '%M %d %Y' ) as dom1 from information", con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("fname").ToString, dr.Item("mname").ToString, dr.Item("lname").ToString, dr.Item("remark").ToString, dr.Item("office").ToString, dr.Item("contactno").ToString, dr.Item("dom1").ToString)

        End While
        con.Close()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim conn As New MySqlConnection("server=localhost;username=root;password=rootcapes;database=capesdatabase")
        Dim cmd1 As New MySqlCommand("select * from capesdatabase.information where id = " & txtid.Text & " ", con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        da.Fill(dt)
        Dim report As New CrystalReport2
        report.SetDataSource(dt)

        Form6.CrystalReportViewer1.ReportSource = report
        Form6.Show()
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim i As Integer
        DataGridView1.Rows.Clear()
        openCon()

        cmd = New MySqlCommand("select *, date_format(dom, '%M %d %Y' ) as dom1 from information where fname Like '" & txtsearch.Text & "%'", con)
        '"SELECT * , YEAR(startofterm) AS start_year, YEAR(endofterm) as end_year FROM capesdatabase.officer;"
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("fname").ToString, dr.Item("mname").ToString, dr.Item("lname").ToString, dr.Item("remark").ToString, dr.Item("office").ToString, dr.Item("contactno").ToString, dr.Item("dom1").ToString)
            txtid.Text = DataGridView1.CurrentRow.Cells(0).Value

        End While
        con.Close()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Form7.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
        Form7.ShowDialog()
    End Sub
End Class