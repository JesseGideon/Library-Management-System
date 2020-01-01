<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reader
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reader))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.MaskedTextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtactivationdate = New System.Windows.Forms.DateTimePicker()
        Me.txtvaliddate = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtgender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.passport = New System.Windows.Forms.PictureBox()
        Me.txtpassport = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtsearch_address = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtsearch_readerid = New System.Windows.Forms.TextBox()
        Me.txtsearch_id = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtsearch_name = New System.Windows.Forms.TextBox()
        Me.txtsearch_gender = New System.Windows.Forms.TextBox()
        Me.txtsearch_activation = New System.Windows.Forms.TextBox()
        Me.txtsearch_valid = New System.Windows.Forms.TextBox()
        Me.searchpic = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txtsearch_contact = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(6, 28)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(855, 161)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(389, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Reader's ID:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(140, 48)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(150, 22)
        Me.txtname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1255, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Address:"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(648, 397)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "View "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Activation Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Valid Till:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(591, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Passport:"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(140, 20)
        Me.txtid.Mask = "R/0000"
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(152, 22)
        Me.txtid.TabIndex = 12
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(140, 76)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(217, 88)
        Me.txtaddress.TabIndex = 13
        '
        'txtactivationdate
        '
        Me.txtactivationdate.Location = New System.Drawing.Point(187, 236)
        Me.txtactivationdate.Name = "txtactivationdate"
        Me.txtactivationdate.Size = New System.Drawing.Size(173, 22)
        Me.txtactivationdate.TabIndex = 15
        '
        'txtvaliddate
        '
        Me.txtvaliddate.Location = New System.Drawing.Point(187, 270)
        Me.txtvaliddate.Name = "txtvaliddate"
        Me.txtvaliddate.Size = New System.Drawing.Size(170, 22)
        Me.txtvaliddate.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(1174, 66)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(616, 206)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Browse....."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(389, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtgender)
        Me.GroupBox1.Controls.Add(Me.txtvaliddate)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtactivationdate)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 310)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register New Reader"
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(187, 177)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(173, 22)
        Me.txtcontact.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(34, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 25)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Contact Number:"
        '
        'txtgender
        '
        Me.txtgender.FormattingEnabled = True
        Me.txtgender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.txtgender.Location = New System.Drawing.Point(187, 205)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(170, 24)
        Me.txtgender.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(473, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Registered Readers"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 395)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(876, 211)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'passport
        '
        Me.passport.Image = CType(resources.GetObject("passport.Image"), System.Drawing.Image)
        Me.passport.Location = New System.Drawing.Point(580, 68)
        Me.passport.Name = "passport"
        Me.passport.Size = New System.Drawing.Size(160, 132)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 20
        Me.passport.TabStop = False
        '
        'txtpassport
        '
        Me.txtpassport.Enabled = False
        Me.txtpassport.Location = New System.Drawing.Point(617, 235)
        Me.txtpassport.Name = "txtpassport"
        Me.txtpassport.Size = New System.Drawing.Size(106, 20)
        Me.txtpassport.TabIndex = 23
        Me.txtpassport.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 25)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Valid Till:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 25)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Activation Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Reader ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(74, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 25)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Gender:"
        '
        'txtsearch_address
        '
        Me.txtsearch_address.Enabled = False
        Me.txtsearch_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_address.Location = New System.Drawing.Point(148, 69)
        Me.txtsearch_address.Multiline = True
        Me.txtsearch_address.Name = "txtsearch_address"
        Me.txtsearch_address.Size = New System.Drawing.Size(217, 88)
        Me.txtsearch_address.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 25)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Address:"
        '
        'txtsearch_readerid
        '
        Me.txtsearch_readerid.Enabled = False
        Me.txtsearch_readerid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_readerid.Location = New System.Drawing.Point(148, 4)
        Me.txtsearch_readerid.Name = "txtsearch_readerid"
        Me.txtsearch_readerid.Size = New System.Drawing.Size(150, 22)
        Me.txtsearch_readerid.TabIndex = 25
        '
        'txtsearch_id
        '
        Me.txtsearch_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_id.Location = New System.Drawing.Point(1016, 66)
        Me.txtsearch_id.Mask = "R/0000"
        Me.txtsearch_id.Name = "txtsearch_id"
        Me.txtsearch_id.Size = New System.Drawing.Size(152, 22)
        Me.txtsearch_id.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 25)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Name:"
        '
        'txtsearch_name
        '
        Me.txtsearch_name.Enabled = False
        Me.txtsearch_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_name.Location = New System.Drawing.Point(148, 32)
        Me.txtsearch_name.Name = "txtsearch_name"
        Me.txtsearch_name.Size = New System.Drawing.Size(150, 22)
        Me.txtsearch_name.TabIndex = 36
        '
        'txtsearch_gender
        '
        Me.txtsearch_gender.Enabled = False
        Me.txtsearch_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_gender.Location = New System.Drawing.Point(190, 194)
        Me.txtsearch_gender.Name = "txtsearch_gender"
        Me.txtsearch_gender.Size = New System.Drawing.Size(150, 22)
        Me.txtsearch_gender.TabIndex = 37
        '
        'txtsearch_activation
        '
        Me.txtsearch_activation.Enabled = False
        Me.txtsearch_activation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_activation.Location = New System.Drawing.Point(190, 227)
        Me.txtsearch_activation.Name = "txtsearch_activation"
        Me.txtsearch_activation.Size = New System.Drawing.Size(150, 22)
        Me.txtsearch_activation.TabIndex = 38
        '
        'txtsearch_valid
        '
        Me.txtsearch_valid.Enabled = False
        Me.txtsearch_valid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_valid.Location = New System.Drawing.Point(190, 262)
        Me.txtsearch_valid.Name = "txtsearch_valid"
        Me.txtsearch_valid.Size = New System.Drawing.Size(150, 22)
        Me.txtsearch_valid.TabIndex = 39
        '
        'searchpic
        '
        Me.searchpic.Image = CType(resources.GetObject("searchpic.Image"), System.Drawing.Image)
        Me.searchpic.Location = New System.Drawing.Point(1222, 113)
        Me.searchpic.Name = "searchpic"
        Me.searchpic.Size = New System.Drawing.Size(144, 132)
        Me.searchpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.searchpic.TabIndex = 40
        Me.searchpic.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1250, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 25)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Passport:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.txtsearch_contact)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtsearch_valid)
        Me.GroupBox3.Controls.Add(Me.txtsearch_activation)
        Me.GroupBox3.Controls.Add(Me.txtsearch_gender)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtsearch_name)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtsearch_address)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtsearch_readerid)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(851, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 297)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(397, 268)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 23)
        Me.Button8.TabIndex = 45
        Me.Button8.Text = "Clear "
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txtsearch_contact
        '
        Me.txtsearch_contact.Enabled = False
        Me.txtsearch_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_contact.Location = New System.Drawing.Point(190, 165)
        Me.txtsearch_contact.Name = "txtsearch_contact"
        Me.txtsearch_contact.Size = New System.Drawing.Size(150, 22)
        Me.txtsearch_contact.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 25)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Contact Number:"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(616, 302)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(170, 23)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Close This Interface"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(648, 372)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "Close view"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(229, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(238, 25)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Register New Reader Here "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(944, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(328, 25)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Search For Reader's Information Here"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(904, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 25)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Reader ID:"
        '
        'reader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1378, 611)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.searchpic)
        Me.Controls.Add(Me.txtsearch_id)
        Me.Controls.Add(Me.txtpassport)
        Me.Controls.Add(Me.passport)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reader"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtactivationdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtvaliddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents passport As System.Windows.Forms.PictureBox
    Friend WithEvents txtgender As System.Windows.Forms.ComboBox
    Friend WithEvents txtpassport As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtsearch_address As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtsearch_readerid As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch_id As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtsearch_name As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch_gender As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch_activation As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch_valid As System.Windows.Forms.TextBox
    Friend WithEvents searchpic As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtsearch_contact As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
