<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookIssueRecord_Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookIssueRecord_Staff))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBookName1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbStaffName = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbStaffName1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker7 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker8 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtBookName)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.dtpDateTo)
        Me.GroupBox4.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(501, 88)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "By Issue Date and Book Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Book Name"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(321, 39)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(163, 24)
        Me.txtBookName.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(175, 39)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(123, 24)
        Me.dtpDateTo.TabIndex = 5
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(24, 38)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(131, 24)
        Me.dtpDateFrom.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBookName1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Location = New System.Drawing.Point(519, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(500, 88)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "By Due Date and Book Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Book Name"
        '
        'txtBookName1
        '
        Me.txtBookName1.Location = New System.Drawing.Point(321, 38)
        Me.txtBookName1.Name = "txtBookName1"
        Me.txtBookName1.Size = New System.Drawing.Size(163, 24)
        Me.txtBookName1.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "From"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(175, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 24)
        Me.DateTimePicker1.TabIndex = 5
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(24, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(131, 24)
        Me.DateTimePicker2.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbStaffName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(501, 88)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "By Issue Date and Staff Name"
        '
        'cmbStaffName
        '
        Me.cmbStaffName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbStaffName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStaffName.FormattingEnabled = True
        Me.cmbStaffName.Items.AddRange(New Object() {"Student", "Staff"})
        Me.cmbStaffName.Location = New System.Drawing.Point(321, 38)
        Me.cmbStaffName.Name = "cmbStaffName"
        Me.cmbStaffName.Size = New System.Drawing.Size(163, 25)
        Me.cmbStaffName.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(318, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Staff Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(172, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "To"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "From"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(175, 38)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(123, 24)
        Me.DateTimePicker3.TabIndex = 5
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(24, 38)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(131, 24)
        Me.DateTimePicker4.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbStaffName1)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker5)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker6)
        Me.GroupBox3.Location = New System.Drawing.Point(519, 109)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(500, 88)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "By Due Date and Staff Name"
        '
        'cmbStaffName1
        '
        Me.cmbStaffName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbStaffName1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStaffName1.FormattingEnabled = True
        Me.cmbStaffName1.Items.AddRange(New Object() {"Student", "Staff"})
        Me.cmbStaffName1.Location = New System.Drawing.Point(321, 38)
        Me.cmbStaffName1.Name = "cmbStaffName1"
        Me.cmbStaffName1.Size = New System.Drawing.Size(163, 25)
        Me.cmbStaffName1.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(318, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 16)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Staff Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(172, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "To"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "From"
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(175, 38)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(123, 24)
        Me.DateTimePicker5.TabIndex = 5
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker6.Location = New System.Drawing.Point(24, 38)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(131, 24)
        Me.DateTimePicker6.TabIndex = 4
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker7)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker8)
        Me.GroupBox5.Location = New System.Drawing.Point(1025, 13)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(332, 88)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Issue Date"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(264, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 25)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "&Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(142, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "To"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 16)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "From"
        '
        'DateTimePicker7
        '
        Me.DateTimePicker7.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker7.Location = New System.Drawing.Point(144, 43)
        Me.DateTimePicker7.Name = "DateTimePicker7"
        Me.DateTimePicker7.Size = New System.Drawing.Size(113, 24)
        Me.DateTimePicker7.TabIndex = 35
        '
        'DateTimePicker8
        '
        Me.DateTimePicker8.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker8.Location = New System.Drawing.Point(20, 43)
        Me.DateTimePicker8.Name = "DateTimePicker8"
        Me.DateTimePicker8.Size = New System.Drawing.Size(112, 24)
        Me.DateTimePicker8.TabIndex = 34
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtStaffName)
        Me.GroupBox6.Location = New System.Drawing.Point(1035, 109)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(209, 88)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "By Staff Name"
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(19, 35)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(163, 24)
        Me.txtStaffName.TabIndex = 35
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1158, 479)
        Me.DataGridView1.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnExportExcel)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Location = New System.Drawing.Point(1181, 205)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 106)
        Me.Panel1.TabIndex = 14
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(15, 54)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(93, 36)
        Me.btnExportExcel.TabIndex = 1
        Me.btnExportExcel.Text = "&Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(15, 15)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 33)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmBookIssueRecord_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1362, 684)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBookIssueRecord_Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Issued Books Record [Staff]"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBookName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbStaffName As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStaffName1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStaffName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btnExportExcel As System.Windows.Forms.Button
    Private WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker7 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker8 As System.Windows.Forms.DateTimePicker
    Private WithEvents Button1 As System.Windows.Forms.Button
End Class
