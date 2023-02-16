Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmJournalsMagzinesRecord1
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"


    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select ID, JM_Name as [Title], SubscriptionNo as [Subscription No], SubscriptionDate as [Subscription Date], Subscription, SubscriptionDateFrom as [Subscription Date From], SubscriptionDateTo as [Subscription Date To], BillNo as [Bill No], BillDate as [Bill Date], Amount, PaidOn as [Paid On], IssueNo as [Issue No],IssueDate as [Issue Date], Months as [Month], Jm_Year as [Year], Volume, V_num as [Number], DateOfReceipt as [Date Of Receipt], SupplierName as [Supplier Name], Department, Remarks from JournalAndMagzines  where JM_name like '" & txtName.Text & "%' order by JM_Name", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "JournalAndMagzines")
            DataGridView1.DataSource = myDataSet.Tables("JournalAndMagzines").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmJournalsMagzinesRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDepartment()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT   ID, JM_Name as [Title], SubscriptionNo as [Subscription No], SubscriptionDate as [Subscription Date], Subscription, SubscriptionDateFrom as [Subscription Date From], SubscriptionDateTo as [Subscription Date To], BillNo as [Bill No], BillDate as [Bill Date], Amount, PaidOn as [Paid On], IssueNo as [Issue No],IssueDate as [Issue Date], Months as [Month], Jm_Year as [Year], Volume, V_num as [Number], DateOfReceipt as [Date Of Receipt], SupplierName as [Supplier Name], Department, Remarks from JournalAndMagzines  where IssueDate between #" & dtpDateFrom.Text & "# and #" & dtpDateTo.Text & "#  order by IssueDate desc", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "JournalAndMagzines")
            DataGridView1.DataSource = myDataSet.Tables("JournalAndMagzines").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT   ID, JM_Name as [Title], SubscriptionNo as [Subscription No], SubscriptionDate as [Subscription Date], Subscription, SubscriptionDateFrom as [Subscription Date From], SubscriptionDateTo as [Subscription Date To], BillNo as [Bill No], BillDate as [Bill Date], Amount, PaidOn as [Paid On], IssueNo as [Issue No],IssueDate as [Issue Date], Months as [Month], Jm_Year as [Year], Volume, V_num as [Number], DateOfReceipt as [Date Of Receipt], SupplierName as [Supplier Name], Department, Remarks from JournalAndMagzines  where DateOfReceipt between #" & DateTimePicker2.Text & "# and #" & DateTimePicker1.Text & "#  order by DateOfReceipt desc", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "JournalAndMagzines")
            DataGridView1.DataSource = myDataSet.Tables("JournalAndMagzines").DefaultView
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
        txtName.Text = ""
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Today
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DateTimePicker3.Text = Today
        DateTimePicker4.Text = Today
        DateTimePicker5.Text = Today
        DateTimePicker6.Text = Today
        cmbDepartment.Text = ""
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT   ID, JM_Name as [Title], SubscriptionNo as [Subscription No], SubscriptionDate as [Subscription Date], Subscription, SubscriptionDateFrom as [Subscription Date From], SubscriptionDateTo as [Subscription Date To], BillNo as [Bill No], BillDate as [Bill Date], Amount, PaidOn as [Paid On], IssueNo as [Issue No],IssueDate as [Issue Date], Months as [Month], Jm_Year as [Year], Volume, V_num as [Number], DateOfReceipt as [Date Of Receipt], SupplierName as [Supplier Name], Department, Remarks from JournalAndMagzines  where BillDate between #" & DateTimePicker4.Text & "# and #" & DateTimePicker3.Text & "#  order by BillDate desc", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "JournalAndMagzines")
            DataGridView1.DataSource = myDataSet.Tables("JournalAndMagzines").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DateTimePicker3_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker3.Validating
        If (DateTimePicker4.Value.Date) > (DateTimePicker3.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker3.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT   ID, JM_Name as [Title], SubscriptionNo as [Subscription No], SubscriptionDate as [Subscription Date], Subscription, SubscriptionDateFrom as [Subscription Date From], SubscriptionDateTo as [Subscription Date To], BillNo as [Bill No], BillDate as [Bill Date], Amount, PaidOn as [Paid On], IssueNo as [Issue No],IssueDate as [Issue Date], Months as [Month], Jm_Year as [Year], Volume, V_num as [Number], DateOfReceipt as [Date Of Receipt], SupplierName as [Supplier Name], Department, Remarks from JournalAndMagzines  where SubscriptionDateTo between #" & DateTimePicker6.Text & "# and #" & DateTimePicker5.Text & "#  order by SubscriptionDateTo ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "JournalAndMagzines")
            DataGridView1.DataSource = myDataSet.Tables("JournalAndMagzines").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DateTimePicker5_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker5.Validating
        If (DateTimePicker6.Value.Date) > (DateTimePicker5.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker5.Focus()
        End If
    End Sub
    Sub fillDepartment()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Department) FROM JournalAndMagzines", CN)
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
    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select ID, JM_Name as [Title], SubscriptionNo as [Subscription No], SubscriptionDate as [Subscription Date], Subscription, SubscriptionDateFrom as [Subscription Date From], SubscriptionDateTo as [Subscription Date To], BillNo as [Bill No], BillDate as [Bill Date], Amount, PaidOn as [Paid On], IssueNo as [Issue No],IssueDate as [Issue Date], Months as [Month], Jm_Year as [Year], Volume, V_num as [Number], DateOfReceipt as [Date Of Receipt], SupplierName as [Supplier Name], Department, Remarks from JournalAndMagzines  where Department= '" & cmbDepartment.Text & "' order by Department", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "JournalAndMagzines")
            DataGridView1.DataSource = myDataSet.Tables("JournalAndMagzines").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class