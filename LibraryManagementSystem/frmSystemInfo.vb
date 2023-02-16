Imports System.IO

Public Class frmSystemInfo

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim i As System.Management.ManagementObject
            Dim searchInfo_Processor As New System.Management.ManagementObjectSearcher("Select * from Win32_Processor")
            For Each i In searchInfo_Processor.Get()
                txtProcessorName.Text = i("Name").ToString
                txtProcessorID.Text = i("ProcessorID").ToString
                txtProcessorDescription.Text = i("Description").ToString
                txtProcessorManufacturer.Text = i("Manufacturer").ToString
                txtProcessorL2CacheSize.Text = i("L2CacheSize").ToString
                txtProcessorClockSpeed.Text = i("CurrentClockSpeed").ToString & " Mhz"
                txtProcessorDataWidth.Text = i("DataWidth").ToString
                txtProcessorExtClock.Text = i("ExtClock").ToString & " Mhz"
                txtProcessorFamily.Text = i("Family").ToString
            Next
            Dim searchInfo_Board As New System.Management.ManagementObjectSearcher("Select * from Win32_BaseBoard")
            For Each i In searchInfo_Board.Get()
                txtBoardDescription.Text = i("Description").ToString
                txtBoardManufacturer.Text = i("Manufacturer").ToString
                txtBoardName.Text = i("Name").ToString
                txtBoardSerialNumber.Text = i("SerialNumber").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub

    Private Sub SaveToFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToFileToolStripMenuItem.Click
        Try
            Dim fs As New FileStream("temp.txt", FileMode.Create, FileAccess.Write)
            Dim w As New StreamWriter(fs)
            w.Write("****** Processor Information ******")
            w.WriteLine()
            w.WriteLine()
            w.WriteLine("Name")
            w.WriteLine(txtProcessorName.Text)
            w.WriteLine()
            w.WriteLine("ID")
            w.WriteLine(txtProcessorID.Text)
            w.WriteLine()
            w.WriteLine("Description")
            w.WriteLine(txtProcessorDescription.Text)
            w.WriteLine()
            w.WriteLine("Manufacturer")
            w.WriteLine(txtProcessorManufacturer.Text)
            w.WriteLine()
            w.WriteLine("L2 Cache Size")
            w.WriteLine(txtProcessorL2CacheSize.Text)
            w.WriteLine()
            w.WriteLine("Clock Speed")
            w.WriteLine(txtProcessorClockSpeed.Text)
            w.WriteLine()
            w.WriteLine("Data Width")
            w.WriteLine(txtProcessorDataWidth.Text)
            w.WriteLine()
            w.WriteLine("Ext Clock")
            w.WriteLine(txtProcessorExtClock.Text)
            w.WriteLine()
            w.WriteLine("Family")
            w.WriteLine(txtProcessorFamily.Text)
            w.WriteLine()
            w.WriteLine("****** MotherBoard Information *****")
            w.WriteLine()
            w.WriteLine("Name")
            w.WriteLine(txtBoardDescription.Text)
            w.WriteLine()
            w.WriteLine("Manufacturer")
            w.WriteLine(txtBoardManufacturer.Text)
            w.WriteLine()
            w.WriteLine("Description")
            w.WriteLine(txtBoardDescription.Text)
            w.WriteLine()
            w.WriteLine("Serial Number")
            w.WriteLine(txtBoardSerialNumber.Text)
            w.Flush()
            w.Close()
            With SaveFileDialog1
                .AddExtension = True
                .OverwritePrompt = True
                .DefaultExt = "txt"
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .FileName = "SystemInfo"
                .Filter = "Text files (*.txt)|*.txt|All files|*.*"
                .FilterIndex = 1
                .Title = "SystemInfo - Save file"
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.MoveFile("temp.txt", .FileName, True)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
