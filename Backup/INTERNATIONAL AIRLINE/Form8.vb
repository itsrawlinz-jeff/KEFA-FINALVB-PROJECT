Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ticket Status"
        Me.ComboBox1.Items.Add("RESERVED TICKET LIST")
        Me.ComboBox1.Items.Add("CANCELLED TICKET LIST")
        Me.ComboBox1.Items.Add("LIST OF PAYMENT DETAILS")
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        Try
            If Me.ComboBox1.Text = "RESERVED TICKET LIST" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_ticket where status='CONFIRMED'", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_ticket")
                DataGridView1.DataSource = ds.Tables("airlines_ticket")
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.ComboBox1.Text = "CANCELLED TICKET LIST" Then
                Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB.NET PROJECTS\airlines.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_ticket where status='CANCELLED'", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_ticket")
                DataGridView1.DataSource = ds.Tables("airlines_ticket")
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.ComboBox1.Text = "LIST OF PAYMENT DETAILS" Then
                Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB.NET PROJECTS\airlines.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_payment", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_payment")
                DataGridView1.DataSource = ds.Tables("airlines_payment")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If Me.ComboBox1.Text = "RESERVED TICKET LIST" Then
                Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB.NET PROJECTS\airlines.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_ticket where status='CONFIRMED'", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_ticket")
                DataGridView1.DataSource = ds.Tables("airlines_ticket")
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.ComboBox1.Text = "CANCELLED TICKET LIST" Then
                Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB.NET PROJECTS\airlines.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_ticket where status='CANCELLED'", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_ticket")
                DataGridView1.DataSource = ds.Tables("airlines_ticket")
            End If
        Catch ex As Exception

        End Try

        Try
            If Me.ComboBox1.Text = "LIST OF PAYMENT DETAILS" Then
                Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB.NET PROJECTS\airlines.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_payment", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_payment")
                DataGridView1.DataSource = ds.Tables("airlines_payment")
            End If
            
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Dim s As New Form1
        Me.Hide()
        s.Show()
    End Sub
End Class