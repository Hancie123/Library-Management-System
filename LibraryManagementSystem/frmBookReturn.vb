Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Public Class frmBookReturn

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
        txtStudentID.Text = ""
        dtpReturnDate.Text = Today
        txtTransactionID.Text = ""
        txtAuthor.Text = ""
        txtBookTitle.Text = ""
        txtCategory.Text = ""
        txtDepartment.Text = ""
        txtEdition.Text = ""
        txtISBN.Text = ""
        txtCourse.Text = ""
        txtStudentName.Text = ""
        txtAccessionNo.Text = ""
        dtpDueDate.Text = ""
        dtpIssueDate.Text = ""
        txtFine.Text = ""
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate_record.Enabled = False
    End Sub
    Sub Reset1()
        txtStaffID.Text = ""
        txtTransactionID1.Text = ""
        dtpReturnDate1.Text = Today
        txtAuthor1.Text = ""
        txtBookTitle1.Text = ""
        txtCategory1.Text = ""
        txtDepartment1.Text = ""
        txtEdition1.Text = ""
        txtISBN1.Text = ""
        txtStaffName.Text = ""
        txtAccessionNo1.Text = ""
        dtpDueDate1.Text = ""
        dtpIssueDate1.Text = ""
        txtFine1.Text = ""
        btnSave1.Enabled = True
        btnDelete1.Enabled = False
        btnUpdate1.Enabled = False
    End Sub
    Private Sub btnNewRecord1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord1.Click
        Reset1()
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtTransactionID.Text)) = 0 Then
                MessageBox.Show("Please retrieve transaction id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTransactionID.Focus()
                Exit Sub
            End If
            If (dtpReturnDate.Value.Date < dtpDueDate.Value.Date) Then
                MessageBox.Show("Return date can not be less than due date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpReturnDate.Focus()
                Exit Sub
            End If
            If txtFine.Text = "" Then
                txtFine.Text = 0
            End If
            txtReturnID.Text = "R-" & GetUniqueKey(6)
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into return_Student(ReturnID, TransactionID, ReturnDate, Fine) VALUES('" & txtReturnID.Text & "','" & txtTransactionID.Text & "',#" & dtpReturnDate.Text & "#," & txtFine.Text & ")"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "Update book set NoOfBooks = NoOfBooks+1 where AccessionNo='" & txtAccessionNo.Text & "'"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb2 As String = "Update bookIssue_student set Status = 'Returned' where AccessionNo='" & txtAccessionNo.Text & "'"
            cmd = New OleDbCommand(cb2)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully returned", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpReturnDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpReturnDate.ValueChanged
        Dim st As Integer = dtpReturnDate.Value.Date.Subtract(dtpDueDate.Value.Date).Days
        If (st > 0) Then
            txtFine.Text = (st * 5).ToString()
        Else
            txtFine.Text = 0
        End If
    End Sub

    Private Sub dtpReturnDate_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpReturnDate.Validating
        If (dtpDueDate.Value.Date) > (dtpReturnDate.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpReturnDate.Focus()
        End If
    End Sub

    Private Sub dtpReturnDate1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpReturnDate1.Validating
        If (dtpDueDate1.Value.Date) > (dtpReturnDate1.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpReturnDate1.Focus()
        End If
    End Sub

    Private Sub dtpReturnDate1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpReturnDate1.ValueChanged
        Dim st As Integer = dtpReturnDate1.Value.Date.Subtract(dtpDueDate1.Value.Date).Days
        If (st > 0) Then
            txtFine1.Text = (st * 5).ToString()

        Else
            txtFine1.Text = 0
        End If
    End Sub

    Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave1.Click
        Try
            If Len(Trim(txtTransactionID1.Text)) = 0 Then
                MessageBox.Show("Please retrieve transaction id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTransactionID1.Focus()
                Exit Sub
            End If
            If (dtpReturnDate1.Value.Date < dtpDueDate1.Value.Date) Then
                MessageBox.Show("Return date can not be less than due date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpReturnDate1.Focus()
                Exit Sub
            End If
            If txtFine1.Text = "" Then
                txtFine1.Text = 0
            End If
            txtReturnID1.Text = "R-" & GetUniqueKey(6)
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into return_Staff(ReturnID, TransactionID, ReturnDate, Fine) VALUES('" & txtReturnID1.Text & "','" & txtTransactionID1.Text & "',#" & dtpReturnDate1.Text & "#," & txtFine1.Text & ")"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "Update book set NoOfBooks = NoOfBooks+1 where AccessionNo='" & txtAccessionNo1.Text & "'"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb2 As String = "Update bookIssue_staff set Status = 'Returned' where AccessionNo='" & txtAccessionNo1.Text & "'"
            cmd = New OleDbCommand(cb2)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully returned", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave1.Enabled = False

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

    Private Sub btnDelete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete1.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord1()
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
            Dim cq As String = "delete from Return_Student where ReturnID = '" & txtReturnID.Text & "'"
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
            Dim cq As String = "delete from Return_Staff where ReturnID = '" & txtReturnID1.Text & "'"
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

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        Try
            If Len(Trim(txtTransactionID.Text)) = 0 Then
                MessageBox.Show("Please retrieve transaction id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTransactionID.Focus()
                Exit Sub
            End If
            If (dtpReturnDate.Value.Date < dtpDueDate.Value.Date) Then
                MessageBox.Show("Return date can not be less than due date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpReturnDate.Focus()
                Exit Sub
            End If
            If txtFine.Text = "" Then
                txtFine.Text = 0
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Return_student set TransactionID='" & txtTransactionID.Text & "',ReturnDate=#" & dtpReturnDate.Text & "#,Fine='" & txtFine.Text & "' where ReturnID='" & txtReturnID.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            If (txtAccessionNo.Text <> TextBox1.Text) Then
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb1 As String = "Update book set NoOfBooks = NoOfBooks - 1 where AccessionNo='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb2 As String = "Update book set NoOfBooks = NoOfBooks + 1 where AccessionNo='" & txtAccessionNo.Text & "'"
                cmd = New OleDbCommand(cb2)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb3 As String = "Update bookIssue_student set Status = 'Returned' where AccessionNo='" & txtAccessionNo.Text & "'"
                cmd = New OleDbCommand(cb3)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb4 As String = "Update bookIssue_student set Status = 'Issued' where AccessionNo='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(cb4)
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

    Private Sub btnUpdate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate1.Click
        Try
            If Len(Trim(txtTransactionID1.Text)) = 0 Then
                MessageBox.Show("Please retrieve transaction id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTransactionID1.Focus()
                Exit Sub
            End If
            If (dtpReturnDate1.Value.Date < dtpDueDate1.Value.Date) Then
                MessageBox.Show("Return date can not be less than due date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpReturnDate1.Focus()
                Exit Sub
            End If
            If txtFine1.Text = "" Then
                txtFine1.Text = 0
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Return_staff set TransactionID='" & txtTransactionID1.Text & "',ReturnDate=#" & dtpReturnDate1.Text & "#,Fine='" & txtFine1.Text & "' where ReturnID='" & txtReturnID1.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            If (txtAccessionNo1.Text <> TextBox2.Text) Then
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb1 As String = "Update book set NoOfBooks = NoOfBooks - 1 where AccessionNo='" & TextBox2.Text & "'"
                cmd = New OleDbCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb2 As String = "Update book set NoOfBooks = NoOfBooks + 1 where AccessionNo='" & txtAccessionNo1.Text & "'"
                cmd = New OleDbCommand(cb2)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb3 As String = "Update bookIssue_staff set Status = 'Returned' where AccessionNo='" & txtAccessionNo1.Text & "'"
                cmd = New OleDbCommand(cb3)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb4 As String = "Update bookIssue_staff set Status = 'Issued' where AccessionNo='" & TextBox2.Text & "'"
                cmd = New OleDbCommand(cb4)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmBookIssueRecord_Staff2.Show()
        frmBookIssueRecord_Staff2.Reset()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmBookIssueRecord2.Show()
        frmBookIssueRecord2.Reset()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmBookReturnRecord_Student.Show()
        frmBookReturnRecord_Student.Reset()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmBookReturnRecord_Staff.Show()
        frmBookReturnRecord_Staff.Reset()
    End Sub
End Class