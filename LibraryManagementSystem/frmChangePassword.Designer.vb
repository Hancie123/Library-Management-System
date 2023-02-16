<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OldPassword = New System.Windows.Forms.TextBox()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 142)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password"
        '
        'OldPassword
        '
        Me.OldPassword.Location = New System.Drawing.Point(217, 138)
        Me.OldPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OldPassword.Name = "OldPassword"
        Me.OldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9824)
        Me.OldPassword.Size = New System.Drawing.Size(161, 22)
        Me.OldPassword.TabIndex = 2
        '
        'NewPassword
        '
        Me.NewPassword.Location = New System.Drawing.Point(217, 190)
        Me.NewPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9824)
        Me.NewPassword.Size = New System.Drawing.Size(161, 22)
        Me.NewPassword.TabIndex = 3
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Location = New System.Drawing.Point(217, 242)
        Me.ConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9824)
        Me.ConfirmPassword.Size = New System.Drawing.Size(161, 22)
        Me.ConfirmPassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 246)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm Password"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(129, 309)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 47)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "User Name"
        '
        'UserName
        '
        Me.UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.UserName.Location = New System.Drawing.Point(217, 89)
        Me.UserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(161, 22)
        Me.UserName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 44)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "User Type"
        '
        'cmbUserType
        '
        Me.cmbUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmbUserType.Location = New System.Drawing.Point(217, 44)
        Me.cmbUserType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(160, 24)
        Me.cmbUserType.TabIndex = 0
        '
        'frmChangePassword
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(424, 391)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.OldPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OldPassword As System.Windows.Forms.TextBox
    Friend WithEvents NewPassword As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
End Class
