Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form5

    Private Sub CMDINSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDINSERT.Click
        Try
            If Me.TXTDESTINATION.Text = "NEWYORK" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim dsinvoice As New DataSet
                Dim dainvoice As New OleDbDataAdapter
                Dim sql As String = "insert into AIRLINES_NEWYORK(FLIGHT_NAME,FLIGHT_NO,ORIGIN,DESTINATION,JOURNEY_DATE,TOTAL_SEAT,REMAIN_SEAT) values('" & TXTFLIGHTNAME.Text & "','" & TXTFLIGHTNO.Text & "','" & TXTORIGIN.Text & "','" & TXTDESTINATION.Text & "','" & TXTJDATE.Text & "'," & TXTTOTSEAT.Text & "," & TXTREMSEAT.Text & ")"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()

            End If
        Catch ex As Exception

        End Try


        Try
            If Me.TXTDESTINATION.Text = "LONDON" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim dsinvoice As New DataSet
                Dim dainvoice As New OleDbDataAdapter
                Dim sql As String = "insert into AIRLINES_LONDON(FLIGHT_NAME,FLIGHT_NO,ORIGIN,DESTINATION,JOURNEY_DATE,TOTAL_SEAT,REMAIN_SEAT) values('" & TXTFLIGHTNAME.Text & "','" & TXTFLIGHTNO.Text & "','" & TXTORIGIN.Text & "','" & TXTDESTINATION.Text & "','" & TXTJDATE.Text & "'," & TXTTOTSEAT.Text & "," & TXTREMSEAT.Text & ")"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If
        Catch ex As Exception

        End Try


        Try
            If Me.TXTDESTINATION.Text = "LOSANGELES" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim dsinvoice As New DataSet
                Dim dainvoice As New OleDbDataAdapter
                Dim sql As String = "insert into AIRLINES_LOSANGELES(FLIGHT_NAME,FLIGHT_NO,ORIGIN,DESTINATION,JOURNEY_DATE,TOTAL_SEAT,REMAIN_SEAT) values('" & TXTFLIGHTNAME.Text & "','" & TXTFLIGHTNO.Text & "','" & TXTORIGIN.Text & "','" & TXTDESTINATION.Text & "','" & TXTJDATE.Text & "'," & TXTTOTSEAT.Text & "," & TXTREMSEAT.Text & ")"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.TXTDESTINATION.Text = "SANFRANSISCO" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim dsinvoice As New DataSet
                Dim dainvoice As New OleDbDataAdapter
                Dim sql As String = "insert into AIRLINES_SANFRANSISCO(FLIGHT_NAME,FLIGHT_NO,ORIGIN,DESTINATION,JOURNEY_DATE,TOTAL_SEAT,REMAIN_SEAT) values('" & TXTFLIGHTNAME.Text & "','" & TXTFLIGHTNO.Text & "','" & TXTORIGIN.Text & "','" & TXTDESTINATION.Text & "','" & TXTJDATE.Text & "'," & TXTTOTSEAT.Text & "," & TXTREMSEAT.Text & ")"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.TXTDESTINATION.Text = "TOKYO" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString
                Dim dsinvoice As New DataSet
                Dim dainvoice As New OleDbDataAdapter
                Dim sql As String = "insert into AIRLINES_TOKYO(FLIGHT_NAME,FLIGHT_NO,ORIGIN,DESTINATION,JOURNEY_DATE,TOTAL_SEAT,REMAIN_SEAT) values('" & TXTFLIGHTNAME.Text & "','" & TXTFLIGHTNO.Text & "','" & TXTORIGIN.Text & "','" & TXTDESTINATION.Text & "','" & TXTJDATE.Text & "'," & TXTTOTSEAT.Text & "," & TXTREMSEAT.Text & ")"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "ADD NEW AIRCRAFT SCHEDULE"
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Dim S As New Form4
        S.Show()
        Me.Hide()
    End Sub
End Class