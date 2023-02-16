Imports System.Net.Mail
Imports System.Data.OleDB
Public Class frmPasswordRecovery

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim ds As New DataSet()
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;")
            con.Open()
            Dim cmd As New OleDbCommand("SELECT user_password FROM Registration,Users where Users.username=Registration.username and Registration.username = 'admin'", con)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds)
            con.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                Dim Msg As New MailMessage()
                ' Sender e-mail address.
                Msg.From = New MailAddress("abcd@gmail.com")
                ' Recipient e-mail address.
                Msg.[To].Add("Virendra_take@yahoo.co.in")
                Msg.Subject = "Your Password Details"
                Msg.Body = "Your Password: " & Convert.ToString(ds.Tables(0).Rows(0)("user_Password")) & ""
                Msg.IsBodyHtml = True
                ' your remote SMTP server IP.
                Dim smtp As New SmtpClient()
                smtp.Host = "smtp.gmail.com"
                smtp.Port = 587
                smtp.Credentials = New System.Net.NetworkCredential("abcd@gmail.com", "12345")
                smtp.EnableSsl = True
                smtp.Send(Msg)
                MessageBox.Show("Password Successfully sent " & vbCrLf & "Please check your mail", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmlogin.Show()
                Frmlogin.txtUsername.Text = ""
                Frmlogin.txtPassword.Text = ""
                Frmlogin.cmbUserType.Text = ""
                Frmlogin.cmbUserType.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub





    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub

    Private Sub frmPasswordRecovery_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Frmlogin.Show()
        Frmlogin.txtUsername.Text = ""
        Frmlogin.txtPassword.Text = ""
        Frmlogin.cmbUserType.Text = ""
        Frmlogin.cmbUserType.Focus()
    End Sub

    Private Sub frmPasswordRecovery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
