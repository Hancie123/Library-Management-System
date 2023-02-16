Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBookIssueRecord1
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
        txtBookName.Text = ""
        txtBookName1.Text = ""
        txtStudentName.Text = ""
        cmbStudentName.Text = ""
        cmbStudentName1.Text = ""
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Today
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DateTimePicker3.Text = Today
        DateTimePicker4.Text = Today
        DateTimePicker5.Text = Today
        DateTimePicker6.Text = Today
        DateTimePicker7.Text = Today
        DateTimePicker8.Text = Today
        DataGridView1.DataSource = Nothing
    End Sub
    Sub fillStudentName()
        Try
            cmbStudentName.DataSource = Nothing
            cmbStudentName1.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct Studentname FROM Student,BookIssue_Student where Student.StudentID=BookIssue_Student.StudentID", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbStudentName.DisplayMember = "StudentName"
            cmbStudentName.DataSource = dtable
            cmbStudentName.SelectedIndex = -1
            cmbStudentName1.DisplayMember = "StudentName"
            cmbStudentName1.DataSource = dtable
            cmbStudentName1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmBookIssueRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillStudentName()
        Reset()
    End Sub

    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBookName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and Issuedate Between #" & dtpDateFrom.Text & "# and #" & dtpDateTo.Text & "# and BookTitle like '" & txtBookName.Text & "%' order by Issuedate desc ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Student")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Student").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
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

    Private Sub txtBookName1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBookName1.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and DueDate Between #" & DateTimePicker2.Text & "# and #" & DateTimePicker1.Text & "# and BookTitle like '" & txtBookName1.Text & "%' order by DueDate desc ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Student")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Student").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and IssueDate Between #" & DateTimePicker8.Text & "# and #" & DateTimePicker7.Text & "#  order by IssueDate desc ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Student")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Student").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbStudentName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStudentName.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and IssueDate Between #" & DateTimePicker4.Text & "# and #" & DateTimePicker3.Text & "# and StudentName= '" & cmbStudentName.Text & "' order by IssueDate desc ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Student")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Student").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cmbStudentName1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStudentName1.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and DueDate Between #" & DateTimePicker6.Text & "# and #" & DateTimePicker5.Text & "# and StudentName= '" & cmbStudentName1.Text & "' order by DueDate desc ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Student")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Student").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStudentName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID  and StudentName like '" & txtStudentName.Text & "%' order by Studentname ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Student")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Student").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
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

    Private Sub dtpDateTo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpDateTo.Validating
        If (dtpDateFrom.Value.Date) > (dtpDateTo.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDateTo.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker1.Validating
        If (DateTimePicker2.Value.Date) > (DateTimePicker1.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker7_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker7.Validating
        If (DateTimePicker8.Value.Date) > (DateTimePicker7.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker7.Focus()
        End If
    End Sub

    Private Sub DateTimePicker3_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker3.Validating
        If (DateTimePicker4.Value.Date) > (DateTimePicker3.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker3.Focus()
        End If
    End Sub

    Private Sub DateTimePicker5_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker5.Validating
        If (DateTimePicker6.Value.Date) > (DateTimePicker5.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker5.Focus()
        End If
    End Sub
End Class