Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBookReturnRecord_Staff
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
        txtStaffName.Text = ""
        cmbStaffName.Text = ""
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Today
        DateTimePicker3.Text = Today
        DateTimePicker4.Text = Today
        DateTimePicker7.Text = Today
        DateTimePicker8.Text = Today
        DataGridView1.DataSource = Nothing
    End Sub
    Sub fillStaffName()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Staffname) FROM Staff,BookIssue_Staff,Return_Staff where Staff.StaffID=BookIssue_Staff.StaffID and BookIssue_Staff.TransactionID=Return_Staff.TransactionID", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbStaffName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbStaffName.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmBookIssueRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillStaffName()
    End Sub

    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBookName.TextChanged
         Try
                con = New OleDbConnection(cs)
                con.Open()
                cmd = New OleDbCommand("SELECT ReturnID as [Return ID],ReturnDate as [Return Date],Fine, BookIssue_Staff.TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department from Book,BookIssue_Staff,Staff,Return_Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID  and BookIssue_Staff.TransactionID=Return_Staff.TransactionID and Returndate Between #" & dtpDateFrom.Text & "# and #" & dtpDateTo.Text & "# and BookTitle like '" & txtBookName.Text & "%' order by Returndate desc ", con)
                Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim myDataSet As DataSet = New DataSet()
              
                myDA.Fill(myDataSet, "Return_Staff")
              
                DataGridView1.DataSource = myDataSet.Tables("Return_Staff").DefaultView
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ReturnID as [Return ID],ReturnDate as [Return Date],Fine, BookIssue_Staff.TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department from Book,BookIssue_Staff,Staff,Return_Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID  and BookIssue_Staff.TransactionID=Return_Staff.TransactionID and Returndate Between #" & DateTimePicker8.Text & "# and #" & DateTimePicker7.Text & "# order by Returndate desc ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Staff")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Staff")
            myDA.Fill(myDataSet, "Return_Staff")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Staff").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Staff").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Return_Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbStaffName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStaffName.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ReturnID as [Return ID],ReturnDate as [Return Date],Fine, BookIssue_Staff.TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department from Book,BookIssue_Staff,Staff,Return_Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID  and BookIssue_Staff.TransactionID=Return_Staff.TransactionID and ReturnDate Between #" & DateTimePicker4.Text & "# and #" & DateTimePicker3.Text & "# and StaffName= '" & cmbStaffName.Text & "' order by ReturnDate desc ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Staff")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Staff")
            myDA.Fill(myDataSet, "Return_Staff")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Staff").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Staff").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Return_Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtStaffName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaffName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ReturnID as [Return ID],ReturnDate as [Return Date],Fine, BookIssue_Staff.TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department from Book,BookIssue_Staff,Staff,Return_Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID  and BookIssue_Staff.TransactionID=Return_Staff.TransactionID and StaffName like '" & txtStaffName.Text & "%' order by Staffname ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Staff")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Staff")
            myDA.Fill(myDataSet, "Return_Staff")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Staff").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Staff").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Return_Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            frmBookReturn.Show()
            frmBookReturn.txtReturnID1.Text = dr.Cells(0).Value.ToString()
            frmBookReturn.dtpReturnDate1.Text = dr.Cells(1).Value.ToString()
            frmBookReturn.txtFine1.Text = dr.Cells(2).Value.ToString()
            frmBookReturn.txtTransactionID1.Text = dr.Cells(3).Value.ToString()
            frmBookReturn.dtpIssueDate1.Text = dr.Cells(4).Value.ToString()
            frmBookReturn.dtpDueDate1.Text = dr.Cells(5).Value.ToString()
            frmBookReturn.txtAccessionNo1.Text = dr.Cells(6).Value.ToString()
            frmBookReturn.TextBox2.Text = dr.Cells(6).Value.ToString()
            frmBookReturn.txtBookTitle1.Text = dr.Cells(7).Value.ToString()
            frmBookReturn.txtAuthor1.Text = dr.Cells(8).Value.ToString()
            frmBookReturn.txtCategory1.Text = dr.Cells(9).Value.ToString()
            frmBookReturn.txtISBN1.Text = dr.Cells(10).Value.ToString()
            frmBookReturn.txtEdition1.Text = dr.Cells(11).Value.ToString()
            frmBookReturn.txtStaffID.Text = dr.Cells(12).Value.ToString()
            frmBookReturn.txtStaffName.Text = dr.Cells(13).Value.ToString()
            frmBookReturn.txtDepartment1.Text = dr.Cells(14).Value.ToString()
            frmBookReturn.btnUpdate1.Enabled = True
            frmBookReturn.btnDelete1.Enabled = True
            frmBookReturn.btnSave1.Enabled = False
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ReturnID as [Return ID],ReturnDate as [Return Date],Fine, BookIssue_Staff.TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department from Book,BookIssue_Staff,Staff,Return_Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID  and BookIssue_Staff.TransactionID=Return_Staff.TransactionID and Returndate Between #" & DateTimePicker2.Text & "# and #" & DateTimePicker1.Text & "# and Fine > 0 order by Returndate desc ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BookIssue_Staff")
            myDA.Fill(myDataSet, "Book")
            myDA.Fill(myDataSet, "Staff")
            myDA.Fill(myDataSet, "Return_Staff")
            DataGridView1.DataSource = myDataSet.Tables("BookIssue_Staff").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Staff").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Return_Staff").DefaultView
            con.Close()
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
End Class