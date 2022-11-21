Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Runtime.InteropServices

Public Class Form11
    Dim userflag As Boolean
    Dim passflag As Boolean

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Try

            Me.Text = "SECURITY CHECK"
            Me.Label1.Text = "INTERNATIONAL AIR TRANSPORT ASSOCIATION"
            Me.Label2.Text = "WELCOME TO IATA,TORONTO,CANADA"
            Me.Label3.Text = "Only Authorised users allowed to login"
            Me.Label4.Text = "if you forgot the password please contact the system administrator immediately"
            Me.Label8.Text = Format(Now, "dd-MMM-yyyy")
            Me.Label10.Text = Format(Now, "hh:mm:ss")

            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            Dim sql As String
            sql = "select * from LOGIN"

            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader()

            While dbread.read
                Me.ComboBox1.Items.Add(dbread.getstring(0))
            End While

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            Dim sql As String
            sql = "select * from LOGIN"

            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader()
            userflag = False
            passflag = False

            While dbread.READ
                If Me.ComboBox1.Text = dbread.GETSTRING(0) And Me.txtpass.Text = dbread.GETSTRING(1) Then
                    userflag = True
                    passflag = True
                    Dim xx As New Form1
                    Me.Hide()
                    xx.Show()
                Else
                    
                End If
            End While

        Catch ex As Exception
            
        End Try
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.txtpass.Focus()
    End Sub
End Class