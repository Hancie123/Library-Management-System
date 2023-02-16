Public Class frmMain

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Notepad.exe")
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskManagerToolStripMenuItem.Click
        System.Diagnostics.Process.Start("TaskMgr.exe")
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSWordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("WinWord.exe")
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordpadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Wordpad.exe")
    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemInfoToolStripMenuItem.Click
        frmSystemInfo.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        frmStudent.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        frmAbout.Hide()
        frmSystemInfo.Hide()
        frmStudent.Hide()
        frmBookIssue.Hide()
        frmBookReturn.Hide()
        frmBookEntry.Hide()
        frmStudent.Hide()
        frmBookReturn.Hide()
        frmCourse.Hide()
        frmStaff.Hide()
        frmSupplier.Hide()
        frmRegistration.Hide()
        frmLoginDetails.Hide()
        frmBookRecord.Hide()
        frmDepartment.Hide()
        frmYears.Hide()
        frmJournalsMagzinesRecord1.Hide()
        frmStudentRecord1.Hide()
        frmStaffRecord1.Hide()
        frmNewsPaper.Hide()
        frmNewsPaperRecord1.Hide()
        frmProjectRecord1.Hide()
        frmBookIssueRecord1.Hide()
        frmBookIssueRecord_Staff1.Hide()
        frmSupplierRecord.Hide()
        frmStudentList.Hide()
        frmStudentListRecord1.Hide()
        frmBookIssueRecord1.Hide()
        frmBookIssueRecord_Staff1.Hide()
        frmBookReturnRecord_Student1.Hide()
        frmBookReturnRecord_Staff1.Hide()
        frmCards.Hide()
        frmStudentsCardRecord.Hide()
        frmStaffCardRecord.Hide()
        frmNoDues.Hide()
        frmStudentsNoDuesdRecord.Hide()
        frmStaffsNoDuesRecord.Hide()
        Frmlogin.Show()
        Frmlogin.cmbUserType.Text = ""
        Frmlogin.txtUsername.Text = ""
        Frmlogin.txtPassword.Text = ""
        Frmlogin.ProgressBar1.Visible = False
        Frmlogin.cmbUserType.Focus()
    End Sub

    Private Sub IssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueToolStripMenuItem.Click
        frmBookIssue.Show()
    End Sub

    Private Sub BookReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookReturnToolStripMenuItem.Click
        frmBookReturn.Show()
    End Sub

    Private Sub BooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem.Click
        frmBookEntry.Show()
    End Sub

    Private Sub BooksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem1.Click
        frmBookEntry.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem1.Click
        frmStudent.Show()
    End Sub

    Private Sub BooksReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksReturnToolStripMenuItem.Click
        frmBookReturn.Show()
    End Sub

    Private Sub BooksIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksIssueToolStripMenuItem.Click
        frmBookIssue.Show()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        frmCourse.Show()
    End Sub

    Private Sub FacultiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultiesToolStripMenuItem1.Click
        frmStaff.Show()
    End Sub
    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        frmSupplier.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem1.Click
        frmRegistration.Show()
    End Sub

    Private Sub LoginDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginDetailsToolStripMenuItem.Click
        frmLoginDetails.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem.Click
        frmRegistration.Show()
    End Sub

    Private Sub FacultiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultiesToolStripMenuItem.Click
        frmStaff.Show()
    End Sub

    Private Sub SearchToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem1.Click
        frmBookRecord.Show()

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        frmDepartment.Show()
    End Sub

    Private Sub MasterEntryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterEntryToolStripMenuItem2.Click
        frmBookRecord.Show()
    End Sub

    Private Sub YearsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearsToolStripMenuItem.Click
        frmYears.Show()
    End Sub

    Private Sub JournalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalsToolStripMenuItem.Click
        frmJournalsAndMagzines.Show()
    End Sub

    Private Sub JournalsAndMagzinesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalsAndMagzinesToolStripMenuItem.Click
        frmJournalsMagzinesRecord1.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem3.Click
        frmStudentRecord1.Show()
    End Sub

    Private Sub FacultiesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultiesToolStripMenuItem3.Click
        frmStaffRecord1.Show()
    End Sub

    Private Sub NewPapersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPapersToolStripMenuItem.Click
        frmNewsPaper.Show()
    End Sub

    Private Sub BooksToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem4.Click
        frmNewsPaperRecord1.Show()
        frmNewsPaperRecord1.Reset()
    End Sub

    Private Sub SubscriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubscriptionToolStripMenuItem.Click
        frmProject.Show()
    End Sub

    Private Sub ProjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectsToolStripMenuItem.Click
        frmProjectRecord1.Show()
        frmProjectRecord1.Reset()
    End Sub

    Private Sub StudentsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem2.Click
        frmBookIssueRecord1.Show()
        frmBookIssueRecord1.Reset()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        frmBookIssueRecord_Staff1.Show()
        frmBookIssueRecord_Staff1.Reset()
    End Sub

    Private Sub SuppliersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem1.Click
        frmSupplierRecord.Show()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentListToolStripMenuItem.Click
        frmStudentList.Show()
    End Sub

    Private Sub StudentsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsListToolStripMenuItem.Click
        frmStudentListRecord1.Show()
        frmStudentListRecord1.Reset()
    End Sub

    Private Sub StudentsToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem5.Click
        frmBookIssueRecord1.Show()
        frmBookIssueRecord1.Reset()
    End Sub

    Private Sub StaffsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffsToolStripMenuItem.Click
        frmBookIssueRecord_Staff1.Show()
        frmBookIssueRecord_Staff1.Reset()
    End Sub

    Private Sub StudentsToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem6.Click
        frmBookReturnRecord_Student1.Show()
        frmBookReturnRecord_Student1.Reset()
    End Sub

    Private Sub StaffsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffsToolStripMenuItem1.Click
        frmBookReturnRecord_Staff1.Show()
        frmBookReturnRecord_Staff1.Reset()
    End Sub

    Private Sub CardsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardsToolStripMenuItem.Click
        frmCards.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem7.Click
        frmStudentsCardRecord.Show()
    End Sub

    Private Sub StaffToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem2.Click
        frmStaffCardRecord.Show()
    End Sub

    Private Sub NoDuesDocToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoDuesDocToolStripMenuItem.Click
        frmNoDues.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem8.Click
        frmStudentsNoDuesdRecord.Show()
    End Sub

    Private Sub StaffToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem3.Click
        frmStaffsNoDuesRecord.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
