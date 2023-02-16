<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCards
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCards))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSession = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtStatus1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGetData1 = New System.Windows.Forms.Button()
        Me.btnUpdate1 = New System.Windows.Forms.Button()
        Me.btnNewRecord1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDepartment1 = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(913, 668)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtStatus)
        Me.TabPage1.Controls.Add(Me.panel1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.listView1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(905, 634)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Students"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(738, 43)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 28)
        Me.txtStatus.TabIndex = 68
        Me.txtStatus.Visible = False
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.Button3)
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.NewRecord)
        Me.panel1.Location = New System.Drawing.Point(386, 96)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(129, 141)
        Me.panel1.TabIndex = 65
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(16, 92)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 33)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&Get Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Enabled = False
        Me.btnUpdate_record.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(16, 53)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(95, 33)
        Me.btnUpdate_record.TabIndex = 3
        Me.btnUpdate_record.Text = "&Update"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'NewRecord
        '
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(16, 14)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(95, 33)
        Me.NewRecord.TabIndex = 0
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(594, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 35)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "Get List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listView1
        '
        Me.listView1.CheckBoxes = True
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader3})
        Me.listView1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listView1.GridLines = True
        Me.listView1.Location = New System.Drawing.Point(6, 96)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(356, 536)
        Me.listView1.TabIndex = 64
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Student ID"
        Me.columnHeader1.Width = 100
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Student Name"
        Me.columnHeader3.Width = 250
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbSession)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmbDepartment)
        Me.GroupBox3.Controls.Add(Me.cmbCourse)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 1)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(573, 88)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Session"
        '
        'cmbSession
        '
        Me.cmbSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Location = New System.Drawing.Point(21, 44)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(165, 29)
        Me.cmbSession.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Course"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartment.Enabled = False
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(363, 44)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(189, 29)
        Me.cmbDepartment.TabIndex = 2
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Enabled = False
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(191, 44)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(165, 29)
        Me.cmbCourse.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtStatus1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(905, 634)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Staff"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtStatus1
        '
        Me.txtStatus1.Location = New System.Drawing.Point(382, 306)
        Me.txtStatus1.Name = "txtStatus1"
        Me.txtStatus1.Size = New System.Drawing.Size(100, 28)
        Me.txtStatus1.TabIndex = 73
        Me.txtStatus1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnGetData1)
        Me.Panel2.Controls.Add(Me.btnUpdate1)
        Me.Panel2.Controls.Add(Me.btnNewRecord1)
        Me.Panel2.Location = New System.Drawing.Point(382, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(129, 142)
        Me.Panel2.TabIndex = 71
        '
        'btnGetData1
        '
        Me.btnGetData1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData1.Location = New System.Drawing.Point(16, 92)
        Me.btnGetData1.Name = "btnGetData1"
        Me.btnGetData1.Size = New System.Drawing.Size(95, 33)
        Me.btnGetData1.TabIndex = 4
        Me.btnGetData1.Text = "&Get Data"
        Me.btnGetData1.UseVisualStyleBackColor = True
        '
        'btnUpdate1
        '
        Me.btnUpdate1.Enabled = False
        Me.btnUpdate1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate1.Location = New System.Drawing.Point(16, 53)
        Me.btnUpdate1.Name = "btnUpdate1"
        Me.btnUpdate1.Size = New System.Drawing.Size(95, 33)
        Me.btnUpdate1.TabIndex = 3
        Me.btnUpdate1.Text = "&Update"
        Me.btnUpdate1.UseVisualStyleBackColor = True
        '
        'btnNewRecord1
        '
        Me.btnNewRecord1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord1.Location = New System.Drawing.Point(16, 14)
        Me.btnNewRecord1.Name = "btnNewRecord1"
        Me.btnNewRecord1.Size = New System.Drawing.Size(95, 33)
        Me.btnNewRecord1.TabIndex = 0
        Me.btnNewRecord1.Text = "&New"
        Me.btnNewRecord1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(298, 40)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 35)
        Me.Button8.TabIndex = 72
        Me.Button8.Text = "Get List"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader4})
        Me.ListView2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(11, 99)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(356, 536)
        Me.ListView2.TabIndex = 65
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Staff ID"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Staff Name"
        Me.ColumnHeader4.Width = 250
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbDepartment1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(268, 88)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Department"
        '
        'cmbDepartment1
        '
        Me.cmbDepartment1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDepartment1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartment1.FormattingEnabled = True
        Me.cmbDepartment1.Location = New System.Drawing.Point(18, 43)
        Me.cmbDepartment1.Name = "cmbDepartment1"
        Me.cmbDepartment1.Size = New System.Drawing.Size(225, 29)
        Me.cmbDepartment1.TabIndex = 2
        '
        'frmCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(906, 668)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmCards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cards Submission"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents txtStatus As System.Windows.Forms.TextBox
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents btnUpdate_record As System.Windows.Forms.Button
    Public WithEvents NewRecord As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents txtStatus1 As System.Windows.Forms.TextBox
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents btnGetData1 As System.Windows.Forms.Button
    Public WithEvents btnUpdate1 As System.Windows.Forms.Button
    Public WithEvents btnNewRecord1 As System.Windows.Forms.Button
    Public WithEvents Button8 As System.Windows.Forms.Button
    Private WithEvents ListView2 As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment1 As System.Windows.Forms.ComboBox
End Class
