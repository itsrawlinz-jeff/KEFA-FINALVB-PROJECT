Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Visible = False

        Me.Text = "INTERNATIONAL AIRLINES DEPARTURE AND ARRIVAL SCHEDULE"
        Me.Label10.Text = Format(Now, "dd-MMM-yyyy")
        Me.Label11.Text = Format(Now, "hh:mm:ss")

        Me.CMBORIGIN.Items.Add("MUMBAI")
        Me.CMBORIGIN.Items.Add("LONDON")
        Me.CMBORIGIN.Items.Add("NEWYORK")
        Me.CMBORIGIN.Items.Add("TOKYO")
        Me.CMBORIGIN.Items.Add("LOSANGELES")
        Me.CMBORIGIN.Items.Add("CHICAGO")
        Me.CMBORIGIN.Items.Add("PARIS")
        Me.CMBORIGIN.Items.Add("FRANKFURT")
        Me.CMBORIGIN.Items.Add("SINGAPORE")
        Me.CMBORIGIN.Items.Add("DUBAI")
        Me.CMBORIGIN.Items.Add("SANFRANSISCO")
        Me.CMBORIGIN.Items.Add("BANGKOK")
        Me.CMBORIGIN.Items.Add("SYDNEY")
        Me.CMBORIGIN.Items.Add("KOLKATA")
        Me.CMBORIGIN.Items.Add("DELHI")
        Me.CMBORIGIN.Items.Add("CHENNAI")
        Me.CMBORIGIN.Items.Add("MELBOURNE")
        Me.CMBORIGIN.Items.Add("PERTH")
        Me.CMBORIGIN.Items.Add("ZURICH")
        Me.CMBORIGIN.Items.Add("GENEVA")
        Me.CMBORIGIN.Items.Add("JEDDAH")
        Me.CMBORIGIN.Items.Add("WASHINGTON")
        Me.CMBORIGIN.Items.Add("HOUSTON")
        Me.CMBORIGIN.Items.Add("DHAKA")
        Me.CMBORIGIN.Items.Add("MONTREAL")
        Me.CMBORIGIN.Items.Add("AL-KUWAIT")
        Me.CMBORIGIN.Items.Add("DAHRAN")
        Me.CMBORIGIN.Items.Add("CAIRO")
        Me.CMBORIGIN.Items.Add("HONGKONG")


        Me.CMBDESTINATION.Items.Add("MUMBAI")
        Me.CMBDESTINATION.Items.Add("LONDON")
        Me.CMBDESTINATION.Items.Add("NEWYORK")
        Me.CMBDESTINATION.Items.Add("TOKYO")
        Me.CMBDESTINATION.Items.Add("LOSANGELES")
        Me.CMBDESTINATION.Items.Add("CHICAGO")
        Me.CMBDESTINATION.Items.Add("PARIS")
        Me.CMBDESTINATION.Items.Add("FRANKFURT")
        Me.CMBDESTINATION.Items.Add("SINGAPORE")
        Me.CMBDESTINATION.Items.Add("DUBAI")
        Me.CMBDESTINATION.Items.Add("SANFRANSISCO")
        Me.CMBDESTINATION.Items.Add("BANGKOK")
        Me.CMBDESTINATION.Items.Add("SYDNEY")
        Me.CMBDESTINATION.Items.Add("KOLKATA")
        Me.CMBDESTINATION.Items.Add("DELHI")
        Me.CMBDESTINATION.Items.Add("CHENNAI")
        Me.CMBDESTINATION.Items.Add("MELBOURNE")
        Me.CMBDESTINATION.Items.Add("PERTH")
        Me.CMBDESTINATION.Items.Add("ZURICH")
        Me.CMBDESTINATION.Items.Add("GENEVA")
        Me.CMBDESTINATION.Items.Add("JEDDAH")
        Me.CMBDESTINATION.Items.Add("WASHINGTON")
        Me.CMBDESTINATION.Items.Add("HOUSTON")
        Me.CMBDESTINATION.Items.Add("DHAKA")
        Me.CMBDESTINATION.Items.Add("MONTREAL")
        Me.CMBDESTINATION.Items.Add("AL-KUWAIT")
        Me.CMBDESTINATION.Items.Add("DAHRAN")
        Me.CMBDESTINATION.Items.Add("CAIRO")
        Me.CMBDESTINATION.Items.Add("HONGKONG")

    End Sub

    Private Sub CMDENTER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDENTER.Click
        ListBox1.Visible = True

        'create a connection string
        Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString

        'create a data adapter
        Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from AIRLINES_GENENQ", myConnection)

        ' create a new dataset
        Dim ds As DataSet = New DataSet

        'Fill dataset
        da.Fill(ds, "AIRLINES_GENENQ")
        ListBox1.DataSource = ds.Tables("AIRLINES_GENENQ")
        ListBox1.DisplayMember = "airline_name"

    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click

        Me.TXTAIRLINE.Text = Me.ListBox1.Text
        Me.ListBox1.Visible = False
        Me.TXTFLTNO.Focus()

        '*************************AIR INDIA*************************'
        Try
            If Me.TXTAIRLINE.Text = "AIRINDIA" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("CHICAGO")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("DUBAI")

                Me.CMBDESTINATION.Items.Clear()
                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("CHICAGO")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("DUBAI")
            End If
        Catch ex As Exception

        End Try

        '*************************JAPAN AIRLINES*************************'
        Try
            If Me.TXTAIRLINE.Text = "JAPAN AIRLINES" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("CHICAGO")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("SANFRANSISCO")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("SYDNEY")

                Me.CMBDESTINATION.Items.Clear()
                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("CHICAGO")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("SANFRANSISCO")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("SYDNEY")

            End If
        Catch ex As Exception

        End Try

        '*************************CATHAY PACIFIC*************************'
        Try
            If Me.TXTAIRLINE.Text = "CATHAY PACIFIC" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("SYDNEY")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("SANFRANSISCO")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")

                Me.CMBDESTINATION.Items.Clear()
                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("SYDNEY")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("SANFRANSISCO")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")

            End If
        Catch ex As Exception

        End Try

        '*************************SINGAPORE AIRLINES*************************'
        Try
            If Me.TXTAIRLINE.Text = "SINGAPORE AIRLINES" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("SYDNEY")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("SANFRANSISCO")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("KOLKATA")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("CHENNAI")
                Me.CMBORIGIN.Items.Add("MELBOURNE")
                Me.CMBORIGIN.Items.Add("PERTH")
                Me.CMBORIGIN.Items.Add("ZURICH")
                Me.CMBORIGIN.Items.Add("GENEVA")

                Me.CMBDESTINATION.Items.Clear()
                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("SYDNEY")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("SANFRANSISCO")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("KOLKATA")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("CHENNAI")
                Me.CMBDESTINATION.Items.Add("MELBOURNE")
                Me.CMBDESTINATION.Items.Add("PERTH")
                Me.CMBDESTINATION.Items.Add("ZURICH")
                Me.CMBDESTINATION.Items.Add("GENEVA")

            End If
        Catch ex As Exception

        End Try

        '*************************BRITISH AIRWAYS*************************'
        Try
            If Me.TXTAIRLINE.Text = "BRITISH AIRWAYS" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("SYDNEY")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("SANFRANSISCO")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("KOLKATA")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("CHENNAI")
                Me.CMBORIGIN.Items.Add("MELBOURNE")
                Me.CMBORIGIN.Items.Add("CHICAGO")

                Me.CMBDESTINATION.Items.Clear()
                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("SYDNEY")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("SANFRANSISCO")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("KOLKATA")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("CHENNAI")
                Me.CMBDESTINATION.Items.Add("MELBOURNE")
                Me.CMBDESTINATION.Items.Add("CHICAGO")

            End If
        Catch ex As Exception

        End Try

        '*************************THAI AIRWAYS*************************'
        Try
            If Me.TXTAIRLINE.Text = "THAI AIRWAYS" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("SYDNEY")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("KOLKATA")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("CHENNAI")
                Me.CMBORIGIN.Items.Add("MELBOURNE")
                Me.CMBORIGIN.Items.Add("DUBAI")

                Me.CMBDESTINATION.Items.Clear()
                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("SYDNEY")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("KOLKATA")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("CHENNAI")
                Me.CMBDESTINATION.Items.Add("MELBOURNE")
                Me.CMBDESTINATION.Items.Add("DUBAI")

            End If
        Catch ex As Exception

        End Try

        '*************************SAUDI ARABIAN AIRLINES*************************'
        Try
            If Me.TXTAIRLINE.Text = "SAUDI ARABIAN AIRLINES" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("RIYADH")
                Me.CMBORIGIN.Items.Add("DAHRAN")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("DUBAI")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("CHENNAI")
                Me.CMBORIGIN.Items.Add("JEDDAH")
                Me.CMBORIGIN.Items.Add("WASHINGTON")
                Me.CMBORIGIN.Items.Add("HOUSTON")
                Me.CMBORIGIN.Items.Add("DHAKA")

                Me.CMBDESTINATION.Items.Clear()
                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("RIYADH")
                Me.CMBDESTINATION.Items.Add("DAHRAN")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("DUBAI")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("CHENNAI")
                Me.CMBDESTINATION.Items.Add("JEDDAH")
                Me.CMBDESTINATION.Items.Add("WASHINGTON")
                Me.CMBDESTINATION.Items.Add("HOUSTON")
                Me.CMBDESTINATION.Items.Add("DHAKA")

            End If
        Catch ex As Exception

        End Try

        '*************************LUFTHANSA*************************'
        Try
            If Me.TXTAIRLINE.Text = "LUFTHANSA" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("DUBAI")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("CHENNAI")
                Me.CMBORIGIN.Items.Add("KOLKATA")
                Me.CMBORIGIN.Items.Add("WASHINGTON")
                Me.CMBORIGIN.Items.Add("SANFRANSISCO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("MONTREAL")
                Me.CMBORIGIN.Items.Add("CHICAGO")

                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("DUBAI")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("CHENNAI")
                Me.CMBDESTINATION.Items.Add("KOLKATA")
                Me.CMBDESTINATION.Items.Add("WASHINGTON")
                Me.CMBDESTINATION.Items.Add("SANFRANSISCO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("MONTREAL")
                Me.CMBDESTINATION.Items.Add("CHICAGO")

            End If
        Catch ex As Exception

        End Try

        '*************************QANTAS AIRWAYS*************************'
        Try
            If Me.TXTAIRLINE.Text = "QANTAS AIRWAYS" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("SANFRANSISCO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("MONTREAL")

                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("SANFRANSISCO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("MONTREAL")

            End If
        Catch ex As Exception

        End Try

        '*************************KUWAIT AIRWAYS*************************'
        Try
            If Me.TXTAIRLINE.Text = "KUWAIT AIRWAYS" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("RIYADH")
                Me.CMBORIGIN.Items.Add("DUBAI")
                Me.CMBORIGIN.Items.Add("JEDDAH")
                Me.CMBORIGIN.Items.Add("AL-KUWAIT")
                Me.CMBORIGIN.Items.Add("DAHRAN")
                Me.CMBORIGIN.Items.Add("CAIRO")
                Me.CMBORIGIN.Items.Add("DHAKA")

                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("RIYADH")
                Me.CMBDESTINATION.Items.Add("DUBAI")
                Me.CMBDESTINATION.Items.Add("JEDDAH")
                Me.CMBDESTINATION.Items.Add("AL-KUWAIT")
                Me.CMBDESTINATION.Items.Add("DAHRAN")
                Me.CMBDESTINATION.Items.Add("CAIRO")
                Me.CMBDESTINATION.Items.Add("DHAKA")
            End If
        Catch ex As Exception

        End Try

        '*************************KOREAN AIR*************************'
        Try
            If Me.TXTAIRLINE.Text = "KOREAN AIR" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("TOKYO")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("SANFRANSISCO")
                Me.CMBORIGIN.Items.Add("LOSANGELES")
                Me.CMBORIGIN.Items.Add("MONTREAL")

                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("TOKYO")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("SANFRANSISCO")
                Me.CMBDESTINATION.Items.Add("LOSANGELES")
                Me.CMBDESTINATION.Items.Add("MONTREAL")

            End If
        Catch ex As Exception

        End Try

        '*************************EMIRATES*************************'
        Try
            If Me.TXTAIRLINE.Text = "EMIRATES" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("MUMBAI")
                Me.CMBORIGIN.Items.Add("LONDON")
                Me.CMBORIGIN.Items.Add("NEWYORK")
                Me.CMBORIGIN.Items.Add("PARIS")
                Me.CMBORIGIN.Items.Add("FRANKFURT")
                Me.CMBORIGIN.Items.Add("SINGAPORE")
                Me.CMBORIGIN.Items.Add("HONGKONG")
                Me.CMBORIGIN.Items.Add("BANGKOK")
                Me.CMBORIGIN.Items.Add("DELHI")
                Me.CMBORIGIN.Items.Add("RIYADH")
                Me.CMBORIGIN.Items.Add("DUBAI")
                Me.CMBORIGIN.Items.Add("JEDDAH")
                Me.CMBORIGIN.Items.Add("AL-KUWAIT")
                Me.CMBORIGIN.Items.Add("DAHRAN")
                Me.CMBORIGIN.Items.Add("CAIRO")
                Me.CMBORIGIN.Items.Add("DHAKA")

                Me.CMBDESTINATION.Items.Add("MUMBAI")
                Me.CMBDESTINATION.Items.Add("LONDON")
                Me.CMBDESTINATION.Items.Add("NEWYORK")
                Me.CMBDESTINATION.Items.Add("PARIS")
                Me.CMBDESTINATION.Items.Add("FRANKFURT")
                Me.CMBDESTINATION.Items.Add("SINGAPORE")
                Me.CMBDESTINATION.Items.Add("HONGKONG")
                Me.CMBDESTINATION.Items.Add("BANGKOK")
                Me.CMBDESTINATION.Items.Add("DELHI")
                Me.CMBDESTINATION.Items.Add("RIYADH")
                Me.CMBDESTINATION.Items.Add("DUBAI")
                Me.CMBDESTINATION.Items.Add("JEDDAH")
                Me.CMBDESTINATION.Items.Add("AL-KUWAIT")
                Me.CMBDESTINATION.Items.Add("DAHRAN")
                Me.CMBDESTINATION.Items.Add("CAIRO")
                Me.CMBDESTINATION.Items.Add("DHAKA")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CMDINSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDINSERT.Click
        Me.TXTAIRLINE.Text = ""
        Me.TXTFLTNO.Text = ""
        Me.CMBORIGIN.Text = ""
        Me.CMBDESTINATION.Text = ""
        Me.TXTDEPARTURE.Text = ""
        Me.TXTARRIVAL.Text = ""
        Me.TXTSTOP.Text = ""
        Me.txtflightno.Enabled = False
        Me.TXTAIRLINE.Focus()
    End Sub

    Private Sub CMDSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSAVE.Click

        Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        Dim dsinvoice As New DataSet
        Dim dainvoice As New OleDbDataAdapter
        Dim sql As String = "insert into AIRLINES_SCH(FLIGHT_NAME,FLIGHT_NO,ORIGIN,DESTINATION,DEPARTURE,ARRIVAL,STOPOVER) values('" & TXTAIRLINE.Text & "','" & TXTFLTNO.Text & "','" & CMBORIGIN.Text & "','" & CMBDESTINATION.Text & "','" & TXTDEPARTURE.Text & "','" & TXTARRIVAL.Text & "','" & TXTSTOP.Text & "')"
        myConnection.Open()
        Dim com As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        dbread = com.ExecuteReader()

    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Dim xx As New Form1
        xx.Show()
        Me.Hide()
    End Sub

    Private Sub txtflightno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtflightno.KeyPress
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                Dim sql As String
                sql = "select * from airlines_sch where flight_no='" & txtflightno.Text & "'"

                myConnection.Open()
                Dim com As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
                If Not dbread.read Then

                Else
                    TXTAIRLINE.Text = dbread.getstring(0)
                    TXTFLTNO.Text = dbread.getstring(1)
                    CMBORIGIN.Text = dbread.getstring(2)
                    CMBDESTINATION.Text = dbread.getstring(3)
                    TXTDEPARTURE.Text = dbread.getstring(4)
                    TXTARRIVAL.Text = dbread.getstring(5)
                    TXTSTOP.Text = dbread.getstring(6)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CMDSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSUBMIT.Click
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            Dim sql As String
            sql = "select * from airlines_sch where flight_no='" & txtflightno.Text & "'"

            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader()
            If Not dbread.read Then

            Else
                TXTAIRLINE.Text = dbread.getstring(0)
                TXTFLTNO.Text = dbread.getstring(1)
                CMBORIGIN.Text = dbread.getstring(2)
                CMBDESTINATION.Text = dbread.getstring(3)
                TXTDEPARTURE.Text = dbread.getstring(4)
                TXTARRIVAL.Text = dbread.getstring(5)
                TXTSTOP.Text = dbread.getstring(6)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CMDCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCEL.Click
        Me.txtflightno.Focus()
        Me.txtflightno.Text = ""
        Me.TXTAIRLINE.Text = ""
        Me.TXTFLTNO.Text = ""
        Me.CMBORIGIN.Text = ""
        Me.CMBDESTINATION.Text = ""
        Me.TXTDEPARTURE.Text = ""
        Me.TXTARRIVAL.Text = ""
        Me.TXTSTOP.Text = ""
    End Sub

    Private Sub CMDUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUPDATE.Click
        Try
            Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString
            Dim dsinvoice As New DataSet
            Dim dainvoice As New OleDbDataAdapter
            Dim sql As String = "update AIRLINES_SCH set FLIGHT_NAME='" & TXTAIRLINE.Text & "',FLIGHT_NO='" & TXTFLTNO.Text & "',ORIGIN='" & CMBORIGIN.Text & "',DESTINATION='" & CMBDESTINATION.Text & "',DEPARTURE='" & TXTDEPARTURE.Text & "',ARRIVAL='" & TXTARRIVAL.Text & "',STOPOVER='" & TXTSTOP.Text & "' where FLIGHT_NO='" & txtflightno.Text & "'"
            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub CMDDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click
        Dim ConnString As String = System.Configuration.ConfigurationSettings.AppSettings("DSN")
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        Dim dsinvoice As New DataSet
        Dim dainvoice As New OleDbDataAdapter
        Dim sql As String = "delete from AIRLINES_SCH where FLIGHT_no='" & txtflightno.Text & "'"
        myConnection.Open()
        Dim com As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        dbread = com.ExecuteReader()

    End Sub

End Class