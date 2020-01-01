Public Class Home

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Are You Sure You Want To Logout?", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
            Form1.txtusername.Text = ""
            Form1.txtpassword.Text = ""
            Form1.ProgressBar1.Value = 0
            Form1.Timer1.Enabled = False
            Form1.ProgressBar1.Visible = False
            Form1.Label4.Visible = False

            Me.Hide()
            Form1.show

        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        description.Text = "In This Section, Libarian Can Add books,Delete books,and search For Books orderly Either By Book ID or Author's Name."
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        description.Text = ""

    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        description.Text = "You Can Register New Reader,View Exiting Readers And Delete Readers,Here."
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        description.Text = ""

    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        description.Text = "Books Can Be Borrowed To Any Registered Readers Here."
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        description.Text = ""

    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        description.Text = " Books Are Been Returned after Its been Borrowed From the Book Catalog."
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        description.Text = ""

    End Sub

    Private Sub Label6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseHover
        description.Text = "Close The Entire Windows"
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        description.Text = ""
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        book_infromation.Show()

    End Sub

    Private Sub ViewBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBooksToolStripMenuItem.Click
        view_book.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        reader.Show()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        issue_book.Show()
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        reset.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        return_book.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class