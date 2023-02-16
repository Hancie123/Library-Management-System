Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Public Class frmBookIssue

    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"
    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
    Sub Reset()
        cmbStudentID.Text = ""
        txtTransactionID.Text = ""
        txtAuthor.Text = ""
        txtBookTitle.Text = ""
        txtCategory.Text = ""
        txtDepartment.Text = ""
        txtEdition.Text = ""
        txtISBN.Text = ""
        txtCourse.Text = ""
        txtStudentName.Text = ""
        cmbAccessionNo.Text = ""
        dtpDueDate.Text = ""
        dtpIssueDate.Text = ""
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate_record.Enabled = False
    End Sub
    Sub Reset1()
        cmbStaffID.Text = ""
        txtTransactionID1.Text = ""
        txtAuthor1.Text = ""
        txtBookTitle1.Text = ""
        txtCategory1.Text = ""
        txtDepartment1.Text = ""
        txtEdition1.Text = ""
        txtISBN1.Text = ""
        txtStaffName.Text = ""
        cmbAccessionNo1.Text = ""
        dtpDueDate1.Text = ""
        dtpIssueDate1.Text = ""
        btnSave1.Enabled = True
        btnDelete1.Enabled = False
        btnUpdate1.Enabled = False
    End Sub
    Private Sub frmBookIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillANo()
        fillANo1()
        fillStudentID()
        fillStaffID()
        Reset()
        Reset1()
    End Sub

    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from BookIssue_Student where TransactionID = '" & txtTransactionID.Text & "'"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Public Sub DeleteRecord1()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from BookIssue_Staff where TransactionID = '" & txtTransactionID1.Text & "'"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset1()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset1()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillANo()
        Try
            cmbAccessionNo.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct AccessionNo FROM Book", CN)
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
    Sub fillANo1()
        Try
            cmbAccessionNo1.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct AccessionNo FROM Book ", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbAccessionNo1.DisplayMember = "AccessionNo"
            cmbAccessionNo1.DataSource = dtable
            cmbAccessionNo1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmStudentRecord3.Show()
        frmStudentRecord3.txtStudentName.Text = ""
        frmStudentRecord3.cmbCourse.Text = ""
        frmStudentRecord3.cmbDepartment.Text = ""
        frmStudentRecord3.cmbCourse1.Text = ""
        frmStudentRecord3.cmbDepartment1.Text = ""
        frmStudentRecord3.cmbSession.Text = ""
        frmStudentRecord3.GetData()
    End Sub

    Private Sub cmbAccessionNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccessionNo.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select BookTitle,Author,Subject,ISBN,Edition from book where AccessionNo='" & cmbAccessionNo.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                txtBookTitle.Text = rdr("BookTitle").ToString()
                txtAuthor.Text = rdr("Author").ToString()
                txtCategory.Text = rdr("Subject").ToString()
                txtISBN.Text = rdr("ISBN").ToString()
                txtEdition.Text = rdr("Edition").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpIssueDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpIssueDate.ValueChanged
        dtpDueDate.Text = dtpIssueDate.Value.Date.AddDays(4)
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

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        Try
            If (cmbStudentID.Text = "") Then
                MessageBox.Show("Please retrieve student id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbStudentID.Focus()
                Exit Sub
            End If
            If (txtStudentName.Text = "") Then
                MessageBox.Show("Please retrieve student name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbAccessionNo.Text)) = 0 Then
                MessageBox.Show("Please select accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbAccessionNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBookTitle.Text)) = 0 Then
                MessageBox.Show("Please retrieve book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBookTitle.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select NoOfBooks from Book where AccessionNo='" & cmbAccessionNo.Text & "' and NoOfBooks <=0"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Book is not available for issue", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Bookissue_student set IssueDate=#" & dtpIssueDate.Text & "#,DueDate=#" & dtpDueDate.Text & "#,AccessionNo='" & cmbAccessionNo.Text & "',StudentID= '" & cmbStudentID.Text & "' where TransactionID='" & txtTransactionID.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            If (cmbAccessionNo.Text <> TextBox1.Text) And (txtStatus.Text = "Issued") Then
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb1 As String = "Update book set NoOfBooks = NoOfBooks + 1 where AccessionNo='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb2 As String = "Update book set NoOfBooks = NoOfBooks - 1 where AccessionNo='" & cmbAccessionNo.Text & "'"
                cmd = New OleDbCommand(cb2)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
            End If
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If (cmbStudentID.Text = "") Then
                MessageBox.Show("Please retrieve student id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbStudentID.Focus()
                Exit Sub
            End If
            If (txtStudentName.Text = "") Then
                MessageBox.Show("Please retrieve student name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbAccessionNo.Text)) = 0 Then
                MessageBox.Show("Please select accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbAccessionNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBookTitle.Text)) = 0 Then
                MessageBox.Show("Please retrieve book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBookTitle.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select NoOfBooks from Book where AccessionNo='" & cmbAccessionNo.Text & "' and NoOfBooks <=0"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Book is not available for issue", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            dtpDueDate.Text = dtpIssueDate.Value.Date.AddDays(4)
            txtTransactionID.Text = "T-" & GetUniqueKey(6)
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into Bookissue_Student(TransactionID, IssueDate, DueDate, AccessionNo, StudentID, Status) VALUES('" & txtTransactionID.Text & "',#" & dtpIssueDate.Text & "#,#" & dtpDueDate.Text & "#,'" & cmbAccessionNo.Text & "','" & cmbStudentID.Text & "','Issued')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "Update book set NoOfBooks = NoOfBooks-1 where AccessionNo='" & cmbAccessionNo.Text & "'"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully issued", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTransactionID.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmBookRecord2.Show()
        frmBookRecord2.Clear()
    End Sub

    Private Sub cmbStudentID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStudentID.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select StudentName,Course,Department from Student where StudentID='" & cmbStudentID.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                txtStudentName.Text = rdr("StudentName").ToString()
                txtCourse.Text = rdr("Course").ToString()
                txtDepartment.Text = rdr("Department").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillStudentID()
        Try
            cmbStudentID.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct StudentID FROM Student ", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbStudentID.DisplayMember = "StudentID"
            cmbStudentID.DataSource = dtable
            cmbStudentID.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillStaffID()
        Try
            cmbStaffID.DataSource = Nothing
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct StaffID FROM Staff ", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbStaffID.DisplayMember = "StaffID"
            cmbStaffID.DataSource = dtable
            cmbStaffID.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmBookIssueRecord.Show()
        frmBookIssueRecord.Reset()
    End Sub


    Private Sub btnNewRecord1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord1.Click
        Reset1()
    End Sub

    Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave1.Click
        Try
            If (cmbStaffID.Text = "") Then
                MessageBox.Show("Please retrieve staff id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbStaffID.Focus()
                Exit Sub
            End If
            If (txtStaffName.Text = "") Then
                MessageBox.Show("Please retrieve staff name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStaffName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbAccessionNo1.Text)) = 0 Then
                MessageBox.Show("Please select accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbAccessionNo1.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBookTitle1.Text)) = 0 Then
                MessageBox.Show("Please retrieve book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBookTitle1.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select NoOfBooks from Book where AccessionNo='" & cmbAccessionNo1.Text & "' and NoOfBooks <=0"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Book is not available for issue", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            dtpDueDate1.Text = dtpIssueDate1.Value.Date.AddDays(4)
            txtTransactionID1.Text = "T-" & GetUniqueKey(6)
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into Bookissue_Staff(TransactionID, IssueDate, DueDate, AccessionNo, StaffID, Status) VALUES('" & txtTransactionID1.Text & "',#" & dtpIssueDate1.Text & "#,#" & dtpDueDate1.Text & "#,'" & cmbAccessionNo1.Text & "','" & cmbStaffID.Text & "','Issued')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "Update book set NoOfBooks = NoOfBooks-1 where AccessionNo='" & cmbAccessionNo1.Text & "'"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully issued", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTransactionID.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate1.Click
        Try
            If (cmbStaffID.Text = "") Then
                MessageBox.Show("Please retrieve staff id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbStaffID.Focus()
                Exit Sub
            End If
            If (txtStaffName.Text = "") Then
                MessageBox.Show("Please retrieve staff name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStaffName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbAccessionNo1.Text)) = 0 Then
                MessageBox.Show("Please select accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbAccessionNo1.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBookTitle1.Text)) = 0 Then
                MessageBox.Show("Please retrieve book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBookTitle1.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select NoOfBooks from Book where AccessionNo='" & cmbAccessionNo1.Text & "' and NoOfBooks <=0"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Book is not available for issue", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Bookissue_staff set IssueDate=#" & dtpIssueDate1.Text & "#,DueDate=#" & dtpDueDate1.Text & "#,AccessionNo='" & cmbAccessionNo1.Text & "',StaffID= '" & cmbStaffID.Text & "' where TransactionID='" & txtTransactionID1.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            If (cmbAccessionNo1.Text <> TextBox2.Text) And (txtStatus1.Text = "Issued") Then
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb1 As String = "Update book set NoOfBooks = NoOfBooks + 1 where AccessionNo='" & TextBox2.Text & "'"
                cmd = New OleDbCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb2 As String = "Update book set NoOfBooks = NoOfBooks - 1 where AccessionNo='" & cmbAccessionNo1.Text & "'"
                cmd = New OleDbCommand(cb2)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
            End If
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate1.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete1.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord1()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmBookIssueRecord_Staff.Show()
        frmBookIssueRecord_Staff.Reset()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmStaffRecord2.Show()
        frmStaffRecord2.txtStaffName.Text = ""
        frmStaffRecord2.dtpDateFrom.Text = Today
        frmStaffRecord2.cmbDepartment.Text = ""
        frmStaffRecord2.dtpDateTo.Text = Today
        frmStaffRecord2.GetData()
    End Sub

    Private Sub cmbAccessionNo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccessionNo1.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select BookTitle,Author,Subject,ISBN,Edition from book where AccessionNo='" & cmbAccessionNo1.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                txtBookTitle1.Text = rdr("BookTitle").ToString()
                txtAuthor1.Text = rdr("Author").ToString()
                txtCategory1.Text = rdr("Subject").ToString()
                txtISBN1.Text = rdr("ISBN").ToString()
                txtEdition1.Text = rdr("Edition").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbStaffID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStaffID.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select Staffname,Department from Staff where StaffID='" & cmbStaffID.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                txtStaffName.Text = rdr("StaffName").ToString()
                txtDepartment1.Text = rdr("Department").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmBookRecord3.Show()
        frmBookRecord3.Clear()
    End Sub

    Private Sub dtpIssueDate1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpIssueDate1.ValueChanged
        dtpDueDate1.Text = dtpIssueDate1.Value.Date.AddDays(4)
    End Sub
End Class