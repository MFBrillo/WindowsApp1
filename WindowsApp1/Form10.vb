Imports MySql.Data.MySqlClient
Public Class Form10
    Private Sub btnoffice_Click(sender As Object, e As EventArgs) Handles btnoffice.Click
        Dim conn As New MySqlConnection("server=localhost;username=root;password=rootcapes;database=capesdatabase")
        Dim cmd1 As New MySqlCommand("select id, fname, mname, lname, office, designation,remark from information where office='" & txtoffice.Text & "' ", con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        da.Fill(dt)
        Dim report As New CrystalReport3
        report.SetDataSource(dt)

        Form8.CrystalReportViewer1.ReportSource = report
        Form8.Show()
    End Sub



    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(Form14)
        UpdateRecord()

    End Sub

    Public Sub UpdateRecord()
        openCon()
        Dim Query As String
        Query = "Select count(remark) from information where remark='Active'"
        cmd = New MySqlCommand(Query, con)
        adapter.SelectCommand = cmd
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.Rows.Count > 0 Then
            lblactive.Text = dt.Rows(0)(0).ToString
        End If
        con.Close()
    End Sub


    Private Sub lblactive_Click(sender As Object, e As EventArgs) Handles lblactive.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Form2.switchPanel(Form12)

    End Sub

    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub txtoffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtoffice.SelectedIndexChanged

    End Sub
End Class