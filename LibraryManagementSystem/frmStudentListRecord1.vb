Imports System.Data.OleDb
Public Class frmStudentListRecord1
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
            Dim ct As String = "select distinct RTRIM(Department) from Student,StudentList where Student.StudentID=StudentList.StudentID and course = '" & cmbCourse.Text & "'"
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
            Dim ct As String = "select distinct RTRIM(C_Year) from StudentList,Student where StudentList.StudentID=Student.StudentID and course = '" & cmbCourse.Text & "'"
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
            Dim ct As String = "select distinct RTRIM(Course) from Student,StudentList where Student.StudentID=StudentList.StudentID and Stu_Session= '" & cmbSession.Text & "'"
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
        btnViewReport.Enabled = True
        listView1.Items.Clear()
    End Sub

    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
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
            Dim _with1 = listView1
            _with1.Clear()
            _with1.Columns.Add("Student ID", 100, HorizontalAlignment.Left)
            _with1.Columns.Add("Student Name", 250, HorizontalAlignment.Center)
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("select Student.StudentID,StudentName from StudentList,Student where StudentList.StudentID=Student.StudentID and Course = '" & cmbCourse.Text & "' and Department= '" & cmbDepartment.Text & "' and Stu_Session= '" & cmbSession.Text & "' and C_Year= '" & cmbYear.Text & "' and Status='Yes' order by StudentName", con)

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

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        Try
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

            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptStudentList 'The report you created.
            Dim myConnection As OleDbConnection
            Dim MyCommand As New OleDbCommand()
            Dim myDA As New OleDbDataAdapter()
            Dim myDS As New Student_DBDataSet 'The DataSet you created.
            myConnection = New OleDbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select Student.StudentID,StudentName,Course,Department,Stu_Session,C_Year from StudentList,Student where StudentList.StudentID=Student.StudentID and Course = '" & cmbCourse.Text & "' and Department= '" & cmbDepartment.Text & "' and Stu_Session= '" & cmbSession.Text & "' and C_Year= '" & cmbYear.Text & "' and Status='Yes' order by StudentName"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Student")
            myDA.Fill(myDS, "StudentList")
            rpt.SetDataSource(myDS)
            frmStudentsReport.CrystalReportViewer1.ReportSource = rpt
            frmStudentsReport.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub
End Class