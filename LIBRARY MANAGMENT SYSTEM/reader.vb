Imports System.Data.OleDb
Public Class reader
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim table As New DataTable
    Dim adpt As New OleDb.OleDbDataAdapter

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "INSERT INTO reader(customer_id,name,address,contact,gender,activation_date,valid_till,iphoto) VALUES('" & txtid.Text & "','" & txtname.Text & "','" & txtaddress.Text & "','" & txtcontact.Text & "','" & txtgender.Text & "','" & txtactivationdate.Text & "','" & txtvaliddate.Text & "','" & txtpassport.Text & "')"
        cmd.ExecuteNonQuery()

        MsgBox("The Registred Reader:" + txtname.Text + " Was Successful.")
        txtid.Text = ""
        txtname.Text = ""
        txtaddress.Text = ""
        txtcontact.Text = ""
        txtgender.Text = ""
        txtactivationdate.Text = ""
        txtvaliddate.Text = ""
        passport.Image = Nothing


        con.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()

        OpenFileDialog1.Filter = "All files |*.*| Bitmap Files (*)|*.bmp; *.jpeg; *.png"
        txtpassport.Text = OpenFileDialog1.FileName
        passport.Image = Image.FromFile(txtpassport.Text)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox2.Show()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()
        Dim s As String
        s = "Select * from reader"
        adpt = New OleDb.OleDbDataAdapter(s, con)

        con.Close()
        adpt.Fill(table)
        DataGridView1.DataSource = table
        adpt.Dispose()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        GroupBox2.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()

        Dim search As String
        search = "Select * from reader where customer_id='" & txtsearch_id.Text & "'"
        cmd = New OleDb.OleDbCommand(search, con)
        dr = cmd.ExecuteReader
        If dr.Read Then

            txtsearch_readerid.Text = dr("customer_id").ToString
            txtsearch_name.Text = dr("name").ToString
            txtsearch_address.Text = dr("address").ToString
            txtsearch_contact.Text = dr("contact").ToString
            txtsearch_gender.Text = dr("gender").ToString
            txtsearch_activation.Text = dr("activation_date").ToString
            txtsearch_valid.Text = dr("valid_till").ToString
            searchpic.ImageLocation = dr("iphoto").ToString

        Else
            MsgBox("This Reader Does Not Exits Or Have not been Registerd")

        End If
        con.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txtsearch_readerid.Text = ""
        txtsearch_name.Text = ""
        txtsearch_address.Text = ""
        txtsearch_contact.Text = ""
        txtsearch_gender.Text = ""
        txtsearch_activation.Text = ""
        txtsearch_valid.Text = ""
        searchpic.ImageLocation = Nothing

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()
        If MsgBox("Do you want to Delete This Reader WIth ID:" + txtsearch_id.Text + "?", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd.CommandText = "Delete from reader where customer_id='" & txtsearch_id.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub

    Private Sub reader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class