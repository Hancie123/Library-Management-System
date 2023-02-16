Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmProjectRecord1
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"
    Sub fillCourse()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Course) FROM Project", CN)
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where SubmissionDate between #" & DateTimePicker2.Text & "# and #" & DateTimePicker1.Text & "#  order by SubmissionDate desc", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Project")
            DataGridView1.DataSource = myDataSet.Tables("Project").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
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
    Public Sub Reset()
        cmbCourse.Text = ""
        cmbYear.Text = ""
        txtProjectTitle.Text = ""
        cmbYear.Enabled = False
        txtStudentName.Text = ""
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DataGridView1.DataSource = Nothing
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
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

    Private Sub txtStudentName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where StudentName like '%" & txtStudentName.Text & "%' order by StudentName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Project")
            DataGridView1.DataSource = myDataSet.Tables("Project").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
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
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptProject 'The report you created.
            Dim myConnection As OleDbConnection
            Dim MyCommand As New OleDbCommand()
            Dim myDA As New OleDbDataAdapter()
            Dim myDS As New LMS_DBDataSet 'The DataSet you created.
            myConnection = New OleDbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT * from Project where Course='" & cmbCourse.Text & "' and Proj_Year='" & cmbYear.Text & "' order by ProjectName"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Project")
            rpt.SetDataSource(myDS)
            frmProjectReport.CrystalReportViewer1.ReportSource = rpt
            frmProjectReport.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub

    Private Sub frmProjectRecord1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCourse()
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            cmbCourse.Text = cmbCourse.Text.Trim()
            cmbYear.Items.Clear()
            cmbYear.Text = ""
            cmbYear.Enabled = True
            cmbCourse.Focus()
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select distinct RTRIM(Proj_Year) from Project where course = '" & cmbCourse.Text & "'"
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

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
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
            cmd = New OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where course='" & cmbCourse.Text & "' and Proj_Year='" & cmbYear.Text & "' order by ProjectName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Project")
            DataGridView1.DataSource = myDataSet.Tables("Project").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptProject 'The report you created.
            Dim myConnection As OleDbConnection
            Dim MyCommand As New OleDbCommand()
            Dim myDA As New OleDbDataAdapter()
            Dim myDS As New LMS_DBDataSet 'The DataSet you created.
            myConnection = New OleDbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT * from Project where  SubmissionDate between #" & DateTimePicker2.Text & "# and #" & DateTimePicker1.Text & "#  order by SubmissionDate desc "
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Project")
            rpt.SetDataSource(myDS)
            frmProjectReport.CrystalReportViewer1.ReportSource = rpt
            frmProjectReport.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptProject 'The report you created.
            Dim myConnection As OleDbConnection
            Dim MyCommand As New OleDbCommand()
            Dim myDA As New OleDbDataAdapter()
            Dim myDS As New LMS_DBDataSet 'The DataSet you created.
            myConnection = New OleDbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT * from Project where StudentName like '%" & txtStudentName.Text & "%' order by StudentName "
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Project")
            rpt.SetDataSource(myDS)
            frmProjectReport.CrystalReportViewer1.ReportSource = rpt
            frmProjectReport.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DateTimePicker1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker1.Validating
        If (DateTimePicker2.Value.Date) > (DateTimePicker1.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub txtProjectTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProjectTitle.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where ProjectName like '" & txtProjectTitle.Text & "%' order by Projectname", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Project")
            DataGridView1.DataSource = myDataSet.Tables("Project").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptProject 'The report you created.
            Dim myConnection As OleDbConnection
            Dim MyCommand As New OleDbCommand()
            Dim myDA As New OleDbDataAdapter()
            Dim myDS As New LMS_DBDataSet 'The DataSet you created.
            myConnection = New OleDbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT * from Project where Projectname like '" & txtProjectTitle.Text & "%' order by Projectname"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Project")
            rpt.SetDataSource(myDS)
            frmProjectReport.CrystalReportViewer1.ReportSource = rpt
            frmProjectReport.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class