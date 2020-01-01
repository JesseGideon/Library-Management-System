<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class issue_book
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(issue_book))
        Me.txtsearch_id = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtbookid = New System.Windows.Forms.TextBox()
        Me.txtisbn = New System.Windows.Forms.TextBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.txtedition = New System.Windows.Forms.TextBox()
        Me.txtissuedto = New System.Windows.Forms.TextBox()
        Me.due_date = New System.Windows.Forms.DateTimePicker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtbookname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.issued_date = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsearch_id
        '
        Me.txtsearch_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_id.Location = New System.Drawing.Point(394, 49)
        Me.txtsearch_id.Mask = "R/0000"
        Me.txtsearch_id.Name = "txtsearch_id"
        Me.txtsearch_id.Size = New System.Drawing.Size(152, 22)
        Me.txtsearch_id.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Reader's ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(204, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(458, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ISSUE BOOK TO ONLY REGISTERD READERS"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(503, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 51)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Close Interface"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(552, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 24)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Search "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Book ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ISBN No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Subject:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Books Avilable:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 402)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Author:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 444)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Edition:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 485)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Book Issued To:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 25)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Due Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(471, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 25)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Passport:"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(386, 436)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 49)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Issue This Book"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(438, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'txtbookid
        '
        Me.txtbookid.Enabled = False
        Me.txtbookid.Location = New System.Drawing.Point(160, 47)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(197, 22)
        Me.txtbookid.TabIndex = 29
        '
        'txtisbn
        '
        Me.txtisbn.Enabled = False
        Me.txtisbn.Location = New System.Drawing.Point(160, 88)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(197, 22)
        Me.txtisbn.TabIndex = 30
        '
        'txtsubject
        '
        Me.txtsubject.Enabled = False
        Me.txtsubject.Location = New System.Drawing.Point(160, 125)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(197, 22)
        Me.txtsubject.TabIndex = 31
        '
        'txtauthor
        '
        Me.txtauthor.Enabled = False
        Me.txtauthor.Location = New System.Drawing.Point(155, 411)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(202, 22)
        Me.txtauthor.TabIndex = 33
        '
        'txtedition
        '
        Me.txtedition.Enabled = False
        Me.txtedition.Location = New System.Drawing.Point(155, 449)
        Me.txtedition.Name = "txtedition"
        Me.txtedition.Size = New System.Drawing.Size(202, 22)
        Me.txtedition.TabIndex = 34
        '
        'txtissuedto
        '
        Me.txtissuedto.Enabled = False
        Me.txtissuedto.Location = New System.Drawing.Point(165, 490)
        Me.txtissuedto.Name = "txtissuedto"
        Me.txtissuedto.Size = New System.Drawing.Size(192, 22)
        Me.txtissuedto.TabIndex = 35
        '
        'due_date
        '
        Me.due_date.Location = New System.Drawing.Point(160, 537)
        Me.due_date.Name = "due_date"
        Me.due_date.Size = New System.Drawing.Size(179, 22)
        Me.due_date.TabIndex = 36
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(143, 151)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(237, 180)
        Me.ListBox1.TabIndex = 37
        '
        'txtbookname
        '
        Me.txtbookname.Enabled = False
        Me.txtbookname.Location = New System.Drawing.Point(155, 371)
        Me.txtbookname.Name = "txtbookname"
        Me.txtbookname.Size = New System.Drawing.Size(202, 22)
        Me.txtbookname.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 366)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 25)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Book Name:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(668, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(215, 157)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.issued_date)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtbookname)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.due_date)
        Me.GroupBox1.Controls.Add(Me.txtissuedto)
        Me.GroupBox1.Controls.Add(Me.txtedition)
        Me.GroupBox1.Controls.Add(Me.txtauthor)
        Me.GroupBox1.Controls.Add(Me.txtsubject)
        Me.GroupBox1.Controls.Add(Me.txtisbn)
        Me.GroupBox1.Controls.Add(Me.txtbookid)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 650)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book's Information"
        Me.GroupBox1.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(100, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(419, 25)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Select Books To be Issued From Books Avaliable"
        '
        'issued_date
        '
        Me.issued_date.Location = New System.Drawing.Point(160, 589)
        Me.issued_date.Name = "issued_date"
        Me.issued_date.Size = New System.Drawing.Size(179, 22)
        Me.issued_date.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(29, 581)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 25)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Issued Date:"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(552, 77)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 24)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'issue_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(962, 780)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsearch_id)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "issue_book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "issue_book"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsearch_id As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtbookid As System.Windows.Forms.TextBox
    Friend WithEvents txtisbn As System.Windows.Forms.TextBox
    Friend WithEvents txtsubject As System.Windows.Forms.TextBox
    Friend WithEvents txtauthor As System.Windows.Forms.TextBox
    Friend WithEvents txtedition As System.Windows.Forms.TextBox
    Friend WithEvents txtissuedto As System.Windows.Forms.TextBox
    Friend WithEvents due_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtbookname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents issued_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
