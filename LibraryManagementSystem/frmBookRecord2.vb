Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBookRecord2
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"

    Private Sub ExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcel.Click
        If dataGridView1.RowCount = Nothing Then
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

            rowsTotal = dataGridView1.RowCount - 1
            colsTotal = dataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dataGridView1.Rows(I).Cells(j).Value
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

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        If dataGridView2.RowCount = Nothing Then
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

            rowsTotal = dataGridView2.RowCount - 1
            colsTotal = dataGridView2.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dataGridView2.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dataGridView2.Rows(I).Cells(j).Value
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

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If dataGridView3.RowCount = Nothing Then
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

            rowsTotal = dataGridView3.RowCount - 1
            colsTotal = dataGridView3.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dataGridView3.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dataGridView3.Rows(I).Cells(j).Value
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

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        If dataGridView4.RowCount = Nothing Then
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

            rowsTotal = dataGridView4.RowCount - 1
            colsTotal = dataGridView4.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dataGridView4.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dataGridView4.Rows(I).Cells(j).Value
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

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If DataGridView5.RowCount = Nothing Then
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

            rowsTotal = DataGridView5.RowCount - 1
            colsTotal = DataGridView5.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView5.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView5.Rows(I).Cells(j).Value
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DataGridView6.RowCount = Nothing Then
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

            rowsTotal = DataGridView6.RowCount - 1
            colsTotal = DataGridView6.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView6.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView6.Rows(I).Cells(j).Value
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

    Private Sub cmbBookTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBookTitle.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where bookTitle='" & cmbBookTitle.Text & "' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBookTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBookTitle.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where bookTitle like '" & txtBookTitle.Text & "%' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView1.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        cmbBookTitle.Text = ""
        txtBookTitle.Text = ""
        dataGridView1.DataSource = Nothing
    End Sub

    Private Sub cmbAuthor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAuthor.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Author='" & cmbAuthor.Text & "' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView2.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtAuthor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAuthor.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Author like '" & txtAuthor.Text & "%' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView2.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button9.Click
        txtAuthor.Text = ""
        txtJointAuthors.Text = ""
        cmbAuthor.Text = ""
        dataGridView2.DataSource = Nothing
    End Sub

    Private Sub cmbAccessionNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccessionNo.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where AccessionNo='" & cmbAccessionNo.Text & "' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView3.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtAccessionNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccessionNo.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where AccessionNo like '" & txtAccessionNo.Text & "%' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView3.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        txtAccessionNo.Text = ""
        cmbAccessionNo.Text = ""
        dataGridView3.DataSource = Nothing
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Subject='" & cmbSubject.Text & "' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView4.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSubject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubject.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Subject like '" & txtSubject.Text & "%' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView4.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        txtSubject.Text = ""
        cmbSubject.Text = ""
        dataGridView4.DataSource = Nothing
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        txtPOP.Text = ""
        cmbPOP.Text = ""
        DataGridView5.DataSource = Nothing
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        txtDepartment.Text = ""
        cmbDepartment.Text = ""
        DataGridView6.DataSource = Nothing
    End Sub

    Private Sub tabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControl1.Click
        Clear()
    End Sub
    Sub Clear()
        DataGridView8.DataSource = Nothing
        cmbRfBook.Text = ""
        txtRFBooks.Text = ""
        DataGridView7.DataSource = Nothing
        txtPOP.Text = ""
        cmbPOP.Text = ""
        DataGridView5.DataSource = Nothing
        txtDepartment.Text = ""
        cmbDepartment.Text = ""
        DataGridView6.DataSource = Nothing
        txtSubject.Text = ""
        cmbSubject.Text = ""
        dataGridView4.DataSource = Nothing
        txtAccessionNo.Text = ""
        cmbAccessionNo.Text = ""
        dataGridView3.DataSource = Nothing
        txtAuthor.Text = ""
        txtJointAuthors.Text = ""
        cmbAuthor.Text = ""
        dataGridView2.DataSource = Nothing
        cmbBookTitle.Text = ""
        txtBookTitle.Text = ""
        dataGridView1.DataSource = Nothing
    End Sub

    Private Sub cmbPOP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPOP.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks as [No Of Books], AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date], Remarks from book where PlaceOfPublisher= '" & cmbPOP.Text & "' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            DataGridView5.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPOP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOP.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where PlaceOfPublisher like '" & txtPOP.Text & "%' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            DataGridView5.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDepartment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepartment.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Department like '" & txtDepartment.Text & "%' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            DataGridView6.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Department= '" & cmbDepartment.Text & "' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            DataGridView6.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillSubject()
        Try
            cmbSubject.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct Subject FROM Book where subject is not null", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSubject.DisplayMember = "Subject"
            cmbSubject.DataSource = dtable
            cmbSubject.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillBookTitle()
        Try
            cmbBookTitle.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct BookTitle FROM Book where BookTitle is not null", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbBookTitle.DisplayMember = "BookTitle"
            cmbBookTitle.DataSource = dtable
            cmbBookTitle.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillAuthor()
        Try
            cmbAuthor.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct Author FROM Book where Author is not null", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbAuthor.DisplayMember = "Author"
            cmbAuthor.DataSource = dtable
            cmbAuthor.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillAccessionNo()
        Try
            cmbAccessionNo.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct AccessionNo FROM Book where AccessionNo is not null", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbAccessionNo.DisplayMember = "AccessionNo"
            cmbAccessionNo.DataSource = dtable
            cmbAccessionNo.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillPOP()
        Try
            cmbPOP.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct PlaceOfPublisher FROM Book where PlaceOfPublisher is not null", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbPOP.DisplayMember = "PlaceOfPublisher"
            cmbPOP.DataSource = dtable
            cmbPOP.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillDepartment()
        Try
            cmbDepartment.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct Department FROM Book where Department is not null", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbDepartment.DisplayMember = "Department"
            cmbDepartment.DataSource = dtable
            cmbDepartment.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmBookRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillAccessionNo()
        fillAuthor()
        fillBookTitle()
        fillDepartment()
        fillPOP()
        fillSubject()
        fillReferenceBook()
        Clear()
    End Sub

    Private Sub dataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = dataGridView1.SelectedRows(0)
            Me.Hide()
            frmBookIssue.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmBookIssue.cmbAccessionNo.Text = dr.Cells(0).Value.ToString()
            frmBookIssue.txtBookTitle.Text = dr.Cells(1).Value.ToString()
            frmBookIssue.txtAuthor.Text = dr.Cells(2).Value.ToString()
            frmBookIssue.txtCategory.Text = dr.Cells(4).Value.ToString()
            frmBookIssue.txtISBN.Text = dr.Cells(7).Value.ToString()
            frmBookIssue.txtEdition.Text = dr.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dataGridView1.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub dataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataGridView2.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = dataGridView2.SelectedRows(0)
            Me.Hide()
            frmBookIssue.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmBookIssue.cmbAccessionNo.Text = dr.Cells(0).Value.ToString()
            frmBookIssue.txtBookTitle.Text = dr.Cells(1).Value.ToString()
            frmBookIssue.txtAuthor.Text = dr.Cells(2).Value.ToString()
            frmBookIssue.txtCategory.Text = dr.Cells(4).Value.ToString()
            frmBookIssue.txtISBN.Text = dr.Cells(7).Value.ToString()
            frmBookIssue.txtEdition.Text = dr.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dataGridView2_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dataGridView2.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dataGridView2.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dataGridView2.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub dataGridView3_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataGridView3.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = dataGridView3.SelectedRows(0)
            Me.Hide()
            frmBookIssue.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmBookIssue.cmbAccessionNo.Text = dr.Cells(0).Value.ToString()
            frmBookIssue.txtBookTitle.Text = dr.Cells(1).Value.ToString()
            frmBookIssue.txtAuthor.Text = dr.Cells(2).Value.ToString()
            frmBookIssue.txtCategory.Text = dr.Cells(4).Value.ToString()
            frmBookIssue.txtISBN.Text = dr.Cells(7).Value.ToString()
            frmBookIssue.txtEdition.Text = dr.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dataGridView3_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dataGridView3.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dataGridView3.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dataGridView3.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub dataGridView4_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataGridView4.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = dataGridView4.SelectedRows(0)
            Me.Hide()
            frmBookIssue.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmBookIssue.cmbAccessionNo.Text = dr.Cells(0).Value.ToString()
            frmBookIssue.txtBookTitle.Text = dr.Cells(1).Value.ToString()
            frmBookIssue.txtAuthor.Text = dr.Cells(2).Value.ToString()
            frmBookIssue.txtCategory.Text = dr.Cells(4).Value.ToString()
            frmBookIssue.txtISBN.Text = dr.Cells(7).Value.ToString()
            frmBookIssue.txtEdition.Text = dr.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dataGridView4_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dataGridView4.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dataGridView4.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dataGridView4.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub DataGridView5_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView5.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView5.SelectedRows(0)
            Me.Hide()
            frmBookIssue.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmBookIssue.cmbAccessionNo.Text = dr.Cells(0).Value.ToString()
            frmBookIssue.txtBookTitle.Text = dr.Cells(1).Value.ToString()
            frmBookIssue.txtAuthor.Text = dr.Cells(2).Value.ToString()
            frmBookIssue.txtCategory.Text = dr.Cells(4).Value.ToString()
            frmBookIssue.txtISBN.Text = dr.Cells(7).Value.ToString()
            frmBookIssue.txtEdition.Text = dr.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView5_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView5.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView5.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView5.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub DataGridView6_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView6.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView6.SelectedRows(0)
            Me.Hide()
            frmBookIssue.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmBookIssue.cmbAccessionNo.Text = dr.Cells(0).Value.ToString()
            frmBookIssue.txtBookTitle.Text = dr.Cells(1).Value.ToString()
            frmBookIssue.txtAuthor.Text = dr.Cells(2).Value.ToString()
            frmBookIssue.txtCategory.Text = dr.Cells(4).Value.ToString()
            frmBookIssue.txtISBN.Text = dr.Cells(7).Value.ToString()
            frmBookIssue.txtEdition.Text = dr.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DataGridView6_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView6.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView6.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView6.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub


    Private Sub txtJointAuthors_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJointAuthors.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where JointAuthors like '%" & txtJointAuthors.Text & "%' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            dataGridView2.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView7_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView7.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView7.SelectedRows(0)
            Me.Hide()
            frmBookIssue.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmBookIssue.cmbAccessionNo.Text = dr.Cells(0).Value.ToString()
            frmBookIssue.txtBookTitle.Text = dr.Cells(1).Value.ToString()
            frmBookIssue.txtAuthor.Text = dr.Cells(2).Value.ToString()
            frmBookIssue.txtCategory.Text = dr.Cells(4).Value.ToString()
            frmBookIssue.txtISBN.Text = dr.Cells(7).Value.ToString()
            frmBookIssue.txtEdition.Text = dr.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView7_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView7.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView7.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView7.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub DataGridView8_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView8.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView8.SelectedRows(0)
            Me.Hide()
            frmBookIssue.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmBookIssue.cmbAccessionNo.Text = dr.Cells(0).Value.ToString()
            frmBookIssue.txtBookTitle.Text = dr.Cells(1).Value.ToString()
            frmBookIssue.txtAuthor.Text = dr.Cells(2).Value.ToString()
            frmBookIssue.txtCategory.Text = dr.Cells(4).Value.ToString()
            frmBookIssue.txtISBN.Text = dr.Cells(7).Value.ToString()
            frmBookIssue.txtEdition.Text = dr.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView8_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView8.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView8.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView8.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DataGridView7.RowCount = Nothing Then
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

            rowsTotal = DataGridView7.RowCount - 1
            colsTotal = DataGridView7.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView7.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView7.Rows(I).Cells(j).Value
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

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If DataGridView8.RowCount = Nothing Then
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

            rowsTotal = DataGridView8.RowCount - 1
            colsTotal = DataGridView8.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView8.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView8.Rows(I).Cells(j).Value
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

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            DataGridView8.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        DataGridView8.DataSource = Nothing
    End Sub

    Private Sub txtRFBooks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRFBooks.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book where reference > 0 and BookTitle like '" & txtRFBooks.Text & "%' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            DataGridView7.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbRfBook_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRfBook.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book where reference > 0 and BookTitle = '" & cmbRfBook.Text & "' order by BookTitle", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Book")
            DataGridView7.DataSource = myDataSet.Tables("Book").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillReferenceBook()
        Try
            cmbRfBook.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct BookTitle FROM Book where Reference > 0", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbRfBook.DisplayMember = "BookTitle"
            cmbRfBook.DataSource = dtable
            cmbRfBook.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        cmbRfBook.Text = ""
        txtRFBooks.Text = ""
        DataGridView7.DataSource = Nothing
    End Sub
End Class