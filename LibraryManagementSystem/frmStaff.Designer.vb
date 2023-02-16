<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtContactNo = New System.Windows.Forms.GroupBox()
        Me.dtpDateOfJoining = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtPermanentAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Browse = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.txtTempAddress = New System.Windows.Forms.TextBox()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.label29 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.txtContactNo.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.Transparent
        Me.txtContactNo.Controls.Add(Me.dtpDateOfJoining)
        Me.txtContactNo.Controls.Add(Me.Label11)
        Me.txtContactNo.Controls.Add(Me.rbFemale)
        Me.txtContactNo.Controls.Add(Me.rbMale)
        Me.txtContactNo.Controls.Add(Me.Label13)
        Me.txtContactNo.Controls.Add(Me.txtStaffID)
        Me.txtContactNo.Controls.Add(Me.Label5)
        Me.txtContactNo.Controls.Add(Me.txtMobileNo)
        Me.txtContactNo.Controls.Add(Me.Label4)
        Me.txtContactNo.Controls.Add(Me.Button1)
        Me.txtContactNo.Controls.Add(Me.txtStaffName)
        Me.txtContactNo.Controls.Add(Me.Label7)
        Me.txtContactNo.Controls.Add(Me.txtPhoneNo)
        Me.txtContactNo.Controls.Add(Me.txtPermanentAddress)
        Me.txtContactNo.Controls.Add(Me.Label3)
        Me.txtContactNo.Controls.Add(Me.dtpDOB)
        Me.txtContactNo.Controls.Add(Me.Browse)
        Me.txtContactNo.Controls.Add(Me.txtEmail)
        Me.txtContactNo.Controls.Add(Me.cmbDepartment)
        Me.txtContactNo.Controls.Add(Me.txtTempAddress)
        Me.txtContactNo.Controls.Add(Me.txtFatherName)
        Me.txtContactNo.Controls.Add(Me.label29)
        Me.txtContactNo.Controls.Add(Me.label28)
        Me.txtContactNo.Controls.Add(Me.label25)
        Me.txtContactNo.Controls.Add(Me.label12)
        Me.txtContactNo.Controls.Add(Me.Picture)
        Me.txtContactNo.Controls.Add(Me.Label10)
        Me.txtContactNo.Controls.Add(Me.label6)
        Me.txtContactNo.Controls.Add(Me.label1)
        Me.txtContactNo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.ForeColor = System.Drawing.Color.Black
        Me.txtContactNo.Location = New System.Drawing.Point(55, 36)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Padding = New System.Windows.Forms.Padding(4)
        Me.txtContactNo.Size = New System.Drawing.Size(1027, 598)
        Me.txtContactNo.TabIndex = 0
        Me.txtContactNo.TabStop = False
        Me.txtContactNo.Text = "Staff Profile"
        '
        'dtpDateOfJoining
        '
        Me.dtpDateOfJoining.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateOfJoining.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfJoining.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfJoining.Location = New System.Drawing.Point(304, 191)
        Me.dtpDateOfJoining.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateOfJoining.Name = "dtpDateOfJoining"
        Me.dtpDateOfJoining.Size = New System.Drawing.Size(161, 26)
        Me.dtpDateOfJoining.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(45, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 23)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "*Date Of Joining"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(408, 139)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(80, 25)
        Me.rbFemale.TabIndex = 2
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(304, 139)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(66, 25)
        Me.rbMale.TabIndex = 1
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(45, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 23)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "*Gender"
        '
        'txtStaffID
        '
        Me.txtStaffID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(304, 44)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.Size = New System.Drawing.Size(189, 26)
        Me.txtStaffID.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(45, 50)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Staff ID"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(680, 490)
        Me.txtMobileNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(220, 26)
        Me.txtMobileNo.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(547, 495)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "*Mobile No."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(515, 44)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 28)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(304, 92)
        Me.txtStaffName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(380, 26)
        Me.txtStaffName.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(41, 544)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 23)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Email"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(304, 490)
        Me.txtPhoneNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(220, 26)
        Me.txtPhoneNo.TabIndex = 9
        '
        'txtPermanentAddress
        '
        Me.txtPermanentAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermanentAddress.Location = New System.Drawing.Point(304, 389)
        Me.txtPermanentAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPermanentAddress.Multiline = True
        Me.txtPermanentAddress.Name = "txtPermanentAddress"
        Me.txtPermanentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPermanentAddress.Size = New System.Drawing.Size(624, 29)
        Me.txtPermanentAddress.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(41, 391)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "*Permanent Address"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(304, 441)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(161, 26)
        Me.dtpDOB.TabIndex = 8
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ForeColor = System.Drawing.Color.Black
        Me.Browse.Location = New System.Drawing.Point(732, 240)
        Me.Browse.Margin = New System.Windows.Forms.Padding(4)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(263, 28)
        Me.Browse.TabIndex = 12
        Me.Browse.Text = "Browse..."
        Me.Browse.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(304, 542)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(408, 26)
        Me.txtEmail.TabIndex = 11
        '
        'cmbDepartment
        '
        Me.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(304, 290)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(295, 26)
        Me.cmbDepartment.TabIndex = 5
        '
        'txtTempAddress
        '
        Me.txtTempAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempAddress.Location = New System.Drawing.Point(304, 337)
        Me.txtTempAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTempAddress.Multiline = True
        Me.txtTempAddress.Name = "txtTempAddress"
        Me.txtTempAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTempAddress.Size = New System.Drawing.Size(624, 29)
        Me.txtTempAddress.TabIndex = 6
        '
        'txtFatherName
        '
        Me.txtFatherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.Location = New System.Drawing.Point(304, 240)
        Me.txtFatherName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(380, 26)
        Me.txtFatherName.TabIndex = 4
        '
        'label29
        '
        Me.label29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label29.AutoSize = True
        Me.label29.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label29.ForeColor = System.Drawing.Color.Black
        Me.label29.Location = New System.Drawing.Point(44, 495)
        Me.label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(88, 23)
        Me.label29.TabIndex = 25
        Me.label29.Text = "Phone No."
        '
        'label28
        '
        Me.label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label28.AutoSize = True
        Me.label28.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label28.Location = New System.Drawing.Point(-451, 628)
        Me.label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(54, 23)
        Me.label28.TabIndex = 24
        Me.label28.Text = "Email"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label25.Location = New System.Drawing.Point(41, 297)
        Me.label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(111, 23)
        Me.label25.TabIndex = 21
        Me.label25.Text = "*Department"
        '
        'label12
        '
        Me.label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.Location = New System.Drawing.Point(45, 345)
        Me.label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(169, 23)
        Me.label12.TabIndex = 15
        Me.label12.Text = "*Temporary Address"
        '
        'Picture
        '
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.Image = Global.LibraryManagementSystem.My.Resources.Resources.photo
        Me.Picture.Location = New System.Drawing.Point(732, 33)
        Me.Picture.Margin = New System.Windows.Forms.Padding(4)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(261, 200)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 13
        Me.Picture.TabStop = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(41, 246)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 23)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "*Father's Name"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(41, 446)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(57, 23)
        Me.label6.TabIndex = 7
        Me.label6.Text = "*DOB"
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(41, 96)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(104, 23)
        Me.label1.TabIndex = 2
        Me.label1.Text = "*Staff Name"
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Location = New System.Drawing.Point(1101, 46)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(171, 221)
        Me.panel1.TabIndex = 1
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Enabled = False
        Me.btnUpdate_record.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(21, 164)
        Me.btnUpdate_record.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(127, 41)
        Me.btnUpdate_record.TabIndex = 3
        Me.btnUpdate_record.Text = "&Update"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(21, 114)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(127, 41)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(21, 65)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 41)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.Location = New System.Drawing.Point(21, 17)
        Me.btnNewRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(127, 41)
        Me.btnNewRecord.TabIndex = 0
        Me.btnNewRecord.Text = "&New"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'frmStaff
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1309, 662)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.txtContactNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        Me.txtContactNo.ResumeLayout(False)
        Me.txtContactNo.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents txtContactNo As System.Windows.Forms.GroupBox
    Private WithEvents Browse As System.Windows.Forms.Button
    Public WithEvents txtEmail As System.Windows.Forms.TextBox
    Public WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Public WithEvents txtTempAddress As System.Windows.Forms.TextBox
    Private WithEvents label29 As System.Windows.Forms.Label
    Private WithEvents label28 As System.Windows.Forms.Label
    Private WithEvents label25 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Public WithEvents Picture As System.Windows.Forms.PictureBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Private WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Public WithEvents txtPermanentAddress As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents btnUpdate_record As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnNewRecord As System.Windows.Forms.Button
    Public WithEvents txtStaffName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents txtFatherName As System.Windows.Forms.TextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtStaffID As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfJoining As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
