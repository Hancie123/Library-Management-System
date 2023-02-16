<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProject))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpSubmissionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnGetDetails = New System.Windows.Forms.Button()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStudentName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpSubmissionDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtProjectName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 310)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(601, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYear.Enabled = False
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(211, 143)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 30)
        Me.cmbYear.TabIndex = 3
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(211, 109)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(173, 30)
        Me.cmbCourse.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(33, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Course"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(211, 74)
        Me.txtStudentName.Multiline = True
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStudentName.Size = New System.Drawing.Size(384, 28)
        Me.txtStudentName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(33, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 23)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Student Name (s)"
        '
        'dtpSubmissionDate
        '
        Me.dtpSubmissionDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpSubmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSubmissionDate.Location = New System.Drawing.Point(211, 180)
        Me.dtpSubmissionDate.Name = "dtpSubmissionDate"
        Me.dtpSubmissionDate.Size = New System.Drawing.Size(136, 29)
        Me.dtpSubmissionDate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(33, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 23)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Submission Date"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(211, 220)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRemarks.Size = New System.Drawing.Size(384, 70)
        Me.txtRemarks.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(33, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 23)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Remarks"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(211, 42)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(384, 29)
        Me.txtProjectName.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(33, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 23)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(33, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 23)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Project Name"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnGetDetails)
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Location = New System.Drawing.Point(709, 34)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(123, 197)
        Me.panel1.TabIndex = 2
        '
        'btnGetDetails
        '
        Me.btnGetDetails.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDetails.Location = New System.Drawing.Point(14, 150)
        Me.btnGetDetails.Name = "btnGetDetails"
        Me.btnGetDetails.Size = New System.Drawing.Size(94, 28)
        Me.btnGetDetails.TabIndex = 4
        Me.btnGetDetails.Text = "&Get Data"
        Me.btnGetDetails.UseVisualStyleBackColor = True
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Enabled = False
        Me.btnUpdate_record.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(14, 117)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(94, 27)
        Me.btnUpdate_record.TabIndex = 3
        Me.btnUpdate_record.Text = "&Update"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(14, 84)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 27)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(14, 51)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 27)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.Location = New System.Drawing.Point(14, 18)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(94, 27)
        Me.btnNewRecord.TabIndex = 0
        Me.btnNewRecord.Text = "&New"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(709, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 29)
        Me.txtID.TabIndex = 10
        Me.txtID.Visible = False
        '
        'frmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(872, 357)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpSubmissionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents btnGetDetails As System.Windows.Forms.Button
    Public WithEvents btnUpdate_record As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnNewRecord As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
End Class
