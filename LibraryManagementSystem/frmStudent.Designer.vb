<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudent))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtContactNo = New System.Windows.Forms.GroupBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtPermanentAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Browse = New System.Windows.Forms.Button()
        Me.txtSession = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.txtTempAddress = New System.Windows.Forms.TextBox()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.txtRollNo = New System.Windows.Forms.TextBox()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.label29 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
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
        Me.txtContactNo.Controls.Add(Me.rbFemale)
        Me.txtContactNo.Controls.Add(Me.rbMale)
        Me.txtContactNo.Controls.Add(Me.Label13)
        Me.txtContactNo.Controls.Add(Me.txtStudentID)
        Me.txtContactNo.Controls.Add(Me.Label5)
        Me.txtContactNo.Controls.Add(Me.txtMobileNo)
        Me.txtContactNo.Controls.Add(Me.Label4)
        Me.txtContactNo.Controls.Add(Me.Button1)
        Me.txtContactNo.Controls.Add(Me.txtStudentName)
        Me.txtContactNo.Controls.Add(Me.Label7)
        Me.txtContactNo.Controls.Add(Me.txtPhoneNo)
        Me.txtContactNo.Controls.Add(Me.txtPermanentAddress)
        Me.txtContactNo.Controls.Add(Me.Label3)
        Me.txtContactNo.Controls.Add(Me.dtpDOB)
        Me.txtContactNo.Controls.Add(Me.Browse)
        Me.txtContactNo.Controls.Add(Me.txtSession)
        Me.txtContactNo.Controls.Add(Me.txtEmail)
        Me.txtContactNo.Controls.Add(Me.cmbDepartment)
        Me.txtContactNo.Controls.Add(Me.cmbCourse)
        Me.txtContactNo.Controls.Add(Me.txtTempAddress)
        Me.txtContactNo.Controls.Add(Me.txtFatherName)
        Me.txtContactNo.Controls.Add(Me.txtRollNo)
        Me.txtContactNo.Controls.Add(Me.txtReceiptNo)
        Me.txtContactNo.Controls.Add(Me.label29)
        Me.txtContactNo.Controls.Add(Me.Label11)
        Me.txtContactNo.Controls.Add(Me.label28)
        Me.txtContactNo.Controls.Add(Me.label25)
        Me.txtContactNo.Controls.Add(Me.label12)
        Me.txtContactNo.Controls.Add(Me.Picture)
        Me.txtContactNo.Controls.Add(Me.label9)
        Me.txtContactNo.Controls.Add(Me.label8)
        Me.txtContactNo.Controls.Add(Me.Label10)
        Me.txtContactNo.Controls.Add(Me.label6)
        Me.txtContactNo.Controls.Add(Me.label2)
        Me.txtContactNo.Controls.Add(Me.label1)
        Me.txtContactNo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.ForeColor = System.Drawing.Color.Black
        Me.txtContactNo.Location = New System.Drawing.Point(55, 36)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContactNo.Size = New System.Drawing.Size(1027, 718)
        Me.txtContactNo.TabIndex = 0
        Me.txtContactNo.TabStop = False
        Me.txtContactNo.Text = "Student Profile"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(408, 135)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.rbMale.Location = New System.Drawing.Point(304, 135)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.Label13.Location = New System.Drawing.Point(45, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 23)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "*Gender"
        '
        'txtStudentID
        '
        Me.txtStudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(304, 44)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(189, 26)
        Me.txtStudentID.TabIndex = 16
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
        Me.Label5.Size = New System.Drawing.Size(94, 23)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Student ID"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(680, 602)
        Me.txtMobileNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(220, 26)
        Me.txtMobileNo.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(548, 602)
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
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 28)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(304, 92)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(275, 26)
        Me.txtStudentName.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(41, 654)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 23)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Email"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(304, 602)
        Me.txtPhoneNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(220, 26)
        Me.txtPhoneNo.TabIndex = 12
        '
        'txtPermanentAddress
        '
        Me.txtPermanentAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermanentAddress.Location = New System.Drawing.Point(304, 501)
        Me.txtPermanentAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPermanentAddress.Multiline = True
        Me.txtPermanentAddress.Name = "txtPermanentAddress"
        Me.txtPermanentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPermanentAddress.Size = New System.Drawing.Size(624, 29)
        Me.txtPermanentAddress.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 508)
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
        Me.dtpDOB.Location = New System.Drawing.Point(304, 553)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(161, 26)
        Me.dtpDOB.TabIndex = 11
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ForeColor = System.Drawing.Color.Black
        Me.Browse.Location = New System.Drawing.Point(732, 240)
        Me.Browse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(263, 28)
        Me.Browse.TabIndex = 15
        Me.Browse.Text = "Browse..."
        Me.Browse.UseVisualStyleBackColor = True
        '
        'txtSession
        '
        Me.txtSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSession.Location = New System.Drawing.Point(304, 321)
        Me.txtSession.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSession.Mask = "0000-0000"
        Me.txtSession.Name = "txtSession"
        Me.txtSession.Size = New System.Drawing.Size(116, 26)
        Me.txtSession.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(304, 651)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(408, 26)
        Me.txtEmail.TabIndex = 14
        '
        'cmbDepartment
        '
        Me.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(304, 268)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(295, 26)
        Me.cmbDepartment.TabIndex = 5
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(304, 223)
        Me.cmbCourse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(189, 26)
        Me.cmbCourse.TabIndex = 4
        '
        'txtTempAddress
        '
        Me.txtTempAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempAddress.Location = New System.Drawing.Point(304, 454)
        Me.txtTempAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTempAddress.Multiline = True
        Me.txtTempAddress.Name = "txtTempAddress"
        Me.txtTempAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTempAddress.Size = New System.Drawing.Size(624, 29)
        Me.txtTempAddress.TabIndex = 9
        '
        'txtFatherName
        '
        Me.txtFatherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.Location = New System.Drawing.Point(304, 178)
        Me.txtFatherName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(380, 26)
        Me.txtFatherName.TabIndex = 3
        '
        'txtRollNo
        '
        Me.txtRollNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRollNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRollNo.Location = New System.Drawing.Point(304, 367)
        Me.txtRollNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.Size = New System.Drawing.Size(189, 26)
        Me.txtRollNo.TabIndex = 7
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.Location = New System.Drawing.Point(304, 414)
        Me.txtReceiptNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(189, 26)
        Me.txtReceiptNo.TabIndex = 8
        '
        'label29
        '
        Me.label29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label29.AutoSize = True
        Me.label29.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label29.ForeColor = System.Drawing.Color.Black
        Me.label29.Location = New System.Drawing.Point(44, 604)
        Me.label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(88, 23)
        Me.label29.TabIndex = 25
        Me.label29.Text = "Phone No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(40, 225)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 23)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "*Course"
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
        Me.label25.Location = New System.Drawing.Point(41, 274)
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
        Me.label12.Location = New System.Drawing.Point(40, 462)
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
        Me.Picture.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(261, 200)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 13
        Me.Picture.TabStop = False
        '
        'label9
        '
        Me.label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Black
        Me.label9.Location = New System.Drawing.Point(40, 418)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(228, 23)
        Me.label9.TabIndex = 10
        Me.label9.Text = "*Caution Money Receipt No."
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(40, 369)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(126, 23)
        Me.label8.TabIndex = 9
        Me.label8.Text = "*Class Roll No."
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(41, 181)
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
        Me.label6.Location = New System.Drawing.Point(41, 560)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(57, 23)
        Me.label6.TabIndex = 7
        Me.label6.Text = "*DOB"
        '
        'label2
        '
        Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(41, 324)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 23)
        Me.label2.TabIndex = 4
        Me.label2.Text = "*Session"
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
        Me.label1.Size = New System.Drawing.Size(128, 23)
        Me.label1.TabIndex = 2
        Me.label1.Text = "*Student Name"
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
        Me.panel1.Location = New System.Drawing.Point(1101, 48)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(171, 221)
        Me.panel1.TabIndex = 1
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Enabled = False
        Me.btnUpdate_record.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(21, 164)
        Me.btnUpdate_record.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnNewRecord.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(127, 41)
        Me.btnNewRecord.TabIndex = 0
        Me.btnNewRecord.Text = "&New"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'frmStudent
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1309, 782)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.txtContactNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
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
    Public WithEvents txtSession As System.Windows.Forms.MaskedTextBox
    Public WithEvents txtEmail As System.Windows.Forms.TextBox
    Public WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Public WithEvents txtTempAddress As System.Windows.Forms.TextBox
    Public WithEvents txtRollNo As System.Windows.Forms.TextBox
    Public WithEvents txtReceiptNo As System.Windows.Forms.TextBox
    Private WithEvents label29 As System.Windows.Forms.Label
    Private WithEvents label28 As System.Windows.Forms.Label
    Private WithEvents label25 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Public WithEvents Picture As System.Windows.Forms.PictureBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
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
    Public WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Public WithEvents txtFatherName As System.Windows.Forms.TextBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtStudentID As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
