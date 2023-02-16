Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmStudentRecord
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"

    Private Sub frmStudentRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCourse()
        fillDepartment()
        fillSession()
        GetData()
    End Sub
    Sub fillSession()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct (stu_session) FROM Student", CN)
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
    Sub fillCourse()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Course) FROM Student", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCourse.Items.Clear()
            cmbCourse1.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCourse.Items.Add(drow(0).ToString())
                cmbCourse1.Items.Add(drow(0).ToString())
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
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Department) FROM Student", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbDepartment.Items.Clear()
            cmbDepartment1.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbDepartment.Items.Add(drow(0).ToString())
                cmbDepartment1.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            frmStudent.Show()
            frmStudent.txtStudentID.Text = dr.Cells(0).Value.ToString()
            frmStudent.txtStudentName.Text = dr.Cells(1).Value.ToString()
            If (dr.Cells(2).Value.ToString() = "Male") Then
                frmStudent.rbMale.Checked = True
            End If
            If (dr.Cells(2).Value.ToString() = "Female") Then
                frmStudent.rbFemale.Checked = True
            End If
            frmStudent.txtFatherName.Text = dr.Cells(3).Value.ToString()
            frmStudent.cmbCourse.Text = dr.Cells(4).Value.ToString()
            frmStudent.cmbDepartment.Text = dr.Cells(5).Value.ToString()
            frmStudent.txtSession.Text = dr.Cells(6).Value.ToString()
            frmStudent.txtRollNo.Text = dr.Cells(7).Value.ToString()
            frmStudent.txtReceiptNo.Text = dr.Cells(8).Value.ToString()
            frmStudent.txtTempAddress.Text = dr.Cells(9).Value.ToString()
            frmStudent.txtPermanentAddress.Text = dr.Cells(10).Value.ToString()
            frmStudent.dtpDOB.Text = dr.Cells(11).Value.ToString()
            frmStudent.txtPhoneNo.Text = dr.Cells(12).Value.ToString()
            frmStudent.txtMobileNo.Text = dr.Cells(13).Value.ToString()
            frmStudent.txtEmail.Text = dr.Cells(14).Value.ToString()
            Dim data As Byte() = DirectCast(dr.Cells(15).Value, Byte())
            Dim ms As New MemoryStream(data)
            frmStudent.Picture.Image = Image.FromStream(ms)
            frmStudent.btnUpdate_record.Enabled = True
            frmStudent.btnDelete.Enabled = True
            frmStudent.btnSave.Enabled = False
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
    Public Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student  order by StudentName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")
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
            cmd = New OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student where studentname like '" & txtStudentName.Text & "%' order by StudentName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student where Course= '" & cmbCourse.Text & "' order by StudentName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student where department= '" & cmbDepartment.Text & "' order by StudentName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtStudentName.Text = ""
        cmbCourse.Text = ""
        cmbDepartment.Text = ""
        cmbCourse1.Text = ""
        cmbDepartment1.Text = ""
        cmbSession.Text = ""
        GetData()
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Len(Trim(cmbSession.Text)) = 0 Then
                MessageBox.Show("Please select session", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbSession.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCourse1.Text)) = 0 Then
                MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCourse1.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment1.Text)) = 0 Then
                MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment1.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student where department= '" & cmbDepartment1.Text & "' and Course='" & cmbCourse1.Text & "' and Stu_Session='" & cmbSession.Text & "' order by StudentName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class