Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmStaffRecord
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"

   
    Sub fillDepartment()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Department) FROM Staff", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbDepartment.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbDepartment.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            frmStaff.Show()
            frmStaff.txtStaffID.Text = dr.Cells(0).Value.ToString()
            frmStaff.txtStaffName.Text = dr.Cells(1).Value.ToString()
            If (dr.Cells(2).Value.ToString() = "Male") Then
                frmStaff.rbMale.Checked = True
            End If
            If (dr.Cells(2).Value.ToString() = "Female") Then
                frmStaff.rbFemale.Checked = True
            End If
            frmStaff.txtFatherName.Text = dr.Cells(3).Value.ToString()
            frmStaff.dtpDateOfJoining.Text = dr.Cells(4).Value.ToString()
            frmStaff.cmbDepartment.Text = dr.Cells(5).Value.ToString()
            frmStaff.txtTempAddress.Text = dr.Cells(6).Value.ToString()
            frmStaff.txtPermanentAddress.Text = dr.Cells(7).Value.ToString()
            frmStaff.dtpDOB.Text = dr.Cells(8).Value.ToString()
            frmStaff.txtPhoneNo.Text = dr.Cells(9).Value.ToString()
            frmStaff.txtMobileNo.Text = dr.Cells(10).Value.ToString()
            frmStaff.txtEmail.Text = dr.Cells(11).Value.ToString()
            Dim data As Byte() = DirectCast(dr.Cells(12).Value, Byte())
            Dim ms As New MemoryStream(data)
            frmStaff.Picture.Image = Image.FromStream(ms)
            frmStaff.btnUpdate_record.Enabled = True
            frmStaff.btnDelete.Enabled = True
            frmStaff.btnSave.Enabled = False
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
            cmd = New OleDbCommand("SELECT StaffID as [Staff ID], StaffName as [Staff Name],Gender, FatherName as [Father's Name],DateOfJoining as [Date Of Joining], Department, TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Staff order by Staffname", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Staff")
            DataGridView1.DataSource = myDataSet.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT StaffID as [Staff ID], StaffName as [Staff Name],Gender, FatherName as [Father's Name],DateOfJoining as [DateOfJoining], Department, TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Staff where department='" & cmbDepartment.Text & "' order by Staffname", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Staff")
            DataGridView1.DataSource = myDataSet.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtStaffName.Text = ""
        dtpDateFrom.Text = Today
        cmbDepartment.Text = ""
        dtpDateTo.Text = Today
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
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT StaffID as [Staff ID], StaffName as [Staff Name],Gender, FatherName as [Father's Name],DateOfJoining as [Date Of Joining], Department, TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Staff where DateOfJoining between #" & dtpDateFrom.Text & "# and #" & dtpDateTo.Text & "# order by Staffname", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Staff")
            DataGridView1.DataSource = myDataSet.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStaffName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaffName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT StaffID as [Staff ID], StaffName as [Staff Name],Gender, FatherName as [Father's Name],DateOfJoining as [Date Of Joining], Department, TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Staff where staffname like '" & txtStaffName.Text & "%' order by Staffname", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Staff")
            DataGridView1.DataSource = myDataSet.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmStaffRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDepartment()
        GetData()
    End Sub

    Private Sub dtpDateTo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpDateTo.Validating
        If (dtpDateFrom.Value.Date) > (dtpDateTo.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDateTo.Focus()
        End If
    End Sub
End Class