Imports MySql.Data.MySqlClient
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(Form10)
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel4.Controls.Clear()
        panel.TopLevel = False
        Panel4.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click




    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        switchPanel(Form10)
        Form10.UpdateRecord()
    End Sub

    Private Sub btnmember_Click(sender As Object, e As EventArgs) Handles btnmember.Click
        switchPanel(Form3)
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        switchPanel(Form4)
        Form4.LoadRecord()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim conn As New MySqlConnection("server=localhost;username=root;password=rootcapes;database=capesdatabase")
        Dim cmd1 As New MySqlCommand("select * from capesdatabase.information", con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        da.fill(dt)
        Dim report As New CrystalReport1
        report.SetDataSource(dt)
        Form5.CrystalReportViewer1.ReportSource = report
        Form5.Show()



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        switchPanel(Form11)
    End Sub
End Class