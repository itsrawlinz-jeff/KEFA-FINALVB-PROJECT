<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CMDDISPLAY = New System.Windows.Forms.Button
        Me.CMDADD = New System.Windows.Forms.Button
        Me.CMBDESTINATION = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXTFLTNO = New System.Windows.Forms.TextBox
        Me.TXTJDATE = New System.Windows.Forms.TextBox
        Me.CMDBOOK = New System.Windows.Forms.Button
        Me.CMDEXIT = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1000, 534)
        Me.DataGridView1.TabIndex = 1
        '
        'CMDDISPLAY
        '
        Me.CMDDISPLAY.Location = New System.Drawing.Point(280, 24)
        Me.CMDDISPLAY.Name = "CMDDISPLAY"
        Me.CMDDISPLAY.Size = New System.Drawing.Size(75, 23)
        Me.CMDDISPLAY.TabIndex = 3
        Me.CMDDISPLAY.Text = "DISPLAY"
        Me.CMDDISPLAY.UseVisualStyleBackColor = True
        '
        'CMDADD
        '
        Me.CMDADD.Location = New System.Drawing.Point(361, 24)
        Me.CMDADD.Name = "CMDADD"
        Me.CMDADD.Size = New System.Drawing.Size(115, 23)
        Me.CMDADD.TabIndex = 6
        Me.CMDADD.Text = "ADD FLIGHT"
        Me.CMDADD.UseVisualStyleBackColor = True
        '
        'CMBDESTINATION
        '
        Me.CMBDESTINATION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBDESTINATION.FormattingEnabled = True
        Me.CMBDESTINATION.Location = New System.Drawing.Point(122, 24)
        Me.CMBDESTINATION.Name = "CMBDESTINATION"
        Me.CMBDESTINATION.Size = New System.Drawing.Size(121, 21)
        Me.CMBDESTINATION.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DESTINATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 623)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "FLIGHT NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 660)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "JOURNEY DATE"
        '
        'TXTFLTNO
        '
        Me.TXTFLTNO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTFLTNO.ForeColor = System.Drawing.Color.Navy
        Me.TXTFLTNO.Location = New System.Drawing.Point(122, 620)
        Me.TXTFLTNO.Name = "TXTFLTNO"
        Me.TXTFLTNO.Size = New System.Drawing.Size(100, 20)
        Me.TXTFLTNO.TabIndex = 11
        '
        'TXTJDATE
        '
        Me.TXTJDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTJDATE.ForeColor = System.Drawing.Color.Navy
        Me.TXTJDATE.Location = New System.Drawing.Point(122, 657)
        Me.TXTJDATE.Name = "TXTJDATE"
        Me.TXTJDATE.Size = New System.Drawing.Size(100, 20)
        Me.TXTJDATE.TabIndex = 12
        '
        'CMDBOOK
        '
        Me.CMDBOOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMDBOOK.Font = New System.Drawing.Font("Poor Richard", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDBOOK.Location = New System.Drawing.Point(666, 642)
        Me.CMDBOOK.Name = "CMDBOOK"
        Me.CMDBOOK.Size = New System.Drawing.Size(234, 31)
        Me.CMDBOOK.TabIndex = 13
        Me.CMDBOOK.Text = "CLICK HERE TO BOOK TICKET"
        Me.CMDBOOK.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMDEXIT.Font = New System.Drawing.Font("Poor Richard", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.Location = New System.Drawing.Point(906, 642)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(110, 31)
        Me.CMDEXIT.TabIndex = 14
        Me.CMDEXIT.Text = "EXIT"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.CMDEXIT)
        Me.Controls.Add(Me.CMDBOOK)
        Me.Controls.Add(Me.TXTJDATE)
        Me.Controls.Add(Me.TXTFLTNO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMBDESTINATION)
        Me.Controls.Add(Me.CMDADD)
        Me.Controls.Add(Me.CMDDISPLAY)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CMDDISPLAY As System.Windows.Forms.Button
    Friend WithEvents CMDADD As System.Windows.Forms.Button
    Friend WithEvents CMBDESTINATION As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTFLTNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTJDATE As System.Windows.Forms.TextBox
    Friend WithEvents CMDBOOK As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
End Class
