Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form10

    Private Sub cmdsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubmit.Click
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            Dim sql As String
            sql = "select * from airlines_payment where pnr=" & TXTPNR.Text & ""
            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader
            If Not dbread.read Then
                MsgBox("Sorry ! No Records Found")
                TXTPNR.Text = ""
                TXTTICKETAMOUNT.Text = ""
                TXTREFUNDAMOUNT.Text = ""
            Else
                TXTTICKETAMOUNT.Text = dbread.getvalue(1)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdrefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefund.Click
        Try

            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            Dim sql As String
            sql = "select * from airlines_payment where pnr=" & TXTPNR.Text & ""
            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader
            If Not dbread.read Then
                MsgBox("Sorry ! No Records Found")
                TXTPNR.Text = ""
                TXTTICKETAMOUNT.Text = ""
                TXTREFUNDAMOUNT.Text = ""
            Else
                TXTTICKETAMOUNT.Text = dbread.getvalue(1)
            End If

        Catch ex As Exception

        End Try

        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            Dim sql As String
            Me.TXTREFUNDAMOUNT.Text = Me.TXTTICKETAMOUNT.Text - Me.TXTTICKETAMOUNT.Text * 0.1
            sql = "update airlines_payment set status='REFUNDED',REFUND_AMOUNT=" & Me.TXTREFUNDAMOUNT.Text & ",DEDUCT_AMOUNT=" & Me.TXTTICKETAMOUNT.Text * 0.1 & ",REFUND_DATE=format(now,'dd-MMM-yyyy') where pnr=" & TXTPNR.Text & ""
            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ticket Refund"
    End Sub
End Class