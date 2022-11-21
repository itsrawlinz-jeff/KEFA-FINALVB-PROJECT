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
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                Dim sql As String
                sql = "select * from airlines_genenq where owned_by='" & txtid.Text & "'"

                myConnection.Open()
                Dim com As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader
                If Not dbread.read Then
                    MsgBox("Sorry ! No Records Found")
                    txtid.Text = ""
                    txtid.Focus()
                Else
                    txtairlinename.Text = dbread.getstring(0)
                    txtcountry.Text = dbread.getString(1)
                    txtowner.Text = dbread.getstring(2)
                    txtbase.Text = dbread.getstring(3)
                    txttype.Text = dbread.getstring(4)
                    txttotseat.Text = dbread.getvalue(5)
                    txtbagallowed.Text = dbread.getstring(6)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubmit.Click
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            Dim sql As String
            sql = "select * from airlines_genenq where owned_by='" & txtid.Text & "'"

            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader
            If Not dbread.read Then
                MsgBox("Sorry ! No Records Found")
                txtid.Text = ""
                txtid.Focus()
            Else
                txtairlinename.Text = dbread.getstring(0)
                txtcountry.Text = dbread.getString(1)
                txtowner.Text = dbread.getstring(2)
                txtbase.Text = dbread.getstring(3)
                txttype.Text = dbread.getstring(4)
                txttotseat.Text = dbread.getvalue(5)
                txtbagallowed.Text = dbread.getstring(6)
            End If

        Catch ex As Exception

        End Try

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
        Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        Dim dsinvoice As New DataSet
        Dim dainvoice As New OleDbDataAdapter
        Dim sql As String = "insert into airlines_genenq(airline_name,country,owned_by,base,type,total_seat,bag_allowed) values('" & txtairlinename.Text & "','" & txtcountry.Text & "','" & txtowner.Text & "','" & txtbase.Text & "','" & txttype.Text & "'," & txttotseat.Text & ",'" & txtbagallowed.Text & "')"
        myConnection.Open()
        Dim com As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        dbread = com.ExecuteReader()
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
        Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        Dim dsinvoice As New DataSet
        Dim dainvoice As New OleDbDataAdapter
        Dim sql As String = "update airlines_genenq set airline_name='" & txtairlinename.Text & "',country='" & txtcountry.Text & "',owned_by='" & txtowner.Text & "',base='" & txtbase.Text & "',type='" & txttype.Text & "',total_seat=" & txttotseat.Text & ",bag_allowed='" & txtbagallowed.Text & "' where owned_by='" & txtid.Text & "'"
        myConnection.Open()
        Dim com As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        dbread = com.ExecuteReader()

    End Sub

    Private Sub CMDDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click
        Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        Dim dsinvoice As New DataSet
        Dim dainvoice As New OleDbDataAdapter
        Dim sql As String = "delete from airlines_genenq where owned_by='" & txtid.Text & "'"
        myConnection.Open()
        Dim com As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        dbread = com.ExecuteReader()

    End Sub

End Class