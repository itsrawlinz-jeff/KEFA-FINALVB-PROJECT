<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.txtpnr = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdsubmit = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CMDCANCEL = New System.Windows.Forms.Button
        Me.txtflightno = New System.Windows.Forms.TextBox
        Me.CMDREFUND = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpnr
        '
        Me.txtpnr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpnr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpnr.Location = New System.Drawing.Point(194, 86)
        Me.txtpnr.Name = "txtpnr"
        Me.txtpnr.Size = New System.Drawing.Size(97, 22)
        Me.txtpnr.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter PNR Number :"
        '
        'cmdsubmit
        '
        Me.cmdsubmit.BackColor = System.Drawing.Color.Cyan
        Me.cmdsubmit.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdsubmit.Location = New System.Drawing.Point(317, 80)
        Me.cmdsubmit.Name = "cmdsubmit"
        Me.cmdsubmit.Size = New System.Drawing.Size(151, 31)
        Me.cmdsubmit.TabIndex = 2
        Me.cmdsubmit.Text = "Submit"
        Me.cmdsubmit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(62, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(916, 559)
        Me.DataGridView1.TabIndex = 3
        '
        'CMDCANCEL
        '
        Me.CMDCANCEL.BackColor = System.Drawing.Color.Cyan
        Me.CMDCANCEL.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCANCEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDCANCEL.Location = New System.Drawing.Point(474, 80)
        Me.CMDCANCEL.Name = "CMDCANCEL"
        Me.CMDCANCEL.Size = New System.Drawing.Size(157, 31)
        Me.CMDCANCEL.TabIndex = 4
        Me.CMDCANCEL.Text = "Cancel Ticket"
        Me.CMDCANCEL.UseVisualStyleBackColor = False
        '
        'txtflightno
        '
        Me.txtflightno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtflightno.Location = New System.Drawing.Point(168, 12)
        Me.txtflightno.Name = "txtflightno"
        Me.txtflightno.Size = New System.Drawing.Size(100, 20)
        Me.txtflightno.TabIndex = 5
        '
        'CMDREFUND
        '
        Me.CMDREFUND.BackColor = System.Drawing.Color.Cyan
        Me.CMDREFUND.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFUND.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMDREFUND.Location = New System.Drawing.Point(637, 80)
        Me.CMDREFUND.Name = "CMDREFUND"
        Me.CMDREFUND.Size = New System.Drawing.Size(174, 31)
        Me.CMDREFUND.TabIndex = 6
        Me.CMDREFUND.Text = "Refund Ticket"
        Me.CMDREFUND.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Cyan
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdexit.Location = New System.Drawing.Point(817, 80)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(161, 31)
        Me.cmdexit.TabIndex = 7
        Me.cmdexit.Text = "Exit"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CMDREFUND)
        Me.Controls.Add(Me.txtflightno)
        Me.Controls.Add(Me.CMDCANCEL)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdsubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpnr)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpnr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdsubmit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CMDCANCEL As System.Windows.Forms.Button
    Friend WithEvents txtflightno As System.Windows.Forms.TextBox
    Friend WithEvents CMDREFUND As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
End Class
