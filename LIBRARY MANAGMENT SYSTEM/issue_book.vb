Imports System.Data.OleDb
Public Class issue_book
    Dim con As New OleDb.OleDbConnection
    Dim dr As OleDb.OleDbDataReader
    Dim dr1 As OleDb.OleDbDataReader
    Dim cmd As New OleDb.OleDbCommand
    Dim cmd1 As New OleDb.OleDbCommand
    Dim cmd3 As New OleDb.OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub issue_book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con

        con.Open()

        Dim sl As String
        sl = "SELECT * FROM books"

        cmd = New OleDb.OleDbCommand(sl, con)
        dr = cmd.ExecuteReader

        While dr.Read
            ListBox1.Items.Add(dr("book_name"))

        End While
        con.Close()
    End Sub

    Private Sub txtbooks_avaliable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        con.Open()

        Dim alselect As String
        alselect = "SELECT * FROM books WHERE book_name='" & ListBox1.SelectedItem & "'"

        cmd1 = New OleDb.OleDbCommand(alselect, con)
        dr1 = cmd1.ExecuteReader

        If dr1.Read Then
            txtbookid.Text = dr1("book_id").ToString
            txtisbn.Text = dr1("isbn_no").ToString
            txtsubject.Text = dr1("subject").ToString
            txtbookname.Text = dr1("book_name").ToString
            txtauthor.Text = dr1("author").ToString
            txtedition.Text = dr1("edition").ToString

        End If
        con.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd3.Connection = con

        con.Open()
        Dim sr As String
        sr = "SELECT * FROM reader WHERE customer_id='" & txtsearch_id.Text & "'"
        cmd3.Connection = con
        cmd3 = New OleDb.OleDbCommand(sr, con)

        dr = cmd3.ExecuteReader

        If dr.Read Then
            txtissuedto.Text = dr("name").ToString
            PictureBox1.ImageLocation = dr("iphoto").ToString
            GroupBox1.Visible = True

        Else
            MsgBox("The Reader Information Does Not Exits,Kindly Register")
            GroupBox1.Visible = False

        End If


        con.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()

        If MsgBox("Want to Issue out this book" + txtbookname.Text + " ?", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then



            cmd.CommandText = "INSERT INTO returned_book(book_id,reader_id,book_name,issued_date,issued_to,due_date,author,isbn_no,subject,edition) VALUES('" & txtbookid.Text & "','" & txtsearch_id.Text & "','" & txtbookname.Text & "','" & issued_date.Text & "','" & txtissuedto.Text & "','" & due_date.Text & "','" & txtauthor.Text & "','" & txtisbn.Text & "','" & txtsubject.Text & "','" & txtedition.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("The BOOK With ID:   " + txtbookid.Text + " Has been Issued Successfully.")

            cmd.CommandText = "Delete from books WHERE book_id='" & txtbookid.Text & "'"
            cmd.ExecuteNonQuery()

            txtbookid.Text = ""
            txtbookname.Text = ""
            txtisbn.Text = ""
            txtedition.Text = ""
            txtsubject.Text = ""
            txtauthor.Text = ""
            PictureBox1.Image = Nothing

        End If
        
        con.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class