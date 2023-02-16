Imports System.Data.OleDb
Public Class frmDepartment
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim rdr As OleDbDataReader
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"

    Sub Reset()
        txtDepartmentName.Text = ""
        btnSave.Enabled = True
        btnUpdate_record.Enabled = False
        btnDelete.Enabled = False
        txtDepartmentName.Focus()
    End Sub
    Public Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT departmentname from Department order by departmentname", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (rdr.Read() = True)
                DataGridView1.Rows.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtDepartmentName.Text)) = 0 Then
            MessageBox.Show("Please enter department name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepartmentName.Focus()
            Exit Sub
        End If

        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select departmentname from Department where departmentname='" & txtDepartmentName.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("department name Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into Department(departmentname) VALUES ('" & txtDepartmentName.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetData()
            btnSave.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtDepartmentName.Text = dr.Cells(0).Value.ToString()
            TextBox1.Text = dr.Cells(0).Value.ToString()
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


    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from Department where departmentname='" & txtDepartmentName.Text & "'"
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
                GetData()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        If Len(Trim(txtDepartmentName.Text)) = 0 Then
            MessageBox.Show("Please enter department name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepartmentName.Focus()
            Exit Sub
        End If

        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Department set departmentname='" & txtDepartmentName.Text & "' where departmentname='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetData()
            btnUpdate_record.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class