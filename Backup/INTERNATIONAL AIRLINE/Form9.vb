Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form9

    Private Sub cmdsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubmit.Click
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            'create a data adapter
            Dim sql As String = "Select * from airlines_ticket where pnr=" & Me.txtpnr.Text & ""
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, myConnection)

            ' create a new dataset
            Dim ds As DataSet = New DataSet
            'Fill dataset
            da.Fill(ds, "airlines_ticket")
            DataGridView1.DataSource = ds.Tables("airlines_ticket")
            Me.txtflightno.Text = Me.DataGridView1.CurrentRow.Cells(5).Value

        Catch ex As Exception

        End Try


    End Sub

    Private Sub CMDCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCEL.Click
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            'create a data adapter
            Dim sql As String = "update airlines_ticket set status='CANCELLED',CANCEL_DATE=FORMAT(NOW,'dd-MMM-yyyy')where pnr=" & Me.txtpnr.Text & ""
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, myConnection)

            ' create a new dataset
            Dim ds As DataSet = New DataSet
            'Fill dataset
            da.Fill(ds, "airlines_ticket")
            DataGridView1.DataSource = ds.Tables("airlines_ticket")
        Catch ex As Exception

        End Try

        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            'create a data adapter
            Dim sql1 As String = "update airlines_payment set status='CANCELLED' where pnr=" & Me.txtpnr.Text & ""
            Dim da1 As OleDbDataAdapter = New OleDbDataAdapter(sql1, myConnection)

            ' create a new dataset
            Dim ds As DataSet = New DataSet
            'Fill dataset
            da1.Fill(ds, "airlines_payment")
            DataGridView1.DataSource = ds.Tables("airlines_payment")
        Catch ex As Exception

        End Try

        Try
            If Me.txtflightno.Text = "SV9" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=REMAIN_SEAT + 1 WHERE FLIGHT_NO='" & Me.txtflightno.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.txtflightno.Text = "AI111" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=REMAIN_SEAT + 1 WHERE FLIGHT_NO='" & Me.txtflightno.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.txtflightno.Text = "SQ26" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=REMAIN_SEAT + 1 WHERE FLIGHT_NO='" & Me.txtflightno.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.txtflightno.Text = "KE81" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=REMAIN_SEAT + 1 WHERE FLIGHT_NO='" & Me.txtflightno.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If
        Catch ex As Exception

        End Try

        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            'create a data adapter
            Dim sql As String = "select * from airlines_ticket where flight_no='" & Me.txtflightno.Text & "'"
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, myConnection)

            ' create a new dataset
            Dim ds As DataSet = New DataSet
            'Fill dataset
            da.Fill(ds, "airlines_ticket")
            DataGridView1.DataSource = ds.Tables("airlines_ticket")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ticket Cancellation"
        Me.txtflightno.Visible = False
    End Sub

    Private Sub CMDREFUND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREFUND.Click
        Dim ss As New Form10
        ss.Show()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Dim xx As New Form1
        Me.Hide()
        xx.Show()
    End Sub
End Class