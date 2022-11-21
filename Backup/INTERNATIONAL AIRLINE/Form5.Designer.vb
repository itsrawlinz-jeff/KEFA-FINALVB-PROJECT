<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.TXTFLIGHTNAME = New System.Windows.Forms.TextBox
        Me.TXTFLIGHTNO = New System.Windows.Forms.TextBox
        Me.TXTJDATE = New System.Windows.Forms.TextBox
        Me.TXTTOTSEAT = New System.Windows.Forms.TextBox
        Me.TXTREMSEAT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXTORIGIN = New System.Windows.Forms.TextBox
        Me.TXTDESTINATION = New System.Windows.Forms.TextBox
        Me.CMDINSERT = New System.Windows.Forms.Button
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTFLIGHTNAME
        '
        Me.TXTFLIGHTNAME.Location = New System.Drawing.Point(174, 86)
        Me.TXTFLIGHTNAME.Name = "TXTFLIGHTNAME"
        Me.TXTFLIGHTNAME.Size = New System.Drawing.Size(182, 20)
        Me.TXTFLIGHTNAME.TabIndex = 0
        '
        'TXTFLIGHTNO
        '
        Me.TXTFLIGHTNO.Location = New System.Drawing.Point(174, 112)
        Me.TXTFLIGHTNO.Name = "TXTFLIGHTNO"
        Me.TXTFLIGHTNO.Size = New System.Drawing.Size(100, 20)
        Me.TXTFLIGHTNO.TabIndex = 1
        '
        'TXTJDATE
        '
        Me.TXTJDATE.Location = New System.Drawing.Point(174, 190)
        Me.TXTJDATE.Name = "TXTJDATE"
        Me.TXTJDATE.Size = New System.Drawing.Size(100, 20)
        Me.TXTJDATE.TabIndex = 4
        '
        'TXTTOTSEAT
        '
        Me.TXTTOTSEAT.Location = New System.Drawing.Point(174, 216)
        Me.TXTTOTSEAT.Name = "TXTTOTSEAT"
        Me.TXTTOTSEAT.Size = New System.Drawing.Size(100, 20)
        Me.TXTTOTSEAT.TabIndex = 5
        '
        'TXTREMSEAT
        '
        Me.TXTREMSEAT.Location = New System.Drawing.Point(174, 242)
        Me.TXTREMSEAT.Name = "TXTREMSEAT"
        Me.TXTREMSEAT.Size = New System.Drawing.Size(100, 20)
        Me.TXTREMSEAT.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(54, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "AIRLINE NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(54, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "FLIGHT NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(54, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ORIGIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(54, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DESTINATION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(53, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "JOURNEY DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(54, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "TOTAL SEAT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(57, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "REMAIN SEAT"
        '
        'TXTORIGIN
        '
        Me.TXTORIGIN.Location = New System.Drawing.Point(174, 138)
        Me.TXTORIGIN.Name = "TXTORIGIN"
        Me.TXTORIGIN.Size = New System.Drawing.Size(130, 20)
        Me.TXTORIGIN.TabIndex = 19
        '
        'TXTDESTINATION
        '
        Me.TXTDESTINATION.Location = New System.Drawing.Point(174, 164)
        Me.TXTDESTINATION.Name = "TXTDESTINATION"
        Me.TXTDESTINATION.Size = New System.Drawing.Size(154, 20)
        Me.TXTDESTINATION.TabIndex = 20
        '
        'CMDINSERT
        '
        Me.CMDINSERT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDINSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDINSERT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMDINSERT.Location = New System.Drawing.Point(102, 286)
        Me.CMDINSERT.Name = "CMDINSERT"
        Me.CMDINSERT.Size = New System.Drawing.Size(193, 30)
        Me.CMDINSERT.TabIndex = 21
        Me.CMDINSERT.Text = "INSERT NEW AIRLINE"
        Me.CMDINSERT.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMDEXIT.Location = New System.Drawing.Point(301, 286)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(94, 30)
        Me.CMDEXIT.TabIndex = 22
        Me.CMDEXIT.Text = "EXIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 56)
        Me.Panel1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(127, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(268, 22)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "INTERNATIONAL AIRLINES"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(499, 345)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CMDEXIT)
        Me.Controls.Add(Me.CMDINSERT)
        Me.Controls.Add(Me.TXTDESTINATION)
        Me.Controls.Add(Me.TXTORIGIN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTREMSEAT)
        Me.Controls.Add(Me.TXTTOTSEAT)
        Me.Controls.Add(Me.TXTJDATE)
        Me.Controls.Add(Me.TXTFLIGHTNO)
        Me.Controls.Add(Me.TXTFLIGHTNAME)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTFLIGHTNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXTFLIGHTNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTJDATE As System.Windows.Forms.TextBox
    Friend WithEvents TXTTOTSEAT As System.Windows.Forms.TextBox
    Friend WithEvents TXTREMSEAT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTORIGIN As System.Windows.Forms.TextBox
    Friend WithEvents TXTDESTINATION As System.Windows.Forms.TextBox
    Friend WithEvents CMDINSERT As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
