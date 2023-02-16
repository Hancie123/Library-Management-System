<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmlogin))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.linkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(481, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 34)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(385, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'linkLabel3
        '
        Me.linkLabel3.AutoSize = True
        Me.linkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel3.ForeColor = System.Drawing.Color.Black
        Me.linkLabel3.LinkColor = System.Drawing.Color.Blue
        Me.linkLabel3.Location = New System.Drawing.Point(430, 319)
        Me.linkLabel3.Name = "linkLabel3"
        Me.linkLabel3.Size = New System.Drawing.Size(188, 27)
        Me.linkLabel3.TabIndex = 6
        Me.linkLabel3.TabStop = True
        Me.linkLabel3.Text = "Password Recovery"
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel1.ForeColor = System.Drawing.Color.Black
        Me.linkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.linkLabel1.Location = New System.Drawing.Point(263, 321)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(173, 27)
        Me.linkLabel1.TabIndex = 5
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "Change Password"
        '
        'cmbUserType
        '
        Me.cmbUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUserType.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmbUserType.Location = New System.Drawing.Point(385, 141)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(172, 30)
        Me.cmbUserType.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(385, 214)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9824)
        Me.txtPassword.Size = New System.Drawing.Size(172, 25)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(385, 178)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 25)
        Me.txtUsername.TabIndex = 1
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(277, 212)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(90, 23)
        Me.PasswordLabel.TabIndex = 67
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(277, 176)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(105, 23)
        Me.UsernameLabel.TabIndex = 66
        Me.UsernameLabel.Text = "&User Name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(277, 139)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(90, 28)
        Me.label2.TabIndex = 65
        Me.label2.Text = "&User Type"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-8, 351)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(869, 10)
        Me.ProgressBar1.TabIndex = 68
        Me.ProgressBar1.Visible = False
        '
        'Frmlogin
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 357)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.linkLabel3)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.label2)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NH Library Management System Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents linkLabel3 As System.Windows.Forms.LinkLabel
    Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
