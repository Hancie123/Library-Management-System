Imports System.Data.OleDb
Public Class frmRegistration
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"
    Sub Reset()
        txtContactNo.Text = ""
        txtEmailID.Text = ""
        txtName.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
        cmbUserType.Text = ""
        txtUsername.Focus()
        btnSave.Enabled = True
        btnUpdate_record.Enabled = False
        btnDelete.Enabled = False
    End Sub
    Private Sub frmRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
    End Sub
    Public Sub Getdata()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from Registration order by JoiningDate", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (rdr.Read() = True)
                DataGridView1.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtUsername.Text = dr.Cells(0).Value.ToString()
            TextBox1.Text = dr.Cells(0).Value.ToString()
            cmbUserType.Text = dr.Cells(1).Value.ToString()
            txtPassword.Text = dr.Cells(2).Value.ToString()
            txtName.Text = dr.Cells(3).Value.ToString()
            txtContactNo.Text = dr.Cells(4).Value.ToString()
            txtEmailID.Text = dr.Cells(5).Value.ToString()
            btnUpdate_record.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtUsername.Focus()
            Return
        End If
        If cmbUserType.Text = "" Then
            MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cmbUserType.Focus()
            Return
        End If
        If txtPassword.Text = "" Then
            MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtPassword.Focus()
            Return
        End If
        If txtName.Text = "" Then
            MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtName.Focus()
            Return
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtContactNo.Focus()
            Return
        End If
        If txtEmailID.Text = "" Then
            MessageBox.Show("Please enter email id", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtEmailID.Focus()
            Return
        End If
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select username from registration where username=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "username"))
            cmd.Parameters("@find").Value = txtUsername.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtUsername.Text = ""
                txtUsername.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If

            con = New OleDbConnection(cs)
            con.Open()

            Dim cb As String = "insert into Registration(UserName, UserType, User_Password, NameOfuser, ContactNo, Email,JoiningDate) VALUES ('" & txtUsername.Text & "','" & cmbUserType.Text & "','" & txtPassword.Text & "','" & txtName.Text & "','" & txtContactNo.Text & "','" & txtEmailID.Text & "','" & System.DateTime.Now & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into users(username) VALUES ('" & txtUsername.Text & "')"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DeleteRecord()

        Try
            If txtUsername.Text = "admin" Or txtUsername.Text = "Admin" Then
                MessageBox.Show("Admin account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "delete from Users where Username='" & txtUsername.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from Registration where Username='" & txtUsername.Text & "'"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Getdata()
                Reset()
            Else
                MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Sub txtContactNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtContactNo.Validating
        If (txtContactNo.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
        End If
    End Sub

    Private Sub txtContactNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmailID_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmailID.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtEmailID.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtEmailID.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtEmailID.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        Try
            If txtUsername.Text = "" Then
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtUsername.Focus()
                Return
            End If
            If cmbUserType.Text = "" Then
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbUserType.Focus()
                Return
            End If
            If txtPassword.Text = "" Then
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtPassword.Focus()
                Return
            End If
            If txtName.Text = "" Then
                MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtName.Focus()
                Return
            End If
            If txtContactNo.Text = "" Then
                MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtContactNo.Focus()
                Return
            End If
            If txtEmailID.Text = "" Then
                MessageBox.Show("Please enter email id", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtEmailID.Focus()
                Return
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update registration set username='" & txtUsername.Text & "', usertype='" & cmbUserType.Text & "',user_password='" & txtPassword.Text & "',contactno='" & txtContactNo.Text & "',email='" & txtEmailID.Text & "',nameofuser='" & txtName.Text & "' where username='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            con = New OleDbConnection(cs)
            MessageBox.Show("Successfully updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class