Imports System.Data.OleDb
Public Class frmYears
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"

    Sub Reset()
        txtYears.Text = ""
        cmbCourse.Text = ""
        txtID.Text = ""
        btnSave.Enabled = True
        btnUpdate_record.Enabled = False
        btnDelete.Enabled = False
        txtYears.Focus()
    End Sub
    Sub fillCourse()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Coursename) FROM Course", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCourse.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCourse.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from tblYears order by Course", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (rdr.Read() = True)
                DataGridView1.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
        fillCourse()
        Autocomplete()
    End Sub
    Sub Autocomplete()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct C_Year FROM tblYears", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "tblYears")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("C_Year").ToString())
            Next
            txtYears.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtYears.AutoCompleteCustomSource = col
            txtYears.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtYears.Text)) = 0 Then
            MessageBox.Show("Please enter year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtYears.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbCourse.Text)) = 0 Then
            MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCourse.Focus()
            Exit Sub
        End If

        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select C_Year,Course from tblYears where Course='" & cmbCourse.Text & "' and C_Year='" & txtYears.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Record Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into tblYears(C_year,Course) VALUES ('" & txtYears.Text & "','" & cmbCourse.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetData()
            Autocomplete()
            btnSave.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtID.Text = dr.Cells(0).Value.ToString()
            txtYears.Text = dr.Cells(1).Value.ToString()
            cmbCourse.Text = dr.Cells(2).Value.ToString()
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
            Dim cq As String = "delete from tblYears where ID=" & txtID.Text & ""
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetData()
                Autocomplete()
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
        If Len(Trim(txtYears.Text)) = 0 Then
            MessageBox.Show("Please enter year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtYears.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbCourse.Text)) = 0 Then
            MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCourse.Focus()
            Exit Sub
        End If
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update tblYears set Course='" & cmbCourse.Text & "',C_Year= '" & txtYears.Text & "' where ID= " & txtID.Text & ""
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetData()
            Autocomplete()
            btnUpdate_record.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class