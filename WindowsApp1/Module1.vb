Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public information As New DataSet

    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=rootcapes;database=capesdatabase"
        con.Open()
    End Sub



End Module
