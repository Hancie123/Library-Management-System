Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmStudentsCardRecord
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
    Private Sub frmCards_Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Dim ct As String = "select distinct RTRIM(Department) from Student,Cards_Student where Student.StudentID=Cards_Student.StudentID and course = '" & cmbCourse.Text & "'"
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

    Private Sub cmbSession_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSession.SelectedIndexChanged
        Try
            cmbCourse.Items.Clear()
            cmbCourse.Text = ""
            cmbCourse.Enabled = True
            cmbCourse.Focus()
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select distinct RTRIM(Course) from Student,Cards_Student where Student.StudentID=Cards_Student.StudentID and Stu_Session= '" & cmbSession.Text & "'"
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
        txtStudentName.Text = ""
        cmbCourse.Enabled = False
        cmbDepartment.Enabled = False
        DataGridView1.Rows.Clear()
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


        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select Student.StudentID,StudentName,Status from Cards_Student,Student where Cards_Student.StudentID=Student.StudentID and Course = '" & cmbCourse.Text & "' and Department= '" & cmbDepartment.Text & "' and Stu_Session= '" & cmbSession.Text & "' order by StudentName ", con)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub txtStudentName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select Student.StudentID,StudentName,Status from Cards_Student,Student where Cards_Student.StudentID=Student.StudentID and Studentname like '" & txtStudentName.Text & "%' order by StudentName ", con)
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

    Private Sub txtStudentName_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select Student.StudentID,StudentName,Status from Cards_Student,Student where Cards_Student.StudentID=Student.StudentID and StudentName like '" & txtStudentName.Text & "%' order by StudentName ", con)
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

    Private Sub DataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub
End Class