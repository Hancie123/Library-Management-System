Imports System.Data.OleDb
Public Class frmNewsPaper
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim Status As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"

    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub
    Sub Reset()
        txtPaperName.Text = ""
        txtRemarks.Text = ""
        dtpDate.Text = Today
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate_record.Enabled = False
        txtPaperName.Focus()
    End Sub
    Private Sub frmNewsPaper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Autocomplete()
    End Sub
   
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtPaperName.Text)) = 0 Then
                MessageBox.Show("Please Enter Paper Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPaperName.Focus()
                Exit Sub
            End If
            If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                MessageBox.Show("Please select status", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If (RadioButton1.Checked = True) Then
                Status = RadioButton1.Text
            End If
            If (RadioButton2.Checked = True) Then
                Status = RadioButton2.Text
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into NewsPaper(PaperName, N_Date, Status, Remarks) VALUES ('" & txtPaperName.Text & "',#" & dtpDate.Text & "#,'" & Status & "','" & txtRemarks.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Autocomplete()
            con.Close()
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
    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from NewsPaper where ID = " & txtID.Text & ""
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        Try
            If Len(Trim(txtPaperName.Text)) = 0 Then
                MessageBox.Show("Please Enter Paper Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPaperName.Focus()
                Exit Sub
            End If
            If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                MessageBox.Show("Please select status", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If (RadioButton1.Checked = True) Then
                Status = RadioButton1.Text
            End If
            If (RadioButton2.Checked = True) Then
                Status = RadioButton2.Text
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update NewsPaper set PaperName='" & txtPaperName.Text & "',N_Date=#" & dtpDate.Text & "#,Status='" & Status & "',Remarks='" & txtRemarks.Text & "' where ID=" & txtID.Text & ""
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
            Autocomplete()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGetDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDetails.Click
        frmNewsPaperRecord.Show()
        frmNewsPaperRecord.cmbPaperName.Text = ""
        frmNewsPaperRecord.dtpDateFrom.Text = Today
        frmNewsPaperRecord.dtpDateTo.Text = Today
        frmNewsPaperRecord.DataGridView1.DataSource = Nothing
        frmNewsPaperRecord.fillcombo()
    End Sub
    Sub Autocomplete()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct PaperName FROM NewsPaper", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "newspaper")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("PaperName").ToString())
            Next
            txtPaperName.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtPaperName.AutoCompleteCustomSource = col
            txtPaperName.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class