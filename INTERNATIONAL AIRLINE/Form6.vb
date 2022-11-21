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


        Form4.Show()
        Me.Hide()




    End Sub

End Class