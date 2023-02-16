Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class frmStudent
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
    Sub fillCourse()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Coursename) FROM Course", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCourse.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCourse.Items.Add(drow(0).ToString())
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
    Private Sub frmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCourse()
        fillDepartment()
    End Sub

    Private Sub Browse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Picture.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmStudentRecord.Show()
        frmStudentRecord.GetData()
        frmStudentRecord.txtStudentName.Text = ""
        frmStudentRecord.cmbCourse.Text = ""
        frmStudentRecord.cmbCourse1.Text = ""
        frmStudentRecord.cmbDepartment.Text = ""
        frmStudentRecord.cmbDepartment1.Text = ""
        frmStudentRecord.cmbSession.Text = ""
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtStudentName.Text)) = 0 Then
                MessageBox.Show("Please enter student name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If rbMale.Checked = False And rbFemale.Checked = False Then
                MessageBox.Show("Please select gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Len(Trim(txtFatherName.Text)) = 0 Then
                MessageBox.Show("Please enter father's name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFatherName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCourse.Text)) = 0 Then
                MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCourse.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(txtRollNo.Text)) = 0 Then
                MessageBox.Show("Please enter class roll no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRollNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtReceiptNo.Text)) = 0 Then
                MessageBox.Show("Please enter receipt no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtReceiptNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtTempAddress.Text)) = 0 Then
                MessageBox.Show("Please enter temporary address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTempAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPermanentAddress.Text)) = 0 Then
                MessageBox.Show("Please enter permanent address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPermanentAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtMobileNo.Text)) = 0 Then
                MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMobileNo.Focus()
                Exit Sub
            End If
            If rbMale.Checked = True Then
                gender = rbMale.Text
            End If
            If rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If
            txtStudentID.Text = "S-" & GetUniqueKey(6)
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into Student(StudentID, StudentName, FatherName, Course, Department,stu_Session, ClassRollNo, CautionMoneyReceiptNo, TemporaryAddress, PermanentAddress, DOB, PhoneNo, MobileNo, Email, Photo,gender) VALUES('" & txtStudentID.Text & "','" & txtStudentName.Text & "','" & txtFatherName.Text & "','" & cmbCourse.Text & "','" & cmbDepartment.Text & "','" & txtSession.Text & "','" & txtRollNo.Text & "','" & txtReceiptNo.Text & "','" & txtTempAddress.Text & "','" & txtPermanentAddress.Text & "','" & dtpDOB.Text & "','" & txtPhoneNo.Text & "','" & txtMobileNo.Text & "','" & txtEmail.Text & "',@image,'" & gender & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(Picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@image", OleDbType.VarBinary)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into StudentList(StudentID) VALUES('" & txtStudentID.Text & "')"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb2 As String = "insert into Cards_student(StudentID,Status) VALUES('" & txtStudentID.Text & "','No')"
            cmd = New OleDbCommand(cb2)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb3 As String = "insert into NoDues_Student(StudentID,Status) VALUES('" & txtStudentID.Text & "','No')"
            cmd = New OleDbCommand(cb3)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", " Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
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
            Dim cq As String = "delete from Student where StudentID = '" & txtStudentID.Text & "'"
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
    Sub Reset()
        txtStudentID.Text = ""
        txtContactNo.Text = ""
        txtEmail.Text = ""
        txtFatherName.Text = ""
        txtMobileNo.Text = ""
        txtPermanentAddress.Text = ""
        txtPhoneNo.Text = ""
        txtReceiptNo.Text = ""
        txtRollNo.Text = ""
        txtSession.Text = ""
        txtStudentName.Text = ""
        txtTempAddress.Text = ""
        txtPermanentAddress.Text = ""
        cmbCourse.Text = ""
        dtpDOB.Text = Today
        cmbDepartment.Text = ""
        Picture.Image = My.Resources.photo
        rbMale.Checked = False
        rbFemale.Checked = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate_record.Enabled = False
        txtStudentName.Focus()
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Reset()
    End Sub

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        Try
            If Len(Trim(txtStudentName.Text)) = 0 Then
                MessageBox.Show("Please enter student name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If rbMale.Checked = False And rbFemale.Checked = False Then
                MessageBox.Show("Please select gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Len(Trim(txtFatherName.Text)) = 0 Then
                MessageBox.Show("Please enter father's name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFatherName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCourse.Text)) = 0 Then
                MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCourse.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(txtRollNo.Text)) = 0 Then
                MessageBox.Show("Please enter class roll no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRollNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtReceiptNo.Text)) = 0 Then
                MessageBox.Show("Please enter receipt no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtReceiptNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtTempAddress.Text)) = 0 Then
                MessageBox.Show("Please enter temporary address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTempAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPermanentAddress.Text)) = 0 Then
                MessageBox.Show("Please enter permanent address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPermanentAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtMobileNo.Text)) = 0 Then
                MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMobileNo.Focus()
                Exit Sub
            End If

            If rbMale.Checked = True Then
                gender = rbMale.Text
            End If
            If rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Student set Studentname='" & txtStudentName.Text & "',Fathername='" & txtFatherName.Text & "',Course='" & cmbCourse.Text & "',Department='" & cmbDepartment.Text & "',Stu_Session='" & txtSession.Text & "',ClassRollNo='" & txtRollNo.Text & "',CautionMoneyReceiptNo='" & txtReceiptNo.Text & "',TemporaryAddress='" & txtTempAddress.Text & "',PermanentAddress='" & txtPermanentAddress.Text & "',DOB=#" & dtpDOB.Text & "#,PhoneNo='" & txtPhoneNo.Text & "',MobileNo='" & txtMobileNo.Text & "',Email='" & txtEmail.Text & "',Photo=@image,Gender='" & gender & "' where StudentID= '" & txtStudentID.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(Picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@image", OleDbType.VarBinary)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully updated", " Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtEmail.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtEmail.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtEmail.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtMobileNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMobileNo.Validating
        If (txtMobileNo.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobileNo.Focus()
        End If
    End Sub

    Private Sub txtMobileNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhoneNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
End Class