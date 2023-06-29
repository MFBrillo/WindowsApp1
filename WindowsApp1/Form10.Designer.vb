<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnoffice = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtoffice = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblactive = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnoffice
        '
        Me.btnoffice.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnoffice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnoffice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnoffice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnoffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnoffice.ForeColor = System.Drawing.Color.White
        Me.btnoffice.Location = New System.Drawing.Point(11, 65)
        Me.btnoffice.Name = "btnoffice"
        Me.btnoffice.Size = New System.Drawing.Size(180, 47)
        Me.btnoffice.TabIndex = 1
        Me.btnoffice.Text = "View"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(295, 55)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(200, 119)
        Me.Guna2Panel2.TabIndex = 4
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(1, 0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(197, 119)
        Me.Guna2Button2.TabIndex = 3
        Me.Guna2Button2.Text = "Officer"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.txtoffice)
        Me.Guna2Panel3.Controls.Add(Me.btnoffice)
        Me.Guna2Panel3.Location = New System.Drawing.Point(547, 55)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(200, 119)
        Me.Guna2Panel3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Choose Office"
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
        Me.txtoffice.Location = New System.Drawing.Point(11, 25)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Size = New System.Drawing.Size(180, 36)
        Me.txtoffice.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(83, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Active Members"
        '
        'lblactive
        '
        Me.lblactive.AutoSize = True
        Me.lblactive.BackColor = System.Drawing.Color.Transparent
        Me.lblactive.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactive.ForeColor = System.Drawing.Color.Black
        Me.lblactive.Location = New System.Drawing.Point(79, 85)
        Me.lblactive.Name = "lblactive"
        Me.lblactive.Size = New System.Drawing.Size(111, 62)
        Me.lblactive.TabIndex = 0
        Me.lblactive.Text = "NO."
        Me.lblactive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(46, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 343)
        Me.Panel1.TabIndex = 35
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblactive)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnoffice As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtoffice As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblactive As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
End Class
