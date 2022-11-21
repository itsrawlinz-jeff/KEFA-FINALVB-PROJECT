Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "General Enquiry"
        Me.txtid.Focus()
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Dim JJ As New Form1
        JJ.Show()
        Me.Hide()
    End Sub

    Private Sub CMDADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADD.Click
        Me.txtid.Enabled = False
        Me.txtairlinename.Text = ""
        Me.txtcountry.Text = ""
        Me.txtowner.Text = ""
        Me.txtbase.Text = ""
        Me.txttype.Text = ""
        Me.txttotseat.Text = ""
        Me.txtbagallowed.Text = ""
        Me.txtairlinename.Focus()
    End Sub

    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress





    End Sub

    Private Sub cmdsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubmit.Click
      

    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        If Me.txtid.Text = "" Then
            Me.txtairlinename.Text = ""
            Me.txtcountry.Text = ""
            Me.txtowner.Text = ""
            Me.txtbase.Text = ""
            Me.txttype.Text = ""
            Me.txttotseat.Text = ""
            Me.txtbagallowed.Text = ""
        End If
    End Sub
    Private Sub CMDSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSAVE.Click
      
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.txtid.Enabled = True
        Me.txtid.Text = ""
        Me.txtairlinename.Text = ""
        Me.txtcountry.Text = ""
        Me.txtowner.Text = ""
        Me.txtbase.Text = ""
        Me.txttype.Text = ""
        Me.txttotseat.Text = ""
        Me.txtbagallowed.Text = ""
        Me.txtid.Focus()
    End Sub

    Private Sub CMDUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUPDATE.Click
      
    End Sub

    Private Sub CMDDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click
       

    End Sub

End Class