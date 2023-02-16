Imports System.Data.OleDb
Public Class frmJournalsAndMagzines
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        Reset()
    End Sub
    Sub Reset()
        dtpBillDate.Text = Today
        dtpPaidOn.Text = Today
        dtpSubDate.Text = Today
        dtpSubDateFrom.Text = Today
        dtpSubDateTo.Text = Today
        txtIssueNo.Text = ""
        txtVolume.Text = ""
        txtRemarks.Text = ""
        txtYear.Text = ""
        cmbMonth.Text = ""
        txtName.Text = ""
        txtNumber.Text = ""
        txtSub.Text = ""
        txtSubNo.Text = ""
        txtAmount.Text = ""
        txtBillNo.Text = ""
        cmbDepartment.Text = ""
        dtpDate.Text = Today
        cmbSupplierName.Text = ""
        dtpDateOfReceipt.Text = Today
        txtName.Focus()
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from JournalAndMagzines where ID = " & txtID.Text & ""
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Autocomplete()
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
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtName.Text)) = 0 Then
                MessageBox.Show("Please Enter Title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtIssueNo.Text)) = 0 Then
                MessageBox.Show("Please Enter Issue No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIssueNo.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbMonth.Text)) = 0 Then
                MessageBox.Show("Please select month", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbMonth.Focus()
                Exit Sub
            End If
            If Len(Trim(txtYear.Text)) = 0 Then
                MessageBox.Show("Please Enter Year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtYear.Focus()
                Exit Sub
            End If
            If Len(Trim(txtVolume.Text)) = 0 Then
                MessageBox.Show("Please Enter Volume", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtVolume.Focus()
                Exit Sub
            End If
            If Len(Trim(txtNumber.Text)) = 0 Then
                MessageBox.Show("Please Enter Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNumber.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSupplierName.Text)) = 0 Then
                MessageBox.Show("Please select supplier", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbSupplierName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into JournalAndMagzines( JM_Name, SubscriptionNo, SubscriptionDate, Subscription, SubscriptionDateFrom, SubscriptionDateTo, BillNo, BillDate, Amount, PaidOn, IssueNo,IssueDate, Months, Jm_Year, Volume, V_num, DateOfReceipt, SupplierName, Department, Remarks) VALUES ('" & txtName.Text & "','" & txtSubNo.Text & "',#" & dtpSubDate.Text & "#,'" & txtSub.Text & "',#" & dtpSubDateFrom.Text & "#,#" & dtpSubDateTo.Text & "#,'" & txtBillNo.Text & "',#" & dtpBillDate.Text & "#," & txtAmount.Text & ",#" & dtpPaidOn.Text & "#,'" & txtIssueNo.Text & "',#" & dtpDate.Text & "#,'" & cmbMonth.Text & "'," & txtYear.Text & ",'" & txtVolume.Text & "','" & txtNumber.Text & "',#" & dtpDateOfReceipt.Text & "#,'" & cmbSupplierName.Text & "','" & cmbDepartment.Text & "','" & txtRemarks.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Autocomplete()
            con.Close()
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If Len(Trim(txtName.Text)) = 0 Then
                MessageBox.Show("Please Enter Title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAmount.Text)) = 0 Then
                MessageBox.Show("Please Enter Amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAmount.Focus()
                Exit Sub
            End If
            If Len(Trim(txtIssueNo.Text)) = 0 Then
                MessageBox.Show("Please Enter Issue No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIssueNo.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbMonth.Text)) = 0 Then
                MessageBox.Show("Please select month", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbMonth.Focus()
                Exit Sub
            End If
            If Len(Trim(txtYear.Text)) = 0 Then
                MessageBox.Show("Please Enter Year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtYear.Focus()
                Exit Sub
            End If
            If Len(Trim(txtVolume.Text)) = 0 Then
                MessageBox.Show("Please Enter Volume", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtVolume.Focus()
                Exit Sub
            End If
            If Len(Trim(txtNumber.Text)) = 0 Then
                MessageBox.Show("Please Enter Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNumber.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSupplierName.Text)) = 0 Then
                MessageBox.Show("Please select supplier", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbSupplierName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update JournalAndMagzines set JM_Name='" & txtName.Text & "',SubscriptionNo='" & txtSubNo.Text & "',SubscriptionDate=#" & dtpSubDate.Text & "#,Subscription='" & txtSub.Text & "',SubscriptionDateFrom=#" & dtpSubDateFrom.Text & "#,SubscriptionDateTo=#" & dtpSubDateTo.Text & "#,BillNo='" & txtBillNo.Text & "',BillDate=#" & dtpBillDate.Text & "#,Amount=" & txtAmount.Text & ",PaidOn=#" & dtpPaidOn.Text & "#,IssueNo='" & txtIssueNo.Text & "',Issuedate=#" & dtpDate.Text & "#,Months='" & cmbMonth.Text & "',JM_year=" & txtYear.Text & ",Volume='" & txtVolume.Text & "',V_Num='" & txtNumber.Text & "',DateOfReceipt=#" & dtpDateOfReceipt.Text & "#,SupplierName='" & cmbSupplierName.Text & "', Department='" & cmbDepartment.Text & "',Remarks='" & txtRemarks.Text & "' where ID=" & txtID.Text & ""
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            Autocomplete()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtYear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYear.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGetDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDetails.Click
        frmJournalsMagzinesRecord.Show()
        frmJournalsMagzinesRecord.Reset()
    End Sub
    Sub Autocomplete()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cmd As New OleDbCommand("SELECT distinct JM_name FROM JournalAndMagzines", con)
            Dim ds As New DataSet()
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "JournalAndMagzines")
            Dim col As New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("JM_name").ToString())
            Next
            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtName.AutoCompleteCustomSource = col
            txtName.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmJournalsAndMagzines_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Autocomplete()
        fillDepartment()
        fillSupplier()
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
End Class