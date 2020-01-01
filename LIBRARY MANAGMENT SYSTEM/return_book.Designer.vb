<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class return_book
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbookid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtreader_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbookname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtissued_date = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdue_date = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtisbn = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtedition = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtissuedto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.Subject = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(398, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(380, 424)
        Me.ListBox1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 39)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Books Borrowed"
        '
        'txtbookid
        '
        Me.txtbookid.Enabled = False
        Me.txtbookid.Location = New System.Drawing.Point(137, 9)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(197, 20)
        Me.txtbookid.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Book ID:"
        '
        'txtreader_id
        '
        Me.txtreader_id.Enabled = False
        Me.txtreader_id.Location = New System.Drawing.Point(137, 46)
        Me.txtreader_id.Name = "txtreader_id"
        Me.txtreader_id.Size = New System.Drawing.Size(197, 20)
        Me.txtreader_id.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Reader's ID:"
        '
        'txtbookname
        '
        Me.txtbookname.Enabled = False
        Me.txtbookname.Location = New System.Drawing.Point(137, 82)
        Me.txtbookname.Name = "txtbookname"
        Me.txtbookname.Size = New System.Drawing.Size(197, 20)
        Me.txtbookname.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Book Name:"
        '
        'txtissued_date
        '
        Me.txtissued_date.Enabled = False
        Me.txtissued_date.Location = New System.Drawing.Point(137, 118)
        Me.txtissued_date.Name = "txtissued_date"
        Me.txtissued_date.Size = New System.Drawing.Size(197, 20)
        Me.txtissued_date.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Issued Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 25)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Due Date:"
        '
        'txtdue_date
        '
        Me.txtdue_date.Enabled = False
        Me.txtdue_date.Location = New System.Drawing.Point(137, 155)
        Me.txtdue_date.Name = "txtdue_date"
        Me.txtdue_date.Size = New System.Drawing.Size(197, 20)
        Me.txtdue_date.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(556, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 45)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Return Book"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(445, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 39)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Book's Infromation"
        '
        'txtauthor
        '
        Me.txtauthor.Enabled = False
        Me.txtauthor.Location = New System.Drawing.Point(137, 197)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(197, 20)
        Me.txtauthor.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 25)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Author:"
        '
        'txtisbn
        '
        Me.txtisbn.Enabled = False
        Me.txtisbn.Location = New System.Drawing.Point(137, 236)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(197, 20)
        Me.txtisbn.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Isbn No:"
        '
        'txtedition
        '
        Me.txtedition.Enabled = False
        Me.txtedition.Location = New System.Drawing.Point(137, 275)
        Me.txtedition.Name = "txtedition"
        Me.txtedition.Size = New System.Drawing.Size(197, 20)
        Me.txtedition.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 25)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Edition:"
        '
        'txtissuedto
        '
        Me.txtissuedto.Enabled = False
        Me.txtissuedto.Location = New System.Drawing.Point(137, 313)
        Me.txtissuedto.Name = "txtissuedto"
        Me.txtissuedto.Size = New System.Drawing.Size(197, 20)
        Me.txtissuedto.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 308)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 25)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Issued To:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsubject)
        Me.GroupBox1.Controls.Add(Me.Subject)
        Me.GroupBox1.Controls.Add(Me.txtissuedto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtedition)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtisbn)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtauthor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtdue_date)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtissued_date)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtbookname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtreader_id)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtbookid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(406, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 371)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'txtsubject
        '
        Me.txtsubject.Enabled = False
        Me.txtsubject.Location = New System.Drawing.Point(137, 345)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(197, 20)
        Me.txtsubject.TabIndex = 52
        '
        'Subject
        '
        Me.Subject.AutoSize = True
        Me.Subject.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject.Location = New System.Drawing.Point(8, 340)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(134, 25)
        Me.Subject.TabIndex = 51
        Me.Subject.Text = "Subject Name:"
        '
        'return_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(895, 528)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "return_book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "return_book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbookid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtreader_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbookname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtissued_date As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdue_date As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtauthor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtisbn As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtedition As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtissuedto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsubject As System.Windows.Forms.TextBox
    Friend WithEvents Subject As System.Windows.Forms.Label
End Class
