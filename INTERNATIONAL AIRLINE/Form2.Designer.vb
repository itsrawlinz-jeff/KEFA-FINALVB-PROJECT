<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMDADD = New System.Windows.Forms.Button()
        Me.CMDUPDATE = New System.Windows.Forms.Button()
        Me.CMDDELETE = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtairlinename = New System.Windows.Forms.TextBox()
        Me.txtcountry = New System.Windows.Forms.TextBox()
        Me.txtowner = New System.Windows.Forms.TextBox()
        Me.txtbase = New System.Windows.Forms.TextBox()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.txttotseat = New System.Windows.Forms.TextBox()
        Me.txtbagallowed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdsubmit = New System.Windows.Forms.Button()
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CMDSAVE = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 125)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(775, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INTERNATIONAL AIR TRANSPORT ASSOCIATION"
        '
        'CMDADD
        '
        Me.CMDADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CMDADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDADD.ForeColor = System.Drawing.Color.Black
        Me.CMDADD.Location = New System.Drawing.Point(47, 370)
        Me.CMDADD.Name = "CMDADD"
        Me.CMDADD.Size = New System.Drawing.Size(80, 27)
        Me.CMDADD.TabIndex = 11
        Me.CMDADD.Text = "ADD "
        Me.CMDADD.UseVisualStyleBackColor = False
        '
        'CMDUPDATE
        '
        Me.CMDUPDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CMDUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDUPDATE.ForeColor = System.Drawing.Color.Black
        Me.CMDUPDATE.Location = New System.Drawing.Point(128, 370)
        Me.CMDUPDATE.Name = "CMDUPDATE"
        Me.CMDUPDATE.Size = New System.Drawing.Size(90, 27)
        Me.CMDUPDATE.TabIndex = 12
        Me.CMDUPDATE.Text = "UPDATE"
        Me.CMDUPDATE.UseVisualStyleBackColor = False
        '
        'CMDDELETE
        '
        Me.CMDDELETE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CMDDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDELETE.ForeColor = System.Drawing.Color.Black
        Me.CMDDELETE.Location = New System.Drawing.Point(366, 13)
        Me.CMDDELETE.Name = "CMDDELETE"
        Me.CMDDELETE.Size = New System.Drawing.Size(97, 27)
        Me.CMDDELETE.TabIndex = 14
        Me.CMDDELETE.Text = "DELETE"
        Me.CMDDELETE.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CMDEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEXIT.Location = New System.Drawing.Point(381, 370)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(73, 27)
        Me.CMDEXIT.TabIndex = 15
        Me.CMDEXIT.Text = "EXIT "
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(95, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Airline ID     :"
        '
        'txtid
        '
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Location = New System.Drawing.Point(168, 127)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(92, 20)
        Me.txtid.TabIndex = 1
        '
        'txtairlinename
        '
        Me.txtairlinename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtairlinename.Location = New System.Drawing.Point(168, 171)
        Me.txtairlinename.Name = "txtairlinename"
        Me.txtairlinename.Size = New System.Drawing.Size(211, 20)
        Me.txtairlinename.TabIndex = 4
        '
        'txtcountry
        '
        Me.txtcountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcountry.Location = New System.Drawing.Point(168, 197)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(100, 20)
        Me.txtcountry.TabIndex = 5
        '
        'txtowner
        '
        Me.txtowner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtowner.Location = New System.Drawing.Point(168, 223)
        Me.txtowner.Name = "txtowner"
        Me.txtowner.Size = New System.Drawing.Size(100, 20)
        Me.txtowner.TabIndex = 6
        '
        'txtbase
        '
        Me.txtbase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbase.Location = New System.Drawing.Point(168, 249)
        Me.txtbase.Name = "txtbase"
        Me.txtbase.Size = New System.Drawing.Size(165, 20)
        Me.txtbase.TabIndex = 7
        '
        'txttype
        '
        Me.txttype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttype.Location = New System.Drawing.Point(168, 275)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(133, 20)
        Me.txttype.TabIndex = 8
        '
        'txttotseat
        '
        Me.txttotseat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotseat.Location = New System.Drawing.Point(168, 301)
        Me.txttotseat.Name = "txttotseat"
        Me.txttotseat.Size = New System.Drawing.Size(110, 20)
        Me.txttotseat.TabIndex = 9
        '
        'txtbagallowed
        '
        Me.txtbagallowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbagallowed.Location = New System.Drawing.Point(168, 327)
        Me.txtbagallowed.Name = "txtbagallowed"
        Me.txtbagallowed.Size = New System.Drawing.Size(110, 20)
        Me.txtbagallowed.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(78, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Airline Name     :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(101, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Country     :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(105, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Owner     :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(111, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Base     :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(111, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Type     :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(87, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total Seat     :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(78, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Bag Allowed     :"
        '
        'cmdsubmit
        '
        Me.cmdsubmit.BackColor = System.Drawing.Color.White
        Me.cmdsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsubmit.ForeColor = System.Drawing.Color.Black
        Me.cmdsubmit.Location = New System.Drawing.Point(266, 125)
        Me.cmdsubmit.Name = "cmdsubmit"
        Me.cmdsubmit.Size = New System.Drawing.Size(70, 23)
        Me.cmdsubmit.TabIndex = 2
        Me.cmdsubmit.Text = "Submit"
        Me.cmdsubmit.UseVisualStyleBackColor = False
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.Color.White
        Me.cmdcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.ForeColor = System.Drawing.Color.Black
        Me.cmdcancel.Location = New System.Drawing.Point(342, 125)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(68, 23)
        Me.cmdcancel.TabIndex = 3
        Me.cmdcancel.Text = "Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CMDDELETE)
        Me.Panel2.Location = New System.Drawing.Point(-76, 357)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(937, 51)
        Me.Panel2.TabIndex = 22
        '
        'CMDSAVE
        '
        Me.CMDSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CMDSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSAVE.ForeColor = System.Drawing.Color.Black
        Me.CMDSAVE.Location = New System.Drawing.Point(219, 370)
        Me.CMDSAVE.Name = "CMDSAVE"
        Me.CMDSAVE.Size = New System.Drawing.Size(75, 27)
        Me.CMDSAVE.TabIndex = 13
        Me.CMDSAVE.Text = "SAVE"
        Me.CMDSAVE.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(833, 424)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdsubmit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbagallowed)
        Me.Controls.Add(Me.txttotseat)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtbase)
        Me.Controls.Add(Me.txtowner)
        Me.Controls.Add(Me.txtcountry)
        Me.Controls.Add(Me.txtairlinename)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMDEXIT)
        Me.Controls.Add(Me.CMDSAVE)
        Me.Controls.Add(Me.CMDUPDATE)
        Me.Controls.Add(Me.CMDADD)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMDADD As System.Windows.Forms.Button
    Friend WithEvents CMDUPDATE As System.Windows.Forms.Button
    Friend WithEvents CMDDELETE As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtairlinename As System.Windows.Forms.TextBox
    Friend WithEvents txtcountry As System.Windows.Forms.TextBox
    Friend WithEvents txtowner As System.Windows.Forms.TextBox
    Friend WithEvents txtbase As System.Windows.Forms.TextBox
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents txttotseat As System.Windows.Forms.TextBox
    Friend WithEvents txtbagallowed As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdsubmit As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CMDSAVE As System.Windows.Forms.Button
End Class
