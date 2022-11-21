Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "TICKET RESERVATION SYSTEM"
        Me.txtbdate.Text = Format(Now, "dd-MMM-yyyy")
        TextBox1.Text = "CONFIRMED"
        TextBox2.Text = "N/A"
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
    End Sub

    Private Sub CMDBOOKING_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBOOKING.Click


        Dim XX As New Form7
        XX.TextBox5.Text = Me.txtpnr.Text
        XX.TextBox6.Text = Me.txtpname.Text
        XX.TextBox7.Text = Me.txtpaddress.Text
        XX.TextBox8.Text = Me.txtdob.Text
        XX.TextBox9.Text = Me.txtphoneno.Text
        XX.TextBox10.Text = Me.txtflightno.Text
        XX.TextBox11.Text = Me.txtdestination.Text
        XX.TextBox12.Text = Me.txtjdate.Text
        XX.TextBox13.Text = Me.txtfare.Text
        XX.TextBox14.Text = Me.txtbdate.Text
        XX.TextBox15.Text = Me.txtseatno.Text
        XX.TextBox16.Text = Me.txtdeparture.Text
        XX.TextBox17.Text = Me.TextBox1.Text
        XX.TextBox18.Text = Me.TextBox2.Text
        XX.TextBox23.Text = Me.TextBox3.Text
        XX.TextBox24.Text = Me.TextBox4.Text
        XX.Show()

    End Sub

End Class