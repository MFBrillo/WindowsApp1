<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtremarkdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtdom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtentry = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtremark = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtoffice = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdesignation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdob = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtgender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcontactno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnclose = New Guna.UI2.WinForms.Guna2Button()
        Me.txtupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.txtid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.txtage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 2)
        Me.Panel2.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Leelawadee", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(68, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 32)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Member's Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtremarkdate)
        Me.GroupBox2.Controls.Add(Me.txtdom)
        Me.GroupBox2.Controls.Add(Me.txtentry)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtremark)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtoffice)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtdesignation)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 329)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(772, 199)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'txtremarkdate
        '
        Me.txtremarkdate.Checked = True
        Me.txtremarkdate.CustomFormat = "yyyy-MM-dd"
        Me.txtremarkdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtremarkdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtremarkdate.ForeColor = System.Drawing.Color.White
        Me.txtremarkdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtremarkdate.Location = New System.Drawing.Point(525, 145)
        Me.txtremarkdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtremarkdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtremarkdate.Name = "txtremarkdate"
        Me.txtremarkdate.Size = New System.Drawing.Size(210, 36)
        Me.txtremarkdate.TabIndex = 48
        Me.txtremarkdate.Value = New Date(2023, 2, 17, 10, 29, 59, 943)
        '
        'txtdom
        '
        Me.txtdom.Checked = True
        Me.txtdom.CustomFormat = "yyyy-MM-dd"
        Me.txtdom.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtdom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdom.ForeColor = System.Drawing.Color.White
        Me.txtdom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdom.Location = New System.Drawing.Point(525, 83)
        Me.txtdom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtdom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtdom.Name = "txtdom"
        Me.txtdom.Size = New System.Drawing.Size(210, 36)
        Me.txtdom.TabIndex = 47
        Me.txtdom.Value = New Date(2023, 2, 17, 10, 29, 59, 943)
        '
        'txtentry
        '
        Me.txtentry.Checked = True
        Me.txtentry.CustomFormat = "yyyy-MM-dd"
        Me.txtentry.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtentry.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtentry.ForeColor = System.Drawing.Color.White
        Me.txtentry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtentry.Location = New System.Drawing.Point(158, 83)
        Me.txtentry.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtentry.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtentry.Name = "txtentry"
        Me.txtentry.Size = New System.Drawing.Size(210, 36)
        Me.txtentry.TabIndex = 46
        Me.txtentry.Value = New Date(2023, 2, 17, 10, 29, 59, 943)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(393, 159)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "End of Membership"
        '
        'txtremark
        '
        Me.txtremark.BackColor = System.Drawing.Color.Transparent
        Me.txtremark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtremark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtremark.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtremark.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtremark.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtremark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtremark.ItemHeight = 30
        Me.txtremark.Items.AddRange(New Object() {"Active", "Retired", "Resigned"})
        Me.txtremark.Location = New System.Drawing.Point(158, 145)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(210, 36)
        Me.txtremark.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Active Status"
        '
        'txtoffice
        '
        Me.txtoffice.BackColor = System.Drawing.Color.Transparent
        Me.txtoffice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtoffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtoffice.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoffice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoffice.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtoffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtoffice.ItemHeight = 30
        Me.txtoffice.Items.AddRange(New Object() {"ACCOUNTING", "ADMINISTRATOR", "AGRICULTURE", "BDH", "CAPENRO", "CGBC", "CRC", "HRMO", "LEGAL", "MDH", "OVG", "PAO", "PBO", "PDRRMO", "PEO", "PGO", "PGSO", "PHO", "PIASO", "PPDO", "PPMD", "PSWDO", "PTCAO", "PTO", "PVO", "RMPH", "SGRMDH", "SP", "TDH"})
        Me.txtoffice.Location = New System.Drawing.Point(158, 19)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Size = New System.Drawing.Size(210, 36)
        Me.txtoffice.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(393, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Date of Membership"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Office"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(406, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Designation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Entry in Service"
        '
        'txtdesignation
        '
        Me.txtdesignation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdesignation.DefaultText = ""
        Me.txtdesignation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdesignation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdesignation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdesignation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdesignation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdesignation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdesignation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdesignation.Location = New System.Drawing.Point(525, 19)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdesignation.PlaceholderText = ""
        Me.txtdesignation.SelectedText = ""
        Me.txtdesignation.Size = New System.Drawing.Size(210, 36)
        Me.txtdesignation.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdob)
        Me.GroupBox1.Controls.Add(Me.txtgender)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtstatus)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtcontactno)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtmname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 267)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'txtdob
        '
        Me.txtdob.Checked = True
        Me.txtdob.CustomFormat = "yyyy-MM-dd"
        Me.txtdob.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtdob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdob.ForeColor = System.Drawing.Color.White
        Me.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdob.Location = New System.Drawing.Point(525, 83)
        Me.txtdob.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtdob.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(210, 36)
        Me.txtdob.TabIndex = 45
        Me.txtdob.Value = New Date(2023, 2, 17, 10, 29, 59, 943)
        '
        'txtgender
        '
        Me.txtgender.BackColor = System.Drawing.Color.Transparent
        Me.txtgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtgender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtgender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtgender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtgender.ItemHeight = 30
        Me.txtgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtgender.Location = New System.Drawing.Point(525, 202)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(210, 36)
        Me.txtgender.TabIndex = 30
        '
        'txtfname
        '
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.DefaultText = ""
        Me.txtfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Location = New System.Drawing.Point(158, 22)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.PlaceholderText = ""
        Me.txtfname.SelectedText = ""
        Me.txtfname.Size = New System.Drawing.Size(210, 36)
        Me.txtfname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'txtstatus
        '
        Me.txtstatus.BackColor = System.Drawing.Color.Transparent
        Me.txtstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtstatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtstatus.ItemHeight = 30
        Me.txtstatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widow", "Widower"})
        Me.txtstatus.Location = New System.Drawing.Point(525, 146)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(210, 36)
        Me.txtstatus.TabIndex = 29
        '
        'txtlname
        '
        Me.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlname.DefaultText = ""
        Me.txtlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlname.Location = New System.Drawing.Point(158, 83)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlname.PlaceholderText = ""
        Me.txtlname.SelectedText = ""
        Me.txtlname.Size = New System.Drawing.Size(210, 36)
        Me.txtlname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'txtaddress
        '
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.DefaultText = ""
        Me.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.Location = New System.Drawing.Point(158, 207)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.PlaceholderText = ""
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.Size = New System.Drawing.Size(210, 36)
        Me.txtaddress.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address"
        '
        'txtcontactno
        '
        Me.txtcontactno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontactno.DefaultText = ""
        Me.txtcontactno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcontactno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcontactno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcontactno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcontactno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcontactno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcontactno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcontactno.Location = New System.Drawing.Point(158, 146)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcontactno.PlaceholderText = ""
        Me.txtcontactno.SelectedText = ""
        Me.txtcontactno.Size = New System.Drawing.Size(210, 36)
        Me.txtcontactno.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Mobile Number"
        '
        'txtmname
        '
        Me.txtmname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmname.DefaultText = ""
        Me.txtmname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtmname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmname.Location = New System.Drawing.Point(525, 22)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmname.PlaceholderText = ""
        Me.txtmname.SelectedText = ""
        Me.txtmname.Size = New System.Drawing.Size(210, 36)
        Me.txtmname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(404, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Gender"
        '
        'btnclose
        '
        Me.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnclose.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(608, 542)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(148, 45)
        Me.btnclose.TabIndex = 38
        Me.btnclose.Text = "Close"
        '
        'txtupdate
        '
        Me.txtupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.txtupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.txtupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtupdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtupdate.ForeColor = System.Drawing.Color.White
        Me.txtupdate.Location = New System.Drawing.Point(410, 542)
        Me.txtupdate.Name = "txtupdate"
        Me.txtupdate.Size = New System.Drawing.Size(148, 45)
        Me.txtupdate.TabIndex = 42
        Me.txtupdate.Text = "Update"
        '
        'txtid
        '
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.DefaultText = ""
        Me.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.Enabled = False
        Me.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Location = New System.Drawing.Point(456, 4)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.PlaceholderText = ""
        Me.txtid.SelectedText = ""
        Me.txtid.Size = New System.Drawing.Size(60, 36)
        Me.txtid.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(368, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 16)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "ID NUMBER:"
        '
        'btndelete
        '
        Me.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(234, 542)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(148, 45)
        Me.btndelete.TabIndex = 47
        Me.btndelete.Text = "Delete"
        '
        'txtage
        '
        Me.txtage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtage.DefaultText = ""
        Me.txtage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtage.Enabled = False
        Me.txtage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtage.Location = New System.Drawing.Point(696, 4)
        Me.txtage.Name = "txtage"
        Me.txtage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtage.PlaceholderText = ""
        Me.txtage.SelectedText = ""
        Me.txtage.Size = New System.Drawing.Size(60, 36)
        Me.txtage.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(650, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "AGE:"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtupdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtremark As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtoffice As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdesignation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtgender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtstatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcontactno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnclose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtdob As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtremarkdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtdom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtentry As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
End Class
