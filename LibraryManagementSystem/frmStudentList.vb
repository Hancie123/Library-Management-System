Imports System.Data.OleDb
Public Class frmStudentList
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
    Private Sub frmStudentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillSession()
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

    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Try
            cmbDepartment.Text = cmbDepartment.Text.Trim()
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

    Sub Reset()
        cmbSession.Text = ""
        cmbCourse.Text = ""
        cmbDepartment.Text = ""
        cmbYear.Text = ""
        cmbCourse.Enabled = False
        cmbDepartment.Enabled = False
        cmbYear.Enabled = False
        btnUpdate_record.Enabled = False
        listView1.Items.Clear()
    End Sub

    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        Reset()
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
        If cmbYear.Text = "" Then
            MessageBox.Show("Please select year", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cmbYear.Focus()
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

            cmd = New OleDbCommand("select Student.StudentID,StudentName,Status from StudentList,Student where StudentList.StudentID=Student.StudentID and Course = '" & cmbCourse.Text & "' and Department= '" & cmbDepartment.Text & "' and Stu_Session= '" & cmbSession.Text & "' and C_Year= '" & cmbYear.Text & "' order by StudentName", con)

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
                Dim cd As String = "update StudentList set Status=@d1,C_Year=@d2 where StudentID=@d3"
                cmd = New OleDbCommand(cd)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("d1", txtStatus.Text)
                cmd.Parameters.AddWithValue("d2", cmbYear.Text)
                cmd.Parameters.AddWithValue("d3", listView1.Items(i).SubItems(0).Text)
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmStudentListRecord.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("select Student.StudentID,StudentName,Status from StudentList,Student where StudentList.StudentID=Student.StudentID and Course = '" & cmbCourse.Text & "' and Department= '" & cmbDepartment.Text & "' and Stu_Session= '" & cmbSession.Text & "' order by StudentName", con)

            rdr = cmd.ExecuteReader()

            While rdr.Read()
                Dim item = New ListViewItem()
                item.Text = rdr(0).ToString().Trim()
                item.SubItems.Add(rdr(1).ToString().Trim())
                listView1.Items.Add(item)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class