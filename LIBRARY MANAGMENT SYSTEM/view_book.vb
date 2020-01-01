Imports System.Data.OleDb
Public Class view_book
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim table As New DataTable
    Dim adpt As New OleDb.OleDbDataAdapter
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub view_book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()
        Dim s As String
        s = "SELECT * FROM books"

        adpt = New OleDb.OleDbDataAdapter(s, con)
        con.Close()

        adpt.Fill(table)
        DataGridView1.DataSource = table
        adpt.Dispose()

    End Sub
End Class