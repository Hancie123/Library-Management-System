<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentListRecord
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentListRecord))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSession = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbYear)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbSession)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmbDepartment)
        Me.GroupBox3.Controls.Add(Me.cmbCourse)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(702, 88)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'cmbYear
        '
        Me.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYear.Enabled = False
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(564, 44)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(118, 29)
        Me.cmbYear.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(561, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Year"
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
        Me.cmbCourse.Location = New System.Drawing.Point(192, 44)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(165, 29)
        Me.cmbCourse.TabIndex = 0
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader3})
        Me.listView1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listView1.GridLines = True
        Me.listView1.Location = New System.Drawing.Point(14, 108)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(356, 557)
        Me.listView1.TabIndex = 7
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
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnViewReport)
        Me.panel1.Controls.Add(Me.btnReset)
        Me.panel1.Location = New System.Drawing.Point(387, 108)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(129, 104)
        Me.panel1.TabIndex = 8
        '
        'btnViewReport
        '
        Me.btnViewReport.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReport.Location = New System.Drawing.Point(16, 53)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(95, 33)
        Me.btnViewReport.TabIndex = 1
        Me.btnViewReport.Text = "&View Report"
        Me.btnViewReport.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(16, 14)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 33)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(732, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 35)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Get List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmStudentListRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(835, 668)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.listView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmStudentListRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students Record"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Private WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents btnViewReport As System.Windows.Forms.Button
    Public WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbSession As System.Windows.Forms.ComboBox
    Public WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
