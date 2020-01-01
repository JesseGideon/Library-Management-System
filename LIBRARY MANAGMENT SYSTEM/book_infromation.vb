
Imports System.Data.OleDb
Public Class book_infromation
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub book_infromation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Book ID" Then
            iblsearch_bookid.Visible = True
            txtsearch_id.Visible = True
            btnsearch_id.Visible = True
            Button3.Visible = True

            iblauthor_name.Visible = False
            txtsearch_author.Visible = False
            btn_author.Visible = False
            Button5.Visible = False


        ElseIf ComboBox1.Text = "Author's Name" Then
            iblauthor_name.Visible = True
            txtsearch_author.Visible = True
            btn_author.Visible = True
            Button5.Visible = True

            iblsearch_bookid.Visible = False
            txtsearch_id.Visible = False
            btnsearch_id.Visible = False
            Button3.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "INSERT INTO books(book_id,isbn_no,subject,book_name,author,publisher,edition,copies,book_pages) VALUES('" & txtreg_bookid.Text & "','" & txtreg_isbn.Text & "','" & txtreg_subject.Text & "','" & txtreg_bookname.Text & "','" & txtreg_author.Text & "','" & txtreg_publisher.Text & "','" & txtreg_edition.Text & "','" & txtreg_copies.Text & "','" & txtreg_bookpages.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("The BOOK With ID: " + txtreg_bookid.Text + " Has been Inserted Successfully.")
        txtreg_bookid.Text = ""
        txtreg_isbn.Text = ""
        txtreg_subject.Text = ""
        txtreg_bookname.Text = ""
        txtreg_author.Text = ""
        txtreg_publisher.Text = ""
        txtreg_edition.Text = ""
        txtreg_copies.Text = ""
        txtreg_bookpages.Text = ""

        con.Close()

    End Sub

    Private Sub btnsearch_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch_id.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()

        Dim search As String
        search = "SELECT * FROM books WHERE book_id='" & txtsearch_id.Text & "'"
        cmd = New OleDb.OleDbCommand(search, con)

        dr = cmd.ExecuteReader
        If dr.Read Then
            txtsearch_bookid.Text = dr("book_id").ToString
            txtsearch_isbn.Text = dr("isbn_no").ToString
            txtsearch_subject.Text = dr("subject").ToString
            txtsearch_bookname.Text = dr("book_name").ToString
            txtsearchauthor.Text = dr("author").ToString
            txtsearch_publisher.Text = dr("publisher").ToString
            txtsearch_edition.Text = dr("edition").ToString
            txtsearch_copies.Text = dr("copies").ToString
            txtsearch_bookpages.Text = dr("book_pages").ToString
        Else
            MsgBox("The Book ID:" + txtsearch_id.Text + " Does Not Exits")

        End If
        con.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtsearch_bookid.Text = ""
        txtsearch_isbn.Text = ""
        txtsearch_subject.Text = ""
        txtsearch_bookname.Text = ""
        txtsearchauthor.Text = ""
        txtsearch_publisher.Text = ""
        txtsearch_edition.Text = ""
        txtsearch_copies.Text = ""
        txtsearch_bookpages.Text = ""

    End Sub

    Private Sub btn_author_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_author.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()

        Dim search As String
        search = "SELECT * FROM books WHERE author ='" & txtsearch_author.Text & "'"
        cmd = New OleDb.OleDbCommand(search, con)

        dr = cmd.ExecuteReader
        If dr.Read Then
            txtsearch_bookid.Text = dr("book_id").ToString
            txtsearch_isbn.Text = dr("isbn_no").ToString
            txtsearch_subject.Text = dr("subject").ToString
            txtsearch_bookname.Text = dr("book_name").ToString
            txtsearchauthor.Text = dr("author").ToString
            txtsearch_publisher.Text = dr("publisher").ToString
            txtsearch_edition.Text = dr("edition").ToString
            txtsearch_copies.Text = dr("copies").ToString
            txtsearch_bookpages.Text = dr("book_pages").ToString
        Else
            MsgBox("The Author Name:" + txtsearch_author.Text + " Does Not Exits")
        End If
        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()

        If MsgBox("Sure You want to Delete The Book with ID:" + txtsearch_id.Text + "? ", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd.CommandText = "DELETE FROM books WHERE book_id='" & txtsearch_id.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")
            txtsearch_bookid.Text = ""
            txtsearch_isbn.Text = ""
            txtsearch_subject.Text = ""
            txtsearch_bookname.Text = ""
            txtsearchauthor.Text = ""
            txtsearch_publisher.Text = ""
            txtsearch_edition.Text = ""
            txtsearch_copies.Text = ""
            txtsearch_bookpages.Text = ""
        End If



        con.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()

        If MsgBox("Sure You want to Delete The Book with ID:" + txtsearch_id.Text + "? ", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd.CommandText = "DELETE FROM books WHERE author='" & txtsearch_author.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")
            txtsearch_bookid.Text = ""
            txtsearch_isbn.Text = ""
            txtsearch_subject.Text = ""
            txtsearch_bookname.Text = ""
            txtsearchauthor.Text = ""
            txtsearch_publisher.Text = ""
            txtsearch_edition.Text = ""
            txtsearch_copies.Text = ""
            txtsearch_bookpages.Text = ""
        End If



        con.Close()
    End Sub
End Class