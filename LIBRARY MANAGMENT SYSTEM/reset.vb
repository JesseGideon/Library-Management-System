Imports System.Data.OleDb
Public Class reset
    Dim con As New OleDb.OleDbConnection
    Dim dr As OleDb.OleDbDataReader
    Dim cmd As New OleDb.OleDbCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\LIBRARY MANAGMENT SYSTEM\libraryDB.mdb"
        cmd.Connection = con
        con.Open()


        Dim s As String
        s = "SELECT * FROM admin"
        cmd = New OleDb.OleDbCommand(s, con)
        dr = cmd.ExecuteReader

        Dim user As String
        Dim pass As String
        Dim st As String

        If dr.Read Then
            user = dr("username").ToString()
            pass = dr("password").ToString()


            If txtprevious_username.Text = user And txtprevious_password.Text = pass Then
                st = "update [admin] set [username]='" & txtnew_username.Text & "', [password]='" & txtnew_password.Text & "' "
                cmd = New OleDb.OleDbCommand(st, con)
                cmd.ExecuteNonQuery()


                MsgBox("Password/username sucessfully Reseted")
                txtprevious_username.Text = ""
                txtprevious_password.Text = ""
                txtnew_username.Text = ""
                txtnew_password.Text = ""


            Else
                MsgBox("Previous Username/Password Did Not Match.Reset Unsucessful", MsgBoxStyle.Information)

            End If
        End If
        
        con.Close()

    End Sub
End Class