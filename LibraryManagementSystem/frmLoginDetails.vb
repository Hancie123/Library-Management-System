Imports System.Data.OleDB
Public Class frmLoginDetails
    Dim rdr As OleDbDataReader = Nothing
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_DB.accdb;Persist Security Info=False;"

    Private Sub frmLoginDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT Username,Usertype,User_password from Registration order by JoiningDate", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (rdr.Read() = True)
                DataGridView1.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class