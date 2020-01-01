Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDb.OleDbConnection
    Dim dr As OleDb.OleDbDataReader
    Dim cmd As New OleDb.OleDbCommand


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

        If dr.Read Then
            user = dr("username").ToString()
            pass = dr("password").ToString()

            If txtusername.Text = user And txtpassword.Text = pass Then

                ProgressBar1.Visible = True
                Timer1.Enabled = True

            Else
                Timer1.Enabled = False
                ProgressBar1.Visible = False
                MsgBox("Wrong Username:" + " " + txtusername.Text + " Or Password:")
            End If
        End If
        con.Close()



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 10 Then
            Label4.Text = "loading....."
        ElseIf ProgressBar1.Value = 30 Then
            Label4.Text = "Still Loading...."
        ElseIf ProgressBar1.Value = 50 Then
            Label4.Text = "Processing..."
        ElseIf ProgressBar1.Value = 67 Then
            Label4.Text = "Waiting...."
        End If

        If ProgressBar1.Value = 100 Then

            Me.Hide()
            Home.Show()
            Timer1.Enabled = False
            Label4.Visible = True

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
