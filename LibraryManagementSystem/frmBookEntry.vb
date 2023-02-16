Imports System.Data.OleDb
Public Class frmBookEntry
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"
    Sub fillSupplier()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(SupplierName) FROM Supplier", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSupplierName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSupplierName.Items.Add(drow(0).ToString())
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
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Departmentname) FROM Department", CN)
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
    Sub fillSubject()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Subject) FROM Book", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSubject.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSubject.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBookRecord1.Show()
    End Sub
    Sub Reset()
        txtAccessionNo.Text = ""
        txtAlmiraPosition.Text = ""
        txtAuthor.Text = ""
        txtBarcode.Text = ""
        txtBookTitle.Text = ""
        txtCD.Text = ""
        txtClassNo.Text = ""
        txtEdition.Text = ""
        txtISBN.Text = ""
        txtJointAuthor.Text = ""
        txtNoOfBooks.Text = ""
        txtPlaceOfPublisher.Text = ""
        txtPrice.Text = ""
        txtPublisherName.Text = ""
        txtPublishingYear.Text = ""
        txtReference.Text = ""
        txtRemarks.Text = ""
        txtVolume.Text = ""
        cmbDepartment.SelectedIndex = -1
        cmbSubject.Text = ""
        cmbSupplierName.Text = ""
        dtpBillDate.Text = Today
        btnDelete.Enabled = False
        btnUpdate_record.Enabled = False
        btnSave.Enabled = True
        txtAccessionNo.Focus()
    End Sub
    Sub AutocompleteBookTitle()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct BookTitle FROM Book", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "ds")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("BookTitle").ToString())
            Next
            txtBookTitle.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBookTitle.AutoCompleteCustomSource = col
            txtBookTitle.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
  
    Sub AutocompleteJointAuthors()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct JointAuthors FROM Book", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "ds")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("JointAuthors").ToString())
            Next
            txtJointAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtJointAuthor.AutoCompleteCustomSource = col
            txtJointAuthor.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub AutocompleteAuthor()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct Author FROM Book", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "ds")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("Author").ToString())
            Next
            txtAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtAuthor.AutoCompleteCustomSource = col
            txtAuthor.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub AutocompletePublisher()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct Publisher FROM Book", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "ds")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("Publisher").ToString())
            Next
            txtPublisherName.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtPublisherName.AutoCompleteCustomSource = col
            txtPublisherName.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub AutocompletePlaceOfPublisher()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct PlaceOfPublisher FROM Book", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "ds")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("PlaceOfPublisher").ToString())
            Next
            txtPlaceOfPublisher.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtPlaceOfPublisher.AutoCompleteCustomSource = col
            txtPlaceOfPublisher.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub AutocompleteAccessionNo()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct AccessionNo FROM Book", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "ds")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("AccessionNo").ToString())
            Next
            txtAccessionNo.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtAccessionNo.AutoCompleteCustomSource = col
            txtAccessionNo.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmBookEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDepartment()
        fillSubject()
        fillSupplier()
        AutocompleteAccessionNo()
        AutocompleteBookTitle()
        AutocompleteJointAuthors()
        AutocompletePlaceOfPublisher()
        AutocompletePublisher()
        AutocompleteAuthor()
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtAccessionNo.Text)) = 0 Then
                MessageBox.Show("Please enter Accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAccessionNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBookTitle.Text)) = 0 Then
                MessageBox.Show("Please enter book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBookTitle.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAuthor.Text)) = 0 Then
                MessageBox.Show("Please enter author name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAuthor.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSubject.Text)) = 0 Then
                MessageBox.Show("Please enetr/select subject", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbSubject.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(txtEdition.Text)) = 0 Then
                MessageBox.Show("Please enter edition", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEdition.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPublisherName.Text)) = 0 Then
                MessageBox.Show("Please enter publisher name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPublisherName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPlaceOfPublisher.Text)) = 0 Then
                MessageBox.Show("Please enter place of  publisher", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPlaceOfPublisher.Focus()
                Exit Sub
            End If
            If Len(Trim(txtNoOfBooks.Text)) = 0 Then
                MessageBox.Show("Please enter no. of books", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNoOfBooks.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAlmiraPosition.Text)) = 0 Then
                MessageBox.Show("Please enter almira position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAlmiraPosition.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPrice.Text)) = 0 Then
                MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrice.Focus()
                Exit Sub
            End If
            If (txtReference.Text = "") Then
                txtReference.Text = 0
            End If
            If Len(Trim(cmbSupplierName.Text)) = 0 Then
                MessageBox.Show("Please select supplier", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbSupplierName.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select AccessionNo from Book where AccessionNo='" & txtAccessionNo.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Accession no. already exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAccessionNo.Text = ""
                txtAccessionNo.Focus()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into Book(AccessionNo, BookTitle, Author, JointAuthors, Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo, Publisher, PlaceOfPublisher, CD,PublishingYear, Reference, NoOfBooks, AlmiraPosition, Price, BillDate, Remarks,SupplierName) VALUES('" & txtAccessionNo.Text & "','" & txtBookTitle.Text & "','" & txtAuthor.Text & "','" & txtJointAuthor.Text & "','" & cmbSubject.Text & "','" & cmbDepartment.Text & "','" & txtBarcode.Text & "','" & txtISBN.Text & "','" & txtVolume.Text & "','" & txtEdition.Text & "','" & txtClassNo.Text & "','" & txtPublisherName.Text & "','" & txtPlaceOfPublisher.Text & "','" & txtCD.Text & "','" & txtPublishingYear.Text & "'," & txtReference.Text & "," & txtNoOfBooks.Text & ",'" & txtAlmiraPosition.Text & "'," & txtPrice.Text & ",#" & dtpBillDate.Text & "#,'" & txtRemarks.Text & "','" & cmbSupplierName.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fillSubject()
            AutocompleteAccessionNo()
            AutocompleteBookTitle()
            AutocompleteJointAuthors()
            AutocompletePlaceOfPublisher()
            AutocompletePublisher()
            AutocompleteAuthor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from Book where AccessionNo= '" & txtAccessionNo.Text & "'"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fillSubject()
                Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fillSubject()
                AutocompleteAccessionNo()
                AutocompleteBookTitle()
                AutocompleteJointAuthors()
                AutocompletePlaceOfPublisher()
                AutocompletePublisher()
                AutocompleteAuthor()
                Reset()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        Try
            If Len(Trim(txtAccessionNo.Text)) = 0 Then
                MessageBox.Show("Please enter Accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAccessionNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBookTitle.Text)) = 0 Then
                MessageBox.Show("Please enter book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBookTitle.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAuthor.Text)) = 0 Then
                MessageBox.Show("Please enter author name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAuthor.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSubject.Text)) = 0 Then
                MessageBox.Show("Please enetr/select subject", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbSubject.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(txtEdition.Text)) = 0 Then
                MessageBox.Show("Please enter edition", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEdition.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPublisherName.Text)) = 0 Then
                MessageBox.Show("Please enter publisher name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPublisherName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtNoOfBooks.Text)) = 0 Then
                MessageBox.Show("Please enter no. of books", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNoOfBooks.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAlmiraPosition.Text)) = 0 Then
                MessageBox.Show("Please enter almira position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAlmiraPosition.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPrice.Text)) = 0 Then
                MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrice.Focus()
                Exit Sub
            End If
            If (txtReference.Text = "") Then
                txtReference.Text = 0
            End If
            If Len(Trim(cmbSupplierName.Text)) = 0 Then
                MessageBox.Show("Please select supplier", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbSupplierName.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Book set AccessionNo='" & txtAccessionNo.Text & "', BookTitle='" & txtBookTitle.Text & "',Author='" & txtAuthor.Text & "',JointAuthors='" & txtJointAuthor.Text & "',Subject='" & cmbSubject.Text & "',Department='" & cmbDepartment.Text & "',Barcode='" & txtBarcode.Text & "',ISBN='" & txtISBN.Text & "',Volume='" & txtVolume.Text & "',Edition='" & txtEdition.Text & "',ClassNo='" & txtClassNo.Text & "',Publisher='" & txtPublisherName.Text & "',PlaceOfPublisher='" & txtPlaceOfPublisher.Text & "',CD='" & txtCD.Text & "',PublishingYear='" & txtPublishingYear.Text & "',Reference=" & txtReference.Text & ",NoOfBooks=" & txtNoOfBooks.Text & ",AlmiraPosition='" & txtAlmiraPosition.Text & "',Price=" & txtPrice.Text & ",BillDate=#" & dtpBillDate.Text & "#,Remarks='" & txtRemarks.Text & "',SupplierName='" & cmbSupplierName.Text & "' where AccessionNo='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully updated", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
            fillSubject()
            AutocompleteAccessionNo()
            AutocompleteBookTitle()
            AutocompleteJointAuthors()
            AutocompletePlaceOfPublisher()
            AutocompletePublisher()
            AutocompleteAuthor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPublishingYear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPublishingYear.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCD.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtReference_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReference.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoOfBooks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoOfBooks.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmBookRecord1.Show()
        frmBookRecord1.Clear()
        frmBookRecord1.fillAccessionNo()
        frmBookRecord1.fillAuthor()
        frmBookRecord1.fillDepartment()
        frmBookRecord1.fillBookTitle()
        frmBookRecord1.fillPOP()
        frmBookRecord1.fillSubject()
        frmBookRecord1.fillReferenceBook()
    End Sub
End Class