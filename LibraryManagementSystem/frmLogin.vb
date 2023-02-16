Imports System.Data.OleDb
Public Class Frmlogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(cmbUserType.Text)) = 0 Then
            MessageBox.Show("Please select user type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUserType.Focus()
            Exit Sub
        End If
        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If
        Try
            Dim myConnection As OleDbConnection
            myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;")
            Dim myCommand As OleDbCommand
            myCommand = New OleDbCommand("SELECT users.username,User_password FROM Users,Registration where Registration.Username=users.username and Users.Username = @Username and user_password = @UserPassword", myConnection)

            Dim uName As New OleDbParameter("@Username", SqlDbType.VarChar)
            Dim uPassword As New OleDbParameter("@UserPassword", SqlDbType.VarChar)
            uName.Value = txtUsername.Text
            uPassword.Value = txtPassword.Text
            myCommand.Parameters.Add(uName)

            myCommand.Parameters.Add(uPassword)

            myCommand.Connection.Open()

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

            Dim Login As Object = 0

            If myReader.HasRows Then

                myReader.Read()

                Login = myReader(Login)

            End If

            If Login = Nothing Then

                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()

            Else

                ProgressBar1.Visible = True
                ProgressBar1.Maximum = 5000
                ProgressBar1.Minimum = 0
                ProgressBar1.Value = 4
                ProgressBar1.Step = 1

                For i = 0 To 5000
                    ProgressBar1.PerformStep()
                Next
                Me.Hide()
                frmMain.lblUser.Text = txtUsername.Text
                frmMain.Show()
            End If
            myCommand.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub linkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Me.Hide()
        frmChangePassword.Show()
        frmChangePassword.cmbUserType.Text = ""
        frmChangePassword.UserName.Text = ""
        frmChangePassword.OldPassword.Text = ""
        frmChangePassword.NewPassword.Text = ""
        frmChangePassword.ConfirmPassword.Text = ""
        frmChangePassword.cmbUserType.Focus()
    End Sub

    Private Sub linkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel3.LinkClicked
        Me.Hide()
        frmPasswordRecovery.Show()
    End Sub

    Private Sub Frmlogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class
