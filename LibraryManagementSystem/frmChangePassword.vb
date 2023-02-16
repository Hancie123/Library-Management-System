Imports System.Data.OleDB
Public Class frmChangePassword
    Dim rdr As OleDbDataReader = Nothing

    Dim con As OleDbConnection = Nothing

    Dim cmd As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim RowsAffected As Integer = 0
            If Len(Trim(cmbUserType.Text)) = 0 Then
                MessageBox.Show("Please select user type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbUserType.Focus()
                Exit Sub
            End If
            If Len(Trim(UserName.Text)) = 0 Then
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserName.Focus()
                Exit Sub
            End If
            If Len(Trim(OldPassword.Text)) = 0 Then
                MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OldPassword.Focus()
                Exit Sub
            End If
            If Len(Trim(NewPassword.Text)) = 0 Then
                MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Focus()
                Exit Sub
            End If
            If Len(Trim(ConfirmPassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ConfirmPassword.Focus()
                Exit Sub
            End If
            If NewPassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                ConfirmPassword.Text = ""
                NewPassword.Focus()
                Exit Sub
            ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                OldPassword.Text = ""
                ConfirmPassword.Text = ""
                OldPassword.Focus()
                Exit Sub
            ElseIf OldPassword.Text = NewPassword.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                ConfirmPassword.Text = ""
                NewPassword.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update Registration set user_password = '" & NewPassword.Text & "'where username='" & UserName.Text & "' and user_password = '" & OldPassword.Text & "' and usertype='" & cmbUserType.Text & "'"
            cmd = New OleDbCommand(co)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Frmlogin.Show()
                Frmlogin.cmbUserType.Text = ""
                Frmlogin.txtUsername.Text = ""
                Frmlogin.txtPassword.Text = ""
                Frmlogin.cmbUserType.Focus()
            Else

                MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserName.Text = ""
                NewPassword.Text = ""
                OldPassword.Text = ""
                ConfirmPassword.Text = ""
                UserName.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ChangePassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Frmlogin.Show()
        Frmlogin.cmbUserType.Text = ""
        frmLogin.txtUsername.Text = ""
        frmLogin.txtPassword.Text = ""
        Frmlogin.cmbUserType.Focus()
    End Sub




    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class