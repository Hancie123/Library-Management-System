<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemInfo))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtProcessorFamily = New System.Windows.Forms.TextBox()
        Me.txtProcessorExtClock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProcessorClockSpeed = New System.Windows.Forms.TextBox()
        Me.txtProcessorDataWidth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProcessorL2CacheSize = New System.Windows.Forms.TextBox()
        Me.txtProcessorManufacturer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProcessorDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProcessorID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProcessorName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtBoardSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBoardDescription = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBoardManufacturer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBoardName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(394, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToFileToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToFileToolStripMenuItem
        '
        Me.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem"
        Me.SaveToFileToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.SaveToFileToolStripMenuItem.Text = "&Save to file"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(155, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(370, 333)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtProcessorFamily)
        Me.TabPage1.Controls.Add(Me.txtProcessorExtClock)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtProcessorClockSpeed)
        Me.TabPage1.Controls.Add(Me.txtProcessorDataWidth)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtProcessorL2CacheSize)
        Me.TabPage1.Controls.Add(Me.txtProcessorManufacturer)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtProcessorDescription)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtProcessorID)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtProcessorName)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(362, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Processor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtProcessorFamily
        '
        Me.txtProcessorFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorFamily.Location = New System.Drawing.Point(186, 252)
        Me.txtProcessorFamily.Name = "txtProcessorFamily"
        Me.txtProcessorFamily.ReadOnly = True
        Me.txtProcessorFamily.Size = New System.Drawing.Size(165, 26)
        Me.txtProcessorFamily.TabIndex = 37
        Me.txtProcessorFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessorExtClock
        '
        Me.txtProcessorExtClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorExtClock.Location = New System.Drawing.Point(15, 252)
        Me.txtProcessorExtClock.Name = "txtProcessorExtClock"
        Me.txtProcessorExtClock.ReadOnly = True
        Me.txtProcessorExtClock.Size = New System.Drawing.Size(165, 26)
        Me.txtProcessorExtClock.TabIndex = 36
        Me.txtProcessorExtClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(183, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Family"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Ext Clock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(183, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Data Width"
        '
        'txtProcessorClockSpeed
        '
        Me.txtProcessorClockSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorClockSpeed.Location = New System.Drawing.Point(15, 211)
        Me.txtProcessorClockSpeed.Name = "txtProcessorClockSpeed"
        Me.txtProcessorClockSpeed.ReadOnly = True
        Me.txtProcessorClockSpeed.Size = New System.Drawing.Size(165, 26)
        Me.txtProcessorClockSpeed.TabIndex = 32
        Me.txtProcessorClockSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessorDataWidth
        '
        Me.txtProcessorDataWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorDataWidth.Location = New System.Drawing.Point(186, 211)
        Me.txtProcessorDataWidth.Name = "txtProcessorDataWidth"
        Me.txtProcessorDataWidth.ReadOnly = True
        Me.txtProcessorDataWidth.Size = New System.Drawing.Size(165, 26)
        Me.txtProcessorDataWidth.TabIndex = 31
        Me.txtProcessorDataWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Clock Speed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "L2 Cache Size"
        '
        'txtProcessorL2CacheSize
        '
        Me.txtProcessorL2CacheSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorL2CacheSize.Location = New System.Drawing.Point(186, 169)
        Me.txtProcessorL2CacheSize.Name = "txtProcessorL2CacheSize"
        Me.txtProcessorL2CacheSize.ReadOnly = True
        Me.txtProcessorL2CacheSize.Size = New System.Drawing.Size(165, 26)
        Me.txtProcessorL2CacheSize.TabIndex = 28
        Me.txtProcessorL2CacheSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessorManufacturer
        '
        Me.txtProcessorManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorManufacturer.Location = New System.Drawing.Point(14, 169)
        Me.txtProcessorManufacturer.Name = "txtProcessorManufacturer"
        Me.txtProcessorManufacturer.ReadOnly = True
        Me.txtProcessorManufacturer.Size = New System.Drawing.Size(165, 26)
        Me.txtProcessorManufacturer.TabIndex = 27
        Me.txtProcessorManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Manufacturer"
        '
        'txtProcessorDescription
        '
        Me.txtProcessorDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorDescription.Location = New System.Drawing.Point(14, 128)
        Me.txtProcessorDescription.Name = "txtProcessorDescription"
        Me.txtProcessorDescription.ReadOnly = True
        Me.txtProcessorDescription.Size = New System.Drawing.Size(337, 26)
        Me.txtProcessorDescription.TabIndex = 25
        Me.txtProcessorDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Description"
        '
        'txtProcessorID
        '
        Me.txtProcessorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorID.Location = New System.Drawing.Point(14, 87)
        Me.txtProcessorID.Name = "txtProcessorID"
        Me.txtProcessorID.ReadOnly = True
        Me.txtProcessorID.Size = New System.Drawing.Size(337, 26)
        Me.txtProcessorID.TabIndex = 23
        Me.txtProcessorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Processor ID"
        '
        'txtProcessorName
        '
        Me.txtProcessorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorName.Location = New System.Drawing.Point(14, 46)
        Me.txtProcessorName.Name = "txtProcessorName"
        Me.txtProcessorName.ReadOnly = True
        Me.txtProcessorName.Size = New System.Drawing.Size(337, 26)
        Me.txtProcessorName.TabIndex = 21
        Me.txtProcessorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Processor Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtBoardSerialNumber)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtBoardDescription)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtBoardManufacturer)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtBoardName)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(362, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Motherboard"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtBoardSerialNumber
        '
        Me.txtBoardSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoardSerialNumber.Location = New System.Drawing.Point(14, 235)
        Me.txtBoardSerialNumber.Name = "txtBoardSerialNumber"
        Me.txtBoardSerialNumber.ReadOnly = True
        Me.txtBoardSerialNumber.Size = New System.Drawing.Size(337, 26)
        Me.txtBoardSerialNumber.TabIndex = 23
        Me.txtBoardSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Serial Number"
        '
        'txtBoardDescription
        '
        Me.txtBoardDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoardDescription.Location = New System.Drawing.Point(14, 179)
        Me.txtBoardDescription.Name = "txtBoardDescription"
        Me.txtBoardDescription.ReadOnly = True
        Me.txtBoardDescription.Size = New System.Drawing.Size(337, 26)
        Me.txtBoardDescription.TabIndex = 21
        Me.txtBoardDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Description"
        '
        'txtBoardManufacturer
        '
        Me.txtBoardManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoardManufacturer.Location = New System.Drawing.Point(14, 123)
        Me.txtBoardManufacturer.Name = "txtBoardManufacturer"
        Me.txtBoardManufacturer.ReadOnly = True
        Me.txtBoardManufacturer.Size = New System.Drawing.Size(337, 26)
        Me.txtBoardManufacturer.TabIndex = 19
        Me.txtBoardManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Manufacturer"
        '
        'txtBoardName
        '
        Me.txtBoardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoardName.Location = New System.Drawing.Point(14, 67)
        Me.txtBoardName.Name = "txtBoardName"
        Me.txtBoardName.ReadOnly = True
        Me.txtBoardName.Size = New System.Drawing.Size(337, 26)
        Me.txtBoardName.TabIndex = 17
        Me.txtBoardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Motherboard Name"
        '
        'frmSystemInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 372)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystemInfo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NH System Info Viewer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtProcessorFamily As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessorExtClock As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProcessorClockSpeed As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessorDataWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProcessorL2CacheSize As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessorManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProcessorDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProcessorID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProcessorName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBoardSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBoardDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBoardManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBoardName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
