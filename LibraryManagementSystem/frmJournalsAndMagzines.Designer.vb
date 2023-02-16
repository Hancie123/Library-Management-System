<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournalsAndMagzines
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJournalsAndMagzines))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSupplierName = New System.Windows.Forms.ComboBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpPaidOn = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.dtpSubDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpSubDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpSubDate = New System.Windows.Forms.DateTimePicker()
        Me.txtSubNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateOfReceipt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtIssueNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnGetDetails = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Controls.Add(Me.cmbDepartment)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbSupplierName)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.dtpPaidOn)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.dtpBillDate)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtBillNo)
        Me.GroupBox1.Controls.Add(Me.dtpSubDateTo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.dtpSubDateFrom)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtSub)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtpSubDate)
        Me.GroupBox1.Controls.Add(Me.txtSubNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDateOfReceipt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtVolume)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbMonth)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.txtIssueNo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(647, 587)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Journals And Magazines"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(211, 447)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(228, 30)
        Me.cmbDepartment.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(36, 450)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Department"
        '
        'cmbSupplierName
        '
        Me.cmbSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSupplierName.FormattingEnabled = True
        Me.cmbSupplierName.Location = New System.Drawing.Point(210, 406)
        Me.cmbSupplierName.Name = "cmbSupplierName"
        Me.cmbSupplierName.Size = New System.Drawing.Size(228, 30)
        Me.cmbSupplierName.TabIndex = 17
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(461, 329)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(118, 29)
        Me.txtNumber.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(377, 332)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 23)
        Me.Label21.TabIndex = 106
        Me.Label21.Text = "Number"
        '
        'dtpPaidOn
        '
        Me.dtpPaidOn.CustomFormat = "dd/MMM/yyyy"
        Me.dtpPaidOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPaidOn.Location = New System.Drawing.Point(461, 197)
        Me.dtpPaidOn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpPaidOn.Name = "dtpPaidOn"
        Me.dtpPaidOn.Size = New System.Drawing.Size(159, 29)
        Me.dtpPaidOn.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(377, 197)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 23)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "Paid On"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(211, 196)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 29)
        Me.txtAmount.TabIndex = 8
        '
        'dtpBillDate
        '
        Me.dtpBillDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDate.Location = New System.Drawing.Point(461, 161)
        Me.dtpBillDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpBillDate.Name = "dtpBillDate"
        Me.dtpBillDate.Size = New System.Drawing.Size(159, 29)
        Me.dtpBillDate.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(377, 168)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 23)
        Me.Label17.TabIndex = 101
        Me.Label17.Text = "Bill Date"
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(211, 164)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(100, 29)
        Me.txtBillNo.TabIndex = 6
        '
        'dtpSubDateTo
        '
        Me.dtpSubDateTo.CustomFormat = "dd/MMM/yyyy"
        Me.dtpSubDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSubDateTo.Location = New System.Drawing.Point(461, 124)
        Me.dtpSubDateTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpSubDateTo.Name = "dtpSubDateTo"
        Me.dtpSubDateTo.Size = New System.Drawing.Size(159, 29)
        Me.dtpSubDateTo.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(425, 129)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 23)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "To"
        '
        'dtpSubDateFrom
        '
        Me.dtpSubDateFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtpSubDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSubDateFrom.Location = New System.Drawing.Point(265, 126)
        Me.dtpSubDateFrom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpSubDateFrom.Name = "dtpSubDateFrom"
        Me.dtpSubDateFrom.Size = New System.Drawing.Size(135, 29)
        Me.dtpSubDateFrom.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(211, 129)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 23)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "From"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(37, 129)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(197, 23)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Subscription Per Annum"
        '
        'txtSub
        '
        Me.txtSub.Location = New System.Drawing.Point(211, 95)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(100, 29)
        Me.txtSub.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(37, 98)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 23)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Subscription"
        '
        'dtpSubDate
        '
        Me.dtpSubDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpSubDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSubDate.Location = New System.Drawing.Point(461, 62)
        Me.dtpSubDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpSubDate.Name = "dtpSubDate"
        Me.dtpSubDate.Size = New System.Drawing.Size(159, 29)
        Me.dtpSubDate.TabIndex = 2
        '
        'txtSubNo
        '
        Me.txtSubNo.Location = New System.Drawing.Point(211, 64)
        Me.txtSubNo.Name = "txtSubNo"
        Me.txtSubNo.Size = New System.Drawing.Size(100, 29)
        Me.txtSubNo.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(37, 164)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 23)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Bill No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(37, 197)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 23)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(331, 67)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 23)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Subscription Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(37, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 23)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Subscription No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(36, 411)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 23)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Supplier Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(211, 33)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(245, 29)
        Me.txtName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(36, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 23)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Title"
        '
        'dtpDateOfReceipt
        '
        Me.dtpDateOfReceipt.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateOfReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfReceipt.Location = New System.Drawing.Point(210, 368)
        Me.dtpDateOfReceipt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpDateOfReceipt.Name = "dtpDateOfReceipt"
        Me.dtpDateOfReceipt.Size = New System.Drawing.Size(159, 29)
        Me.dtpDateOfReceipt.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(38, 370)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 23)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Date Of Receipt"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(211, 261)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(133, 29)
        Me.dtpDate.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(37, 261)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 23)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Date"
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(210, 332)
        Me.txtVolume.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(118, 29)
        Me.txtVolume.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(36, 332)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 23)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "Volume"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(210, 489)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRemarks.Size = New System.Drawing.Size(245, 79)
        Me.txtRemarks.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(37, 489)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 23)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Remarks"
        '
        'cmbMonth
        '
        Me.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(461, 258)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(159, 30)
        Me.cmbMonth.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(377, 261)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 23)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Month"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(211, 297)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(99, 29)
        Me.txtYear.TabIndex = 13
        '
        'txtIssueNo
        '
        Me.txtIssueNo.Location = New System.Drawing.Point(211, 228)
        Me.txtIssueNo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtIssueNo.Name = "txtIssueNo"
        Me.txtIssueNo.Size = New System.Drawing.Size(159, 29)
        Me.txtIssueNo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(38, 299)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 23)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(37, 228)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 23)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Issue No."
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnGetDetails)
        Me.panel1.Controls.Add(Me.btnUpdate)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.NewRecord)
        Me.panel1.Location = New System.Drawing.Point(692, 28)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(128, 223)
        Me.panel1.TabIndex = 1
        '
        'btnGetDetails
        '
        Me.btnGetDetails.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDetails.Location = New System.Drawing.Point(11, 169)
        Me.btnGetDetails.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetDetails.Name = "btnGetDetails"
        Me.btnGetDetails.Size = New System.Drawing.Size(97, 36)
        Me.btnGetDetails.TabIndex = 4
        Me.btnGetDetails.Text = "&Get Data"
        Me.btnGetDetails.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(11, 128)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 36)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(11, 88)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 36)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(11, 48)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 36)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'NewRecord
        '
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(11, 8)
        Me.NewRecord.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(97, 36)
        Me.NewRecord.TabIndex = 1
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(702, 268)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(128, 29)
        Me.txtID.TabIndex = 2
        Me.txtID.Visible = False
        '
        'frmJournalsAndMagzines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(862, 623)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmJournalsAndMagzines"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journals and Magazines Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDateOfReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents btnGetDetails As System.Windows.Forms.Button
    Public WithEvents btnUpdate As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents txtIssueNo As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSub As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpSubDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSubNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpPaidOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtpBillDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpSubDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpSubDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbSupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
