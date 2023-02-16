Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Public Class frmSupplier
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim s1, s2, s3 As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"
    Sub Reset()
        txtSupplierName.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""
        txtEmail.Text = ""
        txtSupplierName.Focus()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate_record.Enabled = False
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from Supplier where SupplierName = '" & txtSupplierName.Text & "'"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetData()
                Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Public Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from Supplier order by SupplierName", con)
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtSupplierName.Text)) = 0 Then
            MessageBox.Show("Please Enter Supplier Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSupplierName.Focus()
            Exit Sub
        End If
        If ((CheckBox1.Checked = False) And (CheckBox2.Checked = False) And (CheckBox3.Checked = False)) Then
            MessageBox.Show("Please Select Supplier Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(txtAddress.Text)) = 0 Then
            MessageBox.Show("Please Enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
            Exit Sub
        End If
        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("Please Enter Contact No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
            Exit Sub
        End If

        Try
            If (CheckBox1.Checked = True) Then
                s1 = "Yes"
            Else
                s1 = "No"
            End If
            If (CheckBox2.Checked = True) Then
                s2 = "Yes"
            Else
                s2 = "No"
            End If
            If (CheckBox3.Checked = True) Then
                s3 = "Yes"
            Else
                s3 = "No"
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into Supplier(SupplierName,S_Books, S_NewsPaper, S_Magzines, Address, ContactNo, EmailID) VALUES ('" & txtSupplierName.Text & "','" & s1 & "','" & s2 & "','" & s3 & "','" & txtAddress.Text & "','" & txtContactNo.Text & "','" & txtEmail.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully saved", "Supplier Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            GetData()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        Reset()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtSupplierName.Text = dr.Cells(0).Value.ToString()
            TextBox1.Text = dr.Cells(0).Value.ToString()
            If (dr.Cells(1).Value.ToString() = "Yes") Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
            If (dr.Cells(2).Value.ToString() = "Yes") Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If (dr.Cells(3).Value.ToString() = "Yes") Then
                CheckBox3.Checked = True
            Else
                CheckBox3.Checked = False
            End If
            txtAddress.Text = dr.Cells(4).Value.ToString()
            txtContactNo.Text = dr.Cells(5).Value.ToString()
            txtEmail.Text = dr.Cells(6).Value.ToString()
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

    Private Sub txtContactNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContactNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtContactNo.Validating
        If (txtContactNo.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
        End If
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtEmail.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtEmail.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtEmail.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        If Len(Trim(txtSupplierName.Text)) = 0 Then
            MessageBox.Show("Please Enter Supplier Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSupplierName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtAddress.Text)) = 0 Then
            MessageBox.Show("Please Enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
            Exit Sub
        End If
        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("Please Enter Contact No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
            Exit Sub
        End If
        If ((CheckBox1.Checked = False) And (CheckBox2.Checked = False) And (CheckBox3.Checked = False)) Then
            MessageBox.Show("Please Select Supplier Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            If (CheckBox1.Checked = True) Then
                s1 = "Yes"
            Else
                s1 = "No"
            End If
            If (CheckBox2.Checked = True) Then
                s2 = "Yes"
            Else
                s2 = "No"
            End If
            If (CheckBox3.Checked = True) Then
                s3 = "Yes"
            Else
                s3 = "No"
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Supplier set SupplierName='" & txtSupplierName.Text & "',S_NewsPaper='" & s2 & "',S_Books='" & s1 & "',S_Magzines='" & s3 & "',Address='" & txtAddress.Text & "',ContactNo='" & txtContactNo.Text & "',EmailID='" & txtEmail.Text & "' where SupplierName='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully updated", "Supplier Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
            GetData()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class