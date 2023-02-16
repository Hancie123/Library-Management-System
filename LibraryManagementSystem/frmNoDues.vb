Imports System.Data.OleDb
Public Class frmNoDues
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"
    Sub fillSession()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Stu_Session) FROM Student", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSession.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSession.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillDepartment()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Department) FROM Staff", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbDepartment1.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbDepartment1.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmStudentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillSession()
        fillDepartment()
    End Sub
    Sub Reset()
        cmbSession.Text = ""
        cmbCourse.Text = ""
        cmbDepartment.Text = ""
        cmbCourse.Enabled = False
        cmbDepartment.Enabled = False
        btnUpdate_record.Enabled = False
        listView1.Items.Clear()
    End Sub
    Sub Reset1()
        cmbDepartment1.Text = ""
        btnUpdate1.Enabled = False
        ListView2.Items.Clear()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudentListRecord.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmbSession.Text = "" Then
            MessageBox.Show("Please select session", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cmbSession.Focus()
            Return
        End If
        If cmbCourse.Text = "" Then
            MessageBox.Show("Please select course", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cmbCourse.Focus()
            Return
        End If
        If cmbDepartment.Text = "" Then
            MessageBox.Show("Please select department", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cmbDepartment.Focus()
            Return
        End If

        Try
            btnUpdate_record.Enabled = True
            Dim _with1 = listView1
            _with1.Clear()
            _with1.Columns.Add("Student ID", 100, HorizontalAlignment.Left)
            _with1.Columns.Add("Student Name", 250, HorizontalAlignment.Center)
            _with1.Columns.Add("Status", 0, HorizontalAlignment.Center)
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select Student.StudentID,StudentName,Status from NoDues_Student,Student where NoDues_Student.StudentID=Student.StudentID and Course = '" & cmbCourse.Text & "' and Department= '" & cmbDepartment.Text & "' and Stu_Session= '" & cmbSession.Text & "' order by StudentName", con)
            rdr = cmd.ExecuteReader()
            While rdr.Read()
                Dim item = New ListViewItem()
                item.Text = rdr(0).ToString().Trim()
                item.SubItems.Add(rdr(1).ToString().Trim())
                item.SubItems.Add(rdr(2).ToString().Trim())
                listView1.Items.Add(item)
                For i As Integer = listView1.Items.Count - 1 To 0 Step -1
                    If listView1.Items(i).SubItems(2).Text = "Yes" Then
                        listView1.Items(i).Checked = True
                    Else
                        listView1.Items(i).Checked = False
                    End If
                Next
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        Try

            For i As Integer = listView1.Items.Count - 1 To 0 Step -1

                con = New OleDbConnection(cs)
                If listView1.Items(i).Checked = True Then
                    txtStatus.Text = "Yes"
                Else
                    txtStatus.Text = "No"
                End If
                Dim cd As String = "update NoDues_Student set Status='" & txtStatus.Text & "' where StudentID= '" & listView1.Items(i).SubItems(0).Text & "'"
                cmd = New OleDbCommand(cd)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Next
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub cmbSession_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSession.SelectedIndexChanged
        Try
            cmbCourse.Items.Clear()
            cmbCourse.Text = ""
            cmbCourse.Enabled = True
            cmbCourse.Focus()
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select distinct RTRIM(Course) from Student where Stu_Session= '" & cmbSession.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            While rdr.Read()
                cmbCourse.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            cmbCourse.Text = cmbCourse.Text.Trim()
            cmbDepartment.Items.Clear()
            cmbDepartment.Text = ""
            cmbDepartment.Enabled = True
            cmbDepartment.Focus()
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select distinct RTRIM(Department) from Student where course = '" & cmbCourse.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            While rdr.Read()
                cmbDepartment.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        Reset()
    End Sub


    Private Sub btnNewRecord1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord1.Click
        Reset1()
    End Sub

    Private Sub btnUpdate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate1.Click
        Try

            For i As Integer = ListView2.Items.Count - 1 To 0 Step -1

                con = New OleDbConnection(cs)
                If ListView2.Items(i).Checked = True Then
                    txtStatus1.Text = "Yes"
                Else
                    txtStatus1.Text = "No"
                End If
                Dim cd As String = "update NoDues_Staff set Status='" & txtStatus1.Text & "' where StaffID= '" & ListView2.Items(i).SubItems(0).Text & "'"
                cmd = New OleDbCommand(cd)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Next
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate1.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If cmbDepartment1.Text = "" Then
            MessageBox.Show("Please select department", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cmbDepartment1.Focus()
            Return
        End If

        Try
            btnUpdate1.Enabled = True
            Dim _with1 = ListView2
            _with1.Clear()
            _with1.Columns.Add("Staff ID", 100, HorizontalAlignment.Left)
            _with1.Columns.Add("Staff Name", 250, HorizontalAlignment.Center)
            _with1.Columns.Add("Status", 0, HorizontalAlignment.Center)
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select Staff.StaffID,StaffName,Status from NoDues_Staff,Staff where NoDues_Staff.StaffID=Staff.StaffID and Department= '" & cmbDepartment1.Text & "' order by StaffName", con)
            rdr = cmd.ExecuteReader()
            While rdr.Read()
                Dim item = New ListViewItem()
                item.Text = rdr(0).ToString().Trim()
                item.SubItems.Add(rdr(1).ToString().Trim())
                item.SubItems.Add(rdr(2).ToString().Trim())
                ListView2.Items.Add(item)
                For i As Integer = ListView2.Items.Count - 1 To 0 Step -1
                    If ListView2.Items(i).SubItems(2).Text = "Yes" Then
                        ListView2.Items(i).Checked = True
                    Else
                        ListView2.Items(i).Checked = False
                    End If
                Next
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmStudentsNoDuesdRecord.Show()
    End Sub

    Private Sub btnGetData1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData1.Click
        frmStaffsNoDuesRecord.Show()
    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Reset()
        Reset1()
    End Sub
End Class