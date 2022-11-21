<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.TXTAIRLINE = New System.Windows.Forms.TextBox()
        Me.TXTFLTNO = New System.Windows.Forms.TextBox()
        Me.TXTDEPARTURE = New System.Windows.Forms.TextBox()
        Me.TXTARRIVAL = New System.Windows.Forms.TextBox()
        Me.TXTSTOP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.CMDSAVE = New System.Windows.Forms.Button()
        Me.CMDDELETE = New System.Windows.Forms.Button()
        Me.CMDUPDATE = New System.Windows.Forms.Button()
        Me.CMDINSERT = New System.Windows.Forms.Button()
        Me.CMBORIGIN = New System.Windows.Forms.ComboBox()
        Me.CMBDESTINATION = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CMDENTER = New System.Windows.Forms.Button()
        Me.txtflightno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CMDSUBMIT = New System.Windows.Forms.Button()
        Me.CMDCANCEL = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTAIRLINE
        '
        Me.TXTAIRLINE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTAIRLINE.Location = New System.Drawing.Point(206, 164)
        Me.TXTAIRLINE.Name = "TXTAIRLINE"
        Me.TXTAIRLINE.Size = New System.Drawing.Size(168, 20)
        Me.TXTAIRLINE.TabIndex = 1
        '
        'TXTFLTNO
        '
        Me.TXTFLTNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTFLTNO.Location = New System.Drawing.Point(206, 190)
        Me.TXTFLTNO.Name = "TXTFLTNO"
        Me.TXTFLTNO.Size = New System.Drawing.Size(100, 20)
        Me.TXTFLTNO.TabIndex = 2
        '
        'TXTDEPARTURE
        '
        Me.TXTDEPARTURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTDEPARTURE.Location = New System.Drawing.Point(206, 268)
        Me.TXTDEPARTURE.Name = "TXTDEPARTURE"
        Me.TXTDEPARTURE.Size = New System.Drawing.Size(100, 20)
        Me.TXTDEPARTURE.TabIndex = 5
        '
        'TXTARRIVAL
        '
        Me.TXTARRIVAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTARRIVAL.Location = New System.Drawing.Point(206, 294)
        Me.TXTARRIVAL.Name = "TXTARRIVAL"
        Me.TXTARRIVAL.Size = New System.Drawing.Size(100, 20)
        Me.TXTARRIVAL.TabIndex = 6
        '
        'TXTSTOP
        '
        Me.TXTSTOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSTOP.Location = New System.Drawing.Point(206, 320)
        Me.TXTSTOP.Name = "TXTSTOP"
        Me.TXTSTOP.Size = New System.Drawing.Size(100, 20)
        Me.TXTSTOP.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "AIRLINE NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "FLIGHT NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "DEPARTURE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ORIGIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DESTINATION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ARRIVAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(131, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "STOPOVER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.CMDEXIT)
        Me.Panel1.Controls.Add(Me.CMDSAVE)
        Me.Panel1.Controls.Add(Me.CMDDELETE)
        Me.Panel1.Controls.Add(Me.CMDUPDATE)
        Me.Panel1.Controls.Add(Me.CMDINSERT)
        Me.Panel1.Location = New System.Drawing.Point(67, 359)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 46)
        Me.Panel1.TabIndex = 14
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Silver
        Me.CMDEXIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDEXIT.Location = New System.Drawing.Point(367, 8)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(83, 32)
        Me.CMDEXIT.TabIndex = 19
        Me.CMDEXIT.Text = "EXIT"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'CMDSAVE
        '
        Me.CMDSAVE.BackColor = System.Drawing.Color.Silver
        Me.CMDSAVE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDSAVE.Location = New System.Drawing.Point(286, 8)
        Me.CMDSAVE.Name = "CMDSAVE"
        Me.CMDSAVE.Size = New System.Drawing.Size(83, 32)
        Me.CMDSAVE.TabIndex = 18
        Me.CMDSAVE.Text = "SAVE"
        Me.CMDSAVE.UseVisualStyleBackColor = False
        '
        'CMDDELETE
        '
        Me.CMDDELETE.BackColor = System.Drawing.Color.Silver
        Me.CMDDELETE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDDELETE.Location = New System.Drawing.Point(205, 8)
        Me.CMDDELETE.Name = "CMDDELETE"
        Me.CMDDELETE.Size = New System.Drawing.Size(83, 32)
        Me.CMDDELETE.TabIndex = 17
        Me.CMDDELETE.Text = "DELETE"
        Me.CMDDELETE.UseVisualStyleBackColor = False
        '
        'CMDUPDATE
        '
        Me.CMDUPDATE.BackColor = System.Drawing.Color.Silver
        Me.CMDUPDATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDUPDATE.Location = New System.Drawing.Point(126, 8)
        Me.CMDUPDATE.Name = "CMDUPDATE"
        Me.CMDUPDATE.Size = New System.Drawing.Size(83, 32)
        Me.CMDUPDATE.TabIndex = 16
        Me.CMDUPDATE.Text = "UPDATE"
        Me.CMDUPDATE.UseVisualStyleBackColor = False
        '
        'CMDINSERT
        '
        Me.CMDINSERT.BackColor = System.Drawing.Color.Silver
        Me.CMDINSERT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDINSERT.Location = New System.Drawing.Point(45, 8)
        Me.CMDINSERT.Name = "CMDINSERT"
        Me.CMDINSERT.Size = New System.Drawing.Size(83, 32)
        Me.CMDINSERT.TabIndex = 15
        Me.CMDINSERT.Text = "INSERT"
        Me.CMDINSERT.UseVisualStyleBackColor = False
        '
        'CMBORIGIN
        '
        Me.CMBORIGIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBORIGIN.FormattingEnabled = True
        Me.CMBORIGIN.Location = New System.Drawing.Point(206, 216)
        Me.CMBORIGIN.Name = "CMBORIGIN"
        Me.CMBORIGIN.Size = New System.Drawing.Size(111, 21)
        Me.CMBORIGIN.TabIndex = 3
        '
        'CMBDESTINATION
        '
        Me.CMBDESTINATION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBDESTINATION.FormattingEnabled = True
        Me.CMBDESTINATION.Location = New System.Drawing.Point(206, 242)
        Me.CMBDESTINATION.Name = "CMBDESTINATION"
        Me.CMBDESTINATION.Size = New System.Drawing.Size(111, 21)
        Me.CMBDESTINATION.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Silver
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(416, 163)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(163, 147)
        Me.ListBox1.TabIndex = 22
        '
        'CMDENTER
        '
        Me.CMDENTER.BackColor = System.Drawing.Color.Gray
        Me.CMDENTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMDENTER.Location = New System.Drawing.Point(380, 162)
        Me.CMDENTER.Name = "CMDENTER"
        Me.CMDENTER.Size = New System.Drawing.Size(30, 22)
        Me.CMDENTER.TabIndex = 23
        Me.CMDENTER.Text = "..."
        Me.CMDENTER.UseVisualStyleBackColor = False
        '
        'txtflightno
        '
        Me.txtflightno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtflightno.Location = New System.Drawing.Point(206, 121)
        Me.txtflightno.Name = "txtflightno"
        Me.txtflightno.Size = New System.Drawing.Size(100, 20)
        Me.txtflightno.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(137, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "FLIGHT NO"
        '
        'CMDSUBMIT
        '
        Me.CMDSUBMIT.BackColor = System.Drawing.Color.Silver
        Me.CMDSUBMIT.Location = New System.Drawing.Point(321, 119)
        Me.CMDSUBMIT.Name = "CMDSUBMIT"
        Me.CMDSUBMIT.Size = New System.Drawing.Size(75, 23)
        Me.CMDSUBMIT.TabIndex = 26
        Me.CMDSUBMIT.Text = "SUBMIT"
        Me.CMDSUBMIT.UseVisualStyleBackColor = False
        '
        'CMDCANCEL
        '
        Me.CMDCANCEL.BackColor = System.Drawing.Color.Silver
        Me.CMDCANCEL.Location = New System.Drawing.Point(402, 119)
        Me.CMDCANCEL.Name = "CMDCANCEL"
        Me.CMDCANCEL.Size = New System.Drawing.Size(75, 23)
        Me.CMDCANCEL.TabIndex = 27
        Me.CMDCANCEL.Text = "CANCEL"
        Me.CMDCANCEL.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 106)
        Me.Panel2.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(557, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Time"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(557, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(63, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(473, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kepha International Air Transport Association"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(639, 433)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CMDCANCEL)
        Me.Controls.Add(Me.CMDSUBMIT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtflightno)
        Me.Controls.Add(Me.CMDENTER)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CMBDESTINATION)
        Me.Controls.Add(Me.CMBORIGIN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTSTOP)
        Me.Controls.Add(Me.TXTARRIVAL)
        Me.Controls.Add(Me.TXTDEPARTURE)
        Me.Controls.Add(Me.TXTFLTNO)
        Me.Controls.Add(Me.TXTAIRLINE)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTAIRLINE As System.Windows.Forms.TextBox
    Friend WithEvents TXTFLTNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTDEPARTURE As System.Windows.Forms.TextBox
    Friend WithEvents TXTARRIVAL As System.Windows.Forms.TextBox
    Friend WithEvents TXTSTOP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents CMDSAVE As System.Windows.Forms.Button
    Friend WithEvents CMDDELETE As System.Windows.Forms.Button
    Friend WithEvents CMDUPDATE As System.Windows.Forms.Button
    Friend WithEvents CMDINSERT As System.Windows.Forms.Button
    Friend WithEvents CMBORIGIN As System.Windows.Forms.ComboBox
    Friend WithEvents CMBDESTINATION As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents CMDENTER As System.Windows.Forms.Button
    Friend WithEvents txtflightno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CMDSUBMIT As System.Windows.Forms.Button
    Friend WithEvents CMDCANCEL As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
