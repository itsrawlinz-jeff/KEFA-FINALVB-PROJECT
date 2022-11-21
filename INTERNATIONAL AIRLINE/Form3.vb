Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Visible = False

        Me.Text = "KEPHA AIRLINES DEPARTURE AND ARRIVAL SCHEDULE"
        Me.Label10.Text = Format(Now, "dd-MMM-yyyy")
        Me.Label11.Text = Format(Now, "hh:mm:ss")

        Me.CMBORIGIN.Items.Add("NAIROBI")
        Me.CMBORIGIN.Items.Add("MOMBASA")
        Me.CMBORIGIN.Items.Add("KISUMU")
        Me.CMBORIGIN.Items.Add("MSA")
        Me.CMBORIGIN.Items.Add("KIAMBU")
        Me.CMBORIGIN.Items.Add("ISIOLO")
   


    End Sub

    Private Sub CMDENTER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDENTER.Click
        ListBox1.Visible = True



    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click

        Me.TXTAIRLINE.Text = Me.ListBox1.Text
        Me.ListBox1.Visible = False
        Me.TXTFLTNO.Focus()

        '*************************AIR INDIA*************************'
        Try
            If Me.TXTAIRLINE.Text = "AIRKCA" Then
                Me.CMBORIGIN.Items.Add("NAIROBI")
                Me.CMBORIGIN.Items.Add("MOMBASA")
                Me.CMBORIGIN.Items.Add("KISUMU")
                Me.CMBORIGIN.Items.Add("MSA")
                Me.CMBORIGIN.Items.Add("KIAMBU")
                Me.CMBORIGIN.Items.Add("ISIOLO")

                Me.CMBDESTINATION.Items.Clear()
                  Me.CMBORIGIN.Items.Add("NAIROBI")
                Me.CMBORIGIN.Items.Add("MOMBASA")
                Me.CMBORIGIN.Items.Add("KISUMU")
                Me.CMBORIGIN.Items.Add("MSA")
                Me.CMBORIGIN.Items.Add("KIAMBU")
                Me.CMBORIGIN.Items.Add("ISIOLO")
            End If
        Catch ex As Exception

        End Try

        '*************************JAPAN AIRLINES*************************'
        Try
            If Me.TXTAIRLINE.Text = "JAPAN AIRLINES" Then
                Me.CMBORIGIN.Items.Clear()
                 Me.CMBORIGIN.Items.Add("NAIROBI")
                Me.CMBORIGIN.Items.Add("MOMBASA")
                Me.CMBORIGIN.Items.Add("KISUMU")
                Me.CMBORIGIN.Items.Add("MSA")
                Me.CMBORIGIN.Items.Add("KIAMBU")
                Me.CMBORIGIN.Items.Add("ISIOLO")

                Me.CMBDESTINATION.Items.Clear()
              Me.CMBORIGIN.Items.Add("NAIROBI")
                Me.CMBORIGIN.Items.Add("MOMBASA")
                Me.CMBORIGIN.Items.Add("KISUMU")
                Me.CMBORIGIN.Items.Add("MSA")
                Me.CMBORIGIN.Items.Add("KIAMBU")
                Me.CMBORIGIN.Items.Add("ISIOLO")

            End If
        Catch ex As Exception

        End Try

        '*************************CATHAY PACIFIC*************************'
        Try
            If Me.TXTAIRLINE.Text = "CATHAY PACIFIC" Then
                Me.CMBORIGIN.Items.Clear()
                Me.CMBORIGIN.Items.Add("NAIROBI")
                Me.CMBORIGIN.Items.Add("MOMBASA")
                Me.CMBORIGIN.Items.Add("KISUMU")
                Me.CMBORIGIN.Items.Add("MSA")
                Me.CMBORIGIN.Items.Add("KIAMBU")
                Me.CMBORIGIN.Items.Add("ISIOLO")

                Me.CMBDESTINATION.Items.Clear()
                Me.CMBORIGIN.Items.Add("NAIROBI")
                Me.CMBORIGIN.Items.Add("MOMBASA")
                Me.CMBORIGIN.Items.Add("KISUMU")
                Me.CMBORIGIN.Items.Add("MSA")
                Me.CMBORIGIN.Items.Add("KIAMBU")
                Me.CMBORIGIN.Items.Add("ISIOLO")
               
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

       

    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Dim xx As New Form1
        xx.Show()
        Me.Hide()
    End Sub

    Private Sub txtflightno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtflightno.KeyPress
       
       
    End Sub

    Private Sub CMDSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSUBMIT.Click
       

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
      

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CMDDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click
      
    End Sub

    Private Sub CMBORIGIN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBORIGIN.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class