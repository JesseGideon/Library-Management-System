Imports System.Data.OleDb
Public Class return_book
    Dim con As New OleDb.OleDbConnection
    Dim dr As OleDb.OleDbDataReader
    Dim cmd As New OleDb.OleDbCommand
    Dim dr1 As OleDb.OleDbDataReader
    Dim cmd1 As New OleDb.OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub return_book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()


        Dim sl As String
        sl = "SELECT * FROM returned_book"

        cmd = New OleDb.OleDbCommand(sl, con)
        dr = cmd.ExecuteReader

        While dr.Read
            ListBox1.Items.Add(dr("book_name"))
        End While



        con.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()


        Dim sl As String
        sl = "SELECT * FROM returned_book Where book_name='" & ListBox1.SelectedItem & "'"
        
        cmd = New OleDb.OleDbCommand(sl, con)
        dr = cmd.ExecuteReader

        If dr.Read Then
            txtbookid.Text = dr("book_id")
            txtbookname.Text = dr("book_name")
            txtreader_id.Text = dr("reader_id")
            txtissued_date.Text = dr("issued_date")
            txtdue_date.Text = dr("due_date")
            txtissuedto.Text = dr("issued_to")
            txtauthor.Text = dr("author")
            txtedition.Text = dr("edition")
            txtisbn.Text = dr("isbn_no")
            txtsubject.Text = dr("subject").ToString

        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()

        If MsgBox("You Want to Return this book" + txtbookname.Text + " ?, it Will no longer Be On You borrwed List Items", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then



            cmd.CommandText = "INSERT INTO books(book_id,book_name,author,isbn_no,subject,edition) VALUES('" & txtbookid.Text & "','" & txtbookname.Text & "','" & txtauthor.Text & "','" & txtisbn.Text & "','" & txtsubject.Text & "','" & txtedition.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("The BOOK With ID:   " + txtbookid.Text + " Has been Successfully Returned.")

            cmd.CommandText = "Delete from returned_book WHERE book_id='" & txtbookid.Text & "'"
            cmd.ExecuteNonQuery()

            txtbookid.Text = ""
            txtbookname.Text = ""
            txtisbn.Text = ""
            txtedition.Text = ""
            txtsubject.Text = ""
            txtauthor.Text = ""


        End If

        con.Close()
    End Sub
End Class