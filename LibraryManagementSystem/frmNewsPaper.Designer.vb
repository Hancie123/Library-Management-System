<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewsPaper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewsPaper))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPaperName = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnGetDetails = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPaperName)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "News Paper"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(47, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 23)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Status"
        '
        'txtPaperName
        '
        Me.txtPaperName.Location = New System.Drawing.Point(156, 27)
        Me.txtPaperName.Name = "txtPaperName"
        Me.txtPaperName.Size = New System.Drawing.Size(237, 29)
        Me.txtPaperName.TabIndex = 0
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(214, 101)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(44, 27)
        Me.RadioButton2.TabIndex = 91
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "A"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(156, 101)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(41, 27)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "P"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(156, 63)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(140, 29)
        Me.dtpDate.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(47, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 23)
        Me.Label20.TabIndex = 87
        Me.Label20.Text = "Date"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(156, 138)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRemarks.Size = New System.Drawing.Size(265, 52)
        Me.txtRemarks.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(47, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 23)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Remarks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(47, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Paper Name"
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
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnGetDetails)
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Location = New System.Drawing.Point(482, 39)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(123, 197)
        Me.panel1.TabIndex = 1
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
        Me.txtID.Location = New System.Drawing.Point(482, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 29)
        Me.txtID.TabIndex = 9
        Me.txtID.Visible = False
        '
        'frmNewsPaper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(621, 266)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmNewsPaper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "News Paper Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnUpdate_record As System.Windows.Forms.Button
    Public WithEvents btnGetDetails As System.Windows.Forms.Button
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents btnNewRecord As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPaperName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
End Class
