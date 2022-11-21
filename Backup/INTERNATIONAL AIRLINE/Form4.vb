Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "INTERNATIONAL AIRLINES TICKET RESERVATION SYSTEM"
        Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString

        Dim sql As String
        'sql = "select * from airlines_genenq"
        sql = "SELECT * FROM AIRLINES_SCH"
        myConnection.Open()
        Dim com As New OleDbCommand
        'Dim COM1 As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        'COM1 = New OleDbCommand(SQL1, myConnection)

        'dbread = com.ExecuteReader()
        'While dbread.read
        'CMBIRLINE.Items.Add(dbread.getstring(0))
        'End While

        dbread = com.ExecuteReader
        While dbread.read
            'CMBORIGIN.Items.Add(dbread.getstring(2))
            CMBDESTINATION.Items.Add(dbread.getstring(3))
        End While

    End Sub

    Private Sub CMDADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADD.Click
        Dim SS As New Form5
        'SS.TXTFLIGHTNAME.Text = Me.CMBAIRLINE.Text
        'SS.TXTORIGIN.Text = Me.CMBORIGIN.Text
        SS.TXTDESTINATION.Text = Me.CMBDESTINATION.Text
        SS.Show()
    End Sub

    Private Sub CMDDISPLAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDISPLAY.Click

        Try
            If CMBDESTINATION.Text = "NEWYORK" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_newyork", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_newyork")
                DataGridView1.DataSource = ds.Tables("airlines_newyork")
            End If
            
        Catch ex As Exception

        End Try

        Try
            If CMBDESTINATION.Text = "LONDON" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_LONDON", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_LONDON")
                DataGridView1.DataSource = ds.Tables("airlines_LONDON")
            End If

        Catch ex As Exception

        End Try

        Try
            If CMBDESTINATION.Text = "LOSANGELES" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_LOSANGELES", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_LOSANGELES")
                DataGridView1.DataSource = ds.Tables("airlines_LOSANGELES")
            End If

        Catch ex As Exception

        End Try

        Try
            If CMBDESTINATION.Text = "SANFRANSISCO" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_SANFRANSISCO", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_SANFRANSISCO")
                DataGridView1.DataSource = ds.Tables("airlines_SANFRANSISCO")
            End If

        Catch ex As Exception

        End Try

        Try
            If CMBDESTINATION.Text = "TOKYO" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_TOKYO", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_TOKYO")
                DataGridView1.DataSource = ds.Tables("airlines_TOKYO")
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Not IsDBNull(DataGridView1.CurrentRow.Cells(1).Value) Then
            TXTFLTNO.Text = DataGridView1.CurrentRow.Cells(1).Value
        Else
            TXTFLTNO.Text = ""
        End If

        If Not IsDBNull(DataGridView1.CurrentRow.Cells(4).Value) Then
            TXTJDATE.Text = DataGridView1.CurrentRow.Cells(4).Value
        Else
            TXTJDATE.Text = ""
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Not IsDBNull(DataGridView1.CurrentRow.Cells(1).Value) Then
            TXTFLTNO.Text = DataGridView1.CurrentRow.Cells(1).Value
        Else
            TXTFLTNO.Text = ""
        End If

        If Not IsDBNull(DataGridView1.CurrentRow.Cells(4).Value) Then
            TXTJDATE.Text = DataGridView1.CurrentRow.Cells(4).Value
        Else
            TXTJDATE.Text = ""
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If Not IsDBNull(DataGridView1.CurrentRow.Cells(1).Value) Then
            TXTFLTNO.Text = DataGridView1.CurrentRow.Cells(1).Value
        Else
            TXTFLTNO.Text = ""
        End If

        If Not IsDBNull(DataGridView1.CurrentRow.Cells(4).Value) Then
            TXTJDATE.Text = DataGridView1.CurrentRow.Cells(4).Value
        Else
            TXTJDATE.Text = ""
        End If
    End Sub

    Private Sub DataGridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyUp
        If Not IsDBNull(DataGridView1.CurrentRow.Cells(1).Value) Then
            TXTFLTNO.Text = DataGridView1.CurrentRow.Cells(1).Value
        Else
            TXTFLTNO.Text = ""
        End If

        If Not IsDBNull(DataGridView1.CurrentRow.Cells(4).Value) Then
            TXTJDATE.Text = DataGridView1.CurrentRow.Cells(4).Value
        Else
            TXTJDATE.Text = ""
        End If
    End Sub

    Private Sub CMBDESTINATION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBDESTINATION.SelectedIndexChanged
        Try
            If CMBDESTINATION.Text = "NEWYORK" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_newyork", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_newyork")
                DataGridView1.DataSource = ds.Tables("airlines_newyork")
            End If

        Catch ex As Exception

        End Try

        Try
            If CMBDESTINATION.Text = "LONDON" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_LONDON", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_LONDON")
                DataGridView1.DataSource = ds.Tables("airlines_LONDON")
            End If

        Catch ex As Exception

        End Try

        Try
            If CMBDESTINATION.Text = "LOSANGELES" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_LOSANGELES", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_LOSANGELES")
                DataGridView1.DataSource = ds.Tables("airlines_LOSANGELES")
            End If

        Catch ex As Exception

        End Try


        Try
            If CMBDESTINATION.Text = "SANFRANSISCO" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_SANFRANSISCO", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_SANFRANSISCO")
                DataGridView1.DataSource = ds.Tables("airlines_SANFRANSISCO")
            End If

        Catch ex As Exception

        End Try

        Try
            If CMBDESTINATION.Text = "TOKYO" Then
                Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = connString

                'create a data adapter
                Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from airlines_TOKYO", myConnection)

                ' create a new dataset
                Dim ds As DataSet = New DataSet
                'Fill dataset
                da.Fill(ds, "airlines_TOKYO")
                DataGridView1.DataSource = ds.Tables("airlines_TOKYO")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Dim X As New Form1
        Me.Hide()
        X.Show()
    End Sub

    Private Sub CMDBOOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBOOK.Click
        Dim XX As New Form6
        XX.txtflightno.Text = Me.TXTFLTNO.Text

        If Not IsDBNull(Me.DataGridView1.CurrentRow.Cells(3).Value) Then
            XX.txtdestination.Text = Me.DataGridView1.CurrentRow.Cells(3).Value
        Else
            XX.txtdestination.Text = ""
        End If
        XX.txtjdate.Text = Me.TXTJDATE.Text
        XX.TextBox3.Text = Me.DataGridView1.CurrentRow.Cells(0).Value
        XX.TextBox4.Text = Me.DataGridView1.CurrentRow.Cells(6).Value
        XX.Show()
    End Sub
End Class