Imports System.Data.OleDb
Public Class frmProject
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"
    Sub Reset()
        txtProjectName.Text = ""
        txtRemarks.Text = ""
        txtStudentName.Text = ""
        cmbCourse.Text = ""
        cmbYear.Text = ""
        dtpSubmissionDate.Text = Today
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate_record.Enabled = False
        cmbYear.Enabled = False
        txtProjectName.Focus()
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
    Private Sub frmProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCourse()
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtProjectName.Text)) = 0 Then
                MessageBox.Show("Please enter project name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtProjectName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtStudentName.Text)) = 0 Then
                MessageBox.Show("Please retrieve student name(s)", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCourse.Text)) = 0 Then
                MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCourse.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbYear.Text)) = 0 Then
                MessageBox.Show("Please select year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbYear.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into Project(ProjectName, StudentName, Course, Proj_year, SubmissionDate, Remarks) VALUES('" & txtProjectName.Text & "','" & txtStudentName.Text & "','" & cmbCourse.Text & "','" & cmbYear.Text & "',#" & dtpSubmissionDate.Text & "#,'" & txtRemarks.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", "Project Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
      Try
            cmbCourse.Text = cmbCourse.Text.Trim()
            cmbYear.Items.Clear()
            cmbYear.Text = ""
            cmbYear.Enabled = True
            cmbYear.Focus()
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select distinct RTRIM(C_Year) from tblYears where course = '" & cmbCourse.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            While rdr.Read()
                cmbYear.Items.Add(rdr(0))
            End While
            con.Close()
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
    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from Project where ID = " & txtID.Text & ""
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If Len(Trim(txtProjectName.Text)) = 0 Then
                MessageBox.Show("Please enter project name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtProjectName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtStudentName.Text)) = 0 Then
                MessageBox.Show("Please retrieve student name(s)", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCourse.Text)) = 0 Then
                MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCourse.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbYear.Text)) = 0 Then
                MessageBox.Show("Please select year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbYear.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Project set projectName='" & txtProjectName.Text & "',StudentName='" & txtStudentName.Text & "',Course='" & cmbCourse.Text & "',proj_Year='" & cmbYear.Text & "',SubmissionDate=#" & dtpSubmissionDate.Text & "#,remarks='" & txtRemarks.Text & "' where ID= " & txtID.Text & ""
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully updated", "Project Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmStudentRecord2.Show()
        frmStudentRecord2.txtStudentName.Text = ""
        frmStudentRecord2.cmbCourse.Text = ""
        frmStudentRecord2.cmbDepartment.Text = ""
        frmStudentRecord2.cmbCourse1.Text = ""
        frmStudentRecord2.cmbDepartment1.Text = ""
        frmStudentRecord2.cmbSession.Text = ""
        frmStudentRecord2.GetData()
    End Sub

    Private Sub btnGetDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDetails.Click
        frmProjectRecord.Show()
        frmProjectRecord.Reset()
    End Sub
End Class