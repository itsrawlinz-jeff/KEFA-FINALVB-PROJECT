Public Class Form1

    Private Sub CMDQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDQUIT.Click
        Dim PP As New Form11
        Me.Hide()
        PP.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "INTERNATIONAL AIRLINES"
        Me.Label4.Text = Format(Now, "dd-MMM-yyyy")
    End Sub

    Private Sub CMDENQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDENQ.Click
        Dim SS As New Form2
        SS.Show()
        'Me.Hide()
    End Sub

    Private Sub CMDTICRESERV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDTICRESERV.Click
        Dim PP As New Form4
        PP.Show()
    End Sub

    Private Sub CMDSCHDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSCHDL.Click
        Dim aa As New Form3
        aa.Show()
        Me.Hide()
    End Sub

    Private Sub CMDTICSTAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDTICSTAT.Click
        Dim PP As New Form8
        PP.Show()
        Me.Hide()
    End Sub

    Private Sub CMDTICCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDTICCANCEL.Click
        Dim jj As New Form9
        jj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
